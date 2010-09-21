﻿//-----------------------------------------------------------------------
// Open Source software licensed under the GNU/GPL agreement.
// 
// Author: Cul8er
//-----------------------------------------------------------------------

namespace FanartHandler
{
    using MediaPortal.Configuration;
    using MediaPortal.GUI.Library;
    using MediaPortal.Music.Database;
    using MediaPortal.Player;
    using MediaPortal.Services;
    using MediaPortal.TagReader;    
    using NLog;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    
    using System.Collections;
    
    /// <summary>
    /// Class handling fanart for selected items in MP.
    /// </summary>
    public class FanartSelected
    {
        #region declarations
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Hashtable windowsUsingFanartSelected; //used to know what skin files that supports selected fanart        
        private bool doShowImageOne = true;  // Decides if property .1 or .2 should be set on next run                        
        private bool hasUpdatedCurrCount = false; // CurrCount have allready been updated this run                        
        private bool fanartAvailable = false;  //Holds if fanart is available (found) or not, controls visibility tag                
        private int updateVisibilityCount = 0;        
        public string currSelectedMovieTitle = null;
        public string currSelectedMusicArtist = null;
        private string currSelectedScorecenterGenre = null;        
        private string tmpImage = Config.GetFolder(Config.Dir.Thumbs) + @"\Skin FanArt\transparent.png";
        public int prevSelectedGeneric = 0;
        public int prevSelectedMusic = 0;
        public int prevSelectedScorecenter = 0;
        public string currSelectedMovie = null;
        public string currSelectedMusic = null;
        public string currSelectedScorecenter = null;
        public ArrayList listSelectedMovies = null;
        public ArrayList listSelectedMusic = null;
        public ArrayList listSelectedScorecenter = null;
        private int currCount = 0;
        private Hashtable properties; //used to hold properties to be updated (Selected or Any)                                    
        private Hashtable currentArtistsImageNames = null;        
        #endregion

        public Hashtable CurrentArtistsImageNames
        {
            get { return currentArtistsImageNames; }
            set { currentArtistsImageNames = value; }
        }

        public Hashtable Properties
        {
            get { return properties; }
            set { properties = value; }
        }

        public int CurrCount
        {
            get { return currCount; }
            set { currCount = value; }
        }

        public string CurrSelectedScorecenterGenre
        {
            get { return currSelectedScorecenterGenre; }
            set { currSelectedScorecenterGenre = value; }
        }

        public int UpdateVisibilityCount
        {
            get { return updateVisibilityCount; }
            set { updateVisibilityCount = value; }
        }

        public bool FanartAvailable
        {
            get { return fanartAvailable; }
            set { fanartAvailable = value; }
        }

        public bool HasUpdatedCurrCount
        {
            get { return hasUpdatedCurrCount; }
            set { hasUpdatedCurrCount = value; }
        }

        public bool DoShowImageOne
        {
            get { return doShowImageOne; }
            set { doShowImageOne = value; }
        }

        public Hashtable WindowsUsingFanartSelected
        {
            get { return windowsUsingFanartSelected; }
            set { windowsUsingFanartSelected = value; }
        }

        public FanartSelected()
        {
            currentArtistsImageNames = new Hashtable();
        }

        /// <summary>
        /// Get Hashtable with all filenames for current artist
        /// </summary>
        public Hashtable GetCurrentArtistsImageNames()
        {
            return CurrentArtistsImageNames;
        }

        /// <summary>
        /// Set Hashtable with all filenames for current artist
        /// </summary>
        public void SetCurrentArtistsImageNames(Hashtable ht)
        {
            CurrentArtistsImageNames = ht;
        }

        /// <summary>
        /// Get and set properties for selected video title
        /// </summary>
        public void RefreshGenericSelectedProperties(string property, ref ArrayList listSelectedGeneric, string type, ref string currSelectedGeneric, ref string currSelectedGenericTitle)
        {
            try
            {
                bool isMusic = false;
                if (property.Equals("music"))
                {
                    isMusic = true;
                }

                if (GUIWindowManager.ActiveWindow == 6623)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#mvids.artist");
                }
                else if (GUIWindowManager.ActiveWindow == 759)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#TV.RecordedTV.Title");
                }
                else if (GUIWindowManager.ActiveWindow == 1)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#TV.View.title");
                }
                else if (GUIWindowManager.ActiveWindow == 600)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#TV.Guide.Title");
                }
                else if (GUIWindowManager.ActiveWindow == 880)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#MusicVids.ArtistName");
                }
                else if (GUIWindowManager.ActiveWindow == 510)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#artist");
                }
                else if (GUIWindowManager.ActiveWindow == 35)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#Play.Current.Title");
                }
                else if (GUIWindowManager.ActiveWindow == 6622)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#selecteditem2");
                }
/*                else if (GUIWindowManager.ActiveWindow == 730716)
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#selecteditem2");
                }                    */
                else
                {
                    FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#selecteditem");
                }
                if (FanartHandlerSetup.SelectedItem != null && FanartHandlerSetup.SelectedItem.Trim().Length > 0)
                {
                    if ((GUIWindowManager.ActiveWindow == 4755 && GUIWindowManager.GetWindow(4755).GetControl(51).IsVisible) || ((GUIWindowManager.ActiveWindow == 6 || GUIWindowManager.ActiveWindow == 25) && FanartHandlerSetup.SelectedItem.Equals("..") == true))
                    {
                        //online videos or myvideo, do not update if in details view                        
                    }
                    else
                    {
                        if (type.Equals("Global Search") || type.Equals("mVids") || type.Equals("Youtube.FM") || type.Equals("Music Playlist") || type.Equals("Music Trivia"))
                        {
                            FanartHandlerSetup.SelectedItem = Utils.GetArtistLeftOfMinusSign(FanartHandlerSetup.SelectedItem);
                        }
                        if (currSelectedGenericTitle.Equals(FanartHandlerSetup.SelectedItem) == false)
                        {
                            currSelectedGeneric = String.Empty;
                            prevSelectedGeneric = -1;
                            SetCurrentArtistsImageNames(null);
                            UpdateVisibilityCount = 0;
                            string sFilename = FanartHandlerSetup.GetFilename(FanartHandlerSetup.SelectedItem, ref currSelectedGeneric, ref prevSelectedGeneric, type, "FanartSelected", true, isMusic);
                            if (sFilename.Length == 0)
                            {
                                if (property.Equals("music"))
                                {
                                    sFilename = FanartHandlerSetup.GetRandomDefaultBackdrop(ref currSelectedGeneric, ref prevSelectedGeneric);
                                    if (sFilename.Length == 0)
                                    {
                                        FanartAvailable = false;
                                    }
                                    else
                                    {
                                        FanartAvailable = true;
                                        currSelectedGeneric = sFilename;
                                    }
                                }
                                else
                                {
                                    FanartAvailable = false;
                                }
                            }
                            else
                            {
                                FanartAvailable = true;
                            }
                            if (DoShowImageOne)
                            {
                                AddProperty("#fanarthandler." + property + ".backdrop1.selected", sFilename, ref listSelectedGeneric, type);
                            }
                            else
                            {
                                AddProperty("#fanarthandler." + property + ".backdrop2.selected", sFilename, ref listSelectedGeneric, type);
                            }
                            currSelectedGenericTitle = FanartHandlerSetup.SelectedItem;
                            ResetCurrCount();
                        }
                        else if (CurrCount >= FanartHandlerSetup.MaxCountImage)
                        {                            
                            string sFilenamePrev = currSelectedGeneric;
                            string sFilename = FanartHandlerSetup.GetFilename(FanartHandlerSetup.SelectedItem, ref currSelectedGeneric, ref prevSelectedGeneric, type, "FanartSelected", false, isMusic);
                            if (sFilename.Length == 0)
                            {
                                if (property.Equals("music"))
                                {
                                    sFilename = FanartHandlerSetup.GetRandomDefaultBackdrop(ref currSelectedGeneric, ref prevSelectedGeneric);
                                    if (sFilename.Length == 0)
                                    {
                                        FanartAvailable = false;
                                    }
                                    else
                                    {
                                        FanartAvailable = true;
                                        currSelectedGeneric = sFilename;
                                    }
                                }
                                else
                                {
                                    FanartAvailable = false;
                                }
                            }
                            else
                            {
                                FanartAvailable = true;
                            }
                            if (DoShowImageOne)
                            {
                                AddProperty("#fanarthandler." + property + ".backdrop1.selected", sFilename, ref listSelectedGeneric, type);
                            }
                            else
                            {
                                AddProperty("#fanarthandler." + property + ".backdrop2.selected", sFilename, ref listSelectedGeneric, type);
                            }
                            currSelectedGenericTitle = FanartHandlerSetup.SelectedItem;
                            if ((sFilename.Length == 0) || (sFilename.Equals(sFilenamePrev) == false))
                            {
                                ResetCurrCount();
                            }
                        }
                        IncreaseCurrCount();
                    }
                }
                else if ((GUIWindowManager.ActiveWindow == 4755 && GUIWindowManager.GetWindow(4755).GetControl(51).IsVisible) || ((GUIWindowManager.ActiveWindow == 6 || GUIWindowManager.ActiveWindow == 25) && FanartHandlerSetup.SelectedItem.Equals("..") == true))
                {
                    //online videos or myvideo, do not update if in details view
                }
                else
                {
                    currSelectedGeneric = String.Empty;
                    prevSelectedGeneric = -1;
                    FanartAvailable = false;
                    if (DoShowImageOne)
                        AddProperty("#fanarthandler." + property + ".backdrop1.selected", tmpImage, ref listSelectedMusic, type);
                    else
                        AddProperty("#fanarthandler." + property + ".backdrop2.selected", tmpImage, ref listSelectedMusic, type);
                    ResetCurrCount();
                    currSelectedGenericTitle = String.Empty;
                    SetCurrentArtistsImageNames(null);
                }
            }
            catch (Exception ex)
            {
                logger.Error("RefreshGenericSelectedProperties: " + ex.ToString());
            }
        }

        /// <summary>
        /// Increase interval counter 
        /// </summary>
        private void IncreaseCurrCount()
        {
            if (HasUpdatedCurrCount == false)
            {
                CurrCount = CurrCount + 1;
                HasUpdatedCurrCount = true;
            }
        }

        /// <summary>
        /// Reset count and trigger change of image (.1 and .2)
        /// </summary>
        public void ResetCurrCount()
        {
            CurrCount = 0;
            UpdateVisibilityCount = 1;
            HasUpdatedCurrCount = true;
        }


        /// <summary>
        /// Get and set properties for selected scorecenter title
        /// </summary>
        public void RefreshScorecenterSelectedProperties()
        {
            try
            {
                FanartHandlerSetup.SelectedItem = GUIPropertyManager.GetProperty("#ScoreCenter.Category");
                if (FanartHandlerSetup.SelectedItem != null && FanartHandlerSetup.SelectedItem.Equals("..") == false && FanartHandlerSetup.SelectedItem.Trim().Length > 0)
                {
                    if (CurrSelectedScorecenterGenre.Equals(FanartHandlerSetup.SelectedItem) == false)
                    {
                        currSelectedScorecenter = String.Empty;
                        prevSelectedScorecenter = -1;
                        UpdateVisibilityCount = 0;
                        SetCurrentArtistsImageNames(null);
                        string sFilename = FanartHandlerSetup.GetFilename(FanartHandlerSetup.SelectedItem, ref currSelectedScorecenter, ref prevSelectedScorecenter, "ScoreCenter", "FanartSelected", true, false);
                        if (sFilename.Length == 0)
                        {
                            FanartAvailable = false;
                        }
                        else
                        {
                            FanartAvailable = true;
                            currSelectedScorecenter = sFilename;
                        }
                        if (DoShowImageOne)
                        {
                            AddProperty("#fanarthandler.scorecenter.backdrop1.selected", sFilename, ref listSelectedScorecenter, "ScoreCenter");
                        }
                        else
                        {
                            AddProperty("#fanarthandler.scorecenter.backdrop2.selected", sFilename, ref listSelectedScorecenter, "ScoreCenter");
                        }
                        CurrSelectedScorecenterGenre = FanartHandlerSetup.SelectedItem;
                        ResetCurrCount();
                    }
                    else if (CurrCount >= FanartHandlerSetup.MaxCountImage)
                    {
                        string sFilenamePrev = currSelectedScorecenter;
                        string sFilename = FanartHandlerSetup.GetFilename(FanartHandlerSetup.SelectedItem, ref currSelectedScorecenter, ref prevSelectedScorecenter, "ScoreCenter", "FanartSelected", false, false);
                        if (sFilename.Length == 0)
                        {
                            FanartAvailable = false;
                        }
                        else
                        {
                            FanartAvailable = true;
                            currSelectedScorecenter = sFilename;
                        }
                        if (DoShowImageOne)
                        {
                            AddProperty("#fanarthandler.scorecenter.backdrop1.selected", sFilename, ref listSelectedScorecenter, "ScoreCenter");
                        }
                        else
                        {
                            AddProperty("#fanarthandler.scorecenter.backdrop2.selected", sFilename, ref listSelectedScorecenter, "ScoreCenter");
                        }
                        CurrSelectedScorecenterGenre = FanartHandlerSetup.SelectedItem;
                        if ((sFilename.Length == 0) || (sFilename.Equals(sFilenamePrev) == false))
                        {
                            ResetCurrCount();
                        }
                    }
                    IncreaseCurrCount();
                }
                else
                {
                    currSelectedScorecenter = String.Empty;
                    CurrSelectedScorecenterGenre = String.Empty;
                    prevSelectedScorecenter = -1;
                    SetCurrentArtistsImageNames(null);
                }
            }
            catch (Exception ex)
            {
                logger.Error("RefreshScorecenterSelectedProperties: " + ex.ToString());
            }
        }

        /// <summary>
        /// Try to get artist. 
        /// </summary>
        private string GetMusicArtistFromListControl()
        {
            try
            {
                GUIListItem gli = GUIControl.GetSelectedListItem(GUIWindowManager.ActiveWindow, 50);

                if (gli != null)
                {
                    if (gli.MusicTag == null && gli.Label.Equals(".."))
                    {
                        //on .. entry in listcontrol?                        
                        return "..";
                    }
                    else if (gli.MusicTag == null)
                    {
                        string sArtistName = null;
                        string dbArtistName = null;
                        string currSelectedInList = GUIPropertyManager.GetProperty("#selecteditem");
                        currSelectedInList = Utils.MovePrefixToBack(Utils.RemoveMPArtistPipes(Utils.GetArtistLeftOfMinusSign(currSelectedInList)));
                        ArrayList al = new ArrayList();
                        FanartHandlerSetup.M_Db.GetAllArtists(ref al);
                        for (int i = 0; i < al.Count; i++)
                        {
                            dbArtistName = Utils.MovePrefixToBack(Utils.RemoveMPArtistPipes(al[i].ToString()));
                            if (currSelectedInList.IndexOf(dbArtistName) >= 0)
                            {
                                sArtistName = dbArtistName;
                                break;
                            }
                        }
                        al = null;
                        currSelectedInList = Utils.GetArtistLeftOfMinusSign(GUIPropertyManager.GetProperty("#selecteditem"));
                        if (sArtistName == null)
                        {
                            al = new ArrayList();
                            if (FanartHandlerSetup.M_Db.GetAlbums(3, currSelectedInList, ref al))
                            {
                                AlbumInfo ai = (AlbumInfo)al[0];
                                if (ai != null)
                                {
                                    if (ai.Artist != null && ai.Artist.Length > 0)
                                    {
                                        sArtistName = ai.Artist;
                                    }
                                    else
                                    {
                                        sArtistName = ai.AlbumArtist;
                                    }
                                }
                            }
                        }
                        currSelectedInList = Utils.MovePrefixToBack(Utils.RemoveMPArtistPipes(Utils.GetArtistLeftOfMinusSign(currSelectedInList)));
                        if (sArtistName == null)
                        {
                            al = new ArrayList();
                            if (FanartHandlerSetup.M_Db.GetAlbums(3, currSelectedInList, ref al))
                            {
                                AlbumInfo ai = (AlbumInfo)al[0];
                                if (ai != null)
                                {
                                    if (ai.Artist != null && ai.Artist.Length > 0)
                                    {
                                        sArtistName = ai.Artist;
                                    }
                                    else
                                    {
                                        sArtistName = ai.AlbumArtist;
                                    }
                                }
                            }
                        }
                        al = null;
                        return Utils.MovePrefixToBack(Utils.RemoveMPArtistPipes(sArtistName));
                    }
                    else
                    {
                        //on artist, album or track entry
                        MusicTag tag1 = (MusicTag)gli.MusicTag;
                        if (tag1 != null)
                        {
                            if (tag1.Artist != null && tag1.Artist.Length > 0)
                            {
                                return Utils.MovePrefixToBack(Utils.RemoveMPArtistPipes(tag1.Artist));
                            }
                            else
                            {
                                return Utils.MovePrefixToBack(Utils.RemoveMPArtistPipes(tag1.AlbumArtist));
                            }
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.Error("getMusicArtistFromListControl: " + ex.ToString());
            }
            return null;
        }


        /// <summary>
        /// Get and set properties for selected artis, album or track in myMusicGenres window
        /// </summary>
        public void RefreshMusicSelectedProperties()
        {
            try
            {
                FanartHandlerSetup.SelectedItem = GetMusicArtistFromListControl();
                if (FanartHandlerSetup.SelectedItem != null && FanartHandlerSetup.SelectedItem.Equals("..") == false && FanartHandlerSetup.SelectedItem.Trim().Length > 0)
                {
                    if (currSelectedMusicArtist.Equals(FanartHandlerSetup.SelectedItem) == false)
                    {
                        currSelectedMusic = String.Empty;
                        prevSelectedMusic = -1;
                        UpdateVisibilityCount = 0;
                        SetCurrentArtistsImageNames(null);
                        string sFilename = FanartHandlerSetup.GetFilename(FanartHandlerSetup.SelectedItem, ref currSelectedMusic, ref prevSelectedMusic, "MusicFanart", "FanartSelected", true, true);
                        if (sFilename.Length == 0)
                        {
                            sFilename = FanartHandlerSetup.GetRandomDefaultBackdrop(ref currSelectedMusic, ref prevSelectedMusic);
                            if (sFilename.Length == 0)
                            {
                                FanartAvailable = false;
                            }
                            else
                            {
                                FanartAvailable = true;
                                currSelectedMusic = sFilename;
                            }
                        }
                        else
                        {
                            FanartAvailable = true;
                        }
                        if (DoShowImageOne)
                        {
                            AddProperty("#fanarthandler.music.backdrop1.selected", sFilename, ref listSelectedMusic, "MusicFanart");
                        }
                        else
                        {
                            AddProperty("#fanarthandler.music.backdrop2.selected", sFilename, ref listSelectedMusic, "MusicFanart");
                        }
                        currSelectedMusicArtist = FanartHandlerSetup.SelectedItem;
                        ResetCurrCount();
                    }
                    else if (CurrCount >= FanartHandlerSetup.MaxCountImage)
                    {
                        string sFilenamePrev = currSelectedMusic;
                        string sFilename = FanartHandlerSetup.GetFilename(FanartHandlerSetup.SelectedItem, ref currSelectedMusic, ref prevSelectedMusic, "MusicFanart", "FanartSelected", false, true);
                        if (sFilename.Length == 0)
                        {
                            sFilename = FanartHandlerSetup.GetRandomDefaultBackdrop(ref currSelectedMusic, ref prevSelectedMusic);
                            if (sFilename.Length == 0)
                            {
                                FanartAvailable = false;
                            }
                            else
                            {
                                FanartAvailable = true;
                                currSelectedMusic = sFilename;
                            }
                        }
                        else
                        {
                            FanartAvailable = true;
                        }
                        if (DoShowImageOne)
                        {
                            AddProperty("#fanarthandler.music.backdrop1.selected", sFilename, ref listSelectedMusic, "MusicFanart");
                        }
                        else
                        {
                            AddProperty("#fanarthandler.music.backdrop2.selected", sFilename, ref listSelectedMusic, "MusicFanart");
                        }
                        currSelectedMusicArtist = FanartHandlerSetup.SelectedItem;
                        if ((sFilename.Length == 0) || (sFilename.Equals(sFilenamePrev) == false))
                        {
                            ResetCurrCount();
                        }
                    }
                    IncreaseCurrCount();
                }
                else if (FanartHandlerSetup.SelectedItem != null && FanartHandlerSetup.SelectedItem.Equals(".."))
                {
                    currSelectedMusic = String.Empty;
                    currSelectedMusicArtist = String.Empty;
                }
                else
                {
                    currSelectedMusic = String.Empty;
                    prevSelectedMusic = -1;
                    FanartAvailable = false;
                    if (DoShowImageOne)
                        AddProperty("#fanarthandler.music.backdrop1.selected", tmpImage, ref listSelectedMusic, "MusicFanart");
                    else
                        AddProperty("#fanarthandler.music.backdrop2.selected", tmpImage, ref listSelectedMusic, "MusicFanart");
                    ResetCurrCount();
                    currSelectedMusicArtist = String.Empty;
                    SetCurrentArtistsImageNames(null);
                }
            }
            catch (Exception ex)
            {
                logger.Error("RefreshMusicSelectedProperties: " + ex.ToString());
            }
        }

        /// <summary>
        /// Update skin properties with new images
        /// </summary>
        public void UpdateProperties()
        {
            try
            {
                foreach (DictionaryEntry de in Properties)
                {
                    FanartHandlerSetup.SetProperty(de.Key.ToString(), de.Value.ToString());
                }
                Properties.Clear();
            }
            catch (Exception ex)
            {
                logger.Error("UpdateProperties: " + ex.ToString());
            }
        }

        /// <summary>
        /// Add new images that later will update skin properties
        /// </summary>
        private void AddProperty(string property, string value, ref ArrayList al, string type)
        {
            try
            {
                if (value == null)
                    value = " ";
                if (String.IsNullOrEmpty(value))
                    value = " ";
                if (Properties.Contains(property))
                {
                    Properties[property] = value;
                }
                else
                {
                    Properties.Add(property, value);
                }

                //load images as MP resource
                if (value != null && value.Length > 0)
                {
                    //add new filename to list
                    if (al != null)
                    {
                        if (al.Contains(value) == false)
                        {
                            try
                            {
                                al.Add(value);
                            }
                            catch (Exception ex)
                            {
                                logger.Error("AddProperty: " + ex.ToString());
                            }
                            Utils.LoadImage(value, type);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("AddProperty: " + ex.ToString());
            }
        }

        /// <summary>
        /// Set visibility on dummy controls that is used in skins for deciding if fanart is available
        /// </summary>
        public void FanartIsAvailable(int windowId)
        {
            GUIControl.ShowControl(windowId, 91919293);
        }

        /// <summary>
        /// Set visibility on dummy controls that is used in skins for deciding if fanart is available
        /// </summary>
        public void FanartIsNotAvailable(int windowId)
        {
            GUIControl.HideControl(windowId, 91919293);
        }

        /// <summary>
        /// Set visibility on dummy controls that is used in skins for fading of images
        /// </summary>
        public void ShowImageOne(int windowId)
        {
            GUIControl.ShowControl(windowId, 91919291);
            GUIControl.HideControl(windowId, 91919292);
        }

        /// <summary>
        /// Set visibility on dummy controls that is used in skins for fading of images
        /// </summary>
        public void ShowImageTwo(int windowId)
        {
            GUIControl.ShowControl(windowId, 91919292);
            GUIControl.HideControl(windowId, 91919291);
        }
    }
}