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
public class winexe : Form
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

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

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

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("PictureBox16")]
	private PictureBox _PictureBox16;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("PictureBox18")]
	private PictureBox _PictureBox18;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

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
			EventHandler eventHandler = PictureBox6_Click;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).Click -= eventHandler;
			}
			_PictureBox6 = value;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).Click += eventHandler;
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
			EventHandler eventHandler = PictureBox5_Click;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click -= eventHandler;
			}
			_PictureBox5 = value;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click += eventHandler;
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
			EventHandler eventHandler = PictureBox7_Click;
			if (_PictureBox7 != null)
			{
				((Control)_PictureBox7).Click -= eventHandler;
			}
			_PictureBox7 = value;
			if (_PictureBox7 != null)
			{
				((Control)_PictureBox7).Click += eventHandler;
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
			EventHandler eventHandler = PictureBox8_Click;
			if (_PictureBox8 != null)
			{
				((Control)_PictureBox8).Click -= eventHandler;
			}
			_PictureBox8 = value;
			if (_PictureBox8 != null)
			{
				((Control)_PictureBox8).Click += eventHandler;
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
			_Label6 = value;
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
			EventHandler eventHandler = PictureBox9_Click;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click -= eventHandler;
			}
			_PictureBox9 = value;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click += eventHandler;
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
			_PictureBox10 = value;
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
			EventHandler eventHandler = PictureBox11_Click;
			if (_PictureBox11 != null)
			{
				((Control)_PictureBox11).Click -= eventHandler;
			}
			_PictureBox11 = value;
			if (_PictureBox11 != null)
			{
				((Control)_PictureBox11).Click += eventHandler;
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
			_PictureBox12 = value;
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
			_Label11 = value;
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
			_Label12 = value;
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

	[DebuggerNonUserCode]
	public winexe()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(winexe_FormClosing);
		((Form)this).Load += winexe_Load;
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
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0618: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected O, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected O, but got Unknown
		//IL_09d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected O, but got Unknown
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		//IL_0b40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4a: Expected O, but got Unknown
		//IL_0be5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bef: Expected O, but got Unknown
		//IL_0c99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected O, but got Unknown
		//IL_0d46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d50: Expected O, but got Unknown
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected O, but got Unknown
		//IL_0e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Expected O, but got Unknown
		//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Expected O, but got Unknown
		//IL_0ff4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ffe: Expected O, but got Unknown
		//IL_1099: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a3: Expected O, but got Unknown
		//IL_1135: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Expected O, but got Unknown
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11de: Expected O, but got Unknown
		//IL_1282: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Expected O, but got Unknown
		//IL_1335: Unknown result type (might be due to invalid IL or missing references)
		//IL_133f: Expected O, but got Unknown
		//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f5: Expected O, but got Unknown
		//IL_1492: Unknown result type (might be due to invalid IL or missing references)
		//IL_149c: Expected O, but got Unknown
		//IL_1549: Unknown result type (might be due to invalid IL or missing references)
		//IL_1553: Expected O, but got Unknown
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1616: Expected O, but got Unknown
		//IL_16bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c7: Expected O, but got Unknown
		//IL_1765: Unknown result type (might be due to invalid IL or missing references)
		//IL_176f: Expected O, but got Unknown
		//IL_1811: Unknown result type (might be due to invalid IL or missing references)
		//IL_181b: Expected O, but got Unknown
		//IL_18bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c7: Expected O, but got Unknown
		//IL_1965: Unknown result type (might be due to invalid IL or missing references)
		//IL_196f: Expected O, but got Unknown
		//IL_1a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a17: Expected O, but got Unknown
		//IL_1aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aae: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(winexe));
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		Panel1 = new Panel();
		Label3 = new Label();
		Label2 = new Label();
		PictureBox4 = new PictureBox();
		Panel2 = new Panel();
		PictureBox6 = new PictureBox();
		PictureBox5 = new PictureBox();
		Label4 = new Label();
		Label5 = new Label();
		PictureBox7 = new PictureBox();
		PictureBox8 = new PictureBox();
		Label6 = new Label();
		PictureBox9 = new PictureBox();
		PictureBox10 = new PictureBox();
		Label7 = new Label();
		PictureBox11 = new PictureBox();
		PictureBox12 = new PictureBox();
		PictureBox13 = new PictureBox();
		PictureBox14 = new PictureBox();
		PictureBox15 = new PictureBox();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		PictureBox16 = new PictureBox();
		Label11 = new Label();
		Label12 = new Label();
		PictureBox17 = new PictureBox();
		PictureBox18 = new PictureBox();
		PictureBox19 = new PictureBox();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox20 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
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
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox20).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(0, 0);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(1400, 35);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(949, 1);
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
		location = new Point(7, 6);
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
		location = new Point(38, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(60, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 4;
		Label1.Text = "Winexe";
		((Control)Panel1).BackColor = Color.RoyalBlue;
		((Control)Panel1).Controls.Add((Control)(object)Label3);
		((Control)Panel1).Controls.Add((Control)(object)Label2);
		Panel panel = Panel1;
		location = new Point(220, 34);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(780, 166);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 5;
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.RoyalBlue;
		((Control)Label3).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label3 = Label3;
		location = new Point(83, 92);
		((Control)label3).Location = location;
		((Control)Label3).Name = "Label3";
		Label label4 = Label3;
		size = new Size(689, 29);
		((Control)label4).Size = size;
		((Control)Label3).TabIndex = 8;
		Label3.Text = "Run Windows System Apps and Installed Apps in Wixzel OS";
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.RoyalBlue;
		((Control)Label2).Font = new Font("Futura Bk BT", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label5 = Label2;
		location = new Point(270, 15);
		((Control)label5).Location = location;
		((Control)Label2).Name = "Label2";
		Label label6 = Label2;
		size = new Size(232, 45);
		((Control)label6).Size = size;
		((Control)Label2).TabIndex = 7;
		Label2.Text = "Winexe v1.0";
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(52, 15);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(128, 128);
		((Control)pictureBox8).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 6;
		PictureBox4.TabStop = false;
		((Control)Panel2).BackColor = Color.White;
		((Control)Panel2).Controls.Add((Control)(object)PictureBox4);
		Panel panel3 = Panel2;
		location = new Point(0, 34);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(223, 166);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 6;
		((Control)PictureBox6).BackColor = Color.White;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox9 = PictureBox6;
		location = new Point(79, 351);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox10 = PictureBox6;
		size = new Size(180, 180);
		((Control)pictureBox10).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)1;
		PictureBox6.TabIndex = 8;
		PictureBox6.TabStop = false;
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox11 = PictureBox5;
		location = new Point(105, 375);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox12 = PictureBox5;
		size = new Size(128, 128);
		((Control)pictureBox12).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)1;
		PictureBox5.TabIndex = 9;
		PictureBox5.TabStop = false;
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.White;
		((Control)Label4).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.FromArgb(35, 35, 35);
		Label label7 = Label4;
		location = new Point(99, 538);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(155, 29);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 9;
		Label4.Text = "System Apps";
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.White;
		((Control)Label5).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.FromArgb(35, 35, 35);
		Label label9 = Label5;
		location = new Point(306, 538);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(174, 29);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 12;
		Label5.Text = "Installed Apps";
		((Control)PictureBox7).BackColor = Color.White;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox13 = PictureBox7;
		location = new Point(319, 375);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox14 = PictureBox7;
		size = new Size(128, 128);
		((Control)pictureBox14).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)1;
		PictureBox7.TabIndex = 11;
		PictureBox7.TabStop = false;
		((Control)PictureBox8).BackColor = Color.White;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox15 = PictureBox8;
		location = new Point(293, 351);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox16 = PictureBox8;
		size = new Size(180, 180);
		((Control)pictureBox16).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)1;
		PictureBox8.TabIndex = 10;
		PictureBox8.TabStop = false;
		Label6.AutoSize = true;
		((Control)Label6).BackColor = Color.White;
		((Control)Label6).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.FromArgb(35, 35, 35);
		Label label11 = Label6;
		location = new Point(790, 538);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(55, 29);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 18;
		Label6.Text = "Run";
		((Control)PictureBox9).BackColor = Color.White;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox17 = PictureBox9;
		location = new Point(750, 375);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox18 = PictureBox9;
		size = new Size(128, 128);
		((Control)pictureBox18).Size = size;
		PictureBox9.SizeMode = (PictureBoxSizeMode)1;
		PictureBox9.TabIndex = 17;
		PictureBox9.TabStop = false;
		((Control)PictureBox10).BackColor = Color.White;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox19 = PictureBox10;
		location = new Point(724, 351);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox20 = PictureBox10;
		size = new Size(180, 180);
		((Control)pictureBox20).Size = size;
		PictureBox10.SizeMode = (PictureBoxSizeMode)1;
		PictureBox10.TabIndex = 16;
		PictureBox10.TabStop = false;
		Label7.AutoSize = true;
		((Control)Label7).BackColor = Color.White;
		((Control)Label7).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.FromArgb(35, 35, 35);
		Label label13 = Label7;
		location = new Point(502, 538);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(217, 29);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 14;
		Label7.Text = "Windows Explorer";
		((Control)PictureBox11).BackColor = Color.White;
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox pictureBox21 = PictureBox11;
		location = new Point(536, 375);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox pictureBox22 = PictureBox11;
		size = new Size(128, 128);
		((Control)pictureBox22).Size = size;
		PictureBox11.SizeMode = (PictureBoxSizeMode)1;
		PictureBox11.TabIndex = 15;
		PictureBox11.TabStop = false;
		((Control)PictureBox12).BackColor = Color.White;
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox23 = PictureBox12;
		location = new Point(510, 351);
		((Control)pictureBox23).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox24 = PictureBox12;
		size = new Size(180, 180);
		((Control)pictureBox24).Size = size;
		PictureBox12.SizeMode = (PictureBoxSizeMode)1;
		PictureBox12.TabIndex = 13;
		PictureBox12.TabStop = false;
		((Control)PictureBox13).BackColor = Color.White;
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox25 = PictureBox13;
		location = new Point(12, 604);
		((Control)pictureBox25).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox26 = PictureBox13;
		size = new Size(102, 34);
		((Control)pictureBox26).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)2;
		PictureBox13.TabIndex = 19;
		PictureBox13.TabStop = false;
		((Control)PictureBox14).BackColor = Color.White;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox27 = PictureBox14;
		location = new Point(886, 604);
		((Control)pictureBox27).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox28 = PictureBox14;
		size = new Size(102, 34);
		((Control)pictureBox28).Size = size;
		PictureBox14.SizeMode = (PictureBoxSizeMode)2;
		PictureBox14.TabIndex = 20;
		PictureBox14.TabStop = false;
		((Control)PictureBox15).BackColor = Color.White;
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox pictureBox29 = PictureBox15;
		location = new Point(778, 604);
		((Control)pictureBox29).Location = location;
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox pictureBox30 = PictureBox15;
		size = new Size(102, 34);
		((Control)pictureBox30).Size = size;
		PictureBox15.SizeMode = (PictureBoxSizeMode)2;
		PictureBox15.TabIndex = 21;
		PictureBox15.TabStop = false;
		Label8.AutoSize = true;
		((Control)Label8).BackColor = Color.White;
		((Control)Label8).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.RoyalBlue;
		Label label15 = Label8;
		location = new Point(33, 611);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(63, 19);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 22;
		Label8.Text = "CLOSE";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.White;
		((Control)Label9).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.RoyalBlue;
		Label label17 = Label9;
		location = new Point(788, 611);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(86, 19);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 23;
		Label9.Text = "SETTINGS";
		Label10.AutoSize = true;
		((Control)Label10).BackColor = Color.White;
		((Control)Label10).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.RoyalBlue;
		Label label19 = Label10;
		location = new Point(903, 611);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(67, 19);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 24;
		Label10.Text = "ABOUT";
		((Control)PictureBox16).BackColor = Color.White;
		PictureBox16.Image = (Image)componentResourceManager.GetObject("PictureBox16.Image");
		PictureBox pictureBox31 = PictureBox16;
		location = new Point(7, 206);
		((Control)pictureBox31).Location = location;
		((Control)PictureBox16).Name = "PictureBox16";
		PictureBox pictureBox32 = PictureBox16;
		size = new Size(64, 64);
		((Control)pictureBox32).Size = size;
		PictureBox16.SizeMode = (PictureBoxSizeMode)1;
		PictureBox16.TabIndex = 25;
		PictureBox16.TabStop = false;
		((Control)PictureBox16).Visible = false;
		Label11.AutoSize = true;
		((Control)Label11).BackColor = Color.White;
		((Control)Label11).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.RoyalBlue;
		Label label21 = Label11;
		location = new Point(77, 224);
		((Control)label21).Location = location;
		((Control)Label11).Name = "Label11";
		Label label22 = Label11;
		size = new Size(194, 29);
		((Control)label22).Size = size;
		((Control)Label11).TabIndex = 26;
		Label11.Text = "Favourites Apps";
		((Control)Label11).Visible = false;
		Label12.AutoSize = true;
		((Control)Label12).BackColor = Color.White;
		((Control)Label12).Font = new Font("Futura Bk BT", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.RoyalBlue;
		Label label23 = Label12;
		location = new Point(77, 294);
		((Control)label23).Location = location;
		((Control)Label12).Name = "Label12";
		Label label24 = Label12;
		size = new Size(75, 29);
		((Control)label24).Size = size;
		((Control)Label12).TabIndex = 28;
		Label12.Text = "Menu";
		((Control)Label12).Visible = false;
		((Control)PictureBox17).BackColor = Color.White;
		PictureBox17.Image = (Image)componentResourceManager.GetObject("PictureBox17.Image");
		PictureBox pictureBox33 = PictureBox17;
		location = new Point(7, 276);
		((Control)pictureBox33).Location = location;
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox pictureBox34 = PictureBox17;
		size = new Size(64, 64);
		((Control)pictureBox34).Size = size;
		PictureBox17.SizeMode = (PictureBoxSizeMode)1;
		PictureBox17.TabIndex = 27;
		PictureBox17.TabStop = false;
		((Control)PictureBox17).Visible = false;
		((Control)PictureBox18).BackColor = Color.White;
		PictureBox18.Image = (Image)componentResourceManager.GetObject("PictureBox18.Image");
		PictureBox pictureBox35 = PictureBox18;
		location = new Point(265, 237);
		((Control)pictureBox35).Location = location;
		((Control)PictureBox18).Name = "PictureBox18";
		PictureBox pictureBox36 = PictureBox18;
		size = new Size(10, 10);
		((Control)pictureBox36).Size = size;
		PictureBox18.SizeMode = (PictureBoxSizeMode)2;
		PictureBox18.TabIndex = 29;
		PictureBox18.TabStop = false;
		((Control)PictureBox18).Visible = false;
		((Control)PictureBox19).BackColor = Color.White;
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox pictureBox37 = PictureBox19;
		location = new Point(265, 305);
		((Control)pictureBox37).Location = location;
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox pictureBox38 = PictureBox19;
		size = new Size(10, 10);
		((Control)pictureBox38).Size = size;
		PictureBox19.SizeMode = (PictureBoxSizeMode)2;
		PictureBox19.TabIndex = 30;
		PictureBox19.TabStop = false;
		((Control)PictureBox19).Visible = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj = defaultclose;
		location = new Point(772, 0);
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
		location = new Point(829, 0);
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
		location = new Point(886, 0);
		((Control)obj5).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj6 = clickclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox pictureBox39 = PictureBox20;
		location = new Point(892, 1);
		((Control)pictureBox39).Location = location;
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox pictureBox40 = PictureBox20;
		size = new Size(51, 34);
		((Control)pictureBox40).Size = size;
		PictureBox20.SizeMode = (PictureBoxSizeMode)2;
		PictureBox20.TabIndex = 118;
		PictureBox20.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1000, 650);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox20);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)PictureBox19);
		((Control)this).Controls.Add((Control)(object)PictureBox18);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)PictureBox17);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)PictureBox16);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)PictureBox15);
		((Control)this).Controls.Add((Control)(object)PictureBox14);
		((Control)this).Controls.Add((Control)(object)PictureBox13);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)PictureBox9);
		((Control)this).Controls.Add((Control)(object)PictureBox10);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)PictureBox11);
		((Control)this).Controls.Add((Control)(object)PictureBox12);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)PictureBox8);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)PictureBox6);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "winexe";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
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
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox20).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void PictureBox11_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.winexestandby).Show();
		((Control)MyProject.Forms.home).Hide();
		((Control)this).Hide();
		Process.Start(MyProject.Forms.datacontrolroom.main.Text + "\\Windows\\explorer.exe");
	}

	private void winexe_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.winexeout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.wine.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void winexe_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = PictureBox2;
		checked
		{
			Point location = new Point(((Control)this).Width - ((Control)PictureBox2).Width, 0);
			((Control)pictureBox).Location = location;
			PictureBox pictureBox2 = PictureBox20;
			Point location2 = new Point(((Control)PictureBox2).Location.X - ((Control)PictureBox20).Width, ((Control)PictureBox2).Location.Y);
			((Control)pictureBox2).Location = location2;
			if (!((Control)MyProject.Forms.home.app1).Enabled)
			{
				((Control)MyProject.Forms.home.app1).Enabled = true;
				MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app2).Enabled)
			{
				((Control)MyProject.Forms.home.app2).Enabled = true;
				MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app3).Enabled)
			{
				((Control)MyProject.Forms.home.app3).Enabled = true;
				MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app4).Enabled)
			{
				((Control)MyProject.Forms.home.app4).Enabled = true;
				MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app5).Enabled)
			{
				((Control)MyProject.Forms.home.app5).Enabled = true;
				MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app6).Enabled)
			{
				((Control)MyProject.Forms.home.app6).Enabled = true;
				MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app7).Enabled)
			{
				((Control)MyProject.Forms.home.app7).Enabled = true;
				MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app8).Enabled)
			{
				((Control)MyProject.Forms.home.app8).Enabled = true;
				MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app9).Enabled)
			{
				((Control)MyProject.Forms.home.app9).Enabled = true;
				MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app10).Enabled)
			{
				((Control)MyProject.Forms.home.app10).Enabled = true;
				MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app11).Enabled)
			{
				((Control)MyProject.Forms.home.app11).Enabled = true;
				MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app12).Enabled)
			{
				((Control)MyProject.Forms.home.app12).Enabled = true;
				MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app13).Enabled)
			{
				((Control)MyProject.Forms.home.app13).Enabled = true;
				MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app14).Enabled)
			{
				((Control)MyProject.Forms.home.app14).Enabled = true;
				MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app15).Enabled)
			{
				((Control)MyProject.Forms.home.app15).Enabled = true;
				MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app16).Enabled)
			{
				((Control)MyProject.Forms.home.app16).Enabled = true;
				MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app17).Enabled)
			{
				((Control)MyProject.Forms.home.app17).Enabled = true;
				MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app18).Enabled)
			{
				((Control)MyProject.Forms.home.app18).Enabled = true;
				MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app19).Enabled)
			{
				((Control)MyProject.Forms.home.app19).Enabled = true;
				MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app20).Enabled)
			{
				((Control)MyProject.Forms.home.app20).Enabled = true;
				MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app21).Enabled)
			{
				((Control)MyProject.Forms.home.app21).Enabled = true;
				MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app22).Enabled)
			{
				((Control)MyProject.Forms.home.app22).Enabled = true;
				MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app23).Enabled)
			{
				((Control)MyProject.Forms.home.app23).Enabled = true;
				MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app24).Enabled)
			{
				((Control)MyProject.Forms.home.app24).Enabled = true;
				MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.wine.Image;
			}
			else if (!((Control)MyProject.Forms.home.app25).Enabled)
			{
				((Control)MyProject.Forms.home.app25).Enabled = true;
				MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.wine.Image;
			}
			Fade.winexein();
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

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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

	private void Label9_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "Settings will update soon via Wixzel Update";
	}

	private void Label10_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.appsabout).Show();
	}

	private void Label8_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "...will update soon via Wixzel Update";
	}

	private void Label4_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "...will update soon via Wixzel Update";
	}

	private void PictureBox7_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "...will update soon via Wixzel Update";
	}

	private void PictureBox8_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "...will update soon via Wixzel Update";
	}

	private void PictureBox9_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.winexestandby).Show();
		((Control)MyProject.Forms.home).Hide();
		((Control)this).Hide();
		Process.Start(MyProject.Forms.datacontrolroom.main.Text + "\\windows\\system32\\rundll32.exe shell32.dll,#61");
	}
}
