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
public class lockscreenback : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("time")]
	private Label _time;

	[AccessedThroughProperty("powerbtn")]
	private PictureBox _powerbtn;

	[AccessedThroughProperty("timetimer")]
	private Timer _timetimer;

	internal virtual Label time
	{
		[DebuggerNonUserCode]
		get
		{
			return _time;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_time = value;
		}
	}

	internal virtual PictureBox powerbtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _powerbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox1_Click;
			if (_powerbtn != null)
			{
				((Control)_powerbtn).Click -= eventHandler;
			}
			_powerbtn = value;
			if (_powerbtn != null)
			{
				((Control)_powerbtn).Click += eventHandler;
			}
		}
	}

	internal virtual Timer timetimer
	{
		[DebuggerNonUserCode]
		get
		{
			return _timetimer;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = timetimer_Tick;
			if (_timetimer != null)
			{
				_timetimer.Tick -= eventHandler;
			}
			_timetimer = value;
			if (_timetimer != null)
			{
				_timetimer.Tick += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public lockscreenback()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		((Form)this).Load += lockscreenback_Load;
		((Control)this).Click += lockscreenback_Click;
		((Form)this).FormClosing += new FormClosingEventHandler(lockscreenback_FormClosing);
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
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(lockscreenback));
		time = new Label();
		powerbtn = new PictureBox();
		timetimer = new Timer(components);
		((ISupportInitialize)powerbtn).BeginInit();
		((Control)this).SuspendLayout();
		time.AutoSize = true;
		((Control)time).BackColor = Color.Transparent;
		((Control)time).Font = new Font("Futura Bk BT", 99.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)time).ForeColor = Color.FromArgb(254, 254, 254);
		Label obj = time;
		Point location = new Point(-22, 571);
		((Control)obj).Location = location;
		((Control)time).Name = "time";
		Label obj2 = time;
		Size size = new Size(421, 159);
		((Control)obj2).Size = size;
		((Control)time).TabIndex = 0;
		time.Text = "12:00";
		((Control)powerbtn).BackColor = Color.Transparent;
		powerbtn.Image = (Image)componentResourceManager.GetObject("powerbtn.Image");
		PictureBox obj3 = powerbtn;
		location = new Point(1258, 12);
		((Control)obj3).Location = location;
		((Control)powerbtn).Name = "powerbtn";
		PictureBox obj4 = powerbtn;
		size = new Size(90, 90);
		((Control)obj4).Size = size;
		powerbtn.SizeMode = (PictureBoxSizeMode)4;
		powerbtn.TabIndex = 1;
		powerbtn.TabStop = false;
		timetimer.Enabled = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.Gainsboro;
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		size = new Size(1360, 768);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)powerbtn);
		((Control)this).Controls.Add((Control)(object)time);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "lockscreenback";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((Form)this).TransparencyKey = Color.Transparent;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)powerbtn).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.power).Show();
	}

	private void lockscreenback_Click(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.home).Opacity = 0.0;
		((Control)MyProject.Forms.home).Show();
		((Form)MyProject.Forms.home).Opacity = 100.0;
		((Form)MyProject.Forms.home).TopMost = true;
		Fade.lockscreenbackout();
		((Control)MyProject.Forms.home).Show();
		((Control)this).Hide();
	}

	private void lockscreenback_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void lockscreenback_Load(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.int1).Opacity = 0.0;
		((Form)MyProject.Forms.int2).Opacity = 0.0;
		((Form)MyProject.Forms.int3).Opacity = 0.0;
		((Form)MyProject.Forms.int4).Opacity = 0.0;
		((Form)MyProject.Forms.int5).Opacity = 0.0;
		((Form)MyProject.Forms.int6).Opacity = 0.0;
		((Form)MyProject.Forms.int7).Opacity = 0.0;
		((Form)this).Opacity = 100.0;
		((Control)this).BackgroundImage = ((Control)MyProject.Forms.home).BackgroundImage;
		Label obj = time;
		checked
		{
			Point location = new Point(5, ((Control)this).Height - ((Control)time).Height - 10);
			((Control)obj).Location = location;
			PictureBox obj2 = powerbtn;
			location = new Point(((Control)this).Width - ((Control)powerbtn).Width, 0);
			((Control)obj2).Location = location;
		}
	}

	private void timetimer_Tick(object sender, EventArgs e)
	{
		time.Text = MyProject.Forms.home.hometime.Text;
	}
}
