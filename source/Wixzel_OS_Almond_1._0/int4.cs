using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class int4 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

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

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
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
			EventHandler eventHandler = Label1_Click;
			if (_Label1 != null)
			{
				((Control)_Label1).Click -= eventHandler;
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label9_Click;
			if (_Label9 != null)
			{
				((Control)_Label9).Click -= eventHandler;
			}
			_Label9 = value;
			if (_Label9 != null)
			{
				((Control)_Label9).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public int4()
	{
		((Form)this).Load += int4_Load;
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
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(int4));
		PictureBox1 = new PictureBox();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Label1 = new Label();
		Label9 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)PictureBox1).BackColor = Color.Transparent;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(1219, 675);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(102, 34);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 2;
		PictureBox1.TabStop = false;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Microsoft Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		TextBox textBox = TextBox1;
		location = new Point(468, 377);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(336, 31);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 3;
		((TextBoxBase)TextBox2).BorderStyle = (BorderStyle)0;
		((Control)TextBox2).Font = new Font("Microsoft Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		TextBox textBox3 = TextBox2;
		location = new Point(468, 461);
		((Control)textBox3).Location = location;
		((Control)TextBox2).Name = "TextBox2";
		TextBox2.PasswordChar = '•';
		TextBox textBox4 = TextBox2;
		size = new Size(336, 31);
		((Control)textBox4).Size = size;
		((Control)TextBox2).TabIndex = 4;
		((Control)Label1).Anchor = (AnchorStyles)15;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.DodgerBlue;
		Label label = Label1;
		location = new Point(810, 470);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(41, 16);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 5;
		Label1.Text = "Show";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.White;
		((Control)Label9).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.RoyalBlue;
		Label label3 = Label9;
		location = new Point(1245, 683);
		((Control)label3).Location = location;
		((Control)Label9).Name = "Label9";
		Label label4 = Label9;
		size = new Size(49, 19);
		((Control)label4).Size = size;
		((Control)Label9).TabIndex = 25;
		Label9.Text = "NEXT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		size = new Size(1360, 768);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)TextBox2);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).DoubleBuffered = true;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "int4";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void PictureBox1_Click(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file"))
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(num, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.FileClose(new int[0]);
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file", true);
		streamWriter.WriteLine(TextBox1.Text);
		streamWriter.Close();
		((Control)MyProject.Forms.int5).Show();
	}

	private void int4_Load(object sender, EventArgs e)
	{
		TextBox textBox = TextBox1;
		checked
		{
			Point location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)TextBox1).Width / 2.0 - 70.0), (int)Math.Round((double)((Control)this).Height / 2.0 - 10.0));
			((Control)textBox).Location = location;
			TextBox textBox2 = TextBox2;
			int x = ((Control)TextBox1).Location.X;
			location = ((Control)TextBox1).Location;
			Point location2 = new Point(x, location.Y + 90);
			((Control)textBox2).Location = location2;
			location = (((Control)Label1).Location = new Point(((Control)TextBox2).Location.X + 342, ((Control)TextBox2).Location.Y + 10));
			PictureBox pictureBox = PictureBox1;
			location2 = new Point(((Control)this).Width - ((Control)PictureBox1).Width - 15, ((Control)this).Height - ((Control)PictureBox1).Height - 50);
			((Control)pictureBox).Location = location2;
			location = (((Control)Label9).Location = new Point(((Control)PictureBox1).Location.X + 26, ((Control)PictureBox1).Location.Y + 8));
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			((Control)this).Width = width;
			((Control)this).Height = height;
		}
	}

	private void Label1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label1.Text, "Show", false) == 0)
		{
			TextBox2.PasswordChar = '\0';
			Label1.Text = "Hide";
		}
		else
		{
			TextBox2.PasswordChar = '•';
			Label1.Text = "Show";
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void Label9_Click(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).FileSystem.FileExists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file"))
		{
			int num = FileSystem.FreeFile();
			FileSystem.FileOpen(num, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
			FileSystem.FileClose(new int[0]);
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file", true);
		streamWriter.WriteLine(TextBox1.Text);
		streamWriter.Close();
		((Control)MyProject.Forms.int5).Show();
	}
}
