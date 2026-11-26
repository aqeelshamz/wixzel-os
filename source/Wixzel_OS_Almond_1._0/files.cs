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
public class files : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox8")]
	private PictureBox _PictureBox8;

	[AccessedThroughProperty("PictureBox9")]
	private PictureBox _PictureBox9;

	[AccessedThroughProperty("PictureBox10")]
	private PictureBox _PictureBox10;

	[AccessedThroughProperty("PictureBox11")]
	private PictureBox _PictureBox11;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	[AccessedThroughProperty("PictureBox15")]
	private PictureBox _PictureBox15;

	[AccessedThroughProperty("PictureBox16")]
	private PictureBox _PictureBox16;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("Label4")]
	private Label _Label4;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("PictureBox17")]
	private PictureBox _PictureBox17;

	[AccessedThroughProperty("PictureBox12")]
	private PictureBox _PictureBox12;

	[AccessedThroughProperty("PictureBox18")]
	private PictureBox _PictureBox18;

	[AccessedThroughProperty("ImageList1")]
	private ImageList _ImageList1;

	[AccessedThroughProperty("ListView1")]
	private ListView _ListView1;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("Timer1")]
	private Timer _Timer1;

	private Point mouse_move;

	private string path;

	private string nextpath;

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
			_PictureBox13 = value;
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
			_PictureBox14 = value;
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
			_PictureBox15 = value;
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
			_PictureBox16 = value;
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

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label15_Click;
			if (_Label15 != null)
			{
				((Control)_Label15).Click -= eventHandler;
			}
			_Label15 = value;
			if (_Label15 != null)
			{
				((Control)_Label15).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
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
			EventHandler eventHandler = PictureBox17_Click;
			if (_PictureBox17 != null)
			{
				((Control)_PictureBox17).Click -= eventHandler;
			}
			_PictureBox17 = value;
			if (_PictureBox17 != null)
			{
				((Control)_PictureBox17).Click += eventHandler;
			}
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
			EventHandler eventHandler = PictureBox12_Click;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).Click -= eventHandler;
			}
			_PictureBox12 = value;
			if (_PictureBox12 != null)
			{
				((Control)_PictureBox12).Click += eventHandler;
			}
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
			EventHandler eventHandler = PictureBox18_Click;
			if (_PictureBox18 != null)
			{
				((Control)_PictureBox18).Click -= eventHandler;
			}
			_PictureBox18 = value;
			if (_PictureBox18 != null)
			{
				((Control)_PictureBox18).Click += eventHandler;
			}
		}
	}

	internal virtual ImageList ImageList1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ImageList1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ImageList1 = value;
		}
	}

	internal virtual ListView ListView1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ListView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			EventHandler eventHandler = ListView1_SelectedIndexChanged;
			MouseEventHandler val = new MouseEventHandler(ListView1_MouseDown);
			MouseEventHandler val2 = new MouseEventHandler(ListView1_MouseDoubleClick);
			ListViewItemSelectionChangedEventHandler val3 = new ListViewItemSelectionChangedEventHandler(ListView1_ItemSelectionChanged);
			EventHandler eventHandler2 = ListView1_Click;
			if (_ListView1 != null)
			{
				_ListView1.SelectedIndexChanged -= eventHandler;
				((Control)_ListView1).MouseDown -= val;
				((Control)_ListView1).MouseDoubleClick -= val2;
				_ListView1.ItemSelectionChanged -= val3;
				((Control)_ListView1).Click -= eventHandler2;
			}
			_ListView1 = value;
			if (_ListView1 != null)
			{
				_ListView1.SelectedIndexChanged += eventHandler;
				((Control)_ListView1).MouseDown += val;
				((Control)_ListView1).MouseDoubleClick += val2;
				_ListView1.ItemSelectionChanged += val3;
				((Control)_ListView1).Click += eventHandler2;
			}
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Label18_Click;
			if (_Label18 != null)
			{
				((Control)_Label18).Click -= eventHandler;
			}
			_Label18 = value;
			if (_Label18 != null)
			{
				((Control)_Label18).Click += eventHandler;
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
			EventHandler eventHandler = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).TextChanged -= eventHandler;
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).TextChanged += eventHandler;
			}
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
			_PictureBox19 = value;
		}
	}

	internal virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
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
			_PictureBox20 = value;
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

	[DebuggerNonUserCode]
	public files()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(files_FormClosing);
		((Form)this).Load += files_Load;
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
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Expected O, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected O, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected O, but got Unknown
		//IL_0a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected O, but got Unknown
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected O, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected O, but got Unknown
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected O, but got Unknown
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e48: Expected O, but got Unknown
		//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Expected O, but got Unknown
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f80: Expected O, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Expected O, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected O, but got Unknown
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1154: Expected O, but got Unknown
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f0: Expected O, but got Unknown
		//IL_1291: Unknown result type (might be due to invalid IL or missing references)
		//IL_129b: Expected O, but got Unknown
		//IL_1347: Unknown result type (might be due to invalid IL or missing references)
		//IL_1351: Expected O, but got Unknown
		//IL_1400: Unknown result type (might be due to invalid IL or missing references)
		//IL_140a: Expected O, but got Unknown
		//IL_14b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c3: Expected O, but got Unknown
		//IL_1572: Unknown result type (might be due to invalid IL or missing references)
		//IL_157c: Expected O, but got Unknown
		//IL_162b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1635: Expected O, but got Unknown
		//IL_16e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ee: Expected O, but got Unknown
		//IL_179d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7: Expected O, but got Unknown
		//IL_1856: Unknown result type (might be due to invalid IL or missing references)
		//IL_1860: Expected O, but got Unknown
		//IL_190f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1919: Expected O, but got Unknown
		//IL_19c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d2: Expected O, but got Unknown
		//IL_1a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8b: Expected O, but got Unknown
		//IL_1b3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b44: Expected O, but got Unknown
		//IL_1bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bfd: Expected O, but got Unknown
		//IL_1cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb6: Expected O, but got Unknown
		//IL_1d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6f: Expected O, but got Unknown
		//IL_1dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e08: Expected O, but got Unknown
		//IL_1ef6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f00: Expected O, but got Unknown
		//IL_1f9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa8: Expected O, but got Unknown
		//IL_2046: Unknown result type (might be due to invalid IL or missing references)
		//IL_2050: Expected O, but got Unknown
		//IL_20dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_20e7: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(files));
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Panel1 = new Panel();
		Label19 = new Label();
		Label18 = new Label();
		TextBox1 = new TextBox();
		PictureBox19 = new PictureBox();
		PictureBox18 = new PictureBox();
		PictureBox17 = new PictureBox();
		PictureBox12 = new PictureBox();
		PictureBox4 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox7 = new PictureBox();
		PictureBox8 = new PictureBox();
		PictureBox9 = new PictureBox();
		PictureBox10 = new PictureBox();
		PictureBox11 = new PictureBox();
		PictureBox13 = new PictureBox();
		PictureBox14 = new PictureBox();
		PictureBox15 = new PictureBox();
		PictureBox16 = new PictureBox();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		Label9 = new Label();
		Label10 = new Label();
		Label11 = new Label();
		Label12 = new Label();
		Label13 = new Label();
		Label14 = new Label();
		Label15 = new Label();
		Label16 = new Label();
		Label17 = new Label();
		ImageList1 = new ImageList(components);
		ListView1 = new ListView();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox20 = new PictureBox();
		Timer1 = new Timer(components);
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox19).BeginInit();
		((ISupportInitialize)PictureBox18).BeginInit();
		((ISupportInitialize)PictureBox17).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox13).BeginInit();
		((ISupportInitialize)PictureBox14).BeginInit();
		((ISupportInitialize)PictureBox15).BeginInit();
		((ISupportInitialize)PictureBox16).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox20).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		Point location = new Point(1309, 3);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		Size size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 16;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(38, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(40, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 15;
		Label1.Text = "Files";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(10, 8);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(22, 17);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 14;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox5 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox6 = PictureBox1;
		size = new Size(1374, 35);
		((Control)pictureBox6).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 13;
		PictureBox1.TabStop = false;
		((Control)Panel1).Controls.Add((Control)(object)Label19);
		((Control)Panel1).Controls.Add((Control)(object)Label18);
		((Control)Panel1).Controls.Add((Control)(object)TextBox1);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox19);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox18);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox17);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox12);
		Panel panel = Panel1;
		location = new Point(0, 32);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(1360, 68);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 17;
		Label19.AutoSize = true;
		((Control)Label19).BackColor = Color.White;
		((Control)Label19).Font = new Font("Futura Bk BT", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = Color.Gray;
		Label label3 = Label19;
		location = new Point(162, 48);
		((Control)label3).Location = location;
		((Control)Label19).Name = "Label19";
		Label label4 = Label19;
		size = new Size(138, 16);
		((Control)label4).Size = size;
		((Control)Label19).TabIndex = 54;
		Label19.Text = "Wixzel OS Almond 1.0";
		Label18.AutoSize = true;
		((Control)Label18).BackColor = Color.White;
		((Control)Label18).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.FromArgb(35, 35, 35);
		Label label5 = Label18;
		location = new Point(162, 24);
		((Control)label5).Location = location;
		((Control)Label18).Name = "Label18";
		Label label6 = Label18;
		size = new Size(157, 18);
		((Control)label6).Size = size;
		((Control)Label18).TabIndex = 49;
		Label18.Text = "Wixzel OS Almond 1.0";
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		TextBox textBox = TextBox1;
		location = new Point(744, 25);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(248, 15);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 53;
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox pictureBox7 = PictureBox19;
		location = new Point(736, 19);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox pictureBox8 = PictureBox19;
		size = new Size(264, 29);
		((Control)pictureBox8).Size = size;
		PictureBox19.SizeMode = (PictureBoxSizeMode)1;
		PictureBox19.TabIndex = 52;
		PictureBox19.TabStop = false;
		((Control)PictureBox18).BackColor = Color.White;
		PictureBox18.Image = (Image)componentResourceManager.GetObject("PictureBox18.Image");
		PictureBox pictureBox9 = PictureBox18;
		location = new Point(1000, 9);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox18).Name = "PictureBox18";
		PictureBox pictureBox10 = PictureBox18;
		size = new Size(50, 50);
		((Control)pictureBox10).Size = size;
		PictureBox18.SizeMode = (PictureBoxSizeMode)2;
		PictureBox18.TabIndex = 50;
		PictureBox18.TabStop = false;
		((Control)PictureBox17).BackColor = Color.White;
		PictureBox17.Image = (Image)componentResourceManager.GetObject("PictureBox17.Image");
		PictureBox pictureBox11 = PictureBox17;
		location = new Point(75, 3);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox17).Name = "PictureBox17";
		PictureBox pictureBox12 = PictureBox17;
		size = new Size(60, 60);
		((Control)pictureBox12).Size = size;
		PictureBox17.SizeMode = (PictureBoxSizeMode)2;
		PictureBox17.TabIndex = 49;
		PictureBox17.TabStop = false;
		((Control)PictureBox12).BackColor = Color.White;
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox13 = PictureBox12;
		location = new Point(12, 3);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox14 = PictureBox12;
		size = new Size(60, 60);
		((Control)pictureBox14).Size = size;
		PictureBox12.SizeMode = (PictureBoxSizeMode)2;
		PictureBox12.TabIndex = 48;
		PictureBox12.TabStop = false;
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox15 = PictureBox4;
		location = new Point(42, 248);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox16 = PictureBox4;
		size = new Size(24, 24);
		((Control)pictureBox16).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 18;
		PictureBox4.TabStop = false;
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox17 = PictureBox5;
		location = new Point(42, 288);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox18 = PictureBox5;
		size = new Size(24, 24);
		((Control)pictureBox18).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 19;
		PictureBox5.TabStop = false;
		((Control)PictureBox6).BackColor = Color.White;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox19 = PictureBox6;
		location = new Point(42, 327);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox20 = PictureBox6;
		size = new Size(24, 24);
		((Control)pictureBox20).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 20;
		PictureBox6.TabStop = false;
		((Control)PictureBox7).BackColor = Color.White;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox21 = PictureBox7;
		location = new Point(42, 367);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox22 = PictureBox7;
		size = new Size(24, 24);
		((Control)pictureBox22).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 21;
		PictureBox7.TabStop = false;
		((Control)PictureBox8).BackColor = Color.White;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox23 = PictureBox8;
		location = new Point(42, 563);
		((Control)pictureBox23).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox24 = PictureBox8;
		size = new Size(24, 24);
		((Control)pictureBox24).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)2;
		PictureBox8.TabIndex = 25;
		PictureBox8.TabStop = false;
		((Control)PictureBox9).BackColor = Color.White;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox25 = PictureBox9;
		location = new Point(42, 523);
		((Control)pictureBox25).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox26 = PictureBox9;
		size = new Size(24, 24);
		((Control)pictureBox26).Size = size;
		PictureBox9.SizeMode = (PictureBoxSizeMode)2;
		PictureBox9.TabIndex = 24;
		PictureBox9.TabStop = false;
		((Control)PictureBox10).BackColor = Color.White;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox27 = PictureBox10;
		location = new Point(42, 484);
		((Control)pictureBox27).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox28 = PictureBox10;
		size = new Size(24, 24);
		((Control)pictureBox28).Size = size;
		PictureBox10.SizeMode = (PictureBoxSizeMode)2;
		PictureBox10.TabIndex = 23;
		PictureBox10.TabStop = false;
		((Control)PictureBox11).BackColor = Color.White;
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox pictureBox29 = PictureBox11;
		location = new Point(42, 444);
		((Control)pictureBox29).Location = location;
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox pictureBox30 = PictureBox11;
		size = new Size(24, 24);
		((Control)pictureBox30).Size = size;
		PictureBox11.SizeMode = (PictureBoxSizeMode)2;
		PictureBox11.TabIndex = 22;
		PictureBox11.TabStop = false;
		((Control)PictureBox13).BackColor = Color.White;
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox31 = PictureBox13;
		location = new Point(42, 604);
		((Control)pictureBox31).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox32 = PictureBox13;
		size = new Size(24, 24);
		((Control)pictureBox32).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)2;
		PictureBox13.TabIndex = 26;
		PictureBox13.TabStop = false;
		((Control)PictureBox14).BackColor = Color.White;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox33 = PictureBox14;
		location = new Point(42, 170);
		((Control)pictureBox33).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox34 = PictureBox14;
		size = new Size(24, 24);
		((Control)pictureBox34).Size = size;
		PictureBox14.SizeMode = (PictureBoxSizeMode)2;
		PictureBox14.TabIndex = 29;
		PictureBox14.TabStop = false;
		((Control)PictureBox15).BackColor = Color.White;
		PictureBox15.Image = (Image)componentResourceManager.GetObject("PictureBox15.Image");
		PictureBox pictureBox35 = PictureBox15;
		location = new Point(42, 130);
		((Control)pictureBox35).Location = location;
		((Control)PictureBox15).Name = "PictureBox15";
		PictureBox pictureBox36 = PictureBox15;
		size = new Size(24, 24);
		((Control)pictureBox36).Size = size;
		PictureBox15.SizeMode = (PictureBoxSizeMode)2;
		PictureBox15.TabIndex = 28;
		PictureBox15.TabStop = false;
		((Control)PictureBox16).BackColor = Color.White;
		PictureBox16.Image = (Image)componentResourceManager.GetObject("PictureBox16.Image");
		PictureBox pictureBox37 = PictureBox16;
		location = new Point(42, 679);
		((Control)pictureBox37).Location = location;
		((Control)PictureBox16).Name = "PictureBox16";
		PictureBox pictureBox38 = PictureBox16;
		size = new Size(24, 24);
		((Control)pictureBox38).Size = size;
		PictureBox16.SizeMode = (PictureBoxSizeMode)2;
		PictureBox16.TabIndex = 30;
		PictureBox16.TabStop = false;
		Label2.AutoSize = true;
		((Control)Label2).BackColor = Color.White;
		((Control)Label2).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.FromArgb(35, 35, 35);
		Label label7 = Label2;
		location = new Point(24, 103);
		((Control)label7).Location = location;
		((Control)Label2).Name = "Label2";
		Label label8 = Label2;
		size = new Size(60, 18);
		((Control)label8).Size = size;
		((Control)Label2).TabIndex = 31;
		Label2.Text = "System";
		Label3.AutoSize = true;
		((Control)Label3).BackColor = Color.White;
		((Control)Label3).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.FromArgb(35, 35, 35);
		Label label9 = Label3;
		location = new Point(24, 220);
		((Control)label9).Location = location;
		((Control)Label3).Name = "Label3";
		Label label10 = Label3;
		size = new Size(61, 18);
		((Control)label10).Size = size;
		((Control)Label3).TabIndex = 32;
		Label3.Text = "Library";
		Label4.AutoSize = true;
		((Control)Label4).BackColor = Color.White;
		((Control)Label4).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.FromArgb(35, 35, 35);
		Label label11 = Label4;
		location = new Point(24, 414);
		((Control)label11).Location = location;
		((Control)Label4).Name = "Label4";
		Label label12 = Label4;
		size = new Size(43, 18);
		((Control)label12).Size = size;
		((Control)Label4).TabIndex = 33;
		Label4.Text = "Files";
		Label5.AutoSize = true;
		((Control)Label5).BackColor = Color.White;
		((Control)Label5).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.FromArgb(35, 35, 35);
		Label label13 = Label5;
		location = new Point(24, 652);
		((Control)label13).Location = location;
		((Control)Label5).Name = "Label5";
		Label label14 = Label5;
		size = new Size(58, 18);
		((Control)label14).Size = size;
		((Control)Label5).TabIndex = 34;
		Label5.Text = "Others";
		Label6.AutoSize = true;
		((Control)Label6).BackColor = Color.White;
		((Control)Label6).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.FromArgb(35, 35, 35);
		Label label15 = Label6;
		location = new Point(72, 135);
		((Control)label15).Location = location;
		((Control)Label6).Name = "Label6";
		Label label16 = Label6;
		size = new Size(49, 18);
		((Control)label16).Size = size;
		((Control)Label6).TabIndex = 36;
		Label6.Text = "Home";
		Label7.AutoSize = true;
		((Control)Label7).BackColor = Color.White;
		((Control)Label7).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.FromArgb(35, 35, 35);
		Label label17 = Label7;
		location = new Point(72, 175);
		((Control)label17).Location = location;
		((Control)Label7).Name = "Label7";
		Label label18 = Label7;
		size = new Size(83, 18);
		((Control)label18).Size = size;
		((Control)Label7).TabIndex = 37;
		Label7.Text = "Downloads";
		Label8.AutoSize = true;
		((Control)Label8).BackColor = Color.White;
		((Control)Label8).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.FromArgb(35, 35, 35);
		Label label19 = Label8;
		location = new Point(72, 293);
		((Control)label19).Location = location;
		((Control)Label8).Name = "Label8";
		Label label20 = Label8;
		size = new Size(58, 18);
		((Control)label20).Size = size;
		((Control)Label8).TabIndex = 39;
		Label8.Text = "Pictures";
		Label9.AutoSize = true;
		((Control)Label9).BackColor = Color.White;
		((Control)Label9).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.FromArgb(35, 35, 35);
		Label label21 = Label9;
		location = new Point(72, 253);
		((Control)label21).Location = location;
		((Control)Label9).Name = "Label9";
		Label label22 = Label9;
		size = new Size(82, 18);
		((Control)label22).Size = size;
		((Control)Label9).TabIndex = 38;
		Label9.Text = "Documents";
		Label10.AutoSize = true;
		((Control)Label10).BackColor = Color.White;
		((Control)Label10).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.FromArgb(35, 35, 35);
		Label label23 = Label10;
		location = new Point(72, 372);
		((Control)label23).Location = location;
		((Control)Label10).Name = "Label10";
		Label label24 = Label10;
		size = new Size(53, 18);
		((Control)label24).Size = size;
		((Control)Label10).TabIndex = 41;
		Label10.Text = "Videos";
		Label11.AutoSize = true;
		((Control)Label11).BackColor = Color.White;
		((Control)Label11).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.FromArgb(35, 35, 35);
		Label label25 = Label11;
		location = new Point(72, 332);
		((Control)label25).Location = location;
		((Control)Label11).Name = "Label11";
		Label label26 = Label11;
		size = new Size(46, 18);
		((Control)label26).Size = size;
		((Control)Label11).TabIndex = 40;
		Label11.Text = "Music";
		Label12.AutoSize = true;
		((Control)Label12).BackColor = Color.White;
		((Control)Label12).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.FromArgb(35, 35, 35);
		Label label27 = Label12;
		location = new Point(72, 568);
		((Control)label27).Location = location;
		((Control)Label12).Name = "Label12";
		Label label28 = Label12;
		size = new Size(38, 18);
		((Control)label28).Size = size;
		((Control)Label12).TabIndex = 45;
		Label12.Text = "Files";
		Label13.AutoSize = true;
		((Control)Label13).BackColor = Color.White;
		((Control)Label13).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.FromArgb(35, 35, 35);
		Label label29 = Label13;
		location = new Point(72, 528);
		((Control)label29).Location = location;
		((Control)Label13).Name = "Label13";
		Label label30 = Label13;
		size = new Size(38, 18);
		((Control)label30).Size = size;
		((Control)Label13).TabIndex = 44;
		Label13.Text = "Files";
		Label14.AutoSize = true;
		((Control)Label14).BackColor = Color.White;
		((Control)Label14).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.FromArgb(35, 35, 35);
		Label label31 = Label14;
		location = new Point(72, 489);
		((Control)label31).Location = location;
		((Control)Label14).Name = "Label14";
		Label label32 = Label14;
		size = new Size(38, 18);
		((Control)label32).Size = size;
		((Control)Label14).TabIndex = 43;
		Label14.Text = "Files";
		Label15.AutoSize = true;
		((Control)Label15).BackColor = Color.White;
		((Control)Label15).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.FromArgb(35, 35, 35);
		Label label33 = Label15;
		location = new Point(72, 449);
		((Control)label33).Location = location;
		((Control)Label15).Name = "Label15";
		Label label34 = Label15;
		size = new Size(42, 18);
		((Control)label34).Size = size;
		((Control)Label15).TabIndex = 42;
		Label15.Text = "Main";
		Label16.AutoSize = true;
		((Control)Label16).BackColor = Color.White;
		((Control)Label16).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.FromArgb(35, 35, 35);
		Label label35 = Label16;
		location = new Point(72, 609);
		((Control)label35).Location = location;
		((Control)Label16).Name = "Label16";
		Label label36 = Label16;
		size = new Size(38, 18);
		((Control)label36).Size = size;
		((Control)Label16).TabIndex = 46;
		Label16.Text = "Files";
		Label17.AutoSize = true;
		((Control)Label17).BackColor = Color.White;
		((Control)Label17).Font = new Font("Futura Bk BT", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.FromArgb(35, 35, 35);
		Label label37 = Label17;
		location = new Point(72, 684);
		((Control)label37).Location = location;
		((Control)Label17).Name = "Label17";
		Label label38 = Label17;
		size = new Size(59, 18);
		((Control)label38).Size = size;
		((Control)Label17).TabIndex = 47;
		Label17.Text = "Settings";
		ImageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ImageList1.ImageStream");
		ImageList1.TransparentColor = Color.Transparent;
		ImageList1.Images.SetKeyName(0, "logo48.png");
		ImageList1.Images.SetKeyName(1, "file48.png");
		ListView1.LargeImageList = ImageList1;
		ListView listView = ListView1;
		location = new Point(165, 100);
		((Control)listView).Location = location;
		((Control)ListView1).Name = "ListView1";
		ListView listView2 = ListView1;
		size = new Size(1190, 620);
		((Control)listView2).Size = size;
		ListView1.SmallImageList = ImageList1;
		((Control)ListView1).TabIndex = 48;
		ListView1.UseCompatibleStateImageBehavior = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj = defaultclose;
		location = new Point(828, 0);
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
		location = new Point(885, 0);
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
		location = new Point(942, 0);
		((Control)obj5).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj6 = clickclose;
		size = new Size(51, 34);
		((Control)obj6).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox pictureBox39 = PictureBox20;
		location = new Point(1252, 3);
		((Control)pictureBox39).Location = location;
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox pictureBox40 = PictureBox20;
		size = new Size(51, 34);
		((Control)pictureBox40).Size = size;
		PictureBox20.SizeMode = (PictureBoxSizeMode)2;
		PictureBox20.TabIndex = 118;
		PictureBox20.TabStop = false;
		Timer1.Enabled = true;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.White;
		size = new Size(1360, 723);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)PictureBox20);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)ListView1);
		((Control)this).Controls.Add((Control)(object)Label17);
		((Control)this).Controls.Add((Control)(object)Label16);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)Label13);
		((Control)this).Controls.Add((Control)(object)Label14);
		((Control)this).Controls.Add((Control)(object)Label15);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)PictureBox16);
		((Control)this).Controls.Add((Control)(object)PictureBox14);
		((Control)this).Controls.Add((Control)(object)PictureBox15);
		((Control)this).Controls.Add((Control)(object)PictureBox13);
		((Control)this).Controls.Add((Control)(object)PictureBox8);
		((Control)this).Controls.Add((Control)(object)PictureBox9);
		((Control)this).Controls.Add((Control)(object)PictureBox10);
		((Control)this).Controls.Add((Control)(object)PictureBox11);
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)PictureBox6);
		((Control)this).Controls.Add((Control)(object)PictureBox5);
		((Control)this).Controls.Add((Control)(object)PictureBox4);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "files";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox19).EndInit();
		((ISupportInitialize)PictureBox18).EndInit();
		((ISupportInitialize)PictureBox17).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox13).EndInit();
		((ISupportInitialize)PictureBox14).EndInit();
		((ISupportInitialize)PictureBox15).EndInit();
		((ISupportInitialize)PictureBox16).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox20).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void files_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.filesout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.file.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void files_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		string current2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					Point point2;
					ListView listView;
					switch (try0001_dispatch)
					{
					default:
					{
						num = 1;
						PictureBox pictureBox = PictureBox3;
						Point location = new Point(((Control)this).Width - ((Control)PictureBox3).Width, 0);
						((Control)pictureBox).Location = location;
						goto IL_002c;
					}
					case 4173:
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
								goto IL_002c;
							case 3:
								goto IL_0078;
							case 4:
								goto IL_00ad;
							case 5:
								goto IL_00f5;
							case 6:
								goto IL_0115;
							case 7:
								goto IL_012e;
							case 9:
								goto IL_015f;
							case 10:
								goto IL_0164;
							case 11:
								goto IL_0185;
							case 12:
								goto IL_019f;
							case 14:
								goto IL_01d1;
							case 15:
								goto IL_01d6;
							case 16:
								goto IL_01f7;
							case 17:
								goto IL_0211;
							case 19:
								goto IL_0243;
							case 20:
								goto IL_0248;
							case 21:
								goto IL_0269;
							case 22:
								goto IL_0283;
							case 24:
								goto IL_02b5;
							case 25:
								goto IL_02ba;
							case 26:
								goto IL_02db;
							case 27:
								goto IL_02f5;
							case 29:
								goto IL_0327;
							case 30:
								goto IL_032c;
							case 31:
								goto IL_034d;
							case 32:
								goto IL_0367;
							case 34:
								goto IL_0399;
							case 35:
								goto IL_039e;
							case 36:
								goto IL_03bf;
							case 37:
								goto IL_03d9;
							case 39:
								goto IL_040b;
							case 40:
								goto IL_0410;
							case 41:
								goto IL_0431;
							case 42:
								goto IL_044b;
							case 44:
								goto IL_047d;
							case 45:
								goto IL_0482;
							case 46:
								goto IL_04a3;
							case 47:
								goto IL_04bd;
							case 49:
								goto IL_04ef;
							case 50:
								goto IL_04f4;
							case 51:
								goto IL_0515;
							case 52:
								goto IL_052f;
							case 54:
								goto IL_0561;
							case 55:
								goto IL_0566;
							case 56:
								goto IL_0587;
							case 57:
								goto IL_05a1;
							case 59:
								goto IL_05d3;
							case 60:
								goto IL_05d8;
							case 61:
								goto IL_05f9;
							case 62:
								goto IL_0613;
							case 64:
								goto IL_0645;
							case 65:
								goto IL_064a;
							case 66:
								goto IL_066b;
							case 67:
								goto IL_0685;
							case 69:
								goto IL_06b7;
							case 70:
								goto IL_06bc;
							case 71:
								goto IL_06dd;
							case 72:
								goto IL_06f7;
							case 74:
								goto IL_0729;
							case 75:
								goto IL_072e;
							case 76:
								goto IL_074f;
							case 77:
								goto IL_0769;
							case 79:
								goto IL_079b;
							case 80:
								goto IL_07a0;
							case 81:
								goto IL_07c1;
							case 82:
								goto IL_07db;
							case 84:
								goto IL_080d;
							case 85:
								goto IL_0812;
							case 86:
								goto IL_0833;
							case 87:
								goto IL_084d;
							case 89:
								goto IL_087f;
							case 90:
								goto IL_0884;
							case 91:
								goto IL_08a5;
							case 92:
								goto IL_08bf;
							case 94:
								goto IL_08f1;
							case 95:
								goto IL_08f6;
							case 96:
								goto IL_0917;
							case 97:
								goto IL_0931;
							case 99:
								goto IL_0963;
							case 100:
								goto IL_0968;
							case 101:
								goto IL_0989;
							case 102:
								goto IL_09a3;
							case 104:
								goto IL_09d5;
							case 105:
								goto IL_09da;
							case 106:
								goto IL_09fb;
							case 107:
								goto IL_0a15;
							case 109:
								goto IL_0a47;
							case 110:
								goto IL_0a4c;
							case 111:
								goto IL_0a6d;
							case 112:
								goto IL_0a87;
							case 114:
								goto IL_0ab9;
							case 115:
								goto IL_0abe;
							case 116:
								goto IL_0adf;
							case 117:
								goto IL_0af9;
							case 119:
								goto IL_0b2b;
							case 120:
								goto IL_0b30;
							case 121:
								goto IL_0b51;
							case 122:
								goto IL_0b6b;
							case 124:
								goto IL_0b9a;
							case 125:
								goto IL_0b9f;
							case 126:
								goto IL_0bc0;
							case 127:
								goto IL_0bda;
							case 8:
							case 13:
							case 18:
							case 23:
							case 28:
							case 33:
							case 38:
							case 43:
							case 48:
							case 53:
							case 58:
							case 63:
							case 68:
							case 73:
							case 78:
							case 83:
							case 88:
							case 93:
							case 98:
							case 103:
							case 108:
							case 113:
							case 118:
							case 123:
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
							case 152:
							case 153:
								goto IL_0c20;
							case 154:
								goto IL_0c2d;
							case 155:
								goto IL_0c36;
							case 156:
								goto IL_0c61;
							case 157:
								goto IL_0c7a;
							case 158:
								goto IL_0ca7;
							case 159:
								goto IL_0ce4;
							case 160:
								goto IL_0d10;
							case 161:
								goto IL_0d3d;
							case 162:
								goto IL_0d7a;
							default:
								goto end_IL_0001;
							case 163:
								goto end_IL_0001_2;
							}
							goto default;
						}
						IL_0d82:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_0d3d;
						}
						enumerator?.Dispose();
						goto end_IL_0001_2;
						IL_0d3d:
						num = 161;
						ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), ImageList1.Images.Count - 1);
						goto IL_0d7a;
						IL_0d10:
						num = 160;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_0d82;
						IL_0ce4:
						num = 159;
						goto IL_0cec;
						IL_002c:
						num = 2;
						point2 = (((Control)PictureBox20).Location = new Point(((Control)PictureBox3).Location.X - ((Control)PictureBox20).Width, ((Control)PictureBox3).Location.Y));
						goto IL_0078;
						IL_0078:
						num = 3;
						point2 = (((Control)ListView1).Location = new Point(170, ((Control)PictureBox1).Height + ((Control)Panel1).Height));
						goto IL_00ad;
						IL_00ad:
						num = 4;
						listView = ListView1;
						point2 = new Point(((Control)this).Width - 170, ((Control)this).Height - (((Control)PictureBox1).Height + ((Control)Panel1).Height));
						((Control)listView).Size = (Size)point2;
						goto IL_00f5;
						IL_00f5:
						num = 5;
						if (!((Control)MyProject.Forms.home.app1).Enabled)
						{
							goto IL_0115;
						}
						goto IL_015f;
						IL_0115:
						num = 6;
						((Control)MyProject.Forms.home.app1).Enabled = true;
						goto IL_012e;
						IL_012e:
						num = 7;
						MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_015f:
						num = 9;
						goto IL_0164;
						IL_0164:
						num = 10;
						if (!((Control)MyProject.Forms.home.app2).Enabled)
						{
							goto IL_0185;
						}
						goto IL_01d1;
						IL_0185:
						num = 11;
						((Control)MyProject.Forms.home.app2).Enabled = true;
						goto IL_019f;
						IL_019f:
						num = 12;
						MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_01d1:
						num = 14;
						goto IL_01d6;
						IL_01d6:
						num = 15;
						if (!((Control)MyProject.Forms.home.app3).Enabled)
						{
							goto IL_01f7;
						}
						goto IL_0243;
						IL_01f7:
						num = 16;
						((Control)MyProject.Forms.home.app3).Enabled = true;
						goto IL_0211;
						IL_0211:
						num = 17;
						MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0243:
						num = 19;
						goto IL_0248;
						IL_0248:
						num = 20;
						if (!((Control)MyProject.Forms.home.app4).Enabled)
						{
							goto IL_0269;
						}
						goto IL_02b5;
						IL_0269:
						num = 21;
						((Control)MyProject.Forms.home.app4).Enabled = true;
						goto IL_0283;
						IL_0283:
						num = 22;
						MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_02b5:
						num = 24;
						goto IL_02ba;
						IL_02ba:
						num = 25;
						if (!((Control)MyProject.Forms.home.app5).Enabled)
						{
							goto IL_02db;
						}
						goto IL_0327;
						IL_02db:
						num = 26;
						((Control)MyProject.Forms.home.app5).Enabled = true;
						goto IL_02f5;
						IL_02f5:
						num = 27;
						MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0327:
						num = 29;
						goto IL_032c;
						IL_032c:
						num = 30;
						if (!((Control)MyProject.Forms.home.app6).Enabled)
						{
							goto IL_034d;
						}
						goto IL_0399;
						IL_034d:
						num = 31;
						((Control)MyProject.Forms.home.app6).Enabled = true;
						goto IL_0367;
						IL_0367:
						num = 32;
						MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0399:
						num = 34;
						goto IL_039e;
						IL_039e:
						num = 35;
						if (!((Control)MyProject.Forms.home.app7).Enabled)
						{
							goto IL_03bf;
						}
						goto IL_040b;
						IL_03bf:
						num = 36;
						((Control)MyProject.Forms.home.app7).Enabled = true;
						goto IL_03d9;
						IL_03d9:
						num = 37;
						MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_040b:
						num = 39;
						goto IL_0410;
						IL_0410:
						num = 40;
						if (!((Control)MyProject.Forms.home.app8).Enabled)
						{
							goto IL_0431;
						}
						goto IL_047d;
						IL_0431:
						num = 41;
						((Control)MyProject.Forms.home.app8).Enabled = true;
						goto IL_044b;
						IL_044b:
						num = 42;
						MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_047d:
						num = 44;
						goto IL_0482;
						IL_0482:
						num = 45;
						if (!((Control)MyProject.Forms.home.app9).Enabled)
						{
							goto IL_04a3;
						}
						goto IL_04ef;
						IL_04a3:
						num = 46;
						((Control)MyProject.Forms.home.app9).Enabled = true;
						goto IL_04bd;
						IL_04bd:
						num = 47;
						MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_04ef:
						num = 49;
						goto IL_04f4;
						IL_04f4:
						num = 50;
						if (!((Control)MyProject.Forms.home.app10).Enabled)
						{
							goto IL_0515;
						}
						goto IL_0561;
						IL_0515:
						num = 51;
						((Control)MyProject.Forms.home.app10).Enabled = true;
						goto IL_052f;
						IL_052f:
						num = 52;
						MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0561:
						num = 54;
						goto IL_0566;
						IL_0566:
						num = 55;
						if (!((Control)MyProject.Forms.home.app11).Enabled)
						{
							goto IL_0587;
						}
						goto IL_05d3;
						IL_0587:
						num = 56;
						((Control)MyProject.Forms.home.app11).Enabled = true;
						goto IL_05a1;
						IL_05a1:
						num = 57;
						MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_05d3:
						num = 59;
						goto IL_05d8;
						IL_05d8:
						num = 60;
						if (!((Control)MyProject.Forms.home.app12).Enabled)
						{
							goto IL_05f9;
						}
						goto IL_0645;
						IL_05f9:
						num = 61;
						((Control)MyProject.Forms.home.app12).Enabled = true;
						goto IL_0613;
						IL_0613:
						num = 62;
						MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0645:
						num = 64;
						goto IL_064a;
						IL_064a:
						num = 65;
						if (!((Control)MyProject.Forms.home.app13).Enabled)
						{
							goto IL_066b;
						}
						goto IL_06b7;
						IL_066b:
						num = 66;
						((Control)MyProject.Forms.home.app13).Enabled = true;
						goto IL_0685;
						IL_0685:
						num = 67;
						MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_06b7:
						num = 69;
						goto IL_06bc;
						IL_06bc:
						num = 70;
						if (!((Control)MyProject.Forms.home.app14).Enabled)
						{
							goto IL_06dd;
						}
						goto IL_0729;
						IL_06dd:
						num = 71;
						((Control)MyProject.Forms.home.app14).Enabled = true;
						goto IL_06f7;
						IL_06f7:
						num = 72;
						MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0729:
						num = 74;
						goto IL_072e;
						IL_072e:
						num = 75;
						if (!((Control)MyProject.Forms.home.app15).Enabled)
						{
							goto IL_074f;
						}
						goto IL_079b;
						IL_074f:
						num = 76;
						((Control)MyProject.Forms.home.app15).Enabled = true;
						goto IL_0769;
						IL_0769:
						num = 77;
						MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_079b:
						num = 79;
						goto IL_07a0;
						IL_07a0:
						num = 80;
						if (!((Control)MyProject.Forms.home.app16).Enabled)
						{
							goto IL_07c1;
						}
						goto IL_080d;
						IL_07c1:
						num = 81;
						((Control)MyProject.Forms.home.app16).Enabled = true;
						goto IL_07db;
						IL_07db:
						num = 82;
						MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_080d:
						num = 84;
						goto IL_0812;
						IL_0812:
						num = 85;
						if (!((Control)MyProject.Forms.home.app17).Enabled)
						{
							goto IL_0833;
						}
						goto IL_087f;
						IL_0833:
						num = 86;
						((Control)MyProject.Forms.home.app17).Enabled = true;
						goto IL_084d;
						IL_084d:
						num = 87;
						MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_087f:
						num = 89;
						goto IL_0884;
						IL_0884:
						num = 90;
						if (!((Control)MyProject.Forms.home.app18).Enabled)
						{
							goto IL_08a5;
						}
						goto IL_08f1;
						IL_08a5:
						num = 91;
						((Control)MyProject.Forms.home.app18).Enabled = true;
						goto IL_08bf;
						IL_08bf:
						num = 92;
						MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_08f1:
						num = 94;
						goto IL_08f6;
						IL_08f6:
						num = 95;
						if (!((Control)MyProject.Forms.home.app19).Enabled)
						{
							goto IL_0917;
						}
						goto IL_0963;
						IL_0917:
						num = 96;
						((Control)MyProject.Forms.home.app19).Enabled = true;
						goto IL_0931;
						IL_0931:
						num = 97;
						MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0963:
						num = 99;
						goto IL_0968;
						IL_0968:
						num = 100;
						if (!((Control)MyProject.Forms.home.app20).Enabled)
						{
							goto IL_0989;
						}
						goto IL_09d5;
						IL_0989:
						num = 101;
						((Control)MyProject.Forms.home.app20).Enabled = true;
						goto IL_09a3;
						IL_09a3:
						num = 102;
						MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_09d5:
						num = 104;
						goto IL_09da;
						IL_09da:
						num = 105;
						if (!((Control)MyProject.Forms.home.app21).Enabled)
						{
							goto IL_09fb;
						}
						goto IL_0a47;
						IL_09fb:
						num = 106;
						((Control)MyProject.Forms.home.app21).Enabled = true;
						goto IL_0a15;
						IL_0a15:
						num = 107;
						MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0a47:
						num = 109;
						goto IL_0a4c;
						IL_0a4c:
						num = 110;
						if (!((Control)MyProject.Forms.home.app22).Enabled)
						{
							goto IL_0a6d;
						}
						goto IL_0ab9;
						IL_0a6d:
						num = 111;
						((Control)MyProject.Forms.home.app22).Enabled = true;
						goto IL_0a87;
						IL_0a87:
						num = 112;
						MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0ab9:
						num = 114;
						goto IL_0abe;
						IL_0abe:
						num = 115;
						if (!((Control)MyProject.Forms.home.app23).Enabled)
						{
							goto IL_0adf;
						}
						goto IL_0b2b;
						IL_0adf:
						num = 116;
						((Control)MyProject.Forms.home.app23).Enabled = true;
						goto IL_0af9;
						IL_0af9:
						num = 117;
						MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0b2b:
						num = 119;
						goto IL_0b30;
						IL_0b30:
						num = 120;
						if (!((Control)MyProject.Forms.home.app24).Enabled)
						{
							goto IL_0b51;
						}
						goto IL_0b9a;
						IL_0b51:
						num = 121;
						((Control)MyProject.Forms.home.app24).Enabled = true;
						goto IL_0b6b;
						IL_0b6b:
						num = 122;
						MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0b9a:
						num = 124;
						goto IL_0b9f;
						IL_0b9f:
						num = 125;
						if (!((Control)MyProject.Forms.home.app25).Enabled)
						{
							goto IL_0bc0;
						}
						goto IL_0c20;
						IL_0bc0:
						num = 126;
						((Control)MyProject.Forms.home.app25).Enabled = true;
						goto IL_0bda;
						IL_0bda:
						num = 127;
						MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.file.Image;
						goto IL_0c20;
						IL_0c20:
						num = 153;
						Fade.filesin();
						goto IL_0c2d;
						IL_0c2d:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0c36;
						IL_0c36:
						num = 155;
						path = MyProject.Forms.datacontrolroom.n2.Text + "\\";
						goto IL_0c61;
						IL_0c61:
						num = 156;
						Label18.Text = path;
						goto IL_0c7a;
						IL_0c7a:
						num = 157;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_0cec;
						IL_0cec:
						if (enumerator2.MoveNext())
						{
							current2 = enumerator2.Current;
							goto IL_0ca7;
						}
						enumerator2?.Dispose();
						goto IL_0d10;
						IL_0ca7:
						num = 158;
						ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), ImageList1.Images.Count - 2);
						goto IL_0ce4;
						IL_0d7a:
						num = 162;
						goto IL_0d82;
						end_IL_0001:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 4173;
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

	private void ListView1_Click(object sender, EventArgs e)
	{
	}

	private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
	{
		nextpath = path + "\\" + e.Item.Text;
		Label19.Text = nextpath;
	}

	private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		string current2 = default(string);
		string text = default(string);
		StreamReader streamReader = default(StreamReader);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000a;
					case 1030:
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
								goto IL_000a;
							case 3:
								goto IL_002b;
							case 4:
								goto IL_003a;
							case 5:
								goto IL_0049;
							case 6:
								goto IL_005e;
							case 7:
								goto IL_0087;
							case 8:
								goto IL_00c0;
							case 9:
								goto IL_00e8;
							case 10:
								goto IL_0112;
							case 11:
								goto IL_014c;
							case 13:
								goto IL_017a;
							case 14:
								goto IL_017f;
							case 15:
								goto IL_01a2;
							case 16:
								goto IL_01b6;
							case 17:
								goto IL_01c6;
							case 18:
								goto IL_01d1;
							case 19:
								goto IL_01f0;
							case 21:
								goto IL_0200;
							case 22:
								goto IL_0223;
							case 23:
								goto IL_0237;
							case 25:
								goto IL_026a;
							case 26:
								goto IL_028d;
							case 27:
								goto IL_02a1;
							case 28:
								goto IL_02c5;
							case 30:
								goto IL_02e1;
							case 31:
								goto IL_0304;
							case 33:
								goto IL_031a;
							case 34:
								goto IL_031f;
							case 35:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 12:
							case 20:
							case 24:
							case 29:
							case 32:
							case 36:
							case 37:
							case 38:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0237:
						num = 23;
						MyProject.Forms.meebrowser.WebBrowser1.Navigate("file:///" + Label19.Text);
						goto end_IL_0001_3;
						IL_026a:
						num = 25;
						if (Strings.InStr(Label19.Text, ".mp3", (CompareMethod)0) != 0)
						{
							goto IL_028d;
						}
						goto IL_02e1;
						IL_0223:
						num = 22;
						((Control)MyProject.Forms.meebrowser).Show();
						goto IL_0237;
						IL_028d:
						num = 26;
						((Control)MyProject.Forms.mediaplayer).Show();
						goto IL_02a1;
						IL_000a:
						num = 2;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(nextpath))
						{
							goto IL_002b;
						}
						goto IL_017a;
						IL_002b:
						num = 3;
						path = nextpath;
						goto IL_003a;
						IL_003a:
						num = 4;
						ListView1.Clear();
						goto IL_0049;
						IL_0049:
						num = 5;
						Label18.Text = path;
						goto IL_005e;
						IL_005e:
						num = 6;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_00c4;
						IL_00c4:
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							goto IL_0087;
						}
						enumerator?.Dispose();
						goto IL_00e8;
						IL_02a1:
						num = 27;
						MyProject.Forms.mediaplayer.player.openPlayer(Label19.Text);
						goto IL_02c5;
						IL_02e1:
						num = 30;
						if (Strings.InStr(Label19.Text, ".mp4", (CompareMethod)0) != 0)
						{
							goto IL_0304;
						}
						goto IL_031a;
						IL_00e8:
						num = 9;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_0151;
						IL_0151:
						if (enumerator2.MoveNext())
						{
							current2 = enumerator2.Current;
							goto IL_0112;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						IL_0304:
						num = 31;
						((Control)MyProject.Forms.mediaplayer).Show();
						goto end_IL_0001_3;
						IL_031f:
						num = 34;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_031a:
						num = 33;
						goto IL_031f;
						IL_0112:
						num = 10;
						ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), ImageList1.Images.Count - 1);
						goto IL_014c;
						IL_014c:
						num = 11;
						goto IL_0151;
						IL_02c5:
						num = 28;
						((Control)MyProject.Forms.mediaplayer.player).Visible = false;
						goto end_IL_0001_3;
						IL_0087:
						num = 7;
						ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), ImageList1.Images.Count - 2);
						goto IL_00c0;
						IL_00c0:
						num = 8;
						goto IL_00c4;
						IL_017a:
						num = 13;
						goto IL_017f;
						IL_017f:
						num = 14;
						if (Strings.InStr(Label19.Text, ".txt", (CompareMethod)0) != 0)
						{
							goto IL_01a2;
						}
						goto IL_0200;
						IL_01a2:
						num = 15;
						((Control)MyProject.Forms.wordpro).Show();
						goto IL_01b6;
						IL_01b6:
						num = 16;
						text = Label19.Text;
						goto IL_01c6;
						IL_01c6:
						num = 17;
						streamReader = new StreamReader(text);
						goto IL_01d1;
						IL_01d1:
						num = 18;
						MyProject.Forms.wordpro.RichTextBox1.Text = streamReader.ReadToEnd();
						goto IL_01f0;
						IL_01f0:
						num = 19;
						streamReader.Close();
						goto end_IL_0001_3;
						IL_0200:
						num = 21;
						if (Strings.InStr(Label19.Text, ".pdf", (CompareMethod)0) != 0)
						{
							goto IL_0223;
						}
						goto IL_026a;
						end_IL_0001_2:
						break;
					}
					num = 35;
					MyProject.Forms.dialog.Label1.Text = "Cannot open the file.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1030;
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

	private void ListView1_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void PictureBox18_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						path = TextBox1.Text;
						goto IL_0015;
					case 495:
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
								goto IL_0015;
							case 3:
								goto IL_001e;
							case 4:
								goto IL_003f;
							case 5:
								goto IL_004e;
							case 6:
								goto IL_0075;
							case 7:
								goto IL_00ae;
							case 8:
								goto IL_00d3;
							case 9:
								goto IL_00fa;
							case 10:
								goto IL_0134;
							case 12:
								goto IL_015c;
							case 13:
								goto IL_0161;
							case 14:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 11:
							case 15:
							case 16:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0161:
						num = 13;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_015c:
						num = 12;
						goto IL_0161;
						IL_00ae:
						num = 7;
						goto IL_00b2;
						IL_00fa:
						num = 9;
						ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), ImageList1.Images.Count - 1);
						goto IL_0134;
						IL_0015:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_001e;
						IL_001e:
						num = 3;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_003f;
						}
						goto IL_015c;
						IL_003f:
						num = 4;
						ListView1.Clear();
						goto IL_004e;
						IL_004e:
						num = 5;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_00b2;
						IL_00b2:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_0075;
						}
						enumerator?.Dispose();
						goto IL_00d3;
						IL_0134:
						num = 10;
						goto IL_0139;
						IL_0075:
						num = 6;
						ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), ImageList1.Images.Count - 2);
						goto IL_00ae;
						IL_00d3:
						num = 8;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_0139;
						IL_0139:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_00fa;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 14;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 495;
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

	private void PictureBox12_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						path = Label18.Text;
						goto IL_0015;
					case 495:
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
								goto IL_0015;
							case 3:
								goto IL_001e;
							case 4:
								goto IL_003f;
							case 5:
								goto IL_004e;
							case 6:
								goto IL_0075;
							case 7:
								goto IL_00ae;
							case 8:
								goto IL_00d3;
							case 9:
								goto IL_00fa;
							case 10:
								goto IL_0134;
							case 12:
								goto IL_015c;
							case 13:
								goto IL_0161;
							case 14:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 11:
							case 15:
							case 16:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0161:
						num = 13;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_015c:
						num = 12;
						goto IL_0161;
						IL_00ae:
						num = 7;
						goto IL_00b2;
						IL_00fa:
						num = 9;
						ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), ImageList1.Images.Count - 1);
						goto IL_0134;
						IL_0015:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_001e;
						IL_001e:
						num = 3;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_003f;
						}
						goto IL_015c;
						IL_003f:
						num = 4;
						ListView1.Clear();
						goto IL_004e;
						IL_004e:
						num = 5;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_00b2;
						IL_00b2:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_0075;
						}
						enumerator?.Dispose();
						goto IL_00d3;
						IL_0134:
						num = 10;
						goto IL_0139;
						IL_0075:
						num = 6;
						ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), ImageList1.Images.Count - 2);
						goto IL_00ae;
						IL_00d3:
						num = 8;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_0139;
						IL_0139:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_00fa;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 14;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 495;
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

	private void PictureBox17_Click(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		string current2 = default(string);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						path = Label19.Text;
						goto IL_0015;
					case 495:
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
								goto IL_0015;
							case 3:
								goto IL_001e;
							case 4:
								goto IL_003f;
							case 5:
								goto IL_004e;
							case 6:
								goto IL_0075;
							case 7:
								goto IL_00ae;
							case 8:
								goto IL_00d3;
							case 9:
								goto IL_00fa;
							case 10:
								goto IL_0134;
							case 12:
								goto IL_015c;
							case 13:
								goto IL_0161;
							case 14:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 11:
							case 15:
							case 16:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0161:
						num = 13;
						((Control)MyProject.Forms.dialog).Show();
						break;
						IL_015c:
						num = 12;
						goto IL_0161;
						IL_00ae:
						num = 7;
						goto IL_00b2;
						IL_00fa:
						num = 9;
						ListView1.Items.Add(current.Substring(current.LastIndexOf("\\") + 1), ImageList1.Images.Count - 1);
						goto IL_0134;
						IL_0015:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_001e;
						IL_001e:
						num = 3;
						if (((ServerComputer)MyProject.Computer).FileSystem.DirectoryExists(path))
						{
							goto IL_003f;
						}
						goto IL_015c;
						IL_003f:
						num = 4;
						ListView1.Clear();
						goto IL_004e;
						IL_004e:
						num = 5;
						enumerator = ((ServerComputer)MyProject.Computer).FileSystem.GetDirectories(path).GetEnumerator();
						goto IL_00b2;
						IL_00b2:
						if (enumerator.MoveNext())
						{
							current2 = enumerator.Current;
							goto IL_0075;
						}
						enumerator?.Dispose();
						goto IL_00d3;
						IL_0134:
						num = 10;
						goto IL_0139;
						IL_0075:
						num = 6;
						ListView1.Items.Add(current2.Substring(current2.LastIndexOf("\\") + 1), ImageList1.Images.Count - 2);
						goto IL_00ae;
						IL_00d3:
						num = 8;
						enumerator2 = ((ServerComputer)MyProject.Computer).FileSystem.GetFiles(path).GetEnumerator();
						goto IL_0139;
						IL_0139:
						if (enumerator2.MoveNext())
						{
							current = enumerator2.Current;
							goto IL_00fa;
						}
						enumerator2?.Dispose();
						goto end_IL_0001_3;
						end_IL_0001_2:
						break;
					}
					num = 14;
					MyProject.Forms.dialog.Label1.Text = "Not found.";
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 495;
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

	private void PictureBox1_Click(object sender, EventArgs e)
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

	private void Label18_Click(object sender, EventArgs e)
	{
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		Label15.Text = MyProject.Forms.datacontrolroom.main.Text + " Drive";
	}

	private void Label15_Click(object sender, EventArgs e)
	{
	}
}
