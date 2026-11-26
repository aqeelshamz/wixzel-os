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
public class deskdate : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("dateformat")]
	private Label _dateformat;

	[AccessedThroughProperty("datedisplay")]
	private Label _datedisplay;

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
			_Label1 = value;
		}
	}

	internal virtual Label dateformat
	{
		[DebuggerNonUserCode]
		get
		{
			return _dateformat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_dateformat = value;
		}
	}

	internal virtual Label datedisplay
	{
		[DebuggerNonUserCode]
		get
		{
			return _datedisplay;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = datedisplay_Click;
			if (_datedisplay != null)
			{
				((Control)_datedisplay).Click -= eventHandler;
			}
			_datedisplay = value;
			if (_datedisplay != null)
			{
				((Control)_datedisplay).Click += eventHandler;
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
	public deskdate()
	{
		((Form)this).Load += deskdate_Load;
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
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		components = new Container();
		Label1 = new Label();
		dateformat = new Label();
		datedisplay = new Label();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)Label1).Anchor = (AnchorStyles)3;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.Black;
		Label label = Label1;
		Point location = new Point(0, 148);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(360, 31);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 35;
		Label1.Text = "System Date";
		Label1.TextAlign = (ContentAlignment)32;
		((Control)dateformat).Anchor = (AnchorStyles)3;
		((Control)dateformat).BackColor = Color.White;
		((Control)dateformat).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)dateformat).ForeColor = Color.Gray;
		Label obj = dateformat;
		location = new Point(0, 97);
		((Control)obj).Location = location;
		((Control)dateformat).Name = "dateformat";
		Label obj2 = dateformat;
		size = new Size(360, 31);
		((Control)obj2).Size = size;
		((Control)dateformat).TabIndex = 34;
		dateformat.Text = "DD MMM YYYY";
		dateformat.TextAlign = (ContentAlignment)32;
		((Control)datedisplay).Anchor = (AnchorStyles)3;
		((Control)datedisplay).BackColor = Color.White;
		((Control)datedisplay).Font = new Font("Futura Bk BT", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)datedisplay).ForeColor = Color.FromArgb(35, 35, 35);
		Label obj3 = datedisplay;
		location = new Point(0, 22);
		((Control)obj3).Location = location;
		((Control)datedisplay).Name = "datedisplay";
		Label obj4 = datedisplay;
		size = new Size(360, 65);
		((Control)obj4).Size = size;
		((Control)datedisplay).TabIndex = 33;
		datedisplay.Text = "Date";
		datedisplay.TextAlign = (ContentAlignment)32;
		Timer1.Enabled = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(360, 200);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)dateformat);
		((Control)this).Controls.Add((Control)(object)datedisplay);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "deskdate";
		((Form)this).TopMost = true;
		((Form)this).TransparencyKey = Color.WhiteSmoke;
		((Control)this).ResumeLayout(false);
	}

	private void datedisplay_Click(object sender, EventArgs e)
	{
	}

	private void deskdate_Load(object sender, EventArgs e)
	{
		((Control)datedisplay).Width = ((Control)this).Width;
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		datedisplay.Text = Strings.Format((object)DateAndTime.Now, "dd MMM yyyy");
	}
}
