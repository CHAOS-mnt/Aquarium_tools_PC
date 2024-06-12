enum SCRIPTFUNC : __int32
{
  	SCRIPTFUNC_INITSYSTEM,
  	SCRIPTFUNC_INITSTATUS,
  	SCRIPTFUNC_EXIT,                        // disabled on switch
  	SCRIPTFUNC_PLAYMOVIE,
  	SCRIPTFUNC_RANDOM,
  	SCRIPTFUNC_WAIT,
  	SCRIPTFUNC_LOADING,
  	SCRIPTFUNC_ENABLEEFFECTSPEED,
  	SCRIPTFUNC_DISABLEEFFECTSPEED,
  	SCRIPTFUNC_GETSYSTEMTIME,
  	SCRIPTFUNC_ISAUTH,                      // disabled on switch
  	SCRIPTFUNC_ISUSEDIRECTX,                // disabled on switch
  	SCRIPTFUNC_DEBUGOUT,
  	SCRIPTFUNC_GETFUNCTIONHASH,             // disabled on switch
  	SCRIPTFUNC_GETFUNCTIONDISTANCE,         // disabled on switch
  	SCRIPTFUNC_READBYTEFUNCTIONMEMORY,      // disabled on switch
  	SCRIPTFUNC_GETCRC32TABLE,               // disabled on switch
  	SCRIPTFUNC_DUMMY,                       // disabled on switch
  	SCRIPTFUNC_SHOWMENU,
  	SCRIPTFUNC_HIDEMENU,
  	SCRIPTFUNC_ENABLESAVE,
  	SCRIPTFUNC_DISABLESAVE,
  	SCRIPTFUNC_ENABLERETURNTITLE,
  	SCRIPTFUNC_DISABLERETURNTITLE,
  	SCRIPTFUNC_SAVEMENU,
  	SCRIPTFUNC_LOADMENU,
  	SCRIPTFUNC_CONFIGMENU,
  	SCRIPTFUNC_EXTRAMODE,
  	SCRIPTFUNC_SAVEGAME,
  	SCRIPTFUNC_LOADGAME,
  	SCRIPTFUNC_AUTOSAVE,
  	SCRIPTFUNC_AUTOLOAD,
  	SCRIPTFUNC_CANAUTOLOAD,
  	SCRIPTFUNC_SETSAVEMESSAGE,
  	SCRIPTFUNC_SETSAVETAG,
  	SCRIPTFUNC_SETSAVETHUMBNAIL,
  	SCRIPTFUNC_ADDBACKSTATUS,
  	SCRIPTFUNC_ISENABLEAUTOSAVE,
  	SCRIPTFUNC_SETCONFIGDATA,
  	SCRIPTFUNC_DELCONFIGDATA,
  	SCRIPTFUNC_GETCONFIGINTDATA,            // *
  	SCRIPTFUNC_GETCONFIGSTRINGDATA,         // *
  	SCRIPTFUNC_SUB_0x2A,                    // * Probably another GETCONFIG not enough information
  	SCRIPTFUNC_SHELLEXECUTE,                // disabled on switch
  	SCRIPTFUNC_ISEXISTFILE,                 // disabled on switch
  	SCRIPTFUNC_GETFILESIZE,                 // disabled on switch
  	SCRIPTFUNC_GETFILEHASH,                 // disabled on switch
  	SCRIPTFUNC_GETEXEFILENAME,              // disabled on switch
  	SCRIPTFUNC_ISINSTALL,                   // disabled on switch
  	SCRIPTFUNC_ISINSTALLFILE,               // disabled on switch
  	SCRIPTFUNC_GETINSTALLFILESIZE,          // disabled on switch
  	SCRIPTFUNC_SAVEWALLPAPER,               // disabled on switch
  	SCRIPTFUNC_SETWALLPAPER,                // disabled on switch
  	SCRIPTFUNC_SUB_0x35,                    // *
  	SCRIPTFUNC_SETBUFFER,                   // disabled on switch
  	SCRIPTFUNC_SETANIMEBUFFER,              // disabled on switch
  	SCRIPTFUNC_SETVISUALBUFFER,             // disabled on switch
  	SCRIPTFUNC_SETSTANDBUFFER,              // disabled on switch
  	SCRIPTFUNC_SETSEBUFFER,                 // disabled on switch
  	SCRIPTFUNC_DELBUFFER,                   // disabled on switch
  	SCRIPTFUNC_ISEXISTBUFFER,               // disabled on switch
  	SCRIPTFUNC_GETCHARCODE,                 // disabled on switch
  	SCRIPTFUNC_GETFONTCOLORR,               // disabled on switch
  	SCRIPTFUNC_GETFONTCOLORG,               // disabled on switch
  	SCRIPTFUNC_GETFONTCOLORB,               // disabled on switch
  	SCRIPTFUNC_SHOWCURSOR,                  // disabled on switch
  	SCRIPTFUNC_HIDECURSOR,                  // disabled on switch
  	SCRIPTFUNC_ENABLEINPUT,
  	SCRIPTFUNC_DISABLEINPUT,
  	SCRIPTFUNC_GETMOUSEMOVEFLG,             // disabled on switch
  	SCRIPTFUNC_GETMOUSEX,                   // disabled on switch
  	SCRIPTFUNC_GETMOUSEY,                   // disabled on switch
  	SCRIPTFUNC_ISCLICK,                     // disabled on switch
  	SCRIPTFUNC_SUB_0x49,                    // *
  	SCRIPTFUNC_SUB_0x4A,                    // *
  	SCRIPTFUNC_LOADSCRIPT,
  	SCRIPTFUNC_LOADEVENT,
  	SCRIPTFUNC_CHANGEBANK,
  	SCRIPTFUNC_CALLSCRIPT,
  	SCRIPTFUNC_CALLBANK,
  	SCRIPTFUNC_RETURN,
  	SCRIPTFUNC_SETEVENTNO,
  	SCRIPTFUNC_GETEVENTNO,
  	SCRIPTFUNC_GETEVENTAREANO,
  	SCRIPTFUNC_GETEVENTCHARNO,
  	SCRIPTFUNC_SETEVENTNAME,
  	SCRIPTFUNC_SETEVENTINFO,
  	SCRIPTFUNC_DELEVENTINFO,
  	SCRIPTFUNC_GETPLAYLISTPOS,
  	SCRIPTFUNC_GETPLAYLISTMAX,
  	SCRIPTFUNC_SETFLG,
  	SCRIPTFUNC_GETFLG,
  	SCRIPTFUNC_SETSYSTEMFLG,
  	SCRIPTFUNC_GETSYSTEMFLG,
  	SCRIPTFUNC_SETCGFLG,
  	SCRIPTFUNC_GETCGFLG,
  	SCRIPTFUNC_SETBGMFLG,
  	SCRIPTFUNC_GETBGMFLG,
  	SCRIPTFUNC_SETREPLAYFLG,
  	SCRIPTFUNC_GETREPLAYFLG,
  	SCRIPTFUNC_SETEVENTFLG,
  	SCRIPTFUNC_GETEVENTFLG,
  	SCRIPTFUNC_SETSELECTMENU,
  	SCRIPTFUNC_SELECTMENU,
  	SCRIPTFUNC_SELECTBUTTON,
  	SCRIPTFUNC_EXITSELECTBUTTON,
  	SCRIPTFUNC_SETWINDOW,
  	SCRIPTFUNC_DELWINDOW,
  	SCRIPTFUNC_SUB_0x6C,                    // *
  	SCRIPTFUNC_SUB_0x6D,                    // *
  	SCRIPTFUNC_GETWINDOWFADESPEED,
  	SCRIPTFUNC_SETMESSAGE,
  	SCRIPTFUNC_SETCHATMESSAGE,
  	SCRIPTFUNC_ADDMESSAGE,
  	SCRIPTFUNC_DELMESSAGE,
  	SCRIPTFUNC_WAITMESSAGE,
  	SCRIPTFUNC_MESSAGEPOS,
  	SCRIPTFUNC_MESSAGEBOX,
  	SCRIPTFUNC_SETINFOMESSAGE,
  	SCRIPTFUNC_ENABLECHECKALREADY,
  	SCRIPTFUNC_DISABLECHECKALREADY,
  	SCRIPTFUNC_ENABLESKIP,
  	SCRIPTFUNC_DISABLESKIP,
  	SCRIPTFUNC_SETSCENARIOENDWARNING,       // *
  	SCRIPTFUNC_CANCELAUTOMODE,
  	SCRIPTFUNC_CANCELSKIPMODE,
  	SCRIPTFUNC_CANCELNEXTJUMP,
  	SCRIPTFUNC_ISSKIP,
  	SCRIPTFUNC_ISNEXTJUMP,
  	SCRIPTFUNC_ISQUICKJUMP,
  	SCRIPTFUNC_SETVISUAL,
  	SCRIPTFUNC_DELVISUAL,
  	SCRIPTFUNC_MOVEVISUAL,
  	SCRIPTFUNC_ZOOMVISUAL,
  	SCRIPTFUNC_PINBOKEVISUAL,
  	SCRIPTFUNC_FADEVISUAL,
  	SCRIPTFUNC_FLASHVISUAL,
  	SCRIPTFUNC_MOSAICVISUAL,
  	SCRIPTFUNC_WAITVISUAL,
  	SCRIPTFUNC_WAITMOVEVISUAL,
  	SCRIPTFUNC_WAITZOOMVISUAL,
  	SCRIPTFUNC_WAITPINBOKEVISUAL,
  	SCRIPTFUNC_WAITFADEVISUAL,
  	SCRIPTFUNC_WAITFLASHVISUAL,
  	SCRIPTFUNC_WAITMOSAICVISUAL,
  	SCRIPTFUNC_GETVISUALNO,
  	SCRIPTFUNC_GETVISUALWIDTH,
  	SCRIPTFUNC_GETVISUALHEIGHT,
  	SCRIPTFUNC_FADEIN,
	SCRIPTFUNC_FADEOUT,
	SCRIPTFUNC_FLASHIN,
	SCRIPTFUNC_FLASHOUT,
	SCRIPTFUNC_ADDIN,
	SCRIPTFUNC_ADDOUT,
	SCRIPTFUNC_CROSSFADE,
	SCRIPTFUNC_ZOOMFADEIN,
	SCRIPTFUNC_ZOOMFADEOUT,
	SCRIPTFUNC_ZOOMFLASHIN,
	SCRIPTFUNC_ZOOMFLASHOUT,
	SCRIPTFUNC_ZOOMADDIN,
	SCRIPTFUNC_ZOOMADDOUT,
	SCRIPTFUNC_ZOOMCROSSFADE,
	SCRIPTFUNC_ROTATEFADEIN,
	SCRIPTFUNC_ROTATEFADEOUT,
	SCRIPTFUNC_ROTATEFLASHIN,
	SCRIPTFUNC_ROTATEFLASHOUT,
	SCRIPTFUNC_ROTATEADDIN,
	SCRIPTFUNC_ROTATEADDOUT,
	SCRIPTFUNC_ROTATECROSSFADE,
	SCRIPTFUNC_MOSAICFADEIN,
	SCRIPTFUNC_MOSAICFADEOUT,
	SCRIPTFUNC_MOSAICFLASHIN,
	SCRIPTFUNC_MOSAICFLASHOUT,
	SCRIPTFUNC_MOSAICADDIN,
	SCRIPTFUNC_MOSAICADDOUT,
	SCRIPTFUNC_MOSAICCROSSFADE,
	SCRIPTFUNC_SCROLLFADEIN,
	SCRIPTFUNC_SCROLLFADEOUT,
	SCRIPTFUNC_SCROLLFLASHIN,
	SCRIPTFUNC_SCROLLFLASHOUT,
	SCRIPTFUNC_SCROLLADDIN,
	SCRIPTFUNC_SCROLLADDOUT,
	SCRIPTFUNC_SCROLLCROSSFADE,
	SCRIPTFUNC_SCROLLIN,
	SCRIPTFUNC_SCROLLOUT,
	SCRIPTFUNC_SCROLLCROSS,
	SCRIPTFUNC_CURTAINFADEIN,
	SCRIPTFUNC_CURTAINFADEOUT,
  	SCRIPTFUNC_CURTAINFADEIN2,            // *
  	SCRIPTFUNC_CURTAINFADEOUT2,           // *
	SCRIPTFUNC_RULEFADEIN,
	SCRIPTFUNC_RULEFADEOUT,
	SCRIPTFUNC_RULEFLASHIN,
	SCRIPTFUNC_RULEFLASHOUT,
	SCRIPTFUNC_RULECROSSFADE,
	SCRIPTFUNC_TURNFADEIN,
	SCRIPTFUNC_TURNFLASHOUT,
	SCRIPTFUNC_TURNFLASHIN,
	SCRIPTFUNC_TURNFADEOUT,
	SCRIPTFUNC_WAVEFADEIN,                // disabled on switch
	SCRIPTFUNC_WAVEFADEOUT,               // disabled on switch
	SCRIPTFUNC_WAVEFLASHIN,               // disabled on switch
	SCRIPTFUNC_WAVEFLASHOUT,              // disabled on switch
	SCRIPTFUNC_WAVECROSSFADE,             // disabled on switch
	SCRIPTFUNC_FADEOUTALL,
  	SCRIPTFUNC_WAITFADE,
	SCRIPTFUNC_FADE,
	SCRIPTFUNC_FLASH,
	SCRIPTFUNC_FADERGB,
	SCRIPTFUNC_FLASHRGB,
	SCRIPTFUNC_SEPIA,
	SCRIPTFUNC_MONO,
	SCRIPTFUNC_NEGATIVE,
	SCRIPTFUNC_SHAKE,
	SCRIPTFUNC_RASTERX,
	SCRIPTFUNC_RASTERY,
	SCRIPTFUNC_WAVEX,
	SCRIPTFUNC_WAVEY,
	SCRIPTFUNC_NOISEX,
	SCRIPTFUNC_NOISEY,
	SCRIPTFUNC_PINBOKE,
	SCRIPTFUNC_VIEW,
	SCRIPTFUNC_VIEWCENTER,
	SCRIPTFUNC_ZOOM,
	SCRIPTFUNC_ROTATE,
	SCRIPTFUNC_TURN,
	SCRIPTFUNC_BLUR,
	SCRIPTFUNC_BLURSCROLL,
	SCRIPTFUNC_BLURZOOM,
	SCRIPTFUNC_SCROLL,
	SCRIPTFUNC_MOSAIC,
	SCRIPTFUNC_SPEEDLINE,
	SCRIPTFUNC_RADIALLINE,
	SCRIPTFUNC_CLIP,
	SCRIPTFUNC_BGCOLOR,
	SCRIPTFUNC_WAITFILTER,
	SCRIPTFUNC_WAITSHAKE,
	SCRIPTFUNC_WAITRASTERX,
	SCRIPTFUNC_WAITRASTERY,
	SCRIPTFUNC_WAITWAVEX,
	SCRIPTFUNC_WAITWAVEY,
	SCRIPTFUNC_WAITNOISEX,
	SCRIPTFUNC_WAITNOISEY,
	SCRIPTFUNC_WAITPINBOKE,
	SCRIPTFUNC_WAITVIEW,
	SCRIPTFUNC_WAITVIEWCENTER,
	SCRIPTFUNC_WAITZOOM,
	SCRIPTFUNC_WAITROTATE,
	SCRIPTFUNC_WAITTURN,
	SCRIPTFUNC_WAITBLUR,                  // disabled on switch
	SCRIPTFUNC_WAITSCROLL,
	SCRIPTFUNC_WAITMOSAIC,
	SCRIPTFUNC_WAITSPEEDLINE,
	SCRIPTFUNC_WAITRADIALLINE,
	SCRIPTFUNC_WAITCLIP,
	SCRIPTFUNC_WAITBGCOLOR,
	SCRIPTFUNC_GETSCROLLX,
	SCRIPTFUNC_GETSCROLLY,
	SCRIPTFUNC_SETSTAND,
	SCRIPTFUNC_SETSTANDPOS,
	SCRIPTFUNC_DELSTAND,
	SCRIPTFUNC_CHANGESTAND,
	SCRIPTFUNC_SETSTANDEX,
	SCRIPTFUNC_SETSTANDPOSEX,
	SCRIPTFUNC_DELSTANDEX,
	SCRIPTFUNC_MOVESTAND,
	SCRIPTFUNC_VIEWSTAND,
	SCRIPTFUNC_ZOOMSTAND,
	SCRIPTFUNC_ZOOMCYCLESTAND,
	SCRIPTFUNC_ROTATESTAND,
	SCRIPTFUNC_ROTATESPEEDSTAND,
	SCRIPTFUNC_ROTATECYCLESTAND,
	SCRIPTFUNC_TURNSTAND,
	SCRIPTFUNC_TURNSPEEDSTAND,
	SCRIPTFUNC_TURNCYCLESTAND,
	SCRIPTFUNC_SHAKESTAND,
	SCRIPTFUNC_RASTERXSTAND,
	SCRIPTFUNC_RASTERYSTAND,
	SCRIPTFUNC_WAVEXSTAND,
	SCRIPTFUNC_WAVEYSTAND,
	SCRIPTFUNC_NOISEXSTAND,
	SCRIPTFUNC_NOISEYSTAND,
	SCRIPTFUNC_PINBOKESTAND,
	SCRIPTFUNC_AFTERIMAGESTAND,
	SCRIPTFUNC_FADESTAND,
	SCRIPTFUNC_BLINKSTAND,
	SCRIPTFUNC_MOSAICSTAND,
	SCRIPTFUNC_CLIPSTAND,
	SCRIPTFUNC_LIPSYNCHSTAND,
	SCRIPTFUNC_WAITSTAND,
	SCRIPTFUNC_WAITMOVESTAND,
	SCRIPTFUNC_WAITZOOMSTAND,
	SCRIPTFUNC_WAITVIEWSTAND,
	SCRIPTFUNC_WAITROTATESTAND,
	SCRIPTFUNC_WAITROTATESPEEDSTAND,
	SCRIPTFUNC_WAITTURNSTAND,
	SCRIPTFUNC_WAITTURNSPEEDSTAND,
	SCRIPTFUNC_WAITSHAKESTAND,
	SCRIPTFUNC_WAITRASTERSTAND,
	SCRIPTFUNC_WAITWAVESTAND,
	SCRIPTFUNC_WAITNOISESTAND,
	SCRIPTFUNC_WAITPINBOKESTAND,
	SCRIPTFUNC_WAITAFTERIMAGESTAND,
	SCRIPTFUNC_WAITFADESTAND,
	SCRIPTFUNC_WAITMOSAICSTAND,
	SCRIPTFUNC_WAITCLIPSTAND,
	SCRIPTFUNC_GETSTANDNO,
	SCRIPTFUNC_GETSTANDCHARNO,
	SCRIPTFUNC_GETSTANDX,
	SCRIPTFUNC_GETSTANDY,
	SCRIPTFUNC_GETSTANDACTX,
	SCRIPTFUNC_GETSTANDACTY,
	SCRIPTFUNC_GETSTANDPOSX,
	SCRIPTFUNC_GETSTANDPOSY,
	SCRIPTFUNC_GETSTANDMOVEX,
	SCRIPTFUNC_GETSTANDMOVEY,
	SCRIPTFUNC_GETSTANDFACEX,
	SCRIPTFUNC_GETSTANDFACEY,
	SCRIPTFUNC_GETSTANDWIDTH,
	SCRIPTFUNC_GETSTANDHEIGHT,
	SCRIPTFUNC_ISEXISTSTAND,
	SCRIPTFUNC_SHOWFACE,
	SCRIPTFUNC_HIDEFACE,
	SCRIPTFUNC_SETOBJECT,
	SCRIPTFUNC_SETANIMEOBJECT,
	SCRIPTFUNC_SETSPRITEOBJECT,
	SCRIPTFUNC_SETFONTOBJECT,
	SCRIPTFUNC_SETCHARCODEOBJECT,
	SCRIPTFUNC_SETFILLOBJECT,
	SCRIPTFUNC_SETCOPYOBJECT,
	SCRIPTFUNC_SETCOPYSTANDOBJECT,
  	SCRIPTFUNC_SETCOPYSCREENOBJECT,
	SCRIPTFUNC_SETVISUALOBJECT,
	SCRIPTFUNC_SETFACEOBJECT,
	SCRIPTFUNC_SETMOVIEOBJECT,
	SCRIPTFUNC_DELOBJECT,
	SCRIPTFUNC_MOVEOBJECT,
	SCRIPTFUNC_MOVESPEEDOBJECT,
	SCRIPTFUNC_MOVEVECTOROBJECT,
	SCRIPTFUNC_VIEWOBJECT,
	SCRIPTFUNC_ZOOMOBJECT,
	SCRIPTFUNC_ZOOMCYCLEOBJECT,
	SCRIPTFUNC_ROTATEOBJECT,
	SCRIPTFUNC_ROTATESPEEDOBJECT,
	SCRIPTFUNC_ROTATECYCLEOBJECT,
	SCRIPTFUNC_TURNOBJECT,
	SCRIPTFUNC_TURNSPEEDOBJECT,
	SCRIPTFUNC_TURNCYCLEOBJECT,
	SCRIPTFUNC_SHAKEOBJECT,
	SCRIPTFUNC_RASTERXOBJECT,
	SCRIPTFUNC_RASTERYOBJECT,
	SCRIPTFUNC_WAVEXOBJECT,
	SCRIPTFUNC_WAVEYOBJECT,
	SCRIPTFUNC_NOISEXOBJECT,
	SCRIPTFUNC_NOISEYOBJECT,
	SCRIPTFUNC_PINBOKEOBJECT,
	SCRIPTFUNC_AFTERIMAGEOBJECT,
	SCRIPTFUNC_FADEOBJECT,
	SCRIPTFUNC_BLINKOBJECT,
	SCRIPTFUNC_MOSAICOBJECT,
	SCRIPTFUNC_CLIPOBJECT,
	SCRIPTFUNC_SCROLLLINKOBJECT,
	SCRIPTFUNC_BGMLINKOBJECT,
	SCRIPTFUNC_ROTATELINKOBJECT,
	SCRIPTFUNC_MIRROROBJECT,
	SCRIPTFUNC_TILEOBJECT,
	SCRIPTFUNC_BUTTONOBJECT,
	SCRIPTFUNC_ISENABLEBUTTON,
  	SCRIPTFUNC_SETATTRIBUTEOBJECT,
  	SCRIPTFUNC_SETVOLUMEMOVIEOBJECT,
	SCRIPTFUNC_WAITOBJECT,
	SCRIPTFUNC_WAITMOVEOBJECT,
	SCRIPTFUNC_WAITMOVESPEEDOBJECT,
	SCRIPTFUNC_WAITMOVEVECTOROBJECT,
	SCRIPTFUNC_WAITVIEWOBJECT,
	SCRIPTFUNC_WAITZOOMOBJECT,
	SCRIPTFUNC_WAITROTATEOBJECT,
	SCRIPTFUNC_WAITROTATESPEEDOBJECT,
	SCRIPTFUNC_WAITTURNOBJECT,
	SCRIPTFUNC_WAITTURNSPEEDOBJECT,
	SCRIPTFUNC_WAITSHAKEOBJECT,
	SCRIPTFUNC_WAITRASTEROBJECT,
	SCRIPTFUNC_WAITWAVEOBJECT,
	SCRIPTFUNC_WAITNOISEOBJECT,
	SCRIPTFUNC_WAITPINBOKEOBJECT,
	SCRIPTFUNC_WAITAFTERIMAGEOBJECT,
	SCRIPTFUNC_WAITFADEOBJECT,
	SCRIPTFUNC_WAITMOSAICOBJECT,
	SCRIPTFUNC_WAITCLIPOBJECT,
  	SCRIPTFUNC_SUB_0x185,                 // * Another WAITOBJECT function but not enough information to guess it's name
  	SCRIPTFUNC_STOPOBJECT,
  	SCRIPTFUNC_SETOBJECTORIGIN,
  	SCRIPTFUNC_SETOBJECTZOOMCENTER,
  	SCRIPTFUNC_SETOBJECTROTATECENTER,
  	SCRIPTFUNC_SETOBJECTANIMENO,
	SCRIPTFUNC_GETOBJECTANIMENO,
  	SCRIPTFUNC_GETOBJECTMAXANIMENO,       // *
	SCRIPTFUNC_GETOBJECTX,
	SCRIPTFUNC_GETOBJECTY,
	SCRIPTFUNC_GETOBJECTACTX,
	SCRIPTFUNC_GETOBJECTACTY,
	SCRIPTFUNC_GETOBJECTORIGINX,
	SCRIPTFUNC_GETOBJECTORIGINY,
	SCRIPTFUNC_GETOBJECTWIDTH,
	SCRIPTFUNC_GETOBJECTHEIGHT,
	SCRIPTFUNC_ISEXISTOBJECT,
	SCRIPTFUNC_SEARCHEMPTYOBJECT,
  	SCRIPTFUNC_HITCHECKOBJECT,
  	SCRIPTFUNC_SETOBJECTGROUP,
	SCRIPTFUNC_DELOBJECTGROUP,
	SCRIPTFUNC_INTERVALOBJECTGROUP,
	SCRIPTFUNC_CLIPOBJECTGROUP,
	SCRIPTFUNC_MOVEOBJECTGROUP,
	SCRIPTFUNC_MOVESPEEDOBJECTGROUP,
	SCRIPTFUNC_MOVEVECTOROBJECTGROUP,
	SCRIPTFUNC_ZOOMOBJECTGROUP,
	SCRIPTFUNC_ROTATEOBJECTGROUP,
	SCRIPTFUNC_ROTATESPEEDOBJECTGROUP,
	SCRIPTFUNC_SHAKEOBJECTGROUP,
	SCRIPTFUNC_FADEOBJECTGROUP,
	SCRIPTFUNC_ROTATELINKOBJECTGROUP,
	SCRIPTFUNC_ISEXISTOBJECTGROUP,
	SCRIPTFUNC_SEARCHEMPTYOBJECTGROUP,
  	SCRIPTFUNC_SETCALLOBJECT,
	SCRIPTFUNC_DELCALLOBJECT,
	SCRIPTFUNC_ISEXISTCALLOBJECT,
	SCRIPTFUNC_SETPLANE,
	SCRIPTFUNC_DELPLANE,
	SCRIPTFUNC_SHOWPLANE,
	SCRIPTFUNC_HIDEPLANE,
	SCRIPTFUNC_MOVEPLANE,
	SCRIPTFUNC_WAITPLANE,
	SCRIPTFUNC_GETPLANENO,
  	SCRIPTFUNC_SUB_0x1B1,                 // * Maybe GETPLANE, need confirmation.
  	SCRIPTFUNC_BGMPLAY,
  	SCRIPTFUNC_BGMFADEPLAY,
  	SCRIPTFUNC_BGMFADEOUT,
  	SCRIPTFUNC_BGMFADE,
  	SCRIPTFUNC_BGMSYNCCROSSFADE,
  	SCRIPTFUNC_BGMLOOP,
  	SCRIPTFUNC_BGMPAN,
  	SCRIPTFUNC_BGMSPEED,
  	SCRIPTFUNC_BGMSTOP,
  	SCRIPTFUNC_BGMRESTART,
  	SCRIPTFUNC_WAITBGM,
  	SCRIPTFUNC_GETBGMNO,
  	SCRIPTFUNC_SETBGMSTARTTIME,           // *
  	SCRIPTFUNC_SEPLAY,
	SCRIPTFUNC_SELOOPPLAY,
	SCRIPTFUNC_SEFADEPLAY,
	SCRIPTFUNC_SEFADEOUT,
	SCRIPTFUNC_SEFADE,
	SCRIPTFUNC_SEPAN,
	SCRIPTFUNC_SESPEED,
	SCRIPTFUNC_SESTOP,
	SCRIPTFUNC_WAITSE,
	SCRIPTFUNC_ISEXISTSE,
	SCRIPTFUNC_SYSTEMSEPLAY,
	SCRIPTFUNC_SYSTEMSESTOP,
	SCRIPTFUNC_WAITSYSTEMSE,
	SCRIPTFUNC_VOICEPLAY,
	SCRIPTFUNC_VOICESTOP,
	SCRIPTFUNC_SETVOICECHAR,
	SCRIPTFUNC_SETVOICEVOLUME,
	SCRIPTFUNC_WAITVOICE,
	SCRIPTFUNC_LOOPVOICEPLAY,
	SCRIPTFUNC_LOOPVOICEFADEPLAY,
	SCRIPTFUNC_LOOPVOICEFADEOUT,
	SCRIPTFUNC_LOOPVOICEFADE,
	SCRIPTFUNC_LOOPVOICEPAN,
	SCRIPTFUNC_LOOPVOICESPEED,
	SCRIPTFUNC_LOOPVOICESTOP,
	SCRIPTFUNC_WAITLOOPVOICE,
	SCRIPTFUNC_ISEXISTLOOPVOICE,
	SCRIPTFUNC_SYSTEMVOICEPLAY,
	SCRIPTFUNC_SYSTEMVOICEPLAYFILE,
	SCRIPTFUNC_SYSTEMVOICESTOP,
	SCRIPTFUNC_WAITSYSTEMVOICE,
	SCRIPTFUNC_GETSYSTEMVOICECHARANO,
  	SCRIPTFUNC_INSERTSTRING,
	SCRIPTFUNC_ERASESTRING,
	SCRIPTFUNC_SUBSTRING,
	SCRIPTFUNC_FINDSTRING,
	SCRIPTFUNC_GETSTRINGLENGTH,
  	SCRIPTFUNC_TIPSMENU,                  // disabled on switch
	SCRIPTFUNC_SHOWTIPS,                  // disabled on switch
	SCRIPTFUNC_HIDETIPS,                  // disabled on switch
	SCRIPTFUNC_ADDTIPS,                   // disabled on switch
  	SCRIPTFUNC_SUB_0x1E8,                 // * disabled on switch
  	SCRIPTFUNC_SUB_0x1E9,                 // *
  	SCRIPTFUNC_ENABLERECORDING,           // *
  	SCRIPTFUNC_DISABLERECORDING,          // *
}