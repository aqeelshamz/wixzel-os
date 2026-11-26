using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class desktime : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("timedisplay")]
	private Label _timedisplay;

	[AccessedThroughProperty("timeformat")]
	private Label _timeformat;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

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

	internal virtual Label timedisplay
	{
		[DebuggerNonUserCode]
		get
		{
			return _timedisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_timedisplay = value;
		}
	}

	internal virtual Label timeformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _timeformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_timeformat = value;
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

	[DebuggerNonUserCode]
	public desktime()
	{
		((Form)this).Load += desktime_Load;
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		components = new Container();
		Timer1 = new Timer(components);
		timedisplay = new Label();
		timeformat = new Label();
		Label1 = new Label();
		((Control)this).SuspendLayout();
		Timer1.Enabled = true;
		((Control)timedisplay).Anchor = (AnchorStyles)3;
		((Control)timedisplay).BackColor = Color.White;
		((Control)timedisplay).Font = new Font("Futura Bk BT", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)timedisplay).ForeColor = Color.FromArgb(35, 35, 35);
		Label obj = timedisplay;
		Point location = new Point(0, 28);
		((Control)obj).Location = location;
		((Control)timedisplay).Name = "timedisplay";
		Label obj2 = timedisplay;
		Size size = new Size(360, 65);
		((Control)obj2).Size = size;
		((Control)timedisplay).TabIndex = 30;
		timedisplay.Text = "Time";
		timedisplay.TextAlign = (ContentAlignment)32;
		((Control)timeformat).Anchor = (AnchorStyles)3;
		((Control)timeformat).BackColor = Color.White;
		((Control)timeformat).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)timeformat).ForeColor = Color.Gray;
		Label obj3 = timeformat;
		location = new Point(0, 103);
		((Control)obj3).Location = location;
		((Control)timeformat).Name = "timeformat";
		Label obj4 = timeformat;
		size = new Size(360, 31);
		((Control)obj4).Size = size;
		((Control)timeformat).TabIndex = 31;
		timeformat.Text = "HH:MM:SS TT";
		timeformat.TextAlign = (ContentAlignment)32;
		((Control)Label1).Anchor = (AnchorStyles)3;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.Black;
		Label label = Label1;
		location = new Point(0, 154);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(360, 31);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 32;
		Label1.Text = "System Time";
		Label1.TextAlign = (ContentAlignment)32;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(360, 200);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)timeformat);
		((Control)this).Controls.Add((Control)(object)timedisplay);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "desktime";
		((Form)this).TopMost = true;
		((Form)this).TransparencyKey = Color.WhiteSmoke;
		((Control)this).ResumeLayout(false);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		timedisplay.Text = Strings.Format((object)DateAndTime.Now, "hh:mm:ss tt");
	}

	private void desktime_Load(object sender, EventArgs e)
	{
		((Control)timedisplay).Width = ((Control)this).Width;
	}
}
