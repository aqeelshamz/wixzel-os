using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Wixzel_OS_Almond_1._0.My;

[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
[HideModuleName]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyForms
	{
		public about m_about;

		public alarmdata m_alarmdata;

		public appdata m_appdata;

		public apps m_apps;

		public appsabout m_appsabout;

		public boot m_boot;

		public boot1 m_boot1;

		public calculator m_calculator;

		public calendar m_calendar;

		public camera m_camera;

		public clock m_clock;

		public commander m_commander;

		public datacontrolroom m_datacontrolroom;

		public deskdate m_deskdate;

		public desknet m_desknet;

		public desktime m_desktime;

		public dialog m_dialog;

		public diskmanagement m_diskmanagement;

		public files m_files;

		public home m_home;

		public homeicondata m_homeicondata;

		public homeitemdata m_homeitemdata;

		public homemenu m_homemenu;

		public int1 m_int1;

		public int2 m_int2;

		public int3 m_int3;

		public int4 m_int4;

		public int5 m_int5;

		public int6 m_int6;

		public int7 m_int7;

		public lockscreenback m_lockscreenback;

		public logoffwindow m_logoffwindow;

		public logonwindow m_logonwindow;

		public mediaplayer m_mediaplayer;

		public meebrowser m_meebrowser;

		public meemail m_meemail;

		public meemail2 m_meemail2;

		public meemail3 m_meemail3;

		public menuwxl m_menuwxl;

		public ncode m_ncode;

		public openapps m_openapps;

		public paintain m_paintain;

		public password m_password;

		public power m_power;

		public resdialog m_resdialog;

		public screenlit m_screenlit;

		public screenshot m_screenshot;

		public setalarm m_setalarm;

		public settingalarm m_settingalarm;

		public settingapps m_settingapps;

		public settinglockscreen m_settinglockscreen;

		public settingnotification m_settingnotification;

		public settingprofile m_settingprofile;

		public settings m_settings;

		public settingsdata m_settingsdata;

		public settingsecurity m_settingsecurity;

		public standbywindow m_standbywindow;

		public taskshow m_taskshow;

		public tts m_tts;

		public updates m_updates;

		public vboard m_vboard;

		public volume m_volume;

		public wallpapers m_wallpapers;

		public weather m_weather;

		public winexe m_winexe;

		public winexestandby m_winexestandby;

		public wixzeltools m_wixzeltools;

		public wordpro m_wordpro;

		public wordprodata m_wordprodata;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public about about
		{
			[DebuggerNonUserCode]
			get
			{
				m_about = Create__Instance__(m_about);
				return m_about;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_about)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_about);
				}
			}
		}

		public alarmdata alarmdata
		{
			[DebuggerNonUserCode]
			get
			{
				m_alarmdata = Create__Instance__(m_alarmdata);
				return m_alarmdata;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_alarmdata)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_alarmdata);
				}
			}
		}

		public appdata appdata
		{
			[DebuggerNonUserCode]
			get
			{
				m_appdata = Create__Instance__(m_appdata);
				return m_appdata;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_appdata)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_appdata);
				}
			}
		}

		public apps apps
		{
			[DebuggerNonUserCode]
			get
			{
				m_apps = Create__Instance__(m_apps);
				return m_apps;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_apps)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_apps);
				}
			}
		}

		public appsabout appsabout
		{
			[DebuggerNonUserCode]
			get
			{
				m_appsabout = Create__Instance__(m_appsabout);
				return m_appsabout;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_appsabout)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_appsabout);
				}
			}
		}

		public boot boot
		{
			[DebuggerNonUserCode]
			get
			{
				m_boot = Create__Instance__(m_boot);
				return m_boot;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_boot)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_boot);
				}
			}
		}

		public boot1 boot1
		{
			[DebuggerNonUserCode]
			get
			{
				m_boot1 = Create__Instance__(m_boot1);
				return m_boot1;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_boot1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_boot1);
				}
			}
		}

		public calculator calculator
		{
			[DebuggerNonUserCode]
			get
			{
				m_calculator = Create__Instance__(m_calculator);
				return m_calculator;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_calculator)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_calculator);
				}
			}
		}

		public calendar calendar
		{
			[DebuggerNonUserCode]
			get
			{
				m_calendar = Create__Instance__(m_calendar);
				return m_calendar;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_calendar)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_calendar);
				}
			}
		}

		public camera camera
		{
			[DebuggerNonUserCode]
			get
			{
				m_camera = Create__Instance__(m_camera);
				return m_camera;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_camera)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_camera);
				}
			}
		}

		public clock clock
		{
			[DebuggerNonUserCode]
			get
			{
				m_clock = Create__Instance__(m_clock);
				return m_clock;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_clock)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_clock);
				}
			}
		}

		public commander commander
		{
			[DebuggerNonUserCode]
			get
			{
				m_commander = Create__Instance__(m_commander);
				return m_commander;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_commander)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_commander);
				}
			}
		}

		public datacontrolroom datacontrolroom
		{
			[DebuggerNonUserCode]
			get
			{
				m_datacontrolroom = Create__Instance__(m_datacontrolroom);
				return m_datacontrolroom;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_datacontrolroom)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_datacontrolroom);
				}
			}
		}

		public deskdate deskdate
		{
			[DebuggerNonUserCode]
			get
			{
				m_deskdate = Create__Instance__(m_deskdate);
				return m_deskdate;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_deskdate)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_deskdate);
				}
			}
		}

		public desknet desknet
		{
			[DebuggerNonUserCode]
			get
			{
				m_desknet = Create__Instance__(m_desknet);
				return m_desknet;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_desknet)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_desknet);
				}
			}
		}

		public desktime desktime
		{
			[DebuggerNonUserCode]
			get
			{
				m_desktime = Create__Instance__(m_desktime);
				return m_desktime;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_desktime)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_desktime);
				}
			}
		}

		public dialog dialog
		{
			[DebuggerNonUserCode]
			get
			{
				m_dialog = Create__Instance__(m_dialog);
				return m_dialog;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_dialog)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_dialog);
				}
			}
		}

		public diskmanagement diskmanagement
		{
			[DebuggerNonUserCode]
			get
			{
				m_diskmanagement = Create__Instance__(m_diskmanagement);
				return m_diskmanagement;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_diskmanagement)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_diskmanagement);
				}
			}
		}

		public files files
		{
			[DebuggerNonUserCode]
			get
			{
				m_files = Create__Instance__(m_files);
				return m_files;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_files)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_files);
				}
			}
		}

		public home home
		{
			[DebuggerNonUserCode]
			get
			{
				m_home = Create__Instance__(m_home);
				return m_home;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_home)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_home);
				}
			}
		}

		public homeicondata homeicondata
		{
			[DebuggerNonUserCode]
			get
			{
				m_homeicondata = Create__Instance__(m_homeicondata);
				return m_homeicondata;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_homeicondata)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_homeicondata);
				}
			}
		}

		public homeitemdata homeitemdata
		{
			[DebuggerNonUserCode]
			get
			{
				m_homeitemdata = Create__Instance__(m_homeitemdata);
				return m_homeitemdata;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_homeitemdata)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_homeitemdata);
				}
			}
		}

		public homemenu homemenu
		{
			[DebuggerNonUserCode]
			get
			{
				m_homemenu = Create__Instance__(m_homemenu);
				return m_homemenu;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_homemenu)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_homemenu);
				}
			}
		}

		public int1 int1
		{
			[DebuggerNonUserCode]
			get
			{
				m_int1 = Create__Instance__(m_int1);
				return m_int1;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_int1)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_int1);
				}
			}
		}

		public int2 int2
		{
			[DebuggerNonUserCode]
			get
			{
				m_int2 = Create__Instance__(m_int2);
				return m_int2;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_int2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_int2);
				}
			}
		}

		public int3 int3
		{
			[DebuggerNonUserCode]
			get
			{
				m_int3 = Create__Instance__(m_int3);
				return m_int3;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_int3)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_int3);
				}
			}
		}

		public int4 int4
		{
			[DebuggerNonUserCode]
			get
			{
				m_int4 = Create__Instance__(m_int4);
				return m_int4;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_int4)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_int4);
				}
			}
		}

		public int5 int5
		{
			[DebuggerNonUserCode]
			get
			{
				m_int5 = Create__Instance__(m_int5);
				return m_int5;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_int5)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_int5);
				}
			}
		}

		public int6 int6
		{
			[DebuggerNonUserCode]
			get
			{
				m_int6 = Create__Instance__(m_int6);
				return m_int6;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_int6)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_int6);
				}
			}
		}

		public int7 int7
		{
			[DebuggerNonUserCode]
			get
			{
				m_int7 = Create__Instance__(m_int7);
				return m_int7;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_int7)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_int7);
				}
			}
		}

		public lockscreenback lockscreenback
		{
			[DebuggerNonUserCode]
			get
			{
				m_lockscreenback = Create__Instance__(m_lockscreenback);
				return m_lockscreenback;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_lockscreenback)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_lockscreenback);
				}
			}
		}

		public logoffwindow logoffwindow
		{
			[DebuggerNonUserCode]
			get
			{
				m_logoffwindow = Create__Instance__(m_logoffwindow);
				return m_logoffwindow;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_logoffwindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_logoffwindow);
				}
			}
		}

		public logonwindow logonwindow
		{
			[DebuggerNonUserCode]
			get
			{
				m_logonwindow = Create__Instance__(m_logonwindow);
				return m_logonwindow;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_logonwindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_logonwindow);
				}
			}
		}

		public mediaplayer mediaplayer
		{
			[DebuggerNonUserCode]
			get
			{
				m_mediaplayer = Create__Instance__(m_mediaplayer);
				return m_mediaplayer;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_mediaplayer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_mediaplayer);
				}
			}
		}

		public meebrowser meebrowser
		{
			[DebuggerNonUserCode]
			get
			{
				m_meebrowser = Create__Instance__(m_meebrowser);
				return m_meebrowser;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_meebrowser)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_meebrowser);
				}
			}
		}

		public meemail meemail
		{
			[DebuggerNonUserCode]
			get
			{
				m_meemail = Create__Instance__(m_meemail);
				return m_meemail;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_meemail)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_meemail);
				}
			}
		}

		public meemail2 meemail2
		{
			[DebuggerNonUserCode]
			get
			{
				m_meemail2 = Create__Instance__(m_meemail2);
				return m_meemail2;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_meemail2)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_meemail2);
				}
			}
		}

		public meemail3 meemail3
		{
			[DebuggerNonUserCode]
			get
			{
				m_meemail3 = Create__Instance__(m_meemail3);
				return m_meemail3;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_meemail3)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_meemail3);
				}
			}
		}

		public menuwxl menuwxl
		{
			[DebuggerNonUserCode]
			get
			{
				m_menuwxl = Create__Instance__(m_menuwxl);
				return m_menuwxl;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_menuwxl)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_menuwxl);
				}
			}
		}

		public ncode ncode
		{
			[DebuggerNonUserCode]
			get
			{
				m_ncode = Create__Instance__(m_ncode);
				return m_ncode;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_ncode)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_ncode);
				}
			}
		}

		public openapps openapps
		{
			[DebuggerNonUserCode]
			get
			{
				m_openapps = Create__Instance__(m_openapps);
				return m_openapps;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_openapps)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_openapps);
				}
			}
		}

		public paintain paintain
		{
			[DebuggerNonUserCode]
			get
			{
				m_paintain = Create__Instance__(m_paintain);
				return m_paintain;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_paintain)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_paintain);
				}
			}
		}

		public password password
		{
			[DebuggerNonUserCode]
			get
			{
				m_password = Create__Instance__(m_password);
				return m_password;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_password)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_password);
				}
			}
		}

		public power power
		{
			[DebuggerNonUserCode]
			get
			{
				m_power = Create__Instance__(m_power);
				return m_power;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_power)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_power);
				}
			}
		}

		public resdialog resdialog
		{
			[DebuggerNonUserCode]
			get
			{
				m_resdialog = Create__Instance__(m_resdialog);
				return m_resdialog;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_resdialog)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_resdialog);
				}
			}
		}

		public screenlit screenlit
		{
			[DebuggerNonUserCode]
			get
			{
				m_screenlit = Create__Instance__(m_screenlit);
				return m_screenlit;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_screenlit)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_screenlit);
				}
			}
		}

		public screenshot screenshot
		{
			[DebuggerNonUserCode]
			get
			{
				m_screenshot = Create__Instance__(m_screenshot);
				return m_screenshot;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_screenshot)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_screenshot);
				}
			}
		}

		public setalarm setalarm
		{
			[DebuggerNonUserCode]
			get
			{
				m_setalarm = Create__Instance__(m_setalarm);
				return m_setalarm;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_setalarm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_setalarm);
				}
			}
		}

		public settingalarm settingalarm
		{
			[DebuggerNonUserCode]
			get
			{
				m_settingalarm = Create__Instance__(m_settingalarm);
				return m_settingalarm;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settingalarm)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settingalarm);
				}
			}
		}

		public settingapps settingapps
		{
			[DebuggerNonUserCode]
			get
			{
				m_settingapps = Create__Instance__(m_settingapps);
				return m_settingapps;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settingapps)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settingapps);
				}
			}
		}

		public settinglockscreen settinglockscreen
		{
			[DebuggerNonUserCode]
			get
			{
				m_settinglockscreen = Create__Instance__(m_settinglockscreen);
				return m_settinglockscreen;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settinglockscreen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settinglockscreen);
				}
			}
		}

		public settingnotification settingnotification
		{
			[DebuggerNonUserCode]
			get
			{
				m_settingnotification = Create__Instance__(m_settingnotification);
				return m_settingnotification;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settingnotification)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settingnotification);
				}
			}
		}

		public settingprofile settingprofile
		{
			[DebuggerNonUserCode]
			get
			{
				m_settingprofile = Create__Instance__(m_settingprofile);
				return m_settingprofile;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settingprofile)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settingprofile);
				}
			}
		}

		public settings settings
		{
			[DebuggerNonUserCode]
			get
			{
				m_settings = Create__Instance__(m_settings);
				return m_settings;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settings)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settings);
				}
			}
		}

		public settingsdata settingsdata
		{
			[DebuggerNonUserCode]
			get
			{
				m_settingsdata = Create__Instance__(m_settingsdata);
				return m_settingsdata;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settingsdata)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settingsdata);
				}
			}
		}

		public settingsecurity settingsecurity
		{
			[DebuggerNonUserCode]
			get
			{
				m_settingsecurity = Create__Instance__(m_settingsecurity);
				return m_settingsecurity;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_settingsecurity)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_settingsecurity);
				}
			}
		}

		public standbywindow standbywindow
		{
			[DebuggerNonUserCode]
			get
			{
				m_standbywindow = Create__Instance__(m_standbywindow);
				return m_standbywindow;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_standbywindow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_standbywindow);
				}
			}
		}

		public taskshow taskshow
		{
			[DebuggerNonUserCode]
			get
			{
				m_taskshow = Create__Instance__(m_taskshow);
				return m_taskshow;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_taskshow)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_taskshow);
				}
			}
		}

		public tts tts
		{
			[DebuggerNonUserCode]
			get
			{
				m_tts = Create__Instance__(m_tts);
				return m_tts;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_tts)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_tts);
				}
			}
		}

		public updates updates
		{
			[DebuggerNonUserCode]
			get
			{
				m_updates = Create__Instance__(m_updates);
				return m_updates;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_updates)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_updates);
				}
			}
		}

		public vboard vboard
		{
			[DebuggerNonUserCode]
			get
			{
				m_vboard = Create__Instance__(m_vboard);
				return m_vboard;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_vboard)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_vboard);
				}
			}
		}

		public volume volume
		{
			[DebuggerNonUserCode]
			get
			{
				m_volume = Create__Instance__(m_volume);
				return m_volume;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_volume)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_volume);
				}
			}
		}

		public wallpapers wallpapers
		{
			[DebuggerNonUserCode]
			get
			{
				m_wallpapers = Create__Instance__(m_wallpapers);
				return m_wallpapers;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_wallpapers)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_wallpapers);
				}
			}
		}

		public weather weather
		{
			[DebuggerNonUserCode]
			get
			{
				m_weather = Create__Instance__(m_weather);
				return m_weather;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_weather)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_weather);
				}
			}
		}

		public winexe winexe
		{
			[DebuggerNonUserCode]
			get
			{
				m_winexe = Create__Instance__(m_winexe);
				return m_winexe;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_winexe)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_winexe);
				}
			}
		}

		public winexestandby winexestandby
		{
			[DebuggerNonUserCode]
			get
			{
				m_winexestandby = Create__Instance__(m_winexestandby);
				return m_winexestandby;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_winexestandby)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_winexestandby);
				}
			}
		}

		public wixzeltools wixzeltools
		{
			[DebuggerNonUserCode]
			get
			{
				m_wixzeltools = Create__Instance__(m_wixzeltools);
				return m_wixzeltools;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_wixzeltools)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_wixzeltools);
				}
			}
		}

		public wordpro wordpro
		{
			[DebuggerNonUserCode]
			get
			{
				m_wordpro = Create__Instance__(m_wordpro);
				return m_wordpro;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_wordpro)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_wordpro);
				}
			}
		}

		public wordprodata wordprodata
		{
			[DebuggerNonUserCode]
			get
			{
				m_wordprodata = Create__Instance__(m_wordprodata);
				return m_wordprodata;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_wordprodata)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_wordprodata);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || (((Control)Instance).IsDisposed ? true : false))
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
