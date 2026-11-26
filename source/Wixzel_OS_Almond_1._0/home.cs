using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class home : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("datedis")]
	private Label _datedis;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("timedis")]
	private Label _timedis;

	[AccessedThroughProperty("netrange")]
	private PictureBox _netrange;

	[AccessedThroughProperty("app1")]
	private PictureBox _app1;

	[AccessedThroughProperty("app2")]
	private PictureBox _app2;

	[AccessedThroughProperty("app4")]
	private PictureBox _app4;

	[AccessedThroughProperty("app3")]
	private PictureBox _app3;

	[AccessedThroughProperty("app6")]
	private PictureBox _app6;

	[AccessedThroughProperty("app5")]
	private PictureBox _app5;

	[AccessedThroughProperty("app8")]
	private PictureBox _app8;

	[AccessedThroughProperty("app7")]
	private PictureBox _app7;

	[AccessedThroughProperty("app10")]
	private PictureBox _app10;

	[AccessedThroughProperty("app9")]
	private PictureBox _app9;

	[AccessedThroughProperty("app20")]
	private PictureBox _app20;

	[AccessedThroughProperty("app19")]
	private PictureBox _app19;

	[AccessedThroughProperty("app18")]
	private PictureBox _app18;

	[AccessedThroughProperty("app17")]
	private PictureBox _app17;

	[AccessedThroughProperty("app16")]
	private PictureBox _app16;

	[AccessedThroughProperty("app15")]
	private PictureBox _app15;

	[AccessedThroughProperty("app14")]
	private PictureBox _app14;

	[AccessedThroughProperty("app13")]
	private PictureBox _app13;

	[AccessedThroughProperty("app12")]
	private PictureBox _app12;

	[AccessedThroughProperty("app11")]
	private PictureBox _app11;

	[AccessedThroughProperty("app25")]
	private PictureBox _app25;

	[AccessedThroughProperty("app24")]
	private PictureBox _app24;

	[AccessedThroughProperty("app23")]
	private PictureBox _app23;

	[AccessedThroughProperty("app22")]
	private PictureBox _app22;

	[AccessedThroughProperty("app21")]
	private PictureBox _app21;

	[AccessedThroughProperty("taskopen")]
	private PictureBox _taskopen;

	[AccessedThroughProperty("datetimeupdate")]
	private Timer _datetimeupdate;

	[AccessedThroughProperty("volume")]
	private PictureBox _volume;

	[AccessedThroughProperty("notificationbtn")]
	private PictureBox _notificationbtn;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("hometime")]
	private Label _hometime;

	[AccessedThroughProperty("item1")]
	private PictureBox _item1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("itemmove")]
	private Timer _itemmove;

	[AccessedThroughProperty("item1lbl")]
	private Label _item1lbl;

	[AccessedThroughProperty("apptaskbarico")]
	private Timer _apptaskbarico;

	private int intX;

	private int intY;

	private Point point;

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
			_PictureBox1 = value;
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
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click -= eventHandler;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox4_MouseMove);
			EventHandler eventHandler = PictureBox4_MouseLeave;
			EventHandler eventHandler2 = PictureBox4_Click;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).MouseMove -= val;
				((Control)_PictureBox4).MouseLeave -= eventHandler;
				((Control)_PictureBox4).Click -= eventHandler2;
			}
			_PictureBox4 = value;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).MouseMove += val;
				((Control)_PictureBox4).MouseLeave += eventHandler;
				((Control)_PictureBox4).Click += eventHandler2;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox2_MouseLeave;
			MouseEventHandler val = new MouseEventHandler(PictureBox2_MouseMove);
			EventHandler eventHandler2 = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseLeave -= eventHandler;
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).Click -= eventHandler2;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseLeave += eventHandler;
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).Click += eventHandler2;
			}
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual Label datedis
	{
		[DebuggerNonUserCode]
		get
		{
			return _datedis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = datedis_Click;
			if (_datedis != null)
			{
				((Control)_datedis).Click -= eventHandler;
			}
			_datedis = value;
			if (_datedis != null)
			{
				((Control)_datedis).Click += eventHandler;
			}
		}
	}

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (_Timer1 != null)
			{
				_Timer1.Tick -= eventHandler;
			}
			_Timer1 = value;
			if (_Timer1 != null)
			{
				_Timer1.Tick += eventHandler;
			}
		}
	}

	internal virtual Label timedis
	{
		[DebuggerNonUserCode]
		get
		{
			return _timedis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = timedis_Click;
			if (_timedis != null)
			{
				((Control)_timedis).Click -= eventHandler;
			}
			_timedis = value;
			if (_timedis != null)
			{
				((Control)_timedis).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox netrange
	{
		[DebuggerNonUserCode]
		get
		{
			return _netrange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = netrange_Click;
			if (_netrange != null)
			{
				((Control)_netrange).Click -= eventHandler;
			}
			_netrange = value;
			if (_netrange != null)
			{
				((Control)_netrange).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app1
	{
		[DebuggerNonUserCode]
		get
		{
			return _app1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app1_MouseMove);
			EventHandler eventHandler = app1_MouseLeave;
			EventHandler eventHandler2 = app1_Click;
			if (_app1 != null)
			{
				((Control)_app1).MouseMove -= val;
				((Control)_app1).MouseLeave -= eventHandler;
				((Control)_app1).Click -= eventHandler2;
			}
			_app1 = value;
			if (_app1 != null)
			{
				((Control)_app1).MouseMove += val;
				((Control)_app1).MouseLeave += eventHandler;
				((Control)_app1).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox app2
	{
		[DebuggerNonUserCode]
		get
		{
			return _app2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app2_MouseMove);
			EventHandler eventHandler = app2_Click;
			if (_app2 != null)
			{
				((Control)_app2).MouseMove -= val;
				((Control)_app2).Click -= eventHandler;
			}
			_app2 = value;
			if (_app2 != null)
			{
				((Control)_app2).MouseMove += val;
				((Control)_app2).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app4
	{
		[DebuggerNonUserCode]
		get
		{
			return _app4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app4_MouseMove);
			EventHandler eventHandler = app4_Click;
			if (_app4 != null)
			{
				((Control)_app4).MouseMove -= val;
				((Control)_app4).Click -= eventHandler;
			}
			_app4 = value;
			if (_app4 != null)
			{
				((Control)_app4).MouseMove += val;
				((Control)_app4).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app3
	{
		[DebuggerNonUserCode]
		get
		{
			return _app3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app3_MouseMove);
			EventHandler eventHandler = app3_Click;
			if (_app3 != null)
			{
				((Control)_app3).MouseMove -= val;
				((Control)_app3).Click -= eventHandler;
			}
			_app3 = value;
			if (_app3 != null)
			{
				((Control)_app3).MouseMove += val;
				((Control)_app3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app6
	{
		[DebuggerNonUserCode]
		get
		{
			return _app6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app6_MouseMove);
			EventHandler eventHandler = app6_Click;
			if (_app6 != null)
			{
				((Control)_app6).MouseMove -= val;
				((Control)_app6).Click -= eventHandler;
			}
			_app6 = value;
			if (_app6 != null)
			{
				((Control)_app6).MouseMove += val;
				((Control)_app6).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app5
	{
		[DebuggerNonUserCode]
		get
		{
			return _app5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app5_MouseMove);
			EventHandler eventHandler = app5_Click;
			if (_app5 != null)
			{
				((Control)_app5).MouseMove -= val;
				((Control)_app5).Click -= eventHandler;
			}
			_app5 = value;
			if (_app5 != null)
			{
				((Control)_app5).MouseMove += val;
				((Control)_app5).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app8
	{
		[DebuggerNonUserCode]
		get
		{
			return _app8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app8_MouseMove);
			EventHandler eventHandler = app8_Click;
			if (_app8 != null)
			{
				((Control)_app8).MouseMove -= val;
				((Control)_app8).Click -= eventHandler;
			}
			_app8 = value;
			if (_app8 != null)
			{
				((Control)_app8).MouseMove += val;
				((Control)_app8).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app7
	{
		[DebuggerNonUserCode]
		get
		{
			return _app7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app7_MouseMove);
			EventHandler eventHandler = app7_Click;
			if (_app7 != null)
			{
				((Control)_app7).MouseMove -= val;
				((Control)_app7).Click -= eventHandler;
			}
			_app7 = value;
			if (_app7 != null)
			{
				((Control)_app7).MouseMove += val;
				((Control)_app7).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app10
	{
		[DebuggerNonUserCode]
		get
		{
			return _app10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app10_MouseMove);
			EventHandler eventHandler = app10_Click;
			if (_app10 != null)
			{
				((Control)_app10).MouseMove -= val;
				((Control)_app10).Click -= eventHandler;
			}
			_app10 = value;
			if (_app10 != null)
			{
				((Control)_app10).MouseMove += val;
				((Control)_app10).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app9
	{
		[DebuggerNonUserCode]
		get
		{
			return _app9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app9_MouseMove);
			EventHandler eventHandler = app9_Click;
			if (_app9 != null)
			{
				((Control)_app9).MouseMove -= val;
				((Control)_app9).Click -= eventHandler;
			}
			_app9 = value;
			if (_app9 != null)
			{
				((Control)_app9).MouseMove += val;
				((Control)_app9).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app20
	{
		[DebuggerNonUserCode]
		get
		{
			return _app20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app20_MouseMove);
			EventHandler eventHandler = app20_Click;
			if (_app20 != null)
			{
				((Control)_app20).MouseMove -= val;
				((Control)_app20).Click -= eventHandler;
			}
			_app20 = value;
			if (_app20 != null)
			{
				((Control)_app20).MouseMove += val;
				((Control)_app20).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app19
	{
		[DebuggerNonUserCode]
		get
		{
			return _app19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app19_MouseMove);
			EventHandler eventHandler = app19_Click;
			if (_app19 != null)
			{
				((Control)_app19).MouseMove -= val;
				((Control)_app19).Click -= eventHandler;
			}
			_app19 = value;
			if (_app19 != null)
			{
				((Control)_app19).MouseMove += val;
				((Control)_app19).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app18
	{
		[DebuggerNonUserCode]
		get
		{
			return _app18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app18_MouseMove);
			EventHandler eventHandler = app18_Click;
			if (_app18 != null)
			{
				((Control)_app18).MouseMove -= val;
				((Control)_app18).Click -= eventHandler;
			}
			_app18 = value;
			if (_app18 != null)
			{
				((Control)_app18).MouseMove += val;
				((Control)_app18).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app17
	{
		[DebuggerNonUserCode]
		get
		{
			return _app17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app17_MouseMove);
			EventHandler eventHandler = app17_Click;
			if (_app17 != null)
			{
				((Control)_app17).MouseMove -= val;
				((Control)_app17).Click -= eventHandler;
			}
			_app17 = value;
			if (_app17 != null)
			{
				((Control)_app17).MouseMove += val;
				((Control)_app17).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app16
	{
		[DebuggerNonUserCode]
		get
		{
			return _app16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app16_MouseMove);
			EventHandler eventHandler = app16_Click;
			if (_app16 != null)
			{
				((Control)_app16).MouseMove -= val;
				((Control)_app16).Click -= eventHandler;
			}
			_app16 = value;
			if (_app16 != null)
			{
				((Control)_app16).MouseMove += val;
				((Control)_app16).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app15
	{
		[DebuggerNonUserCode]
		get
		{
			return _app15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app15_MouseMove);
			EventHandler eventHandler = app15_Click;
			if (_app15 != null)
			{
				((Control)_app15).MouseMove -= val;
				((Control)_app15).Click -= eventHandler;
			}
			_app15 = value;
			if (_app15 != null)
			{
				((Control)_app15).MouseMove += val;
				((Control)_app15).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app14
	{
		[DebuggerNonUserCode]
		get
		{
			return _app14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app14_MouseMove);
			EventHandler eventHandler = app14_Click;
			if (_app14 != null)
			{
				((Control)_app14).MouseMove -= val;
				((Control)_app14).Click -= eventHandler;
			}
			_app14 = value;
			if (_app14 != null)
			{
				((Control)_app14).MouseMove += val;
				((Control)_app14).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app13
	{
		[DebuggerNonUserCode]
		get
		{
			return _app13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app13_MouseMove);
			EventHandler eventHandler = app13_Click;
			if (_app13 != null)
			{
				((Control)_app13).MouseMove -= val;
				((Control)_app13).Click -= eventHandler;
			}
			_app13 = value;
			if (_app13 != null)
			{
				((Control)_app13).MouseMove += val;
				((Control)_app13).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app12
	{
		[DebuggerNonUserCode]
		get
		{
			return _app12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app12_MouseMove);
			EventHandler eventHandler = app12_Click;
			if (_app12 != null)
			{
				((Control)_app12).MouseMove -= val;
				((Control)_app12).Click -= eventHandler;
			}
			_app12 = value;
			if (_app12 != null)
			{
				((Control)_app12).MouseMove += val;
				((Control)_app12).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app11
	{
		[DebuggerNonUserCode]
		get
		{
			return _app11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app11_MouseMove);
			EventHandler eventHandler = app11_Click;
			if (_app11 != null)
			{
				((Control)_app11).MouseMove -= val;
				((Control)_app11).Click -= eventHandler;
			}
			_app11 = value;
			if (_app11 != null)
			{
				((Control)_app11).MouseMove += val;
				((Control)_app11).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app25
	{
		[DebuggerNonUserCode]
		get
		{
			return _app25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app25_MouseMove);
			EventHandler eventHandler = app25_Click;
			if (_app25 != null)
			{
				((Control)_app25).MouseMove -= val;
				((Control)_app25).Click -= eventHandler;
			}
			_app25 = value;
			if (_app25 != null)
			{
				((Control)_app25).MouseMove += val;
				((Control)_app25).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app24
	{
		[DebuggerNonUserCode]
		get
		{
			return _app24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app24_MouseMove);
			EventHandler eventHandler = app24_Click;
			if (_app24 != null)
			{
				((Control)_app24).MouseMove -= val;
				((Control)_app24).Click -= eventHandler;
			}
			_app24 = value;
			if (_app24 != null)
			{
				((Control)_app24).MouseMove += val;
				((Control)_app24).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app23
	{
		[DebuggerNonUserCode]
		get
		{
			return _app23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app23_MouseMove);
			EventHandler eventHandler = app23_MouseLeave;
			EventHandler eventHandler2 = app23_Click;
			if (_app23 != null)
			{
				((Control)_app23).MouseMove -= val;
				((Control)_app23).MouseLeave -= eventHandler;
				((Control)_app23).Click -= eventHandler2;
			}
			_app23 = value;
			if (_app23 != null)
			{
				((Control)_app23).MouseMove += val;
				((Control)_app23).MouseLeave += eventHandler;
				((Control)_app23).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox app22
	{
		[DebuggerNonUserCode]
		get
		{
			return _app22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app22_MouseMove);
			EventHandler eventHandler = app22_Click;
			if (_app22 != null)
			{
				((Control)_app22).MouseMove -= val;
				((Control)_app22).Click -= eventHandler;
			}
			_app22 = value;
			if (_app22 != null)
			{
				((Control)_app22).MouseMove += val;
				((Control)_app22).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox app21
	{
		[DebuggerNonUserCode]
		get
		{
			return _app21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(app21_MouseMove);
			EventHandler eventHandler = app21_Click;
			if (_app21 != null)
			{
				((Control)_app21).MouseMove -= val;
				((Control)_app21).Click -= eventHandler;
			}
			_app21 = value;
			if (_app21 != null)
			{
				((Control)_app21).MouseMove += val;
				((Control)_app21).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox taskopen
	{
		[DebuggerNonUserCode]
		get
		{
			return _taskopen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_taskopen = value;
		}
	}

	internal virtual Timer datetimeupdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _datetimeupdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = datetimeupdate_Tick;
			if (_datetimeupdate != null)
			{
				_datetimeupdate.Tick -= eventHandler;
			}
			_datetimeupdate = value;
			if (_datetimeupdate != null)
			{
				_datetimeupdate.Tick += eventHandler;
			}
		}
	}

	internal virtual PictureBox volume
	{
		[DebuggerNonUserCode]
		get
		{
			return _volume;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_volume = value;
		}
	}

	internal virtual PictureBox notificationbtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _notificationbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_notificationbtn = value;
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
			_Label1 = value;
		}
	}

	internal virtual Label hometime
	{
		[DebuggerNonUserCode]
		get
		{
			return _hometime;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_hometime = value;
		}
	}

	internal virtual PictureBox item1
	{
		[DebuggerNonUserCode]
		get
		{
			return _item1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			EventHandler eventHandler = item1_DoubleClick;
			EventHandler eventHandler2 = item1_Click;
			MouseEventHandler val = new MouseEventHandler(item1_MouseUp);
			MouseEventHandler val2 = new MouseEventHandler(item1_MouseMove);
			if (_item1 != null)
			{
				((Control)_item1).DoubleClick -= eventHandler;
				((Control)_item1).Click -= eventHandler2;
				((Control)_item1).MouseUp -= val;
				((Control)_item1).MouseMove -= val2;
			}
			_item1 = value;
			if (_item1 != null)
			{
				((Control)_item1).DoubleClick += eventHandler;
				((Control)_item1).Click += eventHandler2;
				((Control)_item1).MouseUp += val;
				((Control)_item1).MouseMove += val2;
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

	internal virtual Timer itemmove
	{
		[DebuggerNonUserCode]
		get
		{
			return _itemmove;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = itemmove_Tick;
			if (_itemmove != null)
			{
				_itemmove.Tick -= eventHandler;
			}
			_itemmove = value;
			if (_itemmove != null)
			{
				_itemmove.Tick += eventHandler;
			}
		}
	}

	internal virtual Label item1lbl
	{
		[DebuggerNonUserCode]
		get
		{
			return _item1lbl;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = item1lbl_Click;
			if (_item1lbl != null)
			{
				((Control)_item1lbl).Click -= eventHandler;
			}
			_item1lbl = value;
			if (_item1lbl != null)
			{
				((Control)_item1lbl).Click += eventHandler;
			}
		}
	}

	internal virtual Timer apptaskbarico
	{
		[DebuggerNonUserCode]
		get
		{
			return _apptaskbarico;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = apptaskbarico_Tick;
			if (_apptaskbarico != null)
			{
				_apptaskbarico.Tick -= eventHandler;
			}
			_apptaskbarico = value;
			if (_apptaskbarico != null)
			{
				_apptaskbarico.Tick += eventHandler;
			}
		}
	}

	public home()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		((Control)this).MouseClick += new MouseEventHandler(home_MouseClick);
		((Control)this).MouseDown += new MouseEventHandler(home_MouseDown);
		((Control)this).MouseMove += new MouseEventHandler(home_MouseMove);
		((Control)this).Click += home_Click;
		((Control)this).DoubleClick += home_DoubleClick;
		((Form)this).Load += home_Load;
		__ENCAddToList(this);
		intX = Screen.PrimaryScreen.Bounds.Width;
		intY = Screen.PrimaryScreen.Bounds.Height;
		point = default(Point);
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
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
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
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
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected O, but got Unknown
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected O, but got Unknown
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_0608: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_0724: Unknown result type (might be due to invalid IL or missing references)
		//IL_072e: Expected O, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected O, but got Unknown
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected O, but got Unknown
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a38: Expected O, but got Unknown
		//IL_0abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Expected O, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected O, but got Unknown
		//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Expected O, but got Unknown
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected O, but got Unknown
		//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cfe: Expected O, but got Unknown
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8c: Expected O, but got Unknown
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Expected O, but got Unknown
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Expected O, but got Unknown
		//IL_0f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f36: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc4: Expected O, but got Unknown
		//IL_1048: Unknown result type (might be due to invalid IL or missing references)
		//IL_1052: Expected O, but got Unknown
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e0: Expected O, but got Unknown
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Expected O, but got Unknown
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fc: Expected O, but got Unknown
		//IL_1280: Unknown result type (might be due to invalid IL or missing references)
		//IL_128a: Expected O, but got Unknown
		//IL_130e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1318: Expected O, but got Unknown
		//IL_139c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Expected O, but got Unknown
		//IL_142a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1434: Expected O, but got Unknown
		//IL_14b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c2: Expected O, but got Unknown
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_1550: Expected O, but got Unknown
		//IL_15d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15de: Expected O, but got Unknown
		//IL_1662: Unknown result type (might be due to invalid IL or missing references)
		//IL_166c: Expected O, but got Unknown
		//IL_16f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fa: Expected O, but got Unknown
		//IL_170c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1716: Expected O, but got Unknown
		//IL_17c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cf: Expected O, but got Unknown
		//IL_17e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17eb: Expected O, but got Unknown
		//IL_186f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879: Expected O, but got Unknown
		//IL_188b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1895: Expected O, but got Unknown
		//IL_1939: Unknown result type (might be due to invalid IL or missing references)
		//IL_1943: Expected O, but got Unknown
		//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fc: Expected O, but got Unknown
		//IL_1a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa6: Expected O, but got Unknown
		//IL_1be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bea: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(home));
		PictureBox1 = new PictureBox();
		PictureBox3 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox2 = new PictureBox();
		ImageList1 = new ImageList(components);
		datedis = new Label();
		Timer1 = new Timer(components);
		timedis = new Label();
		netrange = new PictureBox();
		app1 = new PictureBox();
		app2 = new PictureBox();
		app4 = new PictureBox();
		app3 = new PictureBox();
		app6 = new PictureBox();
		app5 = new PictureBox();
		app8 = new PictureBox();
		app7 = new PictureBox();
		app10 = new PictureBox();
		app9 = new PictureBox();
		app20 = new PictureBox();
		app19 = new PictureBox();
		app18 = new PictureBox();
		app17 = new PictureBox();
		app16 = new PictureBox();
		app15 = new PictureBox();
		app14 = new PictureBox();
		app13 = new PictureBox();
		app12 = new PictureBox();
		app11 = new PictureBox();
		app25 = new PictureBox();
		app24 = new PictureBox();
		app23 = new PictureBox();
		app22 = new PictureBox();
		app21 = new PictureBox();
		taskopen = new PictureBox();
		datetimeupdate = new Timer(components);
		volume = new PictureBox();
		notificationbtn = new PictureBox();
		Label1 = new Label();
		hometime = new Label();
		item1 = new PictureBox();
		Label2 = new Label();
		itemmove = new Timer(components);
		item1lbl = new Label();
		apptaskbarico = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)netrange).BeginInit();
		((ISupportInitialize)app1).BeginInit();
		((ISupportInitialize)app2).BeginInit();
		((ISupportInitialize)app4).BeginInit();
		((ISupportInitialize)app3).BeginInit();
		((ISupportInitialize)app6).BeginInit();
		((ISupportInitialize)app5).BeginInit();
		((ISupportInitialize)app8).BeginInit();
		((ISupportInitialize)app7).BeginInit();
		((ISupportInitialize)app10).BeginInit();
		((ISupportInitialize)app9).BeginInit();
		((ISupportInitialize)app20).BeginInit();
		((ISupportInitialize)app19).BeginInit();
		((ISupportInitialize)app18).BeginInit();
		((ISupportInitialize)app17).BeginInit();
		((ISupportInitialize)app16).BeginInit();
		((ISupportInitialize)app15).BeginInit();
		((ISupportInitialize)app14).BeginInit();
		((ISupportInitialize)app13).BeginInit();
		((ISupportInitialize)app12).BeginInit();
		((ISupportInitialize)app11).BeginInit();
		((ISupportInitialize)app25).BeginInit();
		((ISupportInitialize)app24).BeginInit();
		((ISupportInitialize)app23).BeginInit();
		((ISupportInitialize)app22).BeginInit();
		((ISupportInitialize)app21).BeginInit();
		((ISupportInitialize)taskopen).BeginInit();
		((ISupportInitialize)volume).BeginInit();
		((ISupportInitialize)notificationbtn).BeginInit();
		((ISupportInitialize)item1).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(-5, 872);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(1630, 35);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		((Control)PictureBox3).BackgroundImage = (Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage");
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox3 = PictureBox3;
		location = new Point(36, 846);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox4 = PictureBox3;
		size = new Size(20, 20);
		((Control)pictureBox4).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 2;
		PictureBox3.TabStop = false;
		((Control)PictureBox4).Anchor = (AnchorStyles)0;
		((Control)PictureBox4).BackgroundImage = (Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage");
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox5 = PictureBox4;
		location = new Point(-5, 837);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox6 = PictureBox4;
		size = new Size(35, 35);
		((Control)pictureBox6).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)1;
		PictureBox4.TabIndex = 3;
		PictureBox4.TabStop = false;
		((Control)PictureBox2).BackgroundImage = (Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage");
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox7 = PictureBox2;
		location = new Point(-5, 841);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox8 = PictureBox2;
		size = new Size(25, 25);
		((Control)pictureBox8).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 4;
		PictureBox2.TabStop = false;
		ImageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
		ImageList1.TransparentColor = Color.Transparent;
		ImageList1.Images.SetKeyName(0, "wixzel_menu.png");
		ImageList1.Images.SetKeyName(1, "wixzel_menu_mousemove.png");
		ImageList1.Images.SetKeyName(2, "wixzel_menu_tapped.png");
		datedis.AutoSize = true;
		((Control)datedis).BackColor = Color.White;
		((Control)datedis).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj = datedis;
		location = new Point(1393, 872);
		((Control)obj).Location = location;
		((Control)datedis).Name = "datedis";
		Label obj2 = datedis;
		size = new Size(54, 18);
		((Control)obj2).Size = size;
		((Control)datedis).TabIndex = 5;
		datedis.Text = "Label1";
		Timer1.Enabled = true;
		Timer1.Interval = 500;
		timedis.AutoSize = true;
		((Control)timedis).BackColor = Color.White;
		((Control)timedis).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj3 = timedis;
		location = new Point(1465, 872);
		((Control)obj3).Location = location;
		((Control)timedis).Name = "timedis";
		Label obj4 = timedis;
		size = new Size(54, 18);
		((Control)obj4).Size = size;
		((Control)timedis).TabIndex = 6;
		timedis.Text = "Label2";
		((Control)netrange).BackgroundImage = (Image)componentResourceManager.GetObject("netrange.BackgroundImage");
		netrange.Image = (Image)componentResourceManager.GetObject("netrange.Image");
		PictureBox obj5 = netrange;
		location = new Point(1367, 821);
		((Control)obj5).Location = location;
		((Control)netrange).Name = "netrange";
		PictureBox obj6 = netrange;
		size = new Size(25, 25);
		((Control)obj6).Size = size;
		netrange.SizeMode = (PictureBoxSizeMode)4;
		netrange.TabIndex = 7;
		netrange.TabStop = false;
		((Control)app1).BackgroundImage = (Image)componentResourceManager.GetObject("app1.BackgroundImage");
		PictureBox obj7 = app1;
		location = new Point(293, 762);
		((Control)obj7).Location = location;
		((Control)app1).Name = "app1";
		PictureBox obj8 = app1;
		size = new Size(30, 30);
		((Control)obj8).Size = size;
		app1.SizeMode = (PictureBoxSizeMode)4;
		app1.TabIndex = 8;
		app1.TabStop = false;
		((Control)app2).BackgroundImage = (Image)componentResourceManager.GetObject("app2.BackgroundImage");
		PictureBox obj9 = app2;
		location = new Point(334, 762);
		((Control)obj9).Location = location;
		((Control)app2).Name = "app2";
		PictureBox obj10 = app2;
		size = new Size(30, 30);
		((Control)obj10).Size = size;
		app2.SizeMode = (PictureBoxSizeMode)4;
		app2.TabIndex = 9;
		app2.TabStop = false;
		((Control)app4).BackgroundImage = (Image)componentResourceManager.GetObject("app4.BackgroundImage");
		PictureBox obj11 = app4;
		location = new Point(416, 762);
		((Control)obj11).Location = location;
		((Control)app4).Name = "app4";
		PictureBox obj12 = app4;
		size = new Size(30, 30);
		((Control)obj12).Size = size;
		app4.SizeMode = (PictureBoxSizeMode)4;
		app4.TabIndex = 11;
		app4.TabStop = false;
		((Control)app3).BackgroundImage = (Image)componentResourceManager.GetObject("app3.BackgroundImage");
		PictureBox obj13 = app3;
		location = new Point(375, 762);
		((Control)obj13).Location = location;
		((Control)app3).Name = "app3";
		PictureBox obj14 = app3;
		size = new Size(30, 30);
		((Control)obj14).Size = size;
		app3.SizeMode = (PictureBoxSizeMode)4;
		app3.TabIndex = 10;
		app3.TabStop = false;
		((Control)app6).BackgroundImage = (Image)componentResourceManager.GetObject("app6.BackgroundImage");
		PictureBox obj15 = app6;
		location = new Point(293, 726);
		((Control)obj15).Location = location;
		((Control)app6).Name = "app6";
		PictureBox obj16 = app6;
		size = new Size(30, 30);
		((Control)obj16).Size = size;
		app6.SizeMode = (PictureBoxSizeMode)4;
		app6.TabIndex = 13;
		app6.TabStop = false;
		((Control)app5).BackgroundImage = (Image)componentResourceManager.GetObject("app5.BackgroundImage");
		PictureBox obj17 = app5;
		location = new Point(457, 762);
		((Control)obj17).Location = location;
		((Control)app5).Name = "app5";
		PictureBox obj18 = app5;
		size = new Size(30, 30);
		((Control)obj18).Size = size;
		app5.SizeMode = (PictureBoxSizeMode)4;
		app5.TabIndex = 12;
		app5.TabStop = false;
		((Control)app8).BackgroundImage = (Image)componentResourceManager.GetObject("app8.BackgroundImage");
		PictureBox obj19 = app8;
		location = new Point(375, 726);
		((Control)obj19).Location = location;
		((Control)app8).Name = "app8";
		PictureBox obj20 = app8;
		size = new Size(30, 30);
		((Control)obj20).Size = size;
		app8.SizeMode = (PictureBoxSizeMode)4;
		app8.TabIndex = 15;
		app8.TabStop = false;
		((Control)app7).BackgroundImage = (Image)componentResourceManager.GetObject("app7.BackgroundImage");
		PictureBox obj21 = app7;
		location = new Point(334, 726);
		((Control)obj21).Location = location;
		((Control)app7).Name = "app7";
		PictureBox obj22 = app7;
		size = new Size(30, 30);
		((Control)obj22).Size = size;
		app7.SizeMode = (PictureBoxSizeMode)4;
		app7.TabIndex = 14;
		app7.TabStop = false;
		((Control)app10).BackgroundImage = (Image)componentResourceManager.GetObject("app10.BackgroundImage");
		PictureBox obj23 = app10;
		location = new Point(457, 726);
		((Control)obj23).Location = location;
		((Control)app10).Name = "app10";
		PictureBox obj24 = app10;
		size = new Size(30, 30);
		((Control)obj24).Size = size;
		app10.SizeMode = (PictureBoxSizeMode)4;
		app10.TabIndex = 17;
		app10.TabStop = false;
		((Control)app9).BackgroundImage = (Image)componentResourceManager.GetObject("app9.BackgroundImage");
		PictureBox obj25 = app9;
		location = new Point(416, 726);
		((Control)obj25).Location = location;
		((Control)app9).Name = "app9";
		PictureBox obj26 = app9;
		size = new Size(30, 30);
		((Control)obj26).Size = size;
		app9.SizeMode = (PictureBoxSizeMode)4;
		app9.TabIndex = 16;
		app9.TabStop = false;
		((Control)app20).BackgroundImage = (Image)componentResourceManager.GetObject("app20.BackgroundImage");
		PictureBox obj27 = app20;
		location = new Point(457, 690);
		((Control)obj27).Location = location;
		((Control)app20).Name = "app20";
		PictureBox obj28 = app20;
		size = new Size(30, 30);
		((Control)obj28).Size = size;
		app20.SizeMode = (PictureBoxSizeMode)4;
		app20.TabIndex = 27;
		app20.TabStop = false;
		((Control)app19).BackgroundImage = (Image)componentResourceManager.GetObject("app19.BackgroundImage");
		PictureBox obj29 = app19;
		location = new Point(416, 690);
		((Control)obj29).Location = location;
		((Control)app19).Name = "app19";
		PictureBox obj30 = app19;
		size = new Size(30, 30);
		((Control)obj30).Size = size;
		app19.SizeMode = (PictureBoxSizeMode)4;
		app19.TabIndex = 26;
		app19.TabStop = false;
		((Control)app18).BackgroundImage = (Image)componentResourceManager.GetObject("app18.BackgroundImage");
		PictureBox obj31 = app18;
		location = new Point(375, 690);
		((Control)obj31).Location = location;
		((Control)app18).Name = "app18";
		PictureBox obj32 = app18;
		size = new Size(30, 30);
		((Control)obj32).Size = size;
		app18.SizeMode = (PictureBoxSizeMode)4;
		app18.TabIndex = 25;
		app18.TabStop = false;
		((Control)app17).BackgroundImage = (Image)componentResourceManager.GetObject("app17.BackgroundImage");
		PictureBox obj33 = app17;
		location = new Point(334, 690);
		((Control)obj33).Location = location;
		((Control)app17).Name = "app17";
		PictureBox obj34 = app17;
		size = new Size(30, 30);
		((Control)obj34).Size = size;
		app17.SizeMode = (PictureBoxSizeMode)4;
		app17.TabIndex = 24;
		app17.TabStop = false;
		((Control)app16).BackgroundImage = (Image)componentResourceManager.GetObject("app16.BackgroundImage");
		PictureBox obj35 = app16;
		location = new Point(293, 690);
		((Control)obj35).Location = location;
		((Control)app16).Name = "app16";
		PictureBox obj36 = app16;
		size = new Size(30, 30);
		((Control)obj36).Size = size;
		app16.SizeMode = (PictureBoxSizeMode)4;
		app16.TabIndex = 23;
		app16.TabStop = false;
		((Control)app15).BackgroundImage = (Image)componentResourceManager.GetObject("app15.BackgroundImage");
		PictureBox obj37 = app15;
		location = new Point(457, 618);
		((Control)obj37).Location = location;
		((Control)app15).Name = "app15";
		PictureBox obj38 = app15;
		size = new Size(30, 30);
		((Control)obj38).Size = size;
		app15.SizeMode = (PictureBoxSizeMode)4;
		app15.TabIndex = 22;
		app15.TabStop = false;
		((Control)app14).BackgroundImage = (Image)componentResourceManager.GetObject("app14.BackgroundImage");
		PictureBox obj39 = app14;
		location = new Point(416, 618);
		((Control)obj39).Location = location;
		((Control)app14).Name = "app14";
		PictureBox obj40 = app14;
		size = new Size(30, 30);
		((Control)obj40).Size = size;
		app14.SizeMode = (PictureBoxSizeMode)4;
		app14.TabIndex = 21;
		app14.TabStop = false;
		((Control)app13).BackgroundImage = (Image)componentResourceManager.GetObject("app13.BackgroundImage");
		PictureBox obj41 = app13;
		location = new Point(375, 618);
		((Control)obj41).Location = location;
		((Control)app13).Name = "app13";
		PictureBox obj42 = app13;
		size = new Size(30, 30);
		((Control)obj42).Size = size;
		app13.SizeMode = (PictureBoxSizeMode)4;
		app13.TabIndex = 20;
		app13.TabStop = false;
		((Control)app12).BackgroundImage = (Image)componentResourceManager.GetObject("app12.BackgroundImage");
		PictureBox obj43 = app12;
		location = new Point(334, 618);
		((Control)obj43).Location = location;
		((Control)app12).Name = "app12";
		PictureBox obj44 = app12;
		size = new Size(30, 30);
		((Control)obj44).Size = size;
		app12.SizeMode = (PictureBoxSizeMode)4;
		app12.TabIndex = 19;
		app12.TabStop = false;
		((Control)app11).BackgroundImage = (Image)componentResourceManager.GetObject("app11.BackgroundImage");
		PictureBox obj45 = app11;
		location = new Point(293, 618);
		((Control)obj45).Location = location;
		((Control)app11).Name = "app11";
		PictureBox obj46 = app11;
		size = new Size(30, 30);
		((Control)obj46).Size = size;
		app11.SizeMode = (PictureBoxSizeMode)4;
		app11.TabIndex = 18;
		app11.TabStop = false;
		((Control)app25).BackgroundImage = (Image)componentResourceManager.GetObject("app25.BackgroundImage");
		PictureBox obj47 = app25;
		location = new Point(457, 654);
		((Control)obj47).Location = location;
		((Control)app25).Name = "app25";
		PictureBox obj48 = app25;
		size = new Size(30, 30);
		((Control)obj48).Size = size;
		app25.SizeMode = (PictureBoxSizeMode)4;
		app25.TabIndex = 32;
		app25.TabStop = false;
		((Control)app24).BackgroundImage = (Image)componentResourceManager.GetObject("app24.BackgroundImage");
		PictureBox obj49 = app24;
		location = new Point(416, 654);
		((Control)obj49).Location = location;
		((Control)app24).Name = "app24";
		PictureBox obj50 = app24;
		size = new Size(30, 30);
		((Control)obj50).Size = size;
		app24.SizeMode = (PictureBoxSizeMode)4;
		app24.TabIndex = 31;
		app24.TabStop = false;
		((Control)app23).BackgroundImage = (Image)componentResourceManager.GetObject("app23.BackgroundImage");
		PictureBox obj51 = app23;
		location = new Point(375, 654);
		((Control)obj51).Location = location;
		((Control)app23).Name = "app23";
		PictureBox obj52 = app23;
		size = new Size(30, 30);
		((Control)obj52).Size = size;
		app23.SizeMode = (PictureBoxSizeMode)4;
		app23.TabIndex = 30;
		app23.TabStop = false;
		((Control)app22).BackgroundImage = (Image)componentResourceManager.GetObject("app22.BackgroundImage");
		PictureBox obj53 = app22;
		location = new Point(334, 654);
		((Control)obj53).Location = location;
		((Control)app22).Name = "app22";
		PictureBox obj54 = app22;
		size = new Size(30, 30);
		((Control)obj54).Size = size;
		app22.SizeMode = (PictureBoxSizeMode)4;
		app22.TabIndex = 29;
		app22.TabStop = false;
		((Control)app21).BackgroundImage = (Image)componentResourceManager.GetObject("app21.BackgroundImage");
		PictureBox obj55 = app21;
		location = new Point(293, 654);
		((Control)obj55).Location = location;
		((Control)app21).Name = "app21";
		PictureBox obj56 = app21;
		size = new Size(30, 30);
		((Control)obj56).Size = size;
		app21.SizeMode = (PictureBoxSizeMode)4;
		app21.TabIndex = 28;
		app21.TabStop = false;
		((Control)taskopen).BackgroundImage = (Image)componentResourceManager.GetObject("taskopen.BackgroundImage");
		taskopen.Image = (Image)componentResourceManager.GetObject("taskopen.Image");
		PictureBox obj57 = taskopen;
		location = new Point(29, 547);
		((Control)obj57).Location = location;
		((Control)taskopen).Name = "taskopen";
		PictureBox obj58 = taskopen;
		size = new Size(140, 105);
		((Control)obj58).Size = size;
		taskopen.SizeMode = (PictureBoxSizeMode)2;
		taskopen.TabIndex = 35;
		taskopen.TabStop = false;
		((Control)taskopen).Visible = false;
		datetimeupdate.Enabled = true;
		datetimeupdate.Interval = 1000;
		((Control)volume).BackgroundImage = (Image)componentResourceManager.GetObject("volume.BackgroundImage");
		volume.Image = (Image)componentResourceManager.GetObject("volume.Image");
		PictureBox obj59 = volume;
		location = new Point(1318, 821);
		((Control)obj59).Location = location;
		((Control)volume).Name = "volume";
		PictureBox obj60 = volume;
		size = new Size(25, 25);
		((Control)obj60).Size = size;
		volume.SizeMode = (PictureBoxSizeMode)4;
		volume.TabIndex = 36;
		volume.TabStop = false;
		((Control)notificationbtn).BackgroundImage = (Image)componentResourceManager.GetObject("notificationbtn.BackgroundImage");
		notificationbtn.Image = (Image)componentResourceManager.GetObject("notificationbtn.Image");
		PictureBox obj61 = notificationbtn;
		location = new Point(1271, 821);
		((Control)obj61).Location = location;
		((Control)notificationbtn).Name = "notificationbtn";
		PictureBox obj62 = notificationbtn;
		size = new Size(25, 25);
		((Control)obj62).Size = size;
		notificationbtn.SizeMode = (PictureBoxSizeMode)4;
		notificationbtn.TabIndex = 37;
		notificationbtn.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.White;
		Label label = Label1;
		location = new Point(1373, 768);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(227, 54);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 38;
		Label1.Text = "Wixzel OS 1.0 Beta - Trial\r\nDevelopment in progress\r\nSome features may not available\r\n";
		hometime.AutoSize = true;
		((Control)hometime).BackColor = Color.Transparent;
		((Control)hometime).Font = new Font("Futura Bk BT", 72f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)hometime).ForeColor = Color.White;
		Label obj63 = hometime;
		location = new Point(656, 130);
		((Control)obj63).Location = location;
		((Control)hometime).Name = "hometime";
		Label obj64 = hometime;
		size = new Size(133, 115);
		((Control)obj64).Size = size;
		((Control)hometime).TabIndex = 39;
		hometime.Text = "...";
		((Control)item1).BackColor = Color.Transparent;
		item1.Image = (Image)componentResourceManager.GetObject("item1.Image");
		PictureBox obj65 = item1;
		location = new Point(306, 514);
		((Control)obj65).Location = location;
		((Control)item1).Name = "item1";
		PictureBox obj66 = item1;
		size = new Size(50, 50);
		((Control)obj66).Size = size;
		item1.SizeMode = (PictureBoxSizeMode)4;
		item1.TabIndex = 40;
		item1.TabStop = false;
		Label2.AutoSize = true;
		Label label3 = Label2;
		location = new Point(3, 9);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 41;
		Label2.Text = "Label2";
		((Control)Label2).Visible = false;
		itemmove.Enabled = true;
		itemmove.Interval = 1;
		item1lbl.AutoSize = true;
		((Control)item1lbl).BackColor = Color.Transparent;
		((Control)item1lbl).Font = new Font("Futura Bk BT", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)item1lbl).ForeColor = Color.White;
		Label obj67 = item1lbl;
		location = new Point(303, 567);
		((Control)obj67).Location = location;
		((Control)item1lbl).Name = "item1lbl";
		Label obj68 = item1lbl;
		size = new Size(38, 16);
		((Control)obj68).Size = size;
		((Control)item1lbl).TabIndex = 42;
		item1lbl.Text = "Files";
		apptaskbarico.Enabled = true;
		apptaskbarico.Interval = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.MistyRose;
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		size = new Size(1612, 912);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)item1lbl);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)item1);
		((Control)this).Controls.Add((Control)(object)hometime);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)notificationbtn);
		((Control)this).Controls.Add((Control)(object)volume);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)app25);
		((Control)this).Controls.Add((Control)(object)app24);
		((Control)this).Controls.Add((Control)(object)app23);
		((Control)this).Controls.Add((Control)(object)app22);
		((Control)this).Controls.Add((Control)(object)app21);
		((Control)this).Controls.Add((Control)(object)app20);
		((Control)this).Controls.Add((Control)(object)app19);
		((Control)this).Controls.Add((Control)(object)app18);
		((Control)this).Controls.Add((Control)(object)app17);
		((Control)this).Controls.Add((Control)(object)app16);
		((Control)this).Controls.Add((Control)(object)app15);
		((Control)this).Controls.Add((Control)(object)app14);
		((Control)this).Controls.Add((Control)(object)app13);
		((Control)this).Controls.Add((Control)(object)app12);
		((Control)this).Controls.Add((Control)(object)app11);
		((Control)this).Controls.Add((Control)(object)app10);
		((Control)this).Controls.Add((Control)(object)app9);
		((Control)this).Controls.Add((Control)(object)app8);
		((Control)this).Controls.Add((Control)(object)app7);
		((Control)this).Controls.Add((Control)(object)app6);
		((Control)this).Controls.Add((Control)(object)app5);
		((Control)this).Controls.Add((Control)(object)app4);
		((Control)this).Controls.Add((Control)(object)app3);
		((Control)this).Controls.Add((Control)(object)app2);
		((Control)this).Controls.Add((Control)(object)app1);
		((Control)this).Controls.Add((Control)(object)netrange);
		((Control)this).Controls.Add((Control)(object)timedis);
		((Control)this).Controls.Add((Control)(object)datedis);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)taskopen);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "home";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)0;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)netrange).EndInit();
		((ISupportInitialize)app1).EndInit();
		((ISupportInitialize)app2).EndInit();
		((ISupportInitialize)app4).EndInit();
		((ISupportInitialize)app3).EndInit();
		((ISupportInitialize)app6).EndInit();
		((ISupportInitialize)app5).EndInit();
		((ISupportInitialize)app8).EndInit();
		((ISupportInitialize)app7).EndInit();
		((ISupportInitialize)app10).EndInit();
		((ISupportInitialize)app9).EndInit();
		((ISupportInitialize)app20).EndInit();
		((ISupportInitialize)app19).EndInit();
		((ISupportInitialize)app18).EndInit();
		((ISupportInitialize)app17).EndInit();
		((ISupportInitialize)app16).EndInit();
		((ISupportInitialize)app15).EndInit();
		((ISupportInitialize)app14).EndInit();
		((ISupportInitialize)app13).EndInit();
		((ISupportInitialize)app12).EndInit();
		((ISupportInitialize)app11).EndInit();
		((ISupportInitialize)app25).EndInit();
		((ISupportInitialize)app24).EndInit();
		((ISupportInitialize)app23).EndInit();
		((ISupportInitialize)app22).EndInit();
		((ISupportInitialize)app21).EndInit();
		((ISupportInitialize)taskopen).EndInit();
		((ISupportInitialize)volume).EndInit();
		((ISupportInitialize)notificationbtn).EndInit();
		((ISupportInitialize)item1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void home_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.menuwxl).Hide();
		((Control)MyProject.Forms.apps).Hide();
		PictureBox2.Image = ImageList1.Images[0];
		MyProject.Forms.homeicondata.Label1.Text = "notvis";
	}

	private void home_DoubleClick(object sender, EventArgs e)
	{
	}

	private void home_Load(object sender, EventArgs e)
	{
		Label obj = item1lbl;
		Point point = ((Control)item1).Location;
		checked
		{
			Point location = new Point(point.X + 4, ((Control)item1).Location.Y + ((Control)item1).Height);
			((Control)obj).Location = location;
			((Form)MyProject.Forms.lockscreenback).Close();
			((Form)this).StartPosition = (FormStartPosition)1;
			((Control)this).Width = intX;
			((Control)this).Height = intY;
			PictureBox pictureBox = PictureBox4;
			location = new Point(0, ((Control)this).Height - ((Control)PictureBox4).Height);
			((Control)pictureBox).Location = location;
			point = (((Control)PictureBox1).Location = new Point(((Control)PictureBox4).Location.X, ((Control)PictureBox4).Location.Y));
			point = (((Control)PictureBox2).Location = new Point(((Control)PictureBox4).Location.X + 5, ((Control)PictureBox4).Location.Y + 5));
			point = (((Control)PictureBox3).Location = new Point(((Control)PictureBox2).Location.X + 45, ((Control)PictureBox2).Location.Y + 3));
			point = (((Control)app1).Location = new Point(((Control)PictureBox3).Location.X + 45, ((Control)PictureBox4).Location.Y + 3));
			point = (((Control)app2).Location = new Point(((Control)app1).Location.X + ((Control)app1).Width + 10, ((Control)app1).Location.Y));
			point = (((Control)app3).Location = new Point(((Control)app2).Location.X + ((Control)app2).Width + 10, ((Control)app2).Location.Y));
			point = (((Control)app4).Location = new Point(((Control)app3).Location.X + ((Control)app3).Width + 10, ((Control)app3).Location.Y));
			point = (((Control)app5).Location = new Point(((Control)app4).Location.X + ((Control)app4).Width + 10, ((Control)app4).Location.Y));
			point = (((Control)app6).Location = new Point(((Control)app5).Location.X + ((Control)app5).Width + 10, ((Control)app5).Location.Y));
			point = (((Control)app7).Location = new Point(((Control)app6).Location.X + ((Control)app6).Width + 10, ((Control)app6).Location.Y));
			point = (((Control)app8).Location = new Point(((Control)app7).Location.X + ((Control)app7).Width + 10, ((Control)app7).Location.Y));
			point = (((Control)app9).Location = new Point(((Control)app8).Location.X + ((Control)app8).Width + 10, ((Control)app8).Location.Y));
			point = (((Control)app10).Location = new Point(((Control)app9).Location.X + ((Control)app9).Width + 10, ((Control)app9).Location.Y));
			point = (((Control)app11).Location = new Point(((Control)app10).Location.X + ((Control)app10).Width + 10, ((Control)app10).Location.Y));
			point = (((Control)app12).Location = new Point(((Control)app11).Location.X + ((Control)app11).Width + 10, ((Control)app11).Location.Y));
			point = (((Control)app13).Location = new Point(((Control)app12).Location.X + ((Control)app12).Width + 10, ((Control)app12).Location.Y));
			point = (((Control)app14).Location = new Point(((Control)app13).Location.X + ((Control)app13).Width + 10, ((Control)app13).Location.Y));
			point = (((Control)app15).Location = new Point(((Control)app14).Location.X + ((Control)app14).Width + 10, ((Control)app14).Location.Y));
			point = (((Control)app16).Location = new Point(((Control)app15).Location.X + ((Control)app15).Width + 10, ((Control)app15).Location.Y));
			point = (((Control)app17).Location = new Point(((Control)app16).Location.X + ((Control)app16).Width + 10, ((Control)app16).Location.Y));
			point = (((Control)app18).Location = new Point(((Control)app17).Location.X + ((Control)app17).Width + 10, ((Control)app17).Location.Y));
			point = (((Control)app19).Location = new Point(((Control)app18).Location.X + ((Control)app18).Width + 10, ((Control)app18).Location.Y));
			point = (((Control)app20).Location = new Point(((Control)app19).Location.X + ((Control)app19).Width + 10, ((Control)app19).Location.Y));
			point = (((Control)app21).Location = new Point(((Control)app20).Location.X + ((Control)app20).Width + 10, ((Control)app20).Location.Y));
			point = (((Control)app22).Location = new Point(((Control)app21).Location.X + ((Control)app21).Width + 10, ((Control)app21).Location.Y));
			point = (((Control)app23).Location = new Point(((Control)app22).Location.X + ((Control)app22).Width + 10, ((Control)app22).Location.Y));
			point = (((Control)app24).Location = new Point(((Control)app23).Location.X + ((Control)app23).Width + 10, ((Control)app23).Location.Y));
			point = (((Control)app25).Location = new Point(((Control)app24).Location.X + ((Control)app24).Width + 10, ((Control)app24).Location.Y));
			Label obj2 = timedis;
			location = new Point(((Control)this).Width - ((Control)timedis).Width - 45, ((Control)this).Height - ((Control)timedis).Height - 8);
			((Control)obj2).Location = location;
			point = (((Control)datedis).Location = new Point(((Control)timedis).Location.X - ((Control)datedis).Width - 20, ((Control)timedis).Location.Y));
			point = (((Control)netrange).Location = new Point(((Control)datedis).Location.X - ((Control)netrange).Width, ((Control)datedis).Location.Y - 4));
			point = (((Control)volume).Location = new Point(((Control)netrange).Location.X - ((Control)volume).Width, ((Control)netrange).Location.Y));
			point = (((Control)notificationbtn).Location = new Point(((Control)volume).Location.X - ((Control)notificationbtn).Width, ((Control)volume).Location.Y));
			Label label = Label1;
			location = new Point(((Control)this).Width - ((Control)Label1).Width, ((Control)this).Height - ((Control)PictureBox1).Height * 3 - 2);
			((Control)label).Location = location;
			((Control)app1).Enabled = false;
			((Control)app2).Enabled = false;
			((Control)app3).Enabled = false;
			((Control)app4).Enabled = false;
			((Control)app5).Enabled = false;
			((Control)app6).Enabled = false;
			((Control)app7).Enabled = false;
			((Control)app8).Enabled = false;
			((Control)app9).Enabled = false;
			((Control)app10).Enabled = false;
			((Control)app11).Enabled = false;
			((Control)app12).Enabled = false;
			((Control)app13).Enabled = false;
			((Control)app14).Enabled = false;
			((Control)app15).Enabled = false;
			((Control)app16).Enabled = false;
			((Control)app17).Enabled = false;
			((Control)app18).Enabled = false;
			((Control)app19).Enabled = false;
			((Control)app20).Enabled = false;
			((Control)app21).Enabled = false;
			((Control)app22).Enabled = false;
			((Control)app23).Enabled = false;
			((Control)app24).Enabled = false;
			((Control)app25).Enabled = false;
			((Form)this).TopMost = false;
			datedis.Text = Strings.Format((object)DateAndTime.Now, "mmm:yyyy");
			timedis.Text = Strings.Format((object)DateAndTime.Now, "hh:mm tt");
			hometime.Text = Strings.Format((object)DateAndTime.Now, "hh:mm");
			Label obj3 = hometime;
			location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)hometime).Width / 2.0), (int)Math.Round((double)((Control)this).Height / 6.0));
			((Control)obj3).Location = location;
			((Form)this).Opacity = 100.0;
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		MyProject.Forms.homeicondata.Label2.Text = "notvis";
		((Control)MyProject.Forms.taskshow).Hide();
		((Control)MyProject.Forms.homemenu).Hide();
		if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "notvis", false) == 0)
		{
			((Control)MyProject.Forms.menuwxl).Show();
			((Form)MyProject.Forms.menuwxl).TopMost = true;
			PictureBox2.Image = ImageList1.Images[2];
			MyProject.Forms.homeicondata.Label1.Text = "vis";
		}
		else if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "vis", false) == 0)
		{
			((Control)MyProject.Forms.menuwxl).Hide();
			PictureBox2.Image = ImageList1.Images[0];
			MyProject.Forms.homeicondata.Label1.Text = "notvis";
		}
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		MyProject.Forms.homeicondata.Label2.Text = "notvis";
		((Control)MyProject.Forms.homemenu).Hide();
		if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "vis", false) == 0)
		{
			((Control)MyProject.Forms.menuwxl).Hide();
			PictureBox2.Image = ImageList1.Images[0];
			MyProject.Forms.homeicondata.Label1.Text = "notvis";
		}
		else if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "notvis", false) == 0)
		{
			((Control)MyProject.Forms.menuwxl).Show();
			((Form)MyProject.Forms.menuwxl).TopMost = true;
			PictureBox2.Image = ImageList1.Images[2];
			MyProject.Forms.homeicondata.Label1.Text = "vis";
		}
	}

	private void PictureBox2_MouseLeave(object sender, EventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "vis", false) == 0)
		{
			PictureBox2.Image = ImageList1.Images[2];
		}
		else
		{
			PictureBox2.Image = ImageList1.Images[0];
		}
		if (((object)PictureBox2.Image).Equals((object?)ImageList1.Images[2]))
		{
			MyProject.Forms.homeicondata.Label1.Text = "vis";
		}
	}

	private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox2.Image = ImageList1.Images[1];
	}

	private void PictureBox4_MouseLeave(object sender, EventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "vis", false) == 0)
		{
			PictureBox2.Image = ImageList1.Images[2];
		}
		else
		{
			PictureBox2.Image = ImageList1.Images[0];
		}
		if (((object)PictureBox2.Image).Equals((object?)ImageList1.Images[2]))
		{
			MyProject.Forms.homeicondata.Label1.Text = "vis";
		}
	}

	private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox2.Image = ImageList1.Images[1];
	}

	private void home_MouseClick(object sender, MouseEventArgs e)
	{
	}

	private void home_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Invalid comparison between Unknown and I4
		Label2.Text = "";
		((Control)item1).BackColor = Color.Transparent;
		if ((int)Control.MouseButtons == 2097152)
		{
			((Control)MyProject.Forms.menuwxl.PictureBox8).Visible = false;
			((Control)MyProject.Forms.menuwxl.PictureBox9).Visible = false;
			((Control)MyProject.Forms.menuwxl.PictureBox13).Visible = false;
			((Control)MyProject.Forms.menuwxl.PictureBox10).Visible = false;
			Point mousePosition = Control.MousePosition;
			MyProject.Forms.homeicondata.Label2.Text = "vis";
			((Control)MyProject.Forms.homemenu).Show();
			((Form)MyProject.Forms.homemenu).Location = mousePosition;
			((Form)MyProject.Forms.homemenu).TopMost = true;
		}
		if ((int)Control.MouseButtons == 1048576)
		{
			((Control)MyProject.Forms.menuwxl.PictureBox8).Visible = false;
			((Control)MyProject.Forms.menuwxl.PictureBox9).Visible = false;
			((Control)MyProject.Forms.menuwxl.PictureBox13).Visible = false;
			((Control)MyProject.Forms.menuwxl.PictureBox10).Visible = false;
			MyProject.Forms.homeicondata.Label2.Text = "notvis";
			((Form)MyProject.Forms.desknet).Close();
			((Form)MyProject.Forms.desktime).Close();
			((Form)MyProject.Forms.deskdate).Close();
			((Form)MyProject.Forms.openapps).Close();
		}
	}

	private void datedis_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.desknet).Hide();
		((Control)MyProject.Forms.desktime).Hide();
		if (!((Control)MyProject.Forms.deskdate).Visible)
		{
			((Control)MyProject.Forms.deskdate).Show();
			deskdate obj = MyProject.Forms.deskdate;
			Point location = checked(new Point(((Control)timedis).Location.X - ((Control)timedis).Width * 3, ((Control)this).Height - ((Control)MyProject.Forms.desktime).Height - ((Control)PictureBox1).Height));
			((Form)obj).Location = location;
		}
		else
		{
			((Form)MyProject.Forms.deskdate).Close();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
	}

	private void netrange_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.deskdate).Hide();
		((Control)MyProject.Forms.desktime).Hide();
		if (!((Control)MyProject.Forms.desknet).Visible)
		{
			((Control)MyProject.Forms.desknet).Show();
			desknet obj = MyProject.Forms.desknet;
			Point location = checked(new Point(((Control)netrange).Location.X - ((Control)netrange).Width * 6, ((Control)this).Height - ((Control)MyProject.Forms.desknet).Height - ((Control)PictureBox1).Height));
			((Form)obj).Location = location;
		}
		else
		{
			((Form)MyProject.Forms.desknet).Close();
		}
	}

	private void app1_Click(object sender, EventArgs e)
	{
		if (app1.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app1.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app1_MouseLeave(object sender, EventArgs e)
	{
	}

	private void app1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app1).Location.X - ((Control)app1).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app1.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app1.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app1.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app1.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app1.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app1.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app1.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app1.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app1.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app1.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app1.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app1.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app1.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app1.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app1.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app1.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app1.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app1.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app1.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app1.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app1.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app1.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app2_Click(object sender, EventArgs e)
	{
		if (app2.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app2.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void app3_Click(object sender, EventArgs e)
	{
		if (app3.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app3.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void app4_Click(object sender, EventArgs e)
	{
		if (app4.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app4.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void app5_Click(object sender, EventArgs e)
	{
		if (app5.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app5.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void app6_Click(object sender, EventArgs e)
	{
		if (app6.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
		else if (app6.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void app7_Click(object sender, EventArgs e)
	{
		if (app7.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app7.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app8_Click(object sender, EventArgs e)
	{
		if (app8.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app8.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app9_Click(object sender, EventArgs e)
	{
		if (app9.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app9.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app10_Click(object sender, EventArgs e)
	{
		if (app10.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app10.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void app11_Click(object sender, EventArgs e)
	{
		if (app11.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app11.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app12_Click(object sender, EventArgs e)
	{
		if (app12.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app12.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app13_Click(object sender, EventArgs e)
	{
		if (app13.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app13.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app14_Click(object sender, EventArgs e)
	{
		if (app14.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app14.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app15_Click(object sender, EventArgs e)
	{
		if (app15.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app15.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app16_Click(object sender, EventArgs e)
	{
		if (app16.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app16.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void app17_Click(object sender, EventArgs e)
	{
		if (app17.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app17.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app18_Click(object sender, EventArgs e)
	{
		if (app18.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app18.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app19_Click(object sender, EventArgs e)
	{
		if (app19.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app19.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app20_Click(object sender, EventArgs e)
	{
		if (app20.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app20.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app21_Click(object sender, EventArgs e)
	{
		if (app21.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app21.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app22_Click(object sender, EventArgs e)
	{
		if (app22.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app22.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app23_Click(object sender, EventArgs e)
	{
		if (app23.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app23.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app24_Click(object sender, EventArgs e)
	{
		if (app24.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app24.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app25_Click(object sender, EventArgs e)
	{
		if (app25.Image == MyProject.Forms.appdata.calc.Image)
		{
			((Control)MyProject.Forms.calculator).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.abou.Image)
		{
			((Control)MyProject.Forms.about).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.tool.Image)
		{
			((Control)MyProject.Forms.wixzeltools).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.cale.Image)
		{
			((Control)MyProject.Forms.calendar).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.came.Image)
		{
			((Control)MyProject.Forms.camera).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.cloc.Image)
		{
			((Control)MyProject.Forms.clock).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.comm.Image)
		{
			((Control)MyProject.Forms.commander).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.file.Image)
		{
			((Control)MyProject.Forms.files).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.meeb.Image)
		{
			((Control)MyProject.Forms.meebrowser).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.meem.Image)
		{
			((Control)MyProject.Forms.meemail).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.ncod.Image)
		{
			((Control)MyProject.Forms.ncode).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.pain.Image)
		{
			((Control)MyProject.Forms.paintain).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.scre.Image)
		{
			((Control)MyProject.Forms.screenlit).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.scrh.Image)
		{
			((Control)MyProject.Forms.screenshot).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.ttss.Image)
		{
			((Control)MyProject.Forms.tts).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.upda.Image)
		{
			((Control)MyProject.Forms.updates).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.vboa.Image)
		{
			((Control)MyProject.Forms.vboard).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.wall.Image)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.wine.Image)
		{
			((Control)MyProject.Forms.winexe).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.word.Image)
		{
			((Control)MyProject.Forms.wordpro).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.disk.Image)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
		else if (app25.Image == MyProject.Forms.appdata.sett.Image)
		{
			((Control)MyProject.Forms.settings).Show();
		}
	}

	private void app2_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app2).Location.X - ((Control)app2).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app2.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app2.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app2.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app2.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app2.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app2.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app2.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app2.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app2.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app2.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app2.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app2.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app2.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app2.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app2.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app2.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app2.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app2.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app2.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app2.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app2.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app2.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app3_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app3).Location.X - ((Control)app3).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app3.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app3.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app3.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app3.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app3.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app3.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app3.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app3.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app3.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app3.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app3.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app3.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app3.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app3.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app3.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app3.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app3.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app3.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app3.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app3.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app3.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app3.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app4_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app4).Location.X - ((Control)app4).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app4.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app4.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app4.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app4.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app4.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app4.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app4.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app4.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app4.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app4.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app4.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app4.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app4.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app4.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app4.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app4.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app4.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app4.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app4.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app4.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app4.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app4.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app5_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app5).Location.X - ((Control)app5).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app5.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app5.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app5.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app5.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app5.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app5.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app5.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app5.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app5.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app5.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app5.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app5.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app5.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app5.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app5.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app5.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app5.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app5.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app5.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app5.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app5.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app5.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app6_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app6).Location.X - ((Control)app6).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app6.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app6.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app6.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app6.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app6.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app6.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app6.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app6.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app6.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app6.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app6.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app6.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app6.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app6.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app6.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app6.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app6.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app6.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app6.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app6.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app6.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app6.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app7_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app7).Location.X - ((Control)app7).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app7.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app7.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app7.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app7.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app7.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app7.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app7.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app7.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app7.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app7.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app7.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app7.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app7.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app7.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app7.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app7.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app7.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app7.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app7.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app7.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app7.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app7.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app8_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app8).Location.X - ((Control)app8).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app8.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app8.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app8.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app8.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app8.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app8.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app8.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app8.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app8.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app8.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app8.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app8.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app8.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app8.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app8.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app8.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app8.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app8.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app8.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app8.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app8.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app8.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app9_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app9).Location.X - ((Control)app9).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app9.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app9.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app9.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app9.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app9.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app9.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app9.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app9.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app9.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app9.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app9.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app9.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app9.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app9.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app9.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app9.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app9.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app9.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app9.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app9.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app9.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app9.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app10_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app10).Location.X - ((Control)app10).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app10.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app10.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app10.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app10.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app10.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app10.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app10.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app10.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app10.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app10.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app10.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app10.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app10.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app10.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app10.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app10.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app10.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app10.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app10.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app10.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app10.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app10.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app11_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app11).Location.X - ((Control)app11).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app11.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app11.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app11.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app11.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app11.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app11.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app11.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app11.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app11.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app11.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app11.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app11.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app11.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app11.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app11.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app11.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app11.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app11.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app11.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app11.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app11.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app11.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app12_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app12).Location.X - ((Control)app12).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app12.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app12.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app12.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app12.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app12.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app12.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app12.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app12.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app12.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app12.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app12.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app12.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app12.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app12.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app12.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app12.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app12.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app12.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app12.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app12.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app12.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app12.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app13_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app13).Location.X - ((Control)app13).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app13.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app13.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app13.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app13.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app13.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app13.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app13.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app13.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app13.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app13.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app13.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app13.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app13.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app13.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app13.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app13.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app13.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app13.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app13.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app13.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app13.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app13.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app14_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app14).Location.X - ((Control)app14).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app14.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app14.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app14.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app14.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app14.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app14.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app14.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app14.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app14.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app14.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app14.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app14.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app14.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app14.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app14.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app14.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app14.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app14.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app14.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app14.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app14.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app14.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app15_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app15).Location.X - ((Control)app15).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app15.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app15.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app15.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app15.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app15.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app15.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app15.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app15.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app15.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app15.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app15.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app15.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app15.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app15.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app15.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app15.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app15.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app15.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app15.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app15.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app15.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app15.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app16_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app16).Location.X - ((Control)app16).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app16.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app16.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app16.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app16.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app16.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app16.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app16.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app16.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app16.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app16.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app16.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app16.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app16.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app16.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app16.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app16.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app16.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app16.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app16.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app16.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app16.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app16.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app17_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app17).Location.X - ((Control)app17).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app17.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app17.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app17.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app17.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app17.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app17.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app17.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app17.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app17.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app17.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app17.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app17.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app17.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app17.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app17.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app17.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app17.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app17.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app17.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app17.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app17.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app17.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app18_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app18).Location.X - ((Control)app18).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app18.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app18.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app18.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app18.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app18.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app18.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app18.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app18.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app18.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app18.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app18.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app18.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app18.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app18.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app18.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app18.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app18.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app18.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app18.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app18.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app18.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app18.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app19_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app19).Location.X - ((Control)app19).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app19.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app19.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app19.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app19.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app19.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app19.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app19.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app19.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app19.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app19.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app19.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app19.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app19.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app19.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app19.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app19.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app19.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app19.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app19.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app19.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app19.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app19.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app20_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app20).Location.X - ((Control)app20).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app20.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app20.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app20.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app20.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app20.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app20.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app20.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app20.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app20.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app20.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app20.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app20.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app20.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app20.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app20.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app20.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app20.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app20.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app20.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app20.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app20.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app20.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app21_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app21).Location.X - ((Control)app21).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app21.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app21.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app21.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app21.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app21.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app21.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app21.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app21.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app21.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app21.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app21.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app21.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app21.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app21.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app21.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app21.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app21.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app21.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app21.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app21.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app21.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app21.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app22_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app22).Location.X - ((Control)app22).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app22.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app22.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app22.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app22.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app22.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app22.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app22.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app22.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app22.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app22.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app22.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app22.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app22.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app22.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app22.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app22.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app22.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app22.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app22.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app22.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app22.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app22.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app23_MouseLeave(object sender, EventArgs e)
	{
	}

	private void app23_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app23).Location.X - ((Control)app23).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app23.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app23.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app23.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app23.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app23.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app23.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app23.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app23.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app23.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app23.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app23.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app23.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app23.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app23.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app23.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app23.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app23.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app23.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app23.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app23.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app23.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app23.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app24_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app24).Location.X - ((Control)app24).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app24.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app24.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app24.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app24.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app24.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app24.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app24.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app24.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app24.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app24.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app24.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app24.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app24.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app24.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app24.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app24.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app24.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app24.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app24.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app24.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app24.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app24.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void app25_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_054f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0876: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a80: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9a: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_0ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		//IL_10c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ce: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11db: Expected O, but got Unknown
		//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e8: Expected O, but got Unknown
		//IL_13ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Expected O, but got Unknown
		//IL_1608: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_1715: Unknown result type (might be due to invalid IL or missing references)
		//IL_171c: Expected O, but got Unknown
		((Control)MyProject.Forms.taskshow).Show();
		taskshow obj = MyProject.Forms.taskshow;
		checked
		{
			Point location = new Point(((Control)app25).Location.X - ((Control)app25).Width * 2, ((Control)this).Height - ((Control)MyProject.Forms.taskshow).Height - ((Control)PictureBox1).Height);
			((Form)obj).Location = location;
			if (app25.Image == MyProject.Forms.appdata.calc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calculator";
				((Form)MyProject.Forms.calculator).TopMost = true;
				((Control)MyProject.Forms.calculator).Focus();
				Graphics val = null;
				Point location2 = ((Control)MyProject.Forms.calculator).Bounds.Location;
				Bitmap val2 = new Bitmap(((Control)MyProject.Forms.calculator).Bounds.Width + 0, ((Control)MyProject.Forms.calculator).Bounds.Height + 0);
				val = Graphics.FromImage((Image)(object)val2);
				int x = location2.X;
				int y = location2.Y;
				val.CopyFromScreen(x - 0, y - 0, 0, 0, ((Image)val2).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val2;
			}
			else if (app25.Image == MyProject.Forms.appdata.tool.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Tools";
				((Form)MyProject.Forms.wixzeltools).TopMost = true;
				((Control)MyProject.Forms.wixzeltools).Focus();
				Graphics val3 = null;
				Point location3 = ((Control)MyProject.Forms.wixzeltools).Bounds.Location;
				Bitmap val4 = new Bitmap(((Control)MyProject.Forms.wixzeltools).Bounds.Width + 0, ((Control)MyProject.Forms.wixzeltools).Bounds.Height + 0);
				val3 = Graphics.FromImage((Image)(object)val4);
				int x2 = location3.X;
				int y2 = location3.Y;
				val3.CopyFromScreen(x2 - 0, y2 - 0, 0, 0, ((Image)val4).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val4;
			}
			else if (app25.Image == MyProject.Forms.appdata.sett.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Settings";
				((Form)MyProject.Forms.settings).TopMost = true;
				((Control)MyProject.Forms.settings).Focus();
				Graphics val5 = null;
				Point location4 = ((Control)MyProject.Forms.settings).Bounds.Location;
				Bitmap val6 = new Bitmap(((Control)MyProject.Forms.settings).Bounds.Width + 0, ((Control)MyProject.Forms.settings).Bounds.Height + 0);
				val5 = Graphics.FromImage((Image)(object)val6);
				int x3 = location4.X;
				int y3 = location4.Y;
				val5.CopyFromScreen(x3 - 0, y3 - 0, 0, 0, ((Image)val6).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val6;
			}
			else if (app25.Image == MyProject.Forms.appdata.disk.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Disk Management";
				((Form)MyProject.Forms.diskmanagement).TopMost = true;
				((Control)MyProject.Forms.diskmanagement).Focus();
				Graphics val7 = null;
				Point location5 = ((Control)MyProject.Forms.diskmanagement).Bounds.Location;
				Bitmap val8 = new Bitmap(((Control)MyProject.Forms.diskmanagement).Bounds.Width + 0, ((Control)MyProject.Forms.diskmanagement).Bounds.Height + 0);
				val7 = Graphics.FromImage((Image)(object)val8);
				int x4 = location5.X;
				int y4 = location5.Y;
				val7.CopyFromScreen(x4 - 0, y4 - 0, 0, 0, ((Image)val8).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val8;
			}
			else if (app25.Image == MyProject.Forms.appdata.abou.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "About";
				((Form)MyProject.Forms.about).TopMost = true;
				((Control)MyProject.Forms.about).Focus();
				Graphics val9 = null;
				Point location6 = ((Control)MyProject.Forms.about).Bounds.Location;
				Bitmap val10 = new Bitmap(((Control)MyProject.Forms.about).Bounds.Width + 0, ((Control)MyProject.Forms.about).Bounds.Height + 0);
				val9 = Graphics.FromImage((Image)(object)val10);
				int x5 = location6.X;
				int y5 = location6.Y;
				val9.CopyFromScreen(x5 - 0, y5 - 0, 0, 0, ((Image)val10).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val10;
			}
			else if (app25.Image == MyProject.Forms.appdata.cale.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Calendar";
				((Form)MyProject.Forms.calendar).TopMost = true;
				((Control)MyProject.Forms.calendar).Focus();
				Graphics val11 = null;
				Point location7 = ((Control)MyProject.Forms.calendar).Bounds.Location;
				Bitmap val12 = new Bitmap(((Control)MyProject.Forms.calendar).Bounds.Width + 0, ((Control)MyProject.Forms.calendar).Bounds.Height + 0);
				val11 = Graphics.FromImage((Image)(object)val12);
				int x6 = location7.X;
				int y6 = location7.Y;
				val11.CopyFromScreen(x6 - 0, y6 - 0, 0, 0, ((Image)val12).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val12;
			}
			else if (app25.Image == MyProject.Forms.appdata.came.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Camera";
				((Form)MyProject.Forms.camera).TopMost = true;
				((Control)MyProject.Forms.camera).Focus();
				Graphics val13 = null;
				Point location8 = ((Control)MyProject.Forms.camera).Bounds.Location;
				Bitmap val14 = new Bitmap(((Control)MyProject.Forms.camera).Bounds.Width + 0, ((Control)MyProject.Forms.camera).Bounds.Height + 0);
				val13 = Graphics.FromImage((Image)(object)val14);
				int x7 = location8.X;
				int y7 = location8.Y;
				val13.CopyFromScreen(x7 - 0, y7 - 0, 0, 0, ((Image)val14).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val14;
			}
			else if (app25.Image == MyProject.Forms.appdata.cloc.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Clock";
				((Form)MyProject.Forms.clock).TopMost = true;
				((Control)MyProject.Forms.clock).Focus();
				Graphics val15 = null;
				Point location9 = ((Control)MyProject.Forms.clock).Bounds.Location;
				Bitmap val16 = new Bitmap(((Control)MyProject.Forms.clock).Bounds.Width + 0, ((Control)MyProject.Forms.clock).Bounds.Height + 0);
				val15 = Graphics.FromImage((Image)(object)val16);
				int x8 = location9.X;
				int y8 = location9.Y;
				val15.CopyFromScreen(x8 - 0, y8 - 0, 0, 0, ((Image)val16).Size);
			}
			else if (app25.Image == MyProject.Forms.appdata.comm.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Commander";
				((Form)MyProject.Forms.commander).TopMost = true;
				((Control)MyProject.Forms.commander).Focus();
				Graphics val17 = null;
				Point location10 = ((Control)MyProject.Forms.commander).Bounds.Location;
				Bitmap val18 = new Bitmap(((Control)MyProject.Forms.commander).Bounds.Width + 0, ((Control)MyProject.Forms.commander).Bounds.Height + 0);
				val17 = Graphics.FromImage((Image)(object)val18);
				int x9 = location10.X;
				int y9 = location10.Y;
				val17.CopyFromScreen(x9 - 0, y9 - 0, 0, 0, ((Image)val18).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val18;
			}
			else if (app25.Image == MyProject.Forms.appdata.file.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Files";
				((Form)MyProject.Forms.files).TopMost = true;
				((Control)MyProject.Forms.files).Focus();
				Graphics val19 = null;
				Point location11 = ((Control)MyProject.Forms.files).Bounds.Location;
				Bitmap val20 = new Bitmap(((Control)MyProject.Forms.files).Bounds.Width + 0, ((Control)MyProject.Forms.files).Bounds.Height + 0);
				val19 = Graphics.FromImage((Image)(object)val20);
				int x10 = location11.X;
				int y10 = location11.Y;
				val19.CopyFromScreen(x10 - 0, y10 - 0, 0, 0, ((Image)val20).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val20;
			}
			else if (app25.Image == MyProject.Forms.appdata.meeb.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Browser";
				((Form)MyProject.Forms.meebrowser).TopMost = true;
				((Control)MyProject.Forms.meebrowser).Focus();
				Graphics val21 = null;
				Point location12 = ((Control)MyProject.Forms.meebrowser).Bounds.Location;
				Bitmap val22 = new Bitmap(((Control)MyProject.Forms.meebrowser).Bounds.Width + 0, ((Control)MyProject.Forms.meebrowser).Bounds.Height + 0);
				val21 = Graphics.FromImage((Image)(object)val22);
				int x11 = location12.X;
				int y11 = location12.Y;
				val21.CopyFromScreen(x11 - 0, y11 - 0, 0, 0, ((Image)val22).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val22;
			}
			else if (app25.Image == MyProject.Forms.appdata.meem.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Mee Mail";
				((Form)MyProject.Forms.meemail).TopMost = true;
				((Control)MyProject.Forms.meemail).Focus();
				Graphics val23 = null;
				Point location13 = ((Control)MyProject.Forms.meemail).Bounds.Location;
				Bitmap val24 = new Bitmap(((Control)MyProject.Forms.meemail).Bounds.Width + 0, ((Control)MyProject.Forms.meemail).Bounds.Height + 0);
				val23 = Graphics.FromImage((Image)(object)val24);
				int x12 = location13.X;
				int y12 = location13.Y;
				val23.CopyFromScreen(x12 - 0, y12 - 0, 0, 0, ((Image)val24).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val24;
			}
			else if (app25.Image == MyProject.Forms.appdata.ncod.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "NCode";
				((Form)MyProject.Forms.ncode).TopMost = true;
				((Control)MyProject.Forms.ncode).Focus();
				Graphics val25 = null;
				Point location14 = ((Control)MyProject.Forms.ncode).Bounds.Location;
				Bitmap val26 = new Bitmap(((Control)MyProject.Forms.ncode).Bounds.Width + 0, ((Control)MyProject.Forms.ncode).Bounds.Height + 0);
				val25 = Graphics.FromImage((Image)(object)val26);
				int x13 = location14.X;
				int y13 = location14.Y;
				val25.CopyFromScreen(x13 - 0, y13 - 0, 0, 0, ((Image)val26).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val26;
			}
			else if (app25.Image == MyProject.Forms.appdata.pain.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Paintain";
				((Form)MyProject.Forms.paintain).TopMost = true;
				((Control)MyProject.Forms.paintain).Focus();
				Graphics val27 = null;
				Point location15 = ((Control)MyProject.Forms.paintain).Bounds.Location;
				Bitmap val28 = new Bitmap(((Control)MyProject.Forms.paintain).Bounds.Width + 0, ((Control)MyProject.Forms.paintain).Bounds.Height + 0);
				val27 = Graphics.FromImage((Image)(object)val28);
				int x14 = location15.X;
				int y14 = location15.Y;
				val27.CopyFromScreen(x14 - 0, y14 - 0, 0, 0, ((Image)val28).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val28;
			}
			else if (app25.Image == MyProject.Forms.appdata.scre.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenlit";
				((Form)MyProject.Forms.screenlit).TopMost = true;
				((Control)MyProject.Forms.screenlit).Focus();
				Graphics val29 = null;
				Point location16 = ((Control)MyProject.Forms.screenlit).Bounds.Location;
				Bitmap val30 = new Bitmap(((Control)MyProject.Forms.screenlit).Bounds.Width + 0, ((Control)MyProject.Forms.screenlit).Bounds.Height + 0);
				val29 = Graphics.FromImage((Image)(object)val30);
				int x15 = location16.X;
				int y15 = location16.Y;
				val29.CopyFromScreen(x15 - 0, y15 - 0, 0, 0, ((Image)val30).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val30;
			}
			else if (app25.Image == MyProject.Forms.appdata.scrh.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Screenshot";
				((Form)MyProject.Forms.screenshot).TopMost = true;
				((Control)MyProject.Forms.screenshot).Focus();
				Graphics val31 = null;
				Point location17 = ((Control)MyProject.Forms.screenshot).Bounds.Location;
				Bitmap val32 = new Bitmap(((Control)MyProject.Forms.screenshot).Bounds.Width + 0, ((Control)MyProject.Forms.screenshot).Bounds.Height + 0);
				val31 = Graphics.FromImage((Image)(object)val32);
				int x16 = location17.X;
				int y16 = location17.Y;
				val31.CopyFromScreen(x16 - 0, y16 - 0, 0, 0, ((Image)val32).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val32;
			}
			else if (app25.Image == MyProject.Forms.appdata.ttss.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "TTS";
				((Form)MyProject.Forms.tts).TopMost = true;
				((Control)MyProject.Forms.tts).Focus();
				Graphics val33 = null;
				Point location18 = ((Control)MyProject.Forms.tts).Bounds.Location;
				Bitmap val34 = new Bitmap(((Control)MyProject.Forms.tts).Bounds.Width + 0, ((Control)MyProject.Forms.tts).Bounds.Height + 0);
				val33 = Graphics.FromImage((Image)(object)val34);
				int x17 = location18.X;
				int y17 = location18.Y;
				val33.CopyFromScreen(x17 - 0, y17 - 0, 0, 0, ((Image)val34).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val34;
			}
			else if (app25.Image == MyProject.Forms.appdata.upda.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Updates";
				((Form)MyProject.Forms.updates).TopMost = true;
				((Control)MyProject.Forms.updates).Focus();
				Graphics val35 = null;
				Point location19 = ((Control)MyProject.Forms.updates).Bounds.Location;
				Bitmap val36 = new Bitmap(((Control)MyProject.Forms.updates).Bounds.Width + 0, ((Control)MyProject.Forms.updates).Bounds.Height + 0);
				val35 = Graphics.FromImage((Image)(object)val36);
				int x18 = location19.X;
				int y18 = location19.Y;
				val35.CopyFromScreen(x18 - 0, y18 - 0, 0, 0, ((Image)val36).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val36;
			}
			else if (app25.Image == MyProject.Forms.appdata.vboa.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "VBoard";
				((Form)MyProject.Forms.vboard).TopMost = true;
				((Control)MyProject.Forms.vboard).Focus();
				Graphics val37 = null;
				Point location20 = ((Control)MyProject.Forms.vboard).Bounds.Location;
				Bitmap val38 = new Bitmap(((Control)MyProject.Forms.vboard).Bounds.Width + 0, ((Control)MyProject.Forms.vboard).Bounds.Height + 0);
				val37 = Graphics.FromImage((Image)(object)val38);
				int x19 = location20.X;
				int y19 = location20.Y;
				val37.CopyFromScreen(x19 - 0, y19 - 0, 0, 0, ((Image)val38).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val38;
			}
			else if (app25.Image == MyProject.Forms.appdata.wall.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Wallpapers";
				((Form)MyProject.Forms.wallpapers).TopMost = true;
				((Control)MyProject.Forms.wallpapers).Focus();
				Graphics val39 = null;
				Point location21 = ((Control)MyProject.Forms.wallpapers).Bounds.Location;
				Bitmap val40 = new Bitmap(((Control)MyProject.Forms.wallpapers).Bounds.Width + 0, ((Control)MyProject.Forms.wallpapers).Bounds.Height + 0);
				val39 = Graphics.FromImage((Image)(object)val40);
				int x20 = location21.X;
				int y20 = location21.Y;
				val39.CopyFromScreen(x20 - 0, y20 - 0, 0, 0, ((Image)val40).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val40;
			}
			else if (app25.Image == MyProject.Forms.appdata.wine.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "Winexe";
				((Form)MyProject.Forms.winexe).TopMost = true;
				((Control)MyProject.Forms.winexe).Focus();
				Graphics val41 = null;
				Point location22 = ((Control)MyProject.Forms.winexe).Bounds.Location;
				Bitmap val42 = new Bitmap(((Control)MyProject.Forms.winexe).Bounds.Width + 0, ((Control)MyProject.Forms.winexe).Bounds.Height + 0);
				val41 = Graphics.FromImage((Image)(object)val42);
				int x21 = location22.X;
				int y21 = location22.Y;
				val41.CopyFromScreen(x21 - 0, y21 - 0, 0, 0, ((Image)val42).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val42;
			}
			else if (app25.Image == MyProject.Forms.appdata.word.Image)
			{
				MyProject.Forms.taskshow.apptitile.Text = "WordPro";
				((Form)MyProject.Forms.wordpro).TopMost = true;
				((Control)MyProject.Forms.wordpro).Focus();
				Graphics val43 = null;
				Point location23 = ((Control)MyProject.Forms.wordpro).Bounds.Location;
				Bitmap val44 = new Bitmap(((Control)MyProject.Forms.wordpro).Bounds.Width + 0, ((Control)MyProject.Forms.wordpro).Bounds.Height + 0);
				val43 = Graphics.FromImage((Image)(object)val44);
				int x22 = location23.X;
				int y22 = location23.Y;
				val43.CopyFromScreen(x22 - 0, y22 - 0, 0, 0, ((Image)val44).Size);
				MyProject.Forms.taskshow.taskpic.Image = (Image)(object)val44;
			}
		}
	}

	private void home_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)MyProject.Forms.taskshow).Hide();
	}

	private void datetimeupdate_Tick(object sender, EventArgs e)
	{
		datedis.Text = Strings.Format((object)DateAndTime.Now, "MMM  yyyy");
		timedis.Text = Strings.Format((object)DateAndTime.Now, " hh:mm tt");
		hometime.Text = Strings.Format((object)DateAndTime.Now, "hh:mm");
	}

	private void timedis_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.desknet).Hide();
		((Control)MyProject.Forms.deskdate).Hide();
		if (!((Control)MyProject.Forms.desktime).Visible)
		{
			((Control)MyProject.Forms.desktime).Show();
			desktime obj = MyProject.Forms.desktime;
			Point location = checked(new Point(((Control)timedis).Location.X - ((Control)timedis).Width * 3, ((Control)this).Height - ((Control)MyProject.Forms.desktime).Height - ((Control)PictureBox1).Height));
			((Form)obj).Location = location;
		}
		else
		{
			((Form)MyProject.Forms.desktime).Close();
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.desknet).Hide();
		((Control)MyProject.Forms.desktime).Hide();
		((Control)MyProject.Forms.deskdate).Hide();
		if (!((Control)MyProject.Forms.openapps).Visible)
		{
			((Control)MyProject.Forms.openapps).Show();
			openapps obj = MyProject.Forms.openapps;
			Point location = new Point(((Control)PictureBox3).Location.X, checked(((Control)PictureBox1).Location.Y - ((Control)MyProject.Forms.openapps).Height));
			((Form)obj).Location = location;
		}
		else
		{
			((Form)MyProject.Forms.openapps).Close();
		}
	}

	private void item1_Click(object sender, EventArgs e)
	{
		if (((Control)item1).BackColor == Color.Transparent)
		{
			((Control)item1).BackColor = Color.RoyalBlue;
		}
		else
		{
			((Control)item1).BackColor = Color.Transparent;
		}
		Label obj = item1lbl;
		Point location = checked(new Point(((Control)item1).Location.X + 4, ((Control)item1).Location.Y + ((Control)item1).Height));
		((Control)obj).Location = location;
	}

	private void itemmove_Tick(object sender, EventArgs e)
	{
		point = Cursor.Position;
		if (Operators.CompareString(Label2.Text, "item1", false) == 0)
		{
			((Control)item1).Location = point;
		}
		Label obj = item1lbl;
		Point location = checked(new Point(((Control)item1).Location.X + 4, ((Control)item1).Location.Y + ((Control)item1).Height));
		((Control)obj).Location = location;
	}

	private void item1_DoubleClick(object sender, EventArgs e)
	{
		((Control)item1).BackColor = Color.Transparent;
		((Control)MyProject.Forms.files).Show();
	}

	private void item1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)Control.MouseButtons == 1048576)
		{
			if (((Control)item1).BackColor == Color.RoyalBlue)
			{
				Label2.Text = "item1";
			}
			else
			{
				Label2.Text = "";
			}
		}
		Label obj = item1lbl;
		Point location = checked(new Point(((Control)item1).Location.X + 4, ((Control)item1).Location.Y + ((Control)item1).Height));
		((Control)obj).Location = location;
	}

	private void item1_MouseUp(object sender, MouseEventArgs e)
	{
		Label2.Text = "";
		Label obj = item1lbl;
		Point location = checked(new Point(((Control)item1).Location.X + 4, ((Control)item1).Location.Y + ((Control)item1).Height));
		((Control)obj).Location = location;
	}

	private void item1lbl_Click(object sender, EventArgs e)
	{
		if (((Control)item1).BackColor == Color.Transparent)
		{
			((Control)item1).BackColor = Color.RoyalBlue;
		}
		else
		{
			((Control)item1).BackColor = Color.Transparent;
		}
		Label obj = item1lbl;
		Point location = checked(new Point(((Control)item1).Location.X + 4, ((Control)item1).Location.Y + ((Control)item1).Height));
		((Control)obj).Location = location;
	}

	private void apptaskbarico_Tick(object sender, EventArgs e)
	{
		if (app24.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app24.Image = app25.Image;
		}
		else if (app23.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app23.Image = app24.Image;
		}
		else if (app22.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app22.Image = app23.Image;
		}
		else if (app21.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app21.Image = app22.Image;
		}
		else if (app20.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app20.Image = app21.Image;
		}
		else if (app19.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app19.Image = app20.Image;
		}
		else if (app18.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app18.Image = app19.Image;
		}
		else if (app17.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app17.Image = app18.Image;
		}
		else if (app16.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app16.Image = app17.Image;
		}
		else if (app15.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app15.Image = app16.Image;
		}
		else if (app14.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app14.Image = app15.Image;
		}
		else if (app13.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app13.Image = app14.Image;
		}
		else if (app12.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app12.Image = app13.Image;
		}
		else if (app11.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app11.Image = app12.Image;
		}
		else if (app10.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app10.Image = app11.Image;
		}
		else if (app9.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app9.Image = app10.Image;
		}
		else if (app8.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app8.Image = app9.Image;
		}
		else if (app7.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app7.Image = app8.Image;
		}
		else if (app6.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app6.Image = app7.Image;
		}
		else if (app5.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app5.Image = app6.Image;
		}
		else if (app4.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app4.Image = app5.Image;
		}
		else if (app3.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app3.Image = app4.Image;
		}
		else if (app2.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app2.Image = app3.Image;
		}
		else if (app1.Image == MyProject.Forms.appdata.noimg.Image)
		{
			app1.Image = app2.Image;
		}
	}
}
