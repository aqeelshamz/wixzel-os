using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class wordpro : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("PictureBox11")]
	private PictureBox _PictureBox11;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("Panel3")]
	private Panel _Panel3;

	[AccessedThroughProperty("PictureBox18")]
	private PictureBox _PictureBox18;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("PictureBox16")]
	private PictureBox _PictureBox16;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("PictureBox15")]
	private PictureBox _PictureBox15;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("ListBox2")]
	private ListBox _ListBox2;

	[AccessedThroughProperty("Panel4")]
	private Panel _Panel4;

	[AccessedThroughProperty("ListBox1")]
	private ListBox _ListBox1;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox21")]
	private PictureBox _PictureBox21;

	private Point mouse_move;

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
			MouseEventHandler val = new MouseEventHandler(PictureBox1_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox1_MouseDown);
			EventHandler eventHandler = PictureBox1_Click;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove -= val;
				((Control)_PictureBox1).MouseDown -= val2;
				((Control)_PictureBox1).Click -= eventHandler;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).MouseMove += val;
				((Control)_PictureBox1).MouseDown += val2;
				((Control)_PictureBox1).Click += eventHandler;
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
			EventHandler eventHandler2 = PictureBox2_GotFocus;
			MouseEventHandler val = new MouseEventHandler(PictureBox2_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox2_MouseDown);
			EventHandler eventHandler3 = PictureBox2_MouseLeave;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click -= eventHandler;
				((Control)_PictureBox2).GotFocus -= eventHandler2;
				((Control)_PictureBox2).MouseMove -= val;
				((Control)_PictureBox2).MouseDown -= val2;
				((Control)_PictureBox2).MouseLeave -= eventHandler3;
			}
			_PictureBox2 = value;
			if (_PictureBox2 != null)
			{
				((Control)_PictureBox2).Click += eventHandler;
				((Control)_PictureBox2).GotFocus += eventHandler2;
				((Control)_PictureBox2).MouseMove += val;
				((Control)_PictureBox2).MouseDown += val2;
				((Control)_PictureBox2).MouseLeave += eventHandler3;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox3_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox3_MouseDown);
			EventHandler eventHandler = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).MouseMove -= val;
				((Control)_PictureBox3).MouseDown -= val2;
				((Control)_PictureBox3).Click -= eventHandler;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).MouseMove += val;
				((Control)_PictureBox3).MouseDown += val2;
				((Control)_PictureBox3).Click += eventHandler;
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
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Panel1_Paint);
			if (_Panel1 != null)
			{
				((Control)_Panel1).Paint -= val;
			}
			_Panel1 = value;
			if (_Panel1 != null)
			{
				((Control)_Panel1).Paint += val;
			}
		}
	}

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = RichTextBox1_Click;
			EventHandler eventHandler2 = RichTextBox1_TextChanged;
			EventHandler eventHandler3 = RichTextBox1_DoubleClick;
			if (_RichTextBox1 != null)
			{
				((TextBoxBase)_RichTextBox1).Click -= eventHandler;
				((Control)_RichTextBox1).TextChanged -= eventHandler2;
				((Control)_RichTextBox1).DoubleClick -= eventHandler3;
			}
			_RichTextBox1 = value;
			if (_RichTextBox1 != null)
			{
				((TextBoxBase)_RichTextBox1).Click += eventHandler;
				((Control)_RichTextBox1).TextChanged += eventHandler2;
				((Control)_RichTextBox1).DoubleClick += eventHandler3;
			}
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
			EventHandler eventHandler = PictureBox6_Click;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).Click -= eventHandler;
			}
			_PictureBox6 = value;
			if (_PictureBox6 != null)
			{
				((Control)_PictureBox6).Click += eventHandler;
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
			_PictureBox5 = value;
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

	internal virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	internal virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
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

	internal virtual PictureBox PictureBox12
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox12 = value;
		}
	}

	internal virtual PictureBox PictureBox11
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox11 = value;
		}
	}

	internal virtual PictureBox PictureBox10
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox10 = value;
		}
	}

	internal virtual PictureBox PictureBox9
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox9 = value;
		}
	}

	internal virtual PictureBox PictureBox8
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox8 = value;
		}
	}

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

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
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
			_Label6 = value;
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

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	internal virtual Panel Panel2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Panel2_Paint);
			if (_Panel2 != null)
			{
				((Control)_Panel2).Paint -= val;
			}
			_Panel2 = value;
			if (_Panel2 != null)
			{
				((Control)_Panel2).Paint += val;
			}
		}
	}

	internal virtual Panel Panel3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel3 = value;
		}
	}

	internal virtual PictureBox PictureBox18
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox18 = value;
		}
	}

	internal virtual PictureBox PictureBox17
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox17 = value;
		}
	}

	internal virtual PictureBox PictureBox16
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox16_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox16_MouseDown);
			if (_PictureBox16 != null)
			{
				((Control)_PictureBox16).Click -= eventHandler;
				((Control)_PictureBox16).MouseDown -= val;
			}
			_PictureBox16 = value;
			if (_PictureBox16 != null)
			{
				((Control)_PictureBox16).Click += eventHandler;
				((Control)_PictureBox16).MouseDown += val;
			}
		}
	}

	internal virtual PictureBox PictureBox13
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox13_Click;
			if (_PictureBox13 != null)
			{
				((Control)_PictureBox13).Click -= eventHandler;
			}
			_PictureBox13 = value;
			if (_PictureBox13 != null)
			{
				((Control)_PictureBox13).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox14
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox14_Click;
			if (_PictureBox14 != null)
			{
				((Control)_PictureBox14).Click -= eventHandler;
			}
			_PictureBox14 = value;
			if (_PictureBox14 != null)
			{
				((Control)_PictureBox14).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual PictureBox PictureBox15
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox15_Click;
			if (_PictureBox15 != null)
			{
				((Control)_PictureBox15).Click -= eventHandler;
			}
			_PictureBox15 = value;
			if (_PictureBox15 != null)
			{
				((Control)_PictureBox15).Click += eventHandler;
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

	internal virtual PictureBox PictureBox19
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox19_Click;
			if (_PictureBox19 != null)
			{
				((Control)_PictureBox19).Click -= eventHandler;
			}
			_PictureBox19 = value;
			if (_PictureBox19 != null)
			{
				((Control)_PictureBox19).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox PictureBox20
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = PictureBox20_Click;
			if (_PictureBox20 != null)
			{
				((Control)_PictureBox20).Click -= eventHandler;
			}
			_PictureBox20 = value;
			if (_PictureBox20 != null)
			{
				((Control)_PictureBox20).Click += eventHandler;
			}
		}
	}

	internal virtual ListBox ListBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ListBox2_SelectedIndexChanged;
			EventHandler eventHandler2 = ListBox2_Click;
			if (_ListBox2 != null)
			{
				_ListBox2.SelectedIndexChanged -= eventHandler;
				_ListBox2.Click -= eventHandler2;
			}
			_ListBox2 = value;
			if (_ListBox2 != null)
			{
				_ListBox2.SelectedIndexChanged += eventHandler;
				_ListBox2.Click += eventHandler2;
			}
		}
	}

	internal virtual Panel Panel4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Panel4_Paint);
			if (_Panel4 != null)
			{
				((Control)_Panel4).Paint -= val;
			}
			_Panel4 = value;
			if (_Panel4 != null)
			{
				((Control)_Panel4).Paint += val;
			}
		}
	}

	internal virtual ListBox ListBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = ListBox1_SelectedIndexChanged;
			EventHandler eventHandler2 = ListBox1_Click;
			if (_ListBox1 != null)
			{
				_ListBox1.SelectedIndexChanged -= eventHandler;
				_ListBox1.Click -= eventHandler2;
			}
			_ListBox1 = value;
			if (_ListBox1 != null)
			{
				_ListBox1.SelectedIndexChanged += eventHandler;
				_ListBox1.Click += eventHandler2;
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

	internal virtual PictureBox PictureBox21
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox21 = value;
		}
	}

	[DebuggerNonUserCode]
	public wordpro()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(wordpro_FormClosing);
		((Form)this).Load += wordpro_Load;
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
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected O, but got Unknown
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b72: Expected O, but got Unknown
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c97: Expected O, but got Unknown
		//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d17: Expected O, but got Unknown
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Expected O, but got Unknown
		//IL_0e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Expected O, but got Unknown
		//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea1: Expected O, but got Unknown
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2c: Expected O, but got Unknown
		//IL_0fad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb7: Expected O, but got Unknown
		//IL_1058: Unknown result type (might be due to invalid IL or missing references)
		//IL_1062: Expected O, but got Unknown
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1105: Expected O, but got Unknown
		//IL_11a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b0: Expected O, but got Unknown
		//IL_1259: Unknown result type (might be due to invalid IL or missing references)
		//IL_1263: Expected O, but got Unknown
		//IL_130c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Expected O, but got Unknown
		//IL_13bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c9: Expected O, but got Unknown
		//IL_1472: Unknown result type (might be due to invalid IL or missing references)
		//IL_147c: Expected O, but got Unknown
		//IL_1505: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Expected O, but got Unknown
		//IL_1590: Unknown result type (might be due to invalid IL or missing references)
		//IL_159a: Expected O, but got Unknown
		//IL_161b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1625: Expected O, but got Unknown
		//IL_16a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b0: Expected O, but got Unknown
		//IL_1731: Unknown result type (might be due to invalid IL or missing references)
		//IL_173b: Expected O, but got Unknown
		//IL_17dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e6: Expected O, but got Unknown
		//IL_188f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1899: Expected O, but got Unknown
		//IL_1941: Unknown result type (might be due to invalid IL or missing references)
		//IL_194b: Expected O, but got Unknown
		//IL_19f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_19fd: Expected O, but got Unknown
		//IL_1aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ab0: Expected O, but got Unknown
		//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b60: Expected O, but got Unknown
		//IL_1c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c10: Expected O, but got Unknown
		//IL_1c93: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9d: Expected O, but got Unknown
		//IL_1d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d28: Expected O, but got Unknown
		//IL_1da9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db3: Expected O, but got Unknown
		//IL_1e30: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e3a: Expected O, but got Unknown
		//IL_207b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2085: Expected O, but got Unknown
		//IL_2123: Unknown result type (might be due to invalid IL or missing references)
		//IL_212d: Expected O, but got Unknown
		//IL_21cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d5: Expected O, but got Unknown
		//IL_2262: Unknown result type (might be due to invalid IL or missing references)
		//IL_226c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(wordpro));
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		Panel1 = new Panel();
		ListBox1 = new ListBox();
		ListBox2 = new ListBox();
		PictureBox20 = new PictureBox();
		PictureBox19 = new PictureBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		PictureBox18 = new PictureBox();
		PictureBox17 = new PictureBox();
		PictureBox16 = new PictureBox();
		PictureBox13 = new PictureBox();
		PictureBox14 = new PictureBox();
		Label17 = new Label();
		PictureBox15 = new PictureBox();
		Label13 = new Label();
		Label12 = new Label();
		Label11 = new Label();
		Label10 = new Label();
		Label9 = new Label();
		PictureBox12 = new PictureBox();
		PictureBox11 = new PictureBox();
		PictureBox10 = new PictureBox();
		PictureBox9 = new PictureBox();
		PictureBox8 = new PictureBox();
		Label8 = new Label();
		Label7 = new Label();
		Label6 = new Label();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		PictureBox7 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		RichTextBox1 = new RichTextBox();
		Panel2 = new Panel();
		Panel3 = new Panel();
		Panel4 = new Panel();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox21 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox3).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox20).BeginInit();
		((ISupportInitialize)PictureBox19).BeginInit();
		((ISupportInitialize)PictureBox18).BeginInit();
		((ISupportInitialize)PictureBox17).BeginInit();
		((ISupportInitialize)PictureBox16).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((ISupportInitialize)PictureBox14).BeginInit();
		((ISupportInitialize)PictureBox15).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox21).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox = PictureBox1;
		Point location = new Point(0, 0);
		((Control)pictureBox).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox2 = PictureBox1;
		Size size = new Size(1400, 35);
		((Control)pictureBox2).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 0;
		PictureBox1.TabStop = false;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(1309, 1);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(51, 34);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 1;
		PictureBox2.TabStop = false;
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox5 = PictureBox3;
		location = new Point(6, 6);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox6 = PictureBox3;
		size = new Size(22, 22);
		((Control)pictureBox6).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 2;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(34, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(274, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 4;
		Label1.Text = "WordPro - Beta (limited features only)";
		((Control)Panel1).BackColor = Color.SkyBlue;
		((Control)Panel1).Controls.Add((Control)(object)ListBox1);
		((Control)Panel1).Controls.Add((Control)(object)ListBox2);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox20);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox19);
		((Control)Panel1).Controls.Add((Control)(object)TextBox2);
		((Control)Panel1).Controls.Add((Control)(object)TextBox1);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox18);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox17);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox16);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox13);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox14);
		((Control)Panel1).Controls.Add((Control)(object)Label17);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox15);
		((Control)Panel1).Controls.Add((Control)(object)Label13);
		((Control)Panel1).Controls.Add((Control)(object)Label12);
		((Control)Panel1).Controls.Add((Control)(object)Label11);
		((Control)Panel1).Controls.Add((Control)(object)Label10);
		((Control)Panel1).Controls.Add((Control)(object)Label9);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox12);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox11);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox10);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox9);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel1).Controls.Add((Control)(object)Label8);
		((Control)Panel1).Controls.Add((Control)(object)Label7);
		((Control)Panel1).Controls.Add((Control)(object)Label6);
		((Control)Panel1).Controls.Add((Control)(object)Label5);
		((Control)Panel1).Controls.Add((Control)(object)Label4);
		((Control)Panel1).Controls.Add((Control)(object)Label3);
		((Control)Panel1).Controls.Add((Control)(object)Label2);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox7);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox4);
		Panel panel = Panel1;
		location = new Point(0, 34);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(1360, 97);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 5;
		((Control)ListBox1).Anchor = (AnchorStyles)15;
		ListBox1.BorderStyle = (BorderStyle)0;
		ListBox1.Font = new Font("Futura Bk BT", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ListControl)ListBox1).FormattingEnabled = true;
		ListBox1.ItemHeight = 18;
		ListBox listBox = ListBox1;
		location = new Point(585, 47);
		((Control)listBox).Location = location;
		((Control)ListBox1).Name = "ListBox1";
		ListBox listBox2 = ListBox1;
		size = new Size(241, 396);
		((Control)listBox2).Size = size;
		((Control)ListBox1).TabIndex = 0;
		((Control)ListBox1).Visible = false;
		((Control)ListBox2).Anchor = (AnchorStyles)15;
		ListBox2.BorderStyle = (BorderStyle)0;
		ListBox2.Font = new Font("Futura Bk BT", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((ListControl)ListBox2).FormattingEnabled = true;
		ListBox2.ItemHeight = 18;
		ListBox2.Items.AddRange(new object[16]
		{
			"8", "9", "10", "11", "12", "14", "16", "18", "20", "22",
			"24", "26", "28", "36", "48", "72"
		});
		ListBox listBox3 = ListBox2;
		location = new Point(833, 47);
		((Control)listBox3).Location = location;
		((Control)ListBox2).Name = "ListBox2";
		ListBox listBox4 = ListBox2;
		size = new Size(75, 396);
		((Control)listBox4).Size = size;
		((Control)ListBox2).TabIndex = 40;
		((Control)ListBox2).Visible = false;
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox pictureBox7 = PictureBox20;
		location = new Point(883, 27);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox pictureBox8 = PictureBox20;
		size = new Size(25, 25);
		((Control)pictureBox8).Size = size;
		PictureBox20.SizeMode = (PictureBoxSizeMode)2;
		PictureBox20.TabIndex = 41;
		PictureBox20.TabStop = false;
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox pictureBox9 = PictureBox19;
		location = new Point(801, 27);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox pictureBox10 = PictureBox19;
		size = new Size(25, 25);
		((Control)pictureBox10).Size = size;
		PictureBox19.SizeMode = (PictureBoxSizeMode)2;
		PictureBox19.TabIndex = 39;
		PictureBox19.TabStop = false;
		((TextBoxBase)TextBox2).BorderStyle = (BorderStyle)0;
		((Control)TextBox2).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox = TextBox2;
		location = new Point(833, 27);
		((Control)textBox).Location = location;
		((Control)TextBox2).Name = "TextBox2";
		TextBox textBox2 = TextBox2;
		size = new Size(50, 19);
		((Control)textBox2).Size = size;
		((Control)TextBox2).TabIndex = 38;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox3 = TextBox1;
		location = new Point(585, 27);
		((Control)textBox3).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox4 = TextBox1;
		size = new Size(216, 19);
		((Control)textBox4).Size = size;
		((Control)TextBox1).TabIndex = 37;
		PictureBox18.Image = (Image)componentResourceManager.GetObject("PictureBox18.Image");
		PictureBox pictureBox11 = PictureBox18;
		location = new Point(863, 47);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox18).Name = "PictureBox18";
		PictureBox pictureBox12 = PictureBox18;
		size = new Size(50, 50);
		((Control)pictureBox12).Size = size;
		PictureBox18.SizeMode = (PictureBoxSizeMode)2;
		PictureBox18.TabIndex = 36;
		PictureBox18.TabStop = false;
		PictureBox17.Image = (Image)componentResourceManager.GetObject("PictureBox17.Image");
		PictureBox pictureBox13 = PictureBox17;
		location = new Point(807, 47);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox pictureBox14 = PictureBox17;
		size = new Size(50, 50);
		((Control)pictureBox14).Size = size;
		PictureBox17.SizeMode = (PictureBoxSizeMode)2;
		PictureBox17.TabIndex = 35;
		PictureBox17.TabStop = false;
		PictureBox16.Image = (Image)componentResourceManager.GetObject("PictureBox16.Image");
		PictureBox pictureBox15 = PictureBox16;
		location = new Point(751, 47);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox16).Name = "PictureBox16";
		PictureBox pictureBox16 = PictureBox16;
		size = new Size(50, 50);
		((Control)pictureBox16).Size = size;
		PictureBox16.SizeMode = (PictureBoxSizeMode)2;
		PictureBox16.TabIndex = 34;
		PictureBox16.TabStop = false;
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox17 = PictureBox13;
		location = new Point(696, 47);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox18 = PictureBox13;
		size = new Size(50, 50);
		((Control)pictureBox18).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)2;
		PictureBox13.TabIndex = 31;
		PictureBox13.TabStop = false;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox19 = PictureBox14;
		location = new Point(640, 47);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox20 = PictureBox14;
		size = new Size(50, 50);
		((Control)pictureBox20).Size = size;
		PictureBox14.SizeMode = (PictureBoxSizeMode)2;
		PictureBox14.TabIndex = 30;
		PictureBox14.TabStop = false;
		Label17.AutoSize = true;
		((Control)Label17).BackColor = Color.Transparent;
		((Control)Label17).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.White;
		Label label3 = Label17;
		location = new Point(580, 3);
		((Control)label3).Location = location;
		((Control)Label17).Name = "Label17";
		Label label4 = Label17;
		size = new Size(39, 19);
		((Control)label4).Size = size;
		((Control)Label17).TabIndex = 28;
		Label17.Text = "Font";
		((Control)PictureBox15).BackColor = Color.SkyBlue;
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox pictureBox21 = PictureBox15;
		location = new Point(584, 47);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox pictureBox22 = PictureBox15;
		size = new Size(50, 50);
		((Control)pictureBox22).Size = size;
		PictureBox15.SizeMode = (PictureBoxSizeMode)2;
		PictureBox15.TabIndex = 27;
		PictureBox15.TabStop = false;
		Label13.AutoSize = true;
		((Control)Label13).BackColor = Color.Transparent;
		((Control)Label13).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.White;
		Label label5 = Label13;
		location = new Point(1204, 37);
		((Control)label5).Location = location;
		((Control)Label13).Name = "Label13";
		Label label6 = Label13;
		size = new Size(46, 19);
		((Control)label6).Size = size;
		((Control)Label13).TabIndex = 26;
		Label13.Text = "Date";
		Label12.AutoSize = true;
		((Control)Label12).BackColor = Color.Transparent;
		((Control)Label12).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.White;
		Label label7 = Label12;
		location = new Point(1113, 37);
		((Control)label7).Location = location;
		((Control)Label12).Name = "Label12";
		Label label8 = Label12;
		size = new Size(47, 19);
		((Control)label8).Size = size;
		((Control)Label12).TabIndex = 25;
		Label12.Text = "Time";
		Label11.AutoSize = true;
		((Control)Label11).BackColor = Color.Transparent;
		((Control)Label11).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.White;
		Label label9 = Label11;
		location = new Point(517, 37);
		((Control)label9).Location = location;
		((Control)Label11).Name = "Label11";
		Label label10 = Label11;
		size = new Size(37, 19);
		((Control)label10).Size = size;
		((Control)Label11).TabIndex = 24;
		Label11.Text = "Cut";
		Label10.AutoSize = true;
		((Control)Label10).BackColor = Color.Transparent;
		((Control)Label10).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.White;
		Label label11 = Label10;
		location = new Point(422, 37);
		((Control)label11).Location = location;
		((Control)Label10).Name = "Label10";
		Label label12 = Label10;
		size = new Size(50, 19);
		((Control)label12).Size = size;
		((Control)Label10).TabIndex = 23;
		Label10.Text = "Paste";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.White;
		Label label13 = Label9;
		location = new Point(326, 37);
		((Control)label13).Location = location;
		((Control)Label9).Name = "Label9";
		Label label14 = Label9;
		size = new Size(50, 19);
		((Control)label14).Size = size;
		((Control)Label9).TabIndex = 22;
		Label9.Text = "Copy";
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox23 = PictureBox12;
		location = new Point(472, 23);
		((Control)pictureBox23).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox24 = PictureBox12;
		size = new Size(50, 50);
		((Control)pictureBox24).Size = size;
		PictureBox12.SizeMode = (PictureBoxSizeMode)2;
		PictureBox12.TabIndex = 21;
		PictureBox12.TabStop = false;
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox pictureBox25 = PictureBox11;
		location = new Point(378, 23);
		((Control)pictureBox25).Location = location;
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox pictureBox26 = PictureBox11;
		size = new Size(50, 50);
		((Control)pictureBox26).Size = size;
		PictureBox11.SizeMode = (PictureBoxSizeMode)2;
		PictureBox11.TabIndex = 20;
		PictureBox11.TabStop = false;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox27 = PictureBox10;
		location = new Point(280, 20);
		((Control)pictureBox27).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox28 = PictureBox10;
		size = new Size(50, 50);
		((Control)pictureBox28).Size = size;
		PictureBox10.SizeMode = (PictureBoxSizeMode)2;
		PictureBox10.TabIndex = 19;
		PictureBox10.TabStop = false;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox29 = PictureBox9;
		location = new Point(1159, 20);
		((Control)pictureBox29).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox30 = PictureBox9;
		size = new Size(50, 50);
		((Control)pictureBox30).Size = size;
		PictureBox9.SizeMode = (PictureBoxSizeMode)2;
		PictureBox9.TabIndex = 18;
		PictureBox9.TabStop = false;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox31 = PictureBox8;
		location = new Point(1068, 20);
		((Control)pictureBox31).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox32 = PictureBox8;
		size = new Size(50, 50);
		((Control)pictureBox32).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)2;
		PictureBox8.TabIndex = 17;
		PictureBox8.TabStop = false;
		Label8.AutoSize = true;
		((Control)Label8).BackColor = Color.Transparent;
		((Control)Label8).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label15 = Label8;
		location = new Point(1008, 36);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(62, 19);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 16;
		Label8.Text = "Picture";
		Label7.AutoSize = true;
		((Control)Label7).BackColor = Color.Transparent;
		((Control)Label7).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.White;
		Label label17 = Label7;
		location = new Point(973, 3);
		((Control)label17).Location = location;
		((Control)Label7).Name = "Label7";
		Label label18 = Label7;
		size = new Size(47, 19);
		((Control)label18).Size = size;
		((Control)Label7).TabIndex = 15;
		Label7.Text = "Insert";
		Label6.AutoSize = true;
		((Control)Label6).BackColor = Color.Transparent;
		((Control)Label6).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label19 = Label6;
		location = new Point(287, 3);
		((Control)label19).Location = location;
		((Control)Label6).Name = "Label6";
		Label label20 = Label6;
		size = new Size(34, 19);
		((Control)label20).Size = size;
		((Control)Label6).TabIndex = 14;
		Label6.Text = "Edit";
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.Transparent;
		((Control)Label5).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label21 = Label5;
		location = new Point(206, 37);
		((Control)label21).Location = location;
		((Control)Label5).Name = "Label5";
		Label label22 = Label5;
		size = new Size(45, 19);
		((Control)label22).Size = size;
		((Control)Label5).TabIndex = 13;
		Label5.Text = "Save";
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.Transparent;
		((Control)Label4).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label23 = Label4;
		location = new Point(122, 37);
		((Control)label23).Location = location;
		((Control)Label4).Name = "Label4";
		Label label24 = Label4;
		size = new Size(53, 19);
		((Control)label24).Size = size;
		((Control)Label4).TabIndex = 12;
		Label4.Text = "Open";
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label25 = Label3;
		location = new Point(43, 36);
		((Control)label25).Location = location;
		((Control)Label3).Name = "Label3";
		Label label26 = Label3;
		size = new Size(43, 19);
		((Control)label26).Size = size;
		((Control)Label3).TabIndex = 11;
		Label3.Text = "New";
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label27 = Label2;
		location = new Point(8, 3);
		((Control)label27).Location = location;
		((Control)Label2).Name = "Label2";
		Label label28 = Label2;
		size = new Size(33, 19);
		((Control)label28).Size = size;
		((Control)Label2).TabIndex = 7;
		Label2.Text = "File";
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox33 = PictureBox7;
		location = new Point(977, 32);
		((Control)pictureBox33).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox34 = PictureBox7;
		size = new Size(25, 25);
		((Control)pictureBox34).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 10;
		PictureBox7.TabStop = false;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox35 = PictureBox6;
		location = new Point(175, 32);
		((Control)pictureBox35).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox36 = PictureBox6;
		size = new Size(25, 25);
		((Control)pictureBox36).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 9;
		PictureBox6.TabStop = false;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox37 = PictureBox5;
		location = new Point(90, 31);
		((Control)pictureBox37).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox38 = PictureBox5;
		size = new Size(26, 26);
		((Control)pictureBox38).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 8;
		PictureBox5.TabStop = false;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox39 = PictureBox4;
		location = new Point(12, 32);
		((Control)pictureBox39).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox40 = PictureBox4;
		size = new Size(25, 25);
		((Control)pictureBox40).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 7;
		PictureBox4.TabStop = false;
		((TextBoxBase)RichTextBox1).BorderStyle = (BorderStyle)0;
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(45, 172);
		((Control)richTextBox).Location = location;
		((Control)RichTextBox1).Name = "RichTextBox1";
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(1360, 542);
		((Control)richTextBox2).Size = size;
		((Control)RichTextBox1).TabIndex = 6;
		RichTextBox1.Text = "";
		((Control)Panel2).BackColor = Color.Gainsboro;
		Panel panel3 = Panel2;
		location = new Point(0, 130);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(45, 584);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 7;
		((Control)Panel3).BackColor = Color.Gainsboro;
		Panel panel5 = Panel3;
		location = new Point(1315, 130);
		((Control)panel5).Location = location;
		((Control)Panel3).Name = "Panel3";
		Panel panel6 = Panel3;
		size = new Size(45, 584);
		((Control)panel6).Size = size;
		((Control)Panel3).TabIndex = 8;
		((Control)Panel4).BackColor = Color.Gainsboro;
		Panel panel7 = Panel4;
		location = new Point(38, 130);
		((Control)panel7).Location = location;
		((Control)Panel4).Name = "Panel4";
		Panel panel8 = Panel4;
		size = new Size(1283, 42);
		((Control)panel8).Size = size;
		((Control)Panel4).TabIndex = 9;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj = defaultclose;
		location = new Point(1135, 0);
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
		location = new Point(1192, 0);
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
		location = new Point(1249, 0);
		((Control)obj5).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj6 = clickclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox21.Image = (Image)componentResourceManager.GetObject("PictureBox21.Image");
		PictureBox pictureBox41 = PictureBox21;
		location = new Point(1249, 1);
		((Control)pictureBox41).Location = location;
		((Control)PictureBox21).Name = "PictureBox21";
		PictureBox pictureBox42 = PictureBox21;
		size = new Size(51, 34);
		((Control)pictureBox42).Size = size;
		PictureBox21.SizeMode = (PictureBoxSizeMode)2;
		PictureBox21.TabIndex = 118;
		PictureBox21.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.DodgerBlue;
		size = new Size(1360, 723);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox21);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)Panel4);
		((Control)this).Controls.Add((Control)(object)Panel3);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)RichTextBox1);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "wordpro";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)0;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox3).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox20).EndInit();
		((ISupportInitialize)PictureBox19).EndInit();
		((ISupportInitialize)PictureBox18).EndInit();
		((ISupportInitialize)PictureBox17).EndInit();
		((ISupportInitialize)PictureBox16).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((ISupportInitialize)PictureBox14).EndInit();
		((ISupportInitialize)PictureBox15).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox21).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void wordpro_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.wordproout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.word.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void wordpro_Load(object sender, EventArgs e)
	{
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbd: Expected O, but got Unknown
		//IL_0c2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c32: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Font font = default(Font);
		FontFamily val = default(FontFamily);
		int num5 = default(int);
		InstalledFontCollection val2 = default(InstalledFontCollection);
		FontFamily[] families = default(FontFamily[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					PictureBox pictureBox2;
					Point location2;
					switch (try0001_dispatch)
					{
					default:
					{
						num = 1;
						PictureBox pictureBox = PictureBox2;
						Point location = new Point(((Control)this).Width - ((Control)PictureBox2).Width, 0);
						((Control)pictureBox).Location = location;
						goto IL_002d;
					}
					case 3861:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_002d;
							case 3:
								goto IL_007a;
							case 4:
								goto IL_009a;
							case 5:
								goto IL_00b3;
							case 7:
								goto IL_00e4;
							case 8:
								goto IL_00e8;
							case 9:
								goto IL_0108;
							case 10:
								goto IL_0122;
							case 12:
								goto IL_0154;
							case 13:
								goto IL_0159;
							case 14:
								goto IL_017a;
							case 15:
								goto IL_0194;
							case 17:
								goto IL_01c6;
							case 18:
								goto IL_01cb;
							case 19:
								goto IL_01ec;
							case 20:
								goto IL_0206;
							case 22:
								goto IL_0238;
							case 23:
								goto IL_023d;
							case 24:
								goto IL_025e;
							case 25:
								goto IL_0278;
							case 27:
								goto IL_02aa;
							case 28:
								goto IL_02af;
							case 29:
								goto IL_02d0;
							case 30:
								goto IL_02ea;
							case 32:
								goto IL_031c;
							case 33:
								goto IL_0321;
							case 34:
								goto IL_0342;
							case 35:
								goto IL_035c;
							case 37:
								goto IL_038e;
							case 38:
								goto IL_0393;
							case 39:
								goto IL_03b4;
							case 40:
								goto IL_03ce;
							case 42:
								goto IL_0400;
							case 43:
								goto IL_0405;
							case 44:
								goto IL_0426;
							case 45:
								goto IL_0440;
							case 47:
								goto IL_0472;
							case 48:
								goto IL_0477;
							case 49:
								goto IL_0498;
							case 50:
								goto IL_04b2;
							case 52:
								goto IL_04e4;
							case 53:
								goto IL_04e9;
							case 54:
								goto IL_050a;
							case 55:
								goto IL_0524;
							case 57:
								goto IL_0556;
							case 58:
								goto IL_055b;
							case 59:
								goto IL_057c;
							case 60:
								goto IL_0596;
							case 62:
								goto IL_05c8;
							case 63:
								goto IL_05cd;
							case 64:
								goto IL_05ee;
							case 65:
								goto IL_0608;
							case 67:
								goto IL_063a;
							case 68:
								goto IL_063f;
							case 69:
								goto IL_0660;
							case 70:
								goto IL_067a;
							case 72:
								goto IL_06ac;
							case 73:
								goto IL_06b1;
							case 74:
								goto IL_06d2;
							case 75:
								goto IL_06ec;
							case 77:
								goto IL_071e;
							case 78:
								goto IL_0723;
							case 79:
								goto IL_0744;
							case 80:
								goto IL_075e;
							case 82:
								goto IL_0790;
							case 83:
								goto IL_0795;
							case 84:
								goto IL_07b6;
							case 85:
								goto IL_07d0;
							case 87:
								goto IL_0802;
							case 88:
								goto IL_0807;
							case 89:
								goto IL_0828;
							case 90:
								goto IL_0842;
							case 92:
								goto IL_0874;
							case 93:
								goto IL_0879;
							case 94:
								goto IL_089a;
							case 95:
								goto IL_08b4;
							case 97:
								goto IL_08e6;
							case 98:
								goto IL_08eb;
							case 99:
								goto IL_090c;
							case 100:
								goto IL_0926;
							case 102:
								goto IL_0958;
							case 103:
								goto IL_095d;
							case 104:
								goto IL_097e;
							case 105:
								goto IL_0998;
							case 107:
								goto IL_09ca;
							case 108:
								goto IL_09cf;
							case 109:
								goto IL_09f0;
							case 110:
								goto IL_0a0a;
							case 112:
								goto IL_0a3c;
							case 113:
								goto IL_0a41;
							case 114:
								goto IL_0a62;
							case 115:
								goto IL_0a7c;
							case 117:
								goto IL_0aae;
							case 118:
								goto IL_0ab3;
							case 119:
								goto IL_0ad4;
							case 120:
								goto IL_0aee;
							case 122:
								goto IL_0b1d;
							case 123:
								goto IL_0b22;
							case 124:
								goto IL_0b43;
							case 125:
								goto IL_0b5d;
							case 6:
							case 11:
							case 16:
							case 21:
							case 26:
							case 31:
							case 36:
							case 41:
							case 46:
							case 51:
							case 56:
							case 61:
							case 66:
							case 71:
							case 76:
							case 81:
							case 86:
							case 91:
							case 96:
							case 101:
							case 106:
							case 111:
							case 116:
							case 121:
							case 126:
							case 127:
							case 128:
							case 129:
							case 130:
							case 131:
							case 132:
							case 133:
							case 134:
							case 135:
							case 136:
							case 137:
							case 138:
							case 139:
							case 140:
							case 141:
							case 142:
							case 143:
							case 144:
							case 145:
							case 146:
							case 147:
							case 148:
							case 149:
							case 150:
							case 151:
								goto IL_0ba3;
							case 152:
								goto IL_0bb0;
							case 153:
								goto IL_0bbd;
							case 154:
								goto IL_0bd7;
							case 155:
								goto IL_0bfb;
							case 156:
								goto IL_0c11;
							case 157:
								goto IL_0c1a;
							case 158:
								goto IL_0c32;
							case 159:
								goto IL_0c46;
							case 160:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 161:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0c46:
						num = 159;
						TextBox1.Text = "Arial";
						break;
						IL_0bfb:
						num = 155;
						goto IL_0c03;
						IL_0c32:
						num = 158;
						RichTextBox1.Font = font;
						goto IL_0c46;
						IL_0bd7:
						num = 154;
						ListBox1.Items.Add((object)val.Name);
						num5++;
						goto IL_0bfb;
						IL_002d:
						num = 2;
						pictureBox2 = PictureBox21;
						location2 = new Point(((Control)PictureBox2).Location.X - ((Control)PictureBox21).Width, ((Control)PictureBox2).Location.Y);
						((Control)pictureBox2).Location = location2;
						goto IL_007a;
						IL_007a:
						num = 3;
						if (!((Control)MyProject.Forms.home.app1).Enabled)
						{
							goto IL_009a;
						}
						goto IL_00e4;
						IL_009a:
						num = 4;
						((Control)MyProject.Forms.home.app1).Enabled = true;
						goto IL_00b3;
						IL_00b3:
						num = 5;
						MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_00e4:
						num = 7;
						goto IL_00e8;
						IL_00e8:
						num = 8;
						if (!((Control)MyProject.Forms.home.app2).Enabled)
						{
							goto IL_0108;
						}
						goto IL_0154;
						IL_0108:
						num = 9;
						((Control)MyProject.Forms.home.app2).Enabled = true;
						goto IL_0122;
						IL_0122:
						num = 10;
						MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0154:
						num = 12;
						goto IL_0159;
						IL_0159:
						num = 13;
						if (!((Control)MyProject.Forms.home.app3).Enabled)
						{
							goto IL_017a;
						}
						goto IL_01c6;
						IL_017a:
						num = 14;
						((Control)MyProject.Forms.home.app3).Enabled = true;
						goto IL_0194;
						IL_0194:
						num = 15;
						MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_01c6:
						num = 17;
						goto IL_01cb;
						IL_01cb:
						num = 18;
						if (!((Control)MyProject.Forms.home.app4).Enabled)
						{
							goto IL_01ec;
						}
						goto IL_0238;
						IL_01ec:
						num = 19;
						((Control)MyProject.Forms.home.app4).Enabled = true;
						goto IL_0206;
						IL_0206:
						num = 20;
						MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0238:
						num = 22;
						goto IL_023d;
						IL_023d:
						num = 23;
						if (!((Control)MyProject.Forms.home.app5).Enabled)
						{
							goto IL_025e;
						}
						goto IL_02aa;
						IL_025e:
						num = 24;
						((Control)MyProject.Forms.home.app5).Enabled = true;
						goto IL_0278;
						IL_0278:
						num = 25;
						MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_02aa:
						num = 27;
						goto IL_02af;
						IL_02af:
						num = 28;
						if (!((Control)MyProject.Forms.home.app6).Enabled)
						{
							goto IL_02d0;
						}
						goto IL_031c;
						IL_02d0:
						num = 29;
						((Control)MyProject.Forms.home.app6).Enabled = true;
						goto IL_02ea;
						IL_02ea:
						num = 30;
						MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_031c:
						num = 32;
						goto IL_0321;
						IL_0321:
						num = 33;
						if (!((Control)MyProject.Forms.home.app7).Enabled)
						{
							goto IL_0342;
						}
						goto IL_038e;
						IL_0342:
						num = 34;
						((Control)MyProject.Forms.home.app7).Enabled = true;
						goto IL_035c;
						IL_035c:
						num = 35;
						MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_038e:
						num = 37;
						goto IL_0393;
						IL_0393:
						num = 38;
						if (!((Control)MyProject.Forms.home.app8).Enabled)
						{
							goto IL_03b4;
						}
						goto IL_0400;
						IL_03b4:
						num = 39;
						((Control)MyProject.Forms.home.app8).Enabled = true;
						goto IL_03ce;
						IL_03ce:
						num = 40;
						MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0400:
						num = 42;
						goto IL_0405;
						IL_0405:
						num = 43;
						if (!((Control)MyProject.Forms.home.app9).Enabled)
						{
							goto IL_0426;
						}
						goto IL_0472;
						IL_0426:
						num = 44;
						((Control)MyProject.Forms.home.app9).Enabled = true;
						goto IL_0440;
						IL_0440:
						num = 45;
						MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0472:
						num = 47;
						goto IL_0477;
						IL_0477:
						num = 48;
						if (!((Control)MyProject.Forms.home.app10).Enabled)
						{
							goto IL_0498;
						}
						goto IL_04e4;
						IL_0498:
						num = 49;
						((Control)MyProject.Forms.home.app10).Enabled = true;
						goto IL_04b2;
						IL_04b2:
						num = 50;
						MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_04e4:
						num = 52;
						goto IL_04e9;
						IL_04e9:
						num = 53;
						if (!((Control)MyProject.Forms.home.app11).Enabled)
						{
							goto IL_050a;
						}
						goto IL_0556;
						IL_050a:
						num = 54;
						((Control)MyProject.Forms.home.app11).Enabled = true;
						goto IL_0524;
						IL_0524:
						num = 55;
						MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0556:
						num = 57;
						goto IL_055b;
						IL_055b:
						num = 58;
						if (!((Control)MyProject.Forms.home.app12).Enabled)
						{
							goto IL_057c;
						}
						goto IL_05c8;
						IL_057c:
						num = 59;
						((Control)MyProject.Forms.home.app12).Enabled = true;
						goto IL_0596;
						IL_0596:
						num = 60;
						MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_05c8:
						num = 62;
						goto IL_05cd;
						IL_05cd:
						num = 63;
						if (!((Control)MyProject.Forms.home.app13).Enabled)
						{
							goto IL_05ee;
						}
						goto IL_063a;
						IL_05ee:
						num = 64;
						((Control)MyProject.Forms.home.app13).Enabled = true;
						goto IL_0608;
						IL_0608:
						num = 65;
						MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_063a:
						num = 67;
						goto IL_063f;
						IL_063f:
						num = 68;
						if (!((Control)MyProject.Forms.home.app14).Enabled)
						{
							goto IL_0660;
						}
						goto IL_06ac;
						IL_0660:
						num = 69;
						((Control)MyProject.Forms.home.app14).Enabled = true;
						goto IL_067a;
						IL_067a:
						num = 70;
						MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_06ac:
						num = 72;
						goto IL_06b1;
						IL_06b1:
						num = 73;
						if (!((Control)MyProject.Forms.home.app15).Enabled)
						{
							goto IL_06d2;
						}
						goto IL_071e;
						IL_06d2:
						num = 74;
						((Control)MyProject.Forms.home.app15).Enabled = true;
						goto IL_06ec;
						IL_06ec:
						num = 75;
						MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_071e:
						num = 77;
						goto IL_0723;
						IL_0723:
						num = 78;
						if (!((Control)MyProject.Forms.home.app16).Enabled)
						{
							goto IL_0744;
						}
						goto IL_0790;
						IL_0744:
						num = 79;
						((Control)MyProject.Forms.home.app16).Enabled = true;
						goto IL_075e;
						IL_075e:
						num = 80;
						MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0790:
						num = 82;
						goto IL_0795;
						IL_0795:
						num = 83;
						if (!((Control)MyProject.Forms.home.app17).Enabled)
						{
							goto IL_07b6;
						}
						goto IL_0802;
						IL_07b6:
						num = 84;
						((Control)MyProject.Forms.home.app17).Enabled = true;
						goto IL_07d0;
						IL_07d0:
						num = 85;
						MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0802:
						num = 87;
						goto IL_0807;
						IL_0807:
						num = 88;
						if (!((Control)MyProject.Forms.home.app18).Enabled)
						{
							goto IL_0828;
						}
						goto IL_0874;
						IL_0828:
						num = 89;
						((Control)MyProject.Forms.home.app18).Enabled = true;
						goto IL_0842;
						IL_0842:
						num = 90;
						MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0874:
						num = 92;
						goto IL_0879;
						IL_0879:
						num = 93;
						if (!((Control)MyProject.Forms.home.app19).Enabled)
						{
							goto IL_089a;
						}
						goto IL_08e6;
						IL_089a:
						num = 94;
						((Control)MyProject.Forms.home.app19).Enabled = true;
						goto IL_08b4;
						IL_08b4:
						num = 95;
						MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_08e6:
						num = 97;
						goto IL_08eb;
						IL_08eb:
						num = 98;
						if (!((Control)MyProject.Forms.home.app20).Enabled)
						{
							goto IL_090c;
						}
						goto IL_0958;
						IL_090c:
						num = 99;
						((Control)MyProject.Forms.home.app20).Enabled = true;
						goto IL_0926;
						IL_0926:
						num = 100;
						MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0958:
						num = 102;
						goto IL_095d;
						IL_095d:
						num = 103;
						if (!((Control)MyProject.Forms.home.app21).Enabled)
						{
							goto IL_097e;
						}
						goto IL_09ca;
						IL_097e:
						num = 104;
						((Control)MyProject.Forms.home.app21).Enabled = true;
						goto IL_0998;
						IL_0998:
						num = 105;
						MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_09ca:
						num = 107;
						goto IL_09cf;
						IL_09cf:
						num = 108;
						if (!((Control)MyProject.Forms.home.app22).Enabled)
						{
							goto IL_09f0;
						}
						goto IL_0a3c;
						IL_09f0:
						num = 109;
						((Control)MyProject.Forms.home.app22).Enabled = true;
						goto IL_0a0a;
						IL_0a0a:
						num = 110;
						MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0a3c:
						num = 112;
						goto IL_0a41;
						IL_0a41:
						num = 113;
						if (!((Control)MyProject.Forms.home.app23).Enabled)
						{
							goto IL_0a62;
						}
						goto IL_0aae;
						IL_0a62:
						num = 114;
						((Control)MyProject.Forms.home.app23).Enabled = true;
						goto IL_0a7c;
						IL_0a7c:
						num = 115;
						MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0aae:
						num = 117;
						goto IL_0ab3;
						IL_0ab3:
						num = 118;
						if (!((Control)MyProject.Forms.home.app24).Enabled)
						{
							goto IL_0ad4;
						}
						goto IL_0b1d;
						IL_0ad4:
						num = 119;
						((Control)MyProject.Forms.home.app24).Enabled = true;
						goto IL_0aee;
						IL_0aee:
						num = 120;
						MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0b1d:
						num = 122;
						goto IL_0b22;
						IL_0b22:
						num = 123;
						if (!((Control)MyProject.Forms.home.app25).Enabled)
						{
							goto IL_0b43;
						}
						goto IL_0ba3;
						IL_0b43:
						num = 124;
						((Control)MyProject.Forms.home.app25).Enabled = true;
						goto IL_0b5d;
						IL_0b5d:
						num = 125;
						MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.word.Image;
						goto IL_0ba3;
						IL_0ba3:
						num = 151;
						Fade.wordproin();
						goto IL_0bb0;
						IL_0bb0:
						num = 152;
						val2 = new InstalledFontCollection();
						goto IL_0bbd;
						IL_0bbd:
						num = 153;
						families = ((FontCollection)val2).Families;
						num5 = 0;
						goto IL_0c03;
						IL_0c03:
						if (num5 < families.Length)
						{
							val = families[num5];
							goto IL_0bd7;
						}
						goto IL_0c11;
						IL_0c11:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0c1a;
						IL_0c1a:
						num = 157;
						font = new Font("Arial", 8f, (FontStyle)0);
						goto IL_0c32;
						end_IL_0001_2:
						break;
					}
					num = 160;
					TextBox2.Text = "8";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 3861;
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

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void ListBox1_Click(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Font font = default(Font);
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
				case 128:
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
							goto IL_001d;
						case 4:
							goto IL_0033;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					num5 = Conversions.ToInteger(TextBox2.Text);
					goto IL_001d;
					IL_001d:
					num = 3;
					font = new Font(TextBox1.Text, (float)num5);
					goto IL_0033;
					IL_0033:
					num = 4;
					RichTextBox1.Font = font;
					break;
					end_IL_0001_2:
					break;
				}
				num = 5;
				((Control)ListBox1).Visible = false;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 128;
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

	private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		TextBox1.Text = ListBox1.SelectedItem.ToString();
	}

	private void PictureBox19_Click(object sender, EventArgs e)
	{
		if (!((Control)ListBox1).Visible)
		{
			((Control)ListBox1).Visible = true;
			((Control)ListBox1).BringToFront();
			((Control)ListBox1).Focus();
		}
		else
		{
			((Control)ListBox1).Visible = false;
		}
	}

	private void ListBox2_Click(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Font font = default(Font);
		int num5 = default(int);
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
				case 147:
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
							goto IL_001d;
						case 4:
							goto IL_0033;
						case 5:
							goto IL_0043;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_001d:
					num = 3;
					font = new Font(TextBox1.Text, (float)num5);
					goto IL_0033;
					IL_0033:
					num = 4;
					RichTextBox1.Font = font;
					goto IL_0043;
					IL_0009:
					num = 2;
					num5 = Conversions.ToInteger(TextBox2.Text);
					goto IL_001d;
					IL_0043:
					num = 5;
					((Control)ListBox2).Visible = false;
					break;
					end_IL_0001_2:
					break;
				}
				num = 6;
				((TextBoxBase)RichTextBox1).SelectAll();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 147;
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

	private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
	{
		TextBox2.Text = ListBox2.SelectedItem.ToString();
	}

	private void PictureBox20_Click(object sender, EventArgs e)
	{
		if (!((Control)ListBox2).Visible)
		{
			((Control)ListBox2).Visible = true;
			((Control)ListBox2).BringToFront();
			((Control)ListBox2).Focus();
		}
		else
		{
			((Control)ListBox2).Visible = false;
		}
	}

	private void RichTextBox1_Click(object sender, EventArgs e)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		Font val = default(Font);
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
				case 136:
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
							goto IL_001d;
						case 4:
							goto IL_0033;
						case 5:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					num5 = Conversions.ToInteger(TextBox2.Text);
					goto IL_001d;
					IL_001d:
					num = 3;
					val = new Font(TextBox1.Text, (float)num5);
					goto IL_0033;
					IL_0033:
					num = 4;
					RichTextBox1.Font.Equals((object)val);
					break;
					end_IL_0001_2:
					break;
				}
				num = 5;
				((Control)ListBox2).Visible = false;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 136;
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

	private void RichTextBox1_DoubleClick(object sender, EventArgs e)
	{
		((TextBoxBase)RichTextBox1).SelectAll();
	}

	private void RichTextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Panel4_Paint(object sender, PaintEventArgs e)
	{
	}

	private void PictureBox6_Click(object sender, EventArgs e)
	{
		RichTextBox1.SaveFile("D:\\document.docx", (RichTextBoxStreamType)0);
	}

	private void PictureBox15_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Control val = default(Control);
		IEnumerator enumerator = default(IEnumerator);
		string name = default(string);
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
				case 344:
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
							goto IL_002a;
						case 5:
						case 6:
							goto IL_0035;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_0066;
						case 9:
							goto IL_007a;
						case 11:
							goto IL_0093;
						case 12:
							goto IL_0098;
						case 13:
							goto IL_00ad;
						case 4:
						case 10:
						case 14:
						case 15:
						case 16:
							goto IL_00c6;
						default:
							goto end_IL_0001;
						case 17:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0066:
					num = 8;
					((Control)PictureBox15).BackColor = Color.DeepSkyBlue;
					goto IL_007a;
					IL_007a:
					num = 9;
					val.Font = new Font(val.Font, (FontStyle)1);
					goto IL_00c6;
					IL_004f:
					num = 7;
					if (!val.Font.Bold)
					{
						goto IL_0066;
					}
					goto IL_0093;
					IL_0093:
					num = 11;
					goto IL_0098;
					IL_000a:
					num = 2;
					enumerator = ((Control)this).Controls.GetEnumerator();
					goto IL_00cb;
					IL_00cb:
					if (enumerator.MoveNext())
					{
						val = (Control)enumerator.Current;
						goto IL_002a;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001_2;
					IL_0098:
					num = 12;
					((Control)PictureBox15).BackColor = Color.SkyBlue;
					goto IL_00ad;
					IL_00c6:
					num = 16;
					goto IL_00cb;
					IL_00ad:
					num = 13;
					val.Font = new Font(val.Font, (FontStyle)0);
					goto IL_00c6;
					IL_002a:
					num = 3;
					name = val.Name;
					goto IL_0035;
					IL_0035:
					num = 6;
					if (Operators.CompareString(name, "RichTextBox1", false) == 0)
					{
						goto IL_004f;
					}
					goto IL_00c6;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 344;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox14_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Control val = default(Control);
		IEnumerator enumerator = default(IEnumerator);
		string name = default(string);
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
				case 344:
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
							goto IL_002a;
						case 5:
						case 6:
							goto IL_0035;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_0066;
						case 9:
							goto IL_007a;
						case 11:
							goto IL_0093;
						case 12:
							goto IL_0098;
						case 13:
							goto IL_00ad;
						case 4:
						case 10:
						case 14:
						case 15:
						case 16:
							goto IL_00c6;
						default:
							goto end_IL_0001;
						case 17:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0066:
					num = 8;
					((Control)PictureBox14).BackColor = Color.DeepSkyBlue;
					goto IL_007a;
					IL_007a:
					num = 9;
					val.Font = new Font(val.Font, (FontStyle)2);
					goto IL_00c6;
					IL_004f:
					num = 7;
					if (!val.Font.Bold)
					{
						goto IL_0066;
					}
					goto IL_0093;
					IL_0093:
					num = 11;
					goto IL_0098;
					IL_000a:
					num = 2;
					enumerator = ((Control)this).Controls.GetEnumerator();
					goto IL_00cb;
					IL_00cb:
					if (enumerator.MoveNext())
					{
						val = (Control)enumerator.Current;
						goto IL_002a;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001_2;
					IL_0098:
					num = 12;
					((Control)PictureBox14).BackColor = Color.SkyBlue;
					goto IL_00ad;
					IL_00c6:
					num = 16;
					goto IL_00cb;
					IL_00ad:
					num = 13;
					val.Font = new Font(val.Font, (FontStyle)0);
					goto IL_00c6;
					IL_002a:
					num = 3;
					name = val.Name;
					goto IL_0035;
					IL_0035:
					num = 6;
					if (Operators.CompareString(name, "RichTextBox1", false) == 0)
					{
						goto IL_004f;
					}
					goto IL_00c6;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 344;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox13_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Control val = default(Control);
		IEnumerator enumerator = default(IEnumerator);
		string name = default(string);
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
				case 344:
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
							goto IL_002a;
						case 5:
						case 6:
							goto IL_0035;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_0066;
						case 9:
							goto IL_007a;
						case 11:
							goto IL_0093;
						case 12:
							goto IL_0098;
						case 13:
							goto IL_00ad;
						case 4:
						case 10:
						case 14:
						case 15:
						case 16:
							goto IL_00c6;
						default:
							goto end_IL_0001;
						case 17:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0066:
					num = 8;
					((Control)PictureBox13).BackColor = Color.DeepSkyBlue;
					goto IL_007a;
					IL_007a:
					num = 9;
					val.Font = new Font(val.Font, (FontStyle)4);
					goto IL_00c6;
					IL_004f:
					num = 7;
					if (!val.Font.Bold)
					{
						goto IL_0066;
					}
					goto IL_0093;
					IL_0093:
					num = 11;
					goto IL_0098;
					IL_000a:
					num = 2;
					enumerator = ((Control)this).Controls.GetEnumerator();
					goto IL_00cb;
					IL_00cb:
					if (enumerator.MoveNext())
					{
						val = (Control)enumerator.Current;
						goto IL_002a;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001_2;
					IL_0098:
					num = 12;
					((Control)PictureBox13).BackColor = Color.SkyBlue;
					goto IL_00ad;
					IL_00c6:
					num = 16;
					goto IL_00cb;
					IL_00ad:
					num = 13;
					val.Font = new Font(val.Font, (FontStyle)0);
					goto IL_00c6;
					IL_002a:
					num = 3;
					name = val.Name;
					goto IL_0035;
					IL_0035:
					num = 6;
					if (Operators.CompareString(name, "RichTextBox1", false) == 0)
					{
						goto IL_004f;
					}
					goto IL_00c6;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 344;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox16_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Control val = default(Control);
		IEnumerator enumerator = default(IEnumerator);
		string name = default(string);
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
				case 344:
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
							goto IL_002a;
						case 5:
						case 6:
							goto IL_0035;
						case 7:
							goto IL_004f;
						case 8:
							goto IL_0066;
						case 9:
							goto IL_007a;
						case 11:
							goto IL_0093;
						case 12:
							goto IL_0098;
						case 13:
							goto IL_00ad;
						case 4:
						case 10:
						case 14:
						case 15:
						case 16:
							goto IL_00c6;
						default:
							goto end_IL_0001;
						case 17:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_0066:
					num = 8;
					((Control)PictureBox16).BackColor = Color.DeepSkyBlue;
					goto IL_007a;
					IL_007a:
					num = 9;
					val.Font = new Font(val.Font, (FontStyle)8);
					goto IL_00c6;
					IL_004f:
					num = 7;
					if (!val.Font.Bold)
					{
						goto IL_0066;
					}
					goto IL_0093;
					IL_0093:
					num = 11;
					goto IL_0098;
					IL_000a:
					num = 2;
					enumerator = ((Control)this).Controls.GetEnumerator();
					goto IL_00cb;
					IL_00cb:
					if (enumerator.MoveNext())
					{
						val = (Control)enumerator.Current;
						goto IL_002a;
					}
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					goto end_IL_0001_2;
					IL_0098:
					num = 12;
					((Control)PictureBox16).BackColor = Color.SkyBlue;
					goto IL_00ad;
					IL_00c6:
					num = 16;
					goto IL_00cb;
					IL_00ad:
					num = 13;
					val.Font = new Font(val.Font, (FontStyle)0);
					goto IL_00c6;
					IL_002a:
					num = 3;
					name = val.Name;
					goto IL_0035;
					IL_0035:
					num = 6;
					if (Operators.CompareString(name, "RichTextBox1", false) == 0)
					{
						goto IL_004f;
					}
					goto IL_00c6;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 344;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Panel2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox16_MouseDown(object sender, MouseEventArgs e)
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

	private void PictureBox3_Click(object sender, EventArgs e)
	{
	}

	private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
	{
		ref Point reference = ref mouse_move;
		reference = checked(new Point(-e.X, -e.Y));
	}

	private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
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

	private void PictureBox2_GotFocus(object sender, EventArgs e)
	{
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
