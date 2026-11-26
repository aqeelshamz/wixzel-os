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
public class tts : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	private Point mouse_move;

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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(Label1_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(Label1_MouseDown);
			EventHandler eventHandler = Label1_Click;
			if (_Label1 != null)
			{
				((Control)_Label1).MouseMove -= val;
				((Control)_Label1).MouseDown -= val2;
				((Control)_Label1).Click -= eventHandler;
			}
			_Label1 = value;
			if (_Label1 != null)
			{
				((Control)_Label1).MouseMove += val;
				((Control)_Label1).MouseDown += val2;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox2_Click;
			EventHandler eventHandler2 = PictureBox2_MouseLeave;
			MouseEventHandler val = new MouseEventHandler(PictureBox2_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox2_MouseDown);
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click -= eventHandler;
				((Control)_PictureBox2).MouseLeave -= eventHandler2;
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).MouseDown -= val2;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click += eventHandler;
				((Control)_PictureBox2).MouseLeave += eventHandler2;
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).MouseDown += val2;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox1_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox1_MouseDown);
			EventHandler eventHandler = PictureBox1_Click;
			InvalidateEventHandler val3 = new InvalidateEventHandler(PictureBox1_Invalidated);
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove -= val;
				((Control)_PictureBox1).MouseDown -= val2;
				((Control)_PictureBox1).Click -= eventHandler;
				((Control)_PictureBox1).Invalidated -= val3;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove += val;
				((Control)_PictureBox1).MouseDown += val2;
				((Control)_PictureBox1).Click += eventHandler;
				((Control)_PictureBox1).Invalidated += val3;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox3_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox3_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox3_MouseDown);
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click -= eventHandler;
				((Control)_PictureBox3).MouseMove -= val;
				((Control)_PictureBox3).MouseDown -= val2;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click += eventHandler;
				((Control)_PictureBox3).MouseMove += val;
				((Control)_PictureBox3).MouseDown += val2;
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

	internal virtual PictureBox defaultclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _defaultclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_defaultclose = value;
		}
	}

	internal virtual PictureBox hoverclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _hoverclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_hoverclose = value;
		}
	}

	internal virtual PictureBox clickclose
	{
		[DebuggerNonUserCode]
		get
		{
			return _clickclose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_clickclose = value;
		}
	}

	internal virtual PictureBox PictureBox7
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox7 = value;
		}
	}

	[DebuggerNonUserCode]
	public tts()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(tts_FormClosing);
		((Form)this).Load += tts_Load;
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
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_0679: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(tts));
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		PictureBox3 = new PictureBox();
		Label2 = new Label();
		TextBox1 = new TextBox();
		PictureBox4 = new PictureBox();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox7 = new PictureBox();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((Control)this).SuspendLayout();
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		Point location = new Point(33, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		Size size = new Size(148, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 8;
		Label1.Text = "TTS - Text to Speech";
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox = PictureBox2;
		location = new Point(309, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox2 = PictureBox2;
		size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 6;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(1400, 35);
		((Control)pictureBox4).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 5;
		PictureBox1.TabStop = false;
		((Control)PictureBox3).BackColor = Color.White;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(5, -1);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(22, 35);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 7;
		PictureBox3.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label3 = Label2;
		location = new Point(12, 48);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(319, 19);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 9;
		Label2.Text = "Enter text below and press play button:";
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		TextBox textBox = TextBox1;
		location = new Point(12, 71);
		((Control)textBox).Location = location;
		TextBox1.Multiline = true;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(336, 229);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 10;
		((Control)PictureBox4).BackColor = Color.Transparent;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox7 = PictureBox4;
		location = new Point(284, 300);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox8 = PictureBox4;
		size = new Size(64, 64);
		((Control)pictureBox8).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 11;
		PictureBox4.TabStop = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj = defaultclose;
		location = new Point(143, -1);
		((Control)obj).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj2 = defaultclose;
		size = new Size(51, 34);
		((Control)obj2).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj3 = hoverclose;
		location = new Point(200, -1);
		((Control)obj3).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj4 = hoverclose;
		size = new Size(51, 34);
		((Control)obj4).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj5 = clickclose;
		location = new Point(257, -1);
		((Control)obj5).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj6 = clickclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox9 = PictureBox7;
		location = new Point(257, 1);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox10 = PictureBox7;
		size = new Size(51, 34);
		((Control)pictureBox10).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 118;
		PictureBox7.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.SlateBlue;
		size = new Size(360, 360);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "tts";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Label2_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("SAPI.spvoice", ""));
		object[] array = new object[1];
		TextBox textBox = TextBox1;
		array[0] = textBox.Text;
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		NewLateBinding.LateCall(objectValue, (Type)null, "speak", array2, (string[])null, (Type[])null, array3, true);
		if (array3[0])
		{
			textBox.Text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string));
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void tts_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.ttsout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.ttss.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void tts_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = PictureBox2;
		checked
		{
			Point location = new Point(((Control)this).Width - ((Control)PictureBox2).Width, 0);
			((Control)pictureBox).Location = location;
			PictureBox pictureBox2 = PictureBox7;
			Point location2 = new Point(((Control)PictureBox2).Location.X - ((Control)PictureBox7).Width, ((Control)PictureBox2).Location.Y);
			((Control)pictureBox2).Location = location2;
			if (!((Control)MyProject.Forms.home.app1).Enabled)
			{
				((Control)MyProject.Forms.home.app1).Enabled = true;
				MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app2).Enabled)
			{
				((Control)MyProject.Forms.home.app2).Enabled = true;
				MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app3).Enabled)
			{
				((Control)MyProject.Forms.home.app3).Enabled = true;
				MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app4).Enabled)
			{
				((Control)MyProject.Forms.home.app4).Enabled = true;
				MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app5).Enabled)
			{
				((Control)MyProject.Forms.home.app5).Enabled = true;
				MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app6).Enabled)
			{
				((Control)MyProject.Forms.home.app6).Enabled = true;
				MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app7).Enabled)
			{
				((Control)MyProject.Forms.home.app7).Enabled = true;
				MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app8).Enabled)
			{
				((Control)MyProject.Forms.home.app8).Enabled = true;
				MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app9).Enabled)
			{
				((Control)MyProject.Forms.home.app9).Enabled = true;
				MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app10).Enabled)
			{
				((Control)MyProject.Forms.home.app10).Enabled = true;
				MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app11).Enabled)
			{
				((Control)MyProject.Forms.home.app11).Enabled = true;
				MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app12).Enabled)
			{
				((Control)MyProject.Forms.home.app12).Enabled = true;
				MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app13).Enabled)
			{
				((Control)MyProject.Forms.home.app13).Enabled = true;
				MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app14).Enabled)
			{
				((Control)MyProject.Forms.home.app14).Enabled = true;
				MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app15).Enabled)
			{
				((Control)MyProject.Forms.home.app15).Enabled = true;
				MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app16).Enabled)
			{
				((Control)MyProject.Forms.home.app16).Enabled = true;
				MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app17).Enabled)
			{
				((Control)MyProject.Forms.home.app17).Enabled = true;
				MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app18).Enabled)
			{
				((Control)MyProject.Forms.home.app18).Enabled = true;
				MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app19).Enabled)
			{
				((Control)MyProject.Forms.home.app19).Enabled = true;
				MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app20).Enabled)
			{
				((Control)MyProject.Forms.home.app20).Enabled = true;
				MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app21).Enabled)
			{
				((Control)MyProject.Forms.home.app21).Enabled = true;
				MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app22).Enabled)
			{
				((Control)MyProject.Forms.home.app22).Enabled = true;
				MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app23).Enabled)
			{
				((Control)MyProject.Forms.home.app23).Enabled = true;
				MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app24).Enabled)
			{
				((Control)MyProject.Forms.home.app24).Enabled = true;
				MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.ttss.Image;
			}
			else if (!((Control)MyProject.Forms.home.app25).Enabled)
			{
				((Control)MyProject.Forms.home.app25).Enabled = true;
				MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.ttss.Image;
			}
			Fade.ttsin();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox1_Invalidated(object sender, InvalidateEventArgs e)
	{
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	private void Label1_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void Label1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			Point mousePosition = Control.MousePosition;
			mousePosition.Offset(mouse_move.X, mouse_move.Y);
			((Form)this).Location = mousePosition;
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			Point mousePosition = Control.MousePosition;
			mousePosition.Offset(mouse_move.X, mouse_move.Y);
			((Form)this).Location = mousePosition;
		}
	}

	private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)e.Button == 1048576)
		{
			Point mousePosition = Control.MousePosition;
			mousePosition.Offset(mouse_move.X, mouse_move.Y);
			((Form)this).Location = mousePosition;
		}
	}

	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)Control.MouseButtons == 1048576)
		{
			PictureBox2.Image = clickclose.Image;
		}
	}

	private void PictureBox2_MouseLeave(object sender, EventArgs e)
	{
		PictureBox2.Image = defaultclose.Image;
	}

	private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
	{
		if (!((object)PictureBox2.Image).Equals((object?)clickclose.Image))
		{
			PictureBox2.Image = hoverclose.Image;
		}
	}
}
