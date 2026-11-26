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
public class settingprofile : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("username")]
	private Label _username;

	[AccessedThroughProperty("editbtn")]
	private PictureBox _editbtn;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("editpic")]
	private PictureBox _editpic;

	[AccessedThroughProperty("okpic")]
	private PictureBox _okpic;

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

	internal virtual Label username
	{
		[DebuggerNonUserCode]
		get
		{
			return _username;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_username = value;
		}
	}

	internal virtual PictureBox editbtn
	{
		[DebuggerNonUserCode]
		get
		{
			return _editbtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = editbtn_Click;
			if (_editbtn != null)
			{
				((Control)_editbtn).Click -= eventHandler;
			}
			_editbtn = value;
			if (_editbtn != null)
			{
				((Control)_editbtn).Click += eventHandler;
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

	internal virtual PictureBox editpic
	{
		[DebuggerNonUserCode]
		get
		{
			return _editpic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_editpic = value;
		}
	}

	internal virtual PictureBox okpic
	{
		[DebuggerNonUserCode]
		get
		{
			return _okpic;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_okpic = value;
		}
	}

	[DebuggerNonUserCode]
	public settingprofile()
	{
		((Form)this).Load += settingprofile_Load;
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
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(settingprofile));
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		username = new Label();
		editbtn = new PictureBox();
		TextBox1 = new TextBox();
		editpic = new PictureBox();
		okpic = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)editbtn).BeginInit();
		((ISupportInitialize)editpic).BeginInit();
		((ISupportInitialize)okpic).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(0, 0);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(60, 60);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 3;
		PictureBox1.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).Font = new Font("Futura Bk BT", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(61, 17);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(69, 25);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 2;
		Label1.Text = "Profile";
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(449, 122);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(117, 117);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 5;
		PictureBox2.TabStop = false;
		((Control)username).Anchor = (AnchorStyles)3;
		((Control)username).BackColor = Color.Transparent;
		((Control)username).Font = new Font("Futura Bk BT", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)username).ForeColor = Color.Black;
		Label obj = username;
		location = new Point(372, 250);
		((Control)obj).Location = location;
		((Control)username).Name = "username";
		Label obj2 = username;
		size = new Size(276, 37);
		((Control)obj2).Size = size;
		((Control)username).TabIndex = 29;
		username.Text = "Name";
		username.TextAlign = (ContentAlignment)32;
		editbtn.Image = (Image)componentResourceManager.GetObject("editbtn.Image");
		PictureBox obj3 = editbtn;
		location = new Point(487, 301);
		((Control)obj3).Location = location;
		((Control)editbtn).Name = "editbtn";
		PictureBox obj4 = editbtn;
		size = new Size(48, 48);
		((Control)obj4).Size = size;
		editbtn.SizeMode = (PictureBoxSizeMode)2;
		editbtn.TabIndex = 30;
		editbtn.TabStop = false;
		((TextBoxBase)TextBox1).BackColor = Color.WhiteSmoke;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Futura Bk BT", 21.75f);
		TextBox textBox = TextBox1;
		location = new Point(346, 251);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(340, 35);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 31;
		((Control)TextBox1).Visible = false;
		editpic.Image = (Image)componentResourceManager.GetObject("editpic.Image");
		PictureBox obj5 = editpic;
		location = new Point(464, 387);
		((Control)obj5).Location = location;
		((Control)editpic).Name = "editpic";
		PictureBox obj6 = editpic;
		size = new Size(48, 48);
		((Control)obj6).Size = size;
		editpic.SizeMode = (PictureBoxSizeMode)2;
		editpic.TabIndex = 32;
		editpic.TabStop = false;
		((Control)editpic).Visible = false;
		okpic.Image = (Image)componentResourceManager.GetObject("okpic.Image");
		PictureBox obj7 = okpic;
		location = new Point(518, 387);
		((Control)obj7).Location = location;
		((Control)okpic).Name = "okpic";
		PictureBox obj8 = okpic;
		size = new Size(48, 48);
		((Control)obj8).Size = size;
		okpic.SizeMode = (PictureBoxSizeMode)4;
		okpic.TabIndex = 33;
		okpic.TabStop = false;
		((Control)okpic).Visible = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1000, 542);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)okpic);
		((Control)this).Controls.Add((Control)(object)editpic);
		((Control)this).Controls.Add((Control)(object)editbtn);
		((Control)this).Controls.Add((Control)(object)username);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)TextBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "settingprofile";
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)editbtn).EndInit();
		((ISupportInitialize)editpic).EndInit();
		((ISupportInitialize)okpic).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	private void editbtn_Click(object sender, EventArgs e)
	{
		if (editbtn.Image == editpic.Image)
		{
			((Control)username).Visible = false;
			((Control)TextBox1).Visible = true;
			editbtn.Image = okpic.Image;
			return;
		}
		((Control)username).Visible = true;
		((Control)TextBox1).Visible = false;
		editbtn.Image = editpic.Image;
		username.Text = TextBox1.Text;
		int num = FileSystem.FreeFile();
		FileSystem.FileOpen(num, MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file", (OpenMode)2, (OpenAccess)(-1), (OpenShare)(-1), -1);
		FileSystem.FileClose(new int[0]);
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\username.file", true);
		streamWriter.WriteLine(username.Text);
		streamWriter.Close();
		MyProject.Forms.menuwxl.Label5.Text = username.Text;
	}

	private void settingprofile_Load(object sender, EventArgs e)
	{
		Point location = new Point(((Form)MyProject.Forms.settings).Location.X, checked(((Form)MyProject.Forms.settings).Location.Y + ((Control)MyProject.Forms.settings.PictureBox4).Location.Y));
		((Form)this).Location = location;
		username.Text = MyProject.Forms.menuwxl.Label5.Text;
		editbtn.Image = editpic.Image;
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
