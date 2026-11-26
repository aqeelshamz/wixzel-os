using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class boot : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Timer2")]
	private Timer _Timer2;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Timer3")]
	private Timer _Timer3;

	[AccessedThroughProperty("Timer4")]
	private Timer _Timer4;

	[AccessedThroughProperty("Timer5")]
	private Timer _Timer5;

	[AccessedThroughProperty("Timer6")]
	private Timer _Timer6;

	[AccessedThroughProperty("Timer7")]
	private Timer _Timer7;

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

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
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

	internal virtual Timer Timer3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			if (_Timer3 != null)
			{
				_Timer3.Tick -= eventHandler;
			}
			_Timer3 = value;
			if (_Timer3 != null)
			{
				_Timer3.Tick += eventHandler;
			}
		}
	}

	internal virtual Timer Timer4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			if (_Timer4 != null)
			{
				_Timer4.Tick -= eventHandler;
			}
			_Timer4 = value;
			if (_Timer4 != null)
			{
				_Timer4.Tick += eventHandler;
			}
		}
	}

	internal virtual Timer Timer5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer5_Tick;
			if (_Timer5 != null)
			{
				_Timer5.Tick -= eventHandler;
			}
			_Timer5 = value;
			if (_Timer5 != null)
			{
				_Timer5.Tick += eventHandler;
			}
		}
	}

	internal virtual Timer Timer6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer6_Tick;
			if (_Timer6 != null)
			{
				_Timer6.Tick -= eventHandler;
			}
			_Timer6 = value;
			if (_Timer6 != null)
			{
				_Timer6.Tick += eventHandler;
			}
		}
	}

	internal virtual Timer Timer7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			if (_Timer7 != null)
			{
				_Timer7.Tick -= eventHandler;
			}
			_Timer7 = value;
			if (_Timer7 != null)
			{
				_Timer7.Tick += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public boot()
	{
		((Form)this).Load += boot_Load;
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

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.Forms.boot);
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		Timer1 = new Timer(components);
		Timer2 = new Timer(components);
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Timer3 = new Timer(components);
		Timer4 = new Timer(components);
		Timer5 = new Timer(components);
		Timer6 = new Timer(components);
		Timer7 = new Timer(components);
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.White;
		Label label = Label1;
		Point location = new Point(62, 56);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(0, 16);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 0;
		Timer1.Enabled = true;
		Timer1.Interval = 3000;
		Timer2.Interval = 500;
		Label2.AutoSize = true;
		((Control)Label2).Font = new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label3 = Label2;
		location = new Point(62, 92);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(0, 16);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 1;
		Label3.AutoSize = true;
		((Control)Label3).Font = new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label5 = Label3;
		location = new Point(62, 131);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(0, 16);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 2;
		Label4.AutoSize = true;
		((Control)Label4).Font = new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label7 = Label4;
		location = new Point(62, 173);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(0, 16);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 3;
		Label5.AutoSize = true;
		((Control)Label5).Font = new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label9 = Label5;
		location = new Point(62, 302);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(0, 16);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 4;
		Label6.AutoSize = true;
		((Control)Label6).Font = new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label11 = Label6;
		location = new Point(62, 331);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(0, 16);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 5;
		Label7.AutoSize = true;
		((Control)Label7).Font = new Font("Lucida Console", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.White;
		Label label13 = Label7;
		location = new Point(62, 356);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(0, 16);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 6;
		Timer3.Interval = 1;
		Timer4.Interval = 1;
		Timer5.Interval = 1;
		Timer6.Interval = 1;
		Timer7.Interval = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.Black;
		size = new Size(1612, 912);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "boot";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\boot.data.file"))
		{
			Label1.Text = "Loading Wixzel OS Almond 1.0 - Beta";
			((Form)MyProject.Forms.home).Opacity = 0.0;
			((Control)MyProject.Forms.home).Show();
			((Control)MyProject.Forms.home).Hide();
			((Form)MyProject.Forms.home).Opacity = 100.0;
			((Form)MyProject.Forms.menuwxl).Opacity = 0.0;
			((Control)MyProject.Forms.menuwxl).Show();
			((Control)MyProject.Forms.menuwxl).Hide();
			((Form)MyProject.Forms.menuwxl).Opacity = 100.0;
			((Form)MyProject.Forms.apps).Opacity = 0.0;
			((Control)MyProject.Forms.apps).Show();
			((Control)MyProject.Forms.apps).Hide();
			((Form)MyProject.Forms.apps).Opacity = 100.0;
			((Form)MyProject.Forms.homemenu).Opacity = 0.0;
			((Control)MyProject.Forms.homemenu).Show();
			((Control)MyProject.Forms.homemenu).Hide();
			((Form)MyProject.Forms.homemenu).Opacity = 100.0;
			Timer2.Enabled = true;
			Timer1.Enabled = false;
		}
		else
		{
			((Control)MyProject.Forms.int1).Show();
			((Control)this).Hide();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		Label1.Text = "Loading Apps";
		Timer3.Enabled = true;
		Timer2.Enabled = false;
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		Label3.Text = "";
		Timer4.Enabled = true;
		Timer3.Enabled = false;
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		Label4.Text = "";
		Timer5.Enabled = true;
		Timer4.Enabled = false;
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		Label5.Text = "";
		Timer6.Enabled = true;
		Timer5.Enabled = false;
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		Label6.Text = "";
		Timer7.Enabled = true;
		Timer6.Enabled = false;
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		Label7.Text = "";
		((Control)MyProject.Forms.boot1).Show();
		((Control)this).Hide();
		Timer1.Enabled = false;
		Timer2.Enabled = false;
		Timer3.Enabled = false;
		Timer4.Enabled = false;
		Timer5.Enabled = false;
		Timer6.Enabled = false;
		Timer7.Enabled = false;
	}

	private void boot_Load(object sender, EventArgs e)
	{
		((Form)this).TopMost = false;
		((Control)MyProject.Forms.datacontrolroom).Show();
	}
}
