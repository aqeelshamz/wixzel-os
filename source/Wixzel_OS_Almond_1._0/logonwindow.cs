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
public class logonwindow : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

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
	public logonwindow()
	{
		((Form)this).Load += logonwindow_Load;
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
		components = new Container();
		Timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		Timer1.Enabled = true;
		Timer1.Interval = 2000;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.FromArgb(35, 35, 35);
		Size clientSize = new Size(284, 262);
		((Form)this).ClientSize = clientSize;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "logonwindow";
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).WindowState = (FormWindowState)2;
		((Control)this).ResumeLayout(false);
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		((Form)MyProject.Forms.int1).Close();
		((Form)MyProject.Forms.int2).Close();
		((Form)MyProject.Forms.int3).Close();
		((Form)MyProject.Forms.int4).Close();
		((Form)MyProject.Forms.int5).Close();
		((Form)MyProject.Forms.int6).Close();
		((Form)MyProject.Forms.int7).Close();
		((Form)MyProject.Forms.boot1).Close();
		((Form)MyProject.Forms.menuwxl).Opacity = 0.0;
		((Control)MyProject.Forms.menuwxl).Show();
		((Control)MyProject.Forms.menuwxl).Hide();
		((Form)MyProject.Forms.lockscreenback).Opacity = 0.0;
		((Control)MyProject.Forms.lockscreenback).Show();
		((Form)MyProject.Forms.menuwxl).Opacity = 100.0;
		((Form)MyProject.Forms.lockscreenback).Opacity = 100.0;
		Timer1.Enabled = false;
	}

	private void logonwindow_Load(object sender, EventArgs e)
	{
	}
}
