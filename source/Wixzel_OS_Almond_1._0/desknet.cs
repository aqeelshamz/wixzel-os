using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class desknet : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("refreshing")]
	private PictureBox _refreshing;

	[AccessedThroughProperty("notconnected")]
	private PictureBox _notconnected;

	[AccessedThroughProperty("connected")]
	private PictureBox _connected;

	private Thread checkthread;

	public bool internet;

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
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click -= eventHandler;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click += eventHandler;
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
			_Label1 = value;
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
			_PictureBox2 = value;
		}
	}

	internal virtual PictureBox refreshing
	{
		[DebuggerNonUserCode]
		get
		{
			return _refreshing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_refreshing = value;
		}
	}

	internal virtual PictureBox notconnected
	{
		[DebuggerNonUserCode]
		get
		{
			return _notconnected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_notconnected = value;
		}
	}

	internal virtual PictureBox connected
	{
		[DebuggerNonUserCode]
		get
		{
			return _connected;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_connected = value;
		}
	}

	[DebuggerNonUserCode]
	public desknet()
	{
		((Form)this).Load += desknet_Load;
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
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(desknet));
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		refreshing = new PictureBox();
		notconnected = new PictureBox();
		connected = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)refreshing).BeginInit();
		((ISupportInitialize)notconnected).BeginInit();
		((ISupportInitialize)connected).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).BackColor = SystemColors.ActiveCaption;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(0, -1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(360, 136);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(120, 53);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(116, 22);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 1;
		Label1.Text = "Refreshing...";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(23, 29);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(64, 63);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)4;
		PictureBox2.TabIndex = 2;
		PictureBox2.TabStop = false;
		((Control)refreshing).BackColor = Color.White;
		refreshing.Image = (Image)componentResourceManager.GetObject("refreshing.Image");
		PictureBox obj = refreshing;
		location = new Point(247, 97);
		((Control)obj).Location = location;
		((Control)refreshing).Name = "refreshing";
		PictureBox obj2 = refreshing;
		size = new Size(26, 26);
		((Control)obj2).Size = size;
		refreshing.SizeMode = (PictureBoxSizeMode)4;
		refreshing.TabIndex = 3;
		refreshing.TabStop = false;
		((Control)refreshing).Visible = false;
		((Control)notconnected).BackColor = Color.White;
		notconnected.Image = (Image)componentResourceManager.GetObject("notconnected.Image");
		PictureBox obj3 = notconnected;
		location = new Point(279, 97);
		((Control)obj3).Location = location;
		((Control)notconnected).Name = "notconnected";
		PictureBox obj4 = notconnected;
		size = new Size(26, 26);
		((Control)obj4).Size = size;
		notconnected.SizeMode = (PictureBoxSizeMode)4;
		notconnected.TabIndex = 4;
		notconnected.TabStop = false;
		((Control)notconnected).Visible = false;
		((Control)connected).BackColor = Color.White;
		connected.Image = (Image)componentResourceManager.GetObject("connected.Image");
		PictureBox obj5 = connected;
		location = new Point(311, 97);
		((Control)obj5).Location = location;
		((Control)connected).Name = "connected";
		PictureBox obj6 = connected;
		size = new Size(26, 26);
		((Control)obj6).Size = size;
		connected.SizeMode = (PictureBoxSizeMode)4;
		connected.TabIndex = 5;
		connected.TabStop = false;
		((Control)connected).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(360, 135);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)connected);
		((Control)this).Controls.Add((Control)(object)notconnected);
		((Control)this).Controls.Add((Control)(object)refreshing);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "desknet";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)0;
		((Form)this).TopMost = true;
		((Form)this).TransparencyKey = SystemColors.ActiveCaption;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)refreshing).EndInit();
		((ISupportInitialize)notconnected).EndInit();
		((ISupportInitialize)connected).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void desknet_Load(object sender, EventArgs e)
	{
		checkthread = new Thread(checkconnection);
		checkthread.Start();
		PictureBox2.Image = refreshing.Image;
		MyProject.Forms.home.netrange.Image = refreshing.Image;
	}

	private void checkconnection()
	{
		if (!internetconnection())
		{
			internet = false;
		}
		else
		{
			internet = true;
		}
		accesslabel();
	}

	private void accesslabel()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (((Control)this).InvokeRequired)
		{
			((Control)this).Invoke((Delegate)new MethodInvoker(accesslabel));
		}
		else if (!internet)
		{
			Label1.Text = "Not Connected";
			PictureBox2.Image = notconnected.Image;
			MyProject.Forms.home.netrange.Image = notconnected.Image;
		}
		else
		{
			Label1.Text = "Connected";
			PictureBox2.Image = connected.Image;
			MyProject.Forms.home.netrange.Image = connected.Image;
		}
	}

	private bool internetconnection()
	{
		WebRequest webRequest = WebRequest.Create("http://www.google.com/");
		bool result;
		try
		{
			WebResponse response = webRequest.GetResponse();
			response.Close();
			result = true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			webRequest = null;
			result = false;
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}
}
