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
public class calculator : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("text3")]
	private Label _text3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("PictureBox11")]
	private PictureBox _PictureBox11;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	[AccessedThroughProperty("PictureBox15")]
	private PictureBox _PictureBox15;

	[AccessedThroughProperty("PictureBox16")]
	private PictureBox _PictureBox16;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("PictureBox18")]
	private PictureBox _PictureBox18;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("oper")]
	private Label _oper;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("off")]
	private PictureBox _off;

	[AccessedThroughProperty("onn")]
	private PictureBox _onn;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox21")]
	private PictureBox _PictureBox21;

	private Point mouse_move;

	private decimal Firstnum;

	private decimal secondnum;

	private int Operations;

	private bool Operator_Selector;

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
			EventHandler eventHandler2 = PictureBox2_MouseLeave;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click -= eventHandler;
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).MouseDown -= val2;
				((Control)_PictureBox2).MouseLeave -= eventHandler2;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click += eventHandler;
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).MouseDown += val2;
				((Control)_PictureBox2).MouseLeave += eventHandler2;
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

	internal virtual Label text3
	{
		[DebuggerNonUserCode]
		get
		{
			return _text3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = text3_Click;
			if (_text3 != null)
			{
				((Control)_text3).Click -= eventHandler;
			}
			_text3 = value;
			if (_text3 != null)
			{
				((Control)_text3).Click += eventHandler;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox4_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox4_MouseMove);
			EventHandler eventHandler2 = PictureBox4_MouseLeave;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click -= eventHandler;
				((Control)_PictureBox4).MouseMove -= val;
				((Control)_PictureBox4).MouseLeave -= eventHandler2;
			}
			_PictureBox4 = value;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click += eventHandler;
				((Control)_PictureBox4).MouseMove += val;
				((Control)_PictureBox4).MouseLeave += eventHandler2;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox5_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox5_MouseMove);
			EventHandler eventHandler2 = PictureBox5_MouseLeave;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click -= eventHandler;
				((Control)_PictureBox5).MouseMove -= val;
				((Control)_PictureBox5).MouseLeave -= eventHandler2;
			}
			_PictureBox5 = value;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click += eventHandler;
				((Control)_PictureBox5).MouseMove += val;
				((Control)_PictureBox5).MouseLeave += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox6_MouseMove);
			EventHandler eventHandler = PictureBox6_MouseLeave;
			EventHandler eventHandler2 = PictureBox6_Click;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).MouseMove -= val;
				((Control)_PictureBox6).MouseLeave -= eventHandler;
				((Control)_PictureBox6).Click -= eventHandler2;
			}
			_PictureBox6 = value;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).MouseMove += val;
				((Control)_PictureBox6).MouseLeave += eventHandler;
				((Control)_PictureBox6).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox7_MouseMove);
			EventHandler eventHandler = PictureBox7_MouseLeave;
			EventHandler eventHandler2 = PictureBox7_Click;
			if (_PictureBox7 != null)
			{
				((Control)_PictureBox7).MouseMove -= val;
				((Control)_PictureBox7).MouseLeave -= eventHandler;
				((Control)_PictureBox7).Click -= eventHandler2;
			}
			_PictureBox7 = value;
			if (_PictureBox7 != null)
			{
				((Control)_PictureBox7).MouseMove += val;
				((Control)_PictureBox7).MouseLeave += eventHandler;
				((Control)_PictureBox7).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox8_MouseMove);
			EventHandler eventHandler = PictureBox8_MouseLeave;
			EventHandler eventHandler2 = PictureBox8_Click;
			if (_PictureBox8 != null)
			{
				((Control)_PictureBox8).MouseMove -= val;
				((Control)_PictureBox8).MouseLeave -= eventHandler;
				((Control)_PictureBox8).Click -= eventHandler2;
			}
			_PictureBox8 = value;
			if (_PictureBox8 != null)
			{
				((Control)_PictureBox8).MouseMove += val;
				((Control)_PictureBox8).MouseLeave += eventHandler;
				((Control)_PictureBox8).Click += eventHandler2;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox9_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox9_MouseMove);
			EventHandler eventHandler2 = PictureBox9_MouseLeave;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click -= eventHandler;
				((Control)_PictureBox9).MouseMove -= val;
				((Control)_PictureBox9).MouseLeave -= eventHandler2;
			}
			_PictureBox9 = value;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click += eventHandler;
				((Control)_PictureBox9).MouseMove += val;
				((Control)_PictureBox9).MouseLeave += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox10_MouseMove);
			EventHandler eventHandler = PictureBox10_MouseLeave;
			EventHandler eventHandler2 = PictureBox10_Click;
			if (_PictureBox10 != null)
			{
				((Control)_PictureBox10).MouseMove -= val;
				((Control)_PictureBox10).MouseLeave -= eventHandler;
				((Control)_PictureBox10).Click -= eventHandler2;
			}
			_PictureBox10 = value;
			if (_PictureBox10 != null)
			{
				((Control)_PictureBox10).MouseMove += val;
				((Control)_PictureBox10).MouseLeave += eventHandler;
				((Control)_PictureBox10).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox11_MouseMove);
			EventHandler eventHandler = PictureBox11_MouseLeave;
			EventHandler eventHandler2 = PictureBox11_Click;
			if (_PictureBox11 != null)
			{
				((Control)_PictureBox11).MouseMove -= val;
				((Control)_PictureBox11).MouseLeave -= eventHandler;
				((Control)_PictureBox11).Click -= eventHandler2;
			}
			_PictureBox11 = value;
			if (_PictureBox11 != null)
			{
				((Control)_PictureBox11).MouseMove += val;
				((Control)_PictureBox11).MouseLeave += eventHandler;
				((Control)_PictureBox11).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox14_MouseMove);
			EventHandler eventHandler = PictureBox14_MouseLeave;
			EventHandler eventHandler2 = PictureBox14_Click;
			if (_PictureBox14 != null)
			{
				((Control)_PictureBox14).MouseMove -= val;
				((Control)_PictureBox14).MouseLeave -= eventHandler;
				((Control)_PictureBox14).Click -= eventHandler2;
			}
			_PictureBox14 = value;
			if (_PictureBox14 != null)
			{
				((Control)_PictureBox14).MouseMove += val;
				((Control)_PictureBox14).MouseLeave += eventHandler;
				((Control)_PictureBox14).Click += eventHandler2;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox16_MouseMove);
			EventHandler eventHandler = PictureBox16_MouseLeave;
			EventHandler eventHandler2 = PictureBox16_Click;
			if (_PictureBox16 != null)
			{
				((Control)_PictureBox16).MouseMove -= val;
				((Control)_PictureBox16).MouseLeave -= eventHandler;
				((Control)_PictureBox16).Click -= eventHandler2;
			}
			_PictureBox16 = value;
			if (_PictureBox16 != null)
			{
				((Control)_PictureBox16).MouseMove += val;
				((Control)_PictureBox16).MouseLeave += eventHandler;
				((Control)_PictureBox16).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox17_MouseMove);
			EventHandler eventHandler = PictureBox17_MouseLeave;
			EventHandler eventHandler2 = PictureBox17_Click;
			if (_PictureBox17 != null)
			{
				((Control)_PictureBox17).MouseMove -= val;
				((Control)_PictureBox17).MouseLeave -= eventHandler;
				((Control)_PictureBox17).Click -= eventHandler2;
			}
			_PictureBox17 = value;
			if (_PictureBox17 != null)
			{
				((Control)_PictureBox17).MouseMove += val;
				((Control)_PictureBox17).MouseLeave += eventHandler;
				((Control)_PictureBox17).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox18_MouseMove);
			EventHandler eventHandler = PictureBox18_MouseLeave;
			EventHandler eventHandler2 = PictureBox18_Click;
			if (_PictureBox18 != null)
			{
				((Control)_PictureBox18).MouseMove -= val;
				((Control)_PictureBox18).MouseLeave -= eventHandler;
				((Control)_PictureBox18).Click -= eventHandler2;
			}
			_PictureBox18 = value;
			if (_PictureBox18 != null)
			{
				((Control)_PictureBox18).MouseMove += val;
				((Control)_PictureBox18).MouseLeave += eventHandler;
				((Control)_PictureBox18).Click += eventHandler2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox19_MouseMove);
			EventHandler eventHandler = PictureBox19_MouseLeave;
			EventHandler eventHandler2 = PictureBox19_Click;
			if (_PictureBox19 != null)
			{
				((Control)_PictureBox19).MouseMove -= val;
				((Control)_PictureBox19).MouseLeave -= eventHandler;
				((Control)_PictureBox19).Click -= eventHandler2;
			}
			_PictureBox19 = value;
			if (_PictureBox19 != null)
			{
				((Control)_PictureBox19).MouseMove += val;
				((Control)_PictureBox19).MouseLeave += eventHandler;
				((Control)_PictureBox19).Click += eventHandler2;
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
			EventHandler eventHandler = Label5_Click;
			if (_Label5 != null)
			{
				((Control)_Label5).Click -= eventHandler;
			}
			_Label5 = value;
			if (_Label5 != null)
			{
				((Control)_Label5).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label6_Click;
			if (_Label6 != null)
			{
				((Control)_Label6).Click -= eventHandler;
			}
			_Label6 = value;
			if (_Label6 != null)
			{
				((Control)_Label6).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label7_Click;
			if (_Label7 != null)
			{
				((Control)_Label7).Click -= eventHandler;
			}
			_Label7 = value;
			if (_Label7 != null)
			{
				((Control)_Label7).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label8_Click;
			if (_Label8 != null)
			{
				((Control)_Label8).Click -= eventHandler;
			}
			_Label8 = value;
			if (_Label8 != null)
			{
				((Control)_Label8).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label9_Click;
			if (_Label9 != null)
			{
				((Control)_Label9).Click -= eventHandler;
			}
			_Label9 = value;
			if (_Label9 != null)
			{
				((Control)_Label9).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label10_Click;
			if (_Label10 != null)
			{
				((Control)_Label10).Click -= eventHandler;
			}
			_Label10 = value;
			if (_Label10 != null)
			{
				((Control)_Label10).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label11_Click;
			if (_Label11 != null)
			{
				((Control)_Label11).Click -= eventHandler;
			}
			_Label11 = value;
			if (_Label11 != null)
			{
				((Control)_Label11).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label12_Click;
			if (_Label12 != null)
			{
				((Control)_Label12).Click -= eventHandler;
			}
			_Label12 = value;
			if (_Label12 != null)
			{
				((Control)_Label12).Click += eventHandler;
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

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label14_Click;
			if (_Label14 != null)
			{
				((Control)_Label14).Click -= eventHandler;
			}
			_Label14 = value;
			if (_Label14 != null)
			{
				((Control)_Label14).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label15_Click;
			if (_Label15 != null)
			{
				((Control)_Label15).Click -= eventHandler;
			}
			_Label15 = value;
			if (_Label15 != null)
			{
				((Control)_Label15).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label16_Click;
			if (_Label16 != null)
			{
				((Control)_Label16).Click -= eventHandler;
			}
			_Label16 = value;
			if (_Label16 != null)
			{
				((Control)_Label16).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label17_Click;
			if (_Label17 != null)
			{
				((Control)_Label17).Click -= eventHandler;
			}
			_Label17 = value;
			if (_Label17 != null)
			{
				((Control)_Label17).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label18_Click;
			if (_Label18 != null)
			{
				((Control)_Label18).Click -= eventHandler;
			}
			_Label18 = value;
			if (_Label18 != null)
			{
				((Control)_Label18).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label19_Click;
			if (_Label19 != null)
			{
				((Control)_Label19).Click -= eventHandler;
			}
			_Label19 = value;
			if (_Label19 != null)
			{
				((Control)_Label19).Click += eventHandler;
			}
		}
	}

	internal virtual Label oper
	{
		[DebuggerNonUserCode]
		get
		{
			return _oper;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_oper = value;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox20_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox20_MouseMove);
			EventHandler eventHandler2 = PictureBox20_MouseLeave;
			if (_PictureBox20 != null)
			{
				((Control)_PictureBox20).Click -= eventHandler;
				((Control)_PictureBox20).MouseMove -= val;
				((Control)_PictureBox20).MouseLeave -= eventHandler2;
			}
			_PictureBox20 = value;
			if (_PictureBox20 != null)
			{
				((Control)_PictureBox20).Click += eventHandler;
				((Control)_PictureBox20).MouseMove += val;
				((Control)_PictureBox20).MouseLeave += eventHandler2;
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
			EventHandler eventHandler = Label2_Click;
			if (_Label2 != null)
			{
				((Control)_Label2).Click -= eventHandler;
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox off
	{
		[DebuggerNonUserCode]
		get
		{
			return _off;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_off = value;
		}
	}

	internal virtual PictureBox onn
	{
		[DebuggerNonUserCode]
		get
		{
			return _onn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_onn = value;
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
			EventHandler eventHandler = Label4_Click;
			if (_Label4 != null)
			{
				((Control)_Label4).Click -= eventHandler;
			}
			_Label4 = value;
			if (_Label4 != null)
			{
				((Control)_Label4).Click += eventHandler;
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
			_Label3 = value;
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
			EventHandler eventHandler = PictureBox21_Click;
			if (_PictureBox21 != null)
			{
				((Control)_PictureBox21).Click -= eventHandler;
			}
			_PictureBox21 = value;
			if (_PictureBox21 != null)
			{
				((Control)_PictureBox21).Click += eventHandler;
			}
		}
	}

	public calculator()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(calculator_FormClosing);
		((Form)this).Load += calculator_Load;
		((Control)this).LostFocus += calculator_LostFocus;
		__ENCAddToList(this);
		Operator_Selector = false;
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
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Expected O, but got Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_074c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Expected O, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cf: Expected O, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0a: Expected O, but got Unknown
		//IL_0b9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected O, but got Unknown
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce3: Expected O, but got Unknown
		//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7f: Expected O, but got Unknown
		//IL_0e10: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1a: Expected O, but got Unknown
		//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb9: Expected O, but got Unknown
		//IL_0f4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f58: Expected O, but got Unknown
		//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff4: Expected O, but got Unknown
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Expected O, but got Unknown
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_1163: Expected O, but got Unknown
		//IL_1218: Unknown result type (might be due to invalid IL or missing references)
		//IL_1222: Expected O, but got Unknown
		//IL_12d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e1: Expected O, but got Unknown
		//IL_1393: Unknown result type (might be due to invalid IL or missing references)
		//IL_139d: Expected O, but got Unknown
		//IL_144f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Expected O, but got Unknown
		//IL_150e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1518: Expected O, but got Unknown
		//IL_15ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d4: Expected O, but got Unknown
		//IL_1686: Unknown result type (might be due to invalid IL or missing references)
		//IL_1690: Expected O, but got Unknown
		//IL_1745: Unknown result type (might be due to invalid IL or missing references)
		//IL_174f: Expected O, but got Unknown
		//IL_1801: Unknown result type (might be due to invalid IL or missing references)
		//IL_180b: Expected O, but got Unknown
		//IL_18bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c7: Expected O, but got Unknown
		//IL_197c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1986: Expected O, but got Unknown
		//IL_1a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a45: Expected O, but got Unknown
		//IL_1afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b04: Expected O, but got Unknown
		//IL_1bb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bba: Expected O, but got Unknown
		//IL_1c31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3b: Expected O, but got Unknown
		//IL_1ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cef: Expected O, but got Unknown
		//IL_1d89: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d93: Expected O, but got Unknown
		//IL_1e31: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3b: Expected O, but got Unknown
		//IL_1ef1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efb: Expected O, but got Unknown
		//IL_1fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fae: Expected O, but got Unknown
		//IL_2055: Unknown result type (might be due to invalid IL or missing references)
		//IL_205f: Expected O, but got Unknown
		//IL_20fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2104: Expected O, but got Unknown
		//IL_21a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ac: Expected O, but got Unknown
		//IL_2239: Unknown result type (might be due to invalid IL or missing references)
		//IL_2243: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(calculator));
		Label1 = new Label();
		PictureBox3 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		text3 = new Label();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox7 = new PictureBox();
		PictureBox8 = new PictureBox();
		PictureBox9 = new PictureBox();
		PictureBox10 = new PictureBox();
		PictureBox11 = new PictureBox();
		PictureBox12 = new PictureBox();
		PictureBox13 = new PictureBox();
		PictureBox14 = new PictureBox();
		PictureBox15 = new PictureBox();
		PictureBox16 = new PictureBox();
		PictureBox17 = new PictureBox();
		PictureBox18 = new PictureBox();
		PictureBox19 = new PictureBox();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label16 = new Label();
		Label17 = new Label();
		Label18 = new Label();
		Label19 = new Label();
		oper = new Label();
		PictureBox20 = new PictureBox();
		Label2 = new Label();
		off = new PictureBox();
		onn = new PictureBox();
		Label4 = new Label();
		Label3 = new Label();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox21 = new PictureBox();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((ISupportInitialize)PictureBox14).BeginInit();
		((ISupportInitialize)PictureBox15).BeginInit();
		((ISupportInitialize)PictureBox16).BeginInit();
		((ISupportInitialize)PictureBox17).BeginInit();
		((ISupportInitialize)PictureBox18).BeginInit();
		((ISupportInitialize)PictureBox19).BeginInit();
		((ISupportInitialize)PictureBox20).BeginInit();
		((ISupportInitialize)off).BeginInit();
		((ISupportInitialize)onn).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox21).BeginInit();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		Point location = new Point(33, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(82, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 8;
		Label1.Text = "Calculator";
		((Control)PictureBox3).BackColor = Color.White;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		location = new Point(5, 6);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		size = new Size(22, 22);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 7;
		PictureBox3.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(309, 1);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(51, 34);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 6;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox5 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox6 = PictureBox1;
		size = new Size(1000, 35);
		((Control)pictureBox6).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 5;
		PictureBox1.TabStop = false;
		((Control)text3).Anchor = (AnchorStyles)3;
		((Control)text3).BackColor = Color.Transparent;
		((Control)text3).Font = new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)text3).ForeColor = Color.FromArgb(35, 35, 35);
		Label obj = text3;
		location = new Point(12, 56);
		((Control)obj).Location = location;
		((Control)text3).Name = "text3";
		Label obj2 = text3;
		size = new Size(336, 36);
		((Control)obj2).Size = size;
		((Control)text3).TabIndex = 29;
		text3.Text = "0";
		text3.TextAlign = (ContentAlignment)64;
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(0, 128);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(90, 58);
		((Control)pictureBox8).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 30;
		PictureBox4.TabStop = false;
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox9 = PictureBox5;
		location = new Point(90, 128);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox10 = PictureBox5;
		size = new Size(90, 58);
		((Control)pictureBox10).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 31;
		PictureBox5.TabStop = false;
		((Control)PictureBox6).BackColor = Color.White;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox11 = PictureBox6;
		location = new Point(270, 128);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox12 = PictureBox6;
		size = new Size(90, 58);
		((Control)pictureBox12).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 33;
		PictureBox6.TabStop = false;
		((Control)PictureBox7).BackColor = Color.White;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox13 = PictureBox7;
		location = new Point(180, 128);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox14 = PictureBox7;
		size = new Size(90, 58);
		((Control)pictureBox14).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 32;
		PictureBox7.TabStop = false;
		((Control)PictureBox8).BackColor = Color.White;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox15 = PictureBox8;
		location = new Point(270, 186);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox16 = PictureBox8;
		size = new Size(90, 58);
		((Control)pictureBox16).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)2;
		PictureBox8.TabIndex = 37;
		PictureBox8.TabStop = false;
		((Control)PictureBox9).BackColor = Color.White;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox17 = PictureBox9;
		location = new Point(180, 186);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox18 = PictureBox9;
		size = new Size(90, 58);
		((Control)pictureBox18).Size = size;
		PictureBox9.SizeMode = (PictureBoxSizeMode)2;
		PictureBox9.TabIndex = 36;
		PictureBox9.TabStop = false;
		((Control)PictureBox10).BackColor = Color.White;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox19 = PictureBox10;
		location = new Point(90, 186);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox20 = PictureBox10;
		size = new Size(90, 58);
		((Control)pictureBox20).Size = size;
		PictureBox10.SizeMode = (PictureBoxSizeMode)2;
		PictureBox10.TabIndex = 35;
		PictureBox10.TabStop = false;
		((Control)PictureBox11).BackColor = Color.White;
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox pictureBox21 = PictureBox11;
		location = new Point(0, 186);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox pictureBox22 = PictureBox11;
		size = new Size(90, 58);
		((Control)pictureBox22).Size = size;
		PictureBox11.SizeMode = (PictureBoxSizeMode)2;
		PictureBox11.TabIndex = 34;
		PictureBox11.TabStop = false;
		((Control)PictureBox12).BackColor = Color.White;
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox23 = PictureBox12;
		location = new Point(270, 244);
		((Control)pictureBox23).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox24 = PictureBox12;
		size = new Size(90, 58);
		((Control)pictureBox24).Size = size;
		PictureBox12.SizeMode = (PictureBoxSizeMode)2;
		PictureBox12.TabIndex = 41;
		PictureBox12.TabStop = false;
		((Control)PictureBox13).BackColor = Color.White;
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox25 = PictureBox13;
		location = new Point(180, 244);
		((Control)pictureBox25).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox26 = PictureBox13;
		size = new Size(90, 58);
		((Control)pictureBox26).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)2;
		PictureBox13.TabIndex = 40;
		PictureBox13.TabStop = false;
		((Control)PictureBox14).BackColor = Color.White;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox27 = PictureBox14;
		location = new Point(90, 244);
		((Control)pictureBox27).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox28 = PictureBox14;
		size = new Size(90, 58);
		((Control)pictureBox28).Size = size;
		PictureBox14.SizeMode = (PictureBoxSizeMode)2;
		PictureBox14.TabIndex = 39;
		PictureBox14.TabStop = false;
		((Control)PictureBox15).BackColor = Color.White;
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox pictureBox29 = PictureBox15;
		location = new Point(0, 244);
		((Control)pictureBox29).Location = location;
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox pictureBox30 = PictureBox15;
		size = new Size(90, 58);
		((Control)pictureBox30).Size = size;
		PictureBox15.SizeMode = (PictureBoxSizeMode)2;
		PictureBox15.TabIndex = 38;
		PictureBox15.TabStop = false;
		((Control)PictureBox16).BackColor = Color.White;
		PictureBox16.Image = (Image)componentResourceManager.GetObject("PictureBox16.Image");
		PictureBox pictureBox31 = PictureBox16;
		location = new Point(270, 302);
		((Control)pictureBox31).Location = location;
		((Control)PictureBox16).Name = "PictureBox16";
		PictureBox pictureBox32 = PictureBox16;
		size = new Size(90, 58);
		((Control)pictureBox32).Size = size;
		PictureBox16.SizeMode = (PictureBoxSizeMode)2;
		PictureBox16.TabIndex = 45;
		PictureBox16.TabStop = false;
		((Control)PictureBox17).BackColor = Color.White;
		PictureBox17.Image = (Image)componentResourceManager.GetObject("PictureBox17.Image");
		PictureBox pictureBox33 = PictureBox17;
		location = new Point(180, 302);
		((Control)pictureBox33).Location = location;
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox pictureBox34 = PictureBox17;
		size = new Size(90, 58);
		((Control)pictureBox34).Size = size;
		PictureBox17.SizeMode = (PictureBoxSizeMode)2;
		PictureBox17.TabIndex = 44;
		PictureBox17.TabStop = false;
		((Control)PictureBox18).BackColor = Color.White;
		PictureBox18.Image = (Image)componentResourceManager.GetObject("PictureBox18.Image");
		PictureBox pictureBox35 = PictureBox18;
		location = new Point(90, 302);
		((Control)pictureBox35).Location = location;
		((Control)PictureBox18).Name = "PictureBox18";
		PictureBox pictureBox36 = PictureBox18;
		size = new Size(90, 58);
		((Control)pictureBox36).Size = size;
		PictureBox18.SizeMode = (PictureBoxSizeMode)2;
		PictureBox18.TabIndex = 43;
		PictureBox18.TabStop = false;
		((Control)PictureBox19).BackColor = Color.White;
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox pictureBox37 = PictureBox19;
		location = new Point(0, 302);
		((Control)pictureBox37).Location = location;
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox pictureBox38 = PictureBox19;
		size = new Size(90, 58);
		((Control)pictureBox38).Size = size;
		PictureBox19.SizeMode = (PictureBoxSizeMode)2;
		PictureBox19.TabIndex = 42;
		PictureBox19.TabStop = false;
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label5).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label3 = Label5;
		location = new Point(123, 143);
		((Control)label3).Location = location;
		((Control)Label5).Name = "Label5";
		Label label4 = Label5;
		size = new Size(28, 29);
		((Control)label4).Size = size;
		((Control)Label5).TabIndex = 48;
		Label5.Text = "2";
		Label6.AutoSize = true;
		((Control)Label6).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label6).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label5 = Label6;
		location = new Point(215, 143);
		((Control)label5).Location = location;
		((Control)Label6).Name = "Label6";
		Label label6 = Label6;
		size = new Size(28, 29);
		((Control)label6).Size = size;
		((Control)Label6).TabIndex = 49;
		Label6.Text = "3";
		Label7.AutoSize = true;
		((Control)Label7).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label7).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.White;
		Label label7 = Label7;
		location = new Point(215, 202);
		((Control)label7).Location = location;
		((Control)Label7).Name = "Label7";
		Label label8 = Label7;
		size = new Size(28, 29);
		((Control)label8).Size = size;
		((Control)Label7).TabIndex = 52;
		Label7.Text = "6";
		Label8.AutoSize = true;
		((Control)Label8).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label8).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label9 = Label8;
		location = new Point(123, 202);
		((Control)label9).Location = location;
		((Control)Label8).Name = "Label8";
		Label label10 = Label8;
		size = new Size(28, 29);
		((Control)label10).Size = size;
		((Control)Label8).TabIndex = 51;
		Label8.Text = "5";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label9).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.White;
		Label label11 = Label9;
		location = new Point(29, 202);
		((Control)label11).Location = location;
		((Control)Label9).Name = "Label9";
		Label label12 = Label9;
		size = new Size(28, 29);
		((Control)label12).Size = size;
		((Control)Label9).TabIndex = 50;
		Label9.Text = "4";
		Label10.AutoSize = true;
		((Control)Label10).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label10).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.White;
		Label label13 = Label10;
		location = new Point(215, 260);
		((Control)label13).Location = location;
		((Control)Label10).Name = "Label10";
		Label label14 = Label10;
		size = new Size(28, 29);
		((Control)label14).Size = size;
		((Control)Label10).TabIndex = 55;
		Label10.Text = "9";
		Label11.AutoSize = true;
		((Control)Label11).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label11).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.White;
		Label label15 = Label11;
		location = new Point(123, 260);
		((Control)label15).Location = location;
		((Control)Label11).Name = "Label11";
		Label label16 = Label11;
		size = new Size(28, 29);
		((Control)label16).Size = size;
		((Control)Label11).TabIndex = 54;
		Label11.Text = "8";
		Label12.AutoSize = true;
		((Control)Label12).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label12).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.White;
		Label label17 = Label12;
		location = new Point(29, 260);
		((Control)label17).Location = location;
		((Control)Label12).Name = "Label12";
		Label label18 = Label12;
		size = new Size(28, 29);
		((Control)label18).Size = size;
		((Control)Label12).TabIndex = 53;
		Label12.Text = "7";
		Label13.AutoSize = true;
		((Control)Label13).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label13).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.White;
		Label label19 = Label13;
		location = new Point(215, 315);
		((Control)label19).Location = location;
		((Control)Label13).Name = "Label13";
		Label label20 = Label13;
		size = new Size(34, 29);
		((Control)label20).Size = size;
		((Control)Label13).TabIndex = 58;
		Label13.Text = "=";
		Label14.AutoSize = true;
		((Control)Label14).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label14).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label21 = Label14;
		location = new Point(123, 315);
		((Control)label21).Location = location;
		((Control)Label14).Name = "Label14";
		Label label22 = Label14;
		size = new Size(28, 29);
		((Control)label22).Size = size;
		((Control)Label14).TabIndex = 57;
		Label14.Text = "0";
		Label15.AutoSize = true;
		((Control)Label15).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label15).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.White;
		Label label23 = Label15;
		location = new Point(29, 315);
		((Control)label23).Location = location;
		((Control)Label15).Name = "Label15";
		Label label24 = Label15;
		size = new Size(21, 29);
		((Control)label24).Size = size;
		((Control)Label15).TabIndex = 56;
		Label15.Text = ".";
		Label16.AutoSize = true;
		((Control)Label16).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label16).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.White;
		Label label25 = Label16;
		location = new Point(304, 260);
		((Control)label25).Location = location;
		((Control)Label16).Name = "Label16";
		Label label26 = Label16;
		size = new Size(23, 29);
		((Control)label26).Size = size;
		((Control)Label16).TabIndex = 61;
		Label16.Text = "-";
		Label17.AutoSize = true;
		((Control)Label17).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label17).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.White;
		Label label27 = Label17;
		location = new Point(304, 202);
		((Control)label27).Location = location;
		((Control)Label17).Name = "Label17";
		Label label28 = Label17;
		size = new Size(27, 29);
		((Control)label28).Size = size;
		((Control)Label17).TabIndex = 60;
		Label17.Text = "X";
		Label18.AutoSize = true;
		((Control)Label18).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label18).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.White;
		Label label29 = Label18;
		location = new Point(304, 143);
		((Control)label29).Location = location;
		((Control)Label18).Name = "Label18";
		Label label30 = Label18;
		size = new Size(34, 29);
		((Control)label30).Size = size;
		((Control)Label18).TabIndex = 59;
		Label18.Text = "+";
		Label19.AutoSize = true;
		((Control)Label19).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label19).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = Color.White;
		Label label31 = Label19;
		location = new Point(304, 315);
		((Control)label31).Location = location;
		((Control)Label19).Name = "Label19";
		Label label32 = Label19;
		size = new Size(24, 29);
		((Control)label32).Size = size;
		((Control)Label19).TabIndex = 62;
		Label19.Text = "/";
		oper.AutoSize = true;
		((Control)oper).BackColor = Color.White;
		((Control)oper).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj3 = oper;
		location = new Point(144, 9);
		((Control)obj3).Location = location;
		((Control)oper).Name = "oper";
		Label obj4 = oper;
		size = new Size(0, 20);
		((Control)obj4).Size = size;
		((Control)oper).TabIndex = 65;
		((Control)PictureBox20).BackColor = Color.White;
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox pictureBox39 = PictureBox20;
		location = new Point(-11, 90);
		((Control)pictureBox39).Location = location;
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox pictureBox40 = PictureBox20;
		size = new Size(374, 38);
		((Control)pictureBox40).Size = size;
		PictureBox20.SizeMode = (PictureBoxSizeMode)1;
		PictureBox20.TabIndex = 66;
		PictureBox20.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label2).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label33 = Label2;
		location = new Point(304, 93);
		((Control)label33).Location = location;
		((Control)Label2).Name = "Label2";
		Label label34 = Label2;
		size = new Size(31, 29);
		((Control)label34).Size = size;
		((Control)Label2).TabIndex = 70;
		Label2.Text = "C";
		((Control)off).BackColor = Color.White;
		off.Image = (Image)componentResourceManager.GetObject("off.Image");
		PictureBox obj5 = off;
		location = new Point(200, 5);
		((Control)obj5).Location = location;
		((Control)off).Name = "off";
		PictureBox obj6 = off;
		size = new Size(22, 22);
		((Control)obj6).Size = size;
		off.SizeMode = (PictureBoxSizeMode)1;
		off.TabIndex = 71;
		off.TabStop = false;
		((Control)off).Visible = false;
		((Control)onn).BackColor = Color.White;
		onn.Image = (Image)componentResourceManager.GetObject("onn.Image");
		PictureBox obj7 = onn;
		location = new Point(220, 5);
		((Control)obj7).Location = location;
		((Control)onn).Name = "onn";
		PictureBox obj8 = onn;
		size = new Size(22, 22);
		((Control)obj8).Size = size;
		onn.SizeMode = (PictureBoxSizeMode)1;
		onn.TabIndex = 72;
		onn.TabStop = false;
		((Control)onn).Visible = false;
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.FromArgb(107, 116, 173);
		((Control)Label4).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label35 = Label4;
		location = new Point(29, 143);
		((Control)label35).Location = location;
		((Control)Label4).Name = "Label4";
		Label label36 = Label4;
		size = new Size(28, 29);
		((Control)label36).Size = size;
		((Control)Label4).TabIndex = 47;
		Label4.Text = "1";
		((Control)Label3).Anchor = (AnchorStyles)3;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.Gray;
		Label label37 = Label3;
		location = new Point(6, 36);
		((Control)label37).Location = location;
		((Control)Label3).Name = "Label3";
		Label label38 = Label3;
		size = new Size(336, 22);
		((Control)label38).Size = size;
		((Control)Label3).TabIndex = 73;
		Label3.Text = "0";
		Label3.TextAlign = (ContentAlignment)64;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj9 = defaultclose;
		location = new Point(77, 0);
		((Control)obj9).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj10 = defaultclose;
		size = new Size(51, 34);
		((Control)obj10).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj11 = hoverclose;
		location = new Point(134, 0);
		((Control)obj11).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj12 = hoverclose;
		size = new Size(51, 34);
		((Control)obj12).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj13 = clickclose;
		location = new Point(191, 0);
		((Control)obj13).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj14 = clickclose;
		size = new Size(51, 34);
		((Control)obj14).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox21.Image = (Image)componentResourceManager.GetObject("PictureBox21.Image");
		PictureBox pictureBox41 = PictureBox21;
		location = new Point(252, 1);
		((Control)pictureBox41).Location = location;
		((Control)PictureBox21).Name = "PictureBox21";
		PictureBox pictureBox42 = PictureBox21;
		size = new Size(51, 34);
		((Control)pictureBox42).Size = size;
		PictureBox21.SizeMode = (PictureBoxSizeMode)2;
		PictureBox21.TabIndex = 118;
		PictureBox21.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(360, 360);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox21);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)onn);
		((Control)this).Controls.Add((Control)(object)off);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)PictureBox20);
		((Control)this).Controls.Add((Control)(object)oper);
		((Control)this).Controls.Add((Control)(object)Label19);
		((Control)this).Controls.Add((Control)(object)Label16);
		((Control)this).Controls.Add((Control)(object)Label17);
		((Control)this).Controls.Add((Control)(object)Label18);
		((Control)this).Controls.Add((Control)(object)Label13);
		((Control)this).Controls.Add((Control)(object)Label14);
		((Control)this).Controls.Add((Control)(object)Label15);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)PictureBox16);
		((Control)this).Controls.Add((Control)(object)PictureBox17);
		((Control)this).Controls.Add((Control)(object)PictureBox18);
		((Control)this).Controls.Add((Control)(object)PictureBox19);
		((Control)this).Controls.Add((Control)(object)PictureBox12);
		((Control)this).Controls.Add((Control)(object)PictureBox13);
		((Control)this).Controls.Add((Control)(object)PictureBox14);
		((Control)this).Controls.Add((Control)(object)PictureBox15);
		((Control)this).Controls.Add((Control)(object)PictureBox8);
		((Control)this).Controls.Add((Control)(object)PictureBox9);
		((Control)this).Controls.Add((Control)(object)PictureBox10);
		((Control)this).Controls.Add((Control)(object)PictureBox11);
		((Control)this).Controls.Add((Control)(object)PictureBox6);
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)text3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "calculator";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((ISupportInitialize)PictureBox14).EndInit();
		((ISupportInitialize)PictureBox15).EndInit();
		((ISupportInitialize)PictureBox16).EndInit();
		((ISupportInitialize)PictureBox17).EndInit();
		((ISupportInitialize)PictureBox18).EndInit();
		((ISupportInitialize)PictureBox19).EndInit();
		((ISupportInitialize)PictureBox20).EndInit();
		((ISupportInitialize)off).EndInit();
		((ISupportInitialize)onn).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox21).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void calculator_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.calculatorout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.calc.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void calculator_Load(object sender, EventArgs e)
	{
		if (!((Control)MyProject.Forms.home.app1).Enabled)
		{
			((Control)MyProject.Forms.home.app1).Enabled = true;
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app2).Enabled)
		{
			((Control)MyProject.Forms.home.app2).Enabled = true;
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app3).Enabled)
		{
			((Control)MyProject.Forms.home.app3).Enabled = true;
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app4).Enabled)
		{
			((Control)MyProject.Forms.home.app4).Enabled = true;
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app5).Enabled)
		{
			((Control)MyProject.Forms.home.app5).Enabled = true;
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app6).Enabled)
		{
			((Control)MyProject.Forms.home.app6).Enabled = true;
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app7).Enabled)
		{
			((Control)MyProject.Forms.home.app7).Enabled = true;
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app8).Enabled)
		{
			((Control)MyProject.Forms.home.app8).Enabled = true;
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app9).Enabled)
		{
			((Control)MyProject.Forms.home.app9).Enabled = true;
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app10).Enabled)
		{
			((Control)MyProject.Forms.home.app10).Enabled = true;
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app11).Enabled)
		{
			((Control)MyProject.Forms.home.app11).Enabled = true;
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app12).Enabled)
		{
			((Control)MyProject.Forms.home.app12).Enabled = true;
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app13).Enabled)
		{
			((Control)MyProject.Forms.home.app13).Enabled = true;
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app14).Enabled)
		{
			((Control)MyProject.Forms.home.app14).Enabled = true;
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app15).Enabled)
		{
			((Control)MyProject.Forms.home.app15).Enabled = true;
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app16).Enabled)
		{
			((Control)MyProject.Forms.home.app16).Enabled = true;
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app17).Enabled)
		{
			((Control)MyProject.Forms.home.app17).Enabled = true;
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app18).Enabled)
		{
			((Control)MyProject.Forms.home.app18).Enabled = true;
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app19).Enabled)
		{
			((Control)MyProject.Forms.home.app19).Enabled = true;
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app20).Enabled)
		{
			((Control)MyProject.Forms.home.app20).Enabled = true;
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app21).Enabled)
		{
			((Control)MyProject.Forms.home.app21).Enabled = true;
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app22).Enabled)
		{
			((Control)MyProject.Forms.home.app22).Enabled = true;
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app23).Enabled)
		{
			((Control)MyProject.Forms.home.app23).Enabled = true;
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app24).Enabled)
		{
			((Control)MyProject.Forms.home.app24).Enabled = true;
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.calc.Image;
		}
		else if (!((Control)MyProject.Forms.home.app25).Enabled)
		{
			((Control)MyProject.Forms.home.app25).Enabled = true;
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.calc.Image;
		}
		Fade.calculatorin();
	}

	private void Label4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "1";
		}
		else
		{
			text3.Text = "1";
		}
	}

	private void Label5_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "2";
		}
		else
		{
			text3.Text = "2";
		}
	}

	private void Label6_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "3";
		}
		else
		{
			text3.Text = "3";
		}
	}

	private void Label9_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "4";
		}
		else
		{
			text3.Text = "4";
		}
	}

	private void Label8_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "5";
		}
		else
		{
			text3.Text = "5";
		}
	}

	private void Label7_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "6";
		}
		else
		{
			text3.Text = "6";
		}
	}

	private void Label12_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "7";
		}
		else
		{
			text3.Text = "7";
		}
	}

	private void Label11_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "8";
		}
		else
		{
			text3.Text = "8";
		}
	}

	private void Label10_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "9";
		}
		else
		{
			text3.Text = "9";
		}
	}

	private void Label14_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "0";
		}
	}

	private void Label2_Click(object sender, EventArgs e)
	{
		text3.Text = "0";
	}

	private void Label15_Click(object sender, EventArgs e)
	{
		if (!text3.Text.Contains("."))
		{
			Label val = text3;
			val.Text += ".";
		}
	}

	private void Label18_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		Label3.Text = text3.Text;
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 1;
	}

	private void Label16_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 2;
	}

	private void Label17_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		Label3.Text = text3.Text;
		Label3.Text = text3.Text;
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 3;
	}

	private void Label19_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		Label3.Text = text3.Text;
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 4;
	}

	private void Label13_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
				case 493:
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
							goto IL_0018;
						case 4:
							goto IL_0030;
						case 5:
							goto IL_003f;
						case 7:
							goto IL_0068;
						case 8:
							goto IL_0077;
						case 10:
							goto IL_00a0;
						case 11:
							goto IL_00b0;
						case 13:
							goto IL_00d7;
						case 14:
							goto IL_00db;
						case 15:
							goto IL_00f5;
						case 16:
							goto IL_0108;
						case 18:
							goto IL_0127;
						case 19:
							goto IL_012b;
						case 6:
						case 9:
						case 12:
						case 17:
						case 20:
						case 21:
						case 22:
							goto IL_0152;
						case 23:
						case 24:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 25:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0127:
					num = 18;
					goto IL_012b;
					IL_012b:
					num = 19;
					text3.Text = Conversions.ToString(decimal.Divide(Firstnum, secondnum));
					goto IL_0152;
					IL_0108:
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Infinity";
					goto IL_0152;
					IL_0152:
					num = 22;
					Operator_Selector = false;
					break;
					IL_0009:
					num = 2;
					if (!Operator_Selector)
					{
						break;
					}
					goto IL_0018;
					IL_0018:
					num = 3;
					secondnum = Conversions.ToDecimal(text3.Text);
					goto IL_0030;
					IL_0030:
					num = 4;
					if (Operations == 1)
					{
						goto IL_003f;
					}
					goto IL_0068;
					IL_003f:
					num = 5;
					text3.Text = Conversions.ToString(decimal.Add(Firstnum, secondnum));
					goto IL_0152;
					IL_0068:
					num = 7;
					if (Operations == 2)
					{
						goto IL_0077;
					}
					goto IL_00a0;
					IL_0077:
					num = 8;
					text3.Text = Conversions.ToString(decimal.Subtract(Firstnum, secondnum));
					goto IL_0152;
					IL_00a0:
					num = 10;
					if (Operations == 3)
					{
						goto IL_00b0;
					}
					goto IL_00d7;
					IL_00b0:
					num = 11;
					text3.Text = Conversions.ToString(decimal.Multiply(Firstnum, secondnum));
					goto IL_0152;
					IL_00d7:
					num = 13;
					goto IL_00db;
					IL_00db:
					num = 14;
					if (decimal.Compare(secondnum, 0m) == 0)
					{
						goto IL_00f5;
					}
					goto IL_0127;
					IL_00f5:
					num = 15;
					((Control)MyProject.Forms.dialog).Show();
					goto IL_0108;
					end_IL_0001_2:
					break;
				}
				num = 24;
				Label3.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 493;
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

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "1";
		}
		else
		{
			text3.Text = "1";
		}
	}

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "2";
		}
		else
		{
			text3.Text = "2";
		}
	}

	private void PictureBox7_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "3";
		}
		else
		{
			text3.Text = "3";
		}
	}

	private void PictureBox11_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "4";
		}
		else
		{
			text3.Text = "4";
		}
	}

	private void PictureBox10_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "5";
		}
		else
		{
			text3.Text = "5";
		}
	}

	private void PictureBox9_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "6";
		}
		else
		{
			text3.Text = "6";
		}
	}

	private void PictureBox15_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "7";
		}
		else
		{
			text3.Text = "7";
		}
	}

	private void PictureBox14_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "8";
		}
		else
		{
			text3.Text = "8";
		}
	}

	private void PictureBox13_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "9";
		}
		else
		{
			text3.Text = "9";
		}
	}

	private void PictureBox19_Click(object sender, EventArgs e)
	{
		if (!text3.Text.Contains("."))
		{
			Label val = text3;
			val.Text += ".";
		}
	}

	private void PictureBox18_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(text3.Text, "0", false) != 0)
		{
			Label val = text3;
			val.Text += "0";
		}
	}

	private void PictureBox17_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
				case 493:
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
							goto IL_0018;
						case 4:
							goto IL_0030;
						case 5:
							goto IL_003f;
						case 7:
							goto IL_0068;
						case 8:
							goto IL_0077;
						case 10:
							goto IL_00a0;
						case 11:
							goto IL_00b0;
						case 13:
							goto IL_00d7;
						case 14:
							goto IL_00db;
						case 15:
							goto IL_00f5;
						case 16:
							goto IL_0108;
						case 18:
							goto IL_0127;
						case 19:
							goto IL_012b;
						case 6:
						case 9:
						case 12:
						case 17:
						case 20:
						case 21:
						case 22:
							goto IL_0152;
						case 23:
						case 24:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 25:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0127:
					num = 18;
					goto IL_012b;
					IL_012b:
					num = 19;
					text3.Text = Conversions.ToString(decimal.Divide(Firstnum, secondnum));
					goto IL_0152;
					IL_0108:
					num = 16;
					MyProject.Forms.dialog.Label1.Text = "Infinity";
					goto IL_0152;
					IL_0152:
					num = 22;
					Operator_Selector = false;
					break;
					IL_0009:
					num = 2;
					if (!Operator_Selector)
					{
						break;
					}
					goto IL_0018;
					IL_0018:
					num = 3;
					secondnum = Conversions.ToDecimal(text3.Text);
					goto IL_0030;
					IL_0030:
					num = 4;
					if (Operations == 1)
					{
						goto IL_003f;
					}
					goto IL_0068;
					IL_003f:
					num = 5;
					text3.Text = Conversions.ToString(decimal.Add(Firstnum, secondnum));
					goto IL_0152;
					IL_0068:
					num = 7;
					if (Operations == 2)
					{
						goto IL_0077;
					}
					goto IL_00a0;
					IL_0077:
					num = 8;
					text3.Text = Conversions.ToString(decimal.Subtract(Firstnum, secondnum));
					goto IL_0152;
					IL_00a0:
					num = 10;
					if (Operations == 3)
					{
						goto IL_00b0;
					}
					goto IL_00d7;
					IL_00b0:
					num = 11;
					text3.Text = Conversions.ToString(decimal.Multiply(Firstnum, secondnum));
					goto IL_0152;
					IL_00d7:
					num = 13;
					goto IL_00db;
					IL_00db:
					num = 14;
					if (decimal.Compare(secondnum, 0m) == 0)
					{
						goto IL_00f5;
					}
					goto IL_0127;
					IL_00f5:
					num = 15;
					((Control)MyProject.Forms.dialog).Show();
					goto IL_0108;
					end_IL_0001_2:
					break;
				}
				num = 24;
				Label3.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 493;
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

	private void PictureBox16_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		Label3.Text = text3.Text;
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 4;
	}

	private void PictureBox12_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		Label3.Text = text3.Text;
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 2;
	}

	private void PictureBox8_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		Label3.Text = text3.Text;
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 3;
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		Firstnum = Conversions.ToDecimal(text3.Text);
		Label3.Text = text3.Text;
		text3.Text = "0";
		Operator_Selector = true;
		Operations = 1;
	}

	private void PictureBox4_MouseLeave(object sender, EventArgs e)
	{
		PictureBox4.Image = off.Image;
	}

	private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox4.Image = onn.Image;
	}

	private void PictureBox5_MouseLeave(object sender, EventArgs e)
	{
		PictureBox5.Image = off.Image;
	}

	private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox5.Image = onn.Image;
	}

	private void PictureBox7_MouseLeave(object sender, EventArgs e)
	{
		PictureBox7.Image = off.Image;
	}

	private void PictureBox7_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox7.Image = onn.Image;
	}

	private void PictureBox11_MouseLeave(object sender, EventArgs e)
	{
		PictureBox11.Image = off.Image;
	}

	private void PictureBox11_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox11.Image = onn.Image;
	}

	private void PictureBox10_MouseLeave(object sender, EventArgs e)
	{
		PictureBox10.Image = off.Image;
	}

	private void PictureBox10_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox10.Image = onn.Image;
	}

	private void PictureBox9_MouseLeave(object sender, EventArgs e)
	{
		PictureBox9.Image = off.Image;
	}

	private void PictureBox9_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox9.Image = onn.Image;
	}

	private void PictureBox15_MouseLeave(object sender, EventArgs e)
	{
		PictureBox15.Image = off.Image;
	}

	private void PictureBox15_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox15.Image = onn.Image;
	}

	private void PictureBox14_MouseLeave(object sender, EventArgs e)
	{
		PictureBox14.Image = off.Image;
	}

	private void PictureBox14_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox14.Image = onn.Image;
	}

	private void PictureBox13_MouseLeave(object sender, EventArgs e)
	{
		PictureBox13.Image = off.Image;
	}

	private void PictureBox13_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox13.Image = onn.Image;
	}

	private void PictureBox19_MouseLeave(object sender, EventArgs e)
	{
		PictureBox19.Image = off.Image;
	}

	private void PictureBox19_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox19.Image = onn.Image;
	}

	private void PictureBox18_MouseLeave(object sender, EventArgs e)
	{
		PictureBox18.Image = off.Image;
	}

	private void PictureBox18_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox18.Image = onn.Image;
	}

	private void PictureBox17_MouseLeave(object sender, EventArgs e)
	{
		PictureBox17.Image = off.Image;
	}

	private void PictureBox17_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox17.Image = onn.Image;
	}

	private void PictureBox16_MouseLeave(object sender, EventArgs e)
	{
		PictureBox16.Image = off.Image;
	}

	private void PictureBox16_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox16.Image = onn.Image;
	}

	private void PictureBox12_MouseLeave(object sender, EventArgs e)
	{
		PictureBox12.Image = off.Image;
	}

	private void PictureBox12_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox12.Image = onn.Image;
	}

	private void PictureBox8_MouseLeave(object sender, EventArgs e)
	{
		PictureBox8.Image = off.Image;
	}

	private void PictureBox8_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox8.Image = onn.Image;
	}

	private void PictureBox6_MouseLeave(object sender, EventArgs e)
	{
		PictureBox6.Image = off.Image;
	}

	private void PictureBox6_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox6.Image = onn.Image;
	}

	private void PictureBox20_MouseLeave(object sender, EventArgs e)
	{
		PictureBox20.Image = off.Image;
	}

	private void PictureBox20_MouseMove(object sender, MouseEventArgs e)
	{
		PictureBox20.Image = onn.Image;
	}

	private void PictureBox20_Click(object sender, EventArgs e)
	{
		text3.Text = "0";
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void calculator_LostFocus(object sender, EventArgs e)
	{
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

	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
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

	private void PictureBox21_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	private void text3_Click(object sender, EventArgs e)
	{
	}
}
