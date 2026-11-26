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
public class logoffwindow : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("anim")]
	private PictureBox _anim;

	[AccessedThroughProperty("caption")]
	private Label _caption;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	internal virtual PictureBox anim
	{
		[DebuggerNonUserCode]
		get
		{
			return _anim;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_anim = value;
		}
	}

	internal virtual Label caption
	{
		[DebuggerNonUserCode]
		get
		{
			return _caption;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_caption = value;
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
			_Label1 = value;
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
			EventHandler eventHandler = Timer2_Tick;
			if (_Timer2 != null)
			{
				_Timer2.Tick -= eventHandler;
			}
			_Timer2 = value;
			if (_Timer2 != null)
			{
				_Timer2.Tick += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public logoffwindow()
	{
		((Form)this).Load += logoffwindow_Load;
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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(logoffwindow));
		anim = new PictureBox();
		caption = new Label();
		Label1 = new Label();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		((ISupportInitialize)anim).BeginInit();
		((Control)this).SuspendLayout();
		anim.Image = (Image)componentResourceManager.GetObject("anim.Image");
		PictureBox obj = anim;
		Point location = new Point(314, 314);
		((Control)obj).Location = location;
		((Control)anim).Name = "anim";
		PictureBox obj2 = anim;
		Size size = new Size(100, 25);
		((Control)obj2).Size = size;
		anim.SizeMode = (PictureBoxSizeMode)2;
		anim.TabIndex = 137;
		anim.TabStop = false;
		((Control)caption).Anchor = (AnchorStyles)0;
		((Control)caption).BackColor = Color.Transparent;
		((Control)caption).Font = new Font("Futura Bk BT", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)caption).ForeColor = Color.White;
		Label obj3 = caption;
		location = new Point(227, 235);
		((Control)obj3).Location = location;
		((Control)caption).Name = "caption";
		Label obj4 = caption;
		size = new Size(276, 76);
		((Control)obj4).Size = size;
		((Control)caption).TabIndex = 138;
		caption.Text = "Saving Data";
		caption.TextAlign = (ContentAlignment)32;
		((Control)Label1).Anchor = (AnchorStyles)0;
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Futura Bk BT", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.White;
		Label label = Label1;
		location = new Point(237, 41);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(276, 37);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 139;
		Label1.Text = "Saving Data";
		Label1.TextAlign = (ContentAlignment)32;
		((Control)Label1).Visible = false;
		Timer1.Interval = 5000;
		Timer2.Interval = 3000;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.FromArgb(51, 51, 51);
		size = new Size(785, 675);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)caption);
		((Control)this).Controls.Add((Control)(object)anim);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "logoffwindow";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)anim).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void logoffwindow_Load(object sender, EventArgs e)
	{
		Label obj = caption;
		checked
		{
			Point location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)caption).Width / 2.0 - 10.0), (int)Math.Round((double)((Control)this).Height / 2.0 - 50.0));
			((Control)obj).Location = location;
			PictureBox obj2 = anim;
			Point location2 = new Point(((Control)caption).Location.X + ((Control)anim).Width - 15, ((Control)caption).Location.Y + ((Control)caption).Height + ((Control)anim).Height);
			((Control)obj2).Location = location2;
			if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locx.file"))
			{
				int num = FileSystem.FreeFile();
				FileSystem.FileOpen(num, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locx.file", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FileClose(new int[0]);
			}
			StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locx.file", true);
			streamWriter.WriteLine(((Control)MyProject.Forms.home.item1).Location.X.ToString());
			streamWriter.Close();
			if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locy.file"))
			{
				int num2 = FileSystem.FreeFile();
				FileSystem.FileOpen(num2, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locy.file", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FileClose(new int[0]);
			}
			StreamWriter streamWriter2 = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\item1.locy.file", true);
			streamWriter2.WriteLine(((Control)MyProject.Forms.home.item1).Location.Y.ToString());
			streamWriter2.Close();
			Timer1.Enabled = true;
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		caption.Text = Label1.Text;
		Timer2.Enabled = true;
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Timer2_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(caption.Text, "Shutting down", false) == 0)
		{
			ProjectData.EndApp();
		}
		else if (Operators.CompareString(caption.Text, "Restarting", false) == 0)
		{
			((Form)MyProject.Forms.power).Opacity = 0.0;
			((Form)MyProject.Forms.about).Opacity = 0.0;
			((Form)MyProject.Forms.alarmdata).Opacity = 0.0;
			((Form)MyProject.Forms.apps).Opacity = 0.0;
			((Form)MyProject.Forms.appsabout).Opacity = 0.0;
			((Form)MyProject.Forms.boot1).Opacity = 0.0;
			((Form)MyProject.Forms.calculator).Opacity = 0.0;
			((Form)MyProject.Forms.calendar).Opacity = 0.0;
			((Form)MyProject.Forms.camera).Opacity = 0.0;
			((Form)MyProject.Forms.clock).Opacity = 0.0;
			((Form)MyProject.Forms.commander).Opacity = 0.0;
			((Form)MyProject.Forms.deskdate).Opacity = 0.0;
			((Form)MyProject.Forms.desknet).Opacity = 0.0;
			((Form)MyProject.Forms.desktime).Opacity = 0.0;
			((Form)MyProject.Forms.dialog).Opacity = 0.0;
			((Form)MyProject.Forms.diskmanagement).Opacity = 0.0;
			((Form)MyProject.Forms.files).Opacity = 0.0;
			((Form)MyProject.Forms.home).Opacity = 0.0;
			((Form)MyProject.Forms.homeicondata).Opacity = 0.0;
			((Form)MyProject.Forms.homeitemdata).Opacity = 0.0;
			((Form)MyProject.Forms.homemenu).Opacity = 0.0;
			((Form)MyProject.Forms.int1).Opacity = 0.0;
			((Form)MyProject.Forms.int2).Opacity = 0.0;
			((Form)MyProject.Forms.int3).Opacity = 0.0;
			((Form)MyProject.Forms.int4).Opacity = 0.0;
			((Form)MyProject.Forms.int5).Opacity = 0.0;
			((Form)MyProject.Forms.int6).Opacity = 0.0;
			((Form)MyProject.Forms.int7).Opacity = 0.0;
			((Form)MyProject.Forms.lockscreenback).Opacity = 0.0;
			((Form)MyProject.Forms.mediaplayer).Opacity = 0.0;
			((Form)MyProject.Forms.meebrowser).Opacity = 0.0;
			((Form)MyProject.Forms.meemail).Opacity = 0.0;
			((Form)MyProject.Forms.meemail2).Opacity = 0.0;
			((Form)MyProject.Forms.meemail3).Opacity = 0.0;
			((Form)MyProject.Forms.ncode).Opacity = 0.0;
			((Form)MyProject.Forms.menuwxl).Opacity = 0.0;
			((Form)MyProject.Forms.openapps).Opacity = 0.0;
			((Form)MyProject.Forms.paintain).Opacity = 0.0;
			((Form)MyProject.Forms.password).Opacity = 0.0;
			((Form)MyProject.Forms.resdialog).Opacity = 0.0;
			((Form)MyProject.Forms.screenlit).Opacity = 0.0;
			((Form)MyProject.Forms.screenshot).Opacity = 0.0;
			((Form)MyProject.Forms.setalarm).Opacity = 0.0;
			((Form)MyProject.Forms.settingalarm).Opacity = 0.0;
			((Form)MyProject.Forms.settinglockscreen).Opacity = 0.0;
			((Form)MyProject.Forms.settingapps).Opacity = 0.0;
			((Form)MyProject.Forms.settingprofile).Opacity = 0.0;
			((Form)MyProject.Forms.settings).Opacity = 0.0;
			((Form)MyProject.Forms.settingsdata).Opacity = 0.0;
			((Form)MyProject.Forms.settingsecurity).Opacity = 0.0;
			((Form)MyProject.Forms.taskshow).Opacity = 0.0;
			((Form)MyProject.Forms.tts).Opacity = 0.0;
			((Form)MyProject.Forms.updates).Opacity = 0.0;
			((Form)MyProject.Forms.vboard).Opacity = 0.0;
			((Form)MyProject.Forms.volume).Opacity = 0.0;
			((Form)MyProject.Forms.wallpapers).Opacity = 0.0;
			((Form)MyProject.Forms.weather).Opacity = 0.0;
			((Form)MyProject.Forms.winexestandby).Opacity = 0.0;
			((Form)MyProject.Forms.wordpro).Opacity = 0.0;
			((Form)MyProject.Forms.wordprodata).Opacity = 0.0;
			((Control)MyProject.Forms.power).Hide();
			((Control)MyProject.Forms.about).Hide();
			((Control)MyProject.Forms.alarmdata).Hide();
			((Control)MyProject.Forms.apps).Hide();
			((Control)MyProject.Forms.appsabout).Hide();
			((Control)MyProject.Forms.calculator).Hide();
			((Control)MyProject.Forms.calendar).Hide();
			((Control)MyProject.Forms.camera).Hide();
			((Control)MyProject.Forms.clock).Hide();
			((Control)MyProject.Forms.commander).Hide();
			((Control)MyProject.Forms.deskdate).Hide();
			((Control)MyProject.Forms.desknet).Hide();
			((Control)MyProject.Forms.desktime).Hide();
			((Control)MyProject.Forms.dialog).Hide();
			((Control)MyProject.Forms.diskmanagement).Hide();
			((Control)MyProject.Forms.files).Hide();
			((Control)MyProject.Forms.home).Hide();
			((Control)MyProject.Forms.homeicondata).Hide();
			((Control)MyProject.Forms.homeitemdata).Hide();
			((Control)MyProject.Forms.homemenu).Hide();
			((Control)MyProject.Forms.lockscreenback).Hide();
			((Control)MyProject.Forms.mediaplayer).Hide();
			((Control)MyProject.Forms.meebrowser).Hide();
			((Control)MyProject.Forms.meemail).Hide();
			((Control)MyProject.Forms.meemail2).Hide();
			((Control)MyProject.Forms.meemail3).Hide();
			((Control)MyProject.Forms.ncode).Hide();
			((Control)MyProject.Forms.menuwxl).Hide();
			((Control)MyProject.Forms.openapps).Hide();
			((Control)MyProject.Forms.paintain).Hide();
			((Control)MyProject.Forms.password).Hide();
			((Control)MyProject.Forms.resdialog).Hide();
			((Control)MyProject.Forms.screenlit).Hide();
			((Control)MyProject.Forms.screenshot).Hide();
			((Control)MyProject.Forms.setalarm).Hide();
			((Control)MyProject.Forms.settingalarm).Hide();
			((Control)MyProject.Forms.settinglockscreen).Hide();
			((Control)MyProject.Forms.settingapps).Hide();
			((Control)MyProject.Forms.settingprofile).Hide();
			((Control)MyProject.Forms.settings).Hide();
			((Control)MyProject.Forms.settingsdata).Hide();
			((Control)MyProject.Forms.settingsecurity).Hide();
			((Control)MyProject.Forms.taskshow).Hide();
			((Control)MyProject.Forms.tts).Hide();
			((Control)MyProject.Forms.updates).Hide();
			((Control)MyProject.Forms.vboard).Hide();
			((Control)MyProject.Forms.volume).Hide();
			((Control)MyProject.Forms.wallpapers).Hide();
			((Control)MyProject.Forms.weather).Hide();
			((Control)MyProject.Forms.winexestandby).Hide();
			((Control)MyProject.Forms.wordpro).Hide();
			((Control)MyProject.Forms.wordprodata).Hide();
			((Form)MyProject.Forms.power).Opacity = 100.0;
			((Form)MyProject.Forms.about).Opacity = 100.0;
			((Form)MyProject.Forms.alarmdata).Opacity = 100.0;
			((Form)MyProject.Forms.apps).Opacity = 100.0;
			((Form)MyProject.Forms.appsabout).Opacity = 100.0;
			((Form)MyProject.Forms.calculator).Opacity = 100.0;
			((Form)MyProject.Forms.calendar).Opacity = 100.0;
			((Form)MyProject.Forms.camera).Opacity = 100.0;
			((Form)MyProject.Forms.clock).Opacity = 100.0;
			((Form)MyProject.Forms.commander).Opacity = 100.0;
			((Form)MyProject.Forms.deskdate).Opacity = 100.0;
			((Form)MyProject.Forms.desknet).Opacity = 100.0;
			((Form)MyProject.Forms.desktime).Opacity = 100.0;
			((Form)MyProject.Forms.dialog).Opacity = 100.0;
			((Form)MyProject.Forms.diskmanagement).Opacity = 100.0;
			((Form)MyProject.Forms.files).Opacity = 100.0;
			((Form)MyProject.Forms.home).Opacity = 100.0;
			((Form)MyProject.Forms.homeicondata).Opacity = 100.0;
			((Form)MyProject.Forms.homeitemdata).Opacity = 100.0;
			((Form)MyProject.Forms.homemenu).Opacity = 100.0;
			((Form)MyProject.Forms.lockscreenback).Opacity = 100.0;
			((Form)MyProject.Forms.mediaplayer).Opacity = 100.0;
			((Form)MyProject.Forms.meebrowser).Opacity = 100.0;
			((Form)MyProject.Forms.meemail).Opacity = 100.0;
			((Form)MyProject.Forms.meemail2).Opacity = 100.0;
			((Form)MyProject.Forms.meemail3).Opacity = 100.0;
			((Form)MyProject.Forms.ncode).Opacity = 100.0;
			((Form)MyProject.Forms.menuwxl).Opacity = 100.0;
			((Form)MyProject.Forms.openapps).Opacity = 100.0;
			((Form)MyProject.Forms.paintain).Opacity = 100.0;
			((Form)MyProject.Forms.password).Opacity = 100.0;
			((Form)MyProject.Forms.resdialog).Opacity = 100.0;
			((Form)MyProject.Forms.screenlit).Opacity = 100.0;
			((Form)MyProject.Forms.screenshot).Opacity = 100.0;
			((Form)MyProject.Forms.setalarm).Opacity = 100.0;
			((Form)MyProject.Forms.settingalarm).Opacity = 100.0;
			((Form)MyProject.Forms.settinglockscreen).Opacity = 100.0;
			((Form)MyProject.Forms.settingapps).Opacity = 100.0;
			((Form)MyProject.Forms.settingprofile).Opacity = 100.0;
			((Form)MyProject.Forms.settings).Opacity = 100.0;
			((Form)MyProject.Forms.settingsdata).Opacity = 100.0;
			((Form)MyProject.Forms.settingsecurity).Opacity = 100.0;
			((Form)MyProject.Forms.taskshow).Opacity = 100.0;
			((Form)MyProject.Forms.tts).Opacity = 100.0;
			((Form)MyProject.Forms.updates).Opacity = 100.0;
			((Form)MyProject.Forms.vboard).Opacity = 100.0;
			((Form)MyProject.Forms.volume).Opacity = 100.0;
			((Form)MyProject.Forms.wallpapers).Opacity = 100.0;
			((Form)MyProject.Forms.weather).Opacity = 100.0;
			((Form)MyProject.Forms.winexestandby).Opacity = 100.0;
			((Form)MyProject.Forms.wordpro).Opacity = 100.0;
			((Form)MyProject.Forms.wordprodata).Opacity = 100.0;
			((Control)MyProject.Forms.logonwindow).Show();
			((Form)this).Close();
		}
		else if (Operators.CompareString(caption.Text, "Preparing for Standby", false) == 0)
		{
			((Form)MyProject.Forms.power).Opacity = 0.0;
			((Form)MyProject.Forms.about).Opacity = 0.0;
			((Form)MyProject.Forms.alarmdata).Opacity = 0.0;
			((Form)MyProject.Forms.apps).Opacity = 0.0;
			((Form)MyProject.Forms.appsabout).Opacity = 0.0;
			((Form)MyProject.Forms.boot1).Opacity = 0.0;
			((Form)MyProject.Forms.calculator).Opacity = 0.0;
			((Form)MyProject.Forms.calendar).Opacity = 0.0;
			((Form)MyProject.Forms.camera).Opacity = 0.0;
			((Form)MyProject.Forms.clock).Opacity = 0.0;
			((Form)MyProject.Forms.commander).Opacity = 0.0;
			((Form)MyProject.Forms.deskdate).Opacity = 0.0;
			((Form)MyProject.Forms.desknet).Opacity = 0.0;
			((Form)MyProject.Forms.desktime).Opacity = 0.0;
			((Form)MyProject.Forms.dialog).Opacity = 0.0;
			((Form)MyProject.Forms.diskmanagement).Opacity = 0.0;
			((Form)MyProject.Forms.files).Opacity = 0.0;
			((Form)MyProject.Forms.home).Opacity = 0.0;
			((Form)MyProject.Forms.homeicondata).Opacity = 0.0;
			((Form)MyProject.Forms.homeitemdata).Opacity = 0.0;
			((Form)MyProject.Forms.homemenu).Opacity = 0.0;
			((Form)MyProject.Forms.int1).Opacity = 0.0;
			((Form)MyProject.Forms.int2).Opacity = 0.0;
			((Form)MyProject.Forms.int3).Opacity = 0.0;
			((Form)MyProject.Forms.int4).Opacity = 0.0;
			((Form)MyProject.Forms.int5).Opacity = 0.0;
			((Form)MyProject.Forms.int6).Opacity = 0.0;
			((Form)MyProject.Forms.int7).Opacity = 0.0;
			((Form)MyProject.Forms.lockscreenback).Opacity = 0.0;
			((Form)MyProject.Forms.mediaplayer).Opacity = 0.0;
			((Form)MyProject.Forms.meebrowser).Opacity = 0.0;
			((Form)MyProject.Forms.meemail).Opacity = 0.0;
			((Form)MyProject.Forms.meemail2).Opacity = 0.0;
			((Form)MyProject.Forms.meemail3).Opacity = 0.0;
			((Form)MyProject.Forms.ncode).Opacity = 0.0;
			((Form)MyProject.Forms.menuwxl).Opacity = 0.0;
			((Form)MyProject.Forms.openapps).Opacity = 0.0;
			((Form)MyProject.Forms.paintain).Opacity = 0.0;
			((Form)MyProject.Forms.password).Opacity = 0.0;
			((Form)MyProject.Forms.resdialog).Opacity = 0.0;
			((Form)MyProject.Forms.screenlit).Opacity = 0.0;
			((Form)MyProject.Forms.screenshot).Opacity = 0.0;
			((Form)MyProject.Forms.setalarm).Opacity = 0.0;
			((Form)MyProject.Forms.settingalarm).Opacity = 0.0;
			((Form)MyProject.Forms.settinglockscreen).Opacity = 0.0;
			((Form)MyProject.Forms.settingapps).Opacity = 0.0;
			((Form)MyProject.Forms.settingprofile).Opacity = 0.0;
			((Form)MyProject.Forms.settings).Opacity = 0.0;
			((Form)MyProject.Forms.settingsdata).Opacity = 0.0;
			((Form)MyProject.Forms.settingsecurity).Opacity = 0.0;
			((Form)MyProject.Forms.taskshow).Opacity = 0.0;
			((Form)MyProject.Forms.tts).Opacity = 0.0;
			((Form)MyProject.Forms.updates).Opacity = 0.0;
			((Form)MyProject.Forms.vboard).Opacity = 0.0;
			((Form)MyProject.Forms.volume).Opacity = 0.0;
			((Form)MyProject.Forms.wallpapers).Opacity = 0.0;
			((Form)MyProject.Forms.weather).Opacity = 0.0;
			((Form)MyProject.Forms.winexestandby).Opacity = 0.0;
			((Form)MyProject.Forms.wordpro).Opacity = 0.0;
			((Form)MyProject.Forms.wordprodata).Opacity = 0.0;
			((Control)MyProject.Forms.power).Hide();
			((Control)MyProject.Forms.about).Hide();
			((Control)MyProject.Forms.alarmdata).Hide();
			((Control)MyProject.Forms.apps).Hide();
			((Control)MyProject.Forms.appsabout).Hide();
			((Control)MyProject.Forms.calculator).Hide();
			((Control)MyProject.Forms.calendar).Hide();
			((Control)MyProject.Forms.camera).Hide();
			((Control)MyProject.Forms.clock).Hide();
			((Control)MyProject.Forms.commander).Hide();
			((Control)MyProject.Forms.deskdate).Hide();
			((Control)MyProject.Forms.desknet).Hide();
			((Control)MyProject.Forms.desktime).Hide();
			((Control)MyProject.Forms.dialog).Hide();
			((Control)MyProject.Forms.diskmanagement).Hide();
			((Control)MyProject.Forms.files).Hide();
			((Control)MyProject.Forms.home).Hide();
			((Control)MyProject.Forms.homeicondata).Hide();
			((Control)MyProject.Forms.homeitemdata).Hide();
			((Control)MyProject.Forms.homemenu).Hide();
			((Control)MyProject.Forms.lockscreenback).Hide();
			((Control)MyProject.Forms.mediaplayer).Hide();
			((Control)MyProject.Forms.meebrowser).Hide();
			((Control)MyProject.Forms.meemail).Hide();
			((Control)MyProject.Forms.meemail2).Hide();
			((Control)MyProject.Forms.meemail3).Hide();
			((Control)MyProject.Forms.ncode).Hide();
			((Control)MyProject.Forms.menuwxl).Hide();
			((Control)MyProject.Forms.openapps).Hide();
			((Control)MyProject.Forms.paintain).Hide();
			((Control)MyProject.Forms.password).Hide();
			((Control)MyProject.Forms.resdialog).Hide();
			((Control)MyProject.Forms.screenlit).Hide();
			((Control)MyProject.Forms.screenshot).Hide();
			((Control)MyProject.Forms.setalarm).Hide();
			((Control)MyProject.Forms.settingalarm).Hide();
			((Control)MyProject.Forms.settinglockscreen).Hide();
			((Control)MyProject.Forms.settingapps).Hide();
			((Control)MyProject.Forms.settingprofile).Hide();
			((Control)MyProject.Forms.settings).Hide();
			((Control)MyProject.Forms.settingsdata).Hide();
			((Control)MyProject.Forms.settingsecurity).Hide();
			((Control)MyProject.Forms.taskshow).Hide();
			((Control)MyProject.Forms.tts).Hide();
			((Control)MyProject.Forms.updates).Hide();
			((Control)MyProject.Forms.vboard).Hide();
			((Control)MyProject.Forms.volume).Hide();
			((Control)MyProject.Forms.wallpapers).Hide();
			((Control)MyProject.Forms.weather).Hide();
			((Control)MyProject.Forms.winexestandby).Hide();
			((Control)MyProject.Forms.wordpro).Hide();
			((Control)MyProject.Forms.wordprodata).Hide();
			((Form)MyProject.Forms.power).Opacity = 100.0;
			((Form)MyProject.Forms.about).Opacity = 100.0;
			((Form)MyProject.Forms.alarmdata).Opacity = 100.0;
			((Form)MyProject.Forms.apps).Opacity = 100.0;
			((Form)MyProject.Forms.appsabout).Opacity = 100.0;
			((Form)MyProject.Forms.calculator).Opacity = 100.0;
			((Form)MyProject.Forms.calendar).Opacity = 100.0;
			((Form)MyProject.Forms.camera).Opacity = 100.0;
			((Form)MyProject.Forms.clock).Opacity = 100.0;
			((Form)MyProject.Forms.commander).Opacity = 100.0;
			((Form)MyProject.Forms.deskdate).Opacity = 100.0;
			((Form)MyProject.Forms.desknet).Opacity = 100.0;
			((Form)MyProject.Forms.desktime).Opacity = 100.0;
			((Form)MyProject.Forms.dialog).Opacity = 100.0;
			((Form)MyProject.Forms.diskmanagement).Opacity = 100.0;
			((Form)MyProject.Forms.files).Opacity = 100.0;
			((Form)MyProject.Forms.home).Opacity = 100.0;
			((Form)MyProject.Forms.homeicondata).Opacity = 100.0;
			((Form)MyProject.Forms.homeitemdata).Opacity = 100.0;
			((Form)MyProject.Forms.homemenu).Opacity = 100.0;
			((Form)MyProject.Forms.lockscreenback).Opacity = 100.0;
			((Form)MyProject.Forms.mediaplayer).Opacity = 100.0;
			((Form)MyProject.Forms.meebrowser).Opacity = 100.0;
			((Form)MyProject.Forms.meemail).Opacity = 100.0;
			((Form)MyProject.Forms.meemail2).Opacity = 100.0;
			((Form)MyProject.Forms.meemail3).Opacity = 100.0;
			((Form)MyProject.Forms.ncode).Opacity = 100.0;
			((Form)MyProject.Forms.menuwxl).Opacity = 100.0;
			((Form)MyProject.Forms.openapps).Opacity = 100.0;
			((Form)MyProject.Forms.paintain).Opacity = 100.0;
			((Form)MyProject.Forms.password).Opacity = 100.0;
			((Form)MyProject.Forms.resdialog).Opacity = 100.0;
			((Form)MyProject.Forms.screenlit).Opacity = 100.0;
			((Form)MyProject.Forms.screenshot).Opacity = 100.0;
			((Form)MyProject.Forms.setalarm).Opacity = 100.0;
			((Form)MyProject.Forms.settingalarm).Opacity = 100.0;
			((Form)MyProject.Forms.settinglockscreen).Opacity = 100.0;
			((Form)MyProject.Forms.settingapps).Opacity = 100.0;
			((Form)MyProject.Forms.settingprofile).Opacity = 100.0;
			((Form)MyProject.Forms.settings).Opacity = 100.0;
			((Form)MyProject.Forms.settingsdata).Opacity = 100.0;
			((Form)MyProject.Forms.settingsecurity).Opacity = 100.0;
			((Form)MyProject.Forms.taskshow).Opacity = 100.0;
			((Form)MyProject.Forms.tts).Opacity = 100.0;
			((Form)MyProject.Forms.updates).Opacity = 100.0;
			((Form)MyProject.Forms.vboard).Opacity = 100.0;
			((Form)MyProject.Forms.volume).Opacity = 100.0;
			((Form)MyProject.Forms.wallpapers).Opacity = 100.0;
			((Form)MyProject.Forms.weather).Opacity = 100.0;
			((Form)MyProject.Forms.winexestandby).Opacity = 100.0;
			((Form)MyProject.Forms.wordpro).Opacity = 100.0;
			((Form)MyProject.Forms.wordprodata).Opacity = 100.0;
			((Control)MyProject.Forms.standbywindow).Show();
			((Form)this).Close();
		}
		else if (Operators.CompareString(caption.Text, "Preparing to Download Updates", false) == 0)
		{
			((Form)MyProject.Forms.power).Opacity = 0.0;
			((Form)MyProject.Forms.about).Opacity = 0.0;
			((Form)MyProject.Forms.alarmdata).Opacity = 0.0;
			((Form)MyProject.Forms.apps).Opacity = 0.0;
			((Form)MyProject.Forms.appsabout).Opacity = 0.0;
			((Form)MyProject.Forms.boot1).Opacity = 0.0;
			((Form)MyProject.Forms.calculator).Opacity = 0.0;
			((Form)MyProject.Forms.calendar).Opacity = 0.0;
			((Form)MyProject.Forms.camera).Opacity = 0.0;
			((Form)MyProject.Forms.clock).Opacity = 0.0;
			((Form)MyProject.Forms.commander).Opacity = 0.0;
			((Form)MyProject.Forms.deskdate).Opacity = 0.0;
			((Form)MyProject.Forms.desknet).Opacity = 0.0;
			((Form)MyProject.Forms.desktime).Opacity = 0.0;
			((Form)MyProject.Forms.dialog).Opacity = 0.0;
			((Form)MyProject.Forms.diskmanagement).Opacity = 0.0;
			((Form)MyProject.Forms.files).Opacity = 0.0;
			((Form)MyProject.Forms.home).Opacity = 0.0;
			((Form)MyProject.Forms.homeicondata).Opacity = 0.0;
			((Form)MyProject.Forms.homeitemdata).Opacity = 0.0;
			((Form)MyProject.Forms.homemenu).Opacity = 0.0;
			((Form)MyProject.Forms.int1).Opacity = 0.0;
			((Form)MyProject.Forms.int2).Opacity = 0.0;
			((Form)MyProject.Forms.int3).Opacity = 0.0;
			((Form)MyProject.Forms.int4).Opacity = 0.0;
			((Form)MyProject.Forms.int5).Opacity = 0.0;
			((Form)MyProject.Forms.int6).Opacity = 0.0;
			((Form)MyProject.Forms.int7).Opacity = 0.0;
			((Form)MyProject.Forms.lockscreenback).Opacity = 0.0;
			((Form)MyProject.Forms.mediaplayer).Opacity = 0.0;
			((Form)MyProject.Forms.meebrowser).Opacity = 0.0;
			((Form)MyProject.Forms.meemail).Opacity = 0.0;
			((Form)MyProject.Forms.meemail2).Opacity = 0.0;
			((Form)MyProject.Forms.meemail3).Opacity = 0.0;
			((Form)MyProject.Forms.ncode).Opacity = 0.0;
			((Form)MyProject.Forms.menuwxl).Opacity = 0.0;
			((Form)MyProject.Forms.openapps).Opacity = 0.0;
			((Form)MyProject.Forms.paintain).Opacity = 0.0;
			((Form)MyProject.Forms.password).Opacity = 0.0;
			((Form)MyProject.Forms.resdialog).Opacity = 0.0;
			((Form)MyProject.Forms.screenlit).Opacity = 0.0;
			((Form)MyProject.Forms.screenshot).Opacity = 0.0;
			((Form)MyProject.Forms.setalarm).Opacity = 0.0;
			((Form)MyProject.Forms.settingalarm).Opacity = 0.0;
			((Form)MyProject.Forms.settinglockscreen).Opacity = 0.0;
			((Form)MyProject.Forms.settingapps).Opacity = 0.0;
			((Form)MyProject.Forms.settingprofile).Opacity = 0.0;
			((Form)MyProject.Forms.settings).Opacity = 0.0;
			((Form)MyProject.Forms.settingsdata).Opacity = 0.0;
			((Form)MyProject.Forms.settingsecurity).Opacity = 0.0;
			((Form)MyProject.Forms.taskshow).Opacity = 0.0;
			((Form)MyProject.Forms.tts).Opacity = 0.0;
			((Form)MyProject.Forms.updates).Opacity = 0.0;
			((Form)MyProject.Forms.vboard).Opacity = 0.0;
			((Form)MyProject.Forms.volume).Opacity = 0.0;
			((Form)MyProject.Forms.wallpapers).Opacity = 0.0;
			((Form)MyProject.Forms.weather).Opacity = 0.0;
			((Form)MyProject.Forms.winexestandby).Opacity = 0.0;
			((Form)MyProject.Forms.wordpro).Opacity = 0.0;
			((Form)MyProject.Forms.wordprodata).Opacity = 0.0;
			((Control)MyProject.Forms.power).Hide();
			((Control)MyProject.Forms.about).Hide();
			((Control)MyProject.Forms.alarmdata).Hide();
			((Control)MyProject.Forms.apps).Hide();
			((Control)MyProject.Forms.appsabout).Hide();
			((Control)MyProject.Forms.calculator).Hide();
			((Control)MyProject.Forms.calendar).Hide();
			((Control)MyProject.Forms.camera).Hide();
			((Control)MyProject.Forms.clock).Hide();
			((Control)MyProject.Forms.commander).Hide();
			((Control)MyProject.Forms.deskdate).Hide();
			((Control)MyProject.Forms.desknet).Hide();
			((Control)MyProject.Forms.desktime).Hide();
			((Control)MyProject.Forms.dialog).Hide();
			((Control)MyProject.Forms.diskmanagement).Hide();
			((Control)MyProject.Forms.files).Hide();
			((Control)MyProject.Forms.home).Hide();
			((Control)MyProject.Forms.homeicondata).Hide();
			((Control)MyProject.Forms.homeitemdata).Hide();
			((Control)MyProject.Forms.homemenu).Hide();
			((Control)MyProject.Forms.lockscreenback).Hide();
			((Control)MyProject.Forms.mediaplayer).Hide();
			((Control)MyProject.Forms.meebrowser).Hide();
			((Control)MyProject.Forms.meemail).Hide();
			((Control)MyProject.Forms.meemail2).Hide();
			((Control)MyProject.Forms.meemail3).Hide();
			((Control)MyProject.Forms.ncode).Hide();
			((Control)MyProject.Forms.menuwxl).Hide();
			((Control)MyProject.Forms.openapps).Hide();
			((Control)MyProject.Forms.paintain).Hide();
			((Control)MyProject.Forms.password).Hide();
			((Control)MyProject.Forms.resdialog).Hide();
			((Control)MyProject.Forms.screenlit).Hide();
			((Control)MyProject.Forms.screenshot).Hide();
			((Control)MyProject.Forms.setalarm).Hide();
			((Control)MyProject.Forms.settingalarm).Hide();
			((Control)MyProject.Forms.settinglockscreen).Hide();
			((Control)MyProject.Forms.settingapps).Hide();
			((Control)MyProject.Forms.settingprofile).Hide();
			((Control)MyProject.Forms.settings).Hide();
			((Control)MyProject.Forms.settingsdata).Hide();
			((Control)MyProject.Forms.settingsecurity).Hide();
			((Control)MyProject.Forms.taskshow).Hide();
			((Control)MyProject.Forms.tts).Hide();
			((Control)MyProject.Forms.updates).Hide();
			((Control)MyProject.Forms.vboard).Hide();
			((Control)MyProject.Forms.volume).Hide();
			((Control)MyProject.Forms.wallpapers).Hide();
			((Control)MyProject.Forms.weather).Hide();
			((Control)MyProject.Forms.winexestandby).Hide();
			((Control)MyProject.Forms.wordpro).Hide();
			((Control)MyProject.Forms.wordprodata).Hide();
			((Form)MyProject.Forms.power).Opacity = 100.0;
			((Form)MyProject.Forms.about).Opacity = 100.0;
			((Form)MyProject.Forms.alarmdata).Opacity = 100.0;
			((Form)MyProject.Forms.apps).Opacity = 100.0;
			((Form)MyProject.Forms.appsabout).Opacity = 100.0;
			((Form)MyProject.Forms.calculator).Opacity = 100.0;
			((Form)MyProject.Forms.calendar).Opacity = 100.0;
			((Form)MyProject.Forms.camera).Opacity = 100.0;
			((Form)MyProject.Forms.clock).Opacity = 100.0;
			((Form)MyProject.Forms.commander).Opacity = 100.0;
			((Form)MyProject.Forms.deskdate).Opacity = 100.0;
			((Form)MyProject.Forms.desknet).Opacity = 100.0;
			((Form)MyProject.Forms.desktime).Opacity = 100.0;
			((Form)MyProject.Forms.dialog).Opacity = 100.0;
			((Form)MyProject.Forms.diskmanagement).Opacity = 100.0;
			((Form)MyProject.Forms.files).Opacity = 100.0;
			((Form)MyProject.Forms.home).Opacity = 100.0;
			((Form)MyProject.Forms.homeicondata).Opacity = 100.0;
			((Form)MyProject.Forms.homeitemdata).Opacity = 100.0;
			((Form)MyProject.Forms.homemenu).Opacity = 100.0;
			((Form)MyProject.Forms.lockscreenback).Opacity = 100.0;
			((Form)MyProject.Forms.mediaplayer).Opacity = 100.0;
			((Form)MyProject.Forms.meebrowser).Opacity = 100.0;
			((Form)MyProject.Forms.meemail).Opacity = 100.0;
			((Form)MyProject.Forms.meemail2).Opacity = 100.0;
			((Form)MyProject.Forms.meemail3).Opacity = 100.0;
			((Form)MyProject.Forms.ncode).Opacity = 100.0;
			((Form)MyProject.Forms.menuwxl).Opacity = 100.0;
			((Form)MyProject.Forms.openapps).Opacity = 100.0;
			((Form)MyProject.Forms.paintain).Opacity = 100.0;
			((Form)MyProject.Forms.password).Opacity = 100.0;
			((Form)MyProject.Forms.resdialog).Opacity = 100.0;
			((Form)MyProject.Forms.screenlit).Opacity = 100.0;
			((Form)MyProject.Forms.screenshot).Opacity = 100.0;
			((Form)MyProject.Forms.setalarm).Opacity = 100.0;
			((Form)MyProject.Forms.settingalarm).Opacity = 100.0;
			((Form)MyProject.Forms.settinglockscreen).Opacity = 100.0;
			((Form)MyProject.Forms.settingapps).Opacity = 100.0;
			((Form)MyProject.Forms.settingprofile).Opacity = 100.0;
			((Form)MyProject.Forms.settings).Opacity = 100.0;
			((Form)MyProject.Forms.settingsdata).Opacity = 100.0;
			((Form)MyProject.Forms.settingsecurity).Opacity = 100.0;
			((Form)MyProject.Forms.taskshow).Opacity = 100.0;
			((Form)MyProject.Forms.tts).Opacity = 100.0;
			((Form)MyProject.Forms.updates).Opacity = 100.0;
			((Form)MyProject.Forms.vboard).Opacity = 100.0;
			((Form)MyProject.Forms.volume).Opacity = 100.0;
			((Form)MyProject.Forms.wallpapers).Opacity = 100.0;
			((Form)MyProject.Forms.weather).Opacity = 100.0;
			((Form)MyProject.Forms.winexestandby).Opacity = 100.0;
			((Form)MyProject.Forms.wordpro).Opacity = 100.0;
			((Form)MyProject.Forms.wordprodata).Opacity = 100.0;
			((Control)MyProject.Forms.standbywindow).Show();
			Process.Start(MyProject.Forms.updates.updatelink.Text);
			((Form)this).Close();
		}
	}
}
