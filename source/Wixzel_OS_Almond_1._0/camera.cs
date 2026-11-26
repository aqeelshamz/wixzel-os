using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class camera : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBoxx1")]
	private PictureBox _PictureBoxx1;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("button2")]
	private PictureBox _button2;

	[AccessedThroughProperty("PictureBoxx2")]
	private PictureBox _PictureBoxx2;

	[AccessedThroughProperty("SaveFileDialog1")]
	private SaveFileDialog _SaveFileDialog1;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	private Point mouse_move;

	private VideoCaptureDevice CAMERA;

	private Bitmap bmp;

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
			_Timer1 = value;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label1_MouseDown);
			EventHandler eventHandler = Label1_Click;
			MouseEventHandler val2 = new MouseEventHandler(Label1_MouseMove);
			if (_Label1 != null)
			{
				((Control)_Label1).MouseDown -= val;
				((Control)_Label1).Click -= eventHandler;
				((Control)_Label1).MouseMove -= val2;
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).MouseDown += val;
				((Control)_Label1).Click += eventHandler;
				((Control)_Label1).MouseMove += val2;
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

	internal virtual PictureBox PictureBoxx1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBoxx1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBoxx1_Click;
			if (_PictureBoxx1 != null)
			{
				((Control)_PictureBoxx1).Click -= eventHandler;
			}
			_PictureBoxx1 = value;
			if (_PictureBoxx1 != null)
			{
				((Control)_PictureBoxx1).Click += eventHandler;
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

	internal virtual PictureBox button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = button2_Click;
			if (_button2 != null)
			{
				((Control)_button2).Click -= eventHandler;
			}
			_button2 = value;
			if (_button2 != null)
			{
				((Control)_button2).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBoxx2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBoxx2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBoxx2 = value;
		}
	}

	internal virtual SaveFileDialog SaveFileDialog1
	{
		[DebuggerNonUserCode]
		get
		{
			return _SaveFileDialog1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_SaveFileDialog1 = value;
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
	public camera()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(camera_FormClosing);
		((Form)this).Load += camera_Load;
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
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(camera));
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		PictureBox2 = new PictureBox();
		Label1 = new Label();
		PictureBox3 = new PictureBox();
		PictureBoxx1 = new PictureBox();
		PictureBox5 = new PictureBox();
		button2 = new PictureBox();
		PictureBoxx2 = new PictureBox();
		SaveFileDialog1 = new SaveFileDialog();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox7 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBoxx1).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)button2).BeginInit();
		((ISupportInitialize)PictureBoxx2).BeginInit();
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
		PictureBox1.TabIndex = 1;
		PictureBox1.TabStop = false;
		Timer1.Interval = 1;
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(9, 8);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(22, 17);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 2;
		PictureBox2.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(37, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(67, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 3;
		Label1.Text = "Camera";
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(949, 1);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(51, 34);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 4;
		PictureBox3.TabStop = false;
		PictureBox pictureBoxx = PictureBoxx1;
		location = new Point(0, 33);
		((Control)pictureBoxx).Location = location;
		((Control)PictureBoxx1).Name = "PictureBoxx1";
		PictureBox pictureBoxx2 = PictureBoxx1;
		size = new Size(826, 617);
		((Control)pictureBoxx2).Size = size;
		PictureBoxx1.SizeMode = (PictureBoxSizeMode)1;
		PictureBoxx1.TabIndex = 5;
		PictureBoxx1.TabStop = false;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox7 = PictureBox5;
		location = new Point(824, 33);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox8 = PictureBox5;
		size = new Size(176, 688);
		((Control)pictureBox8).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 6;
		PictureBox5.TabStop = false;
		((Control)button2).BackColor = Color.RoyalBlue;
		((Control)button2).BackgroundImage = (Image)componentResourceManager.GetObject("button2.BackgroundImage");
		button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
		PictureBox obj = button2;
		location = new Point(874, 287);
		((Control)obj).Location = location;
		((Control)button2).Name = "button2";
		PictureBox obj2 = button2;
		size = new Size(85, 85);
		((Control)obj2).Size = size;
		button2.SizeMode = (PictureBoxSizeMode)2;
		button2.TabIndex = 7;
		button2.TabStop = false;
		PictureBox pictureBoxx3 = PictureBoxx2;
		location = new Point(874, 535);
		((Control)pictureBoxx3).Location = location;
		((Control)PictureBoxx2).Name = "PictureBoxx2";
		PictureBox pictureBoxx4 = PictureBoxx2;
		size = new Size(85, 78);
		((Control)pictureBoxx4).Size = size;
		PictureBoxx2.SizeMode = (PictureBoxSizeMode)1;
		PictureBoxx2.TabIndex = 8;
		PictureBoxx2.TabStop = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj3 = defaultclose;
		location = new Point(159, 0);
		((Control)obj3).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj4 = defaultclose;
		size = new Size(51, 34);
		((Control)obj4).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj5 = hoverclose;
		location = new Point(216, 0);
		((Control)obj5).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj6 = hoverclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj7 = clickclose;
		location = new Point(273, 0);
		((Control)obj7).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj8 = clickclose;
		size = new Size(51, 34);
		((Control)obj8).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox9 = PictureBox7;
		location = new Point(892, 1);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox10 = PictureBox7;
		size = new Size(51, 33);
		((Control)pictureBox10).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)1;
		PictureBox7.TabIndex = 118;
		PictureBox7.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1000, 650);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)PictureBoxx2);
		((Control)this).Controls.Add((Control)(object)button2);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)PictureBoxx1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "camera";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBoxx1).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)button2).EndInit();
		((ISupportInitialize)PictureBoxx2).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void camera_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.cameraout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.came.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void camera_Load(object sender, EventArgs e)
	{
		if (!((Control)MyProject.Forms.home.app1).Enabled)
		{
			((Control)MyProject.Forms.home.app1).Enabled = true;
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app2).Enabled)
		{
			((Control)MyProject.Forms.home.app2).Enabled = true;
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app3).Enabled)
		{
			((Control)MyProject.Forms.home.app3).Enabled = true;
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app4).Enabled)
		{
			((Control)MyProject.Forms.home.app4).Enabled = true;
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app5).Enabled)
		{
			((Control)MyProject.Forms.home.app5).Enabled = true;
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app6).Enabled)
		{
			((Control)MyProject.Forms.home.app6).Enabled = true;
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app7).Enabled)
		{
			((Control)MyProject.Forms.home.app7).Enabled = true;
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app8).Enabled)
		{
			((Control)MyProject.Forms.home.app8).Enabled = true;
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app9).Enabled)
		{
			((Control)MyProject.Forms.home.app9).Enabled = true;
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app10).Enabled)
		{
			((Control)MyProject.Forms.home.app10).Enabled = true;
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app11).Enabled)
		{
			((Control)MyProject.Forms.home.app11).Enabled = true;
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app12).Enabled)
		{
			((Control)MyProject.Forms.home.app12).Enabled = true;
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app13).Enabled)
		{
			((Control)MyProject.Forms.home.app13).Enabled = true;
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app14).Enabled)
		{
			((Control)MyProject.Forms.home.app14).Enabled = true;
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app15).Enabled)
		{
			((Control)MyProject.Forms.home.app15).Enabled = true;
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app16).Enabled)
		{
			((Control)MyProject.Forms.home.app16).Enabled = true;
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app17).Enabled)
		{
			((Control)MyProject.Forms.home.app17).Enabled = true;
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app18).Enabled)
		{
			((Control)MyProject.Forms.home.app18).Enabled = true;
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app19).Enabled)
		{
			((Control)MyProject.Forms.home.app19).Enabled = true;
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app20).Enabled)
		{
			((Control)MyProject.Forms.home.app20).Enabled = true;
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app21).Enabled)
		{
			((Control)MyProject.Forms.home.app21).Enabled = true;
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app22).Enabled)
		{
			((Control)MyProject.Forms.home.app22).Enabled = true;
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app23).Enabled)
		{
			((Control)MyProject.Forms.home.app23).Enabled = true;
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app24).Enabled)
		{
			((Control)MyProject.Forms.home.app24).Enabled = true;
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.came.Image;
		}
		else if (!((Control)MyProject.Forms.home.app25).Enabled)
		{
			((Control)MyProject.Forms.home.app25).Enabled = true;
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.came.Image;
		}
		Fade.camerain();
	}

	private void Captured(object sender, NewFrameEventArgs eventArgs)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
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
				case 100:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 4:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					bmp = (Bitmap)((Image)eventArgs.Frame).Clone();
					break;
					end_IL_0001_2:
					break;
				}
				num = 3;
				PictureBoxx1.Image = (Image)(Bitmap)((Image)eventArgs.Frame).Clone();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 100;
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

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
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
				case 129:
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
							goto IL_0017;
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
					((CommonDialog)SaveFileDialog1).ShowDialog();
					goto IL_0017;
					IL_0017:
					num = 3;
					PictureBoxx2.Image = PictureBoxx1.Image;
					break;
					end_IL_0001_2:
					break;
				}
				num = 4;
				PictureBoxx2.Image.Save(((FileDialog)SaveFileDialog1).FileName + ".png");
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 129;
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

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void PictureBoxx1_Click(object sender, EventArgs e)
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
