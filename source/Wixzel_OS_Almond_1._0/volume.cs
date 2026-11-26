using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class volume : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("full")]
	private PictureBox _full;

	[AccessedThroughProperty("med")]
	private PictureBox _med;

	[AccessedThroughProperty("low")]
	private PictureBox _low;

	[AccessedThroughProperty("mute")]
	private PictureBox _mute;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	private const int APPCOMMAND_VOLUME_MUTE = 524288;

	private const int APPCOMMAND_VOLUME_UP = 655360;

	private const int APPCOMMAND_VOLUME_DOWN = 589824;

	private const int WM_APPCOMMAND = 793;

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

	internal virtual PictureBox full
	{
		[DebuggerNonUserCode]
		get
		{
			return _full;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_full = value;
		}
	}

	internal virtual PictureBox med
	{
		[DebuggerNonUserCode]
		get
		{
			return _med;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_med = value;
		}
	}

	internal virtual PictureBox low
	{
		[DebuggerNonUserCode]
		get
		{
			return _low;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_low = value;
		}
	}

	internal virtual PictureBox mute
	{
		[DebuggerNonUserCode]
		get
		{
			return _mute;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mute = value;
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
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click -= eventHandler;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click += eventHandler;
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

	[DebuggerNonUserCode]
	public volume()
	{
		((Form)this).Load += volume_Load;
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
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_044b: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(volume));
		PictureBox1 = new PictureBox();
		full = new PictureBox();
		med = new PictureBox();
		low = new PictureBox();
		mute = new PictureBox();
		PictureBox2 = new PictureBox();
		Timer1 = new Timer(components);
		PictureBox3 = new PictureBox();
		Label4 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)full).BeginInit();
		((ISupportInitialize)med).BeginInit();
		((ISupportInitialize)low).BeginInit();
		((ISupportInitialize)mute).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(-4, -4);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(60, 60);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		full.Image = (Image)componentResourceManager.GetObject("full.Image");
		PictureBox obj = full;
		location = new Point(62, 44);
		((Control)obj).Location = location;
		((Control)full).Name = "full";
		PictureBox obj2 = full;
		size = new Size(19, 21);
		((Control)obj2).Size = size;
		full.SizeMode = (PictureBoxSizeMode)1;
		full.TabIndex = 1;
		full.TabStop = false;
		med.Image = (Image)componentResourceManager.GetObject("med.Image");
		PictureBox obj3 = med;
		location = new Point(87, 44);
		((Control)obj3).Location = location;
		((Control)med).Name = "med";
		PictureBox obj4 = med;
		size = new Size(19, 21);
		((Control)obj4).Size = size;
		med.SizeMode = (PictureBoxSizeMode)1;
		med.TabIndex = 2;
		med.TabStop = false;
		low.Image = (Image)componentResourceManager.GetObject("low.Image");
		PictureBox obj5 = low;
		location = new Point(112, 44);
		((Control)obj5).Location = location;
		((Control)low).Name = "low";
		PictureBox obj6 = low;
		size = new Size(19, 21);
		((Control)obj6).Size = size;
		low.SizeMode = (PictureBoxSizeMode)1;
		low.TabIndex = 3;
		low.TabStop = false;
		mute.Image = (Image)componentResourceManager.GetObject("mute.Image");
		PictureBox obj7 = mute;
		location = new Point(137, 44);
		((Control)obj7).Location = location;
		((Control)mute).Name = "mute";
		PictureBox obj8 = mute;
		size = new Size(19, 21);
		((Control)obj8).Size = size;
		mute.SizeMode = (PictureBoxSizeMode)1;
		mute.TabIndex = 4;
		mute.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(46, -4);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(60, 60);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 5;
		PictureBox2.TabStop = false;
		Timer1.Enabled = true;
		Timer1.Interval = 1;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(132, -4);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(60, 60);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 6;
		PictureBox3.TabStop = false;
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.White;
		((Control)Label4).Font = new Font("Futura-Medium", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.Black;
		Label label = Label4;
		location = new Point(97, 16);
		((Control)label).Location = location;
		((Control)Label4).Name = "Label4";
		Label label2 = Label4;
		size = new Size(43, 24);
		((Control)label2).Size = size;
		((Control)Label4).TabIndex = 32;
		Label4.Text = "100";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(204, 54);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)mute);
		((Control)this).Controls.Add((Control)(object)low);
		((Control)this).Controls.Add((Control)(object)med);
		((Control)this).Controls.Add((Control)(object)full);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "volume";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)full).EndInit();
		((ISupportInitialize)med).EndInit();
		((ISupportInitialize)low).EndInit();
		((ISupportInitialize)mute).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetAsyncKeyState(long vKey);

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		IntPtr handle = ((Control)this).Handle;
		IntPtr handle2 = ((Control)this).Handle;
		IntPtr lParam = new IntPtr(655360);
		SendMessageW(handle, 793, handle2, lParam);
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		IntPtr handle = ((Control)this).Handle;
		IntPtr handle2 = ((Control)this).Handle;
		IntPtr lParam = new IntPtr(589824);
		SendMessageW(handle, 793, handle2, lParam);
	}

	private void volume_Load(object sender, EventArgs e)
	{
	}
}
