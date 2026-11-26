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
public class paintain : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("PictureBox11")]
	private PictureBox _PictureBox11;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("PictureBox29")]
	private PictureBox _PictureBox29;

	[AccessedThroughProperty("PictureBox30")]
	private PictureBox _PictureBox30;

	[AccessedThroughProperty("PictureBox31")]
	private PictureBox _PictureBox31;

	[AccessedThroughProperty("PictureBox32")]
	private PictureBox _PictureBox32;

	[AccessedThroughProperty("PictureBox33")]
	private PictureBox _PictureBox33;

	[AccessedThroughProperty("PictureBox34")]
	private PictureBox _PictureBox34;

	[AccessedThroughProperty("PictureBox35")]
	private PictureBox _PictureBox35;

	[AccessedThroughProperty("PictureBox36")]
	private PictureBox _PictureBox36;

	[AccessedThroughProperty("PictureBox37")]
	private PictureBox _PictureBox37;

	[AccessedThroughProperty("PictureBox38")]
	private PictureBox _PictureBox38;

	[AccessedThroughProperty("PictureBox39")]
	private PictureBox _PictureBox39;

	[AccessedThroughProperty("PictureBox40")]
	private PictureBox _PictureBox40;

	[AccessedThroughProperty("PictureBox41")]
	private PictureBox _PictureBox41;

	[AccessedThroughProperty("PictureBox42")]
	private PictureBox _PictureBox42;

	[AccessedThroughProperty("PictureBox43")]
	private PictureBox _PictureBox43;

	[AccessedThroughProperty("PictureBox26")]
	private PictureBox _PictureBox26;

	[AccessedThroughProperty("PictureBox27")]
	private PictureBox _PictureBox27;

	[AccessedThroughProperty("PictureBox28")]
	private PictureBox _PictureBox28;

	[AccessedThroughProperty("PictureBox23")]
	private PictureBox _PictureBox23;

	[AccessedThroughProperty("PictureBox24")]
	private PictureBox _PictureBox24;

	[AccessedThroughProperty("PictureBox25")]
	private PictureBox _PictureBox25;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("PictureBox21")]
	private PictureBox _PictureBox21;

	[AccessedThroughProperty("PictureBox22")]
	private PictureBox _PictureBox22;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("PictureBox18")]
	private PictureBox _PictureBox18;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("PictureBox16")]
	private PictureBox _PictureBox16;

	[AccessedThroughProperty("PictureBox15")]
	private PictureBox _PictureBox15;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	[AccessedThroughProperty("PictureBox44")]
	private PictureBox _PictureBox44;

	[AccessedThroughProperty("PictureBox45")]
	private PictureBox _PictureBox45;

	[AccessedThroughProperty("PictureBox46")]
	private PictureBox _PictureBox46;

	[AccessedThroughProperty("PictureBox47")]
	private PictureBox _PictureBox47;

	[AccessedThroughProperty("PictureBox48")]
	private PictureBox _PictureBox48;

	[AccessedThroughProperty("PictureBox49")]
	private PictureBox _PictureBox49;

	[AccessedThroughProperty("PictureBox50")]
	private PictureBox _PictureBox50;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox51")]
	private PictureBox _PictureBox51;

	private Point mouse_move;

	private Graphics G;

	private bool drawFlag;

	private int xDown;

	private int yDown;

	private int xUp;

	private int yUp;

	private int intL;

	private int intR;

	private int intT;

	private int intB;

	private int intW;

	private int intH;

	private Color clrSelected;

	private int intBrushSize;

	private int intPenWidth;

	private Bitmap bmpPic;

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
			_PictureBox13 = value;
		}
	}

	internal virtual PictureBox PictureBox11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox11 = value;
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
			EventHandler eventHandler = PictureBox12_Click;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).Click -= eventHandler;
			}
			_PictureBox12 = value;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox9 = value;
		}
	}

	internal virtual PictureBox PictureBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox10 = value;
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

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel2 = value;
		}
	}

	internal virtual PictureBox PictureBox29
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox29 = value;
		}
	}

	internal virtual PictureBox PictureBox30
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox30 = value;
		}
	}

	internal virtual PictureBox PictureBox31
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox31 = value;
		}
	}

	internal virtual PictureBox PictureBox32
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox32 = value;
		}
	}

	internal virtual PictureBox PictureBox33
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox33 = value;
		}
	}

	internal virtual PictureBox PictureBox34
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox34 = value;
		}
	}

	internal virtual PictureBox PictureBox35
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox35 = value;
		}
	}

	internal virtual PictureBox PictureBox36
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox36 = value;
		}
	}

	internal virtual PictureBox PictureBox37
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox37 = value;
		}
	}

	internal virtual PictureBox PictureBox38
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox38 = value;
		}
	}

	internal virtual PictureBox PictureBox39
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox39 = value;
		}
	}

	internal virtual PictureBox PictureBox40
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox40 = value;
		}
	}

	internal virtual PictureBox PictureBox41
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox41 = value;
		}
	}

	internal virtual PictureBox PictureBox42
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox42 = value;
		}
	}

	internal virtual PictureBox PictureBox43
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox43 = value;
		}
	}

	internal virtual PictureBox PictureBox26
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox26 = value;
		}
	}

	internal virtual PictureBox PictureBox27
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox27 = value;
		}
	}

	internal virtual PictureBox PictureBox28
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox28 = value;
		}
	}

	internal virtual PictureBox PictureBox23
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox23 = value;
		}
	}

	internal virtual PictureBox PictureBox24
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox24 = value;
		}
	}

	internal virtual PictureBox PictureBox25
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox25 = value;
		}
	}

	internal virtual PictureBox PictureBox20
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox20 = value;
		}
	}

	internal virtual PictureBox PictureBox21
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox21 = value;
		}
	}

	internal virtual PictureBox PictureBox22
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox22 = value;
		}
	}

	internal virtual PictureBox PictureBox17
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox17 = value;
		}
	}

	internal virtual PictureBox PictureBox18
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox18 = value;
		}
	}

	internal virtual PictureBox PictureBox19
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox19 = value;
		}
	}

	internal virtual PictureBox PictureBox16
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox16 = value;
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
			_PictureBox15 = value;
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
			_PictureBox14 = value;
		}
	}

	internal virtual PictureBox PictureBox44
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox44 = value;
		}
	}

	internal virtual PictureBox PictureBox45
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox45 = value;
		}
	}

	internal virtual PictureBox PictureBox46
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox46 = value;
		}
	}

	internal virtual PictureBox PictureBox47
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox47 = value;
		}
	}

	internal virtual PictureBox PictureBox48
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox48 = value;
		}
	}

	internal virtual PictureBox PictureBox49
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox49 = value;
		}
	}

	internal virtual PictureBox PictureBox50
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox50 = value;
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
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
			_Label5 = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
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
			_Label4 = value;
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

	internal virtual PictureBox PictureBox51
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox51 = value;
		}
	}

	public paintain()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(paintain_FormClosing);
		((Form)this).Load += paintain_Load;
		__ENCAddToList(this);
		drawFlag = false;
		clrSelected = Color.Black;
		intBrushSize = 6;
		intPenWidth = 2;
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
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_0697: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a1: Expected O, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		//IL_0c75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7f: Expected O, but got Unknown
		//IL_0d28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d32: Expected O, but got Unknown
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de5: Expected O, but got Unknown
		//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e98: Expected O, but got Unknown
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f48: Expected O, but got Unknown
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected O, but got Unknown
		//IL_108f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1099: Expected O, but got Unknown
		//IL_1128: Unknown result type (might be due to invalid IL or missing references)
		//IL_1132: Expected O, but got Unknown
		//IL_11c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cb: Expected O, but got Unknown
		//IL_125a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1264: Expected O, but got Unknown
		//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1300: Expected O, but got Unknown
		//IL_1392: Unknown result type (might be due to invalid IL or missing references)
		//IL_139c: Expected O, but got Unknown
		//IL_142e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1438: Expected O, but got Unknown
		//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d4: Expected O, but got Unknown
		//IL_1566: Unknown result type (might be due to invalid IL or missing references)
		//IL_1570: Expected O, but got Unknown
		//IL_1a4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a57: Expected O, but got Unknown
		//IL_1ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af3: Expected O, but got Unknown
		//IL_1b85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8f: Expected O, but got Unknown
		//IL_1c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c2b: Expected O, but got Unknown
		//IL_1cbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc7: Expected O, but got Unknown
		//IL_1d59: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d63: Expected O, but got Unknown
		//IL_1df5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dff: Expected O, but got Unknown
		//IL_1ef5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eff: Expected O, but got Unknown
		//IL_1f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9b: Expected O, but got Unknown
		//IL_202d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2037: Expected O, but got Unknown
		//IL_20c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d3: Expected O, but got Unknown
		//IL_2165: Unknown result type (might be due to invalid IL or missing references)
		//IL_216f: Expected O, but got Unknown
		//IL_2201: Unknown result type (might be due to invalid IL or missing references)
		//IL_220b: Expected O, but got Unknown
		//IL_229d: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a7: Expected O, but got Unknown
		//IL_2339: Unknown result type (might be due to invalid IL or missing references)
		//IL_2343: Expected O, but got Unknown
		//IL_23d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23df: Expected O, but got Unknown
		//IL_2471: Unknown result type (might be due to invalid IL or missing references)
		//IL_247b: Expected O, but got Unknown
		//IL_250d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2517: Expected O, but got Unknown
		//IL_25a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b3: Expected O, but got Unknown
		//IL_2642: Unknown result type (might be due to invalid IL or missing references)
		//IL_264c: Expected O, but got Unknown
		//IL_26db: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e5: Expected O, but got Unknown
		//IL_2774: Unknown result type (might be due to invalid IL or missing references)
		//IL_277e: Expected O, but got Unknown
		//IL_280d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2817: Expected O, but got Unknown
		//IL_28a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28b3: Expected O, but got Unknown
		//IL_2945: Unknown result type (might be due to invalid IL or missing references)
		//IL_294f: Expected O, but got Unknown
		//IL_29e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_29eb: Expected O, but got Unknown
		//IL_2a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a87: Expected O, but got Unknown
		//IL_2b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b23: Expected O, but got Unknown
		//IL_2bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bbf: Expected O, but got Unknown
		//IL_2c51: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c5b: Expected O, but got Unknown
		//IL_2ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cf7: Expected O, but got Unknown
		//IL_2d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d93: Expected O, but got Unknown
		//IL_2e25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2f: Expected O, but got Unknown
		//IL_2ec1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ecb: Expected O, but got Unknown
		//IL_2f5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f64: Expected O, but got Unknown
		//IL_2ff3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ffd: Expected O, but got Unknown
		//IL_308c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3096: Expected O, but got Unknown
		//IL_3125: Unknown result type (might be due to invalid IL or missing references)
		//IL_312f: Expected O, but got Unknown
		//IL_31cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d7: Expected O, but got Unknown
		//IL_3275: Unknown result type (might be due to invalid IL or missing references)
		//IL_327f: Expected O, but got Unknown
		//IL_330c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3316: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(paintain));
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Panel1 = new Panel();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		PictureBox13 = new PictureBox();
		PictureBox11 = new PictureBox();
		PictureBox12 = new PictureBox();
		PictureBox9 = new PictureBox();
		PictureBox10 = new PictureBox();
		PictureBox8 = new PictureBox();
		PictureBox7 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		Panel2 = new Panel();
		PictureBox44 = new PictureBox();
		PictureBox45 = new PictureBox();
		PictureBox46 = new PictureBox();
		PictureBox47 = new PictureBox();
		PictureBox48 = new PictureBox();
		PictureBox49 = new PictureBox();
		PictureBox50 = new PictureBox();
		Panel3 = new Panel();
		PictureBox29 = new PictureBox();
		PictureBox30 = new PictureBox();
		PictureBox31 = new PictureBox();
		PictureBox32 = new PictureBox();
		PictureBox33 = new PictureBox();
		PictureBox34 = new PictureBox();
		PictureBox35 = new PictureBox();
		PictureBox36 = new PictureBox();
		PictureBox37 = new PictureBox();
		PictureBox38 = new PictureBox();
		PictureBox39 = new PictureBox();
		PictureBox40 = new PictureBox();
		PictureBox41 = new PictureBox();
		PictureBox42 = new PictureBox();
		PictureBox43 = new PictureBox();
		PictureBox26 = new PictureBox();
		PictureBox27 = new PictureBox();
		PictureBox28 = new PictureBox();
		PictureBox23 = new PictureBox();
		PictureBox24 = new PictureBox();
		PictureBox25 = new PictureBox();
		PictureBox20 = new PictureBox();
		PictureBox21 = new PictureBox();
		PictureBox22 = new PictureBox();
		PictureBox17 = new PictureBox();
		PictureBox18 = new PictureBox();
		PictureBox19 = new PictureBox();
		PictureBox16 = new PictureBox();
		PictureBox15 = new PictureBox();
		PictureBox14 = new PictureBox();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox51 = new PictureBox();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox13).BeginInit();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox44).BeginInit();
		((ISupportInitialize)PictureBox45).BeginInit();
		((ISupportInitialize)PictureBox46).BeginInit();
		((ISupportInitialize)PictureBox47).BeginInit();
		((ISupportInitialize)PictureBox48).BeginInit();
		((ISupportInitialize)PictureBox49).BeginInit();
		((ISupportInitialize)PictureBox50).BeginInit();
		((ISupportInitialize)PictureBox29).BeginInit();
		((ISupportInitialize)PictureBox30).BeginInit();
		((ISupportInitialize)PictureBox31).BeginInit();
		((ISupportInitialize)PictureBox32).BeginInit();
		((ISupportInitialize)PictureBox33).BeginInit();
		((ISupportInitialize)PictureBox34).BeginInit();
		((ISupportInitialize)PictureBox35).BeginInit();
		((ISupportInitialize)PictureBox36).BeginInit();
		((ISupportInitialize)PictureBox37).BeginInit();
		((ISupportInitialize)PictureBox38).BeginInit();
		((ISupportInitialize)PictureBox39).BeginInit();
		((ISupportInitialize)PictureBox40).BeginInit();
		((ISupportInitialize)PictureBox41).BeginInit();
		((ISupportInitialize)PictureBox42).BeginInit();
		((ISupportInitialize)PictureBox43).BeginInit();
		((ISupportInitialize)PictureBox26).BeginInit();
		((ISupportInitialize)PictureBox27).BeginInit();
		((ISupportInitialize)PictureBox28).BeginInit();
		((ISupportInitialize)PictureBox23).BeginInit();
		((ISupportInitialize)PictureBox24).BeginInit();
		((ISupportInitialize)PictureBox25).BeginInit();
		((ISupportInitialize)PictureBox20).BeginInit();
		((ISupportInitialize)PictureBox21).BeginInit();
		((ISupportInitialize)PictureBox22).BeginInit();
		((ISupportInitialize)PictureBox17).BeginInit();
		((ISupportInitialize)PictureBox18).BeginInit();
		((ISupportInitialize)PictureBox19).BeginInit();
		((ISupportInitialize)PictureBox16).BeginInit();
		((ISupportInitialize)PictureBox15).BeginInit();
		((ISupportInitialize)PictureBox14).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox51).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		Point location = new Point(1310, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		Size size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 16;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(38, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(65, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 15;
		Label1.Text = "Paintain";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(10, 6);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(22, 22);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 14;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox5 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox6 = PictureBox1;
		size = new Size(1400, 35);
		((Control)pictureBox6).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 13;
		PictureBox1.TabStop = false;
		((Control)Panel1).BackColor = Color.DodgerBlue;
		((Control)Panel1).Controls.Add((Control)(object)Label8);
		((Control)Panel1).Controls.Add((Control)(object)Label9);
		((Control)Panel1).Controls.Add((Control)(object)Label10);
		((Control)Panel1).Controls.Add((Control)(object)Label5);
		((Control)Panel1).Controls.Add((Control)(object)Label6);
		((Control)Panel1).Controls.Add((Control)(object)Label7);
		((Control)Panel1).Controls.Add((Control)(object)Label4);
		((Control)Panel1).Controls.Add((Control)(object)Label3);
		((Control)Panel1).Controls.Add((Control)(object)Label2);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox13);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox11);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox12);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox9);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox10);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox7);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox5);
		Panel panel = Panel1;
		location = new Point(0, 34);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(163, 689);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 17;
		Label8.AutoSize = true;
		((Control)Label8).BackColor = Color.Transparent;
		((Control)Label8).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label3 = Label8;
		location = new Point(43, 383);
		((Control)label3).Location = location;
		((Control)Label8).Name = "Label8";
		Label label4 = Label8;
		size = new Size(113, 19);
		((Control)label4).Size = size;
		((Control)Label8).TabIndex = 35;
		Label8.Text = "Filled Square";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.White;
		Label label5 = Label9;
		location = new Point(43, 352);
		((Control)label5).Location = location;
		((Control)Label9).Name = "Label9";
		Label label6 = Label9;
		size = new Size(64, 19);
		((Control)label6).Size = size;
		((Control)Label9).TabIndex = 34;
		Label9.Text = "Square";
		Label10.AutoSize = true;
		((Control)Label10).BackColor = Color.Transparent;
		((Control)Label10).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.White;
		Label label7 = Label10;
		location = new Point(43, 320);
		((Control)label7).Location = location;
		((Control)Label10).Name = "Label10";
		Label label8 = Label10;
		size = new Size(105, 19);
		((Control)label8).Size = size;
		((Control)Label10).TabIndex = 33;
		Label10.Text = "Filled Circle";
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.Transparent;
		((Control)Label5).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label9 = Label5;
		location = new Point(43, 290);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(56, 19);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 32;
		Label5.Text = "Circle";
		Label6.AutoSize = true;
		((Control)Label6).BackColor = Color.Transparent;
		((Control)Label6).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label11 = Label6;
		location = new Point(43, 259);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(54, 19);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 31;
		Label6.Text = "Brush";
		Label7.AutoSize = true;
		((Control)Label7).BackColor = Color.Transparent;
		((Control)Label7).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.White;
		Label label13 = Label7;
		location = new Point(43, 227);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(55, 19);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 30;
		Label7.Text = "Pencil";
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.Transparent;
		((Control)Label4).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label15 = Label4;
		location = new Point(43, 80);
		((Control)label15).Location = location;
		((Control)Label4).Name = "Label4";
		Label label16 = Label4;
		size = new Size(45, 19);
		((Control)label16).Size = size;
		((Control)Label4).TabIndex = 29;
		Label4.Text = "Save";
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label17 = Label3;
		location = new Point(43, 49);
		((Control)label17).Location = location;
		((Control)Label3).Name = "Label3";
		Label label18 = Label3;
		size = new Size(53, 19);
		((Control)label18).Size = size;
		((Control)Label3).TabIndex = 28;
		Label3.Text = "Open";
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label19 = Label2;
		location = new Point(43, 17);
		((Control)label19).Location = location;
		((Control)Label2).Name = "Label2";
		Label label20 = Label2;
		size = new Size(43, 19);
		((Control)label20).Size = size;
		((Control)Label2).TabIndex = 20;
		Label2.Text = "New";
		((Control)PictureBox13).BackColor = Color.Transparent;
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox7 = PictureBox13;
		location = new Point(11, 46);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox8 = PictureBox13;
		size = new Size(26, 26);
		((Control)pictureBox8).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)2;
		PictureBox13.TabIndex = 27;
		PictureBox13.TabStop = false;
		((Control)PictureBox11).BackColor = Color.Transparent;
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox pictureBox9 = PictureBox11;
		location = new Point(12, 78);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox pictureBox10 = PictureBox11;
		size = new Size(25, 25);
		((Control)pictureBox10).Size = size;
		PictureBox11.SizeMode = (PictureBoxSizeMode)2;
		PictureBox11.TabIndex = 26;
		PictureBox11.TabStop = false;
		((Control)PictureBox12).BackColor = Color.Transparent;
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox11 = PictureBox12;
		location = new Point(12, 15);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox12 = PictureBox12;
		size = new Size(25, 25);
		((Control)pictureBox12).Size = size;
		PictureBox12.SizeMode = (PictureBoxSizeMode)2;
		PictureBox12.TabIndex = 25;
		PictureBox12.TabStop = false;
		((Control)PictureBox9).BackColor = Color.Transparent;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox13 = PictureBox9;
		location = new Point(12, 380);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox14 = PictureBox9;
		size = new Size(25, 25);
		((Control)pictureBox14).Size = size;
		PictureBox9.SizeMode = (PictureBoxSizeMode)2;
		PictureBox9.TabIndex = 24;
		PictureBox9.TabStop = false;
		((Control)PictureBox10).BackColor = Color.Transparent;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox15 = PictureBox10;
		location = new Point(12, 349);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox16 = PictureBox10;
		size = new Size(25, 25);
		((Control)pictureBox16).Size = size;
		PictureBox10.SizeMode = (PictureBoxSizeMode)2;
		PictureBox10.TabIndex = 23;
		PictureBox10.TabStop = false;
		((Control)PictureBox8).BackColor = Color.Transparent;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox17 = PictureBox8;
		location = new Point(12, 318);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox18 = PictureBox8;
		size = new Size(25, 25);
		((Control)pictureBox18).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)2;
		PictureBox8.TabIndex = 22;
		PictureBox8.TabStop = false;
		((Control)PictureBox7).BackColor = Color.Transparent;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox19 = PictureBox7;
		location = new Point(12, 287);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox20 = PictureBox7;
		size = new Size(25, 25);
		((Control)pictureBox20).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 21;
		PictureBox7.TabStop = false;
		((Control)PictureBox6).BackColor = Color.Transparent;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox21 = PictureBox6;
		location = new Point(12, 256);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox22 = PictureBox6;
		size = new Size(25, 25);
		((Control)pictureBox22).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 20;
		PictureBox6.TabStop = false;
		((Control)PictureBox5).BackColor = Color.Transparent;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox23 = PictureBox5;
		location = new Point(12, 225);
		((Control)pictureBox23).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox24 = PictureBox5;
		size = new Size(25, 25);
		((Control)pictureBox24).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 19;
		PictureBox5.TabStop = false;
		PictureBox pictureBox25 = PictureBox4;
		location = new Point(162, 34);
		((Control)pictureBox25).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox26 = PictureBox4;
		size = new Size(1198, 604);
		((Control)pictureBox26).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)1;
		PictureBox4.TabIndex = 18;
		PictureBox4.TabStop = false;
		((Control)Panel2).BackColor = Color.DodgerBlue;
		((Control)Panel2).Controls.Add((Control)(object)PictureBox44);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox45);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox46);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox47);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox48);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox49);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox50);
		((Control)Panel2).Controls.Add((Control)(object)Panel3);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox29);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox30);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox31);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox32);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox33);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox34);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox35);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox36);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox37);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox38);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox39);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox40);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox41);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox42);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox43);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox26);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox27);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox28);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox23);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox24);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox25);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox20);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox21);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox22);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox17);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox18);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox19);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox16);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox15);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox14);
		Panel panel3 = Panel2;
		location = new Point(162, 636);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(1199, 87);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 19;
		((Control)PictureBox44).BackColor = Color.Transparent;
		PictureBox44.Image = (Image)componentResourceManager.GetObject("PictureBox44.Image");
		PictureBox pictureBox27 = PictureBox44;
		location = new Point(744, 29);
		((Control)pictureBox27).Location = location;
		((Control)PictureBox44).Name = "PictureBox44";
		PictureBox pictureBox28 = PictureBox44;
		size = new Size(35, 35);
		((Control)pictureBox28).Size = size;
		PictureBox44.SizeMode = (PictureBoxSizeMode)2;
		PictureBox44.TabIndex = 65;
		PictureBox44.TabStop = false;
		((Control)PictureBox45).BackColor = Color.Transparent;
		PictureBox45.Image = (Image)componentResourceManager.GetObject("PictureBox45.Image");
		PictureBox pictureBox29 = PictureBox45;
		location = new Point(676, 35);
		((Control)pictureBox29).Location = location;
		((Control)PictureBox45).Name = "PictureBox45";
		PictureBox pictureBox30 = PictureBox45;
		size = new Size(25, 25);
		((Control)pictureBox30).Size = size;
		PictureBox45.SizeMode = (PictureBoxSizeMode)2;
		PictureBox45.TabIndex = 64;
		PictureBox45.TabStop = false;
		((Control)PictureBox46).BackColor = Color.Transparent;
		PictureBox46.Image = (Image)componentResourceManager.GetObject("PictureBox46.Image");
		PictureBox pictureBox31 = PictureBox46;
		location = new Point(707, 32);
		((Control)pictureBox31).Location = location;
		((Control)PictureBox46).Name = "PictureBox46";
		PictureBox pictureBox32 = PictureBox46;
		size = new Size(30, 30);
		((Control)pictureBox32).Size = size;
		PictureBox46.SizeMode = (PictureBoxSizeMode)2;
		PictureBox46.TabIndex = 63;
		PictureBox46.TabStop = false;
		((Control)PictureBox47).BackColor = Color.Transparent;
		PictureBox47.Image = (Image)componentResourceManager.GetObject("PictureBox47.Image");
		PictureBox pictureBox33 = PictureBox47;
		location = new Point(650, 38);
		((Control)pictureBox33).Location = location;
		((Control)PictureBox47).Name = "PictureBox47";
		PictureBox pictureBox34 = PictureBox47;
		size = new Size(20, 20);
		((Control)pictureBox34).Size = size;
		PictureBox47.SizeMode = (PictureBoxSizeMode)2;
		PictureBox47.TabIndex = 62;
		PictureBox47.TabStop = false;
		((Control)PictureBox48).BackColor = Color.Transparent;
		PictureBox48.Image = (Image)componentResourceManager.GetObject("PictureBox48.Image");
		PictureBox pictureBox35 = PictureBox48;
		location = new Point(609, 44);
		((Control)pictureBox35).Location = location;
		((Control)PictureBox48).Name = "PictureBox48";
		PictureBox pictureBox36 = PictureBox48;
		size = new Size(10, 10);
		((Control)pictureBox36).Size = size;
		PictureBox48.SizeMode = (PictureBoxSizeMode)2;
		PictureBox48.TabIndex = 61;
		PictureBox48.TabStop = false;
		((Control)PictureBox49).BackColor = Color.Transparent;
		PictureBox49.Image = (Image)componentResourceManager.GetObject("PictureBox49.Image");
		PictureBox pictureBox37 = PictureBox49;
		location = new Point(628, 41);
		((Control)pictureBox37).Location = location;
		((Control)PictureBox49).Name = "PictureBox49";
		PictureBox pictureBox38 = PictureBox49;
		size = new Size(15, 15);
		((Control)pictureBox38).Size = size;
		PictureBox49.SizeMode = (PictureBoxSizeMode)2;
		PictureBox49.TabIndex = 60;
		PictureBox49.TabStop = false;
		((Control)PictureBox50).BackColor = Color.Transparent;
		PictureBox50.Image = (Image)componentResourceManager.GetObject("PictureBox50.Image");
		PictureBox pictureBox39 = PictureBox50;
		location = new Point(594, 47);
		((Control)pictureBox39).Location = location;
		((Control)PictureBox50).Name = "PictureBox50";
		PictureBox pictureBox40 = PictureBox50;
		size = new Size(5, 5);
		((Control)pictureBox40).Size = size;
		PictureBox50.SizeMode = (PictureBoxSizeMode)2;
		PictureBox50.TabIndex = 59;
		PictureBox50.TabStop = false;
		((Control)Panel3).BackColor = Color.Transparent;
		Panel panel5 = Panel3;
		location = new Point(490, 23);
		((Control)panel5).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel6 = Panel3;
		size = new Size(52, 52);
		((Control)panel6).Size = size;
		((Control)Panel3).TabIndex = 58;
		((Control)PictureBox29).BackColor = Color.Transparent;
		PictureBox29.Image = (Image)componentResourceManager.GetObject("PictureBox29.Image");
		PictureBox pictureBox41 = PictureBox29;
		location = new Point(423, 54);
		((Control)pictureBox41).Location = location;
		((Control)PictureBox29).Name = "PictureBox29";
		PictureBox pictureBox42 = PictureBox29;
		size = new Size(20, 20);
		((Control)pictureBox42).Size = size;
		PictureBox29.SizeMode = (PictureBoxSizeMode)2;
		PictureBox29.TabIndex = 57;
		PictureBox29.TabStop = false;
		((Control)PictureBox30).BackColor = Color.Transparent;
		PictureBox30.Image = (Image)componentResourceManager.GetObject("PictureBox30.Image");
		PictureBox pictureBox43 = PictureBox30;
		location = new Point(454, 54);
		((Control)pictureBox43).Location = location;
		((Control)PictureBox30).Name = "PictureBox30";
		PictureBox pictureBox44 = PictureBox30;
		size = new Size(20, 20);
		((Control)pictureBox44).Size = size;
		PictureBox30.SizeMode = (PictureBoxSizeMode)2;
		PictureBox30.TabIndex = 56;
		PictureBox30.TabStop = false;
		((Control)PictureBox31).BackColor = Color.Transparent;
		PictureBox31.Image = (Image)componentResourceManager.GetObject("PictureBox31.Image");
		PictureBox pictureBox45 = PictureBox31;
		location = new Point(454, 23);
		((Control)pictureBox45).Location = location;
		((Control)PictureBox31).Name = "PictureBox31";
		PictureBox pictureBox46 = PictureBox31;
		size = new Size(20, 20);
		((Control)pictureBox46).Size = size;
		PictureBox31.SizeMode = (PictureBoxSizeMode)2;
		PictureBox31.TabIndex = 55;
		PictureBox31.TabStop = false;
		((Control)PictureBox32).BackColor = Color.Transparent;
		PictureBox32.Image = (Image)componentResourceManager.GetObject("PictureBox32.Image");
		PictureBox pictureBox47 = PictureBox32;
		location = new Point(330, 54);
		((Control)pictureBox47).Location = location;
		((Control)PictureBox32).Name = "PictureBox32";
		PictureBox pictureBox48 = PictureBox32;
		size = new Size(20, 20);
		((Control)pictureBox48).Size = size;
		PictureBox32.SizeMode = (PictureBoxSizeMode)2;
		PictureBox32.TabIndex = 54;
		PictureBox32.TabStop = false;
		((Control)PictureBox33).BackColor = Color.Transparent;
		PictureBox33.Image = (Image)componentResourceManager.GetObject("PictureBox33.Image");
		PictureBox pictureBox49 = PictureBox33;
		location = new Point(361, 54);
		((Control)pictureBox49).Location = location;
		((Control)PictureBox33).Name = "PictureBox33";
		PictureBox pictureBox50 = PictureBox33;
		size = new Size(20, 20);
		((Control)pictureBox50).Size = size;
		PictureBox33.SizeMode = (PictureBoxSizeMode)2;
		PictureBox33.TabIndex = 53;
		PictureBox33.TabStop = false;
		((Control)PictureBox34).BackColor = Color.Transparent;
		PictureBox34.Image = (Image)componentResourceManager.GetObject("PictureBox34.Image");
		PictureBox pictureBox51 = PictureBox34;
		location = new Point(299, 54);
		((Control)pictureBox51).Location = location;
		((Control)PictureBox34).Name = "PictureBox34";
		PictureBox pictureBox52 = PictureBox34;
		size = new Size(20, 20);
		((Control)pictureBox52).Size = size;
		PictureBox34.SizeMode = (PictureBoxSizeMode)2;
		PictureBox34.TabIndex = 52;
		PictureBox34.TabStop = false;
		((Control)PictureBox35).BackColor = Color.Transparent;
		PictureBox35.Image = (Image)componentResourceManager.GetObject("PictureBox35.Image");
		PictureBox pictureBox53 = PictureBox35;
		location = new Point(237, 54);
		((Control)pictureBox53).Location = location;
		((Control)PictureBox35).Name = "PictureBox35";
		PictureBox pictureBox54 = PictureBox35;
		size = new Size(20, 20);
		((Control)pictureBox54).Size = size;
		PictureBox35.SizeMode = (PictureBoxSizeMode)2;
		PictureBox35.TabIndex = 51;
		PictureBox35.TabStop = false;
		((Control)PictureBox36).BackColor = Color.Transparent;
		PictureBox36.Image = (Image)componentResourceManager.GetObject("PictureBox36.Image");
		PictureBox pictureBox55 = PictureBox36;
		location = new Point(268, 54);
		((Control)pictureBox55).Location = location;
		((Control)PictureBox36).Name = "PictureBox36";
		PictureBox pictureBox56 = PictureBox36;
		size = new Size(20, 20);
		((Control)pictureBox56).Size = size;
		PictureBox36.SizeMode = (PictureBoxSizeMode)2;
		PictureBox36.TabIndex = 50;
		PictureBox36.TabStop = false;
		((Control)PictureBox37).BackColor = Color.Transparent;
		PictureBox37.Image = (Image)componentResourceManager.GetObject("PictureBox37.Image");
		PictureBox pictureBox57 = PictureBox37;
		location = new Point(206, 54);
		((Control)pictureBox57).Location = location;
		((Control)PictureBox37).Name = "PictureBox37";
		PictureBox pictureBox58 = PictureBox37;
		size = new Size(20, 20);
		((Control)pictureBox58).Size = size;
		PictureBox37.SizeMode = (PictureBoxSizeMode)2;
		PictureBox37.TabIndex = 49;
		PictureBox37.TabStop = false;
		((Control)PictureBox38).BackColor = Color.Transparent;
		PictureBox38.Image = (Image)componentResourceManager.GetObject("PictureBox38.Image");
		PictureBox pictureBox59 = PictureBox38;
		location = new Point(144, 54);
		((Control)pictureBox59).Location = location;
		((Control)PictureBox38).Name = "PictureBox38";
		PictureBox pictureBox60 = PictureBox38;
		size = new Size(20, 20);
		((Control)pictureBox60).Size = size;
		PictureBox38.SizeMode = (PictureBoxSizeMode)2;
		PictureBox38.TabIndex = 48;
		PictureBox38.TabStop = false;
		((Control)PictureBox39).BackColor = Color.Transparent;
		PictureBox39.Image = (Image)componentResourceManager.GetObject("PictureBox39.Image");
		PictureBox pictureBox61 = PictureBox39;
		location = new Point(175, 54);
		((Control)pictureBox61).Location = location;
		((Control)PictureBox39).Name = "PictureBox39";
		PictureBox pictureBox62 = PictureBox39;
		size = new Size(20, 20);
		((Control)pictureBox62).Size = size;
		PictureBox39.SizeMode = (PictureBoxSizeMode)2;
		PictureBox39.TabIndex = 47;
		PictureBox39.TabStop = false;
		((Control)PictureBox40).BackColor = Color.Transparent;
		PictureBox40.Image = (Image)componentResourceManager.GetObject("PictureBox40.Image");
		PictureBox pictureBox63 = PictureBox40;
		location = new Point(113, 54);
		((Control)pictureBox63).Location = location;
		((Control)PictureBox40).Name = "PictureBox40";
		PictureBox pictureBox64 = PictureBox40;
		size = new Size(20, 20);
		((Control)pictureBox64).Size = size;
		PictureBox40.SizeMode = (PictureBoxSizeMode)2;
		PictureBox40.TabIndex = 46;
		PictureBox40.TabStop = false;
		((Control)PictureBox41).BackColor = Color.Transparent;
		PictureBox41.Image = (Image)componentResourceManager.GetObject("PictureBox41.Image");
		PictureBox pictureBox65 = PictureBox41;
		location = new Point(51, 54);
		((Control)pictureBox65).Location = location;
		((Control)PictureBox41).Name = "PictureBox41";
		PictureBox pictureBox66 = PictureBox41;
		size = new Size(20, 20);
		((Control)pictureBox66).Size = size;
		PictureBox41.SizeMode = (PictureBoxSizeMode)2;
		PictureBox41.TabIndex = 45;
		PictureBox41.TabStop = false;
		((Control)PictureBox42).BackColor = Color.Transparent;
		PictureBox42.Image = (Image)componentResourceManager.GetObject("PictureBox42.Image");
		PictureBox pictureBox67 = PictureBox42;
		location = new Point(82, 54);
		((Control)pictureBox67).Location = location;
		((Control)PictureBox42).Name = "PictureBox42";
		PictureBox pictureBox68 = PictureBox42;
		size = new Size(20, 20);
		((Control)pictureBox68).Size = size;
		PictureBox42.SizeMode = (PictureBoxSizeMode)2;
		PictureBox42.TabIndex = 44;
		PictureBox42.TabStop = false;
		((Control)PictureBox43).BackColor = Color.Transparent;
		PictureBox43.Image = (Image)componentResourceManager.GetObject("PictureBox43.Image");
		PictureBox pictureBox69 = PictureBox43;
		location = new Point(20, 54);
		((Control)pictureBox69).Location = location;
		((Control)PictureBox43).Name = "PictureBox43";
		PictureBox pictureBox70 = PictureBox43;
		size = new Size(20, 20);
		((Control)pictureBox70).Size = size;
		PictureBox43.SizeMode = (PictureBoxSizeMode)2;
		PictureBox43.TabIndex = 43;
		PictureBox43.TabStop = false;
		((Control)PictureBox26).BackColor = Color.Transparent;
		PictureBox26.Image = (Image)componentResourceManager.GetObject("PictureBox26.Image");
		PictureBox pictureBox71 = PictureBox26;
		location = new Point(423, 23);
		((Control)pictureBox71).Location = location;
		((Control)PictureBox26).Name = "PictureBox26";
		PictureBox pictureBox72 = PictureBox26;
		size = new Size(20, 20);
		((Control)pictureBox72).Size = size;
		PictureBox26.SizeMode = (PictureBoxSizeMode)2;
		PictureBox26.TabIndex = 42;
		PictureBox26.TabStop = false;
		((Control)PictureBox27).BackColor = Color.Transparent;
		PictureBox27.Image = (Image)componentResourceManager.GetObject("PictureBox27.Image");
		PictureBox pictureBox73 = PictureBox27;
		location = new Point(392, 54);
		((Control)pictureBox73).Location = location;
		((Control)PictureBox27).Name = "PictureBox27";
		PictureBox pictureBox74 = PictureBox27;
		size = new Size(20, 20);
		((Control)pictureBox74).Size = size;
		PictureBox27.SizeMode = (PictureBoxSizeMode)2;
		PictureBox27.TabIndex = 41;
		PictureBox27.TabStop = false;
		((Control)PictureBox28).BackColor = Color.Transparent;
		PictureBox28.Image = (Image)componentResourceManager.GetObject("PictureBox28.Image");
		PictureBox pictureBox75 = PictureBox28;
		location = new Point(392, 23);
		((Control)pictureBox75).Location = location;
		((Control)PictureBox28).Name = "PictureBox28";
		PictureBox pictureBox76 = PictureBox28;
		size = new Size(20, 20);
		((Control)pictureBox76).Size = size;
		PictureBox28.SizeMode = (PictureBoxSizeMode)2;
		PictureBox28.TabIndex = 40;
		PictureBox28.TabStop = false;
		((Control)PictureBox23).BackColor = Color.Transparent;
		PictureBox23.Image = (Image)componentResourceManager.GetObject("PictureBox23.Image");
		PictureBox pictureBox77 = PictureBox23;
		location = new Point(330, 23);
		((Control)pictureBox77).Location = location;
		((Control)PictureBox23).Name = "PictureBox23";
		PictureBox pictureBox78 = PictureBox23;
		size = new Size(20, 20);
		((Control)pictureBox78).Size = size;
		PictureBox23.SizeMode = (PictureBoxSizeMode)2;
		PictureBox23.TabIndex = 39;
		PictureBox23.TabStop = false;
		((Control)PictureBox24).BackColor = Color.Transparent;
		PictureBox24.Image = (Image)componentResourceManager.GetObject("PictureBox24.Image");
		PictureBox pictureBox79 = PictureBox24;
		location = new Point(361, 23);
		((Control)pictureBox79).Location = location;
		((Control)PictureBox24).Name = "PictureBox24";
		PictureBox pictureBox80 = PictureBox24;
		size = new Size(20, 20);
		((Control)pictureBox80).Size = size;
		PictureBox24.SizeMode = (PictureBoxSizeMode)2;
		PictureBox24.TabIndex = 38;
		PictureBox24.TabStop = false;
		((Control)PictureBox25).BackColor = Color.Transparent;
		PictureBox25.Image = (Image)componentResourceManager.GetObject("PictureBox25.Image");
		PictureBox pictureBox81 = PictureBox25;
		location = new Point(299, 23);
		((Control)pictureBox81).Location = location;
		((Control)PictureBox25).Name = "PictureBox25";
		PictureBox pictureBox82 = PictureBox25;
		size = new Size(20, 20);
		((Control)pictureBox82).Size = size;
		PictureBox25.SizeMode = (PictureBoxSizeMode)2;
		PictureBox25.TabIndex = 37;
		PictureBox25.TabStop = false;
		((Control)PictureBox20).BackColor = Color.Transparent;
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox pictureBox83 = PictureBox20;
		location = new Point(237, 23);
		((Control)pictureBox83).Location = location;
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox pictureBox84 = PictureBox20;
		size = new Size(20, 20);
		((Control)pictureBox84).Size = size;
		PictureBox20.SizeMode = (PictureBoxSizeMode)2;
		PictureBox20.TabIndex = 36;
		PictureBox20.TabStop = false;
		((Control)PictureBox21).BackColor = Color.Transparent;
		PictureBox21.Image = (Image)componentResourceManager.GetObject("PictureBox21.Image");
		PictureBox pictureBox85 = PictureBox21;
		location = new Point(268, 23);
		((Control)pictureBox85).Location = location;
		((Control)PictureBox21).Name = "PictureBox21";
		PictureBox pictureBox86 = PictureBox21;
		size = new Size(20, 20);
		((Control)pictureBox86).Size = size;
		PictureBox21.SizeMode = (PictureBoxSizeMode)2;
		PictureBox21.TabIndex = 35;
		PictureBox21.TabStop = false;
		((Control)PictureBox22).BackColor = Color.Transparent;
		PictureBox22.Image = (Image)componentResourceManager.GetObject("PictureBox22.Image");
		PictureBox pictureBox87 = PictureBox22;
		location = new Point(206, 23);
		((Control)pictureBox87).Location = location;
		((Control)PictureBox22).Name = "PictureBox22";
		PictureBox pictureBox88 = PictureBox22;
		size = new Size(20, 20);
		((Control)pictureBox88).Size = size;
		PictureBox22.SizeMode = (PictureBoxSizeMode)2;
		PictureBox22.TabIndex = 34;
		PictureBox22.TabStop = false;
		((Control)PictureBox17).BackColor = Color.Transparent;
		PictureBox17.Image = (Image)componentResourceManager.GetObject("PictureBox17.Image");
		PictureBox pictureBox89 = PictureBox17;
		location = new Point(144, 23);
		((Control)pictureBox89).Location = location;
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox pictureBox90 = PictureBox17;
		size = new Size(20, 20);
		((Control)pictureBox90).Size = size;
		PictureBox17.SizeMode = (PictureBoxSizeMode)2;
		PictureBox17.TabIndex = 33;
		PictureBox17.TabStop = false;
		((Control)PictureBox18).BackColor = Color.Transparent;
		PictureBox18.Image = (Image)componentResourceManager.GetObject("PictureBox18.Image");
		PictureBox pictureBox91 = PictureBox18;
		location = new Point(175, 23);
		((Control)pictureBox91).Location = location;
		((Control)PictureBox18).Name = "PictureBox18";
		PictureBox pictureBox92 = PictureBox18;
		size = new Size(20, 20);
		((Control)pictureBox92).Size = size;
		PictureBox18.SizeMode = (PictureBoxSizeMode)2;
		PictureBox18.TabIndex = 32;
		PictureBox18.TabStop = false;
		((Control)PictureBox19).BackColor = Color.Transparent;
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox pictureBox93 = PictureBox19;
		location = new Point(113, 23);
		((Control)pictureBox93).Location = location;
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox pictureBox94 = PictureBox19;
		size = new Size(20, 20);
		((Control)pictureBox94).Size = size;
		PictureBox19.SizeMode = (PictureBoxSizeMode)2;
		PictureBox19.TabIndex = 31;
		PictureBox19.TabStop = false;
		((Control)PictureBox16).BackColor = Color.Transparent;
		PictureBox16.Image = (Image)componentResourceManager.GetObject("PictureBox16.Image");
		PictureBox pictureBox95 = PictureBox16;
		location = new Point(51, 23);
		((Control)pictureBox95).Location = location;
		((Control)PictureBox16).Name = "PictureBox16";
		PictureBox pictureBox96 = PictureBox16;
		size = new Size(20, 20);
		((Control)pictureBox96).Size = size;
		PictureBox16.SizeMode = (PictureBoxSizeMode)2;
		PictureBox16.TabIndex = 30;
		PictureBox16.TabStop = false;
		((Control)PictureBox15).BackColor = Color.Transparent;
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox pictureBox97 = PictureBox15;
		location = new Point(82, 23);
		((Control)pictureBox97).Location = location;
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox pictureBox98 = PictureBox15;
		size = new Size(20, 20);
		((Control)pictureBox98).Size = size;
		PictureBox15.SizeMode = (PictureBoxSizeMode)2;
		PictureBox15.TabIndex = 29;
		PictureBox15.TabStop = false;
		((Control)PictureBox14).BackColor = Color.Transparent;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox99 = PictureBox14;
		location = new Point(20, 23);
		((Control)pictureBox99).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox100 = PictureBox14;
		size = new Size(20, 20);
		((Control)pictureBox100).Size = size;
		PictureBox14.SizeMode = (PictureBoxSizeMode)2;
		PictureBox14.TabIndex = 28;
		PictureBox14.TabStop = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj = defaultclose;
		location = new Point(1147, 0);
		((Control)obj).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj2 = defaultclose;
		size = new Size(51, 34);
		((Control)obj2).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj3 = hoverclose;
		location = new Point(1204, 0);
		((Control)obj3).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj4 = hoverclose;
		size = new Size(51, 34);
		((Control)obj4).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj5 = clickclose;
		location = new Point(1261, 0);
		((Control)obj5).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj6 = clickclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox51.Image = (Image)componentResourceManager.GetObject("PictureBox51.Image");
		PictureBox pictureBox101 = PictureBox51;
		location = new Point(1261, 1);
		((Control)pictureBox101).Location = location;
		((Control)PictureBox51).Name = "PictureBox51";
		PictureBox pictureBox102 = PictureBox51;
		size = new Size(51, 34);
		((Control)pictureBox102).Size = size;
		PictureBox51.SizeMode = (PictureBoxSizeMode)2;
		PictureBox51.TabIndex = 118;
		PictureBox51.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1360, 768);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox51);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "paintain";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox13).EndInit();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((ISupportInitialize)PictureBox44).EndInit();
		((ISupportInitialize)PictureBox45).EndInit();
		((ISupportInitialize)PictureBox46).EndInit();
		((ISupportInitialize)PictureBox47).EndInit();
		((ISupportInitialize)PictureBox48).EndInit();
		((ISupportInitialize)PictureBox49).EndInit();
		((ISupportInitialize)PictureBox50).EndInit();
		((ISupportInitialize)PictureBox29).EndInit();
		((ISupportInitialize)PictureBox30).EndInit();
		((ISupportInitialize)PictureBox31).EndInit();
		((ISupportInitialize)PictureBox32).EndInit();
		((ISupportInitialize)PictureBox33).EndInit();
		((ISupportInitialize)PictureBox34).EndInit();
		((ISupportInitialize)PictureBox35).EndInit();
		((ISupportInitialize)PictureBox36).EndInit();
		((ISupportInitialize)PictureBox37).EndInit();
		((ISupportInitialize)PictureBox38).EndInit();
		((ISupportInitialize)PictureBox39).EndInit();
		((ISupportInitialize)PictureBox40).EndInit();
		((ISupportInitialize)PictureBox41).EndInit();
		((ISupportInitialize)PictureBox42).EndInit();
		((ISupportInitialize)PictureBox43).EndInit();
		((ISupportInitialize)PictureBox26).EndInit();
		((ISupportInitialize)PictureBox27).EndInit();
		((ISupportInitialize)PictureBox28).EndInit();
		((ISupportInitialize)PictureBox23).EndInit();
		((ISupportInitialize)PictureBox24).EndInit();
		((ISupportInitialize)PictureBox25).EndInit();
		((ISupportInitialize)PictureBox20).EndInit();
		((ISupportInitialize)PictureBox21).EndInit();
		((ISupportInitialize)PictureBox22).EndInit();
		((ISupportInitialize)PictureBox17).EndInit();
		((ISupportInitialize)PictureBox18).EndInit();
		((ISupportInitialize)PictureBox19).EndInit();
		((ISupportInitialize)PictureBox16).EndInit();
		((ISupportInitialize)PictureBox15).EndInit();
		((ISupportInitialize)PictureBox14).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox51).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void PictureBox12_Click(object sender, EventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		((Control)PictureBox4).Enabled = true;
		((Form)this).BackColor = Color.White;
		bmpPic = new Bitmap(((Control)PictureBox4).Width, ((Control)PictureBox4).Height);
		PictureBox4.Image = (Image)(object)bmpPic;
		G = Graphics.FromImage((Image)(object)bmpPic);
		((Control)PictureBox4).DrawToBitmap(bmpPic, ((Control)PictureBox4).ClientRectangle);
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
	}

	private void paintain_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.paintainout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.pain.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void paintain_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = PictureBox3;
		checked
		{
			Point location = new Point(((Control)this).Width - ((Control)PictureBox3).Width, 0);
			((Control)pictureBox).Location = location;
			PictureBox pictureBox2 = PictureBox51;
			Point location2 = new Point(((Control)PictureBox3).Location.X - ((Control)PictureBox51).Width, ((Control)PictureBox3).Location.Y);
			((Control)pictureBox2).Location = location2;
			if (!((Control)MyProject.Forms.home.app1).Enabled)
			{
				((Control)MyProject.Forms.home.app1).Enabled = true;
				MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app2).Enabled)
			{
				((Control)MyProject.Forms.home.app2).Enabled = true;
				MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app3).Enabled)
			{
				((Control)MyProject.Forms.home.app3).Enabled = true;
				MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app4).Enabled)
			{
				((Control)MyProject.Forms.home.app4).Enabled = true;
				MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app5).Enabled)
			{
				((Control)MyProject.Forms.home.app5).Enabled = true;
				MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app6).Enabled)
			{
				((Control)MyProject.Forms.home.app6).Enabled = true;
				MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app7).Enabled)
			{
				((Control)MyProject.Forms.home.app7).Enabled = true;
				MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app8).Enabled)
			{
				((Control)MyProject.Forms.home.app8).Enabled = true;
				MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app9).Enabled)
			{
				((Control)MyProject.Forms.home.app9).Enabled = true;
				MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app10).Enabled)
			{
				((Control)MyProject.Forms.home.app10).Enabled = true;
				MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app11).Enabled)
			{
				((Control)MyProject.Forms.home.app11).Enabled = true;
				MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app12).Enabled)
			{
				((Control)MyProject.Forms.home.app12).Enabled = true;
				MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app13).Enabled)
			{
				((Control)MyProject.Forms.home.app13).Enabled = true;
				MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app14).Enabled)
			{
				((Control)MyProject.Forms.home.app14).Enabled = true;
				MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app15).Enabled)
			{
				((Control)MyProject.Forms.home.app15).Enabled = true;
				MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app16).Enabled)
			{
				((Control)MyProject.Forms.home.app16).Enabled = true;
				MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app17).Enabled)
			{
				((Control)MyProject.Forms.home.app17).Enabled = true;
				MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app18).Enabled)
			{
				((Control)MyProject.Forms.home.app18).Enabled = true;
				MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app19).Enabled)
			{
				((Control)MyProject.Forms.home.app19).Enabled = true;
				MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app20).Enabled)
			{
				((Control)MyProject.Forms.home.app20).Enabled = true;
				MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app21).Enabled)
			{
				((Control)MyProject.Forms.home.app21).Enabled = true;
				MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app22).Enabled)
			{
				((Control)MyProject.Forms.home.app22).Enabled = true;
				MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app23).Enabled)
			{
				((Control)MyProject.Forms.home.app23).Enabled = true;
				MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app24).Enabled)
			{
				((Control)MyProject.Forms.home.app24).Enabled = true;
				MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.pain.Image;
			}
			else if (!((Control)MyProject.Forms.home.app25).Enabled)
			{
				((Control)MyProject.Forms.home.app25).Enabled = true;
				MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.pain.Image;
			}
			Fade.paintainin();
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

	private void PictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
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
}
