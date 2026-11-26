using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class settingsdata : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("apps")]
	private PictureBox _apps;

	[AccessedThroughProperty("profile")]
	private PictureBox _profile;

	[AccessedThroughProperty("security")]
	private PictureBox _security;

	[AccessedThroughProperty("storage")]
	private PictureBox _storage;

	[AccessedThroughProperty("wallpaperss")]
	private PictureBox _wallpaperss;

	[AccessedThroughProperty("lockscreen")]
	private PictureBox _lockscreen;

	[AccessedThroughProperty("notification")]
	private PictureBox _notification;

	[AccessedThroughProperty("alarm")]
	private PictureBox _alarm;

	[AccessedThroughProperty("updates")]
	private PictureBox _updates;

	[AccessedThroughProperty("wixzel")]
	private PictureBox _wixzel;

	[AccessedThroughProperty("none")]
	private PictureBox _none;

	internal virtual PictureBox apps
	{
		[DebuggerNonUserCode]
		get
		{
			return _apps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_apps = value;
		}
	}

	internal virtual PictureBox profile
	{
		[DebuggerNonUserCode]
		get
		{
			return _profile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_profile = value;
		}
	}

	internal virtual PictureBox security
	{
		[DebuggerNonUserCode]
		get
		{
			return _security;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_security = value;
		}
	}

	internal virtual PictureBox storage
	{
		[DebuggerNonUserCode]
		get
		{
			return _storage;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_storage = value;
		}
	}

	internal virtual PictureBox wallpaperss
	{
		[DebuggerNonUserCode]
		get
		{
			return _wallpaperss;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_wallpaperss = value;
		}
	}

	internal virtual PictureBox lockscreen
	{
		[DebuggerNonUserCode]
		get
		{
			return _lockscreen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lockscreen = value;
		}
	}

	internal virtual PictureBox notification
	{
		[DebuggerNonUserCode]
		get
		{
			return _notification;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_notification = value;
		}
	}

	internal virtual PictureBox alarm
	{
		[DebuggerNonUserCode]
		get
		{
			return _alarm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_alarm = value;
		}
	}

	internal virtual PictureBox updates
	{
		[DebuggerNonUserCode]
		get
		{
			return _updates;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_updates = value;
		}
	}

	internal virtual PictureBox wixzel
	{
		[DebuggerNonUserCode]
		get
		{
			return _wixzel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_wixzel = value;
		}
	}

	internal virtual PictureBox none
	{
		[DebuggerNonUserCode]
		get
		{
			return _none;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_none = value;
		}
	}

	[DebuggerNonUserCode]
	public settingsdata()
	{
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
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0613: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(settingsdata));
		apps = new PictureBox();
		profile = new PictureBox();
		security = new PictureBox();
		storage = new PictureBox();
		wallpaperss = new PictureBox();
		lockscreen = new PictureBox();
		notification = new PictureBox();
		alarm = new PictureBox();
		updates = new PictureBox();
		wixzel = new PictureBox();
		none = new PictureBox();
		((ISupportInitialize)apps).BeginInit();
		((ISupportInitialize)profile).BeginInit();
		((ISupportInitialize)security).BeginInit();
		((ISupportInitialize)storage).BeginInit();
		((ISupportInitialize)wallpaperss).BeginInit();
		((ISupportInitialize)lockscreen).BeginInit();
		((ISupportInitialize)notification).BeginInit();
		((ISupportInitialize)alarm).BeginInit();
		((ISupportInitialize)updates).BeginInit();
		((ISupportInitialize)wixzel).BeginInit();
		((ISupportInitialize)none).BeginInit();
		((Control)this).SuspendLayout();
		((Control)apps).BackColor = Color.White;
		apps.Image = (Image)componentResourceManager.GetObject("apps.Image");
		PictureBox obj = apps;
		Point location = new Point(41, 35);
		((Control)obj).Location = location;
		((Control)apps).Name = "apps";
		PictureBox obj2 = apps;
		Size size = new Size(20, 20);
		((Control)obj2).Size = size;
		apps.SizeMode = (PictureBoxSizeMode)4;
		apps.TabIndex = 121;
		apps.TabStop = false;
		((Control)profile).BackColor = Color.White;
		profile.Image = (Image)componentResourceManager.GetObject("profile.Image");
		PictureBox obj3 = profile;
		location = new Point(41, 61);
		((Control)obj3).Location = location;
		((Control)profile).Name = "profile";
		PictureBox obj4 = profile;
		size = new Size(20, 20);
		((Control)obj4).Size = size;
		profile.SizeMode = (PictureBoxSizeMode)4;
		profile.TabIndex = 122;
		profile.TabStop = false;
		((Control)security).BackColor = Color.White;
		security.Image = (Image)componentResourceManager.GetObject("security.Image");
		PictureBox obj5 = security;
		location = new Point(41, 87);
		((Control)obj5).Location = location;
		((Control)security).Name = "security";
		PictureBox obj6 = security;
		size = new Size(20, 20);
		((Control)obj6).Size = size;
		security.SizeMode = (PictureBoxSizeMode)4;
		security.TabIndex = 123;
		security.TabStop = false;
		((Control)storage).BackColor = Color.White;
		storage.Image = (Image)componentResourceManager.GetObject("storage.Image");
		PictureBox obj7 = storage;
		location = new Point(41, 113);
		((Control)obj7).Location = location;
		((Control)storage).Name = "storage";
		PictureBox obj8 = storage;
		size = new Size(20, 20);
		((Control)obj8).Size = size;
		storage.SizeMode = (PictureBoxSizeMode)4;
		storage.TabIndex = 124;
		storage.TabStop = false;
		((Control)wallpaperss).BackColor = Color.White;
		wallpaperss.Image = (Image)componentResourceManager.GetObject("wallpaperss.Image");
		PictureBox obj9 = wallpaperss;
		location = new Point(84, 61);
		((Control)obj9).Location = location;
		((Control)wallpaperss).Name = "wallpaperss";
		PictureBox obj10 = wallpaperss;
		size = new Size(20, 20);
		((Control)obj10).Size = size;
		wallpaperss.SizeMode = (PictureBoxSizeMode)4;
		wallpaperss.TabIndex = 126;
		wallpaperss.TabStop = false;
		((Control)lockscreen).BackColor = Color.White;
		lockscreen.Image = (Image)componentResourceManager.GetObject("lockscreen.Image");
		PictureBox obj11 = lockscreen;
		location = new Point(84, 35);
		((Control)obj11).Location = location;
		((Control)lockscreen).Name = "lockscreen";
		PictureBox obj12 = lockscreen;
		size = new Size(20, 20);
		((Control)obj12).Size = size;
		lockscreen.SizeMode = (PictureBoxSizeMode)4;
		lockscreen.TabIndex = 125;
		lockscreen.TabStop = false;
		((Control)notification).BackColor = Color.White;
		notification.Image = (Image)componentResourceManager.GetObject("notification.Image");
		PictureBox obj13 = notification;
		location = new Point(128, 61);
		((Control)obj13).Location = location;
		((Control)notification).Name = "notification";
		PictureBox obj14 = notification;
		size = new Size(20, 20);
		((Control)obj14).Size = size;
		notification.SizeMode = (PictureBoxSizeMode)4;
		notification.TabIndex = 128;
		notification.TabStop = false;
		((Control)alarm).BackColor = Color.White;
		alarm.Image = (Image)componentResourceManager.GetObject("alarm.Image");
		PictureBox obj15 = alarm;
		location = new Point(128, 35);
		((Control)obj15).Location = location;
		((Control)alarm).Name = "alarm";
		PictureBox obj16 = alarm;
		size = new Size(20, 20);
		((Control)obj16).Size = size;
		alarm.SizeMode = (PictureBoxSizeMode)4;
		alarm.TabIndex = 127;
		alarm.TabStop = false;
		((Control)updates).BackColor = Color.White;
		updates.Image = (Image)componentResourceManager.GetObject("updates.Image");
		PictureBox obj17 = updates;
		location = new Point(169, 61);
		((Control)obj17).Location = location;
		((Control)updates).Name = "updates";
		PictureBox obj18 = updates;
		size = new Size(20, 20);
		((Control)obj18).Size = size;
		updates.SizeMode = (PictureBoxSizeMode)4;
		updates.TabIndex = 130;
		updates.TabStop = false;
		((Control)wixzel).BackColor = Color.White;
		wixzel.Image = (Image)componentResourceManager.GetObject("wixzel.Image");
		PictureBox obj19 = wixzel;
		location = new Point(169, 35);
		((Control)obj19).Location = location;
		((Control)wixzel).Name = "wixzel";
		PictureBox obj20 = wixzel;
		size = new Size(20, 20);
		((Control)obj20).Size = size;
		wixzel.SizeMode = (PictureBoxSizeMode)4;
		wixzel.TabIndex = 129;
		wixzel.TabStop = false;
		((Control)none).BackColor = Color.White;
		PictureBox obj21 = none;
		location = new Point(217, 35);
		((Control)obj21).Location = location;
		((Control)none).Name = "none";
		PictureBox obj22 = none;
		size = new Size(20, 20);
		((Control)obj22).Size = size;
		none.SizeMode = (PictureBoxSizeMode)4;
		none.TabIndex = 131;
		none.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(611, 540);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)none);
		((Control)this).Controls.Add((Control)(object)updates);
		((Control)this).Controls.Add((Control)(object)wixzel);
		((Control)this).Controls.Add((Control)(object)notification);
		((Control)this).Controls.Add((Control)(object)alarm);
		((Control)this).Controls.Add((Control)(object)wallpaperss);
		((Control)this).Controls.Add((Control)(object)lockscreen);
		((Control)this).Controls.Add((Control)(object)storage);
		((Control)this).Controls.Add((Control)(object)security);
		((Control)this).Controls.Add((Control)(object)profile);
		((Control)this).Controls.Add((Control)(object)apps);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "settingsdata";
		((ISupportInitialize)apps).EndInit();
		((ISupportInitialize)profile).EndInit();
		((ISupportInitialize)security).EndInit();
		((ISupportInitialize)storage).EndInit();
		((ISupportInitialize)wallpaperss).EndInit();
		((ISupportInitialize)lockscreen).EndInit();
		((ISupportInitialize)notification).EndInit();
		((ISupportInitialize)alarm).EndInit();
		((ISupportInitialize)updates).EndInit();
		((ISupportInitialize)wixzel).EndInit();
		((ISupportInitialize)none).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
