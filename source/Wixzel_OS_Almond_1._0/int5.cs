using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class int5 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("off")]
	private PictureBox _off;

	[AccessedThroughProperty("onn")]
	private PictureBox _onn;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			KeyPressEventHandler val = new KeyPressEventHandler(TextBox1_KeyPress);
			EventHandler eventHandler = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).KeyPress -= val;
				((Control)_TextBox1).TextChanged -= eventHandler;
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).KeyPress += val;
				((Control)_TextBox1).TextChanged += eventHandler;
			}
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
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click -= eventHandler;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click -= eventHandler;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox off
	{
		[DebuggerNonUserCode]
		get
		{
			return _off;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_off = value;
		}
	}

	internal virtual PictureBox onn
	{
		[DebuggerNonUserCode]
		get
		{
			return _onn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_onn = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
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
	public int5()
	{
		((Form)this).Load += int5_Load;
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
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(int5));
		PictureBox1 = new PictureBox();
		TextBox1 = new TextBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		off = new PictureBox();
		onn = new PictureBox();
		Panel1 = new Panel();
		Label9 = new Label();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)off).BeginInit();
		((ISupportInitialize)onn).BeginInit();
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
		PictureBox1.TabIndex = 3;
		PictureBox1.TabStop = false;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Microsoft Sans Serif", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		TextBox textBox = TextBox1;
		location = new Point(468, 327);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(336, 31);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 4;
		((Control)PictureBox2).BackColor = Color.Transparent;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(427, 378);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(30, 30);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 5;
		PictureBox2.TabStop = false;
		((Control)PictureBox2).Visible = false;
		((Control)PictureBox3).BackColor = Color.Transparent;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(427, 437);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(30, 30);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 6;
		PictureBox3.TabStop = false;
		((Control)PictureBox3).Visible = false;
		((Control)off).BackColor = Color.Transparent;
		off.Image = (Image)componentResourceManager.GetObject("off.Image");
		PictureBox obj = off;
		location = new Point(349, 404);
		((Control)obj).Location = location;
		((Control)off).Name = "off";
		PictureBox obj2 = off;
		size = new Size(30, 30);
		((Control)obj2).Size = size;
		off.SizeMode = (PictureBoxSizeMode)2;
		off.TabIndex = 7;
		off.TabStop = false;
		((Control)off).Visible = false;
		((Control)onn).BackColor = Color.Transparent;
		onn.Image = (Image)componentResourceManager.GetObject("onn.Image");
		PictureBox obj3 = onn;
		location = new Point(313, 404);
		((Control)obj3).Location = location;
		((Control)onn).Name = "onn";
		PictureBox obj4 = onn;
		size = new Size(30, 30);
		((Control)obj4).Size = size;
		onn.SizeMode = (PictureBoxSizeMode)2;
		onn.TabIndex = 8;
		onn.TabStop = false;
		((Control)onn).Visible = false;
		((Control)Panel1).BackColor = Color.FromArgb(247, 247, 247);
		Panel panel = Panel1;
		location = new Point(468, 422);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(536, 134);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 9;
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.White;
		((Control)Label9).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.RoyalBlue;
		Label label = Label9;
		location = new Point(1246, 683);
		((Control)label).Location = location;
		((Control)Label9).Name = "Label9";
		Label label2 = Label9;
		size = new Size(49, 19);
		((Control)label2).Size = size;
		((Control)Label9).TabIndex = 26;
		Label9.Text = "NEXT";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Control)this).BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		size = new Size(1360, 768);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)onn);
		((Control)this).Controls.Add((Control)(object)off);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).DoubleBuffered = true;
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "int5";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((Form)this).WindowState = (FormWindowState)2;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)off).EndInit();
		((ISupportInitialize)onn).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		if (Strings.InStr(TextBox1.Text, "@", (CompareMethod)0) != 0)
		{
			((Control)MyProject.Forms.int6).Show();
			return;
		}
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "Enter a valid email address";
	}

	private void int5_Load(object sender, EventArgs e)
	{
		TextBox textBox = TextBox1;
		checked
		{
			Point location = new Point((int)Math.Round((double)((Control)this).Width / 2.0 - (double)((Control)PictureBox1).Width / 2.0 - 200.0), (int)Math.Round((double)((Control)this).Height / 2.0 - 70.0));
			((Control)textBox).Location = location;
			PictureBox pictureBox = PictureBox1;
			location = new Point(((Control)this).Width - ((Control)PictureBox1).Width - 15, ((Control)this).Height - ((Control)PictureBox1).Height - 50);
			((Control)pictureBox).Location = location;
			Label label = Label9;
			location = ((Control)PictureBox1).Location;
			Point location2 = new Point(location.X + 26, ((Control)PictureBox1).Location.Y + 8);
			((Control)label).Location = location2;
			location = (((Control)Panel1).Location = new Point(((Control)TextBox1).Location.X, ((Control)TextBox1).Location.Y + 100));
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			((Control)this).Width = width;
			((Control)this).Height = height;
			PictureBox2.Image = onn.Image;
			PictureBox3.Image = onn.Image;
		}
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			if (Strings.InStr(TextBox1.Text, "@", (CompareMethod)0) != 0)
			{
				((Control)MyProject.Forms.int6).Show();
				return;
			}
			((Control)MyProject.Forms.dialog).Show();
			MyProject.Forms.dialog.Label1.Text = "Enter a valid email address";
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		if (((object)PictureBox2.Image).Equals((object?)onn.Image))
		{
			PictureBox2.Image = off.Image;
		}
		else
		{
			PictureBox2.Image = onn.Image;
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		if (((object)PictureBox3.Image).Equals((object?)onn.Image))
		{
			PictureBox3.Image = off.Image;
		}
		else
		{
			PictureBox3.Image = onn.Image;
		}
	}

	private void Label9_Click(object sender, EventArgs e)
	{
		if (Strings.InStr(TextBox1.Text, "@", (CompareMethod)0) != 0)
		{
			((Control)MyProject.Forms.int6).Show();
			return;
		}
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "Enter a valid email address";
	}
}
