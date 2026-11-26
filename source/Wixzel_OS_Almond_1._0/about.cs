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
public class about : Form
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

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	private Point mouse_move;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox2_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox2_MouseDown);
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).MouseDown -= val2;
				((Control)_PictureBox2).Click -= eventHandler;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).MouseDown += val2;
				((Control)_PictureBox2).Click += eventHandler;
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

	[DebuggerNonUserCode]
	public about()
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		((Control)this).GotFocus += about_GotFocus;
		((Form)this).HelpButtonClicked += about_HelpButtonClicked;
		((Form)this).Load += about_Load;
		((Control)this).LostFocus += about_LostFocus;
		((Form)this).FormClosing += new FormClosingEventHandler(about_FormClosing);
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
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_08e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ee: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ace: Expected O, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b76: Expected O, but got Unknown
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0d: Expected O, but got Unknown
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(about));
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		PictureBox4 = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Panel1 = new Panel();
		PictureBox6 = new PictureBox();
		PictureBox5 = new PictureBox();
		Label7 = new Label();
		Label6 = new Label();
		Label8 = new Label();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox7 = new PictureBox();
		Label5 = new Label();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		Point location = new Point(949, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		Size size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 8;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(37, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(127, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 7;
		Label1.Text = "About Wixzel OS";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(9, 5);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(22, 22);
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
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(758, 66);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(200, 200);
		((Control)pictureBox8).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)4;
		PictureBox4.TabIndex = 9;
		PictureBox4.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label3 = Label2;
		location = new Point(258, 127);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(169, 19);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 10;
		Label2.Text = "Wixzel OS Almond 1.0";
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label5 = Label3;
		location = new Point(258, 194);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(278, 19);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 11;
		Label3.Text = "Copyright © 2018 Wixzel Corporation";
		Label4.AutoSize = true;
		((Control)Label4).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = SystemColors.ControlDarkDark;
		Label label7 = Label4;
		location = new Point(258, 241);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(91, 19);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 12;
		Label4.Text = "Beta Edition";
		((Control)Panel1).BackColor = Color.WhiteSmoke;
		((Control)Panel1).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel1).Controls.Add((Control)(object)Label7);
		((Control)Panel1).Controls.Add((Control)(object)Label6);
		Panel panel = Panel1;
		location = new Point(0, 34);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(180, 619);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 14;
		((Control)PictureBox6).BackColor = Color.Transparent;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox9 = PictureBox6;
		location = new Point(18, 526);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox10 = PictureBox6;
		size = new Size(22, 21);
		((Control)pictureBox10).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)4;
		PictureBox6.TabIndex = 17;
		PictureBox6.TabStop = false;
		((Control)PictureBox5).BackColor = Color.Transparent;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox11 = PictureBox5;
		location = new Point(18, 569);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox12 = PictureBox5;
		size = new Size(22, 21);
		((Control)pictureBox12).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 15;
		PictureBox5.TabStop = false;
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label9 = Label7;
		location = new Point(46, 528);
		((Control)label9).Location = location;
		((Control)Label7).Name = "Label7";
		Label label10 = Label7;
		size = new Size(62, 19);
		((Control)label10).Size = size;
		((Control)Label7).TabIndex = 16;
		Label7.Text = "Settings";
		Label6.AutoSize = true;
		((Control)Label6).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label11 = Label6;
		location = new Point(46, 571);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(110, 19);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 15;
		Label6.Text = "Wixzel Update";
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.DodgerBlue;
		Label label13 = Label8;
		location = new Point(258, 66);
		((Control)label13).Location = location;
		((Control)Label8).Name = "Label8";
		Label label14 = Label8;
		size = new Size(326, 22);
		((Control)label14).Size = size;
		((Control)Label8).TabIndex = 15;
		Label8.Text = "Thankyou for choosing Wixzel OS";
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
		defaultclose.TabIndex = 116;
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
		hoverclose.TabIndex = 115;
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
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox13 = PictureBox7;
		location = new Point(892, 1);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox14 = PictureBox7;
		size = new Size(51, 34);
		((Control)pictureBox14).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 117;
		PictureBox7.TabStop = false;
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label15 = Label5;
		location = new Point(258, 160);
		((Control)label15).Location = location;
		((Control)Label5).Name = "Label5";
		Label label16 = Label5;
		size = new Size(132, 19);
		((Control)label16).Size = size;
		((Control)Label5).TabIndex = 118;
		Label5.Text = "Screen Resolution";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1000, 650);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "about";
		((Form)this).ShowInTaskbar = false;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void about_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.aboutout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.abou.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void about_GotFocus(object sender, EventArgs e)
	{
	}

	private void about_HelpButtonClicked(object sender, CancelEventArgs e)
	{
	}

	private void about_Load(object sender, EventArgs e)
	{
		checked
		{
			int num = ((Control)MyProject.Forms.home).Width - 12;
			int num2 = ((Control)MyProject.Forms.home).Height - 12;
			string text = "Screen Resolution: " + Conversions.ToString(num) + "x" + Conversions.ToString(num2);
			Label5.Text = text;
			if (!((Control)MyProject.Forms.home.app1).Enabled)
			{
				((Control)MyProject.Forms.home.app1).Enabled = true;
				MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app2).Enabled)
			{
				((Control)MyProject.Forms.home.app2).Enabled = true;
				MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app3).Enabled)
			{
				((Control)MyProject.Forms.home.app3).Enabled = true;
				MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app4).Enabled)
			{
				((Control)MyProject.Forms.home.app4).Enabled = true;
				MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app5).Enabled)
			{
				((Control)MyProject.Forms.home.app5).Enabled = true;
				MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app6).Enabled)
			{
				((Control)MyProject.Forms.home.app6).Enabled = true;
				MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app7).Enabled)
			{
				((Control)MyProject.Forms.home.app7).Enabled = true;
				MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app8).Enabled)
			{
				((Control)MyProject.Forms.home.app8).Enabled = true;
				MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app9).Enabled)
			{
				((Control)MyProject.Forms.home.app9).Enabled = true;
				MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app10).Enabled)
			{
				((Control)MyProject.Forms.home.app10).Enabled = true;
				MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app11).Enabled)
			{
				((Control)MyProject.Forms.home.app11).Enabled = true;
				MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app12).Enabled)
			{
				((Control)MyProject.Forms.home.app12).Enabled = true;
				MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app13).Enabled)
			{
				((Control)MyProject.Forms.home.app13).Enabled = true;
				MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app14).Enabled)
			{
				((Control)MyProject.Forms.home.app14).Enabled = true;
				MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app15).Enabled)
			{
				((Control)MyProject.Forms.home.app15).Enabled = true;
				MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app16).Enabled)
			{
				((Control)MyProject.Forms.home.app16).Enabled = true;
				MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app17).Enabled)
			{
				((Control)MyProject.Forms.home.app17).Enabled = true;
				MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app18).Enabled)
			{
				((Control)MyProject.Forms.home.app18).Enabled = true;
				MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app19).Enabled)
			{
				((Control)MyProject.Forms.home.app19).Enabled = true;
				MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app20).Enabled)
			{
				((Control)MyProject.Forms.home.app20).Enabled = true;
				MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app21).Enabled)
			{
				((Control)MyProject.Forms.home.app21).Enabled = true;
				MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app22).Enabled)
			{
				((Control)MyProject.Forms.home.app22).Enabled = true;
				MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app23).Enabled)
			{
				((Control)MyProject.Forms.home.app23).Enabled = true;
				MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app24).Enabled)
			{
				((Control)MyProject.Forms.home.app24).Enabled = true;
				MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.abou.Image;
			}
			else if (!((Control)MyProject.Forms.home.app25).Enabled)
			{
				((Control)MyProject.Forms.home.app25).Enabled = true;
				MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.abou.Image;
			}
			Fade.aboutin();
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
		if (((Form)this).Location.Y == ((Control)MyProject.Forms.home.PictureBox4).Location.Y)
		{
			Point location = new Point(((Form)this).Location.X, checked(((Control)MyProject.Forms.home.PictureBox4).Location.Y - 5));
			((Form)this).Location = location;
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

	private void about_LostFocus(object sender, EventArgs e)
	{
	}

	private void Label6_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.updates).Show();
	}

	private void Label7_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.settings).Show();
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.settings).Show();
	}

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.updates).Show();
	}
}
