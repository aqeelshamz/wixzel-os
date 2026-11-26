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
public class homemenu : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = Label1_MouseLeave;
			MouseEventHandler val = new MouseEventHandler(Label1_MouseMove);
			EventHandler eventHandler2 = Label1_Click;
			if (_Label1 != null)
			{
				((Control)_Label1).MouseLeave -= eventHandler;
				((Control)_Label1).MouseMove -= val;
				((Control)_Label1).Click -= eventHandler2;
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).MouseLeave += eventHandler;
				((Control)_Label1).MouseMove += val;
				((Control)_Label1).Click += eventHandler2;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = Label2_MouseLeave;
			EventHandler eventHandler2 = Label2_Click;
			MouseEventHandler val = new MouseEventHandler(Label2_MouseMove);
			if (_Label2 != null)
			{
				((Control)_Label2).MouseLeave -= eventHandler;
				((Control)_Label2).Click -= eventHandler2;
				((Control)_Label2).MouseMove -= val;
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).MouseLeave += eventHandler;
				((Control)_Label2).Click += eventHandler2;
				((Control)_Label2).MouseMove += val;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label3_MouseMove);
			EventHandler eventHandler = Label3_MouseLeave;
			EventHandler eventHandler2 = Label3_Click;
			if (_Label3 != null)
			{
				((Control)_Label3).MouseMove -= val;
				((Control)_Label3).MouseLeave -= eventHandler;
				((Control)_Label3).Click -= eventHandler2;
			}
			_Label3 = value;
			if (_Label3 != null)
			{
				((Control)_Label3).MouseMove += val;
				((Control)_Label3).MouseLeave += eventHandler;
				((Control)_Label3).Click += eventHandler2;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label4_MouseMove);
			EventHandler eventHandler = Label4_MouseLeave;
			EventHandler eventHandler2 = Label4_Click;
			if (_Label4 != null)
			{
				((Control)_Label4).MouseMove -= val;
				((Control)_Label4).MouseLeave -= eventHandler;
				((Control)_Label4).Click -= eventHandler2;
			}
			_Label4 = value;
			if (_Label4 != null)
			{
				((Control)_Label4).MouseMove += val;
				((Control)_Label4).MouseLeave += eventHandler;
				((Control)_Label4).Click += eventHandler2;
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
	public homemenu()
	{
		((Form)this).Load += homemenu_Load;
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.Black;
		Label label = Label1;
		Point location = new Point(15, 14);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(207, 18);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 4;
		Label1.Text = "Refresh                                      ";
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.White;
		((Control)Label2).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.Black;
		Label label3 = Label2;
		location = new Point(15, 58);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(263, 18);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 5;
		Label2.Text = "Add                                                         ";
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.White;
		((Control)Label3).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.Black;
		Label label5 = Label3;
		location = new Point(15, 102);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(193, 18);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 6;
		Label3.Text = "Wallpapers                           ";
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.White;
		((Control)Label4).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.Black;
		Label label7 = Label4;
		location = new Point(15, 147);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(223, 18);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 7;
		Label4.Text = "Settings                                         ";
		Timer1.Enabled = true;
		Timer1.Interval = 1;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(159, 178);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "homemenu";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void homemenu_Load(object sender, EventArgs e)
	{
		((Form)this).TopMost = false;
		MyProject.Forms.homeicondata.Label2.Text = "vis";
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (Operators.CompareString(MyProject.Forms.homeicondata.Label2.Text, "notvis", false) == 0)
		{
			((Form)this).Close();
		}
	}

	private void Label1_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).Refresh();
		((Control)MyProject.Forms.home).Focus();
		((Form)this).Close();
	}

	private void Label2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Label3_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.wallpapers).Show();
		((Form)MyProject.Forms.wallpapers).TopMost = true;
		((Form)this).Close();
	}

	private void Label4_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.settings).Show();
		((Form)MyProject.Forms.settings).TopMost = true;
		((Form)this).Close();
	}

	private void Label1_MouseLeave(object sender, EventArgs e)
	{
		((Control)Label1).ForeColor = Color.Black;
	}

	private void Label1_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)Label1).ForeColor = Color.RoyalBlue;
	}

	private void Label2_MouseLeave(object sender, EventArgs e)
	{
		((Control)Label2).ForeColor = Color.Black;
	}

	private void Label2_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)Label2).ForeColor = Color.RoyalBlue;
	}

	private void Label3_MouseLeave(object sender, EventArgs e)
	{
		((Control)Label3).ForeColor = Color.Black;
	}

	private void Label3_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)Label3).ForeColor = Color.RoyalBlue;
	}

	private void Label4_MouseLeave(object sender, EventArgs e)
	{
		((Control)Label4).ForeColor = Color.Black;
	}

	private void Label4_MouseMove(object sender, MouseEventArgs e)
	{
		((Control)Label4).ForeColor = Color.RoyalBlue;
	}
}
