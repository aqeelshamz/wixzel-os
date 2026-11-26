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
public class int7 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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

	[DebuggerNonUserCode]
	public int7()
	{
		((Form)this).Load += int7_Load;
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(int7));
		PictureBox1 = new PictureBox();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).BackColor = Color.Transparent;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(216, 399);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(913, 16);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 1;
		PictureBox1.TabStop = false;
		Timer1.Enabled = true;
		Timer1.Interval = 5000;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		size = new Size(1360, 768);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).DoubleBuffered = true;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "int7";
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
		((Control)MyProject.Forms.boot1).Show();
		Timer1.Enabled = false;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void int7_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		int height = default(int);
		int width = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		int num5 = default(int);
		StreamWriter streamWriter2 = default(StreamWriter);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					num = 1;
					PictureBox pictureBox = PictureBox1;
					Point location = checked(new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)PictureBox1).Width / 2.0), (int)Math.Round((double)((Control)this).Height / 2.0 + 50.0)));
					((Control)pictureBox).Location = location;
					goto IL_0069;
				}
				case 643:
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
							goto IL_0069;
						case 3:
							goto IL_009f;
						case 4:
						case 5:
							goto IL_00d1;
						case 6:
							goto IL_0103;
						case 7:
							goto IL_0112;
						case 8:
							goto IL_011c;
						case 9:
							goto IL_0125;
						case 10:
							goto IL_012f;
						case 11:
							goto IL_015c;
						case 12:
							goto IL_016c;
						case 13:
							goto IL_019f;
						case 14:
							goto IL_01af;
						case 15:
							goto IL_01ba;
						case 16:
							goto IL_01d2;
						case 17:
							goto IL_01eb;
						case 18:
							goto IL_01f7;
						case 19:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 20:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_01d2:
					num = 16;
					height = Screen.PrimaryScreen.Bounds.Height;
					goto IL_01eb;
					IL_01eb:
					num = 17;
					((Control)this).Width = width;
					goto IL_01f7;
					IL_01ba:
					num = 15;
					width = Screen.PrimaryScreen.Bounds.Width;
					goto IL_01d2;
					IL_01f7:
					num = 18;
					((Control)this).Height = height;
					break;
					IL_0069:
					num = 2;
					if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\boot.data.file"))
					{
						goto IL_009f;
					}
					goto IL_00d1;
					IL_009f:
					num = 3;
					((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\boot.data.file");
					goto IL_00d1;
					IL_00d1:
					num = 5;
					streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\boot.data.file", true);
					goto IL_0103;
					IL_0103:
					num = 6;
					streamWriter.WriteLine("</boot>");
					goto IL_0112;
					IL_0112:
					num = 7;
					streamWriter.Close();
					goto IL_011c;
					IL_011c:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0125;
					IL_0125:
					num = 9;
					num5 = FileSystem.FreeFile();
					goto IL_012f;
					IL_012f:
					num = 10;
					FileSystem.FileOpen(num5, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data.file", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_015c;
					IL_015c:
					num = 11;
					FileSystem.FileClose(new int[0]);
					goto IL_016c;
					IL_016c:
					num = 12;
					streamWriter2 = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data.file", true);
					goto IL_019f;
					IL_019f:
					num = 13;
					streamWriter2.WriteLine("mirax");
					goto IL_01af;
					IL_01af:
					num = 14;
					streamWriter2.Close();
					goto IL_01ba;
					end_IL_0001_2:
					break;
				}
				num = 19;
				((Control)MyProject.Forms.int6).Hide();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 643;
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
