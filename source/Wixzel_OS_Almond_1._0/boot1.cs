using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class boot1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

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

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Timer2 = value;
		}
	}

	[DebuggerNonUserCode]
	public boot1()
	{
		((Form)this).Load += boot1_Load;
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
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(boot1));
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(291, 701);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(260, 73);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		PictureBox1.WaitOnLoad = true;
		Timer1.Enabled = true;
		Timer1.Interval = 14000;
		Timer2.Enabled = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.FromArgb(32, 32, 32);
		size = new Size(1612, 912);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "boot1";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.binary.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.bubblero.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.greenmix.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.mirax.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.orange.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.pinkero.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.vibgyor.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.wixzeld.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.wixzeldb.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.wixzelpro.Image;
		}
		else if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file"))
		{
			((Control)MyProject.Forms.home).BackgroundImage = MyProject.Forms.wallpapers.wixzelprob.Image;
		}
		((Form)MyProject.Forms.power).Opacity = 0.0;
		((Control)MyProject.Forms.power).Show();
		((Control)MyProject.Forms.power).Hide();
		((Form)MyProject.Forms.home).Opacity = 0.0;
		((Form)MyProject.Forms.home).TopMost = true;
		((Control)MyProject.Forms.home).Show();
		((Form)MyProject.Forms.lockscreenback).Opacity = 0.0;
		((Form)MyProject.Forms.lockscreenback).TopMost = true;
		((Control)MyProject.Forms.lockscreenback).Show();
		((Form)MyProject.Forms.home).Opacity = 100.0;
		((Form)MyProject.Forms.power).Opacity = 100.0;
		MyProject.Forms.homeicondata.Label2.Text = "notvis";
		((Control)MyProject.Forms.homemenu).Hide();
		if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "notvis", false) == 0)
		{
			((Control)MyProject.Forms.menuwxl).Show();
			((Form)MyProject.Forms.menuwxl).TopMost = true;
			MyProject.Forms.home.PictureBox2.Image = MyProject.Forms.home.ImageList1.Images[2];
			MyProject.Forms.homeicondata.Label1.Text = "vis";
		}
		else if (Operators.CompareString(MyProject.Forms.homeicondata.Label1.Text, "vis", false) == 0)
		{
			((Control)MyProject.Forms.menuwxl).Hide();
			MyProject.Forms.home.PictureBox2.Image = MyProject.Forms.home.ImageList1.Images[0];
			MyProject.Forms.homeicondata.Label1.Text = "notvis";
		}
		((Control)this).Hide();
		Timer1.Enabled = false;
	}

	private void boot1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		StreamReader streamReader = default(StreamReader);
		string path = default(string);
		int top = default(int);
		string path2 = default(string);
		StreamReader streamReader2 = default(StreamReader);
		string path3 = default(string);
		StreamReader streamReader3 = default(StreamReader);
		int left = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				PictureBox pictureBox;
				Point location;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					((Form)this).TopMost = false;
					goto IL_000c;
				case 514:
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
							goto IL_000c;
						case 3:
							goto IL_002f;
						case 4:
							goto IL_003a;
						case 5:
							goto IL_0058;
						case 6:
							goto IL_0062;
						case 7:
							goto IL_00ca;
						case 8:
							goto IL_00d3;
						case 9:
							goto IL_00f6;
						case 10:
							goto IL_0102;
						case 11:
							goto IL_0112;
						case 12:
							goto IL_012c;
						case 13:
							goto IL_0137;
						case 14:
							goto IL_015b;
						case 15:
							goto IL_0168;
						case 16:
							goto IL_0179;
						case 17:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 18:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_015b:
					num = 14;
					streamReader = new StreamReader(path);
					goto IL_0168;
					IL_0168:
					num = 15;
					top = Conversions.ToInteger(streamReader.ReadToEnd());
					goto IL_0179;
					IL_0137:
					num = 13;
					path = MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locy.file";
					goto IL_015b;
					IL_0179:
					num = 16;
					((Control)MyProject.Forms.home.item1).Top = top;
					break;
					IL_000c:
					num = 2;
					path2 = MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file";
					goto IL_002f;
					IL_002f:
					num = 3;
					streamReader2 = new StreamReader(path2);
					goto IL_003a;
					IL_003a:
					num = 4;
					MyProject.Forms.menuwxl.Label5.Text = streamReader2.ReadToEnd();
					goto IL_0058;
					IL_0058:
					num = 5;
					streamReader2.Close();
					goto IL_0062;
					IL_0062:
					num = 6;
					pictureBox = PictureBox1;
					location = checked(new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)PictureBox1).Width / 2.0), (int)Math.Round((double)((Control)this).Height / 2.0 - 50.0)));
					((Control)pictureBox).Location = location;
					goto IL_00ca;
					IL_00ca:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_00d3;
					IL_00d3:
					num = 8;
					path3 = MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locx.file";
					goto IL_00f6;
					IL_00f6:
					num = 9;
					streamReader3 = new StreamReader(path3);
					goto IL_0102;
					IL_0102:
					num = 10;
					left = Conversions.ToInteger(streamReader3.ReadToEnd());
					goto IL_0112;
					IL_0112:
					num = 11;
					((Control)MyProject.Forms.home.item1).Left = left;
					goto IL_012c;
					IL_012c:
					num = 12;
					streamReader3.Close();
					goto IL_0137;
					end_IL_0001_2:
					break;
				}
				num = 17;
				streamReader.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 514;
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

	private void Label1_Click(object sender, EventArgs e)
	{
	}
}
