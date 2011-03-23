﻿//***********************************************************************
// Assembly         : FanartHandler
// Author           : cul8er
// Created          : 05-09-2010
//
// Last Modified By : cul8er
// Last Modified On : 10-05-2010
// Description      : 
//
// Copyright        : Open Source software licensed under the GNU/GPL agreement.
//***********************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using NLog;
using MediaPortal.Configuration;
using MediaPortal.GUI.Library;
using MediaPortal.Util;
using MediaPortal.Music.Database;
using MediaPortal.Player;
using MediaPortal.Playlists;
using MediaPortal.Plugins.MovingPictures;
using MediaPortal.Plugins.MovingPictures.Database;
using MediaPortal.Plugins.MovingPictures.MainUI;
using Cornerstone.Database;
using Cornerstone.Database.Tables;
using TvDatabase;
using ForTheRecord.Entities;
using ForTheRecord.ServiceAgents;
using ForTheRecord.ServiceContracts;
using ForTheRecord.UI.Process.Recordings;
using WindowPlugins.GUITVSeries;
using System.Globalization;


namespace FanartHandler
{
    public static class UtilsLatestTVRecordings 
    {
        #region declarations
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private static bool _isGetTypeRunningOnThisThread/* = false*/;
        #endregion

        public static bool IsGetTypeRunningOnThisThread
        {
            get { return UtilsLatestTVRecordings._isGetTypeRunningOnThisThread; }
            set { UtilsLatestTVRecordings._isGetTypeRunningOnThisThread = value; }
        }        

        public static LatestsCollection GetTVRecordings()
        {
            LatestsCollection result = new LatestsCollection();
            LatestsCollection latests = new LatestsCollection();
            try
            {
                IList<TvDatabase.Recording> recordings = TvDatabase.Recording.ListAll();
                int x = 0;
                foreach (TvDatabase.Recording rec in recordings)
                {
                    string thumbNail = string.Format(CultureInfo.CurrentCulture, "{0}\\{1}{2}", Thumbs.TVRecorded,
                                                 Path.ChangeExtension(MediaPortal.Util.Utils.SplitFilename(rec.FileName), null),
                                                 MediaPortal.Util.Utils.GetThumbExtension());
                    thumbNail = thumbNail.Replace(".jpg", "L.jpg");
                    latests.Add(new Latest(rec.StartTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture), thumbNail, null, rec.Title, null, null, null, rec.Genre, null, null, null, null, null, null, null, null, null, null, null));
                }
                latests.Sort(new LatestAddedComparer());
                for (int x0 = 0; x0 < latests.Count; x0++)
                {
                    latests[x0].DateAdded = latests[x0].DateAdded.Substring(0, 10);
                    result.Add(latests[x0]);
                    x++;
                    if (x == 3)
                    {
                        break;
                    }
                }
                if (latests != null)
                {
                    latests.Clear();
                }
                latests = null;
            }
            catch //(Exception ex)
            {
                if (latests != null)
                {
                    latests.Clear();
                }
                latests = null;
                //logger.Error("GetTVRecordings: " + ex.ToString());
            }
            return result;
        }

        class LatestAddedComparer : IComparer<Latest>
        {
            public int Compare(Latest latest1, Latest latest2)
            {
                int returnValue = 1;
                if (latest1 is Latest && latest2 is Latest)
                {
                    returnValue = latest2.DateAdded.CompareTo(latest1.DateAdded);
                }

                return returnValue;
            }
        }

    }




}