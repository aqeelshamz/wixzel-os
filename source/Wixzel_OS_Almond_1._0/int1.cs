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
public class int1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("directory")]
	private Timer _directory;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	internal virtual Timer directory
	{
		[DebuggerNonUserCode]
		get
		{
			return _directory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = directory_Tick;
			if (_directory != null)
			{
				_directory.Tick -= eventHandler;
			}
			_directory = value;
			if (_directory != null)
			{
				_directory.Tick += eventHandler;
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
	public int1()
	{
		((Form)this).Load += int1_Load;
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
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(int1));
		directory = new Timer(components);
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		directory.Enabled = true;
		directory.Interval = 5000;
		Timer1.Enabled = true;
		Timer1.Interval = 15000;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		Size clientSize = new Size(1360, 768);
		((Form)this).ClientSize = clientSize;
		((Control)this).DoubleBuffered = true;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "int1";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).ResumeLayout(false);
	}

	private void int1_Load(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.datacontrolroom).Show();
		int width = Screen.PrimaryScreen.Bounds.Width;
		int height = Screen.PrimaryScreen.Bounds.Height;
		((Control)this).Width = width;
		((Control)this).Height = height;
	}

	private void directory_Tick(object sender, EventArgs e)
	{
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.calculator.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.calculator.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.calendar.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.calendar.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.camera.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.camera.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.converter.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.converter.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.files.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.files.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.gallery.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.gallery.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meebrowser.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meebrowser.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meemail.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meemail.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.ncode.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.ncode.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.network.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.network.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.news.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.news.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.notes.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.notes.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.oradixz.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.oradixz.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.paintain.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.paintain.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.picdit.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.picdit.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.soundrecorder.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.soundrecorder.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.sports.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.sports.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.weather.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.weather.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.winexe.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.winexe.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.assistant.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.assistant.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.games.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.games.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.mediaplayer.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.mediaplayer.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.security.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.security.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.store.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.store.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.studio.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.studio.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.tools.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.tools.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.updates.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.wordpro.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.wordpro.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.about.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.about.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.commander.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.commander.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.diskmanagement.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.diskmanagement.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.screenlit.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.screenlit.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.screenshot.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.screenshot.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.settings.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.settings.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.startupapps.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.startupapps.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.taskmanager.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.taskmanager.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.tts.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.tts.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.vboard.1.0"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\tool.wixzel.vboard.1.0");
		}
		if (!Directory.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data"))
		{
			Directory.CreateDirectory(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data");
		}
		if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\bubblero.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\greenmix.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\mirax.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\orange.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\pinkero.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\vibgyor.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\wixzeld.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\wixzeldb.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\wixzelpro.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.dta\\wixzelprob.file"))
		{
			File.Delete(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
		directory.Enabled = false;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.int2).Show();
		Timer1.Enabled = false;
	}

	private void file_Tick(object sender, EventArgs e)
	{
	}
}
