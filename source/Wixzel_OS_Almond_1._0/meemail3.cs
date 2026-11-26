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
public class meemail3 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("head")]
	private Label _head;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	private Point mouse_move;

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
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
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox3_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox3_MouseMove);
			EventHandler eventHandler2 = PictureBox3_MouseLeave;
			MouseEventHandler val2 = new MouseEventHandler(PictureBox3_MouseDown);
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click -= eventHandler;
				((Control)_PictureBox3).MouseMove -= val;
				((Control)_PictureBox3).MouseLeave -= eventHandler2;
				((Control)_PictureBox3).MouseDown -= val2;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).Click += eventHandler;
				((Control)_PictureBox3).MouseMove += val;
				((Control)_PictureBox3).MouseLeave += eventHandler2;
				((Control)_PictureBox3).MouseDown += val2;
			}
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox2_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox2_MouseDown);
			EventHandler eventHandler = PictureBox2_Click;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).MouseDown -= val2;
				((Control)_PictureBox2).Click -= eventHandler;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).MouseDown += val2;
				((Control)_PictureBox2).Click += eventHandler;
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
			MouseEventHandler val = new MouseEventHandler(PictureBox1_MouseMove);
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove -= val;
				((Control)_PictureBox1).Click -= eventHandler;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove += val;
				((Control)_PictureBox1).Click += eventHandler;
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
			_Label4 = value;
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
			_Label3 = value;
		}
	}

	internal virtual Label head
	{
		[DebuggerNonUserCode]
		get
		{
			return _head;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_head = value;
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
			_Label9 = value;
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

	internal virtual PictureBox PictureBox6
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox6 = value;
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
			_PictureBox4 = value;
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
			_Label5 = value;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox5_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox5_MouseDown);
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click -= eventHandler;
				((Control)_PictureBox5).MouseDown -= val;
			}
			_PictureBox5 = value;
			if (_PictureBox5 != null)
			{
				((Control)_PictureBox5).Click += eventHandler;
				((Control)_PictureBox5).MouseDown += val;
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
	public meemail3()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(meemail3_FormClosing);
		((Form)this).Load += meemail3_Load;
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
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_078e: Expected O, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected O, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f9: Expected O, but got Unknown
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected O, but got Unknown
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4b: Expected O, but got Unknown
		//IL_0be0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bea: Expected O, but got Unknown
		//IL_0c88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c92: Expected O, but got Unknown
		//IL_0d30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3a: Expected O, but got Unknown
		//IL_0dc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd1: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(meemail3));
		Label8 = new Label();
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Label4 = new Label();
		Label3 = new Label();
		head = new Label();
		Label9 = new Label();
		TextBox1 = new TextBox();
		PictureBox6 = new PictureBox();
		Label2 = new Label();
		TextBox2 = new TextBox();
		PictureBox4 = new PictureBox();
		Label5 = new Label();
		PictureBox5 = new PictureBox();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox7 = new PictureBox();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((Control)this).SuspendLayout();
		Label8.AutoSize = true;
		((Control)Label8).BackColor = Color.Transparent;
		((Control)Label8).Font = new Font("Microsoft Sans Serif", 8.999999f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label = Label8;
		Point location = new Point(408, 628);
		((Control)label).Location = location;
		((Control)Label8).Name = "Label8";
		Label label2 = Label8;
		Size size = new Size(97, 15);
		((Control)label2).Size = size;
		((Control)Label8).TabIndex = 30;
		Label8.Text = "Mee Mail v1.0";
		((Control)PictureBox3).BackColor = Color.White;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		location = new Point(449, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 20;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label3 = Label1;
		location = new Point(34, 7);
		((Control)label3).Location = location;
		((Control)Label1).Name = "Label1";
		Label label4 = Label1;
		size = new Size(199, 20);
		((Control)label4).Size = size;
		((Control)Label1).TabIndex = 19;
		Label1.Text = "Mee Mail - Add Account";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(6, 6);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(22, 22);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 18;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox5 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox6 = PictureBox1;
		size = new Size(1000, 35);
		((Control)pictureBox6).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 17;
		PictureBox1.TabStop = false;
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.Transparent;
		((Control)Label4).Font = new Font("Microsoft Sans Serif", 8.999999f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label5 = Label4;
		location = new Point(14, 610);
		((Control)label5).Location = location;
		((Control)Label4).Name = "Label4";
		Label label6 = Label4;
		size = new Size(132, 15);
		((Control)label6).Size = size;
		((Control)Label4).TabIndex = 24;
		Label4.Text = "Mee Mail Supports:";
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Microsoft Sans Serif", 8.999999f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label7 = Label3;
		location = new Point(14, 628);
		((Control)label7).Location = location;
		((Control)Label3).Name = "Label3";
		Label label8 = Label3;
		size = new Size(350, 15);
		((Control)label8).Size = size;
		((Control)Label3).TabIndex = 23;
		Label3.Text = "Gmail • Outlook • Msn • Yahoo • Lycos • Aol • Netscape • Rediff";
		head.AutoSize = true;
		((Control)head).BackColor = Color.Transparent;
		((Control)head).Font = new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)head).ForeColor = Color.White;
		Label obj = head;
		location = new Point(12, 44);
		((Control)obj).Location = location;
		((Control)head).Name = "head";
		Label obj2 = head;
		size = new Size(212, 37);
		((Control)obj2).Size = size;
		((Control)head).TabIndex = 31;
		head.Text = "Add Account";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.White;
		Label label9 = Label9;
		location = new Point(14, 97);
		((Control)label9).Location = location;
		((Control)Label9).Name = "Label9";
		Label label10 = Label9;
		size = new Size(408, 20);
		((Control)label10).Size = size;
		((Control)Label9).TabIndex = 33;
		Label9.Text = "Adding a account will remove the current account.";
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox = TextBox1;
		location = new Point(125, 225);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(259, 22);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 36;
		((Control)PictureBox6).BackColor = Color.Transparent;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox7 = PictureBox6;
		location = new Point(120, 219);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox8 = PictureBox6;
		size = new Size(270, 36);
		((Control)pictureBox8).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)1;
		PictureBox6.TabIndex = 35;
		PictureBox6.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label11 = Label2;
		location = new Point(116, 192);
		((Control)label11).Location = location;
		((Control)Label2).Name = "Label2";
		Label label12 = Label2;
		size = new Size(68, 24);
		((Control)label12).Size = size;
		((Control)Label2).TabIndex = 34;
		Label2.Text = "Email:";
		((TextBoxBase)TextBox2).BorderStyle = (BorderStyle)0;
		((Control)TextBox2).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox3 = TextBox2;
		location = new Point(125, 306);
		((Control)textBox3).Location = location;
		((Control)TextBox2).Name = "TextBox2";
		TextBox2.PasswordChar = '•';
		TextBox textBox4 = TextBox2;
		size = new Size(259, 22);
		((Control)textBox4).Size = size;
		((Control)TextBox2).TabIndex = 39;
		((Control)PictureBox4).BackColor = Color.Transparent;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox9 = PictureBox4;
		location = new Point(120, 300);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox10 = PictureBox4;
		size = new Size(270, 36);
		((Control)pictureBox10).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)1;
		PictureBox4.TabIndex = 38;
		PictureBox4.TabStop = false;
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.Transparent;
		((Control)Label5).Font = new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label13 = Label5;
		location = new Point(116, 273);
		((Control)label13).Location = location;
		((Control)Label5).Name = "Label5";
		Label label14 = Label5;
		size = new Size(106, 24);
		((Control)label14).Size = size;
		((Control)Label5).TabIndex = 37;
		Label5.Text = "Password:";
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox11 = PictureBox5;
		location = new Point(205, 379);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox12 = PictureBox5;
		size = new Size(102, 34);
		((Control)pictureBox12).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 40;
		PictureBox5.TabStop = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj3 = defaultclose;
		location = new Point(234, 0);
		((Control)obj3).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj4 = defaultclose;
		size = new Size(51, 34);
		((Control)obj4).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj5 = hoverclose;
		location = new Point(291, 0);
		((Control)obj5).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj6 = hoverclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj7 = clickclose;
		location = new Point(348, 0);
		((Control)obj7).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj8 = clickclose;
		size = new Size(51, 34);
		((Control)obj8).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox13 = PictureBox7;
		location = new Point(392, 1);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox14 = PictureBox7;
		size = new Size(51, 34);
		((Control)pictureBox14).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 118;
		PictureBox7.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.DodgerBlue;
		size = new Size(500, 648);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)TextBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Control)this).Controls.Add((Control)(object)PictureBox6);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)head);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "meemail3";
		((Form)this).ShowInTaskbar = false;
		((Form)this).Text = "meemail3";
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void PictureBox5_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		int num5 = default(int);
		int num6 = default(int);
		StreamWriter streamWriter2 = default(StreamWriter);
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
					goto IL_000a;
				case 406:
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
							goto IL_000a;
						case 3:
							goto IL_0013;
						case 4:
							goto IL_003f;
						case 5:
							goto IL_004e;
						case 6:
							goto IL_0080;
						case 7:
							goto IL_009a;
						case 8:
							goto IL_00a4;
						case 9:
							goto IL_00ad;
						case 10:
							goto IL_00da;
						case 11:
							goto IL_00ea;
						case 12:
							goto IL_011d;
						case 13:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 14:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00da:
					num = 10;
					FileSystem.FileClose(new int[0]);
					goto IL_00ea;
					IL_00ea:
					num = 11;
					streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meemail.1.0\\password.txt", true);
					goto IL_011d;
					IL_00ad:
					num = 9;
					FileSystem.FileOpen(num5, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meemail.1.0\\password.txt", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_00da;
					IL_011d:
					num = 12;
					streamWriter.WriteLine(TextBox2.Text.ToString());
					break;
					IL_000a:
					num = 2;
					num6 = FileSystem.FreeFile();
					goto IL_0013;
					IL_0013:
					num = 3;
					FileSystem.FileOpen(num6, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meemail.1.0\\emailid.txt", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
					goto IL_003f;
					IL_003f:
					num = 4;
					FileSystem.FileClose(new int[0]);
					goto IL_004e;
					IL_004e:
					num = 5;
					streamWriter2 = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\app.wixzel.meemail.1.0\\emailid.txt", true);
					goto IL_0080;
					IL_0080:
					num = 6;
					streamWriter2.WriteLine(TextBox1.Text.ToString());
					goto IL_009a;
					IL_009a:
					num = 7;
					streamWriter2.Close();
					goto IL_00a4;
					IL_00a4:
					num = 8;
					num5 = FileSystem.FreeFile();
					goto IL_00ad;
					end_IL_0001_2:
					break;
				}
				num = 13;
				streamWriter.Close();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 406;
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

	private void meemail3_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.meemailout();
	}

	private void meemail3_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = PictureBox3;
		checked
		{
			Point location = new Point(((Control)this).Width - ((Control)PictureBox3).Width, 0);
			((Control)pictureBox).Location = location;
			PictureBox pictureBox2 = PictureBox7;
			Point location2 = new Point(((Control)PictureBox3).Location.X - ((Control)PictureBox7).Width, ((Control)PictureBox3).Location.Y);
			((Control)pictureBox2).Location = location2;
			Fade.meemail3in();
		}
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox5_MouseDown(object sender, MouseEventArgs e)
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

	private void PictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
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

	private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
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
		((Form)MyProject.Forms.meemail).Close();
		((Form)MyProject.Forms.meemail2).Close();
		((Form)this).Close();
	}

	private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)Control.MouseButtons == 1048576)
		{
			PictureBox3.Image = clickclose.Image;
		}
	}

	private void PictureBox3_MouseLeave(object sender, EventArgs e)
	{
		PictureBox3.Image = defaultclose.Image;
	}

	private void PictureBox3_MouseMove(object sender, MouseEventArgs e)
	{
		if (!((object)PictureBox3.Image).Equals((object?)clickclose.Image))
		{
			PictureBox3.Image = hoverclose.Image;
		}
	}
}
