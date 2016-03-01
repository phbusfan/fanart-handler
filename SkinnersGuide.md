


---

# Introduction #
Fanart Handler is a plugin for [MediaPortal (MP)](http://www.team-mediaportal.com/). The plugin has two main purposes;
  * Search and download music fanart (scrape) from the [htbackdrops](http://htbackdrops.com/) site.
    1. for all artists stored in your MP music database.
    1. for any artist currently playing (on the fly).

  * Push fanart that you store on your local harddrive to the current used MP skin.
    1. push fanart for now played music
    1. push fanart for selected music or movie
    1. push random images from selected folders

This is the **Skin Designer's Guide** to the "FanartHandler" plugin. This guide describes the skin tags that you can use in your skin to display fanart (backdrops).

The scope of this plugin is to;
  1. scrape htbackdrops site for music fanart for all artists stored in your MP music database.
  1. scrape htbackdrops site for music fanart for currently played artist.
  1. push music fanart for now played music track (artist images)
  1. push music fanart for browsed music artists
  1. push music fanart for browsed/played music artists
  1. push movie fanart for browsed video titles
  1. push scorecenter fanart for browsed category in myScoreCenter plugin
  1. push cycling fanart from the following folders for use anywhere in a skin for
    * thumbs\MovingPictures\Backdrops\FullSize
    * thumbs\Fan Art\fanart\original
    * thumbs\Skin Fanart\games thumbs\Skin Fanart\UserDef\games*** thumbs\Skin Fanart\movies thumbs\Skin Fanart\UserDef\movies**
    * thumbs\Skin Fanart\music thumbs\Skin Fanart\UserDef\music*** thumbs\Skin Fanart\pictures thumbs\Skin Fanart\UserDef\pictures**
    * thumbs\Skin Fanart\plugins thumbs\Skin Fanart\UserDef\plugins*** thumbs\Skin Fanart\tv thumbs\Skin Fanart\UserDef\tv**
    * thumbs\Skin Fanart\movies thumbs\Skin Fanart\Scraper\movies*** thumbs\Skin Fanart\music thumbs\Skin Fanart\Scraper\music**

## Requirements ##
  * MediaPortal 1.1 or later
  * Fanart Handler Plugin
  * A skin that supports the Fanart Handler.
**NOTE** This plugin only supports JPG images.


---

# Change Logs #
This chapter describes changes that skinners need to consider when versions of the fanart handler plugin changes.
## Change Log - Version 2.2.5 to 2.3.0 ##
No changes needed in skin files to support version 2.2.3 if your skin previously supported version 1.1 - 2.2.2 of this plugin. BUT all latest media tags is deprecated and should be replaced with the tags used by the new LatestMediaHandler plugin. Please see the [skinning guide](http://code.google.com/p/latestmediahandler/wiki/SkinnersGuide) of that plugin for more information. Users will have to install the LatestMediaHandler plugin to get the existing functionality.
## Change Log - Version 2.2.4 to 2.2.5 ##
No changes needed in skin files to support version 2.2.3 if your skin previously supported version 1.1 - 2.2.2 of this plugin.
## Change Log - Version 2.2.3 to 2.2.4 ##
New properties that makes latest recorded tv (4TR and MP) playable. New feature: New property for latest pictures (Title). New property for latest music (Genre). New property for latest tvseries and movingpictures called plot. New properties to "enabled" that can be used to decide if a user have enabled latest media tags.
## Change Log - Version 2.2.2 to 2.2.3 ##
No changes needed in skin files to support version 2.2.3 if your skin previously supported version 1.1 - 2.2.2 of this plugin.
## Change Log - Version 2.2.1 to 2.2.2 ##
Many changes. Most of the "Available Skin Tags" and "Define Tags" has changed name. New Latest Media properties for TVSeries Serie Poster added. New buttons for making latest media (music, moving pictures and tvseries) playable for basichome page. Changes are marked with strikeouts in the text below.
## Change Log - Version 2.2 to 2.2.1 ##
No changes needed in skin files to support version 2.2.1 if your skin previously supported version 1.1 - 2.2 of this plugin.
## Change Log - Version 2.1.1 to 2.2 ##
The plugin now supports latest added properties for Music, Pictures, Moving Pictures, TV Recordings and TVSeries. Read more about this in sections below.
### New Property: Displays what type of scrape is occurring ###
This property informs what type of scrape is occurring, like;
  * Initial Scrape
  * New Fanart Scrape
  * Now Playing Scrape
```
#fanarthandler.scraper.task
```
## Change Log - Version 2.1 to 2.1.1 ##
No changes needed in skin files to support version 2.1.1 if your skin previously supported version 1.1 - 2.1.1 of this plugin.
## Change Log - Version 2.0 to 2.1 ##
No changes needed in skin files to support version 2.1 if your skin previously supported version 1.1 - 2.0 of this plugin. This version has added support for fanart in MP's MPGrooveshark plugin
## Change Log - Version 1.10 to 2.0 ##
No changes needed in skin files to support version 2.0 if your skin previously supported version 1.1 - 1.10 of this plugin. This version has added support for fanart in MP's TV sections like tv guide, recorded tv, tv home, tv program info. Use the #fanarthandler.movie.backdrop1.selected and #fanarthandler.movie.backdrop2.selected properties for this. Example of usage in [this](http://x-factor.googlecode.com/svn/trunk/4TR_RecordedTv.xml) link.
## Change Log - Version 1.9 to 1.10 ##
No changes needed in skin files to support version 1.10 if your skin previously supported version 1.1 - 1.9 of this plugin. All handling of asynchronous image loading has been rewritten to ensure faster loading of images and more stable handling.
## Change Log - Version 1.8 to 1.9 ##
No changes needed in skin files to support version 1.9 if your skin previously supported version 1.1 - 1.8 of this plugin. This version is reintroducing the possibility to use HIDDEN and VISIBLE animations for backdrops. I found a fix that tricks MP so that these animations now work. The good with these animations compared to VISIBLECHANGE animations is that fading in and out is working and gives a much smother experiense in MP. No more of the old "slideshow" effect on windowopen ;)
## Change Log - Version 1.7 to 1.8 ##
No changes needed in skin files to support version 1.8 if your skin previously supported version 1.1 - 1.7 of this plugin. This version adds optional support for movie fanart in onlinevideos plugin.

If you use Random Fanart on Basic Home, you should change the default animations to:
```
<animation effect="fade" start="10" end="100" time="850">VisibleChange</animation> 
```

Using the old hidden animation makes MP show all fanart images like a slide show on window open and it does not look that good. Using visiblechange instead makes it smooth when opening Basic Home containing many image controls being loaded async.
## Change Log - Version 1.6 to 1.7 ##
No changes needed in skin files to support version 1.7 if your skin previously supported version 1.1, 1.2, 1.3, 1.4, 1.5 or 1.6 of this plugin.
## Change Log - Version 1.5 to 1.6 ##
No changes needed in skin files to support version 1.6 if your skin previously supported version 1.1, 1.2, 1.3, 1.4 or 1.5 of this plugin. But the handing of how images are changed in this version. Images are now loaded asynchronous when a MP window is opened. This means that for example in basichome where you may have alot of random images a delay can occur from the time the window displays until images are loaded and shown. To resolve this you can add an image that fades while the loading of all the rest of the images occur. See example below.
```
<control>
  <description>BACKGROUND LOADING</description>
  <id>0</id>
  <type>image</type>
  <posX>0</posX>
  <posY>0</posY>
  <width>1280</width>
  <height>720</height>
  <texture>LoadingBackdrop.png</texture> 
  <animation effect="fade" start="100" end="0" time="6000" reversible="false">WindowOpen</animation>
  <animation effect="fade" start="0" end="0" time="10" reversible="false">WindowClose</animation>
</control>
```
## Change Log - Version 1.4 to 1.5 ##
No changes needed in skin files to support version 1.5 if your skin previously supported version 1.1, 1.2, 1.3 or 1.4 of this plugin.
## Change Log - Version 1.3 to 1.4 ##
No changes needed in skin files to support version 1.4 if your skin previously supported version 1.1, 1.2 or 1.3 of this plugin.
## Change Log - Version 1.2 to 1.3 ##
No changes needed in skin files to support version 1.3 if your skin previously supported version 1.1 or 1.2 of this plugin.

## Change Log - Version 1.1 to 1.2 ##
No changes needed in skin files to support version 1.2 if your skin previously supported version 1.1 of this plugin.

## Change Log - Version 1.0 to 1.1 ##
### New Define Tag: #useSelectedFanart ###
```
<define>#useSelectedFanart:Yes</define>
```
New tag that you have to include in every skin file that wants to use any of the ".selected" properties (like #fanarthandler.music.backdrop1.selected). From v 2.2.4 it is possible to only add this property to a common file that is imported in the real xml file. Read more on this property in chapter below.



### New Define Tag: #usePlayFanart ###
```
<define>#usePlayFanart:Yes</define>
```
New tag that you have to include in every skin file that wants to use any of the ".play" properties (like #fanarthandler.music.backdrop1.play). From v 2.2.4 it is possible to only add this property to a common file that is imported in the real xml file. Read more on this property in chapter below.


### New Define Tag: #useRandomScoreCenterUserFanart ###
```
<define>#useRandomScoreCenterUserFanart:Yes</define>
```
> New tag to enable the use of Random images from the thumb\Skin fanart\scorecenter folder. This tag must be included in each skin file where you wish to display these random images. See more on using this tag in the chapter below.


### New control and property to display scrape progress in MP ###
This 'scraper is running' control can be used in a skin if want to display when the scraper is running.


### New Control: Is Visible When The Scraper Is Running ###
This control will be visible when the scraper is running
```
<control>
  <description>DUMMY CONTROL FOR FANART HANDLER IS SCRAPING VISIBILITY CONDITION</description>
  <type>label</type>
  <id>91919280</id>
  <posX>0</posX>
  <posY>0</posY>
  <width>1</width>
  <visible>no</visible>
</control> 
```
Read more on this in chapter "Scraper Controls".


### New Property: Displays Scrape Progress In Percent In MP ###
This property holdsscrape progress number in percent
```
#fanarthandler.scraper.percent.completed
```
Read more on this in chapter "Scraper Controls".



---


# Enable Fanart Handler Support In A Skin File #
## Add Support For "Selected" Images To A Skin File ##
By default no fanart for selected artist/title is loaded. The reason for this is to save memory in MP. To enable fanart for selected artist/title to be pushed to a skin file you add "define" tags in the skin file header. See example below.
```
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<window>
<id>35</id>
<defaultcontrol>77032</defaultcontrol>
<allowoverlay>no</allowoverlay>
<disabletopbar>yes</disabletopbar>
<rememberLastFocusedControl>no</rememberLastFocusedControl>
<define>#useSelectedFanart:Yes</define>  (Will be available in plugin version 1.1)
<controls>
```

From v 2.2.4 it is possible to only add this property to a common file that is imported in the real xml file. Read more on this property in chapter below.


## Add Support For "Now Playing" Images To A Skin File ##
By default no fanart for now playing music is loaded. The reason for this is to save memory in MP. To enable fanart for now playing music to be pushed to a skin file you add "define" tags in the skin file header. See example below.
```
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<window>
<id>35</id>
<defaultcontrol>77032</defaultcontrol>
<allowoverlay>no</allowoverlay>
<disabletopbar>yes</disabletopbar>
<rememberLastFocusedControl>no</rememberLastFocusedControl>
<define>#usePlayFanart:Yes</define>  (Will be available in plugin version 1.1)
<controls>
```

From v 2.2.4 it is possible to only add this property to a common file that is imported in the real xml file. Read more on this property in chapter below.


## Add Support For "Random" Images To A Skin File ##
By default no random images are loaded. The reason for this is to save memory in MP. If all random images for all supported paths (games, movies, moving pictures, music, pictures and tvseries) where loaded in all skin files this would mean unnecessary use of memory. To enable random images to be pushed to a skin file you add "define" tags in the skin file header. See example below.
```
<?xml version="1.0" encoding="utf-8" standalone="yes"?>
<window>
<id>35</id>
<defaultcontrol>77032</defaultcontrol>
<allowoverlay>no</allowoverlay>
<disabletopbar>yes</disabletopbar>
<rememberLastFocusedControl>no</rememberLastFocusedControl>
<define>#useRandomGamesUserFanart:No</define>
<define>#useRandomMoviesUserFanart:Yes</define>
<define>#useRandomMoviesScraperFanart:Yes</define>
<define>#useRandomMovingPicturesFanart:No</define>
<define>#useRandomMusicUserFanart:Yes</define>
<define>#useRandomMusicScraperFanart:Yes</define>
<define>#useRandomPicturesUserFanart:Yes</define>
<define>#useRandomPluginsUserFanart:Yes</define>
<define>#useRandomScoreCenterUserFanart:Yes</define> 
<define>#useRandomTVUserFanart:Yes</define>
<define>#useRandomTVSeriesFanart:Yes</define>
<controls>
```


## Available Define Tags ##
|useSelectedFanart|Enables fanart for the "selected" properties like "#fanarthandler.music.backdrop1.selected" and "#fanarthandler.movie.backdrop1.selected"|
|:----------------|:----------------------------------------------------------------------------------------------------------------------------------------|
|usePlayFanart    |Enables fanart for the tags "#fanarthandler.music.backdrop1.play" and "#fanarthandler.music.backdrop1.play"                              |
|useRandomGamesUserFanart|Enables cycling fanart from the tags "#fanarthandler.games.userdef.backdrop1.any" and "#fanarthandler.games.userdef.backdrop2.any"       |
|useRandomMoviesUserFanart|Enables cycling fanart from the tags "#fanarthandler.movie.userdef.backdrop1.any" and "#fanarthandler.movie.userdef.backdrop2.any"       |
|useRandomMoviesScraperFanart|Enables cycling fanart from the tags "#fanarthandler.movie.scraper.backdrop1.any" and "#fanarthandler.movie.scraper.backdrop2.any"       |
|useRandomMovingPicturesFanart|Enables cycling fanart from the tags "#fanarthandler.movingpicture.userdef.backdrop1.any" and "#fanarthandler.movingpicture.userdef.backdrop2.any"|
|useRandomMusicUserFanart|Enables cycling fanart from the tags "#fanarthandler.music.userdef.backdrop1.any" and "#fanarthandler.music.userdef.backdrop2.any"       |
|useRandomMusicScraperFanart|Enables cycling fanart from the tags "#fanarthandler.music.scraper.backdrop1.any" and "#fanarthandler.music.acraper.backdrop2.any"       |
|useRandomPicturesUserFanart|Enables cycling fanart from the tags "#fanarthandler.picture.userdef.backdrop1.any" and "#fanarthandler.picture.userdef.backdrop2.any"   |
|useRandomPluginsUserFanart|Enables cycling fanart from the tags "#fanarthandler.plugins.userdef.backdrop1.any" and "#fanarthandler.plugins.userdef.backdrop2.any"   |
|useRandomScoreCenterUserFanart|Enables cycling fanart from the tags "#fanarthandler.scorecenter.userdef.backdrop1.any" and "#fanarthandler.scorecenter.backdrop2.any"   |
|useRandomTVUserFanart|Enables cycling fanart from the tags "#fanarthandler.tv.backdrop1.selected" and "#fanarthandler.tv.backdrop2.selected"                   |
|useRandomTVSeriesFanart|Enables cycling fanart from the tags "#fanarthandler.tvseries.backdrop1.selected" and "#fanarthandler.tvseries.backdrop2.selected"       |


---


# Available Skin Tags #
|#fanarthandler.games.userdef.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\games" folder.|
|:-----------------------------------------|:---------------------------------------------------------------------------------------------------------------|
|#fanarthandler.games.userdef.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\games" folder.|
|#fanarthandler.movie.userdef.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\movies" folder.|
|#fanarthandler.movie.userdef.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\movies" folder.|
|#fanarthandler.movie.scraper.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\Scraper\movies" folder.|
|#fanarthandler.movie.scraper.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\Scraper\movies" folder.|
|#fanarthandler.movie.backdrop1.selected   |Use this tag in the myVideo plugin (myVideo.xml & myVideoTitle.xml) to show fanart for selected video. It picks images from the "thumbs\Skin Fanart\Scraper\movies" folder.|
|#fanarthandler.movie.backdrop2.selected   |Use this tag in the myVideo plugin (myVideo.xml & myVideoTitle.xml) to show fanart for selected video. It picks images from the "thumbs\Skin Fanart\Scraper\movies" folder.|
|#fanarthandler.movingpicture.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\MovingPictures\Backdrops\FullSize" folder.|
|#fanarthandler.movingpicture.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\MovingPictures\Backdrops\FullSize" folder.|
|#fanarthandler.music.userdef.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\music" folder.|
|#fanarthandler.music.userdef.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\music" folder.|
|#fanarthandler.music.scraper.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\Scraper\music" folder.|
|#fanarthandler.music.scraper.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\Scraper\music" folder.|
|#fanarthandler.music.overlay.play         |Can be used if you want a "small" fanart available in the background of the now playing overlay in MP. Using this instead of ".play" property allows end users to enable/disable this fanart in the MP configuration|
|#fanarthandler.music.backdrop1.play       |Use this tag anywhere in a skin for displaying images from the "thumbs\Skin Fanart\Scraper\music" folder for now playing music (artist).|
|#fanarthandler.music.backdrop2.play       |Use this tag anywhere in a skin for displaying images from the "thumbs\Skin Fanart\Scraper\music" folder for now playing music (artist).|
|#fanarthandler.music.backdrop1.selected   |Use this tag in the myMusic plugin (myMusicGenres.xml) to show fanart for selected artist. It picks images from the "thumbs\Skin Fanart\Scraper\music" folder.|
|#fanarthandler.music.backdrop2.selected   |Use this tag in the myMusic plugin (myMusicGenres.xml) to show fanart for selected artist. It picks images from the "thumbs\Skin Fanart\Scraper\music" folder.|
|#fanarthandler.picture.userdef.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\pictures" folder.|
|#fanarthandler.picture.userdef.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\pictures" folder.|
|#fanarthandler.plugins.userdef.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\plugins" folder.|
|#fanarthandler.plugins.userdef.backdrop2.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\plugins" folder.|
|#fanarthandler.scorecenter.userdef.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\scorecenter" folder.|
|#fanarthandler.scorecenter.userdef.backdrop1.any|Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\scorecenter" folder.|
|#fanarthandler.scorecenter.backdrop1.selected|Use this tag in the myScorecenter plugin (myScoreCenter.xml) to show fanart for selected genre in the plugin. It picks images from the "thumbs\Skin Fanart\UserDef\scorecenter" folder.|
|#fanarthandler.scorecenter.backdrop2.selected|Use this tag in the myScorecenter plugin (myScoreCenter.xml) to show fanart for selected genre in the plugin. It picks images from the "thumbs\Skin Fanart\UserDef\scorecenter" folder.|
|#fanarthandler.tv.userdef.backdrop1.any   |Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\tv" folder.   |
|#fanarthandler.tv.userdef.backdrop2.any   |Use this tag anywhere in a skin for displaying random images from the "thumbs\Skin Fanart\UserDef\tv" folder.   |
|#fanarthandler.tvseries.backdrop1.any     |Use this tag anywhere in a skin for displaying random images from the "thumbs\Fan Art\fanart\original" folder.  |
|#fanarthandler.tvseries.backdrop1.any     |Use this tag anywhere in a skin for displaying random images from the "thumbs\Fan Art\fanart\original" folder.  |



---


# The Fanart Fading Transition #
The plugin supports animation effects to the fanart so that it fades from one image to another. This is possible by using two label controls and two images controls. The plugin handles visiblity of the label controls. Use visibility tag on the image contol and animation(s) to enable a smooth transition effect. An example implementation is listed below.

## Controlling Visibility ##
These controls exist to control visibility in the skin. There are three sets of two  controls. One set of controls for selected items (like when browsing your playlist or music collection), one set of controls for now played music and one set of controls for random images.
<br><b>This control will be visible when image 1 for selected item is the one that the skin should display</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR SELECTED FANART 1 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919291&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>
<b>This control will be visible when image 2 for selected item is the one that the skin should display</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR SELECTED FANART 2 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919292&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>
<b>This control will be visible when image 1 for played item is the one that the skin should display</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR PLAYING FANART 1 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919295&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>
<b>This control will be visible when image 2 for played item is the one that the skin should display</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR PLAYING FANART 2 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919296&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>
<b>This control will be visible when random image 1 is the one that the skin should display</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR RANDOM FANART 1 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919297&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>
<b>This control will be visible when random image 2 is the one that the skin should display</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR RANDOM FANART 2 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919298&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>

<h2>Fanart Available Controls</h2>
The fanart available controls can be used in a skin if you need to know if currently selected or played artist/title has fanart (i.e if the plugin found fanart or not).<br>
<br>
<b>This control will be visible when selected fanart is available. Use this in visibility tags to show or hide images depending if the plugin found fanart or not</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR SELECTED FANART AVAILABILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919293&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>

<b>This control will be visible when playing fanart is availble. Use this in visibility tags to show or hide images depending if the plugin found fanart or not</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR PLAYING FANART AVAILABILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919294&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
</code></pre>

<h2>An Example - Music Now Playing</h2>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR PLAYING FANART 1 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919295&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
  <br>
&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR PLAYING FANART 2 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919296&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR PLAYING FANART AVAILABILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919294&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;DEFAULT BACKGROUND WHEN FANART NOT AVAILABLE&lt;/description&gt;<br>
  &lt;id&gt;0&lt;/id&gt;<br>
  &lt;type&gt;multiimage&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;imagepath&gt;music&lt;/imagepath&gt;<br>
  &lt;timeperimage&gt;30000&lt;/timeperimage&gt;<br>
  &lt;fadetime&gt;800&lt;/fadetime&gt;<br>
  &lt;loop&gt;yes&lt;/loop&gt;<br>
  &lt;randomize&gt;True&lt;/randomize&gt;		<br>
  &lt;visible&gt;!control.isvisible(91919294)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;	<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;FANART IMAGE 1&lt;/description&gt;<br>
  &lt;id&gt;897688&lt;/id&gt;<br>
  &lt;type&gt;image&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;texture&gt;#fanarthandler.music.backdrop1.play&lt;/texture&gt;<br>
  &lt;visible&gt;control.isvisible(91919295)+control.isvisible(91919294)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;FANART IMAGE 2&lt;/description&gt;<br>
  &lt;id&gt;897689&lt;/id&gt;<br>
  &lt;type&gt;image&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;texture&gt;#fanarthandler.music.backdrop2.play&lt;/texture&gt;<br>
  &lt;visible&gt;control.isvisible(91919296)+control.isvisible(91919294)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;<br>
</code></pre>

<h2>An Example - Selected Music (in lists)</h2>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR SELECTED FANART 1 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919291&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
  <br>
&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR SELECTED FANART 2 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919292&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR SELECTED FANART AVAILABILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919293&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;DEFAULT BACKGROUND WHEN FANART NOT AVAILABLE&lt;/description&gt;<br>
  &lt;id&gt;0&lt;/id&gt;<br>
  &lt;type&gt;multiimage&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;imagepath&gt;music&lt;/imagepath&gt;<br>
  &lt;timeperimage&gt;30000&lt;/timeperimage&gt;<br>
  &lt;fadetime&gt;800&lt;/fadetime&gt;<br>
  &lt;loop&gt;yes&lt;/loop&gt;<br>
  &lt;randomize&gt;True&lt;/randomize&gt;		<br>
  &lt;visible&gt;!control.isvisible(91919293)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;	<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;FANART IMAGE 1&lt;/description&gt;<br>
  &lt;id&gt;897688&lt;/id&gt;<br>
  &lt;type&gt;image&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;texture&gt;#fanarthandler.music.backdrop1.selected&lt;/texture&gt;<br>
  &lt;visible&gt;control.isvisible(91919291)+control.isvisible(91919293)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;FANART IMAGE 2&lt;/description&gt;<br>
  &lt;id&gt;897689&lt;/id&gt;<br>
  &lt;type&gt;image&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;texture&gt;#fanarthandler.music.backdrop2.selected&lt;/texture&gt;<br>
  &lt;visible&gt;control.isvisible(91919292)+control.isvisible(91919293)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;<br>
</code></pre>

<h2>An Example - Random Images</h2>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR RANDOM FANART 1 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919297&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
  <br>
&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR RANDOM FANART 2 VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919298&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;FANART IMAGE 1&lt;/description&gt;<br>
  &lt;id&gt;897688&lt;/id&gt;<br>
  &lt;type&gt;image&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;texture&gt;#fanarthandler.music.userdef.backdrop1.any&lt;/texture&gt;<br>
  &lt;visible&gt;control.isvisible(91919297)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;<br>
<br>
&lt;control&gt;<br>
  &lt;description&gt;FANART IMAGE 2&lt;/description&gt;<br>
  &lt;id&gt;897689&lt;/id&gt;<br>
  &lt;type&gt;image&lt;/type&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1280&lt;/width&gt;<br>
  &lt;height&gt;720&lt;/height&gt;<br>
  &lt;texture&gt;#fanarthandler.music.userdef.backdrop2.any&lt;/texture&gt;<br>
  &lt;visible&gt;control.isvisible(91919298)&lt;/visible&gt;<br>
  &lt;animation effect="fade" start="10" end="100" time="1000" delay="80" reversible="false"&gt;Visible&lt;/animation&gt;<br>
  &lt;animation effect="fade" start="100" end="0" time="900" reversible="false"&gt;Hidden&lt;/animation&gt;<br>
&lt;/control&gt;<br>
</code></pre>

To get even more examples you can look at these x-factor skin files using this plugin;<br>
<ul><li><a href='http://x-factor.googlecode.com/svn/trunk/MyMusicPlayingNow.xml'>MyMusicPlayingNow.xml</a>
</li><li><a href='http://x-factor.googlecode.com/svn/trunk/mymusicplaylist.xml'>mymusicplaylist.xml</a>
</li><li><a href='http://x-factor.googlecode.com/svn/trunk/mymusicgenres.xml'>mymusicgenres.xml</a>
</li><li><a href='http://x-factor.googlecode.com/svn/trunk/myvideo.xml'>myvideo.xml</a>
</li><li><a href='http://x-factor.googlecode.com/svn/trunk/Basichome.xml'>Basichome.xml</a>
</li><li><a href='http://x-factor.googlecode.com/svn/trunk/MyRadioLastFM.xml'>MyRadioLastFM.xml</a>
</li><li><a href='http://x-factor.googlecode.com/svn/trunk/myLyrics.xml'>myLyrics.xml</a></li></ul>


<hr />
<h1>Scraper Controls</h1>
<h2>Scraper is Running (will be available in version 1.1 of this plugin)</h2>
The 'scraper is running' control can be used in a skin if want to display when the scraper is running.<br>
<br>
<b>This control will be visible when the scraper is running</b>
<pre><code>&lt;control&gt;<br>
  &lt;description&gt;DUMMY CONTROL FOR FANART HANDLER IS SCRAPING VISIBILITY CONDITION&lt;/description&gt;<br>
  &lt;type&gt;label&lt;/type&gt;<br>
  &lt;id&gt;91919280&lt;/id&gt;<br>
  &lt;posX&gt;0&lt;/posX&gt;<br>
  &lt;posY&gt;0&lt;/posY&gt;<br>
  &lt;width&gt;1&lt;/width&gt;<br>
  &lt;visible&gt;no&lt;/visible&gt;<br>
&lt;/control&gt; <br>
</code></pre>

<h2>An Example of a common.overlay.fanart.xml file that can be included for example in BasicHome.xml</h2>
This example will show a running animation and dispay the percent completed when the scraper is running.<br>
<pre><code>&lt;?xml version="1.0" encoding="utf-8" standalone="yes"?&gt;<br>
&lt;window&gt;<br>
  &lt;controls&gt;<br>
  <br>
		&lt;control&gt;<br>
			&lt;description&gt;DUMMY CONTROL FOR FANART HANDLER IS SCRAPING VISIBILITY CONDITION&lt;/description&gt;<br>
			&lt;type&gt;label&lt;/type&gt;<br>
			&lt;id&gt;91919280&lt;/id&gt;<br>
			&lt;posX&gt;0&lt;/posX&gt;<br>
			&lt;posY&gt;0&lt;/posY&gt;<br>
			&lt;width&gt;1&lt;/width&gt;<br>
                        &lt;visible&gt;no&lt;/visible&gt;<br>
		&lt;/control&gt; 	<br>
		<br>
		&lt;control&gt;<br>
			&lt;description&gt;Scraping Header Shadow&lt;/description&gt;<br>
			&lt;type&gt;label&lt;/type&gt;<br>
			&lt;id&gt;0&lt;/id&gt;<br>
			&lt;posX&gt;541&lt;/posX&gt;<br>
			&lt;posY&gt;189&lt;/posY&gt;<br>
			&lt;width&gt;200&lt;/width&gt;<br>
			&lt;textcolor&gt;ff000000&lt;/textcolor&gt;<br>
			&lt;font&gt;fontLowerCase14&lt;/font&gt;<br>
			&lt;label&gt;scraping&lt;/label&gt;<br>
			&lt;align&gt;center&lt;/align&gt;<br>
			&lt;animation effect="fade" start="0" end="50" time="10" reversible="false"&gt;WindowOpen&lt;/animation&gt;<br>
			&lt;visible&gt;control.isvisible(91919280)&lt;/visible&gt;<br>
		&lt;/control&gt;<br>
		<br>
		&lt;control&gt;<br>
			&lt;description&gt;Scraping Header&lt;/description&gt;<br>
			&lt;type&gt;label&lt;/type&gt;<br>
			&lt;id&gt;0&lt;/id&gt;<br>
			&lt;posX&gt;540&lt;/posX&gt;<br>
			&lt;posY&gt;188&lt;/posY&gt;<br>
			&lt;width&gt;200&lt;/width&gt;<br>
			&lt;textcolor&gt;ffffffff&lt;/textcolor&gt;<br>
			&lt;font&gt;fontLowerCase14&lt;/font&gt;<br>
			&lt;label&gt;scraping&lt;/label&gt;<br>
			&lt;align&gt;center&lt;/align&gt;<br>
			&lt;visible&gt;control.isvisible(91919280)&lt;/visible&gt;<br>
		&lt;/control&gt;<br>
		&lt;control&gt;<br>
			&lt;description&gt;music background image&lt;/description&gt;<br>
			&lt;id&gt;0&lt;/id&gt;<br>
			&lt;type&gt;multiimage&lt;/type&gt;<br>
			&lt;posX&gt;592&lt;/posX&gt;<br>
			&lt;posY&gt;80&lt;/posY&gt;<br>
			&lt;width&gt;96&lt;/width&gt;<br>
			&lt;height&gt;96&lt;/height&gt;<br>
			&lt;imagepath&gt;../FanartHandler&lt;/imagepath&gt;<br>
			&lt;timeperimage&gt;150&lt;/timeperimage&gt;<br>
			&lt;fadetime&gt;20&lt;/fadetime&gt;<br>
			&lt;loop&gt;yes&lt;/loop&gt;<br>
			&lt;randomize&gt;no&lt;/randomize&gt;<br>
			&lt;visible&gt;control.isvisible(91919280)&lt;/visible&gt;<br>
		&lt;/control&gt;				<br>
	<br>
		&lt;control&gt;<br>
			&lt;description&gt;Scraping Percent Complete Shadow&lt;/description&gt;<br>
			&lt;type&gt;label&lt;/type&gt;<br>
			&lt;id&gt;0&lt;/id&gt;<br>
			&lt;posX&gt;593&lt;/posX&gt;<br>
			&lt;posY&gt;129&lt;/posY&gt;<br>
			&lt;width&gt;96&lt;/width&gt;<br>
			&lt;textcolor&gt;90000000&lt;/textcolor&gt;<br>
			&lt;font&gt;font14&lt;/font&gt;<br>
			&lt;label&gt;#fanarthandler.scraper.percent.completed %&lt;/label&gt;<br>
			&lt;align&gt;center&lt;/align&gt;<br>
			&lt;visible&gt;control.isvisible(91919280)&lt;/visible&gt;<br>
		&lt;/control&gt;<br>
		<br>
		&lt;control&gt;<br>
			&lt;description&gt;Scraping Percent Complete&lt;/description&gt;<br>
			&lt;type&gt;label&lt;/type&gt;<br>
			&lt;id&gt;0&lt;/id&gt;<br>
			&lt;posX&gt;592&lt;/posX&gt;<br>
			&lt;posY&gt;128&lt;/posY&gt;<br>
			&lt;width&gt;96&lt;/width&gt;<br>
                        &lt;textcolor&gt;90ffffff&lt;/textcolor&gt;<br>
			&lt;font&gt;font14&lt;/font&gt;<br>
			&lt;label&gt;#fanarthandler.scraper.percent.completed %&lt;/label&gt;<br>
			&lt;align&gt;center&lt;/align&gt;<br>
			&lt;visible&gt;control.isvisible(91919280)&lt;/visible&gt;<br>
		&lt;/control&gt;<br>
	<br>
	&lt;/controls&gt;<br>
	<br>
&lt;/window&gt;<br>
</code></pre>


<hr />