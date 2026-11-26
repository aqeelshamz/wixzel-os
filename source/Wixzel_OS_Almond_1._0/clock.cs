using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class clock : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("stopwatch1")]
	private PictureBox _stopwatch1;

	[AccessedThroughProperty("alarm1")]
	private PictureBox _alarm1;

	[AccessedThroughProperty("clock1")]
	private PictureBox _clock1;

	[AccessedThroughProperty("c1")]
	private PictureBox _c1;

	[AccessedThroughProperty("a1")]
	private PictureBox _a1;

	[AccessedThroughProperty("s1")]
	private PictureBox _s1;

	[AccessedThroughProperty("timedisplay")]
	private Label _timedisplay;

	[AccessedThroughProperty("systemtime")]
	private Label _systemtime;

	[AccessedThroughProperty("settings1")]
	private PictureBox _settings1;

	[AccessedThroughProperty("setthing")]
	private Label _setthing;

	[AccessedThroughProperty("ala1")]
	private Label _ala1;

	[AccessedThroughProperty("onoff1")]
	private PictureBox _onoff1;

	[AccessedThroughProperty("del1")]
	private PictureBox _del1;

	[AccessedThroughProperty("lap3")]
	private Label _lap3;

	[AccessedThroughProperty("lap2")]
	private Label _lap2;

	[AccessedThroughProperty("lap1")]
	private Label _lap1;

	[AccessedThroughProperty("lap6")]
	private Label _lap6;

	[AccessedThroughProperty("lap5")]
	private Label _lap5;

	[AccessedThroughProperty("lap4")]
	private Label _lap4;

	[AccessedThroughProperty("lap9")]
	private Label _lap9;

	[AccessedThroughProperty("lap8")]
	private Label _lap8;

	[AccessedThroughProperty("lap7")]
	private Label _lap7;

	[AccessedThroughProperty("lap12")]
	private Label _lap12;

	[AccessedThroughProperty("lap11")]
	private Label _lap11;

	[AccessedThroughProperty("lap10")]
	private Label _lap10;

	[AccessedThroughProperty("start")]
	private PictureBox _start;

	[AccessedThroughProperty("stopp")]
	private PictureBox _stopp;

	[AccessedThroughProperty("restart")]
	private PictureBox _restart;

	[AccessedThroughProperty("timerefresh")]
	private Timer _timerefresh;

	[AccessedThroughProperty("stopwatch")]
	private Timer _stopwatch;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("refresh1")]
	private Timer _refresh1;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	private Point mouse_move;

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox1_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox1_MouseDown);
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove -= val;
				((Control)_PictureBox1).MouseDown -= val2;
				((Control)_PictureBox1).Click -= eventHandler;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove += val;
				((Control)_PictureBox1).MouseDown += val2;
				((Control)_PictureBox1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox2_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox2_MouseDown);
			EventHandler eventHandler = PictureBox2_Click;
			EventHandler eventHandler2 = PictureBox2_MouseLeave;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).MouseDown -= val2;
				((Control)_PictureBox2).Click -= eventHandler;
				((Control)_PictureBox2).MouseLeave -= eventHandler2;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).MouseDown += val2;
				((Control)_PictureBox2).Click += eventHandler;
				((Control)_PictureBox2).MouseLeave += eventHandler2;
			}
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox3_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox3_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox3_MouseDown);
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click -= eventHandler;
				((Control)_PictureBox3).MouseMove -= val;
				((Control)_PictureBox3).MouseDown -= val2;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click += eventHandler;
				((Control)_PictureBox3).MouseMove += val;
				((Control)_PictureBox3).MouseDown += val2;
			}
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label1_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(Label1_MouseDown);
			EventHandler eventHandler = Label1_Click;
			if (_Label1 != null)
			{
				((Control)_Label1).MouseMove -= val;
				((Control)_Label1).MouseDown -= val2;
				((Control)_Label1).Click -= eventHandler;
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).MouseMove += val;
				((Control)_Label1).MouseDown += val2;
				((Control)_Label1).Click += eventHandler;
			}
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	internal virtual PictureBox stopwatch1
	{
		[DebuggerNonUserCode]
		get
		{
			return _stopwatch1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = stopwatch1_Click;
			if (_stopwatch1 != null)
			{
				((Control)_stopwatch1).Click -= eventHandler;
			}
			_stopwatch1 = value;
			if (_stopwatch1 != null)
			{
				((Control)_stopwatch1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox alarm1
	{
		[DebuggerNonUserCode]
		get
		{
			return _alarm1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = alarm1_Click;
			if (_alarm1 != null)
			{
				((Control)_alarm1).Click -= eventHandler;
			}
			_alarm1 = value;
			if (_alarm1 != null)
			{
				((Control)_alarm1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox clock1
	{
		[DebuggerNonUserCode]
		get
		{
			return _clock1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = clock1_Click;
			if (_clock1 != null)
			{
				((Control)_clock1).Click -= eventHandler;
			}
			_clock1 = value;
			if (_clock1 != null)
			{
				((Control)_clock1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox c1
	{
		[DebuggerNonUserCode]
		get
		{
			return _c1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_c1 = value;
		}
	}

	internal virtual PictureBox a1
	{
		[DebuggerNonUserCode]
		get
		{
			return _a1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_a1 = value;
		}
	}

	internal virtual PictureBox s1
	{
		[DebuggerNonUserCode]
		get
		{
			return _s1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_s1 = value;
		}
	}

	internal virtual Label timedisplay
	{
		[DebuggerNonUserCode]
		get
		{
			return _timedisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = timedisplay_Click;
			if (_timedisplay != null)
			{
				((Control)_timedisplay).Click -= eventHandler;
			}
			_timedisplay = value;
			if (_timedisplay != null)
			{
				((Control)_timedisplay).Click += eventHandler;
			}
		}
	}

	internal virtual Label systemtime
	{
		[DebuggerNonUserCode]
		get
		{
			return _systemtime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_systemtime = value;
		}
	}

	internal virtual PictureBox settings1
	{
		[DebuggerNonUserCode]
		get
		{
			return _settings1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = settings1_Click;
			if (_settings1 != null)
			{
				((Control)_settings1).Click -= eventHandler;
			}
			_settings1 = value;
			if (_settings1 != null)
			{
				((Control)_settings1).Click += eventHandler;
			}
		}
	}

	internal virtual Label setthing
	{
		[DebuggerNonUserCode]
		get
		{
			return _setthing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = setthing_Click;
			if (_setthing != null)
			{
				((Control)_setthing).Click -= eventHandler;
			}
			_setthing = value;
			if (_setthing != null)
			{
				((Control)_setthing).Click += eventHandler;
			}
		}
	}

	internal virtual Label ala1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ala1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ala1_Click;
			if (_ala1 != null)
			{
				((Control)_ala1).Click -= eventHandler;
			}
			_ala1 = value;
			if (_ala1 != null)
			{
				((Control)_ala1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox onoff1
	{
		[DebuggerNonUserCode]
		get
		{
			return _onoff1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = onoff1_Click;
			if (_onoff1 != null)
			{
				((Control)_onoff1).Click -= eventHandler;
			}
			_onoff1 = value;
			if (_onoff1 != null)
			{
				((Control)_onoff1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox del1
	{
		[DebuggerNonUserCode]
		get
		{
			return _del1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = del1_Click;
			if (_del1 != null)
			{
				((Control)_del1).Click -= eventHandler;
			}
			_del1 = value;
			if (_del1 != null)
			{
				((Control)_del1).Click += eventHandler;
			}
		}
	}

	internal virtual Label lap3
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap3 = value;
		}
	}

	internal virtual Label lap2
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap2 = value;
		}
	}

	internal virtual Label lap1
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap1 = value;
		}
	}

	internal virtual Label lap6
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap6 = value;
		}
	}

	internal virtual Label lap5
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap5 = value;
		}
	}

	internal virtual Label lap4
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap4 = value;
		}
	}

	internal virtual Label lap9
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap9 = value;
		}
	}

	internal virtual Label lap8
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap8 = value;
		}
	}

	internal virtual Label lap7
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap7 = value;
		}
	}

	internal virtual Label lap12
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap12 = value;
		}
	}

	internal virtual Label lap11
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap11 = value;
		}
	}

	internal virtual Label lap10
	{
		[DebuggerNonUserCode]
		get
		{
			return _lap10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lap10 = value;
		}
	}

	internal virtual PictureBox start
	{
		[DebuggerNonUserCode]
		get
		{
			return _start;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = start_Click;
			if (_start != null)
			{
				((Control)_start).Click -= eventHandler;
			}
			_start = value;
			if (_start != null)
			{
				((Control)_start).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox stopp
	{
		[DebuggerNonUserCode]
		get
		{
			return _stopp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = stopp_Click;
			if (_stopp != null)
			{
				((Control)_stopp).Click -= eventHandler;
			}
			_stopp = value;
			if (_stopp != null)
			{
				((Control)_stopp).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox restart
	{
		[DebuggerNonUserCode]
		get
		{
			return _restart;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = restart_Click;
			if (_restart != null)
			{
				((Control)_restart).Click -= eventHandler;
			}
			_restart = value;
			if (_restart != null)
			{
				((Control)_restart).Click += eventHandler;
			}
		}
	}

	internal virtual Timer timerefresh
	{
		[DebuggerNonUserCode]
		get
		{
			return _timerefresh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = timerefresh_Tick;
			if (_timerefresh != null)
			{
				_timerefresh.Tick -= eventHandler;
			}
			_timerefresh = value;
			if (_timerefresh != null)
			{
				_timerefresh.Tick += eventHandler;
			}
		}
	}

	internal virtual Timer stopwatch
	{
		[DebuggerNonUserCode]
		get
		{
			return _stopwatch;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = stopwatch_Tick;
			if (_stopwatch != null)
			{
				_stopwatch.Tick -= eventHandler;
			}
			_stopwatch = value;
			if (_stopwatch != null)
			{
				_stopwatch.Tick += eventHandler;
			}
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual Timer refresh1
	{
		[DebuggerNonUserCode]
		get
		{
			return _refresh1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = refresh1_Tick;
			if (_refresh1 != null)
			{
				_refresh1.Tick -= eventHandler;
			}
			_refresh1 = value;
			if (_refresh1 != null)
			{
				_refresh1.Tick += eventHandler;
			}
		}
	}

	internal virtual PictureBox defaultclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _defaultclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_defaultclose = value;
		}
	}

	internal virtual PictureBox hoverclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _hoverclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_hoverclose = value;
		}
	}

	internal virtual PictureBox clickclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _clickclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_clickclose = value;
		}
	}

	internal virtual PictureBox PictureBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox7 = value;
		}
	}

	[DebuggerNonUserCode]
	public clock()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(clock_FormClosing);
		((Form)this).Load += clock_Load;
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_04f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected O, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected O, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected O, but got Unknown
		//IL_0aa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab1: Expected O, but got Unknown
		//IL_0b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b88: Expected O, but got Unknown
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3a: Expected O, but got Unknown
		//IL_0cdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce6: Expected O, but got Unknown
		//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected O, but got Unknown
		//IL_0ee3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eed: Expected O, but got Unknown
		//IL_0f92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f9c: Expected O, but got Unknown
		//IL_1041: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Expected O, but got Unknown
		//IL_10f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fa: Expected O, but got Unknown
		//IL_119f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a9: Expected O, but got Unknown
		//IL_124e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1258: Expected O, but got Unknown
		//IL_12fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1307: Expected O, but got Unknown
		//IL_13af: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b9: Expected O, but got Unknown
		//IL_1461: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Expected O, but got Unknown
		//IL_1513: Unknown result type (might be due to invalid IL or missing references)
		//IL_151d: Expected O, but got Unknown
		//IL_15c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cf: Expected O, but got Unknown
		//IL_1677: Unknown result type (might be due to invalid IL or missing references)
		//IL_1681: Expected O, but got Unknown
		//IL_171a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1724: Expected O, but got Unknown
		//IL_17c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cd: Expected O, but got Unknown
		//IL_186f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879: Expected O, but got Unknown
		//IL_1944: Unknown result type (might be due to invalid IL or missing references)
		//IL_194e: Expected O, but got Unknown
		//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fc: Expected O, but got Unknown
		//IL_1aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab9: Expected O, but got Unknown
		//IL_1b55: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5f: Expected O, but got Unknown
		//IL_1bfb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c05: Expected O, but got Unknown
		//IL_1c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(clock));
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		Panel1 = new Panel();
		settings1 = new PictureBox();
		stopwatch1 = new PictureBox();
		alarm1 = new PictureBox();
		clock1 = new PictureBox();
		c1 = new PictureBox();
		a1 = new PictureBox();
		s1 = new PictureBox();
		timedisplay = new Label();
		systemtime = new Label();
		setthing = new Label();
		ala1 = new Label();
		onoff1 = new PictureBox();
		del1 = new PictureBox();
		lap3 = new Label();
		lap2 = new Label();
		lap1 = new Label();
		lap6 = new Label();
		lap5 = new Label();
		lap4 = new Label();
		lap9 = new Label();
		lap8 = new Label();
		lap7 = new Label();
		lap12 = new Label();
		lap11 = new Label();
		lap10 = new Label();
		start = new PictureBox();
		stopp = new PictureBox();
		restart = new PictureBox();
		timerefresh = new Timer(components);
		stopwatch = new Timer(components);
		Label2 = new Label();
		Label3 = new Label();
		refresh1 = new Timer(components);
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox7 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)settings1).BeginInit();
		((ISupportInitialize)stopwatch1).BeginInit();
		((ISupportInitialize)alarm1).BeginInit();
		((ISupportInitialize)clock1).BeginInit();
		((ISupportInitialize)c1).BeginInit();
		((ISupportInitialize)a1).BeginInit();
		((ISupportInitialize)s1).BeginInit();
		((ISupportInitialize)onoff1).BeginInit();
		((ISupportInitialize)del1).BeginInit();
		((ISupportInitialize)start).BeginInit();
		((ISupportInitialize)stopp).BeginInit();
		((ISupportInitialize)restart).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(0, 0);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(1000, 35);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(309, 1);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(51, 34);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 1;
		PictureBox2.TabStop = false;
		((Control)PictureBox3).BackColor = Color.White;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(5, 5);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(22, 22);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 2;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(33, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(49, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 4;
		Label1.Text = "Clock";
		((Control)Panel1).BackColor = Color.Coral;
		((Control)Panel1).Controls.Add((Control)(object)settings1);
		((Control)Panel1).Controls.Add((Control)(object)stopwatch1);
		((Control)Panel1).Controls.Add((Control)(object)alarm1);
		((Control)Panel1).Controls.Add((Control)(object)clock1);
		Panel panel = Panel1;
		location = new Point(0, 33);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(360, 49);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 8;
		((Control)settings1).BackColor = Color.Transparent;
		settings1.Image = (Image)componentResourceManager.GetObject("settings1.Image");
		PictureBox obj = settings1;
		location = new Point(289, 14);
		((Control)obj).Location = location;
		((Control)settings1).Name = "settings1";
		PictureBox obj2 = settings1;
		size = new Size(40, 40);
		((Control)obj2).Size = size;
		settings1.SizeMode = (PictureBoxSizeMode)2;
		settings1.TabIndex = 12;
		settings1.TabStop = false;
		((Control)stopwatch1).BackColor = Color.Transparent;
		stopwatch1.Image = (Image)componentResourceManager.GetObject("stopwatch1.Image");
		PictureBox obj3 = stopwatch1;
		location = new Point(201, 14);
		((Control)obj3).Location = location;
		((Control)stopwatch1).Name = "stopwatch1";
		PictureBox obj4 = stopwatch1;
		size = new Size(40, 40);
		((Control)obj4).Size = size;
		stopwatch1.SizeMode = (PictureBoxSizeMode)2;
		stopwatch1.TabIndex = 11;
		stopwatch1.TabStop = false;
		((Control)alarm1).BackColor = Color.Transparent;
		alarm1.Image = (Image)componentResourceManager.GetObject("alarm1.Image");
		PictureBox obj5 = alarm1;
		location = new Point(113, 14);
		((Control)obj5).Location = location;
		((Control)alarm1).Name = "alarm1";
		PictureBox obj6 = alarm1;
		size = new Size(40, 40);
		((Control)obj6).Size = size;
		alarm1.SizeMode = (PictureBoxSizeMode)2;
		alarm1.TabIndex = 10;
		alarm1.TabStop = false;
		((Control)clock1).BackColor = Color.Transparent;
		clock1.Image = (Image)componentResourceManager.GetObject("clock1.Image");
		PictureBox obj7 = clock1;
		location = new Point(25, 14);
		((Control)obj7).Location = location;
		((Control)clock1).Name = "clock1";
		PictureBox obj8 = clock1;
		size = new Size(40, 40);
		((Control)obj8).Size = size;
		clock1.SizeMode = (PictureBoxSizeMode)2;
		clock1.TabIndex = 9;
		clock1.TabStop = false;
		((Control)c1).BackColor = Color.Transparent;
		c1.Image = (Image)componentResourceManager.GetObject("c1.Image");
		PictureBox obj9 = c1;
		location = new Point(41, 85);
		((Control)obj9).Location = location;
		((Control)c1).Name = "c1";
		PictureBox obj10 = c1;
		size = new Size(10, 10);
		((Control)obj10).Size = size;
		c1.SizeMode = (PictureBoxSizeMode)2;
		c1.TabIndex = 9;
		c1.TabStop = false;
		((Control)a1).BackColor = Color.Transparent;
		a1.Image = (Image)componentResourceManager.GetObject("a1.Image");
		PictureBox obj11 = a1;
		location = new Point(129, 85);
		((Control)obj11).Location = location;
		((Control)a1).Name = "a1";
		PictureBox obj12 = a1;
		size = new Size(10, 10);
		((Control)obj12).Size = size;
		a1.SizeMode = (PictureBoxSizeMode)2;
		a1.TabIndex = 10;
		a1.TabStop = false;
		((Control)a1).Visible = false;
		((Control)s1).BackColor = Color.Transparent;
		s1.Image = (Image)componentResourceManager.GetObject("s1.Image");
		PictureBox obj13 = s1;
		location = new Point(217, 85);
		((Control)obj13).Location = location;
		((Control)s1).Name = "s1";
		PictureBox obj14 = s1;
		size = new Size(10, 10);
		((Control)obj14).Size = size;
		s1.SizeMode = (PictureBoxSizeMode)2;
		s1.TabIndex = 11;
		s1.TabStop = false;
		((Control)s1).Visible = false;
		((Control)timedisplay).Anchor = (AnchorStyles)3;
		((Control)timedisplay).BackColor = Color.Transparent;
		((Control)timedisplay).Font = new Font("Futura Bk BT", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)timedisplay).ForeColor = Color.FromArgb(35, 35, 35);
		Label obj15 = timedisplay;
		location = new Point(56, 130);
		((Control)obj15).Location = location;
		((Control)timedisplay).Name = "timedisplay";
		Label obj16 = timedisplay;
		size = new Size(248, 83);
		((Control)obj16).Size = size;
		((Control)timedisplay).TabIndex = 29;
		timedisplay.Text = "Time";
		timedisplay.TextAlign = (ContentAlignment)32;
		((Control)timedisplay).Visible = false;
		systemtime.AutoSize = true;
		((Control)systemtime).BackColor = Color.Transparent;
		((Control)systemtime).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj17 = systemtime;
		location = new Point(133, 200);
		((Control)obj17).Location = location;
		((Control)systemtime).Name = "systemtime";
		Label obj18 = systemtime;
		size = new Size(96, 19);
		((Control)obj18).Size = size;
		((Control)systemtime).TabIndex = 30;
		systemtime.Text = "System Time";
		((Control)systemtime).Visible = false;
		setthing.AutoSize = true;
		((Control)setthing).BackColor = Color.Transparent;
		((Control)setthing).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj19 = setthing;
		location = new Point(21, 112);
		((Control)obj19).Location = location;
		((Control)setthing).Name = "setthing";
		Label obj20 = setthing;
		size = new Size(95, 19);
		((Control)obj20).Size = size;
		((Control)setthing).TabIndex = 32;
		setthing.Text = "+ Set Alarm";
		((Control)setthing).Visible = false;
		ala1.AutoSize = true;
		((Control)ala1).BackColor = Color.Transparent;
		((Control)ala1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj21 = ala1;
		location = new Point(21, 150);
		((Control)obj21).Location = location;
		((Control)ala1).Name = "ala1";
		Label obj22 = ala1;
		size = new Size(18, 19);
		((Control)obj22).Size = size;
		((Control)ala1).TabIndex = 33;
		ala1.Text = "1";
		((Control)ala1).Visible = false;
		((Control)onoff1).BackColor = Color.Transparent;
		onoff1.Image = (Image)componentResourceManager.GetObject("onoff1.Image");
		PictureBox obj23 = onoff1;
		location = new Point(289, 150);
		((Control)obj23).Location = location;
		((Control)onoff1).Name = "onoff1";
		PictureBox obj24 = onoff1;
		size = new Size(25, 25);
		((Control)obj24).Size = size;
		onoff1.SizeMode = (PictureBoxSizeMode)2;
		onoff1.TabIndex = 13;
		onoff1.TabStop = false;
		((Control)onoff1).Visible = false;
		((Control)del1).BackColor = Color.Transparent;
		del1.Image = (Image)componentResourceManager.GetObject("del1.Image");
		PictureBox obj25 = del1;
		location = new Point(320, 150);
		((Control)obj25).Location = location;
		((Control)del1).Name = "del1";
		PictureBox obj26 = del1;
		size = new Size(25, 25);
		((Control)obj26).Size = size;
		del1.SizeMode = (PictureBoxSizeMode)2;
		del1.TabIndex = 38;
		del1.TabStop = false;
		((Control)del1).Visible = false;
		lap3.AutoSize = true;
		((Control)lap3).BackColor = Color.Transparent;
		((Control)lap3).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj27 = lap3;
		location = new Point(21, 329);
		((Control)obj27).Location = location;
		((Control)lap3).Name = "lap3";
		Label obj28 = lap3;
		size = new Size(18, 19);
		((Control)obj28).Size = size;
		((Control)lap3).TabIndex = 43;
		lap3.Text = "1";
		((Control)lap3).Visible = false;
		lap2.AutoSize = true;
		((Control)lap2).BackColor = Color.Transparent;
		((Control)lap2).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj29 = lap2;
		location = new Point(21, 298);
		((Control)obj29).Location = location;
		((Control)lap2).Name = "lap2";
		Label obj30 = lap2;
		size = new Size(18, 19);
		((Control)obj30).Size = size;
		((Control)lap2).TabIndex = 42;
		lap2.Text = "1";
		((Control)lap2).Visible = false;
		lap1.AutoSize = true;
		((Control)lap1).BackColor = Color.Transparent;
		((Control)lap1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj31 = lap1;
		location = new Point(21, 267);
		((Control)obj31).Location = location;
		((Control)lap1).Name = "lap1";
		Label obj32 = lap1;
		size = new Size(18, 19);
		((Control)obj32).Size = size;
		((Control)lap1).TabIndex = 41;
		lap1.Text = "1";
		((Control)lap1).Visible = false;
		lap6.AutoSize = true;
		((Control)lap6).BackColor = Color.Transparent;
		((Control)lap6).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj33 = lap6;
		location = new Point(121, 329);
		((Control)obj33).Location = location;
		((Control)lap6).Name = "lap6";
		Label obj34 = lap6;
		size = new Size(18, 19);
		((Control)obj34).Size = size;
		((Control)lap6).TabIndex = 46;
		lap6.Text = "1";
		((Control)lap6).Visible = false;
		lap5.AutoSize = true;
		((Control)lap5).BackColor = Color.Transparent;
		((Control)lap5).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj35 = lap5;
		location = new Point(121, 298);
		((Control)obj35).Location = location;
		((Control)lap5).Name = "lap5";
		Label obj36 = lap5;
		size = new Size(18, 19);
		((Control)obj36).Size = size;
		((Control)lap5).TabIndex = 45;
		lap5.Text = "1";
		((Control)lap5).Visible = false;
		lap4.AutoSize = true;
		((Control)lap4).BackColor = Color.Transparent;
		((Control)lap4).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj37 = lap4;
		location = new Point(121, 267);
		((Control)obj37).Location = location;
		((Control)lap4).Name = "lap4";
		Label obj38 = lap4;
		size = new Size(18, 19);
		((Control)obj38).Size = size;
		((Control)lap4).TabIndex = 44;
		lap4.Text = "1";
		((Control)lap4).Visible = false;
		lap9.AutoSize = true;
		((Control)lap9).BackColor = Color.Transparent;
		((Control)lap9).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj39 = lap9;
		location = new Point(213, 329);
		((Control)obj39).Location = location;
		((Control)lap9).Name = "lap9";
		Label obj40 = lap9;
		size = new Size(18, 19);
		((Control)obj40).Size = size;
		((Control)lap9).TabIndex = 49;
		lap9.Text = "1";
		((Control)lap9).Visible = false;
		lap8.AutoSize = true;
		((Control)lap8).BackColor = Color.Transparent;
		((Control)lap8).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj41 = lap8;
		location = new Point(213, 298);
		((Control)obj41).Location = location;
		((Control)lap8).Name = "lap8";
		Label obj42 = lap8;
		size = new Size(18, 19);
		((Control)obj42).Size = size;
		((Control)lap8).TabIndex = 48;
		lap8.Text = "1";
		((Control)lap8).Visible = false;
		lap7.AutoSize = true;
		((Control)lap7).BackColor = Color.Transparent;
		((Control)lap7).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj43 = lap7;
		location = new Point(213, 267);
		((Control)obj43).Location = location;
		((Control)lap7).Name = "lap7";
		Label obj44 = lap7;
		size = new Size(18, 19);
		((Control)obj44).Size = size;
		((Control)lap7).TabIndex = 47;
		lap7.Text = "1";
		((Control)lap7).Visible = false;
		lap12.AutoSize = true;
		((Control)lap12).BackColor = Color.Transparent;
		((Control)lap12).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj45 = lap12;
		location = new Point(301, 329);
		((Control)obj45).Location = location;
		((Control)lap12).Name = "lap12";
		Label obj46 = lap12;
		size = new Size(18, 19);
		((Control)obj46).Size = size;
		((Control)lap12).TabIndex = 52;
		lap12.Text = "1";
		((Control)lap12).Visible = false;
		lap11.AutoSize = true;
		((Control)lap11).BackColor = Color.Transparent;
		((Control)lap11).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj47 = lap11;
		location = new Point(301, 298);
		((Control)obj47).Location = location;
		((Control)lap11).Name = "lap11";
		Label obj48 = lap11;
		size = new Size(18, 19);
		((Control)obj48).Size = size;
		((Control)lap11).TabIndex = 51;
		lap11.Text = "1";
		((Control)lap11).Visible = false;
		lap10.AutoSize = true;
		((Control)lap10).BackColor = Color.Transparent;
		((Control)lap10).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj49 = lap10;
		location = new Point(301, 267);
		((Control)obj49).Location = location;
		((Control)lap10).Name = "lap10";
		Label obj50 = lap10;
		size = new Size(18, 19);
		((Control)obj50).Size = size;
		((Control)lap10).TabIndex = 50;
		lap10.Text = "1";
		((Control)lap10).Visible = false;
		((Control)start).BackColor = Color.Transparent;
		start.Image = (Image)componentResourceManager.GetObject("start.Image");
		PictureBox obj51 = start;
		location = new Point(117, 224);
		((Control)obj51).Location = location;
		((Control)start).Name = "start";
		PictureBox obj52 = start;
		size = new Size(40, 40);
		((Control)obj52).Size = size;
		start.SizeMode = (PictureBoxSizeMode)2;
		start.TabIndex = 13;
		start.TabStop = false;
		((Control)start).Visible = false;
		((Control)stopp).BackColor = Color.Transparent;
		stopp.Image = (Image)componentResourceManager.GetObject("stopp.Image");
		PictureBox obj53 = stopp;
		location = new Point(163, 224);
		((Control)obj53).Location = location;
		((Control)stopp).Name = "stopp";
		PictureBox obj54 = stopp;
		size = new Size(40, 40);
		((Control)obj54).Size = size;
		stopp.SizeMode = (PictureBoxSizeMode)2;
		stopp.TabIndex = 53;
		stopp.TabStop = false;
		((Control)stopp).Visible = false;
		((Control)restart).BackColor = Color.Transparent;
		restart.Image = (Image)componentResourceManager.GetObject("restart.Image");
		PictureBox obj55 = restart;
		location = new Point(209, 224);
		((Control)obj55).Location = location;
		((Control)restart).Name = "restart";
		PictureBox obj56 = restart;
		size = new Size(40, 40);
		((Control)obj56).Size = size;
		restart.SizeMode = (PictureBoxSizeMode)2;
		restart.TabIndex = 54;
		restart.TabStop = false;
		((Control)restart).Visible = false;
		timerefresh.Enabled = true;
		stopwatch.Interval = 1;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.White;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label3 = Label2;
		location = new Point(133, 7);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(19, 20);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 55;
		Label2.Text = "1";
		((Control)Label2).Visible = false;
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.White;
		((Control)Label3).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label5 = Label3;
		location = new Point(157, 7);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(19, 20);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 56;
		Label3.Text = "1";
		((Control)Label3).Visible = false;
		refresh1.Enabled = true;
		refresh1.Interval = 1000;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj57 = defaultclose;
		location = new Point(25, -7);
		((Control)obj57).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj58 = defaultclose;
		size = new Size(51, 34);
		((Control)obj58).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj59 = hoverclose;
		location = new Point(81, -7);
		((Control)obj59).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj60 = hoverclose;
		size = new Size(51, 34);
		((Control)obj60).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj61 = clickclose;
		location = new Point(139, -7);
		((Control)obj61).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj62 = clickclose;
		size = new Size(51, 34);
		((Control)obj62).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox7 = PictureBox7;
		location = new Point(253, 1);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox8 = PictureBox7;
		size = new Size(51, 34);
		((Control)pictureBox8).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 118;
		PictureBox7.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(360, 360);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)restart);
		((Control)this).Controls.Add((Control)(object)stopp);
		((Control)this).Controls.Add((Control)(object)start);
		((Control)this).Controls.Add((Control)(object)lap12);
		((Control)this).Controls.Add((Control)(object)lap11);
		((Control)this).Controls.Add((Control)(object)lap10);
		((Control)this).Controls.Add((Control)(object)lap9);
		((Control)this).Controls.Add((Control)(object)lap8);
		((Control)this).Controls.Add((Control)(object)lap7);
		((Control)this).Controls.Add((Control)(object)lap6);
		((Control)this).Controls.Add((Control)(object)lap5);
		((Control)this).Controls.Add((Control)(object)lap4);
		((Control)this).Controls.Add((Control)(object)lap3);
		((Control)this).Controls.Add((Control)(object)lap2);
		((Control)this).Controls.Add((Control)(object)lap1);
		((Control)this).Controls.Add((Control)(object)del1);
		((Control)this).Controls.Add((Control)(object)onoff1);
		((Control)this).Controls.Add((Control)(object)ala1);
		((Control)this).Controls.Add((Control)(object)setthing);
		((Control)this).Controls.Add((Control)(object)systemtime);
		((Control)this).Controls.Add((Control)(object)timedisplay);
		((Control)this).Controls.Add((Control)(object)s1);
		((Control)this).Controls.Add((Control)(object)a1);
		((Control)this).Controls.Add((Control)(object)c1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "clock";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)settings1).EndInit();
		((ISupportInitialize)stopwatch1).EndInit();
		((ISupportInitialize)alarm1).EndInit();
		((ISupportInitialize)clock1).EndInit();
		((ISupportInitialize)c1).EndInit();
		((ISupportInitialize)a1).EndInit();
		((ISupportInitialize)s1).EndInit();
		((ISupportInitialize)onoff1).EndInit();
		((ISupportInitialize)del1).EndInit();
		((ISupportInitialize)start).EndInit();
		((ISupportInitialize)stopp).EndInit();
		((ISupportInitialize)restart).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void clock1_Click(object sender, EventArgs e)
	{
		((Control)c1).Visible = true;
		((Control)a1).Visible = false;
		((Control)s1).Visible = false;
	}

	private void alarm1_Click(object sender, EventArgs e)
	{
		((Control)c1).Visible = false;
		((Control)a1).Visible = true;
		((Control)s1).Visible = false;
	}

	private void stopwatch1_Click(object sender, EventArgs e)
	{
		timedisplay.Text = "0";
		((Control)c1).Visible = false;
		((Control)a1).Visible = false;
		((Control)s1).Visible = true;
		((Control)timedisplay).Visible = false;
		((Control)systemtime).Visible = false;
	}

	private void settings1_Click(object sender, EventArgs e)
	{
	}

	private void timerefresh_Tick(object sender, EventArgs e)
	{
		Label3.Text = timedisplay.Text;
		if (((Control)c1).Visible)
		{
			stopwatch.Enabled = false;
			((Control)timedisplay).Visible = true;
			((Control)systemtime).Visible = true;
			timedisplay.Text = Strings.Format((object)DateAndTime.Now, "hh:mm:ss tt");
			((Control)start).Visible = false;
			((Control)stopp).Visible = false;
			((Control)restart).Visible = false;
			((Control)setthing).Visible = false;
			((Control)ala1).Visible = false;
			((Control)onoff1).Visible = false;
			((Control)del1).Visible = false;
		}
		else if (((Control)a1).Visible)
		{
			stopwatch.Enabled = false;
			((Control)setthing).Visible = true;
			((Control)ala1).Visible = true;
			((Control)onoff1).Visible = true;
			((Control)timedisplay).Visible = false;
			((Control)systemtime).Visible = false;
			((Control)start).Visible = false;
			((Control)stopp).Visible = false;
			((Control)restart).Visible = false;
			((Control)del1).Visible = true;
		}
		else if (((Control)s1).Visible)
		{
			((Control)timedisplay).Visible = true;
			((Control)start).Visible = true;
			((Control)stopp).Visible = true;
			((Control)restart).Visible = true;
			((Control)setthing).Visible = false;
			((Control)ala1).Visible = false;
			((Control)onoff1).Visible = false;
			((Control)del1).Visible = false;
		}
	}

	private void clock_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.clockout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.cloc.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void clock_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					if (!((Control)MyProject.Forms.home.app1).Enabled)
					{
						goto IL_001e;
					}
					goto IL_0066;
				case 3497:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_001e;
						case 3:
							goto IL_0036;
						case 5:
							goto IL_0066;
						case 6:
							goto IL_0069;
						case 7:
							goto IL_0086;
						case 8:
							goto IL_009e;
						case 10:
							goto IL_00ce;
						case 11:
							goto IL_00d2;
						case 12:
							goto IL_00f0;
						case 13:
							goto IL_0109;
						case 15:
							goto IL_013a;
						case 16:
							goto IL_013e;
						case 17:
							goto IL_015c;
						case 18:
							goto IL_0175;
						case 20:
							goto IL_01a6;
						case 21:
							goto IL_01aa;
						case 22:
							goto IL_01c8;
						case 23:
							goto IL_01e1;
						case 25:
							goto IL_0212;
						case 26:
							goto IL_0216;
						case 27:
							goto IL_0234;
						case 28:
							goto IL_024d;
						case 30:
							goto IL_027e;
						case 31:
							goto IL_0282;
						case 32:
							goto IL_02a0;
						case 33:
							goto IL_02b9;
						case 35:
							goto IL_02ea;
						case 36:
							goto IL_02ee;
						case 37:
							goto IL_030c;
						case 38:
							goto IL_0325;
						case 40:
							goto IL_0356;
						case 41:
							goto IL_035a;
						case 42:
							goto IL_0378;
						case 43:
							goto IL_0391;
						case 45:
							goto IL_03c2;
						case 46:
							goto IL_03c6;
						case 47:
							goto IL_03e4;
						case 48:
							goto IL_03fd;
						case 50:
							goto IL_042e;
						case 51:
							goto IL_0432;
						case 52:
							goto IL_0450;
						case 53:
							goto IL_0469;
						case 55:
							goto IL_049a;
						case 56:
							goto IL_049e;
						case 57:
							goto IL_04bc;
						case 58:
							goto IL_04d5;
						case 60:
							goto IL_0506;
						case 61:
							goto IL_050a;
						case 62:
							goto IL_0528;
						case 63:
							goto IL_0541;
						case 65:
							goto IL_0572;
						case 66:
							goto IL_0576;
						case 67:
							goto IL_0594;
						case 68:
							goto IL_05ad;
						case 70:
							goto IL_05de;
						case 71:
							goto IL_05e2;
						case 72:
							goto IL_0600;
						case 73:
							goto IL_0619;
						case 75:
							goto IL_064a;
						case 76:
							goto IL_064e;
						case 77:
							goto IL_066c;
						case 78:
							goto IL_0685;
						case 80:
							goto IL_06b6;
						case 81:
							goto IL_06ba;
						case 82:
							goto IL_06d8;
						case 83:
							goto IL_06f1;
						case 85:
							goto IL_0722;
						case 86:
							goto IL_0726;
						case 87:
							goto IL_0744;
						case 88:
							goto IL_075d;
						case 90:
							goto IL_078e;
						case 91:
							goto IL_0792;
						case 92:
							goto IL_07b0;
						case 93:
							goto IL_07c9;
						case 95:
							goto IL_07fa;
						case 96:
							goto IL_07fe;
						case 97:
							goto IL_081c;
						case 98:
							goto IL_0835;
						case 100:
							goto IL_0866;
						case 101:
							goto IL_086a;
						case 102:
							goto IL_0888;
						case 103:
							goto IL_08a1;
						case 105:
							goto IL_08d2;
						case 106:
							goto IL_08d6;
						case 107:
							goto IL_08f4;
						case 108:
							goto IL_090d;
						case 110:
							goto IL_093e;
						case 111:
							goto IL_0942;
						case 112:
							goto IL_0960;
						case 113:
							goto IL_0979;
						case 115:
							goto IL_09aa;
						case 116:
							goto IL_09ae;
						case 117:
							goto IL_09cc;
						case 118:
							goto IL_09e5;
						case 120:
							goto IL_0a13;
						case 121:
							goto IL_0a17;
						case 122:
							goto IL_0a35;
						case 123:
							goto IL_0a4e;
						case 4:
						case 9:
						case 14:
						case 19:
						case 24:
						case 29:
						case 34:
						case 39:
						case 44:
						case 49:
						case 54:
						case 59:
						case 64:
						case 69:
						case 74:
						case 79:
						case 84:
						case 89:
						case 94:
						case 99:
						case 104:
						case 109:
						case 114:
						case 119:
						case 124:
						case 125:
						case 126:
						case 127:
						case 128:
						case 129:
						case 130:
						case 131:
						case 132:
						case 133:
						case 134:
						case 135:
						case 136:
						case 137:
						case 138:
						case 139:
						case 140:
						case 141:
						case 142:
						case 143:
						case 144:
						case 145:
						case 146:
						case 147:
						case 148:
						case 149:
							goto IL_0a93;
						case 150:
							goto IL_0a9f;
						case 151:
							goto IL_0aa7;
						case 152:
							goto IL_0ad7;
						case 153:
							goto IL_0b01;
						case 154:
						case 155:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 156:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0aa7:
					num = 151;
					if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt"))
					{
						break;
					}
					goto IL_0ad7;
					IL_0ad7:
					num = 152;
					File.Create(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt");
					goto IL_0b01;
					IL_0a9f:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0aa7;
					IL_0b01:
					num = 153;
					FileSystem.FileClose(new int[0]);
					break;
					IL_001e:
					num = 2;
					((Control)MyProject.Forms.home.app1).Enabled = true;
					goto IL_0036;
					IL_0036:
					num = 3;
					MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0066:
					num = 5;
					goto IL_0069;
					IL_0069:
					num = 6;
					if (!((Control)MyProject.Forms.home.app2).Enabled)
					{
						goto IL_0086;
					}
					goto IL_00ce;
					IL_0086:
					num = 7;
					((Control)MyProject.Forms.home.app2).Enabled = true;
					goto IL_009e;
					IL_009e:
					num = 8;
					MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_00ce:
					num = 10;
					goto IL_00d2;
					IL_00d2:
					num = 11;
					if (!((Control)MyProject.Forms.home.app3).Enabled)
					{
						goto IL_00f0;
					}
					goto IL_013a;
					IL_00f0:
					num = 12;
					((Control)MyProject.Forms.home.app3).Enabled = true;
					goto IL_0109;
					IL_0109:
					num = 13;
					MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_013a:
					num = 15;
					goto IL_013e;
					IL_013e:
					num = 16;
					if (!((Control)MyProject.Forms.home.app4).Enabled)
					{
						goto IL_015c;
					}
					goto IL_01a6;
					IL_015c:
					num = 17;
					((Control)MyProject.Forms.home.app4).Enabled = true;
					goto IL_0175;
					IL_0175:
					num = 18;
					MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_01a6:
					num = 20;
					goto IL_01aa;
					IL_01aa:
					num = 21;
					if (!((Control)MyProject.Forms.home.app5).Enabled)
					{
						goto IL_01c8;
					}
					goto IL_0212;
					IL_01c8:
					num = 22;
					((Control)MyProject.Forms.home.app5).Enabled = true;
					goto IL_01e1;
					IL_01e1:
					num = 23;
					MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0212:
					num = 25;
					goto IL_0216;
					IL_0216:
					num = 26;
					if (!((Control)MyProject.Forms.home.app6).Enabled)
					{
						goto IL_0234;
					}
					goto IL_027e;
					IL_0234:
					num = 27;
					((Control)MyProject.Forms.home.app6).Enabled = true;
					goto IL_024d;
					IL_024d:
					num = 28;
					MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_027e:
					num = 30;
					goto IL_0282;
					IL_0282:
					num = 31;
					if (!((Control)MyProject.Forms.home.app7).Enabled)
					{
						goto IL_02a0;
					}
					goto IL_02ea;
					IL_02a0:
					num = 32;
					((Control)MyProject.Forms.home.app7).Enabled = true;
					goto IL_02b9;
					IL_02b9:
					num = 33;
					MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_02ea:
					num = 35;
					goto IL_02ee;
					IL_02ee:
					num = 36;
					if (!((Control)MyProject.Forms.home.app8).Enabled)
					{
						goto IL_030c;
					}
					goto IL_0356;
					IL_030c:
					num = 37;
					((Control)MyProject.Forms.home.app8).Enabled = true;
					goto IL_0325;
					IL_0325:
					num = 38;
					MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0356:
					num = 40;
					goto IL_035a;
					IL_035a:
					num = 41;
					if (!((Control)MyProject.Forms.home.app9).Enabled)
					{
						goto IL_0378;
					}
					goto IL_03c2;
					IL_0378:
					num = 42;
					((Control)MyProject.Forms.home.app9).Enabled = true;
					goto IL_0391;
					IL_0391:
					num = 43;
					MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_03c2:
					num = 45;
					goto IL_03c6;
					IL_03c6:
					num = 46;
					if (!((Control)MyProject.Forms.home.app10).Enabled)
					{
						goto IL_03e4;
					}
					goto IL_042e;
					IL_03e4:
					num = 47;
					((Control)MyProject.Forms.home.app10).Enabled = true;
					goto IL_03fd;
					IL_03fd:
					num = 48;
					MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_042e:
					num = 50;
					goto IL_0432;
					IL_0432:
					num = 51;
					if (!((Control)MyProject.Forms.home.app11).Enabled)
					{
						goto IL_0450;
					}
					goto IL_049a;
					IL_0450:
					num = 52;
					((Control)MyProject.Forms.home.app11).Enabled = true;
					goto IL_0469;
					IL_0469:
					num = 53;
					MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_049a:
					num = 55;
					goto IL_049e;
					IL_049e:
					num = 56;
					if (!((Control)MyProject.Forms.home.app12).Enabled)
					{
						goto IL_04bc;
					}
					goto IL_0506;
					IL_04bc:
					num = 57;
					((Control)MyProject.Forms.home.app12).Enabled = true;
					goto IL_04d5;
					IL_04d5:
					num = 58;
					MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0506:
					num = 60;
					goto IL_050a;
					IL_050a:
					num = 61;
					if (!((Control)MyProject.Forms.home.app13).Enabled)
					{
						goto IL_0528;
					}
					goto IL_0572;
					IL_0528:
					num = 62;
					((Control)MyProject.Forms.home.app13).Enabled = true;
					goto IL_0541;
					IL_0541:
					num = 63;
					MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0572:
					num = 65;
					goto IL_0576;
					IL_0576:
					num = 66;
					if (!((Control)MyProject.Forms.home.app14).Enabled)
					{
						goto IL_0594;
					}
					goto IL_05de;
					IL_0594:
					num = 67;
					((Control)MyProject.Forms.home.app14).Enabled = true;
					goto IL_05ad;
					IL_05ad:
					num = 68;
					MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_05de:
					num = 70;
					goto IL_05e2;
					IL_05e2:
					num = 71;
					if (!((Control)MyProject.Forms.home.app15).Enabled)
					{
						goto IL_0600;
					}
					goto IL_064a;
					IL_0600:
					num = 72;
					((Control)MyProject.Forms.home.app15).Enabled = true;
					goto IL_0619;
					IL_0619:
					num = 73;
					MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_064a:
					num = 75;
					goto IL_064e;
					IL_064e:
					num = 76;
					if (!((Control)MyProject.Forms.home.app16).Enabled)
					{
						goto IL_066c;
					}
					goto IL_06b6;
					IL_066c:
					num = 77;
					((Control)MyProject.Forms.home.app16).Enabled = true;
					goto IL_0685;
					IL_0685:
					num = 78;
					MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_06b6:
					num = 80;
					goto IL_06ba;
					IL_06ba:
					num = 81;
					if (!((Control)MyProject.Forms.home.app17).Enabled)
					{
						goto IL_06d8;
					}
					goto IL_0722;
					IL_06d8:
					num = 82;
					((Control)MyProject.Forms.home.app17).Enabled = true;
					goto IL_06f1;
					IL_06f1:
					num = 83;
					MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0722:
					num = 85;
					goto IL_0726;
					IL_0726:
					num = 86;
					if (!((Control)MyProject.Forms.home.app18).Enabled)
					{
						goto IL_0744;
					}
					goto IL_078e;
					IL_0744:
					num = 87;
					((Control)MyProject.Forms.home.app18).Enabled = true;
					goto IL_075d;
					IL_075d:
					num = 88;
					MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_078e:
					num = 90;
					goto IL_0792;
					IL_0792:
					num = 91;
					if (!((Control)MyProject.Forms.home.app19).Enabled)
					{
						goto IL_07b0;
					}
					goto IL_07fa;
					IL_07b0:
					num = 92;
					((Control)MyProject.Forms.home.app19).Enabled = true;
					goto IL_07c9;
					IL_07c9:
					num = 93;
					MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_07fa:
					num = 95;
					goto IL_07fe;
					IL_07fe:
					num = 96;
					if (!((Control)MyProject.Forms.home.app20).Enabled)
					{
						goto IL_081c;
					}
					goto IL_0866;
					IL_081c:
					num = 97;
					((Control)MyProject.Forms.home.app20).Enabled = true;
					goto IL_0835;
					IL_0835:
					num = 98;
					MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0866:
					num = 100;
					goto IL_086a;
					IL_086a:
					num = 101;
					if (!((Control)MyProject.Forms.home.app21).Enabled)
					{
						goto IL_0888;
					}
					goto IL_08d2;
					IL_0888:
					num = 102;
					((Control)MyProject.Forms.home.app21).Enabled = true;
					goto IL_08a1;
					IL_08a1:
					num = 103;
					MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_08d2:
					num = 105;
					goto IL_08d6;
					IL_08d6:
					num = 106;
					if (!((Control)MyProject.Forms.home.app22).Enabled)
					{
						goto IL_08f4;
					}
					goto IL_093e;
					IL_08f4:
					num = 107;
					((Control)MyProject.Forms.home.app22).Enabled = true;
					goto IL_090d;
					IL_090d:
					num = 108;
					MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_093e:
					num = 110;
					goto IL_0942;
					IL_0942:
					num = 111;
					if (!((Control)MyProject.Forms.home.app23).Enabled)
					{
						goto IL_0960;
					}
					goto IL_09aa;
					IL_0960:
					num = 112;
					((Control)MyProject.Forms.home.app23).Enabled = true;
					goto IL_0979;
					IL_0979:
					num = 113;
					MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_09aa:
					num = 115;
					goto IL_09ae;
					IL_09ae:
					num = 116;
					if (!((Control)MyProject.Forms.home.app24).Enabled)
					{
						goto IL_09cc;
					}
					goto IL_0a13;
					IL_09cc:
					num = 117;
					((Control)MyProject.Forms.home.app24).Enabled = true;
					goto IL_09e5;
					IL_09e5:
					num = 118;
					MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0a13:
					num = 120;
					goto IL_0a17;
					IL_0a17:
					num = 121;
					if (!((Control)MyProject.Forms.home.app25).Enabled)
					{
						goto IL_0a35;
					}
					goto IL_0a93;
					IL_0a35:
					num = 122;
					((Control)MyProject.Forms.home.app25).Enabled = true;
					goto IL_0a4e;
					IL_0a4e:
					num = 123;
					MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.cloc.Image;
					goto IL_0a93;
					IL_0a93:
					num = 149;
					Fade.clockin();
					goto IL_0a9f;
					end_IL_0001_2:
					break;
				}
				num = 155;
				((Control)this).Refresh();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3497;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void start_Click(object sender, EventArgs e)
	{
		stopwatch.Enabled = true;
	}

	private void stopwatch_Tick(object sender, EventArgs e)
	{
		int num = Conversions.ToInteger(Label3.Text);
		int num2 = Conversions.ToInteger(Label2.Text);
		timedisplay.Text = Conversions.ToString(checked(num + num2));
	}

	private void stopp_Click(object sender, EventArgs e)
	{
		stopwatch.Enabled = false;
	}

	private void restart_Click(object sender, EventArgs e)
	{
		stopwatch.Enabled = false;
		timedisplay.Text = "0";
	}

	private void setthing_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.setalarm).Show();
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void del1_Click(object sender, EventArgs e)
	{
		if (!File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt"))
		{
			File.Create(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt");
			FileSystem.FileClose(new int[0]);
		}
		int num = FileSystem.FreeFile();
		FileSystem.FileOpen(num, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FileClose(new int[0]);
		ala1.Text = "No Alarm";
	}

	private void timedisplay_Click(object sender, EventArgs e)
	{
	}

	private void ala1_Click(object sender, EventArgs e)
	{
	}

	private void refresh1_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamReader streamReader = default(StreamReader);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 118:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0030;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					streamReader = new StreamReader(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt", detectEncodingFromByteOrderMarks: true);
					goto IL_0030;
					IL_0030:
					num = 3;
					ala1.Text = streamReader.ReadToEnd();
					break;
					end_IL_0001_2:
					break;
				}
				num = 4;
				streamReader.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 118;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	private void Label1_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			Point mousePosition = Control.MousePosition;
			mousePosition.Offset(mouse_move.X, mouse_move.Y);
			((Form)this).Location = mousePosition;
		}
	}

	private void Label1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			Point mousePosition = Control.MousePosition;
			mousePosition.Offset(mouse_move.X, mouse_move.Y);
			((Form)this).Location = mousePosition;
		}
	}

	private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			Point mousePosition = Control.MousePosition;
			mousePosition.Offset(mouse_move.X, mouse_move.Y);
			((Form)this).Location = mousePosition;
		}
	}

	private void onoff1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)Control.MouseButtons == 1048576)
		{
			PictureBox2.Image = clickclose.Image;
		}
	}

	private void PictureBox2_MouseLeave(object sender, EventArgs e)
	{
		PictureBox2.Image = defaultclose.Image;
	}

	private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
	{
		if (!((object)PictureBox2.Image).Equals((object?)clickclose.Image))
		{
			PictureBox2.Image = hoverclose.Image;
		}
	}
}
