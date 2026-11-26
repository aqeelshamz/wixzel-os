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
using Microsoft.VisualBasic.Devices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class updates : Form
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

	[AccessedThroughProperty("updateimg")]
	private PictureBox _updateimg;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("checkdate")]
	private Label _checkdate;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("updatelink")]
	private Label _updatelink;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("downloadbtn")]
	private PictureBox _downloadbtn;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	internal virtual PictureBox updateimg
	{
		[DebuggerNonUserCode]
		get
		{
			return _updateimg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_updateimg = value;
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

	internal virtual Label checkdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _checkdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_checkdate = value;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(defaultclose_MouseMove);
			EventHandler eventHandler = defaultclose_Click;
			if (_defaultclose != null)
			{
				((Control)_defaultclose).MouseMove -= val;
				((Control)_defaultclose).Click -= eventHandler;
			}
			_defaultclose = value;
			if (_defaultclose != null)
			{
				((Control)_defaultclose).MouseMove += val;
				((Control)_defaultclose).Click += eventHandler;
			}
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

	internal virtual Label updatelink
	{
		[DebuggerNonUserCode]
		get
		{
			return _updatelink;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_updatelink = value;
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

	internal virtual PictureBox downloadbtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _downloadbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = downloadbtn_Click;
			if (_downloadbtn != null)
			{
				((Control)_downloadbtn).Click -= eventHandler;
			}
			_downloadbtn = value;
			if (_downloadbtn != null)
			{
				((Control)_downloadbtn).Click += eventHandler;
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
			EventHandler eventHandler = Timer1_Tick_1;
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

	[DebuggerNonUserCode]
	public updates()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).FormClosed += new FormClosedEventHandler(updates_FormClosed);
		((Form)this).FormClosing += new FormClosingEventHandler(updates_FormClosing);
		((Form)this).Load += updates_Load;
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
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected O, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_095a: Expected O, but got Unknown
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected O, but got Unknown
		//IL_0b20: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2a: Expected O, but got Unknown
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected O, but got Unknown
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(updates));
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		updateimg = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		checkdate = new Label();
		Label7 = new Label();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox7 = new PictureBox();
		updatelink = new Label();
		PictureBox4 = new PictureBox();
		Label8 = new Label();
		downloadbtn = new PictureBox();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)updateimg).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)downloadbtn).BeginInit();
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
		size = new Size(117, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 7;
		Label1.Text = "Wixzel Updates";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(9, 6);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(22, 21);
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
		size = new Size(1400, 35);
		((Control)pictureBox6).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 5;
		PictureBox1.TabStop = false;
		updateimg.Image = (Image)componentResourceManager.GetObject("updateimg.Image");
		PictureBox obj = updateimg;
		location = new Point(0, 33);
		((Control)obj).Location = location;
		((Control)updateimg).Name = "updateimg";
		PictureBox obj2 = updateimg;
		size = new Size(1000, 220);
		((Control)obj2).Size = size;
		updateimg.SizeMode = (PictureBoxSizeMode)2;
		updateimg.TabIndex = 9;
		updateimg.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label3 = Label2;
		location = new Point(29, 334);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(179, 22);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 10;
		Label2.Text = "Current Version : ";
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label5 = Label3;
		location = new Point(205, 334);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(202, 22);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 11;
		Label3.Text = "Wixzel OS Almond 1.0";
		Label4.AutoSize = true;
		((Control)Label4).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label7 = Label4;
		location = new Point(410, 334);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(64, 22);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 12;
		Label4.Text = "(2018)";
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label9 = Label5;
		location = new Point(29, 380);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(193, 22);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 13;
		Label5.Text = "Last Checked On  :";
		checkdate.AutoSize = true;
		((Control)checkdate).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj3 = checkdate;
		location = new Point(205, 380);
		((Control)obj3).Location = location;
		((Control)checkdate).Name = "checkdate";
		Label obj4 = checkdate;
		size = new Size(28, 22);
		((Control)obj4).Size = size;
		((Control)checkdate).TabIndex = 14;
		checkdate.Text = "...";
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label11 = Label7;
		location = new Point(29, 432);
		((Control)label11).Location = location;
		((Control)Label7).Name = "Label7";
		Label label12 = Label7;
		size = new Size(224, 22);
		((Control)label12).Size = size;
		((Control)Label7).TabIndex = 15;
		Label7.Text = "Commander Version : ";
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj5 = defaultclose;
		location = new Point(784, 0);
		((Control)obj5).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj6 = defaultclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj7 = hoverclose;
		location = new Point(841, 0);
		((Control)obj7).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj8 = hoverclose;
		size = new Size(51, 34);
		((Control)obj8).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj9 = clickclose;
		location = new Point(898, 0);
		((Control)obj9).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj10 = clickclose;
		size = new Size(51, 34);
		((Control)obj10).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox7 = PictureBox7;
		location = new Point(898, 1);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox8 = PictureBox7;
		size = new Size(51, 34);
		((Control)pictureBox8).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 118;
		PictureBox7.TabStop = false;
		updatelink.AutoSize = true;
		((Control)updatelink).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj11 = updatelink;
		location = new Point(29, 475);
		((Control)obj11).Location = location;
		((Control)updatelink).Name = "updatelink";
		Label obj12 = updatelink;
		size = new Size(25, 24);
		((Control)obj12).Size = size;
		((Control)updatelink).TabIndex = 119;
		updatelink.Text = "...";
		((Control)updatelink).Visible = false;
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox9 = PictureBox4;
		location = new Point(31, 272);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox10 = PictureBox4;
		size = new Size(208, 37);
		((Control)pictureBox10).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)1;
		PictureBox4.TabIndex = 120;
		PictureBox4.TabStop = false;
		Label8.AutoSize = true;
		((Control)Label8).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.RoyalBlue;
		Label label13 = Label8;
		location = new Point(49, 281);
		((Control)label13).Location = location;
		((Control)Label8).Name = "Label8";
		Label label14 = Label8;
		size = new Size(169, 19);
		((Control)label14).Size = size;
		((Control)Label8).TabIndex = 121;
		Label8.Text = "CHECK FOR UPDATES";
		((Control)downloadbtn).BackColor = Color.White;
		downloadbtn.Image = (Image)componentResourceManager.GetObject("downloadbtn.Image");
		PictureBox obj13 = downloadbtn;
		location = new Point(265, 270);
		((Control)obj13).Location = location;
		((Control)downloadbtn).Name = "downloadbtn";
		PictureBox obj14 = downloadbtn;
		size = new Size(170, 39);
		((Control)obj14).Size = size;
		downloadbtn.SizeMode = (PictureBoxSizeMode)2;
		downloadbtn.TabIndex = 122;
		downloadbtn.TabStop = false;
		((Control)downloadbtn).Visible = false;
		Timer1.Enabled = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1000, 650);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)downloadbtn);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)updatelink);
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)checkdate);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)updateimg);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "updates";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)updateimg).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)downloadbtn).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void updates_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void updates_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.updatesout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.upda.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void updates_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = PictureBox3;
		checked
		{
			Point location = new Point(((Control)this).Width - ((Control)PictureBox3).Width, 0);
			((Control)pictureBox).Location = location;
			PictureBox pictureBox2 = PictureBox7;
			Point location2 = new Point(((Control)PictureBox3).Location.X - ((Control)PictureBox7).Width, ((Control)PictureBox3).Location.Y);
			((Control)pictureBox2).Location = location2;
			if (!((Control)MyProject.Forms.home.app1).Enabled)
			{
				((Control)MyProject.Forms.home.app1).Enabled = true;
				MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app2).Enabled)
			{
				((Control)MyProject.Forms.home.app2).Enabled = true;
				MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app3).Enabled)
			{
				((Control)MyProject.Forms.home.app3).Enabled = true;
				MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app4).Enabled)
			{
				((Control)MyProject.Forms.home.app4).Enabled = true;
				MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app5).Enabled)
			{
				((Control)MyProject.Forms.home.app5).Enabled = true;
				MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app6).Enabled)
			{
				((Control)MyProject.Forms.home.app6).Enabled = true;
				MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app7).Enabled)
			{
				((Control)MyProject.Forms.home.app7).Enabled = true;
				MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app8).Enabled)
			{
				((Control)MyProject.Forms.home.app8).Enabled = true;
				MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app9).Enabled)
			{
				((Control)MyProject.Forms.home.app9).Enabled = true;
				MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app10).Enabled)
			{
				((Control)MyProject.Forms.home.app10).Enabled = true;
				MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app11).Enabled)
			{
				((Control)MyProject.Forms.home.app11).Enabled = true;
				MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app12).Enabled)
			{
				((Control)MyProject.Forms.home.app12).Enabled = true;
				MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app13).Enabled)
			{
				((Control)MyProject.Forms.home.app13).Enabled = true;
				MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app14).Enabled)
			{
				((Control)MyProject.Forms.home.app14).Enabled = true;
				MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app15).Enabled)
			{
				((Control)MyProject.Forms.home.app15).Enabled = true;
				MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app16).Enabled)
			{
				((Control)MyProject.Forms.home.app16).Enabled = true;
				MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app17).Enabled)
			{
				((Control)MyProject.Forms.home.app17).Enabled = true;
				MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app18).Enabled)
			{
				((Control)MyProject.Forms.home.app18).Enabled = true;
				MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app19).Enabled)
			{
				((Control)MyProject.Forms.home.app19).Enabled = true;
				MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app20).Enabled)
			{
				((Control)MyProject.Forms.home.app20).Enabled = true;
				MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app21).Enabled)
			{
				((Control)MyProject.Forms.home.app21).Enabled = true;
				MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app22).Enabled)
			{
				((Control)MyProject.Forms.home.app22).Enabled = true;
				MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app23).Enabled)
			{
				((Control)MyProject.Forms.home.app23).Enabled = true;
				MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app24).Enabled)
			{
				((Control)MyProject.Forms.home.app24).Enabled = true;
				MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.upda.Image;
			}
			else if (!((Control)MyProject.Forms.home.app25).Enabled)
			{
				((Control)MyProject.Forms.home.app25).Enabled = true;
				MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.upda.Image;
			}
			Fade.updatesin();
			if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\date.data.file"))
			{
				string path = MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\date.data.file";
				StreamReader streamReader = new StreamReader(path);
				checkdate.Text = streamReader.ReadToEnd();
				streamReader.Close();
			}
			if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updimg.png"))
			{
				updateimg.ImageLocation = MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updimg.png";
			}
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Form)this).Text = ((Form)this).Location.ToString();
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

	private void defaultclose_Click(object sender, EventArgs e)
	{
	}

	private void defaultclose_MouseMove(object sender, MouseEventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Label8_Click(object sender, EventArgs e)
	{
		Label8.Text = "CHECKING...";
		if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updimg.png"))
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updimg.png");
		}
		if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updadd.txt"))
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updadd.txt");
		}
		((ServerComputer)MyProject.Computer).Network.DownloadFile("https://wxlupddata.weebly.com/uploads/1/1/9/5/119516668/1_orig.png", MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updimg.png");
		((ServerComputer)MyProject.Computer).Network.DownloadFile("https://wxlupddata.weebly.com/uploads/1/1/9/5/119516668/link.txt", MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updadd.txt");
		checkdate.Text = Strings.Format((object)DateAndTime.Now, "dd/MM/yyy");
		Label8.Text = "CHECK FOR UPDATES";
		((Control)this).Refresh();
		updateimg.ImageLocation = MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updimg.png";
		string path = MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\updadd.txt";
		StreamReader streamReader = new StreamReader(path);
		updatelink.Text = streamReader.ReadToEnd();
		streamReader.Close();
		if (Operators.CompareString(checkdate.Text, "...", false) != 0)
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(num, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\date.data.file", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.FileClose(new int[0]);
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0\\date.data.file", true);
		streamWriter.WriteLine(checkdate.Text);
		streamWriter.Close();
		if (Operators.CompareString(updatelink.Text, "...", false) == 0)
		{
			((Control)downloadbtn).Visible = false;
		}
		else
		{
			((Control)downloadbtn).Visible = true;
		}
	}

	private void downloadbtn_Click(object sender, EventArgs e)
	{
		MyProject.Forms.logoffwindow.Label1.Text = "Preparing to Download Updates";
		((Control)MyProject.Forms.logoffwindow).Show();
	}

	private void Timer1_Tick_1(object sender, EventArgs e)
	{
		if (Operators.CompareString(updatelink.Text, "...", false) == 0)
		{
			((Control)downloadbtn).Visible = false;
		}
		else
		{
			((Control)downloadbtn).Visible = true;
		}
	}
}
