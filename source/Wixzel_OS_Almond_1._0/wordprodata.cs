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
public class wordprodata : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("bold")]
	private Label _bold;

	[AccessedThroughProperty("italic")]
	private Label _italic;

	[AccessedThroughProperty("under")]
	private Label _under;

	[AccessedThroughProperty("strike")]
	private Label _strike;

	internal virtual Label bold
	{
		[DebuggerNonUserCode]
		get
		{
			return _bold;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_bold = value;
		}
	}

	internal virtual Label italic
	{
		[DebuggerNonUserCode]
		get
		{
			return _italic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_italic = value;
		}
	}

	internal virtual Label under
	{
		[DebuggerNonUserCode]
		get
		{
			return _under;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_under = value;
		}
	}

	internal virtual Label strike
	{
		[DebuggerNonUserCode]
		get
		{
			return _strike;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_strike = value;
		}
	}

	[DebuggerNonUserCode]
	public wordprodata()
	{
		((Form)this).Load += wordprodata_Load;
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
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		bold = new Label();
		italic = new Label();
		under = new Label();
		strike = new Label();
		((Control)this).SuspendLayout();
		bold.AutoSize = true;
		((Control)bold).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj = bold;
		Point location = new Point(22, 15);
		((Control)obj).Location = location;
		((Control)bold).Name = "bold";
		Label obj2 = bold;
		Size size = new Size(34, 18);
		((Control)obj2).Size = size;
		((Control)bold).TabIndex = 0;
		bold.Text = "null";
		italic.AutoSize = true;
		((Control)italic).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj3 = italic;
		location = new Point(22, 37);
		((Control)obj3).Location = location;
		((Control)italic).Name = "italic";
		Label obj4 = italic;
		size = new Size(34, 18);
		((Control)obj4).Size = size;
		((Control)italic).TabIndex = 1;
		italic.Text = "null";
		under.AutoSize = true;
		((Control)under).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj5 = under;
		location = new Point(22, 60);
		((Control)obj5).Location = location;
		((Control)under).Name = "under";
		Label obj6 = under;
		size = new Size(34, 18);
		((Control)obj6).Size = size;
		((Control)under).TabIndex = 2;
		under.Text = "null";
		strike.AutoSize = true;
		((Control)strike).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj7 = strike;
		location = new Point(22, 85);
		((Control)obj7).Location = location;
		((Control)strike).Name = "strike";
		Label obj8 = strike;
		size = new Size(34, 18);
		((Control)obj8).Size = size;
		((Control)strike).TabIndex = 3;
		strike.Text = "null";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(97, 122);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)strike);
		((Control)this).Controls.Add((Control)(object)under);
		((Control)this).Controls.Add((Control)(object)italic);
		((Control)this).Controls.Add((Control)(object)bold);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "wordprodata";
		((Form)this).ShowInTaskbar = false;
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void wordprodata_Load(object sender, EventArgs e)
	{
	}
}
