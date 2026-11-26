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
public class taskshow : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("taskclose")]
	private Label _taskclose;

	[AccessedThroughProperty("apptitile")]
	private Label _apptitile;

	[AccessedThroughProperty("taskpic")]
	private PictureBox _taskpic;

	internal virtual Label taskclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _taskclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_taskclose = value;
		}
	}

	internal virtual Label apptitile
	{
		[DebuggerNonUserCode]
		get
		{
			return _apptitile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_apptitile = value;
		}
	}

	internal virtual PictureBox taskpic
	{
		[DebuggerNonUserCode]
		get
		{
			return _taskpic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_taskpic = value;
		}
	}

	[DebuggerNonUserCode]
	public taskshow()
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
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		taskclose = new Label();
		apptitile = new Label();
		taskpic = new PictureBox();
		((ISupportInitialize)taskpic).BeginInit();
		((Control)this).SuspendLayout();
		taskclose.AutoSize = true;
		((Control)taskclose).BackColor = Color.White;
		((Control)taskclose).Font = new Font("Futura Bk BT", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj = taskclose;
		Point location = new Point(122, 4);
		((Control)obj).Location = location;
		((Control)taskclose).Name = "taskclose";
		Label obj2 = taskclose;
		Size size = new Size(13, 14);
		((Control)obj2).Size = size;
		((Control)taskclose).TabIndex = 41;
		taskclose.Text = "X";
		apptitile.AutoSize = true;
		((Control)apptitile).BackColor = Color.White;
		((Control)apptitile).Font = new Font("Futura Bk BT", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label obj3 = apptitile;
		location = new Point(4, 4);
		((Control)obj3).Location = location;
		((Control)apptitile).Name = "apptitile";
		Label obj4 = apptitile;
		size = new Size(26, 14);
		((Control)obj4).Size = size;
		((Control)apptitile).TabIndex = 40;
		apptitile.Text = "App";
		((Control)taskpic).BackColor = Color.Silver;
		PictureBox obj5 = taskpic;
		location = new Point(0, 20);
		((Control)obj5).Location = location;
		((Control)taskpic).Name = "taskpic";
		PictureBox obj6 = taskpic;
		size = new Size(140, 85);
		((Control)obj6).Size = size;
		taskpic.SizeMode = (PictureBoxSizeMode)4;
		taskpic.TabIndex = 39;
		taskpic.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(140, 105);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)taskclose);
		((Control)this).Controls.Add((Control)(object)apptitile);
		((Control)this).Controls.Add((Control)(object)taskpic);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "taskshow";
		((Form)this).TopMost = true;
		((ISupportInitialize)taskpic).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
