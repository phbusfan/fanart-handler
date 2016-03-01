

# Introduction #
Fanart Handler is a plugin for [MediaPortal (MP)](http://www.team-mediaportal.com/). The plugin has two main purposes;
  * Search and download music fanart (scrape) from the [htbackdrops](http://htbackdrops.com/) site.
    1. for all artists stored in your MP music database.
    1. for any artist currently being played (on the fly).

  * Push fanart that you store on your local harddrive to the current used MP skin.
    1. push fanart for now played music
    1. push fanart for selected music or movie
    1. push random images from selected folders

This is the end user guide to the "FanartHandler" plugin.

The scope of this plugin is to;
  1. scrape htbackdrops site for music fanart for all artists stored in your MP music database.
  1. scrape htbackdrops site for music fanart for currently played artist.
  1. push music fanart for now played music track (artist images)
  1. push music fanart for browsed music artists
  1. push movie fanart for browsed video titles
  1. push scorecenter fanart for browsed category in myScoreCenter plugin
  1. push cycling fanart from the following folders for use anywhere in a skin for
    * `thumbs\MovingPictures\Backdrops\FullSize`
    * `thumbs\Fan Art\fanart\original`
    * `thumbs\Skin Fanart\UserDef\games`
    * `thumbs\Skin Fanart\UserDef\movies`
    * `thumbs\Skin Fanart\UserDef\music`
    * `thumbs\Skin Fanart\UserDef\pictures`
    * `thumbs\Skin Fanart\UserDef\plugins`
    * `thumbs\Skin Fanart\UserDef\scorecenter`
    * `thumbs\Skin Fanart\UserDef\tv`
    * `thumbs\Skin Fanart\Scraper\movies`
    * `thumbs\Skin Fanart\Scraper\music`

## Requirements ##
  * MediaPortal 1.1 or later
  * Fanart Handler Plugin
  * A skin that supports the Fanart Handler.
**NOTE** This plugin only supports JPG images.


---


# Add Your Own Custom Fanart (Backdrops) To Be Used In The Skin #
To add you fanart (backdrops) that you yourself has downloaded or made to be used by the fanart handler plugin you should use these folders
  1. thumbs\Skin Fanart\UserDef\games (used for pushing random game images to a skin)
  1. thumbs\Skin Fanart\UserDef\movies (used for pushing random movie images to a skin)
  1. thumbs\Skin Fanart\UserDef\music (used for pushing random music images to a skin)
  1. thumbs\Skin Fanart\UserDef\pictures (used for pushing random picture images to a skin)
  1. thumbs\Skin Fanart\UserDef\plugins (used for pushing random plugins images to a skin)
  1. thumbs\Skin Fanart\UserDef\scorecenter (used for pushing images of selected genre in the scorecenter plugin to a skin).
  1. thumbs\Skin Fanart\UserDef\tv (used for pushing random tv images to a skin)
  1. thumbs\Skin Fanart\UserDef\movies (used for providing fanart for now played title or selected title in your movie library)
  1. thumbs\Skin Fanart\UserDef\music (used for providing fanart for now played artist or selected artist in your music library)

The **thumbs** folder, or directory, is located in;
  1. Windows Vista: `C:\ProgramData\Team MediaPortal\MediaPortal\`
  1. Windows XP: `C:\Documents and Settings\All Users\Application Data\Team MediaPortal\MediaPortal\`
You can find this folder by clicking Start button in Windows and the "`Programs\Team MediaPortal\MediaPortal\User Files`".


## Naming Convention for your custom fanart ##
If you add music or video fanart that you want the skin to use when you select a video or music (or play music) you should use the following naming convention. If the current played artist in MP is Madonna that will be matched in the fanart folder with any image that starts with "madonna", followed by numbers and a file extenstion. This means a file named "madonna1.jpg" will be a match. And Madonna010.jpg will be a match. However, a file named "This Is A Madonna Image.jpg" will not be a match, and a file named madoXnna.jpg will not be a match.

### Supported naming convention for id3 artist tag for multiple artist support ###
To get fanart for music that has two or more artists the artist names in the id3 tag need to be separated by semicolon(s).

Example;
Madonna;Blur


---


# Configuration #
  1. Open MP Configuration
  1. Click on Plugins
  1. Scroll all the way down in the list of plugins and under the headline Process Plugins you will find a plugin called Fanart Handler. Right click in this plugin and make sure it is enabled.
  1. Right click on the plugin again and this time choose configuration.
  1. You will now see a small dialog window that looks like in the picture below.

![http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin.jpg](http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin.jpg)

## General Options ##
### Minimum Resolution For Images ###
Select the  minimum image resolution (quality) you want for fanart/backdrops/thumbs. Setting this to "0x0" will allow all images. If you have enabled "MP Artist Thumbs"
or "MP Album Thumbs" you may want to leave this to "400x400" (because most of these thumbs are below "600x600" in resolution).

### Show Each Image For ###
Select the number of seconds each image will be displayed before trying to switch to next image for selected or played artist (or next randomg image or next selected move and so on).


---


## Music Fanart ##
![http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin1.jpg](http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin1.jpg)
## Fanart Settings ##
<br>
<h3>Music Fanart Options</h3>
<b>Select Music Fanart Sources - MP Artist Thumbs</b><br>
Check this option if you want the artist thumbnail images that MediaPortal automatically downloads for an artist to be used when you select a music artist/album/track in MediaPortal. These images are often in low resolution (=bad quality) but setting the "Minimum Resolution For Images" option can solve this problem.<br>
<br>
<b>Select Music Fanart Sources - MP Album Thumbs</b><br>
Check this option if you want the album thumbnail images that MediaPortal automatically downloads for an albun to be used when you select a music artist/album/track in MediaPortal. These images are often in low resolution (=bad quality) but setting the  "Minimum Resolution For Images" option can solve this problem.<br>
<br>
<b>Select Music Fanart Sources - Music Fanart Matches (High Resolution)</b><br>
Check this option if you want the fanart/backdrop images that you have donwloaded/created and put in the "/thumbs/Skin Fanart/music" folder or the fanart/backdrops that this plugin downloads (if scraper is enabled) to be used when you select a music artist/album/track in MediaPortal. Enabling this option is recommended.<br>
<br>
<b>Select Music Fanart Sources - Skip MP Thumbs When High Resolution Fanart Available</b><br>
Check this option if you do not want to display the MP thumb images for artists that have high resolution fanart. For artists missing high resolution fanart the MP thumb images will still be shown.<br>
<br>
<b>Select Music Fanart Sources - Skip MP Thumbs When Displaying Random Fanart</b><br>
Check this opton if you have enabled the option "MP Artist Thumbs" or "MP Album Thumbs" above but do not want these images available when a skin displays random images as backdrops. For example when selecting a menu like pictures. This option exists because some may think that artist thumbs are of good enough quality when browsing the music collection but not good enough when displaying random music images for their music menu.<br>
<br>
<b>Use Fanart In Music (Now Playing) Overlay - Use Fanart In Overlay</b><br>
This option enables music fanart as background in the music overlay (now playing window) in MediaPortal, if your current skin supports it.<br>
<br>
<h3>Default Backdrop When Fanart Not Available</h3>
<b>Use Specific Image When Music Fanart Is Not Available</b><br>
Check this option to select a specific image that will be displayed if fanart is not available for the current artist.<br>
<br>
<b>Use Folder When Music Fanart Is Not Available</b><br>
Check this option to select a folder containing one or several images that will be displayed if fanart is not available for the current artist.<br>
<br>
<h3>Music Plugin Fanart Option</h3>
<b>Enable Fanart For Selected Items</b><br>
Check this option to enable fanart for selected items anywhere in a skin when browsing your music collection. Like in myMusic plugin, music playlist, Music Videos or Last FM. Checking this option is highly recommended.<br>
<br>
<h2>Scraper Settings</h2>
<img src='http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin2.jpg' />

<h3>Scraper Options</h3>
<b>Enable Automatic Download Of Music Fanart For Artists In Your MP Music Database</b><br>
Check this option if you want this plugin to automatically search the internet site www.htbackdrops.com for fanart backdrops matching all the artists that you have already in your MediaPortal music database and then downloading the found images to your  harddrive (to the <code>thumbs/Skin Fanart/music</code> folder). Leaving this option unchecked will disable scraping and you will have to manually add your fanart images to the <code>thumbs/Skin Fanart/music</code> folder.<br>
<br>
Warning; Using this option if you have a large music collection can use quite alot of harddisk space.<br>
<br>
<b>Enable Automatic Download Of Music Fanart For Artists Now Being Played</b><br>
Check this option if you want this plugin to automatically search the internet site www.htbackdrops.com for fanart backdrops matching every song you play in MediaPortal and then downloading the found images to your harddrive (to the <code>thumbs/Skin Fanart/music</code>
folder). Leaving this option unchecked will disable now playing scraping and you will have to manually add your fanart images to the <code>thumbs/Skin Fanart/music</code> folder.<br>
<br>
Warning; Using this option if you have a large music<br>
collection can use quite alot of harddisk space.<br>
<br>
<b>Download Max X Images Per Artist</b><br>
Choose how many images the scraper will try to download for every artist. Choosing a higher number will consume more harddisk space.<br>
<br>
<b>Scraper Interval X (Hours)</b><br>
Select the  number of hours between each new scraper attempt.<br>
<br>
<h2>Manage Fanart</h2>
<img src='http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin3.jpg' />

<h3>Enable/Disable Selected Fanart Button</h3>
Press this button to enable or disable the use of the selected fanart backdrop. Enabled means that the image will be used by the plugin in MediaPortal. Disabled means that MediaPortal will not use the image. The difference between pressing this button and the "Delete Selected Fanart" is that this button keeps the image on your harddrive and also in the fanart database. This also means that the scraper will NOT download it again. Pressing the delete button will delete the image but it can re-appear because the scraper can find the image on a future scrape.<br>
<br>
<h3>Delete Selected Fanart Button</h3>
Press this button to delete the selected fanart backdrop from the fanart database but also from your harddrive. The difference between pressing this button and the "Enable/Disable Selected Fanart" button is that this button deletes the image from your harddrive and the fanart database. This saves harddisk space but the image can re-appear because the scraper can find the image on a future scrape.<br>
<br>
<h3>Delete All Fanart Button</h3>
WARNING: Pressing this button will delete all images stored on your harddrive in the <code>thumbs/Skin Fanart/music</code> folder and also from the fanart database.<br>
<br>
<br>
<h3>Cleanup Missing Fanart Button</h3>
Press this button to sync the fanart database and images on your harddrive. Any entries in the fanart database that do not have a matching image stored on your harddrive will be removed.<br>
<br>
<br>
<h3>Reset Scraper Button</h3>
The purpose of this button is to reset everything and allow for a complete new initial scrape. The first time you open MediaPortal after enabling the scraper<br>
will cause a big search for fanart matching every artist you have in your MediaPortal music database. This is only done once.<br>
<br>
After this MediaPortal will perorm this "initial scrape" only for<br>
newly added artists. If, at a later stage, you decide that you want to increase the number of imges per artist, you will have to press this button to initiate a new intitial scrape the next time you start MediaPortal. After the initial scrape this plugin will only scrape the !htbackdrop site for new images.<br>
<br>
<h3>Start Scraper Button</h3>
Initiates a new scrape.<br>
<br>
<hr />
<h2>Video Fanart</h2>
<img src='http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin4.jpg' />
<h3>Video Plugin Fanart Option</h3>
<b>Enable Fanart For Selected Items</b><br>
Check this option to enable fanart for selected items when browsing your movies using the myVideos plugin.<br>
<br>
<br>
<hr />
<h2>ScoreCenter Fanart</h2>
<img src='http://x-factor.googlecode.com/svn/wiki/img/xfactorfanarthandler_plugin5.jpg' />
<h3>ScoreCenter Plugin Fanart Option</h3>
<b>Enable Fanart For Selected Genres</b><br>
Check this option to enable fanart for selected genres when browsing your sports results in the myScoreCenter plugin.  Note: make sure you have not enabled fanart/backdrops in the Scorecenter plugin itself, or you may get duplicate images displaying.<br>
<br>
<br>
<hr />
<h2>Disable Fanart for Music</h2>
<ol><li>Open MP Configuration<br>
</li><li>Click on Plugins<br>
</li><li>Scroll all the way down in the list of plugins and under the headline Process Plugins you will find a plugin called Fanart Handler. Right click in this plugin and make sure it is disabled.<br>
<hr />