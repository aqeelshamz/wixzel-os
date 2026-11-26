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
public class setalarm : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("TextBox3")]
	private TextBox _TextBox3;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

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
			EventHandler eventHandler = TextBox1_Click;
			EventHandler eventHandler2 = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((TextBoxBase)_TextBox1).Click -= eventHandler;
				((Control)_TextBox1).TextChanged -= eventHandler2;
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((TextBoxBase)_TextBox1).Click += eventHandler;
				((Control)_TextBox1).TextChanged += eventHandler2;
			}
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
			EventHandler eventHandler = TextBox2_TextChanged;
			EventHandler eventHandler2 = TextBox2_Click;
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).TextChanged -= eventHandler;
				((TextBoxBase)_TextBox2).Click -= eventHandler2;
			}
			_TextBox2 = value;
			if (_TextBox2 != null)
			{
				((Control)_TextBox2).TextChanged += eventHandler;
				((TextBoxBase)_TextBox2).Click += eventHandler2;
			}
		}
	}

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
			_PictureBox1 = value;
		}
	}

	internal virtual TextBox TextBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = TextBox3_TextChanged;
			EventHandler eventHandler2 = TextBox3_Click;
			if (_TextBox3 != null)
			{
				((Control)_TextBox3).TextChanged -= eventHandler;
				((TextBoxBase)_TextBox3).Click -= eventHandler2;
			}
			_TextBox3 = value;
			if (_TextBox3 != null)
			{
				((Control)_TextBox3).TextChanged += eventHandler;
				((TextBoxBase)_TextBox3).Click += eventHandler2;
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
			_PictureBox3 = value;
		}
	}

	internal virtual PictureBox PictureBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox4_Click;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click -= eventHandler;
			}
			_PictureBox4 = value;
			if (_PictureBox4 != null)
			{
				((Control)_PictureBox4).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox5_Click;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click -= eventHandler;
			}
			_PictureBox5 = value;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click += eventHandler;
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
			EventHandler eventHandler = Label2_Click;
			if (_Label2 != null)
			{
				((Control)_Label2).Click -= eventHandler;
			}
			_Label2 = value;
			if (_Label2 != null)
			{
				((Control)_Label2).Click += eventHandler;
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
			EventHandler eventHandler = Label3_Click;
			if (_Label3 != null)
			{
				((Control)_Label3).Click -= eventHandler;
			}
			_Label3 = value;
			if (_Label3 != null)
			{
				((Control)_Label3).Click += eventHandler;
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
			EventHandler eventHandler = Label4_Click;
			if (_Label4 != null)
			{
				((Control)_Label4).Click -= eventHandler;
			}
			_Label4 = value;
			if (_Label4 != null)
			{
				((Control)_Label4).Click += eventHandler;
			}
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
			EventHandler eventHandler = Label5_Click;
			if (_Label5 != null)
			{
				((Control)_Label5).Click -= eventHandler;
			}
			_Label5 = value;
			if (_Label5 != null)
			{
				((Control)_Label5).Click += eventHandler;
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
			EventHandler eventHandler = Label6_Click;
			if (_Label6 != null)
			{
				((Control)_Label6).Click -= eventHandler;
			}
			_Label6 = value;
			if (_Label6 != null)
			{
				((Control)_Label6).Click += eventHandler;
			}
		}
	}

	[DebuggerNonUserCode]
	public setalarm()
	{
		((Control)this).Click += setalarm_Click;
		((Form)this).Load += setalarm_Load;
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_07c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(setalarm));
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		PictureBox1 = new PictureBox();
		TextBox3 = new TextBox();
		PictureBox3 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Timer1 = new Timer(components);
		Label6 = new Label();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.Transparent;
		((Control)Label1).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label1).ForeColor = Color.FromArgb(35, 35, 35);
		Label label = Label1;
		Point location = new Point(12, 9);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(109, 25);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 4;
		Label1.Text = "Set Alarm";
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox = PictureBox2;
		location = new Point(51, 70);
		((Control)pictureBox).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(49, 45);
		((Control)pictureBox2).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)1;
		PictureBox2.TabIndex = 6;
		PictureBox2.TabStop = false;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox = TextBox1;
		location = new Point(54, 75);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(42, 26);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 7;
		TextBox1.Text = "12";
		((TextBoxBase)TextBox2).BorderStyle = (BorderStyle)0;
		((Control)TextBox2).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox3 = TextBox2;
		location = new Point(121, 75);
		((Control)textBox3).Location = location;
		((Control)TextBox2).Name = "TextBox2";
		TextBox textBox4 = TextBox2;
		size = new Size(42, 26);
		((Control)textBox4).Size = size;
		((Control)TextBox2).TabIndex = 9;
		TextBox2.Text = "12";
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(118, 70);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(49, 45);
		((Control)pictureBox4).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 8;
		PictureBox1.TabStop = false;
		((TextBoxBase)TextBox3).BorderStyle = (BorderStyle)0;
		((Control)TextBox3).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox5 = TextBox3;
		location = new Point(187, 75);
		((Control)textBox5).Location = location;
		((Control)TextBox3).Name = "TextBox3";
		TextBox textBox6 = TextBox3;
		size = new Size(42, 26);
		((Control)textBox6).Size = size;
		((Control)TextBox3).TabIndex = 11;
		TextBox3.Text = "12";
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(184, 70);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(49, 45);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)1;
		PictureBox3.TabIndex = 10;
		PictureBox3.TabStop = false;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(309, 0);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(51, 34);
		((Control)pictureBox8).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 12;
		PictureBox4.TabStop = false;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox9 = PictureBox5;
		location = new Point(308, 72);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox10 = PictureBox5;
		size = new Size(40, 40);
		((Control)pictureBox10).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 13;
		PictureBox5.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.FromArgb(35, 35, 35);
		Label label3 = Label2;
		location = new Point(55, 121);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(44, 25);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 14;
		Label2.Text = "HH";
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.FromArgb(35, 35, 35);
		Label label5 = Label3;
		location = new Point(119, 121);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(50, 25);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 15;
		Label3.Text = "MM";
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.Transparent;
		((Control)Label4).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.FromArgb(35, 35, 35);
		Label label7 = Label4;
		location = new Point(192, 118);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(36, 25);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 16;
		Label4.Text = "SS";
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.Transparent;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.FromArgb(35, 35, 35);
		Label label9 = Label5;
		location = new Point(127, 9);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(20, 24);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 17;
		Label5.Text = "a";
		Timer1.Enabled = true;
		Timer1.Interval = 1;
		Label6.AutoSize = true;
		((Control)Label6).BackColor = Color.Transparent;
		((Control)Label6).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.FromArgb(35, 35, 35);
		Label label11 = Label6;
		location = new Point(244, 75);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(45, 25);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 18;
		Label6.Text = "AM";
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.Gainsboro;
		size = new Size(360, 187);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)TextBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)TextBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "setalarm";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)0;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void TextBox1_Click(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).SelectAll();
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 230:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0022;
						case 4:
						case 5:
							goto IL_0036;
						case 6:
							goto IL_005a;
						case 7:
						case 8:
							goto IL_006e;
						case 9:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
						case 11:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0036:
					num = 5;
					if (Conversions.ToDouble(TextBox1.Text) >= 12.0)
					{
						goto IL_005a;
					}
					goto IL_006e;
					IL_005a:
					num = 6;
					TextBox1.Text = "12";
					goto IL_006e;
					IL_0022:
					num = 3;
					TextBox1.Text = "";
					goto IL_0036;
					IL_006e:
					num = 8;
					if (Operators.CompareString(TextBox1.Text, "", false) != 0)
					{
						goto end_IL_0001_3;
					}
					break;
					IL_0009:
					num = 2;
					if (!Versioned.IsNumeric((object)TextBox1.Text))
					{
						goto IL_0022;
					}
					goto IL_0036;
					end_IL_0001_2:
					break;
				}
				num = 9;
				TextBox1.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 230;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox2_Click(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox2).SelectAll();
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 230:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0022;
						case 4:
						case 5:
							goto IL_0036;
						case 6:
							goto IL_005a;
						case 7:
						case 8:
							goto IL_006e;
						case 9:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
						case 11:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0036:
					num = 5;
					if (Conversions.ToDouble(TextBox2.Text) >= 59.0)
					{
						goto IL_005a;
					}
					goto IL_006e;
					IL_005a:
					num = 6;
					TextBox2.Text = "59";
					goto IL_006e;
					IL_0022:
					num = 3;
					TextBox2.Text = "";
					goto IL_0036;
					IL_006e:
					num = 8;
					if (Operators.CompareString(TextBox2.Text, "", false) != 0)
					{
						goto end_IL_0001_3;
					}
					break;
					IL_0009:
					num = 2;
					if (!Versioned.IsNumeric((object)TextBox2.Text))
					{
						goto IL_0022;
					}
					goto IL_0036;
					end_IL_0001_2:
					break;
				}
				num = 9;
				TextBox2.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 230;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void TextBox3_Click(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox3).SelectAll();
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
	}

	private void TextBox3_TextChanged(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 230:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0022;
						case 4:
						case 5:
							goto IL_0036;
						case 6:
							goto IL_005a;
						case 7:
						case 8:
							goto IL_006e;
						case 9:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 10:
						case 11:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0036:
					num = 5;
					if (Conversions.ToDouble(TextBox3.Text) >= 59.0)
					{
						goto IL_005a;
					}
					goto IL_006e;
					IL_005a:
					num = 6;
					TextBox3.Text = "59";
					goto IL_006e;
					IL_0022:
					num = 3;
					TextBox3.Text = "";
					goto IL_0036;
					IL_006e:
					num = 8;
					if (Operators.CompareString(TextBox3.Text, "", false) != 0)
					{
						goto end_IL_0001_3;
					}
					break;
					IL_0009:
					num = 2;
					if (!Versioned.IsNumeric((object)TextBox3.Text))
					{
						goto IL_0022;
					}
					goto IL_0036;
					end_IL_0001_2:
					break;
				}
				num = 9;
				TextBox1.Text = "";
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 230;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void PictureBox5_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
		if (!File.Exists(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt"))
		{
			File.Create(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt");
			FileSystem.FileClose(new int[0]);
		}
		int num = FileSystem.FreeFile();
		FileSystem.FileOpen(num, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FileClose(new int[0]);
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.clock.1.0\\alarm.txt", true);
		streamWriter.WriteLine(Label5.Text);
		streamWriter.Close();
		((Control)MyProject.Forms.dialog).Show();
		MyProject.Forms.dialog.Label1.Text = "Alarm Set for " + Label5.Text;
		MyProject.Forms.clock.ala1.Text = Label5.Text;
		((Form)this).Close();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Label5.Text = TextBox1.Text + ":" + TextBox2.Text + ":" + TextBox3.Text + " " + Label6.Text;
	}

	private void Label6_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(Label6.Text, "AM", false) == 0)
		{
			Label6.Text = "PM";
		}
		else
		{
			Label6.Text = "AM";
		}
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void setalarm_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void setalarm_Load(object sender, EventArgs e)
	{
		((Form)this).Location = ((Form)MyProject.Forms.clock).Location;
		((TextBoxBase)TextBox1).SelectAll();
		((TextBoxBase)TextBox2).SelectAll();
		((TextBoxBase)TextBox3).SelectAll();
	}

	private void Label1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void Label5_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void Label4_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void Label3_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void Label2_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		if (Operators.CompareString(TextBox2.Text, "1", false) == 0)
		{
			TextBox2.Text = "01";
		}
		if (Operators.CompareString(TextBox2.Text, "2", false) == 0)
		{
			TextBox2.Text = "02";
		}
		if (Operators.CompareString(TextBox2.Text, "3", false) == 0)
		{
			TextBox2.Text = "03";
		}
		if (Operators.CompareString(TextBox2.Text, "4", false) == 0)
		{
			TextBox2.Text = "04";
		}
		if (Operators.CompareString(TextBox2.Text, "5", false) == 0)
		{
			TextBox2.Text = "05";
		}
		if (Operators.CompareString(TextBox2.Text, "6", false) == 0)
		{
			TextBox2.Text = "06";
		}
		if (Operators.CompareString(TextBox2.Text, "7", false) == 0)
		{
			TextBox2.Text = "07";
		}
		if (Operators.CompareString(TextBox2.Text, "8", false) == 0)
		{
			TextBox2.Text = "08";
		}
		if (Operators.CompareString(TextBox2.Text, "9", false) == 0)
		{
			TextBox2.Text = "09";
		}
		if (Operators.CompareString(TextBox1.Text, "1", false) == 0)
		{
			TextBox1.Text = "01";
		}
		if (Operators.CompareString(TextBox1.Text, "2", false) == 0)
		{
			TextBox1.Text = "02";
		}
		if (Operators.CompareString(TextBox1.Text, "3", false) == 0)
		{
			TextBox1.Text = "03";
		}
		if (Operators.CompareString(TextBox1.Text, "4", false) == 0)
		{
			TextBox1.Text = "04";
		}
		if (Operators.CompareString(TextBox1.Text, "5", false) == 0)
		{
			TextBox1.Text = "05";
		}
		if (Operators.CompareString(TextBox1.Text, "6", false) == 0)
		{
			TextBox1.Text = "06";
		}
		if (Operators.CompareString(TextBox1.Text, "7", false) == 0)
		{
			TextBox1.Text = "07";
		}
		if (Operators.CompareString(TextBox1.Text, "8", false) == 0)
		{
			TextBox1.Text = "08";
		}
		if (Operators.CompareString(TextBox1.Text, "9", false) == 0)
		{
			TextBox1.Text = "09";
		}
		if (Operators.CompareString(TextBox3.Text, "1", false) == 0)
		{
			TextBox3.Text = "01";
		}
		if (Operators.CompareString(TextBox3.Text, "2", false) == 0)
		{
			TextBox3.Text = "02";
		}
		if (Operators.CompareString(TextBox3.Text, "3", false) == 0)
		{
			TextBox3.Text = "03";
		}
		if (Operators.CompareString(TextBox3.Text, "4", false) == 0)
		{
			TextBox3.Text = "04";
		}
		if (Operators.CompareString(TextBox3.Text, "5", false) == 0)
		{
			TextBox3.Text = "05";
		}
		if (Operators.CompareString(TextBox3.Text, "6", false) == 0)
		{
			TextBox3.Text = "06";
		}
		if (Operators.CompareString(TextBox3.Text, "7", false) == 0)
		{
			TextBox3.Text = "07";
		}
		if (Operators.CompareString(TextBox3.Text, "8", false) == 0)
		{
			TextBox3.Text = "08";
		}
		if (Operators.CompareString(TextBox3.Text, "9", false) == 0)
		{
			TextBox3.Text = "09";
		}
	}
}
