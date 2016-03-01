


---

# Change Logs #
## Change Log (version 2.2.5 to 2.3.0) ##
  * Removed all hanlding of latest media (music, tv, movies, pictures...). This is all handled of the new LatestMediaHandler plugin.
  * Several bug fixes.
## Change Log (version 2.2.4 to 2.2.5) ##
  * Several bug fixes.
## Change Log (version 2.2.3 to 2.2.4) ##
  * New feature: New option in configuration to enable or disable asynchronously loading of random images.
  * New feature: Fanart support in my videos movie info screen (thanks Deda)
  * New feature: New properties to support playing latest recorded tv (4TR or MP)
  * New feature: Now scanning and import of local files are recursively into folders and subfolders.
  * New feature: New properties to "enabled" that can be used to decide if a user have enabled latest media tags
  * New feature: New property for latest pictures. Title.
  * New feature: Configuration has a few new options.
  * New feature: FanartHandler now fully supports adding the fanart handler properties to separete xml files and import. Easier and more maintainable code
  * Bug fixed: Black fanart in some occasions
  * Bug fixed: Artist Thumb filename starts with a 'space' character when downloading thumbs for multi-artists tracks
  * Bug fixed: Speedup of the plugin
  * Bug fixed: Other small fixes and improvements
This is a big change from previous versions. First time you run MP after an upgrade the scraper can run quite some time depending on the settings you have (if you scrape for thumbs for example).
## Change Log (version 2.2.2 to 2.2.3) ##
  * For users that had the 2.2.2 Beta installed the 2.2.2 final version failed to upgrade.
  * Videos with "the" in the movie name failed to parse in FH.
  * Latest Music properties not set and wrongly dependent on external dll files.
  * Music Vidoes no longer working due to wrongly dependent on dll files.
## Change Log (version 2.2.1 to 2.2.2) ##
  * Now playing scrape improved for multiple artists
  * Scraping for new images improved
  * Latest added TVrecordings used low quality thumb, now uses high quality thumb
  * Sometimes low quality artist or album thumb was incorrectly used instead of high quality fanart
  * The folder structure of this plugin has changed. Skin Fanart has got two subfolders called Scraper and UserDef.
  * New property for (#fanarthandler.tvseries.latest1.serieThumb, #fanarthandler.tvseries.latest2.serieThumb and #fanarthandler.tvseries.latest3.serieThumb)
## Change Log (version 2.2 to 2.2.1) ##
  * Various optimizations and code cleanup.
  * Max 4 Images in now plaing scrape restriction now removed
  * bug fixed: DoScrapeNew: System.NullReferenceException
  * bug fixed: Timezone problem (causing missed new images)
  * bug fixed: Start: System.IO.FileNotFoundException
## Change Log (version 2.1.1 to 2.2) ##
  * new feature: htbackdrops have released a new API (new database) and this is the first version of Fanart Handler that supports it.
  * new feature: Scraper  now scrapes artist thumbnails from htbackdrops
  * new feature: Latest added picture, movie, tvseries, tv recordings and music properties available
  * new feature: Moving Picture fanart (random) now respects parental control
  * bug fixed: many small bugs has been fixed (like sraping for new images failed from time to time).
_WARNING\*Because of the new htbackdrop database and API image duplication check will no longer work. The only unique id before was the URL to the image but since this now is changed I have no way of detecting duplicates. New API supports Image IDs and this is now implemented and should assure that future changes to htbackdrops wont affect the fanart handler. If you want to be sure not to get duplicated images the only way is to (from fanart handler configuration) delete all music fanart images (Delete All Fanart button in configuration), reset the scraper (Reset Scraper button in configuration) and finally do a new scrape (Start Scraper button in configuration). If you don't mid duplicates or handles this in the configuration you do not have to to this "reset" step. And, please remember that doing so would cause  alot of load on the htbackdrop site.
## Change Log (version 2.1 to 2.1.1) ##
  * bug fixed: DirectoryNotFoundException is now handled correctly by the plugin
  * bug fixed: Configuration allways checked all local fanart. Now uses timestamps just like the plugin in MP.
  * bug fixed: fanarthandler.org database included in installer was old version, now current
  * bug fixed: Fanart available flag (id: 91919294) was not set properly on end of playback.
## Change Log (version 2.0 to 2.1) ##
  * new feature: Support for fanart in MPGrooveshark plugin
  * bug fixed: small fine tuning and code cleanup
## Change Log (version 1.10 to 2.0) ##
  * new feature: Support for fanart (by using the #fanarthandler.movie.backdrop1.selected and #fanarthandler.movie.backdrop2.selected properties) in TV sections (like tv guide, tv recordings) implemented.
  * new feature: Timestamp handling implemented to make import of local fanart faster
  * bug fixed: Scraping causing huge CPU loads and stutter in MP solved.
  * bug fixed: Resuming from standby or hibernation bug fixed.
  * bug fixed: Bug in how default backdrops where used is fixed
  * bug fixed: The total number of images reported in music fanart overview was wrong, now fixed (in MP configuration).
  * bug fixed: MPE1 bug causing version 1.10 not correctly identified in the new installer solved by versioning this to 2.0
## Change Log (version 1.9 to 1.10) ##
I have made some big changes in how the fanart handler plugin works (optimizations and overall improvements). A big part of the plugin has been re-coded in this release.
  * new feature: Added a delay between fanart selected item changes
  * new feature: Loading of initial tasks (like loading local fanart) are now a separate thing and will not be done as now prior to loading the plugin resulting is faster start of MP.
  * new feature: The "Random Movie" property now only push images from the movie folder (previous version concatenated images from movie, tvseries and moving pictures).
  * bug fixed: Proxy handling redone to fix the issue when users has proxy enabled in fanarthandler even when not behind a proxy. Now this will only prevent fanart  handler from working and does not affect other plugins like online videos and myWeather.
  * bug fixed: SQLite.NET.SQLiteException, ERROR detailed:near "," bug is fixed.
## Change Log (version 1.8 to 1.9) ##
  * improvement: Loading of backdrops improved and fix to support MP animations better included.
  * bug fixed: Improved handling of suspend/resume handling
  * bug fixed: no such table error fixed
  * bug fixed: tvseries fanart not added correctly -> unavailable in onlinevideo is fixed
## Change Log (version 1.7 to 1.8) ##
  * new feature: Support for multi-artist files.
  * new feature: Mouse and Keyboard shortcuts for image management in Configuration.
  * new feature: Show resolution of fanart in manage fanart tab for selected image.
  * new feature: Support for movie fanart in onlinevideos plugin.
  * bug fixed: Fixed issue with "The remote server returned an error: (417)Expectation failed.".
## Change Log (version 1.6 to 1.7) ##
  * bug fixed: Includes optimization in how random images was handled.
  * bug fixed: Plugin now should support standby/hibernation.
## Change Log (version 1.5 to 1.6) ##
  * No new features but the new version includes optimization in how random images was handled. Usage of memory has also gone down due to this optimization.
## Change Log (version 1.4 to 1.5) ##
  * new feature: Manage Video Fanart support.
  * new feature: Manage Scorecenter Fanart support.
  * new feature: Import local fanart in the configuration tool (music, video and scorecenter).
  * bug fixed: Resolution info striped from image name for better matching (some images on htbackdrops ends like **1080P).
  * bug fixed: Database upgrade script failed on very old databases
  * bug fixed: Fading when one image only is now fixed
## Change Log (version 1.3 to 1.4) ##
  * new feature: Basic proxy support.
  * bug fixed: Some character sets was handled wrong causing some fanart not to be downloaded.
  * bug fixed: Corrupt images was created on disk in some situations.
## Change Log (version 1.2 to 1.3) ##
  * new feature: Fanart now also works in shared view in myMusic plugin (where artist,album or track is available).
  * bug fixed: Delay in showing "skin default" backdrop when music played stops.
  * bug fixed: Plugin incorrectly renames several artist names
  * bug fixed: Configuration GUI buggy and sometimes becomes unresponsive during a scrape
  * bug fixed: Max images per artist setting ignored until you restart the program
  * bug fixed: The #fanarthandler.scorecenter.backdrop1.any was never filled with any value
  * bug fixed: Scroll speed in Moving Picture and TVSeries affected by this plugin.
  * bug fixed: Default image deleted when deleting all fanart
  * bug fixed: High CPU load when playing video and using this plugin**

## Change Log (version 1.1 to 1.2) ##
  * bug fixed: artist names using "the" prefix didn't work properly
  * bug fixed: System.Data.ContraintException error
  * bug fixed: GUIWindowManager: Could not find window
  * bug fixed: Crash on scraping
  * bug fixed: Default backdrop should not be stored in the config template
  * bug fixed: Default backdrop supplied with config template pointed to wrong file (.png instead of .jpg)
  * bug fixed: Manage Fanart scrollbar issue and unresponsive GUI
  * bug fixed: Closing configuration now as if you want to save settings_

## Change Log (version 1.0 to 1.1) ##
  * new feature: New Configuration GUI including many, many new options
  * new feature: Scraping indicator in skin, including progress in percent
  * new feature: Added support to display random Scorecentre images
  * bug fixed: Random image contains an apostrophe caused errors in log
  * bug fixed: Jumping to now playing window doesn't cause fanart to update
  * bug fixed: Delete all images in image manager only deletes half at a time
  * bug fixed: Enabling/disabling options in configuration not applied until you save/close and re-open config tool
  * bug fixed: Default backdrop was set to xfactor skin image
  * bug fixed: Fanart preview Image does not always get displayed in 'Management' tab
  * bug fixed: Settings are not saved if you manually enter in values
  * bug fixed: Saving configuration now also shows warning that user also need to press ok in MP configuration to save data
  * bug fixed: Selected artist in playlist is buggy (displaying fanart)
  * bug fixed: Turning circle with a % sign in the middle, but no progress number
  * bug fixed: Several tooltip texts was wrong in configuration
  * bug fixed: Configuration window and it's controls did not rezise when dialog changed size


---

# Installation #
## First Time Installation ##
Just download the MPI file from the Download page (link), double click and the installation is done. Follow the user guide to configure the plugin.

**NOTE!** If you are using latest SVN of MediaPortal you will have to locate the old MPIInstaller in the Mediaportal directory. Start the MPIInstaller and locate the installer file. The reason for this is that SVN version of MP includes the new MPEInstaller that is not compatible with the old one and associated MPI files with it.

## Upgrading (from previous stable version) ##
If you are upgrading from a previous stable version of Fanart Handler (e.g ver 1.0) you do not need to rescrape your fanart.

A lot of bugs have been fixed so you may have some duplicates or wrong artist names in your database. You could just delete these using the Manage Fanart Tab under Music Fanart. However, many new images have been added to htbackdrops lately so you may wish to press the Reset button to get those as well as new images for the ones you delete.

Of course, to get a 'clean' database and ensure all fanart is named correctly, it is recommended to delete all your fanart and rescrape it.

## Installation If You Have A Beta Or Release Candidate Version Already Installed ##
If you have installed A Beta or Release Candidate version of this skin, please follow these steps to install.
  1. copy your fanart in the /thumbs/skin fanart/music to a backup location
  1. delete all fanart in the /thumbs/skin fanart/music folder
  1. copy your /database/fanarthandler.db3 file to a backup location
  1. delete your /database/fanarthandler.db3 file
  1. install the MPI file (link).

**NOTE!** If you are using latest SVN of MediaPortal you will have to locate the old MPIInstaller in the Mediaportal directory. Start the MPIInstaller and locate the installer file. The reason for this is that SVN version of MP includes the new MPEInstaller that is not compatible with the old one and assisiated MPI files with it.

## Uninstall ##
Just run the MPI installer which will remove the files it installed, such as the fanarthandler.dll in MediaPortal program plugins folder, and the temporary files stored in the thumbs\Skin Fanart folders.

**NOTE!** You must delete the the fanarthandler.db3 file manually from the `[userdata]\database` folder since it is not installed by the MPI installer but created by the plugin after installation.