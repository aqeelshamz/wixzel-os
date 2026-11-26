using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class settings : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("mainbtn")]
	private PictureBox _mainbtn;

	[AccessedThroughProperty("displaybtn")]
	private PictureBox _displaybtn;

	[AccessedThroughProperty("aboutbtn")]
	private PictureBox _aboutbtn;

	[AccessedThroughProperty("soundbtn")]
	private PictureBox _soundbtn;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("setdes")]
	private Label _setdes;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	[AccessedThroughProperty("PictureBox15")]
	private PictureBox _PictureBox15;

	[AccessedThroughProperty("tab1")]
	private PictureBox _tab1;

	[AccessedThroughProperty("tab2")]
	private PictureBox _tab2;

	[AccessedThroughProperty("tab4")]
	private PictureBox _tab4;

	[AccessedThroughProperty("tab3")]
	private PictureBox _tab3;

	[AccessedThroughProperty("tab1txt")]
	private Label _tab1txt;

	[AccessedThroughProperty("tab2txt")]
	private Label _tab2txt;

	[AccessedThroughProperty("tab4txt")]
	private Label _tab4txt;

	[AccessedThroughProperty("tab3txt")]
	private Label _tab3txt;

	[AccessedThroughProperty("mainchk")]
	private PictureBox _mainchk;

	[AccessedThroughProperty("displaychk")]
	private PictureBox _displaychk;

	[AccessedThroughProperty("soundchk")]
	private PictureBox _soundchk;

	[AccessedThroughProperty("aboutchk")]
	private PictureBox _aboutchk;

	[AccessedThroughProperty("tab1pic")]
	private PictureBox _tab1pic;

	[AccessedThroughProperty("tab2pic")]
	private PictureBox _tab2pic;

	[AccessedThroughProperty("tab4pic")]
	private PictureBox _tab4pic;

	[AccessedThroughProperty("tab3pic")]
	private PictureBox _tab3pic;

	private Point mouse_move;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox3_MouseMove);
			EventHandler eventHandler = PictureBox3_MouseLeave;
			MouseEventHandler val2 = new MouseEventHandler(PictureBox3_MouseDown);
			EventHandler eventHandler2 = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).MouseMove -= val;
				((Control)_PictureBox3).MouseLeave -= eventHandler;
				((Control)_PictureBox3).MouseDown -= val2;
				((Control)_PictureBox3).Click -= eventHandler2;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).MouseMove += val;
				((Control)_PictureBox3).MouseLeave += eventHandler;
				((Control)_PictureBox3).MouseDown += val2;
				((Control)_PictureBox3).Click += eventHandler2;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox2_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox2_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox2_MouseDown);
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click -= eventHandler;
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).MouseDown -= val2;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click += eventHandler;
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).MouseDown += val2;
			}
		}
	}

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox1_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox1_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox1_MouseDown);
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click -= eventHandler;
				((Control)_PictureBox1).MouseMove -= val;
				((Control)_PictureBox1).MouseDown -= val2;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click += eventHandler;
				((Control)_PictureBox1).MouseMove += val;
				((Control)_PictureBox1).MouseDown += val2;
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
			_PictureBox4 = value;
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox5 = value;
		}
	}

	internal virtual PictureBox PictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox6 = value;
		}
	}

	internal virtual PictureBox mainbtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _mainbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = mainbtn_Click;
			MouseEventHandler val = new MouseEventHandler(mainbtn_MouseMove);
			EventHandler eventHandler2 = mainbtn_MouseLeave;
			if (_mainbtn != null)
			{
				((Control)_mainbtn).Click -= eventHandler;
				((Control)_mainbtn).MouseMove -= val;
				((Control)_mainbtn).MouseLeave -= eventHandler2;
			}
			_mainbtn = value;
			if (_mainbtn != null)
			{
				((Control)_mainbtn).Click += eventHandler;
				((Control)_mainbtn).MouseMove += val;
				((Control)_mainbtn).MouseLeave += eventHandler2;
			}
		}
	}

	internal virtual PictureBox displaybtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _displaybtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(displaybtn_MouseMove);
			EventHandler eventHandler = displaybtn_MouseLeave;
			EventHandler eventHandler2 = displaybtn_Click;
			if (_displaybtn != null)
			{
				((Control)_displaybtn).MouseMove -= val;
				((Control)_displaybtn).MouseLeave -= eventHandler;
				((Control)_displaybtn).Click -= eventHandler2;
			}
			_displaybtn = value;
			if (_displaybtn != null)
			{
				((Control)_displaybtn).MouseMove += val;
				((Control)_displaybtn).MouseLeave += eventHandler;
				((Control)_displaybtn).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox aboutbtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _aboutbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(aboutbtn_MouseMove);
			EventHandler eventHandler = aboutbtn_MouseLeave;
			EventHandler eventHandler2 = aboutbtn_Click;
			if (_aboutbtn != null)
			{
				((Control)_aboutbtn).MouseMove -= val;
				((Control)_aboutbtn).MouseLeave -= eventHandler;
				((Control)_aboutbtn).Click -= eventHandler2;
			}
			_aboutbtn = value;
			if (_aboutbtn != null)
			{
				((Control)_aboutbtn).MouseMove += val;
				((Control)_aboutbtn).MouseLeave += eventHandler;
				((Control)_aboutbtn).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox soundbtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _soundbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(soundbtn_MouseMove);
			EventHandler eventHandler = soundbtn_MouseLeave;
			EventHandler eventHandler2 = soundbtn_Click;
			if (_soundbtn != null)
			{
				((Control)_soundbtn).MouseMove -= val;
				((Control)_soundbtn).MouseLeave -= eventHandler;
				((Control)_soundbtn).Click -= eventHandler2;
			}
			_soundbtn = value;
			if (_soundbtn != null)
			{
				((Control)_soundbtn).MouseMove += val;
				((Control)_soundbtn).MouseLeave += eventHandler;
				((Control)_soundbtn).Click += eventHandler2;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label2_MouseMove);
			EventHandler eventHandler = Label2_MouseLeave;
			EventHandler eventHandler2 = Label2_Click;
			if (_Label2 != null)
			{
				((Control)_Label2).MouseMove -= val;
				((Control)_Label2).MouseLeave -= eventHandler;
				((Control)_Label2).Click -= eventHandler2;
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).MouseMove += val;
				((Control)_Label2).MouseLeave += eventHandler;
				((Control)_Label2).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label3_MouseMove);
			EventHandler eventHandler = Label3_MouseLeave;
			EventHandler eventHandler2 = Label3_Click;
			if (_Label3 != null)
			{
				((Control)_Label3).MouseMove -= val;
				((Control)_Label3).MouseLeave -= eventHandler;
				((Control)_Label3).Click -= eventHandler2;
			}
			_Label3 = value;
			if (_Label3 != null)
			{
				((Control)_Label3).MouseMove += val;
				((Control)_Label3).MouseLeave += eventHandler;
				((Control)_Label3).Click += eventHandler2;
			}
		}
	}

	internal virtual Label Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label4_MouseUp);
			MouseEventHandler val2 = new MouseEventHandler(Label4_MouseMove);
			EventHandler eventHandler = Label4_MouseLeave;
			EventHandler eventHandler2 = Label4_Click;
			if (_Label4 != null)
			{
				((Control)_Label4).MouseUp -= val;
				((Control)_Label4).MouseMove -= val2;
				((Control)_Label4).MouseLeave -= eventHandler;
				((Control)_Label4).Click -= eventHandler2;
			}
			_Label4 = value;
			if (_Label4 != null)
			{
				((Control)_Label4).MouseUp += val;
				((Control)_Label4).MouseMove += val2;
				((Control)_Label4).MouseLeave += eventHandler;
				((Control)_Label4).Click += eventHandler2;
			}
		}
	}

	internal virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label5_MouseMove);
			EventHandler eventHandler = Label5_MouseLeave;
			EventHandler eventHandler2 = Label5_Click;
			if (_Label5 != null)
			{
				((Control)_Label5).MouseMove -= val;
				((Control)_Label5).MouseLeave -= eventHandler;
				((Control)_Label5).Click -= eventHandler2;
			}
			_Label5 = value;
			if (_Label5 != null)
			{
				((Control)_Label5).MouseMove += val;
				((Control)_Label5).MouseLeave += eventHandler;
				((Control)_Label5).Click += eventHandler2;
			}
		}
	}

	internal virtual Label setdes
	{
		[DebuggerNonUserCode]
		get
		{
			return _setdes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_setdes = value;
		}
	}

	internal virtual PictureBox PictureBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox12_MouseMove);
			EventHandler eventHandler = PictureBox12_MouseLeave;
			EventHandler eventHandler2 = PictureBox12_Click;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).MouseMove -= val;
				((Control)_PictureBox12).MouseLeave -= eventHandler;
				((Control)_PictureBox12).Click -= eventHandler2;
			}
			_PictureBox12 = value;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).MouseMove += val;
				((Control)_PictureBox12).MouseLeave += eventHandler;
				((Control)_PictureBox12).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox PictureBox13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox13_MouseMove);
			EventHandler eventHandler = PictureBox13_MouseLeave;
			EventHandler eventHandler2 = PictureBox13_Click;
			if (_PictureBox13 != null)
			{
				((Control)_PictureBox13).MouseMove -= val;
				((Control)_PictureBox13).MouseLeave -= eventHandler;
				((Control)_PictureBox13).Click -= eventHandler2;
			}
			_PictureBox13 = value;
			if (_PictureBox13 != null)
			{
				((Control)_PictureBox13).MouseMove += val;
				((Control)_PictureBox13).MouseLeave += eventHandler;
				((Control)_PictureBox13).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox PictureBox14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox14_MouseLeave;
			EventHandler eventHandler2 = PictureBox14_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox14_MouseMove);
			if (_PictureBox14 != null)
			{
				((Control)_PictureBox14).MouseLeave -= eventHandler;
				((Control)_PictureBox14).Click -= eventHandler2;
				((Control)_PictureBox14).MouseMove -= val;
			}
			_PictureBox14 = value;
			if (_PictureBox14 != null)
			{
				((Control)_PictureBox14).MouseLeave += eventHandler;
				((Control)_PictureBox14).Click += eventHandler2;
				((Control)_PictureBox14).MouseMove += val;
			}
		}
	}

	internal virtual PictureBox PictureBox15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox15_MouseMove);
			EventHandler eventHandler = PictureBox15_MouseLeave;
			EventHandler eventHandler2 = PictureBox15_Click;
			if (_PictureBox15 != null)
			{
				((Control)_PictureBox15).MouseMove -= val;
				((Control)_PictureBox15).MouseLeave -= eventHandler;
				((Control)_PictureBox15).Click -= eventHandler2;
			}
			_PictureBox15 = value;
			if (_PictureBox15 != null)
			{
				((Control)_PictureBox15).MouseMove += val;
				((Control)_PictureBox15).MouseLeave += eventHandler;
				((Control)_PictureBox15).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox tab1
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab1 = value;
		}
	}

	internal virtual PictureBox tab2
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab2 = value;
		}
	}

	internal virtual PictureBox tab4
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab4 = value;
		}
	}

	internal virtual PictureBox tab3
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab3 = value;
		}
	}

	internal virtual Label tab1txt
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab1txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(tab1txt_MouseMove);
			EventHandler eventHandler = tab1txt_MouseLeave;
			EventHandler eventHandler2 = tab1txt_Click;
			if (_tab1txt != null)
			{
				((Control)_tab1txt).MouseMove -= val;
				((Control)_tab1txt).MouseLeave -= eventHandler;
				((Control)_tab1txt).Click -= eventHandler2;
			}
			_tab1txt = value;
			if (_tab1txt != null)
			{
				((Control)_tab1txt).MouseMove += val;
				((Control)_tab1txt).MouseLeave += eventHandler;
				((Control)_tab1txt).Click += eventHandler2;
			}
		}
	}

	internal virtual Label tab2txt
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab2txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(tab2txt_MouseMove);
			EventHandler eventHandler = tab2txt_MouseLeave;
			EventHandler eventHandler2 = tab2txt_Click;
			if (_tab2txt != null)
			{
				((Control)_tab2txt).MouseMove -= val;
				((Control)_tab2txt).MouseLeave -= eventHandler;
				((Control)_tab2txt).Click -= eventHandler2;
			}
			_tab2txt = value;
			if (_tab2txt != null)
			{
				((Control)_tab2txt).MouseMove += val;
				((Control)_tab2txt).MouseLeave += eventHandler;
				((Control)_tab2txt).Click += eventHandler2;
			}
		}
	}

	internal virtual Label tab4txt
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab4txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(tab4txt_MouseMove);
			EventHandler eventHandler = tab4txt_MouseLeave;
			EventHandler eventHandler2 = tab4txt_Click;
			if (_tab4txt != null)
			{
				((Control)_tab4txt).MouseMove -= val;
				((Control)_tab4txt).MouseLeave -= eventHandler;
				((Control)_tab4txt).Click -= eventHandler2;
			}
			_tab4txt = value;
			if (_tab4txt != null)
			{
				((Control)_tab4txt).MouseMove += val;
				((Control)_tab4txt).MouseLeave += eventHandler;
				((Control)_tab4txt).Click += eventHandler2;
			}
		}
	}

	internal virtual Label tab3txt
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab3txt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(tab3txt_MouseMove);
			EventHandler eventHandler = tab3txt_MouseLeave;
			EventHandler eventHandler2 = tab3txt_Click;
			if (_tab3txt != null)
			{
				((Control)_tab3txt).MouseMove -= val;
				((Control)_tab3txt).MouseLeave -= eventHandler;
				((Control)_tab3txt).Click -= eventHandler2;
			}
			_tab3txt = value;
			if (_tab3txt != null)
			{
				((Control)_tab3txt).MouseMove += val;
				((Control)_tab3txt).MouseLeave += eventHandler;
				((Control)_tab3txt).Click += eventHandler2;
			}
		}
	}

	internal virtual PictureBox mainchk
	{
		[DebuggerNonUserCode]
		get
		{
			return _mainchk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mainchk = value;
		}
	}

	internal virtual PictureBox displaychk
	{
		[DebuggerNonUserCode]
		get
		{
			return _displaychk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_displaychk = value;
		}
	}

	internal virtual PictureBox soundchk
	{
		[DebuggerNonUserCode]
		get
		{
			return _soundchk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_soundchk = value;
		}
	}

	internal virtual PictureBox aboutchk
	{
		[DebuggerNonUserCode]
		get
		{
			return _aboutchk;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_aboutchk = value;
		}
	}

	internal virtual PictureBox tab1pic
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab1pic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab1pic = value;
		}
	}

	internal virtual PictureBox tab2pic
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab2pic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab2pic = value;
		}
	}

	internal virtual PictureBox tab4pic
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab4pic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab4pic = value;
		}
	}

	internal virtual PictureBox tab3pic
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab3pic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab3pic = value;
		}
	}

	[DebuggerNonUserCode]
	public settings()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(settings_FormClosing);
		((Form)this).Load += settings_Load;
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0857: Expected O, but got Unknown
		//IL_08e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f2: Expected O, but got Unknown
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0994: Expected O, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adb: Expected O, but got Unknown
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected O, but got Unknown
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		//IL_0cd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce2: Expected O, but got Unknown
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected O, but got Unknown
		//IL_0e28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected O, but got Unknown
		//IL_0ed0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eda: Expected O, but got Unknown
		//IL_0f78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f82: Expected O, but got Unknown
		//IL_1030: Unknown result type (might be due to invalid IL or missing references)
		//IL_103a: Expected O, but got Unknown
		//IL_10d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected O, but got Unknown
		//IL_1174: Unknown result type (might be due to invalid IL or missing references)
		//IL_117e: Expected O, but got Unknown
		//IL_1216: Unknown result type (might be due to invalid IL or missing references)
		//IL_1220: Expected O, but got Unknown
		//IL_12b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c2: Expected O, but got Unknown
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1367: Expected O, but got Unknown
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_140c: Expected O, but got Unknown
		//IL_14a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b1: Expected O, but got Unknown
		//IL_155b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1565: Expected O, but got Unknown
		//IL_1622: Unknown result type (might be due to invalid IL or missing references)
		//IL_162c: Expected O, but got Unknown
		//IL_16e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f3: Expected O, but got Unknown
		//IL_17b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ba: Expected O, but got Unknown
		//IL_1868: Unknown result type (might be due to invalid IL or missing references)
		//IL_1872: Expected O, but got Unknown
		//IL_1917: Unknown result type (might be due to invalid IL or missing references)
		//IL_1921: Expected O, but got Unknown
		//IL_19c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d0: Expected O, but got Unknown
		//IL_1a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7f: Expected O, but got Unknown
		//IL_1b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2e: Expected O, but got Unknown
		//IL_1bc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd0: Expected O, but got Unknown
		//IL_1c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c72: Expected O, but got Unknown
		//IL_1d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d14: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(settings));
		PictureBox7 = new PictureBox();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox6 = new PictureBox();
		mainbtn = new PictureBox();
		displaybtn = new PictureBox();
		aboutbtn = new PictureBox();
		soundbtn = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		setdes = new Label();
		PictureBox12 = new PictureBox();
		PictureBox13 = new PictureBox();
		PictureBox14 = new PictureBox();
		PictureBox15 = new PictureBox();
		tab1 = new PictureBox();
		tab2 = new PictureBox();
		tab4 = new PictureBox();
		tab3 = new PictureBox();
		tab1txt = new Label();
		tab2txt = new Label();
		tab4txt = new Label();
		tab3txt = new Label();
		mainchk = new PictureBox();
		displaychk = new PictureBox();
		soundchk = new PictureBox();
		aboutchk = new PictureBox();
		tab1pic = new PictureBox();
		tab2pic = new PictureBox();
		tab4pic = new PictureBox();
		tab3pic = new PictureBox();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)mainbtn).BeginInit();
		((ISupportInitialize)displaybtn).BeginInit();
		((ISupportInitialize)aboutbtn).BeginInit();
		((ISupportInitialize)soundbtn).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((ISupportInitialize)PictureBox14).BeginInit();
		((ISupportInitialize)PictureBox15).BeginInit();
		((ISupportInitialize)tab1).BeginInit();
		((ISupportInitialize)tab2).BeginInit();
		((ISupportInitialize)tab4).BeginInit();
		((ISupportInitialize)tab3).BeginInit();
		((ISupportInitialize)mainchk).BeginInit();
		((ISupportInitialize)displaychk).BeginInit();
		((ISupportInitialize)soundchk).BeginInit();
		((ISupportInitialize)aboutchk).BeginInit();
		((ISupportInitialize)tab1pic).BeginInit();
		((ISupportInitialize)tab2pic).BeginInit();
		((ISupportInitialize)tab4pic).BeginInit();
		((ISupportInitialize)tab3pic).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox = PictureBox7;
		Point location = new Point(891, 2);
		((Control)pictureBox).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox2 = PictureBox7;
		Size size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 126;
		PictureBox7.TabStop = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj = defaultclose;
		location = new Point(159, 0);
		((Control)obj).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj2 = defaultclose;
		size = new Size(51, 34);
		((Control)obj2).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 125;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj3 = hoverclose;
		location = new Point(216, 0);
		((Control)obj3).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj4 = hoverclose;
		size = new Size(51, 34);
		((Control)obj4).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 124;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj5 = clickclose;
		location = new Point(273, 0);
		((Control)obj5).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj6 = clickclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 123;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox3 = PictureBox3;
		location = new Point(948, 2);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox4 = PictureBox3;
		size = new Size(51, 34);
		((Control)pictureBox4).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 122;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(37, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(62, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 121;
		Label1.Text = "Settings";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox5 = PictureBox2;
		location = new Point(9, 6);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox6 = PictureBox2;
		size = new Size(22, 22);
		((Control)pictureBox6).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 120;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox7 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox8 = PictureBox1;
		size = new Size(1400, 35);
		((Control)pictureBox8).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 119;
		PictureBox1.TabStop = false;
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox9 = PictureBox4;
		location = new Point(0, 34);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox10 = PictureBox4;
		size = new Size(1099, 75);
		((Control)pictureBox10).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 127;
		PictureBox4.TabStop = false;
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox11 = PictureBox5;
		location = new Point(699, 53);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox12 = PictureBox5;
		size = new Size(242, 34);
		((Control)pictureBox12).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)1;
		PictureBox5.TabIndex = 128;
		PictureBox5.TabStop = false;
		((Control)PictureBox6).BackColor = Color.White;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox13 = PictureBox6;
		location = new Point(947, 44);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox14 = PictureBox6;
		size = new Size(48, 48);
		((Control)pictureBox14).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 129;
		PictureBox6.TabStop = false;
		((Control)mainbtn).BackColor = Color.White;
		mainbtn.Image = (Image)componentResourceManager.GetObject("mainbtn.Image");
		PictureBox obj7 = mainbtn;
		location = new Point(164, 134);
		((Control)obj7).Location = location;
		((Control)mainbtn).Name = "mainbtn";
		PictureBox obj8 = mainbtn;
		size = new Size(155, 155);
		((Control)obj8).Size = size;
		mainbtn.SizeMode = (PictureBoxSizeMode)2;
		mainbtn.TabIndex = 130;
		mainbtn.TabStop = false;
		((Control)displaybtn).BackColor = Color.White;
		displaybtn.Image = (Image)componentResourceManager.GetObject("displaybtn.Image");
		PictureBox obj9 = displaybtn;
		location = new Point(336, 134);
		((Control)obj9).Location = location;
		((Control)displaybtn).Name = "displaybtn";
		PictureBox obj10 = displaybtn;
		size = new Size(155, 155);
		((Control)obj10).Size = size;
		displaybtn.SizeMode = (PictureBoxSizeMode)2;
		displaybtn.TabIndex = 131;
		displaybtn.TabStop = false;
		((Control)aboutbtn).BackColor = Color.White;
		aboutbtn.Image = (Image)componentResourceManager.GetObject("aboutbtn.Image");
		PictureBox obj11 = aboutbtn;
		location = new Point(681, 134);
		((Control)obj11).Location = location;
		((Control)aboutbtn).Name = "aboutbtn";
		PictureBox obj12 = aboutbtn;
		size = new Size(155, 155);
		((Control)obj12).Size = size;
		aboutbtn.SizeMode = (PictureBoxSizeMode)2;
		aboutbtn.TabIndex = 133;
		aboutbtn.TabStop = false;
		((Control)soundbtn).BackColor = Color.White;
		soundbtn.Image = (Image)componentResourceManager.GetObject("soundbtn.Image");
		PictureBox obj13 = soundbtn;
		location = new Point(509, 134);
		((Control)obj13).Location = location;
		((Control)soundbtn).Name = "soundbtn";
		PictureBox obj14 = soundbtn;
		size = new Size(155, 155);
		((Control)obj14).Size = size;
		soundbtn.SizeMode = (PictureBoxSizeMode)2;
		soundbtn.TabIndex = 132;
		soundbtn.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.White;
		((Control)Label2).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label3 = Label2;
		location = new Point(211, 251);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(59, 25);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 135;
		Label2.Text = "Main";
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.White;
		((Control)Label3).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label5 = Label3;
		location = new Point(376, 251);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(79, 25);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 136;
		Label3.Text = "Display";
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.White;
		((Control)Label4).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label7 = Label4;
		location = new Point(553, 251);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(70, 25);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 137;
		Label4.Text = "Sound";
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.White;
		((Control)Label5).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label9 = Label5;
		location = new Point(729, 251);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(65, 25);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 138;
		Label5.Text = "About";
		((Control)setdes).Anchor = (AnchorStyles)3;
		((Control)setdes).BackColor = Color.Transparent;
		((Control)setdes).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)setdes).ForeColor = Color.Black;
		setdes.ImageAlign = (ContentAlignment)64;
		Label obj15 = setdes;
		location = new Point(164, 341);
		((Control)obj15).Location = location;
		((Control)setdes).Name = "setdes";
		Label obj16 = setdes;
		size = new Size(672, 34);
		((Control)obj16).Size = size;
		((Control)setdes).TabIndex = 139;
		setdes.TextAlign = (ContentAlignment)32;
		((Control)PictureBox12).BackColor = Color.White;
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox15 = PictureBox12;
		location = new Point(190, 148);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox16 = PictureBox12;
		size = new Size(100, 100);
		((Control)pictureBox16).Size = size;
		PictureBox12.SizeMode = (PictureBoxSizeMode)4;
		PictureBox12.TabIndex = 140;
		PictureBox12.TabStop = false;
		((Control)PictureBox13).BackColor = Color.White;
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox17 = PictureBox13;
		location = new Point(364, 148);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox18 = PictureBox13;
		size = new Size(100, 100);
		((Control)pictureBox18).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)4;
		PictureBox13.TabIndex = 141;
		PictureBox13.TabStop = false;
		((Control)PictureBox14).BackColor = Color.White;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox19 = PictureBox14;
		location = new Point(711, 148);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox20 = PictureBox14;
		size = new Size(100, 100);
		((Control)pictureBox20).Size = size;
		PictureBox14.SizeMode = (PictureBoxSizeMode)4;
		PictureBox14.TabIndex = 143;
		PictureBox14.TabStop = false;
		((Control)PictureBox15).BackColor = Color.White;
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox pictureBox21 = PictureBox15;
		location = new Point(537, 148);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox pictureBox22 = PictureBox15;
		size = new Size(100, 100);
		((Control)pictureBox22).Size = size;
		PictureBox15.SizeMode = (PictureBoxSizeMode)4;
		PictureBox15.TabIndex = 142;
		PictureBox15.TabStop = false;
		((Control)tab1).BackColor = Color.White;
		tab1.Image = (Image)componentResourceManager.GetObject("tab1.Image");
		PictureBox obj17 = tab1;
		location = new Point(234, 424);
		((Control)obj17).Location = location;
		((Control)tab1).Name = "tab1";
		PictureBox obj18 = tab1;
		size = new Size(262, 63);
		((Control)obj18).Size = size;
		tab1.SizeMode = (PictureBoxSizeMode)2;
		tab1.TabIndex = 144;
		tab1.TabStop = false;
		((Control)tab2).BackColor = Color.White;
		tab2.Image = (Image)componentResourceManager.GetObject("tab2.Image");
		PictureBox obj19 = tab2;
		location = new Point(510, 424);
		((Control)obj19).Location = location;
		((Control)tab2).Name = "tab2";
		PictureBox obj20 = tab2;
		size = new Size(262, 63);
		((Control)obj20).Size = size;
		tab2.SizeMode = (PictureBoxSizeMode)2;
		tab2.TabIndex = 145;
		tab2.TabStop = false;
		((Control)tab4).BackColor = Color.White;
		tab4.Image = (Image)componentResourceManager.GetObject("tab4.Image");
		PictureBox obj21 = tab4;
		location = new Point(509, 517);
		((Control)obj21).Location = location;
		((Control)tab4).Name = "tab4";
		PictureBox obj22 = tab4;
		size = new Size(262, 63);
		((Control)obj22).Size = size;
		tab4.SizeMode = (PictureBoxSizeMode)2;
		tab4.TabIndex = 147;
		tab4.TabStop = false;
		((Control)tab3).BackColor = Color.White;
		tab3.Image = (Image)componentResourceManager.GetObject("tab3.Image");
		PictureBox obj23 = tab3;
		location = new Point(234, 517);
		((Control)obj23).Location = location;
		((Control)tab3).Name = "tab3";
		PictureBox obj24 = tab3;
		size = new Size(262, 63);
		((Control)obj24).Size = size;
		tab3.SizeMode = (PictureBoxSizeMode)2;
		tab3.TabIndex = 146;
		tab3.TabStop = false;
		((Control)tab1txt).Anchor = (AnchorStyles)3;
		((Control)tab1txt).BackColor = Color.Transparent;
		((Control)tab1txt).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)tab1txt).ForeColor = Color.DimGray;
		tab1txt.ImageAlign = (ContentAlignment)64;
		Label obj25 = tab1txt;
		location = new Point(288, 437);
		((Control)obj25).Location = location;
		((Control)tab1txt).Name = "tab1txt";
		Label obj26 = tab1txt;
		size = new Size(194, 34);
		((Control)obj26).Size = size;
		((Control)tab1txt).TabIndex = 148;
		tab1txt.TextAlign = (ContentAlignment)32;
		((Control)tab2txt).Anchor = (AnchorStyles)3;
		((Control)tab2txt).BackColor = Color.Transparent;
		((Control)tab2txt).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)tab2txt).ForeColor = Color.DimGray;
		tab2txt.ImageAlign = (ContentAlignment)64;
		Label obj27 = tab2txt;
		location = new Point(558, 437);
		((Control)obj27).Location = location;
		((Control)tab2txt).Name = "tab2txt";
		Label obj28 = tab2txt;
		size = new Size(200, 34);
		((Control)obj28).Size = size;
		((Control)tab2txt).TabIndex = 149;
		tab2txt.TextAlign = (ContentAlignment)32;
		((Control)tab4txt).Anchor = (AnchorStyles)3;
		((Control)tab4txt).BackColor = Color.Transparent;
		((Control)tab4txt).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)tab4txt).ForeColor = Color.DimGray;
		tab4txt.ImageAlign = (ContentAlignment)64;
		Label obj29 = tab4txt;
		location = new Point(562, 530);
		((Control)obj29).Location = location;
		((Control)tab4txt).Name = "tab4txt";
		Label obj30 = tab4txt;
		size = new Size(196, 34);
		((Control)obj30).Size = size;
		((Control)tab4txt).TabIndex = 151;
		tab4txt.TextAlign = (ContentAlignment)32;
		((Control)tab3txt).Anchor = (AnchorStyles)3;
		((Control)tab3txt).BackColor = Color.Transparent;
		((Control)tab3txt).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)tab3txt).ForeColor = Color.DimGray;
		tab3txt.ImageAlign = (ContentAlignment)64;
		Label obj31 = tab3txt;
		location = new Point(292, 530);
		((Control)obj31).Location = location;
		((Control)tab3txt).Name = "tab3txt";
		Label obj32 = tab3txt;
		size = new Size(190, 34);
		((Control)obj32).Size = size;
		((Control)tab3txt).TabIndex = 150;
		tab3txt.TextAlign = (ContentAlignment)32;
		((Control)mainchk).BackColor = Color.White;
		mainchk.Image = (Image)componentResourceManager.GetObject("mainchk.Image");
		PictureBox obj33 = mainchk;
		location = new Point(238, 305);
		((Control)obj33).Location = location;
		((Control)mainchk).Name = "mainchk";
		PictureBox obj34 = mainchk;
		size = new Size(10, 10);
		((Control)obj34).Size = size;
		mainchk.SizeMode = (PictureBoxSizeMode)2;
		mainchk.TabIndex = 152;
		mainchk.TabStop = false;
		((Control)mainchk).Visible = false;
		((Control)displaychk).BackColor = Color.White;
		displaychk.Image = (Image)componentResourceManager.GetObject("displaychk.Image");
		PictureBox obj35 = displaychk;
		location = new Point(411, 305);
		((Control)obj35).Location = location;
		((Control)displaychk).Name = "displaychk";
		PictureBox obj36 = displaychk;
		size = new Size(10, 10);
		((Control)obj36).Size = size;
		displaychk.SizeMode = (PictureBoxSizeMode)2;
		displaychk.TabIndex = 153;
		displaychk.TabStop = false;
		((Control)displaychk).Visible = false;
		((Control)soundchk).BackColor = Color.White;
		soundchk.Image = (Image)componentResourceManager.GetObject("soundchk.Image");
		PictureBox obj37 = soundchk;
		location = new Point(586, 305);
		((Control)obj37).Location = location;
		((Control)soundchk).Name = "soundchk";
		PictureBox obj38 = soundchk;
		size = new Size(10, 10);
		((Control)obj38).Size = size;
		soundchk.SizeMode = (PictureBoxSizeMode)2;
		soundchk.TabIndex = 154;
		soundchk.TabStop = false;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).BackColor = Color.White;
		aboutchk.Image = (Image)componentResourceManager.GetObject("aboutchk.Image");
		PictureBox obj39 = aboutchk;
		location = new Point(758, 305);
		((Control)obj39).Location = location;
		((Control)aboutchk).Name = "aboutchk";
		PictureBox obj40 = aboutchk;
		size = new Size(10, 10);
		((Control)obj40).Size = size;
		aboutchk.SizeMode = (PictureBoxSizeMode)2;
		aboutchk.TabIndex = 155;
		aboutchk.TabStop = false;
		((Control)aboutchk).Visible = false;
		((Control)tab1pic).BackColor = Color.White;
		tab1pic.Image = (Image)componentResourceManager.GetObject("tab1pic.Image");
		PictureBox obj41 = tab1pic;
		location = new Point(247, 446);
		((Control)obj41).Location = location;
		((Control)tab1pic).Name = "tab1pic";
		PictureBox obj42 = tab1pic;
		size = new Size(20, 20);
		((Control)obj42).Size = size;
		tab1pic.SizeMode = (PictureBoxSizeMode)4;
		tab1pic.TabIndex = 156;
		tab1pic.TabStop = false;
		((Control)tab2pic).BackColor = Color.White;
		tab2pic.Image = (Image)componentResourceManager.GetObject("tab2pic.Image");
		PictureBox obj43 = tab2pic;
		location = new Point(521, 446);
		((Control)obj43).Location = location;
		((Control)tab2pic).Name = "tab2pic";
		PictureBox obj44 = tab2pic;
		size = new Size(20, 20);
		((Control)obj44).Size = size;
		tab2pic.SizeMode = (PictureBoxSizeMode)4;
		tab2pic.TabIndex = 157;
		tab2pic.TabStop = false;
		((Control)tab4pic).BackColor = Color.White;
		tab4pic.Image = (Image)componentResourceManager.GetObject("tab4pic.Image");
		PictureBox obj45 = tab4pic;
		location = new Point(521, 540);
		((Control)obj45).Location = location;
		((Control)tab4pic).Name = "tab4pic";
		PictureBox obj46 = tab4pic;
		size = new Size(20, 20);
		((Control)obj46).Size = size;
		tab4pic.SizeMode = (PictureBoxSizeMode)4;
		tab4pic.TabIndex = 159;
		tab4pic.TabStop = false;
		((Control)tab3pic).BackColor = Color.White;
		tab3pic.Image = (Image)componentResourceManager.GetObject("tab3pic.Image");
		PictureBox obj47 = tab3pic;
		location = new Point(247, 540);
		((Control)obj47).Location = location;
		((Control)tab3pic).Name = "tab3pic";
		PictureBox obj48 = tab3pic;
		size = new Size(20, 20);
		((Control)obj48).Size = size;
		tab3pic.SizeMode = (PictureBoxSizeMode)4;
		tab3pic.TabIndex = 158;
		tab3pic.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1000, 650);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)tab4pic);
		((Control)this).Controls.Add((Control)(object)tab3pic);
		((Control)this).Controls.Add((Control)(object)tab2pic);
		((Control)this).Controls.Add((Control)(object)tab1pic);
		((Control)this).Controls.Add((Control)(object)aboutchk);
		((Control)this).Controls.Add((Control)(object)soundchk);
		((Control)this).Controls.Add((Control)(object)displaychk);
		((Control)this).Controls.Add((Control)(object)mainchk);
		((Control)this).Controls.Add((Control)(object)tab4txt);
		((Control)this).Controls.Add((Control)(object)tab3txt);
		((Control)this).Controls.Add((Control)(object)tab2txt);
		((Control)this).Controls.Add((Control)(object)tab1txt);
		((Control)this).Controls.Add((Control)(object)tab4);
		((Control)this).Controls.Add((Control)(object)tab3);
		((Control)this).Controls.Add((Control)(object)tab2);
		((Control)this).Controls.Add((Control)(object)tab1);
		((Control)this).Controls.Add((Control)(object)PictureBox14);
		((Control)this).Controls.Add((Control)(object)PictureBox15);
		((Control)this).Controls.Add((Control)(object)PictureBox13);
		((Control)this).Controls.Add((Control)(object)PictureBox12);
		((Control)this).Controls.Add((Control)(object)setdes);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)aboutbtn);
		((Control)this).Controls.Add((Control)(object)soundbtn);
		((Control)this).Controls.Add((Control)(object)displaybtn);
		((Control)this).Controls.Add((Control)(object)mainbtn);
		((Control)this).Controls.Add((Control)(object)PictureBox6);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "settings";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)mainbtn).EndInit();
		((ISupportInitialize)displaybtn).EndInit();
		((ISupportInitialize)aboutbtn).EndInit();
		((ISupportInitialize)soundbtn).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((ISupportInitialize)PictureBox14).EndInit();
		((ISupportInitialize)PictureBox15).EndInit();
		((ISupportInitialize)tab1).EndInit();
		((ISupportInitialize)tab2).EndInit();
		((ISupportInitialize)tab4).EndInit();
		((ISupportInitialize)tab3).EndInit();
		((ISupportInitialize)mainchk).EndInit();
		((ISupportInitialize)displaychk).EndInit();
		((ISupportInitialize)soundchk).EndInit();
		((ISupportInitialize)aboutchk).EndInit();
		((ISupportInitialize)tab1pic).EndInit();
		((ISupportInitialize)tab2pic).EndInit();
		((ISupportInitialize)tab4pic).EndInit();
		((ISupportInitialize)tab3pic).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void settings_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.settingsout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.sett.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void settings_Load(object sender, EventArgs e)
	{
		tab1pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab2pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
		if (!((Control)MyProject.Forms.home.app1).Enabled)
		{
			((Control)MyProject.Forms.home.app1).Enabled = true;
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app2).Enabled)
		{
			((Control)MyProject.Forms.home.app2).Enabled = true;
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app3).Enabled)
		{
			((Control)MyProject.Forms.home.app3).Enabled = true;
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app4).Enabled)
		{
			((Control)MyProject.Forms.home.app4).Enabled = true;
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app5).Enabled)
		{
			((Control)MyProject.Forms.home.app5).Enabled = true;
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app6).Enabled)
		{
			((Control)MyProject.Forms.home.app6).Enabled = true;
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app7).Enabled)
		{
			((Control)MyProject.Forms.home.app7).Enabled = true;
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app8).Enabled)
		{
			((Control)MyProject.Forms.home.app8).Enabled = true;
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app9).Enabled)
		{
			((Control)MyProject.Forms.home.app9).Enabled = true;
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app10).Enabled)
		{
			((Control)MyProject.Forms.home.app10).Enabled = true;
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app11).Enabled)
		{
			((Control)MyProject.Forms.home.app11).Enabled = true;
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app12).Enabled)
		{
			((Control)MyProject.Forms.home.app12).Enabled = true;
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app13).Enabled)
		{
			((Control)MyProject.Forms.home.app13).Enabled = true;
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app14).Enabled)
		{
			((Control)MyProject.Forms.home.app14).Enabled = true;
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app15).Enabled)
		{
			((Control)MyProject.Forms.home.app15).Enabled = true;
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app16).Enabled)
		{
			((Control)MyProject.Forms.home.app16).Enabled = true;
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app17).Enabled)
		{
			((Control)MyProject.Forms.home.app17).Enabled = true;
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app18).Enabled)
		{
			((Control)MyProject.Forms.home.app18).Enabled = true;
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app19).Enabled)
		{
			((Control)MyProject.Forms.home.app19).Enabled = true;
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app20).Enabled)
		{
			((Control)MyProject.Forms.home.app20).Enabled = true;
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app21).Enabled)
		{
			((Control)MyProject.Forms.home.app21).Enabled = true;
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app22).Enabled)
		{
			((Control)MyProject.Forms.home.app22).Enabled = true;
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app23).Enabled)
		{
			((Control)MyProject.Forms.home.app23).Enabled = true;
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app24).Enabled)
		{
			((Control)MyProject.Forms.home.app24).Enabled = true;
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.sett.Image;
		}
		else if (!((Control)MyProject.Forms.home.app25).Enabled)
		{
			((Control)MyProject.Forms.home.app25).Enabled = true;
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.sett.Image;
		}
		Fade.settingsin();
	}

	private void mainbtn_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = true;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Apps";
		tab1pic.Image = MyProject.Forms.settingsdata.apps.Image;
		tab2txt.Text = "Profile";
		tab2pic.Image = MyProject.Forms.settingsdata.profile.Image;
		tab3txt.Text = "Security";
		tab3pic.Image = MyProject.Forms.settingsdata.security.Image;
		tab4txt.Text = "Storage";
		tab4pic.Image = MyProject.Forms.settingsdata.storage.Image;
	}

	private void mainbtn_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void mainbtn_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Manage Apps, Profile, Security and Storage";
	}

	private void displaybtn_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = true;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Lock Screen";
		tab1pic.Image = MyProject.Forms.settingsdata.lockscreen.Image;
		tab2txt.Text = "Wallpapers";
		tab2pic.Image = MyProject.Forms.settingsdata.wallpaperss.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void displaybtn_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void displaybtn_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Set Wallpaper, Customize Home and Lock screen";
	}

	private void soundbtn_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = true;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Alarm Tone";
		tab1pic.Image = MyProject.Forms.settingsdata.alarm.Image;
		tab2txt.Text = "Notification Sound";
		tab2pic.Image = MyProject.Forms.settingsdata.notification.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void soundbtn_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void soundbtn_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Set Alarm, Notification Sounds";
	}

	private void aboutbtn_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = true;
		tab1txt.Text = "Wixzel OS";
		tab1pic.Image = MyProject.Forms.settingsdata.wixzel.Image;
		tab2txt.Text = "Updates";
		tab2pic.Image = MyProject.Forms.settingsdata.updates.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void aboutbtn_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void aboutbtn_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "View basic information about Wixzel OS PC";
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.settingalarm).Close();
		((Form)MyProject.Forms.settingapps).Close();
		((Form)MyProject.Forms.settinglockscreen).Close();
		((Form)MyProject.Forms.settingnotification).Close();
		((Form)MyProject.Forms.settingprofile).Close();
		((Form)MyProject.Forms.settingsecurity).Close();
		((Form)this).Close();
	}

	private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
	{
		PictureBox3.Image = clickclose.Image;
	}

	private void PictureBox3_MouseLeave(object sender, EventArgs e)
	{
		PictureBox3.Image = defaultclose.Image;
	}

	private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
	{
		if (!((object)PictureBox3.Image).Equals((object?)clickclose.Image))
		{
			PictureBox3.Image = hoverclose.Image;
		}
	}

	private void Label2_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = true;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Apps";
		tab1pic.Image = MyProject.Forms.settingsdata.apps.Image;
		tab2txt.Text = "Profile";
		tab2pic.Image = MyProject.Forms.settingsdata.profile.Image;
		tab3txt.Text = "Security";
		tab3pic.Image = MyProject.Forms.settingsdata.security.Image;
		tab4txt.Text = "Storage";
		tab4pic.Image = MyProject.Forms.settingsdata.storage.Image;
	}

	private void Label2_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void Label2_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Manage Apps, Profile, Security and Storage";
	}

	private void PictureBox12_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = true;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Apps";
		tab1pic.Image = MyProject.Forms.settingsdata.apps.Image;
		tab2txt.Text = "Profile";
		tab2pic.Image = MyProject.Forms.settingsdata.profile.Image;
		tab3txt.Text = "Security";
		tab3pic.Image = MyProject.Forms.settingsdata.security.Image;
		tab4txt.Text = "Storage";
		tab4pic.Image = MyProject.Forms.settingsdata.storage.Image;
	}

	private void PictureBox12_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void PictureBox12_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Manage Apps, Profile, Security and Storage";
	}

	private void Label3_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = true;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Lock Screen";
		tab1pic.Image = MyProject.Forms.settingsdata.lockscreen.Image;
		tab2txt.Text = "Wallpapers";
		tab2pic.Image = MyProject.Forms.settingsdata.wallpaperss.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void Label3_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void Label3_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Set Wallpaper, Customize Home and Lock screen";
	}

	private void PictureBox13_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = true;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Lock Screen";
		tab1pic.Image = MyProject.Forms.settingsdata.lockscreen.Image;
		tab2txt.Text = "Wallpapers";
		tab2pic.Image = MyProject.Forms.settingsdata.wallpaperss.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void PictureBox13_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void PictureBox13_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Set Wallpaper, Customize Home and Lock screen";
	}

	private void Label4_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = true;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Alarm Tone";
		tab1pic.Image = MyProject.Forms.settingsdata.alarm.Image;
		tab2txt.Text = "Notification Sound";
		tab2pic.Image = MyProject.Forms.settingsdata.notification.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void Label4_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void Label4_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Set Alarm, Notification Sounds";
	}

	private void Label4_MouseUp(object sender, MouseEventArgs e)
	{
	}

	private void PictureBox15_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = true;
		((Control)aboutchk).Visible = false;
		tab1txt.Text = "Alarm Tone";
		tab1pic.Image = MyProject.Forms.settingsdata.alarm.Image;
		tab2txt.Text = "Notification Sound";
		tab2pic.Image = MyProject.Forms.settingsdata.notification.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void PictureBox15_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void PictureBox15_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "Set Alarm, Notification Sounds";
	}

	private void Label5_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = true;
		tab1txt.Text = "Wixzel OS";
		tab1pic.Image = MyProject.Forms.settingsdata.wixzel.Image;
		tab2txt.Text = "Updates";
		tab2pic.Image = MyProject.Forms.settingsdata.updates.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void Label5_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void Label5_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "View basic information about Wixzel OS PC";
	}

	private void PictureBox14_Click(object sender, EventArgs e)
	{
		((Control)mainchk).Visible = false;
		((Control)displaychk).Visible = false;
		((Control)soundchk).Visible = false;
		((Control)aboutchk).Visible = true;
		tab1txt.Text = "Wixzel OS";
		tab1pic.Image = MyProject.Forms.settingsdata.wixzel.Image;
		tab2txt.Text = "Updates";
		tab2pic.Image = MyProject.Forms.settingsdata.updates.Image;
		tab3txt.Text = "";
		tab3pic.Image = MyProject.Forms.settingsdata.none.Image;
		tab4txt.Text = "";
		tab4pic.Image = MyProject.Forms.settingsdata.none.Image;
	}

	private void PictureBox14_MouseLeave(object sender, EventArgs e)
	{
		setdes.Text = "";
	}

	private void PictureBox14_MouseMove(object sender, MouseEventArgs e)
	{
		setdes.Text = "View basic information about Wixzel OS PC";
	}

	private void tab1txt_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(tab1txt.Text, "Apps", false) == 0)
		{
			((Form)MyProject.Forms.settingapps).TopMost = true;
			((Control)MyProject.Forms.settingapps).Show();
		}
		else if (Operators.CompareString(tab1txt.Text, "Lock Screen", false) == 0)
		{
			((Control)MyProject.Forms.dialog).Show();
			MyProject.Forms.dialog.Label1.Text = "Settings for Lock Screen will update soon via Wixzel Update";
		}
		else if (Operators.CompareString(tab1txt.Text, "Alarm Tone", false) == 0)
		{
			((Control)MyProject.Forms.dialog).Show();
			MyProject.Forms.dialog.Label1.Text = "Settings for Alarm Tone will update soon via Wixzel Update";
		}
		else if (Operators.CompareString(tab1txt.Text, "Wixzel OS", false) == 0)
		{
			((Control)MyProject.Forms.about).Show();
		}
	}

	private void tab1txt_MouseLeave(object sender, EventArgs e)
	{
		((Control)tab1txt).ForeColor = Color.DimGray;
	}

	private void tab1txt_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)tab1txt).ForeColor = Color.RoyalBlue;
	}

	private void tab2txt_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(tab2txt.Text, "Profile", false) == 0)
		{
			((Form)MyProject.Forms.settingprofile).TopMost = true;
			((Control)MyProject.Forms.settingprofile).Show();
		}
		else if (Operators.CompareString(tab2txt.Text, "Wallpapers", false) == 0)
		{
			((Control)MyProject.Forms.wallpapers).Show();
		}
		else if (Operators.CompareString(tab2txt.Text, "Notification Sound", false) == 0)
		{
			((Control)MyProject.Forms.dialog).Show();
			MyProject.Forms.dialog.Label1.Text = "Settings for Notification Sound will update soon via Wixzel Update";
		}
		else if (Operators.CompareString(tab2txt.Text, "Updates", false) == 0)
		{
			((Control)MyProject.Forms.updates).Show();
		}
	}

	private void tab2txt_MouseLeave(object sender, EventArgs e)
	{
		((Control)tab2txt).ForeColor = Color.DimGray;
	}

	private void tab2txt_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)tab2txt).ForeColor = Color.RoyalBlue;
	}

	private void tab3txt_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(tab3txt.Text, "Security", false) == 0)
		{
			((Control)MyProject.Forms.dialog).Show();
			MyProject.Forms.dialog.Label1.Text = "Wixzel Security is under development. It will update soon via Wixzel Update.";
		}
	}

	private void tab3txt_MouseLeave(object sender, EventArgs e)
	{
		((Control)tab3txt).ForeColor = Color.DimGray;
	}

	private void tab3txt_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)tab3txt).ForeColor = Color.RoyalBlue;
	}

	private void tab4txt_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(tab4txt.Text, "Storage", false) == 0)
		{
			((Control)MyProject.Forms.diskmanagement).Show();
		}
	}

	private void tab4txt_MouseLeave(object sender, EventArgs e)
	{
		((Control)tab4txt).ForeColor = Color.DimGray;
	}

	private void tab4txt_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)tab4txt).ForeColor = Color.RoyalBlue;
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
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

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	private void Label1_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
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

	private void PictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
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
}
