using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class diskmanagement : Form
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

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("main")]
	private Label _main;

	[AccessedThroughProperty("n2")]
	private Label _n2;

	[AccessedThroughProperty("n4")]
	private Label _n4;

	[AccessedThroughProperty("n3")]
	private Label _n3;

	[AccessedThroughProperty("n8")]
	private Label _n8;

	[AccessedThroughProperty("n7")]
	private Label _n7;

	[AccessedThroughProperty("n6")]
	private Label _n6;

	[AccessedThroughProperty("n5")]
	private Label _n5;

	[AccessedThroughProperty("n9")]
	private Label _n9;

	[AccessedThroughProperty("mainp")]
	private PictureBox _mainp;

	[AccessedThroughProperty("n2p")]
	private PictureBox _n2p;

	[AccessedThroughProperty("n4p")]
	private PictureBox _n4p;

	[AccessedThroughProperty("n3p")]
	private PictureBox _n3p;

	[AccessedThroughProperty("n8p")]
	private PictureBox _n8p;

	[AccessedThroughProperty("n7p")]
	private PictureBox _n7p;

	[AccessedThroughProperty("n6p")]
	private PictureBox _n6p;

	[AccessedThroughProperty("n5p")]
	private PictureBox _n5p;

	[AccessedThroughProperty("n9p")]
	private PictureBox _n9p;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("n2l")]
	private Label _n2l;

	[AccessedThroughProperty("n4l")]
	private Label _n4l;

	[AccessedThroughProperty("n3l")]
	private Label _n3l;

	[AccessedThroughProperty("n8l")]
	private Label _n8l;

	[AccessedThroughProperty("n7l")]
	private Label _n7l;

	[AccessedThroughProperty("n6l")]
	private Label _n6l;

	[AccessedThroughProperty("n5l")]
	private Label _n5l;

	[AccessedThroughProperty("n9l")]
	private Label _n9l;

	[AccessedThroughProperty("mainopen")]
	private PictureBox _mainopen;

	[AccessedThroughProperty("n3open")]
	private PictureBox _n3open;

	[AccessedThroughProperty("n2open")]
	private PictureBox _n2open;

	[AccessedThroughProperty("n5open")]
	private PictureBox _n5open;

	[AccessedThroughProperty("n4open")]
	private PictureBox _n4open;

	[AccessedThroughProperty("n8open")]
	private PictureBox _n8open;

	[AccessedThroughProperty("n7open")]
	private PictureBox _n7open;

	[AccessedThroughProperty("n6open")]
	private PictureBox _n6open;

	[AccessedThroughProperty("n8del")]
	private PictureBox _n8del;

	[AccessedThroughProperty("n7del")]
	private PictureBox _n7del;

	[AccessedThroughProperty("n6del")]
	private PictureBox _n6del;

	[AccessedThroughProperty("n5del")]
	private PictureBox _n5del;

	[AccessedThroughProperty("n4del")]
	private PictureBox _n4del;

	[AccessedThroughProperty("n3del")]
	private PictureBox _n3del;

	[AccessedThroughProperty("n2del")]
	private PictureBox _n2del;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("refreshlabel")]
	private Label _refreshlabel;

	[AccessedThroughProperty("n9open")]
	private PictureBox _n9open;

	[AccessedThroughProperty("n9del")]
	private PictureBox _n9del;

	private string path;

	private string nextpath;

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox3_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox3_MouseMove);
			EventHandler eventHandler2 = PictureBox3_MouseLeave;
			MouseEventHandler val2 = new MouseEventHandler(PictureBox3_MouseDown);
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click -= eventHandler;
				((Control)_PictureBox3).MouseMove -= val;
				((Control)_PictureBox3).MouseLeave -= eventHandler2;
				((Control)_PictureBox3).MouseDown -= val2;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click += eventHandler;
				((Control)_PictureBox3).MouseMove += val;
				((Control)_PictureBox3).MouseLeave += eventHandler2;
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

	internal virtual Label main
	{
		[DebuggerNonUserCode]
		get
		{
			return _main;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_main = value;
		}
	}

	internal virtual Label n2
	{
		[DebuggerNonUserCode]
		get
		{
			return _n2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n2 = value;
		}
	}

	internal virtual Label n4
	{
		[DebuggerNonUserCode]
		get
		{
			return _n4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n4 = value;
		}
	}

	internal virtual Label n3
	{
		[DebuggerNonUserCode]
		get
		{
			return _n3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n3 = value;
		}
	}

	internal virtual Label n8
	{
		[DebuggerNonUserCode]
		get
		{
			return _n8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n8 = value;
		}
	}

	internal virtual Label n7
	{
		[DebuggerNonUserCode]
		get
		{
			return _n7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n7 = value;
		}
	}

	internal virtual Label n6
	{
		[DebuggerNonUserCode]
		get
		{
			return _n6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n6 = value;
		}
	}

	internal virtual Label n5
	{
		[DebuggerNonUserCode]
		get
		{
			return _n5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n5 = value;
		}
	}

	internal virtual Label n9
	{
		[DebuggerNonUserCode]
		get
		{
			return _n9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n9 = value;
		}
	}

	internal virtual PictureBox mainp
	{
		[DebuggerNonUserCode]
		get
		{
			return _mainp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mainp = value;
		}
	}

	internal virtual PictureBox n2p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n2p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n2p = value;
		}
	}

	internal virtual PictureBox n4p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n4p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n4p = value;
		}
	}

	internal virtual PictureBox n3p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n3p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n3p = value;
		}
	}

	internal virtual PictureBox n8p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n8p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n8p = value;
		}
	}

	internal virtual PictureBox n7p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n7p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n7p = value;
		}
	}

	internal virtual PictureBox n6p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n6p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n6p = value;
		}
	}

	internal virtual PictureBox n5p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n5p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n5p = value;
		}
	}

	internal virtual PictureBox n9p
	{
		[DebuggerNonUserCode]
		get
		{
			return _n9p;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n9p = value;
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

	internal virtual Label n2l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n2l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n2l = value;
		}
	}

	internal virtual Label n4l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n4l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n4l = value;
		}
	}

	internal virtual Label n3l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n3l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n3l = value;
		}
	}

	internal virtual Label n8l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n8l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n8l = value;
		}
	}

	internal virtual Label n7l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n7l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n7l = value;
		}
	}

	internal virtual Label n6l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n6l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n6l = value;
		}
	}

	internal virtual Label n5l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n5l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n5l = value;
		}
	}

	internal virtual Label n9l
	{
		[DebuggerNonUserCode]
		get
		{
			return _n9l;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n9l = value;
		}
	}

	internal virtual PictureBox mainopen
	{
		[DebuggerNonUserCode]
		get
		{
			return _mainopen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mainopen_Click;
			if (_mainopen != null)
			{
				((Control)_mainopen).Click -= eventHandler;
			}
			_mainopen = value;
			if (_mainopen != null)
			{
				((Control)_mainopen).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n3open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n3open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n3open_Click;
			if (_n3open != null)
			{
				((Control)_n3open).Click -= eventHandler;
			}
			_n3open = value;
			if (_n3open != null)
			{
				((Control)_n3open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n2open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n2open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n2open_Click;
			if (_n2open != null)
			{
				((Control)_n2open).Click -= eventHandler;
			}
			_n2open = value;
			if (_n2open != null)
			{
				((Control)_n2open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n5open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n5open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n5open_Click;
			if (_n5open != null)
			{
				((Control)_n5open).Click -= eventHandler;
			}
			_n5open = value;
			if (_n5open != null)
			{
				((Control)_n5open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n4open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n4open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n4open_Click;
			if (_n4open != null)
			{
				((Control)_n4open).Click -= eventHandler;
			}
			_n4open = value;
			if (_n4open != null)
			{
				((Control)_n4open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n8open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n8open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n8open_Click;
			if (_n8open != null)
			{
				((Control)_n8open).Click -= eventHandler;
			}
			_n8open = value;
			if (_n8open != null)
			{
				((Control)_n8open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n7open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n7open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n7open_Click;
			if (_n7open != null)
			{
				((Control)_n7open).Click -= eventHandler;
			}
			_n7open = value;
			if (_n7open != null)
			{
				((Control)_n7open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n6open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n6open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n6open_Click;
			if (_n6open != null)
			{
				((Control)_n6open).Click -= eventHandler;
			}
			_n6open = value;
			if (_n6open != null)
			{
				((Control)_n6open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n8del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n8del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n8del = value;
		}
	}

	internal virtual PictureBox n7del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n7del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n7del = value;
		}
	}

	internal virtual PictureBox n6del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n6del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n6del = value;
		}
	}

	internal virtual PictureBox n5del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n5del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n5del = value;
		}
	}

	internal virtual PictureBox n4del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n4del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n4del = value;
		}
	}

	internal virtual PictureBox n3del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n3del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n3del = value;
		}
	}

	internal virtual PictureBox n2del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n2del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n2del = value;
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
			EventHandler eventHandler = PictureBox4_Click;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click -= eventHandler;
			}
			_PictureBox4 = value;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label13_Click;
			if (_Label13 != null)
			{
				((Control)_Label13).Click -= eventHandler;
			}
			_Label13 = value;
			if (_Label13 != null)
			{
				((Control)_Label13).Click += eventHandler;
			}
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

	internal virtual PictureBox PictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8 = value;
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

	internal virtual Label refreshlabel
	{
		[DebuggerNonUserCode]
		get
		{
			return _refreshlabel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_refreshlabel = value;
		}
	}

	internal virtual PictureBox n9open
	{
		[DebuggerNonUserCode]
		get
		{
			return _n9open;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = n9open_Click;
			if (_n9open != null)
			{
				((Control)_n9open).Click -= eventHandler;
			}
			_n9open = value;
			if (_n9open != null)
			{
				((Control)_n9open).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox n9del
	{
		[DebuggerNonUserCode]
		get
		{
			return _n9del;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_n9del = value;
		}
	}

	[DebuggerNonUserCode]
	public diskmanagement()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(diskmanagement_FormClosing);
		((Form)this).Load += diskmanagement_Load;
		((Control)this).MouseLeave += diskmanagement_MouseLeave;
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
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_0752: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected O, but got Unknown
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected O, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a61: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		//IL_0b87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b91: Expected O, but got Unknown
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected O, but got Unknown
		//IL_0cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Expected O, but got Unknown
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0e07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Expected O, but got Unknown
		//IL_0ea7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb1: Expected O, but got Unknown
		//IL_0f47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f51: Expected O, but got Unknown
		//IL_0fd8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe2: Expected O, but got Unknown
		//IL_1077: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected O, but got Unknown
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Expected O, but got Unknown
		//IL_11cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d9: Expected O, but got Unknown
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1285: Expected O, but got Unknown
		//IL_1327: Unknown result type (might be due to invalid IL or missing references)
		//IL_1331: Expected O, but got Unknown
		//IL_13d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dd: Expected O, but got Unknown
		//IL_147f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1489: Expected O, but got Unknown
		//IL_152b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1535: Expected O, but got Unknown
		//IL_15e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f0: Expected O, but got Unknown
		//IL_168e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1698: Expected O, but got Unknown
		//IL_1743: Unknown result type (might be due to invalid IL or missing references)
		//IL_174d: Expected O, but got Unknown
		//IL_17f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1802: Expected O, but got Unknown
		//IL_18ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b7: Expected O, but got Unknown
		//IL_1962: Unknown result type (might be due to invalid IL or missing references)
		//IL_196c: Expected O, but got Unknown
		//IL_1a17: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a21: Expected O, but got Unknown
		//IL_1acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad6: Expected O, but got Unknown
		//IL_1b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8b: Expected O, but got Unknown
		//IL_1c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c31: Expected O, but got Unknown
		//IL_1cc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cd3: Expected O, but got Unknown
		//IL_1d78: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d82: Expected O, but got Unknown
		//IL_1e27: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e31: Expected O, but got Unknown
		//IL_1ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee0: Expected O, but got Unknown
		//IL_1f85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f8f: Expected O, but got Unknown
		//IL_2034: Unknown result type (might be due to invalid IL or missing references)
		//IL_203e: Expected O, but got Unknown
		//IL_20e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ed: Expected O, but got Unknown
		//IL_2192: Unknown result type (might be due to invalid IL or missing references)
		//IL_219c: Expected O, but got Unknown
		//IL_2241: Unknown result type (might be due to invalid IL or missing references)
		//IL_224b: Expected O, but got Unknown
		//IL_22f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_22fa: Expected O, but got Unknown
		//IL_239f: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a9: Expected O, but got Unknown
		//IL_244e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2458: Expected O, but got Unknown
		//IL_24fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2507: Expected O, but got Unknown
		//IL_25ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b6: Expected O, but got Unknown
		//IL_265b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2665: Expected O, but got Unknown
		//IL_2709: Unknown result type (might be due to invalid IL or missing references)
		//IL_2713: Expected O, but got Unknown
		//IL_27b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ba: Expected O, but got Unknown
		//IL_285c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2866: Expected O, but got Unknown
		//IL_2908: Unknown result type (might be due to invalid IL or missing references)
		//IL_2912: Expected O, but got Unknown
		//IL_29c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29cd: Expected O, but got Unknown
		//IL_2a6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a74: Expected O, but got Unknown
		//IL_2b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b23: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(diskmanagement));
		PictureBox7 = new PictureBox();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		main = new Label();
		n2 = new Label();
		n4 = new Label();
		n3 = new Label();
		n8 = new Label();
		n7 = new Label();
		n6 = new Label();
		n5 = new Label();
		n9 = new Label();
		mainp = new PictureBox();
		n2p = new PictureBox();
		n4p = new PictureBox();
		n3p = new PictureBox();
		n8p = new PictureBox();
		n7p = new PictureBox();
		n6p = new PictureBox();
		n5p = new PictureBox();
		n9p = new PictureBox();
		Label3 = new Label();
		n2l = new Label();
		n4l = new Label();
		n3l = new Label();
		n8l = new Label();
		n7l = new Label();
		n6l = new Label();
		n5l = new Label();
		n9l = new Label();
		mainopen = new PictureBox();
		n3open = new PictureBox();
		n2open = new PictureBox();
		n5open = new PictureBox();
		n4open = new PictureBox();
		n8open = new PictureBox();
		n7open = new PictureBox();
		n6open = new PictureBox();
		n8del = new PictureBox();
		n7del = new PictureBox();
		n6del = new PictureBox();
		n5del = new PictureBox();
		n4del = new PictureBox();
		n3del = new PictureBox();
		n2del = new PictureBox();
		PictureBox4 = new PictureBox();
		Label13 = new Label();
		PictureBox5 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox8 = new PictureBox();
		Timer1 = new Timer(components);
		refreshlabel = new Label();
		n9open = new PictureBox();
		n9del = new PictureBox();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)mainp).BeginInit();
		((ISupportInitialize)n2p).BeginInit();
		((ISupportInitialize)n4p).BeginInit();
		((ISupportInitialize)n3p).BeginInit();
		((ISupportInitialize)n8p).BeginInit();
		((ISupportInitialize)n7p).BeginInit();
		((ISupportInitialize)n6p).BeginInit();
		((ISupportInitialize)n5p).BeginInit();
		((ISupportInitialize)n9p).BeginInit();
		((ISupportInitialize)mainopen).BeginInit();
		((ISupportInitialize)n3open).BeginInit();
		((ISupportInitialize)n2open).BeginInit();
		((ISupportInitialize)n5open).BeginInit();
		((ISupportInitialize)n4open).BeginInit();
		((ISupportInitialize)n8open).BeginInit();
		((ISupportInitialize)n7open).BeginInit();
		((ISupportInitialize)n6open).BeginInit();
		((ISupportInitialize)n8del).BeginInit();
		((ISupportInitialize)n7del).BeginInit();
		((ISupportInitialize)n6del).BeginInit();
		((ISupportInitialize)n5del).BeginInit();
		((ISupportInitialize)n4del).BeginInit();
		((ISupportInitialize)n3del).BeginInit();
		((ISupportInitialize)n2del).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)n9open).BeginInit();
		((ISupportInitialize)n9del).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox = PictureBox7;
		Point location = new Point(892, 0);
		((Control)pictureBox).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox2 = PictureBox7;
		Size size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 125;
		PictureBox7.TabStop = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj = defaultclose;
		location = new Point(644, 0);
		((Control)obj).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj2 = defaultclose;
		size = new Size(51, 34);
		((Control)obj2).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 124;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj3 = hoverclose;
		location = new Point(701, 0);
		((Control)obj3).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj4 = hoverclose;
		size = new Size(51, 34);
		((Control)obj4).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 123;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj5 = clickclose;
		location = new Point(758, 0);
		((Control)obj5).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj6 = clickclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 122;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox3 = PictureBox3;
		location = new Point(949, 0);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox4 = PictureBox3;
		size = new Size(51, 34);
		((Control)pictureBox4).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 121;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(37, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(137, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 120;
		Label1.Text = "Disk Management";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox5 = PictureBox2;
		location = new Point(9, 12);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox6 = PictureBox2;
		size = new Size(22, 9);
		((Control)pictureBox6).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 119;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox7 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox8 = PictureBox1;
		size = new Size(1000, 34);
		((Control)pictureBox8).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 118;
		PictureBox1.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Futura Bk BT", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label3 = Label2;
		location = new Point(12, 76);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(312, 35);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 126;
		Label2.Text = "Available Disk Drives:";
		main.AutoSize = true;
		((Control)main).BackColor = Color.Transparent;
		((Control)main).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj7 = main;
		location = new Point(120, 148);
		((Control)obj7).Location = location;
		((Control)main).Name = "main";
		Label obj8 = main;
		size = new Size(0, 22);
		((Control)obj8).Size = size;
		((Control)main).TabIndex = 127;
		n2.AutoSize = true;
		((Control)n2).BackColor = Color.Transparent;
		((Control)n2).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj9 = n2;
		location = new Point(120, 196);
		((Control)obj9).Location = location;
		((Control)n2).Name = "n2";
		Label obj10 = n2;
		size = new Size(0, 22);
		((Control)obj10).Size = size;
		((Control)n2).TabIndex = 128;
		((Control)n2).Visible = false;
		n4.AutoSize = true;
		((Control)n4).BackColor = Color.Transparent;
		((Control)n4).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj11 = n4;
		location = new Point(120, 293);
		((Control)obj11).Location = location;
		((Control)n4).Name = "n4";
		Label obj12 = n4;
		size = new Size(0, 22);
		((Control)obj12).Size = size;
		((Control)n4).TabIndex = 130;
		((Control)n4).Visible = false;
		n3.AutoSize = true;
		((Control)n3).BackColor = Color.Transparent;
		((Control)n3).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj13 = n3;
		location = new Point(120, 245);
		((Control)obj13).Location = location;
		((Control)n3).Name = "n3";
		Label obj14 = n3;
		size = new Size(0, 22);
		((Control)obj14).Size = size;
		((Control)n3).TabIndex = 129;
		((Control)n3).Visible = false;
		n8.AutoSize = true;
		((Control)n8).BackColor = Color.Transparent;
		((Control)n8).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj15 = n8;
		location = new Point(120, 490);
		((Control)obj15).Location = location;
		((Control)n8).Name = "n8";
		Label obj16 = n8;
		size = new Size(0, 22);
		((Control)obj16).Size = size;
		((Control)n8).TabIndex = 134;
		((Control)n8).Visible = false;
		n7.AutoSize = true;
		((Control)n7).BackColor = Color.Transparent;
		((Control)n7).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj17 = n7;
		location = new Point(120, 442);
		((Control)obj17).Location = location;
		((Control)n7).Name = "n7";
		Label obj18 = n7;
		size = new Size(0, 22);
		((Control)obj18).Size = size;
		((Control)n7).TabIndex = 133;
		((Control)n7).Visible = false;
		n6.AutoSize = true;
		((Control)n6).BackColor = Color.Transparent;
		((Control)n6).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj19 = n6;
		location = new Point(120, 393);
		((Control)obj19).Location = location;
		((Control)n6).Name = "n6";
		Label obj20 = n6;
		size = new Size(0, 22);
		((Control)obj20).Size = size;
		((Control)n6).TabIndex = 132;
		((Control)n6).Visible = false;
		n5.AutoSize = true;
		((Control)n5).BackColor = Color.Transparent;
		((Control)n5).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj21 = n5;
		location = new Point(120, 345);
		((Control)obj21).Location = location;
		((Control)n5).Name = "n5";
		Label obj22 = n5;
		size = new Size(0, 22);
		((Control)obj22).Size = size;
		((Control)n5).TabIndex = 131;
		((Control)n5).Visible = false;
		n9.AutoSize = true;
		((Control)n9).BackColor = Color.Transparent;
		((Control)n9).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj23 = n9;
		location = new Point(120, 541);
		((Control)obj23).Location = location;
		((Control)n9).Name = "n9";
		Label obj24 = n9;
		size = new Size(0, 22);
		((Control)obj24).Size = size;
		((Control)n9).TabIndex = 135;
		((Control)n9).Visible = false;
		((Control)mainp).BackColor = Color.White;
		mainp.Image = (Image)componentResourceManager.GetObject("mainp.Image");
		PictureBox obj25 = mainp;
		location = new Point(50, 145);
		((Control)obj25).Location = location;
		((Control)mainp).Name = "mainp";
		PictureBox obj26 = mainp;
		size = new Size(64, 25);
		((Control)obj26).Size = size;
		mainp.SizeMode = (PictureBoxSizeMode)2;
		mainp.TabIndex = 142;
		mainp.TabStop = false;
		((Control)n2p).BackColor = Color.White;
		n2p.Image = (Image)componentResourceManager.GetObject("n2p.Image");
		PictureBox obj27 = n2p;
		location = new Point(50, 193);
		((Control)obj27).Location = location;
		((Control)n2p).Name = "n2p";
		PictureBox obj28 = n2p;
		size = new Size(64, 26);
		((Control)obj28).Size = size;
		n2p.SizeMode = (PictureBoxSizeMode)2;
		n2p.TabIndex = 143;
		n2p.TabStop = false;
		((Control)n2p).Visible = false;
		((Control)n4p).BackColor = Color.White;
		n4p.Image = (Image)componentResourceManager.GetObject("n4p.Image");
		PictureBox obj29 = n4p;
		location = new Point(50, 290);
		((Control)obj29).Location = location;
		((Control)n4p).Name = "n4p";
		PictureBox obj30 = n4p;
		size = new Size(64, 26);
		((Control)obj30).Size = size;
		n4p.SizeMode = (PictureBoxSizeMode)2;
		n4p.TabIndex = 145;
		n4p.TabStop = false;
		((Control)n4p).Visible = false;
		((Control)n3p).BackColor = Color.White;
		n3p.Image = (Image)componentResourceManager.GetObject("n3p.Image");
		PictureBox obj31 = n3p;
		location = new Point(50, 242);
		((Control)obj31).Location = location;
		((Control)n3p).Name = "n3p";
		PictureBox obj32 = n3p;
		size = new Size(64, 26);
		((Control)obj32).Size = size;
		n3p.SizeMode = (PictureBoxSizeMode)2;
		n3p.TabIndex = 144;
		n3p.TabStop = false;
		((Control)n3p).Visible = false;
		((Control)n8p).BackColor = Color.White;
		n8p.Image = (Image)componentResourceManager.GetObject("n8p.Image");
		PictureBox obj33 = n8p;
		location = new Point(50, 487);
		((Control)obj33).Location = location;
		((Control)n8p).Name = "n8p";
		PictureBox obj34 = n8p;
		size = new Size(64, 26);
		((Control)obj34).Size = size;
		n8p.SizeMode = (PictureBoxSizeMode)2;
		n8p.TabIndex = 149;
		n8p.TabStop = false;
		((Control)n8p).Visible = false;
		((Control)n7p).BackColor = Color.White;
		n7p.Image = (Image)componentResourceManager.GetObject("n7p.Image");
		PictureBox obj35 = n7p;
		location = new Point(50, 439);
		((Control)obj35).Location = location;
		((Control)n7p).Name = "n7p";
		PictureBox obj36 = n7p;
		size = new Size(64, 26);
		((Control)obj36).Size = size;
		n7p.SizeMode = (PictureBoxSizeMode)2;
		n7p.TabIndex = 148;
		n7p.TabStop = false;
		((Control)n7p).Visible = false;
		((Control)n6p).BackColor = Color.White;
		n6p.Image = (Image)componentResourceManager.GetObject("n6p.Image");
		PictureBox obj37 = n6p;
		location = new Point(50, 390);
		((Control)obj37).Location = location;
		((Control)n6p).Name = "n6p";
		PictureBox obj38 = n6p;
		size = new Size(64, 26);
		((Control)obj38).Size = size;
		n6p.SizeMode = (PictureBoxSizeMode)2;
		n6p.TabIndex = 147;
		n6p.TabStop = false;
		((Control)n6p).Visible = false;
		((Control)n5p).BackColor = Color.White;
		n5p.Image = (Image)componentResourceManager.GetObject("n5p.Image");
		PictureBox obj39 = n5p;
		location = new Point(50, 342);
		((Control)obj39).Location = location;
		((Control)n5p).Name = "n5p";
		PictureBox obj40 = n5p;
		size = new Size(64, 26);
		((Control)obj40).Size = size;
		n5p.SizeMode = (PictureBoxSizeMode)2;
		n5p.TabIndex = 146;
		n5p.TabStop = false;
		((Control)n5p).Visible = false;
		((Control)n9p).BackColor = Color.White;
		n9p.Image = (Image)componentResourceManager.GetObject("n9p.Image");
		PictureBox obj41 = n9p;
		location = new Point(50, 538);
		((Control)obj41).Location = location;
		((Control)n9p).Name = "n9p";
		PictureBox obj42 = n9p;
		size = new Size(64, 26);
		((Control)obj42).Size = size;
		n9p.SizeMode = (PictureBoxSizeMode)2;
		n9p.TabIndex = 150;
		n9p.TabStop = false;
		((Control)n9p).Visible = false;
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label5 = Label3;
		location = new Point(394, 148);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(73, 22);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 152;
		Label3.Text = "System";
		n2l.AutoSize = true;
		((Control)n2l).BackColor = Color.Transparent;
		((Control)n2l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj43 = n2l;
		location = new Point(394, 196);
		((Control)obj43).Location = location;
		((Control)n2l).Name = "n2l";
		Label obj44 = n2l;
		size = new Size(81, 22);
		((Control)obj44).Size = size;
		((Control)n2l).TabIndex = 153;
		n2l.Text = "Primary";
		((Control)n2l).Visible = false;
		n4l.AutoSize = true;
		((Control)n4l).BackColor = Color.Transparent;
		((Control)n4l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj45 = n4l;
		location = new Point(394, 294);
		((Control)obj45).Location = location;
		((Control)n4l).Name = "n4l";
		Label obj46 = n4l;
		size = new Size(81, 22);
		((Control)obj46).Size = size;
		((Control)n4l).TabIndex = 155;
		n4l.Text = "Primary";
		((Control)n4l).Visible = false;
		n3l.AutoSize = true;
		((Control)n3l).BackColor = Color.Transparent;
		((Control)n3l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj47 = n3l;
		location = new Point(394, 246);
		((Control)obj47).Location = location;
		((Control)n3l).Name = "n3l";
		Label obj48 = n3l;
		size = new Size(81, 22);
		((Control)obj48).Size = size;
		((Control)n3l).TabIndex = 154;
		n3l.Text = "Primary";
		((Control)n3l).Visible = false;
		n8l.AutoSize = true;
		((Control)n8l).BackColor = Color.Transparent;
		((Control)n8l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj49 = n8l;
		location = new Point(394, 492);
		((Control)obj49).Location = location;
		((Control)n8l).Name = "n8l";
		Label obj50 = n8l;
		size = new Size(81, 22);
		((Control)obj50).Size = size;
		((Control)n8l).TabIndex = 159;
		n8l.Text = "Primary";
		((Control)n8l).Visible = false;
		n7l.AutoSize = true;
		((Control)n7l).BackColor = Color.Transparent;
		((Control)n7l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj51 = n7l;
		location = new Point(394, 444);
		((Control)obj51).Location = location;
		((Control)n7l).Name = "n7l";
		Label obj52 = n7l;
		size = new Size(81, 22);
		((Control)obj52).Size = size;
		((Control)n7l).TabIndex = 158;
		n7l.Text = "Primary";
		((Control)n7l).Visible = false;
		n6l.AutoSize = true;
		((Control)n6l).BackColor = Color.Transparent;
		((Control)n6l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj53 = n6l;
		location = new Point(394, 394);
		((Control)obj53).Location = location;
		((Control)n6l).Name = "n6l";
		Label obj54 = n6l;
		size = new Size(81, 22);
		((Control)obj54).Size = size;
		((Control)n6l).TabIndex = 157;
		n6l.Text = "Primary";
		((Control)n6l).Visible = false;
		n5l.AutoSize = true;
		((Control)n5l).BackColor = Color.Transparent;
		((Control)n5l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj55 = n5l;
		location = new Point(394, 346);
		((Control)obj55).Location = location;
		((Control)n5l).Name = "n5l";
		Label obj56 = n5l;
		size = new Size(81, 22);
		((Control)obj56).Size = size;
		((Control)n5l).TabIndex = 156;
		n5l.Text = "Primary";
		((Control)n5l).Visible = false;
		n9l.AutoSize = true;
		((Control)n9l).BackColor = Color.Transparent;
		((Control)n9l).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj57 = n9l;
		location = new Point(394, 541);
		((Control)obj57).Location = location;
		((Control)n9l).Name = "n9l";
		Label obj58 = n9l;
		size = new Size(81, 22);
		((Control)obj58).Size = size;
		((Control)n9l).TabIndex = 160;
		n9l.Text = "Primary";
		((Control)n9l).Visible = false;
		((Control)mainopen).BackColor = Color.White;
		mainopen.Image = (Image)componentResourceManager.GetObject("mainopen.Image");
		PictureBox obj59 = mainopen;
		location = new Point(855, 145);
		((Control)obj59).Location = location;
		((Control)mainopen).Name = "mainopen";
		PictureBox obj60 = mainopen;
		size = new Size(25, 25);
		((Control)obj60).Size = size;
		mainopen.SizeMode = (PictureBoxSizeMode)2;
		mainopen.TabIndex = 162;
		mainopen.TabStop = false;
		((Control)n3open).BackColor = Color.White;
		n3open.Image = (Image)componentResourceManager.GetObject("n3open.Image");
		PictureBox obj61 = n3open;
		location = new Point(855, 242);
		((Control)obj61).Location = location;
		((Control)n3open).Name = "n3open";
		PictureBox obj62 = n3open;
		size = new Size(25, 25);
		((Control)obj62).Size = size;
		n3open.SizeMode = (PictureBoxSizeMode)2;
		n3open.TabIndex = 165;
		n3open.TabStop = false;
		((Control)n3open).Visible = false;
		((Control)n2open).BackColor = Color.White;
		n2open.Image = (Image)componentResourceManager.GetObject("n2open.Image");
		PictureBox obj63 = n2open;
		location = new Point(855, 193);
		((Control)obj63).Location = location;
		((Control)n2open).Name = "n2open";
		PictureBox obj64 = n2open;
		size = new Size(25, 25);
		((Control)obj64).Size = size;
		n2open.SizeMode = (PictureBoxSizeMode)2;
		n2open.TabIndex = 164;
		n2open.TabStop = false;
		((Control)n2open).Visible = false;
		((Control)n5open).BackColor = Color.White;
		n5open.Image = (Image)componentResourceManager.GetObject("n5open.Image");
		PictureBox obj65 = n5open;
		location = new Point(855, 342);
		((Control)obj65).Location = location;
		((Control)n5open).Name = "n5open";
		PictureBox obj66 = n5open;
		size = new Size(25, 25);
		((Control)obj66).Size = size;
		n5open.SizeMode = (PictureBoxSizeMode)2;
		n5open.TabIndex = 167;
		n5open.TabStop = false;
		((Control)n5open).Visible = false;
		((Control)n4open).BackColor = Color.White;
		n4open.Image = (Image)componentResourceManager.GetObject("n4open.Image");
		PictureBox obj67 = n4open;
		location = new Point(855, 293);
		((Control)obj67).Location = location;
		((Control)n4open).Name = "n4open";
		PictureBox obj68 = n4open;
		size = new Size(25, 25);
		((Control)obj68).Size = size;
		n4open.SizeMode = (PictureBoxSizeMode)2;
		n4open.TabIndex = 166;
		n4open.TabStop = false;
		((Control)n4open).Visible = false;
		((Control)n8open).BackColor = Color.White;
		n8open.Image = (Image)componentResourceManager.GetObject("n8open.Image");
		PictureBox obj69 = n8open;
		location = new Point(855, 490);
		((Control)obj69).Location = location;
		((Control)n8open).Name = "n8open";
		PictureBox obj70 = n8open;
		size = new Size(25, 25);
		((Control)obj70).Size = size;
		n8open.SizeMode = (PictureBoxSizeMode)2;
		n8open.TabIndex = 170;
		n8open.TabStop = false;
		((Control)n8open).Visible = false;
		((Control)n7open).BackColor = Color.White;
		n7open.Image = (Image)componentResourceManager.GetObject("n7open.Image");
		PictureBox obj71 = n7open;
		location = new Point(855, 439);
		((Control)obj71).Location = location;
		((Control)n7open).Name = "n7open";
		PictureBox obj72 = n7open;
		size = new Size(25, 25);
		((Control)obj72).Size = size;
		n7open.SizeMode = (PictureBoxSizeMode)2;
		n7open.TabIndex = 169;
		n7open.TabStop = false;
		((Control)n7open).Visible = false;
		((Control)n6open).BackColor = Color.White;
		n6open.Image = (Image)componentResourceManager.GetObject("n6open.Image");
		PictureBox obj73 = n6open;
		location = new Point(855, 390);
		((Control)obj73).Location = location;
		((Control)n6open).Name = "n6open";
		PictureBox obj74 = n6open;
		size = new Size(25, 25);
		((Control)obj74).Size = size;
		n6open.SizeMode = (PictureBoxSizeMode)2;
		n6open.TabIndex = 168;
		n6open.TabStop = false;
		((Control)n6open).Visible = false;
		((Control)n8del).BackColor = Color.White;
		n8del.Image = (Image)componentResourceManager.GetObject("n8del.Image");
		PictureBox obj75 = n8del;
		location = new Point(903, 490);
		((Control)obj75).Location = location;
		((Control)n8del).Name = "n8del";
		PictureBox obj76 = n8del;
		size = new Size(25, 25);
		((Control)obj76).Size = size;
		n8del.SizeMode = (PictureBoxSizeMode)2;
		n8del.TabIndex = 179;
		n8del.TabStop = false;
		((Control)n8del).Visible = false;
		((Control)n7del).BackColor = Color.White;
		n7del.Image = (Image)componentResourceManager.GetObject("n7del.Image");
		PictureBox obj77 = n7del;
		location = new Point(903, 439);
		((Control)obj77).Location = location;
		((Control)n7del).Name = "n7del";
		PictureBox obj78 = n7del;
		size = new Size(25, 25);
		((Control)obj78).Size = size;
		n7del.SizeMode = (PictureBoxSizeMode)2;
		n7del.TabIndex = 178;
		n7del.TabStop = false;
		((Control)n7del).Visible = false;
		((Control)n6del).BackColor = Color.White;
		n6del.Image = (Image)componentResourceManager.GetObject("n6del.Image");
		PictureBox obj79 = n6del;
		location = new Point(903, 390);
		((Control)obj79).Location = location;
		((Control)n6del).Name = "n6del";
		PictureBox obj80 = n6del;
		size = new Size(25, 25);
		((Control)obj80).Size = size;
		n6del.SizeMode = (PictureBoxSizeMode)2;
		n6del.TabIndex = 177;
		n6del.TabStop = false;
		((Control)n6del).Visible = false;
		((Control)n5del).BackColor = Color.White;
		n5del.Image = (Image)componentResourceManager.GetObject("n5del.Image");
		PictureBox obj81 = n5del;
		location = new Point(903, 342);
		((Control)obj81).Location = location;
		((Control)n5del).Name = "n5del";
		PictureBox obj82 = n5del;
		size = new Size(25, 25);
		((Control)obj82).Size = size;
		n5del.SizeMode = (PictureBoxSizeMode)2;
		n5del.TabIndex = 176;
		n5del.TabStop = false;
		((Control)n5del).Visible = false;
		((Control)n4del).BackColor = Color.White;
		n4del.Image = (Image)componentResourceManager.GetObject("n4del.Image");
		PictureBox obj83 = n4del;
		location = new Point(903, 293);
		((Control)obj83).Location = location;
		((Control)n4del).Name = "n4del";
		PictureBox obj84 = n4del;
		size = new Size(25, 25);
		((Control)obj84).Size = size;
		n4del.SizeMode = (PictureBoxSizeMode)2;
		n4del.TabIndex = 175;
		n4del.TabStop = false;
		((Control)n4del).Visible = false;
		((Control)n3del).BackColor = Color.White;
		n3del.Image = (Image)componentResourceManager.GetObject("n3del.Image");
		PictureBox obj85 = n3del;
		location = new Point(903, 242);
		((Control)obj85).Location = location;
		((Control)n3del).Name = "n3del";
		PictureBox obj86 = n3del;
		size = new Size(25, 25);
		((Control)obj86).Size = size;
		n3del.SizeMode = (PictureBoxSizeMode)2;
		n3del.TabIndex = 174;
		n3del.TabStop = false;
		((Control)n3del).Visible = false;
		((Control)n2del).BackColor = Color.White;
		n2del.Image = (Image)componentResourceManager.GetObject("n2del.Image");
		PictureBox obj87 = n2del;
		location = new Point(903, 193);
		((Control)obj87).Location = location;
		((Control)n2del).Name = "n2del";
		PictureBox obj88 = n2del;
		size = new Size(25, 25);
		((Control)obj88).Size = size;
		n2del.SizeMode = (PictureBoxSizeMode)2;
		n2del.TabIndex = 173;
		n2del.TabStop = false;
		((Control)n2del).Visible = false;
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox9 = PictureBox4;
		location = new Point(886, 50);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox10 = PictureBox4;
		size = new Size(102, 34);
		((Control)pictureBox10).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 181;
		PictureBox4.TabStop = false;
		Label13.AutoSize = true;
		((Control)Label13).BackColor = Color.Transparent;
		((Control)Label13).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.DodgerBlue;
		Label label7 = Label13;
		location = new Point(900, 58);
		((Control)label7).Location = location;
		((Control)Label13).Name = "Label13";
		Label label8 = Label13;
		size = new Size(74, 18);
		((Control)label8).Size = size;
		((Control)Label13).TabIndex = 182;
		Label13.Text = "REFRESH";
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox11 = PictureBox5;
		location = new Point(778, 50);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox12 = PictureBox5;
		size = new Size(102, 34);
		((Control)pictureBox12).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 183;
		PictureBox5.TabStop = false;
		((Control)PictureBox5).Visible = false;
		((Control)PictureBox6).BackColor = Color.White;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox13 = PictureBox6;
		location = new Point(670, 50);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox14 = PictureBox6;
		size = new Size(102, 34);
		((Control)pictureBox14).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 184;
		PictureBox6.TabStop = false;
		((Control)PictureBox6).Visible = false;
		((Control)PictureBox8).BackColor = Color.White;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox15 = PictureBox8;
		location = new Point(562, 50);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox16 = PictureBox8;
		size = new Size(102, 34);
		((Control)pictureBox16).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)2;
		PictureBox8.TabIndex = 185;
		PictureBox8.TabStop = false;
		((Control)PictureBox8).Visible = false;
		refreshlabel.AutoSize = true;
		((Control)refreshlabel).BackColor = Color.Transparent;
		((Control)refreshlabel).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0);
		((Control)refreshlabel).ForeColor = Color.Gray;
		Label obj89 = refreshlabel;
		location = new Point(328, 86);
		((Control)obj89).Location = location;
		((Control)refreshlabel).Name = "refreshlabel";
		Label obj90 = refreshlabel;
		size = new Size(116, 22);
		((Control)obj90).Size = size;
		((Control)refreshlabel).TabIndex = 186;
		refreshlabel.Text = "Refreshing...";
		((Control)n9open).BackColor = Color.White;
		n9open.Image = (Image)componentResourceManager.GetObject("n9open.Image");
		PictureBox obj91 = n9open;
		location = new Point(855, 538);
		((Control)obj91).Location = location;
		((Control)n9open).Name = "n9open";
		PictureBox obj92 = n9open;
		size = new Size(25, 25);
		((Control)obj92).Size = size;
		n9open.SizeMode = (PictureBoxSizeMode)2;
		n9open.TabIndex = 187;
		n9open.TabStop = false;
		((Control)n9open).Visible = false;
		((Control)n9del).BackColor = Color.White;
		n9del.Image = (Image)componentResourceManager.GetObject("n9del.Image");
		PictureBox obj93 = n9del;
		location = new Point(903, 538);
		((Control)obj93).Location = location;
		((Control)n9del).Name = "n9del";
		PictureBox obj94 = n9del;
		size = new Size(25, 25);
		((Control)obj94).Size = size;
		n9del.SizeMode = (PictureBoxSizeMode)2;
		n9del.TabIndex = 188;
		n9del.TabStop = false;
		((Control)n9del).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1000, 650);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)n9del);
		((Control)this).Controls.Add((Control)(object)n9open);
		((Control)this).Controls.Add((Control)(object)refreshlabel);
		((Control)this).Controls.Add((Control)(object)PictureBox8);
		((Control)this).Controls.Add((Control)(object)PictureBox6);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)Label13);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)n8del);
		((Control)this).Controls.Add((Control)(object)n7del);
		((Control)this).Controls.Add((Control)(object)n6del);
		((Control)this).Controls.Add((Control)(object)n5del);
		((Control)this).Controls.Add((Control)(object)n4del);
		((Control)this).Controls.Add((Control)(object)n3del);
		((Control)this).Controls.Add((Control)(object)n2del);
		((Control)this).Controls.Add((Control)(object)n8open);
		((Control)this).Controls.Add((Control)(object)n7open);
		((Control)this).Controls.Add((Control)(object)n6open);
		((Control)this).Controls.Add((Control)(object)n5open);
		((Control)this).Controls.Add((Control)(object)n4open);
		((Control)this).Controls.Add((Control)(object)n3open);
		((Control)this).Controls.Add((Control)(object)n2open);
		((Control)this).Controls.Add((Control)(object)mainopen);
		((Control)this).Controls.Add((Control)(object)n9l);
		((Control)this).Controls.Add((Control)(object)n8l);
		((Control)this).Controls.Add((Control)(object)n7l);
		((Control)this).Controls.Add((Control)(object)n6l);
		((Control)this).Controls.Add((Control)(object)n5l);
		((Control)this).Controls.Add((Control)(object)n4l);
		((Control)this).Controls.Add((Control)(object)n3l);
		((Control)this).Controls.Add((Control)(object)n2l);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)n9p);
		((Control)this).Controls.Add((Control)(object)n8p);
		((Control)this).Controls.Add((Control)(object)n7p);
		((Control)this).Controls.Add((Control)(object)n6p);
		((Control)this).Controls.Add((Control)(object)n5p);
		((Control)this).Controls.Add((Control)(object)n4p);
		((Control)this).Controls.Add((Control)(object)n3p);
		((Control)this).Controls.Add((Control)(object)n2p);
		((Control)this).Controls.Add((Control)(object)mainp);
		((Control)this).Controls.Add((Control)(object)n9);
		((Control)this).Controls.Add((Control)(object)n8);
		((Control)this).Controls.Add((Control)(object)n7);
		((Control)this).Controls.Add((Control)(object)n6);
		((Control)this).Controls.Add((Control)(object)n5);
		((Control)this).Controls.Add((Control)(object)n4);
		((Control)this).Controls.Add((Control)(object)n3);
		((Control)this).Controls.Add((Control)(object)n2);
		((Control)this).Controls.Add((Control)(object)main);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "diskmanagement";
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)mainp).EndInit();
		((ISupportInitialize)n2p).EndInit();
		((ISupportInitialize)n4p).EndInit();
		((ISupportInitialize)n3p).EndInit();
		((ISupportInitialize)n8p).EndInit();
		((ISupportInitialize)n7p).EndInit();
		((ISupportInitialize)n6p).EndInit();
		((ISupportInitialize)n5p).EndInit();
		((ISupportInitialize)n9p).EndInit();
		((ISupportInitialize)mainopen).EndInit();
		((ISupportInitialize)n3open).EndInit();
		((ISupportInitialize)n2open).EndInit();
		((ISupportInitialize)n5open).EndInit();
		((ISupportInitialize)n4open).EndInit();
		((ISupportInitialize)n8open).EndInit();
		((ISupportInitialize)n7open).EndInit();
		((ISupportInitialize)n6open).EndInit();
		((ISupportInitialize)n8del).EndInit();
		((ISupportInitialize)n7del).EndInit();
		((ISupportInitialize)n6del).EndInit();
		((ISupportInitialize)n5del).EndInit();
		((ISupportInitialize)n4del).EndInit();
		((ISupportInitialize)n3del).EndInit();
		((ISupportInitialize)n2del).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)n9open).EndInit();
		((ISupportInitialize)n9del).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Label3_Click(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		main.Text = MyProject.Forms.datacontrolroom.main.Text;
		n2.Text = MyProject.Forms.datacontrolroom.n2.Text;
		n3.Text = MyProject.Forms.datacontrolroom.n3.Text;
		n4.Text = MyProject.Forms.datacontrolroom.n4.Text;
		n5.Text = MyProject.Forms.datacontrolroom.n5.Text;
		n6.Text = MyProject.Forms.datacontrolroom.n6.Text;
		n7.Text = MyProject.Forms.datacontrolroom.n7.Text;
		n8.Text = MyProject.Forms.datacontrolroom.n8.Text;
		n9.Text = MyProject.Forms.datacontrolroom.n9.Text;
		if (Operators.CompareString(n2.Text, "null", false) == 0)
		{
			((Control)n2).Visible = false;
			((Control)n2p).Visible = false;
			((Control)n2l).Visible = false;
			((Control)n2open).Visible = false;
			((Control)n2del).Visible = false;
		}
		else
		{
			((Control)n2).Visible = true;
			((Control)n2p).Visible = true;
			((Control)n2l).Visible = true;
			((Control)n2open).Visible = true;
			((Control)n2del).Visible = true;
		}
		if (Operators.CompareString(n3.Text, "null", false) == 0)
		{
			((Control)n3).Visible = false;
			((Control)n3p).Visible = false;
			((Control)n3l).Visible = false;
			((Control)n3open).Visible = false;
			((Control)n3del).Visible = false;
		}
		else
		{
			((Control)n3).Visible = true;
			((Control)n3p).Visible = true;
			((Control)n3l).Visible = true;
			((Control)n3open).Visible = true;
			((Control)n3del).Visible = true;
		}
		if (Operators.CompareString(n4.Text, "null", false) == 0)
		{
			((Control)n4).Visible = false;
			((Control)n4p).Visible = false;
			((Control)n4l).Visible = false;
			((Control)n4open).Visible = false;
			((Control)n4del).Visible = false;
		}
		else
		{
			((Control)n4).Visible = true;
			((Control)n4p).Visible = true;
			((Control)n4l).Visible = true;
			((Control)n4open).Visible = true;
			((Control)n4del).Visible = true;
		}
		if (Operators.CompareString(n5.Text, "null", false) == 0)
		{
			((Control)n5).Visible = false;
			((Control)n5p).Visible = false;
			((Control)n5l).Visible = false;
			((Control)n5open).Visible = false;
			((Control)n5del).Visible = false;
		}
		else
		{
			((Control)n5).Visible = true;
			((Control)n5p).Visible = true;
			((Control)n5l).Visible = true;
			((Control)n5open).Visible = true;
			((Control)n5del).Visible = true;
		}
		if (Operators.CompareString(n6.Text, "null", false) == 0)
		{
			((Control)n6).Visible = false;
			((Control)n6p).Visible = false;
			((Control)n6l).Visible = false;
			((Control)n6open).Visible = false;
			((Control)n6del).Visible = false;
		}
		else
		{
			((Control)n6).Visible = true;
			((Control)n6p).Visible = true;
			((Control)n6l).Visible = true;
			((Control)n6open).Visible = true;
			((Control)n6del).Visible = true;
		}
		if (Operators.CompareString(n7.Text, "null", false) == 0)
		{
			((Control)n7).Visible = false;
			((Control)n7p).Visible = false;
			((Control)n7l).Visible = false;
			((Control)n7open).Visible = false;
			((Control)n7del).Visible = false;
		}
		else
		{
			((Control)n7).Visible = true;
			((Control)n7p).Visible = true;
			((Control)n7l).Visible = true;
			((Control)n7open).Visible = true;
			((Control)n7del).Visible = true;
		}
		if (Operators.CompareString(n8.Text, "null", false) == 0)
		{
			((Control)n8).Visible = false;
			((Control)n8p).Visible = false;
			((Control)n8l).Visible = false;
			((Control)n8open).Visible = false;
			((Control)n8del).Visible = false;
		}
		else
		{
			((Control)n8).Visible = true;
			((Control)n8p).Visible = true;
			((Control)n8l).Visible = true;
			((Control)n8open).Visible = true;
			((Control)n8del).Visible = true;
		}
		if (Operators.CompareString(n9.Text, "null", false) == 0)
		{
			((Control)n9).Visible = false;
			((Control)n9p).Visible = false;
			((Control)n9l).Visible = false;
			((Control)n9open).Visible = false;
			((Control)n9del).Visible = false;
		}
		else
		{
			((Control)n9).Visible = true;
			((Control)n9p).Visible = true;
			((Control)n9l).Visible = true;
			((Control)n9open).Visible = true;
			((Control)n9del).Visible = true;
		}
		((Control)refreshlabel).Visible = false;
		Timer1.Enabled = false;
	}

	private void diskmanagement_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.diskmanagementout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.disk.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void diskmanagement_Load(object sender, EventArgs e)
	{
		if (!((Control)MyProject.Forms.home.app1).Enabled)
		{
			((Control)MyProject.Forms.home.app1).Enabled = true;
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app2).Enabled)
		{
			((Control)MyProject.Forms.home.app2).Enabled = true;
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app3).Enabled)
		{
			((Control)MyProject.Forms.home.app3).Enabled = true;
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app4).Enabled)
		{
			((Control)MyProject.Forms.home.app4).Enabled = true;
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app5).Enabled)
		{
			((Control)MyProject.Forms.home.app5).Enabled = true;
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app6).Enabled)
		{
			((Control)MyProject.Forms.home.app6).Enabled = true;
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app7).Enabled)
		{
			((Control)MyProject.Forms.home.app7).Enabled = true;
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app8).Enabled)
		{
			((Control)MyProject.Forms.home.app8).Enabled = true;
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app9).Enabled)
		{
			((Control)MyProject.Forms.home.app9).Enabled = true;
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app10).Enabled)
		{
			((Control)MyProject.Forms.home.app10).Enabled = true;
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app11).Enabled)
		{
			((Control)MyProject.Forms.home.app11).Enabled = true;
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app12).Enabled)
		{
			((Control)MyProject.Forms.home.app12).Enabled = true;
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app13).Enabled)
		{
			((Control)MyProject.Forms.home.app13).Enabled = true;
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app14).Enabled)
		{
			((Control)MyProject.Forms.home.app14).Enabled = true;
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app15).Enabled)
		{
			((Control)MyProject.Forms.home.app15).Enabled = true;
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app16).Enabled)
		{
			((Control)MyProject.Forms.home.app16).Enabled = true;
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app17).Enabled)
		{
			((Control)MyProject.Forms.home.app17).Enabled = true;
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app18).Enabled)
		{
			((Control)MyProject.Forms.home.app18).Enabled = true;
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app19).Enabled)
		{
			((Control)MyProject.Forms.home.app19).Enabled = true;
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app20).Enabled)
		{
			((Control)MyProject.Forms.home.app20).Enabled = true;
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app21).Enabled)
		{
			((Control)MyProject.Forms.home.app21).Enabled = true;
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app22).Enabled)
		{
			((Control)MyProject.Forms.home.app22).Enabled = true;
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app23).Enabled)
		{
			((Control)MyProject.Forms.home.app23).Enabled = true;
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app24).Enabled)
		{
			((Control)MyProject.Forms.home.app24).Enabled = true;
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.disk.Image;
		}
		else if (!((Control)MyProject.Forms.home.app25).Enabled)
		{
			((Control)MyProject.Forms.home.app25).Enabled = true;
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.disk.Image;
		}
		Fade.diskmanagementin();
		((Control)MyProject.Forms.datacontrolroom).Show();
		((Control)refreshlabel).Visible = true;
		Timer1.Enabled = true;
	}

	private void Label13_Click(object sender, EventArgs e)
	{
		((Control)refreshlabel).Visible = true;
		MyProject.Forms.datacontrolroom.Timer1.Enabled = true;
		Timer1.Enabled = true;
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		((Control)refreshlabel).Visible = true;
		MyProject.Forms.datacontrolroom.Timer1.Enabled = true;
		Timer1.Enabled = true;
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)Control.MouseButtons == 1048576)
		{
			PictureBox3.Image = clickclose.Image;
		}
	}

	private void diskmanagement_MouseLeave(object sender, EventArgs e)
	{
		PictureBox3.Image = defaultclose.Image;
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

	private void mainopen_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = main.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n2open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n2.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n3open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n3.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n4open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n4.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n5open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n5.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n6open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n6.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n7open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n7.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n8open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n8.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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

	private void n9open_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						((Control)MyProject.Forms.files).Show();
						goto IL_0014;
					case 623:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0014;
							case 3:
								goto IL_0041;
							case 4:
								goto IL_005e;
							case 5:
								goto IL_0067;
							case 6:
								goto IL_0088;
							case 7:
								goto IL_00a0;
							case 8:
								goto IL_00c7;
							case 9:
								goto IL_0112;
							case 10:
								goto IL_0138;
							case 11:
								goto IL_0160;
							case 12:
								goto IL_01ac;
							case 14:
								goto IL_01d4;
							case 15:
								goto IL_01d9;
							case 16:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 13:
							case 17:
							case 18:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_01d9:
						num = 15;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_01d4:
						num = 14;
						goto IL_01d9;
						IL_0112:
						num = 9;
						goto IL_0117;
						IL_0160:
						num = 11;
						MyProject.Forms.files.ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 1);
						goto IL_01ac;
						IL_0014:
						num = 2;
						MyProject.Forms.files.TextBox1.Text = n9.Text + "\\\\";
						goto IL_0041;
						IL_0041:
						num = 3;
						path = MyProject.Forms.files.TextBox1.Text;
						goto IL_005e;
						IL_005e:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0067;
						IL_0067:
						num = 5;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_0088;
						}
						goto IL_01d4;
						IL_0088:
						num = 6;
						MyProject.Forms.files.ListView1.Clear();
						goto IL_00a0;
						IL_00a0:
						num = 7;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0117;
						IL_0117:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_00c7;
						}
						enumerator?.Dispose();
						goto IL_0138;
						IL_01ac:
						num = 12;
						goto IL_01b1;
						IL_00c7:
						num = 8;
						MyProject.Forms.files.ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), MyProject.Forms.files.ImageList1.Images.Count - 2);
						goto IL_0112;
						IL_0138:
						num = 10;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_01b1;
						IL_01b1:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_0160;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 623;
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
}
