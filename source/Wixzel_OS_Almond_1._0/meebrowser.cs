using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class meebrowser : Form
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

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("PictureBox13")]
	private PictureBox _PictureBox13;

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

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

	[AccessedThroughProperty("PictureBox6")]
	private PictureBox _PictureBox6;

	[AccessedThroughProperty("PictureBox5")]
	private PictureBox _PictureBox5;

	[AccessedThroughProperty("PictureBox4")]
	private PictureBox _PictureBox4;

	[AccessedThroughProperty("Panel2")]
	private Panel _Panel2;

	[AccessedThroughProperty("WebBrowser1")]
	private WebBrowser _WebBrowser1;

	[AccessedThroughProperty("PictureBox23")]
	private PictureBox _PictureBox23;

	[AccessedThroughProperty("PictureBox22")]
	private PictureBox _PictureBox22;

	[AccessedThroughProperty("PictureBox21")]
	private PictureBox _PictureBox21;

	[AccessedThroughProperty("PictureBox20")]
	private PictureBox _PictureBox20;

	[AccessedThroughProperty("PictureBox19")]
	private PictureBox _PictureBox19;

	[AccessedThroughProperty("tab5")]
	private PictureBox _tab5;

	[AccessedThroughProperty("tab4")]
	private PictureBox _tab4;

	[AccessedThroughProperty("tab3")]
	private PictureBox _tab3;

	[AccessedThroughProperty("tab2")]
	private PictureBox _tab2;

	[AccessedThroughProperty("tab1")]
	private PictureBox _tab1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("ico5")]
	private PictureBox _ico5;

	[AccessedThroughProperty("ico4")]
	private PictureBox _ico4;

	[AccessedThroughProperty("ico3")]
	private PictureBox _ico3;

	[AccessedThroughProperty("ico2")]
	private PictureBox _ico2;

	[AccessedThroughProperty("ico1")]
	private PictureBox _ico1;

	[AccessedThroughProperty("urlhost")]
	private Timer _urlhost;

	[AccessedThroughProperty("urladdress")]
	private Timer _urladdress;

	[AccessedThroughProperty("downfavicon")]
	private Timer _downfavicon;

	[AccessedThroughProperty("t5")]
	private Label _t5;

	[AccessedThroughProperty("t4")]
	private Label _t4;

	[AccessedThroughProperty("t3")]
	private Label _t3;

	[AccessedThroughProperty("t2")]
	private Label _t2;

	[AccessedThroughProperty("t1")]
	private Label _t1;

	[AccessedThroughProperty("WebBrowser2")]
	private WebBrowser _WebBrowser2;

	[AccessedThroughProperty("WebBrowser3")]
	private WebBrowser _WebBrowser3;

	[AccessedThroughProperty("WebBrowser4")]
	private WebBrowser _WebBrowser4;

	[AccessedThroughProperty("WebBrowser5")]
	private WebBrowser _WebBrowser5;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox14")]
	private PictureBox _PictureBox14;

	private Point mouse_move;

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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			MouseEventHandler val = new MouseEventHandler(PictureBox3_MouseMove);
			EventHandler eventHandler = PictureBox3_MouseLeave;
			MouseEventHandler val2 = new MouseEventHandler(PictureBox3_MouseDown);
			EventHandler eventHandler2 = PictureBox3_Click;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).MouseMove -= val;
				((Control)_PictureBox3).MouseLeave -= eventHandler;
				((Control)_PictureBox3).MouseDown -= val2;
				((Control)_PictureBox3).Click -= eventHandler2;
			}
			_PictureBox3 = value;
			if (_PictureBox3 != null)
			{
				((Control)_PictureBox3).MouseMove += val;
				((Control)_PictureBox3).MouseLeave += eventHandler;
				((Control)_PictureBox3).MouseDown += val2;
				((Control)_PictureBox3).Click += eventHandler2;
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
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			EventHandler eventHandler = PictureBox1_Click;
			MouseEventHandler val = new MouseEventHandler(PictureBox1_MouseMove);
			MouseEventHandler val2 = new MouseEventHandler(PictureBox1_MouseDown);
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click -= eventHandler;
				((Control)_PictureBox1).MouseMove -= val;
				((Control)_PictureBox1).MouseDown -= val2;
			}
			_PictureBox1 = value;
			if (_PictureBox1 != null)
			{
				((Control)_PictureBox1).Click += eventHandler;
				((Control)_PictureBox1).MouseMove += val;
				((Control)_PictureBox1).MouseDown += val2;
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
			_Panel1 = value;
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
			EventHandler eventHandler = TextBox1_Click;
			EventHandler eventHandler2 = TextBox1_TextChanged;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).KeyPress -= val;
				((TextBoxBase)_TextBox1).Click -= eventHandler;
				((Control)_TextBox1).TextChanged -= eventHandler2;
			}
			_TextBox1 = value;
			if (_TextBox1 != null)
			{
				((Control)_TextBox1).KeyPress += val;
				((TextBoxBase)_TextBox1).Click += eventHandler;
				((Control)_TextBox1).TextChanged += eventHandler2;
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
			EventHandler eventHandler = PictureBox9_Click;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click -= eventHandler;
			}
			_PictureBox9 = value;
			if (_PictureBox9 != null)
			{
				((Control)_PictureBox9).Click += eventHandler;
			}
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
			_PictureBox6 = value;
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

	internal virtual WebBrowser WebBrowser1
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			WebBrowserNavigatedEventHandler val = new WebBrowserNavigatedEventHandler(WebBrowser1_Navigated);
			WebBrowserDocumentCompletedEventHandler val2 = new WebBrowserDocumentCompletedEventHandler(WebBrowser1_DocumentCompleted);
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.Navigated -= val;
				_WebBrowser1.DocumentCompleted -= val2;
			}
			_WebBrowser1 = value;
			if (_WebBrowser1 != null)
			{
				_WebBrowser1.Navigated += val;
				_WebBrowser1.DocumentCompleted += val2;
			}
		}
	}

	internal virtual PictureBox PictureBox23
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox23 = value;
		}
	}

	internal virtual PictureBox PictureBox22
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox22 = value;
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

	internal virtual PictureBox tab5
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab5 = value;
		}
	}

	internal virtual PictureBox tab4
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab4 = value;
		}
	}

	internal virtual PictureBox tab3
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab3 = value;
		}
	}

	internal virtual PictureBox tab2
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab2 = value;
		}
	}

	internal virtual PictureBox tab1
	{
		[DebuggerNonUserCode]
		get
		{
			return _tab1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tab1 = value;
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

	internal virtual PictureBox ico5
	{
		[DebuggerNonUserCode]
		get
		{
			return _ico5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ico5 = value;
		}
	}

	internal virtual PictureBox ico4
	{
		[DebuggerNonUserCode]
		get
		{
			return _ico4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ico4 = value;
		}
	}

	internal virtual PictureBox ico3
	{
		[DebuggerNonUserCode]
		get
		{
			return _ico3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ico3 = value;
		}
	}

	internal virtual PictureBox ico2
	{
		[DebuggerNonUserCode]
		get
		{
			return _ico2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ico2 = value;
		}
	}

	internal virtual PictureBox ico1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ico1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ico1 = value;
		}
	}

	internal virtual Timer urlhost
	{
		[DebuggerNonUserCode]
		get
		{
			return _urlhost;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = urlhost_Tick;
			if (_urlhost != null)
			{
				_urlhost.Tick -= eventHandler;
			}
			_urlhost = value;
			if (_urlhost != null)
			{
				_urlhost.Tick += eventHandler;
			}
		}
	}

	internal virtual Timer urladdress
	{
		[DebuggerNonUserCode]
		get
		{
			return _urladdress;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = urladdress_Tick;
			if (_urladdress != null)
			{
				_urladdress.Tick -= eventHandler;
			}
			_urladdress = value;
			if (_urladdress != null)
			{
				_urladdress.Tick += eventHandler;
			}
		}
	}

	internal virtual Timer downfavicon
	{
		[DebuggerNonUserCode]
		get
		{
			return _downfavicon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_downfavicon = value;
		}
	}

	internal virtual Label t5
	{
		[DebuggerNonUserCode]
		get
		{
			return _t5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_t5 = value;
		}
	}

	internal virtual Label t4
	{
		[DebuggerNonUserCode]
		get
		{
			return _t4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_t4 = value;
		}
	}

	internal virtual Label t3
	{
		[DebuggerNonUserCode]
		get
		{
			return _t3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_t3 = value;
		}
	}

	internal virtual Label t2
	{
		[DebuggerNonUserCode]
		get
		{
			return _t2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_t2 = value;
		}
	}

	internal virtual Label t1
	{
		[DebuggerNonUserCode]
		get
		{
			return _t1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_t1 = value;
		}
	}

	internal virtual WebBrowser WebBrowser2
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser2 = value;
		}
	}

	internal virtual WebBrowser WebBrowser3
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser3 = value;
		}
	}

	internal virtual WebBrowser WebBrowser4
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_WebBrowser4 = value;
		}
	}

	internal virtual WebBrowser WebBrowser5
	{
		[DebuggerNonUserCode]
		get
		{
			return _WebBrowser5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			WebBrowserDocumentCompletedEventHandler val = new WebBrowserDocumentCompletedEventHandler(WebBrowser5_DocumentCompleted);
			if (_WebBrowser5 != null)
			{
				_WebBrowser5.DocumentCompleted -= val;
			}
			_WebBrowser5 = value;
			if (_WebBrowser5 != null)
			{
				_WebBrowser5.DocumentCompleted += val;
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

	[DebuggerNonUserCode]
	public meebrowser()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(meebrowser_FormClosing);
		((Form)this).Load += meebrowser_Load;
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
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ea: Expected O, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0600: Expected O, but got Unknown
		//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fa: Expected O, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_0910: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b5: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0c18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected O, but got Unknown
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Expected O, but got Unknown
		//IL_0d53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5d: Expected O, but got Unknown
		//IL_0deb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected O, but got Unknown
		//IL_10c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Expected O, but got Unknown
		//IL_1164: Unknown result type (might be due to invalid IL or missing references)
		//IL_116e: Expected O, but got Unknown
		//IL_1206: Unknown result type (might be due to invalid IL or missing references)
		//IL_1210: Expected O, but got Unknown
		//IL_12a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b2: Expected O, but got Unknown
		//IL_134a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1354: Expected O, but got Unknown
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_1661: Expected O, but got Unknown
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected O, but got Unknown
		//IL_178d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1797: Expected O, but got Unknown
		//IL_1828: Unknown result type (might be due to invalid IL or missing references)
		//IL_1832: Expected O, but got Unknown
		//IL_18c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cd: Expected O, but got Unknown
		//IL_195e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1968: Expected O, but got Unknown
		//IL_19fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a06: Expected O, but got Unknown
		//IL_1a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aa4: Expected O, but got Unknown
		//IL_1b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b42: Expected O, but got Unknown
		//IL_1bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be0: Expected O, but got Unknown
		//IL_1d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0a: Expected O, but got Unknown
		//IL_1fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1feb: Expected O, but got Unknown
		//IL_2089: Unknown result type (might be due to invalid IL or missing references)
		//IL_2093: Expected O, but got Unknown
		//IL_2131: Unknown result type (might be due to invalid IL or missing references)
		//IL_213b: Expected O, but got Unknown
		//IL_21c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d2: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(meebrowser));
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Panel1 = new Panel();
		TextBox1 = new TextBox();
		PictureBox13 = new PictureBox();
		PictureBox12 = new PictureBox();
		PictureBox11 = new PictureBox();
		PictureBox10 = new PictureBox();
		PictureBox9 = new PictureBox();
		PictureBox8 = new PictureBox();
		PictureBox7 = new PictureBox();
		PictureBox6 = new PictureBox();
		PictureBox5 = new PictureBox();
		PictureBox4 = new PictureBox();
		Panel2 = new Panel();
		t5 = new Label();
		t4 = new Label();
		t3 = new Label();
		t2 = new Label();
		t1 = new Label();
		ico5 = new PictureBox();
		ico4 = new PictureBox();
		ico3 = new PictureBox();
		ico2 = new PictureBox();
		ico1 = new PictureBox();
		PictureBox23 = new PictureBox();
		PictureBox22 = new PictureBox();
		PictureBox21 = new PictureBox();
		PictureBox20 = new PictureBox();
		PictureBox19 = new PictureBox();
		tab5 = new PictureBox();
		tab4 = new PictureBox();
		tab3 = new PictureBox();
		tab2 = new PictureBox();
		tab1 = new PictureBox();
		WebBrowser1 = new WebBrowser();
		Label2 = new Label();
		urlhost = new Timer(components);
		urladdress = new Timer(components);
		downfavicon = new Timer(components);
		WebBrowser2 = new WebBrowser();
		WebBrowser3 = new WebBrowser();
		WebBrowser4 = new WebBrowser();
		WebBrowser5 = new WebBrowser();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox14 = new PictureBox();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)PictureBox13).BeginInit();
		((ISupportInitialize)PictureBox12).BeginInit();
		((ISupportInitialize)PictureBox11).BeginInit();
		((ISupportInitialize)PictureBox10).BeginInit();
		((ISupportInitialize)PictureBox9).BeginInit();
		((ISupportInitialize)PictureBox8).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((ISupportInitialize)PictureBox6).BeginInit();
		((ISupportInitialize)PictureBox5).BeginInit();
		((ISupportInitialize)PictureBox4).BeginInit();
		((Control)Panel2).SuspendLayout();
		((ISupportInitialize)ico5).BeginInit();
		((ISupportInitialize)ico4).BeginInit();
		((ISupportInitialize)ico3).BeginInit();
		((ISupportInitialize)ico2).BeginInit();
		((ISupportInitialize)ico1).BeginInit();
		((ISupportInitialize)PictureBox23).BeginInit();
		((ISupportInitialize)PictureBox22).BeginInit();
		((ISupportInitialize)PictureBox21).BeginInit();
		((ISupportInitialize)PictureBox20).BeginInit();
		((ISupportInitialize)PictureBox19).BeginInit();
		((ISupportInitialize)tab5).BeginInit();
		((ISupportInitialize)tab4).BeginInit();
		((ISupportInitialize)tab3).BeginInit();
		((ISupportInitialize)tab2).BeginInit();
		((ISupportInitialize)tab1).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox14).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		Point location = new Point(1309, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		Size size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 12;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(37, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(99, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 11;
		Label1.Text = "Mee Browser";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(9, 6);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(22, 22);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 10;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox5 = PictureBox1;
		location = new Point(-1, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox6 = PictureBox1;
		size = new Size(1368, 35);
		((Control)pictureBox6).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)1;
		PictureBox1.TabIndex = 9;
		PictureBox1.TabStop = false;
		((Control)Panel1).BackColor = Color.White;
		((Control)Panel1).Controls.Add((Control)(object)TextBox1);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox13);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox12);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox11);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox10);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox9);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox8);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox7);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox6);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox5);
		((Control)Panel1).Controls.Add((Control)(object)PictureBox4);
		Panel panel = Panel1;
		location = new Point(0, 33);
		((Control)panel).Location = location;
		((Control)Panel1).Name = "Panel1";
		Panel panel2 = Panel1;
		size = new Size(1360, 60);
		((Control)panel2).Size = size;
		((Control)Panel1).TabIndex = 13;
		((TextBoxBase)TextBox1).BorderStyle = (BorderStyle)0;
		((Control)TextBox1).Font = new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		TextBox textBox = TextBox1;
		location = new Point(309, 20);
		((Control)textBox).Location = location;
		((Control)TextBox1).Name = "TextBox1";
		TextBox textBox2 = TextBox1;
		size = new Size(865, 17);
		((Control)textBox2).Size = size;
		((Control)TextBox1).TabIndex = 24;
		((Control)PictureBox13).BackColor = Color.White;
		PictureBox13.Image = (Image)componentResourceManager.GetObject("PictureBox13.Image");
		PictureBox pictureBox7 = PictureBox13;
		location = new Point(224, 6);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox13).Name = "PictureBox13";
		PictureBox pictureBox8 = PictureBox13;
		size = new Size(48, 48);
		((Control)pictureBox8).Size = size;
		PictureBox13.SizeMode = (PictureBoxSizeMode)2;
		PictureBox13.TabIndex = 23;
		PictureBox13.TabStop = false;
		((Control)PictureBox12).BackColor = Color.White;
		PictureBox12.Image = (Image)componentResourceManager.GetObject("PictureBox12.Image");
		PictureBox pictureBox9 = PictureBox12;
		location = new Point(170, 6);
		((Control)pictureBox9).Location = location;
		((Control)PictureBox12).Name = "PictureBox12";
		PictureBox pictureBox10 = PictureBox12;
		size = new Size(48, 48);
		((Control)pictureBox10).Size = size;
		PictureBox12.SizeMode = (PictureBoxSizeMode)2;
		PictureBox12.TabIndex = 22;
		PictureBox12.TabStop = false;
		((Control)PictureBox11).BackColor = Color.White;
		PictureBox11.Image = (Image)componentResourceManager.GetObject("PictureBox11.Image");
		PictureBox pictureBox11 = PictureBox11;
		location = new Point(1255, 6);
		((Control)pictureBox11).Location = location;
		((Control)PictureBox11).Name = "PictureBox11";
		PictureBox pictureBox12 = PictureBox11;
		size = new Size(48, 48);
		((Control)pictureBox12).Size = size;
		PictureBox11.SizeMode = (PictureBoxSizeMode)2;
		PictureBox11.TabIndex = 21;
		PictureBox11.TabStop = false;
		((Control)PictureBox10).BackColor = Color.White;
		PictureBox10.Image = (Image)componentResourceManager.GetObject("PictureBox10.Image");
		PictureBox pictureBox13 = PictureBox10;
		location = new Point(1309, 5);
		((Control)pictureBox13).Location = location;
		((Control)PictureBox10).Name = "PictureBox10";
		PictureBox pictureBox14 = PictureBox10;
		size = new Size(50, 50);
		((Control)pictureBox14).Size = size;
		PictureBox10.SizeMode = (PictureBoxSizeMode)2;
		PictureBox10.TabIndex = 20;
		PictureBox10.TabStop = false;
		((Control)PictureBox9).BackColor = Color.White;
		PictureBox9.Image = (Image)componentResourceManager.GetObject("PictureBox9.Image");
		PictureBox pictureBox15 = PictureBox9;
		location = new Point(1201, 6);
		((Control)pictureBox15).Location = location;
		((Control)PictureBox9).Name = "PictureBox9";
		PictureBox pictureBox16 = PictureBox9;
		size = new Size(48, 48);
		((Control)pictureBox16).Size = size;
		PictureBox9.SizeMode = (PictureBoxSizeMode)2;
		PictureBox9.TabIndex = 19;
		PictureBox9.TabStop = false;
		((Control)PictureBox8).BackColor = Color.White;
		PictureBox8.Image = (Image)componentResourceManager.GetObject("PictureBox8.Image");
		PictureBox pictureBox17 = PictureBox8;
		location = new Point(1133, 13);
		((Control)pictureBox17).Location = location;
		((Control)PictureBox8).Name = "PictureBox8";
		PictureBox pictureBox18 = PictureBox8;
		size = new Size(51, 34);
		((Control)pictureBox18).Size = size;
		PictureBox8.SizeMode = (PictureBoxSizeMode)2;
		PictureBox8.TabIndex = 18;
		PictureBox8.TabStop = false;
		((Control)PictureBox7).BackColor = Color.White;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox19 = PictureBox7;
		location = new Point(348, 13);
		((Control)pictureBox19).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox20 = PictureBox7;
		size = new Size(799, 34);
		((Control)pictureBox20).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)1;
		PictureBox7.TabIndex = 17;
		PictureBox7.TabStop = false;
		((Control)PictureBox6).BackColor = Color.White;
		PictureBox6.Image = (Image)componentResourceManager.GetObject("PictureBox6.Image");
		PictureBox pictureBox21 = PictureBox6;
		location = new Point(301, 13);
		((Control)pictureBox21).Location = location;
		((Control)PictureBox6).Name = "PictureBox6";
		PictureBox pictureBox22 = PictureBox6;
		size = new Size(51, 34);
		((Control)pictureBox22).Size = size;
		PictureBox6.SizeMode = (PictureBoxSizeMode)2;
		PictureBox6.TabIndex = 16;
		PictureBox6.TabStop = false;
		((Control)PictureBox5).BackColor = Color.White;
		PictureBox5.Image = (Image)componentResourceManager.GetObject("PictureBox5.Image");
		PictureBox pictureBox23 = PictureBox5;
		location = new Point(76, 0);
		((Control)pictureBox23).Location = location;
		((Control)PictureBox5).Name = "PictureBox5";
		PictureBox pictureBox24 = PictureBox5;
		size = new Size(60, 60);
		((Control)pictureBox24).Size = size;
		PictureBox5.SizeMode = (PictureBoxSizeMode)2;
		PictureBox5.TabIndex = 15;
		PictureBox5.TabStop = false;
		((Control)PictureBox4).BackColor = Color.White;
		PictureBox4.Image = (Image)componentResourceManager.GetObject("PictureBox4.Image");
		PictureBox pictureBox25 = PictureBox4;
		location = new Point(3, 0);
		((Control)pictureBox25).Location = location;
		((Control)PictureBox4).Name = "PictureBox4";
		PictureBox pictureBox26 = PictureBox4;
		size = new Size(60, 60);
		((Control)pictureBox26).Size = size;
		PictureBox4.SizeMode = (PictureBoxSizeMode)2;
		PictureBox4.TabIndex = 14;
		PictureBox4.TabStop = false;
		((Control)Panel2).BackColor = Color.Gainsboro;
		((Control)Panel2).Controls.Add((Control)(object)t5);
		((Control)Panel2).Controls.Add((Control)(object)t4);
		((Control)Panel2).Controls.Add((Control)(object)t3);
		((Control)Panel2).Controls.Add((Control)(object)t2);
		((Control)Panel2).Controls.Add((Control)(object)t1);
		((Control)Panel2).Controls.Add((Control)(object)ico5);
		((Control)Panel2).Controls.Add((Control)(object)ico4);
		((Control)Panel2).Controls.Add((Control)(object)ico3);
		((Control)Panel2).Controls.Add((Control)(object)ico2);
		((Control)Panel2).Controls.Add((Control)(object)ico1);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox23);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox22);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox21);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox20);
		((Control)Panel2).Controls.Add((Control)(object)PictureBox19);
		((Control)Panel2).Controls.Add((Control)(object)tab5);
		((Control)Panel2).Controls.Add((Control)(object)tab4);
		((Control)Panel2).Controls.Add((Control)(object)tab3);
		((Control)Panel2).Controls.Add((Control)(object)tab2);
		((Control)Panel2).Controls.Add((Control)(object)tab1);
		Panel panel3 = Panel2;
		location = new Point(0, 93);
		((Control)panel3).Location = location;
		((Control)Panel2).Name = "Panel2";
		Panel panel4 = Panel2;
		size = new Size(1360, 39);
		((Control)panel4).Size = size;
		((Control)Panel2).TabIndex = 14;
		t5.AutoSize = true;
		((Control)t5).BackColor = Color.White;
		((Control)t5).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj = t5;
		location = new Point(985, 11);
		((Control)obj).Location = location;
		((Control)t5).Name = "t5";
		Label obj2 = t5;
		size = new Size(24, 20);
		((Control)obj2).Size = size;
		((Control)t5).TabIndex = 38;
		t5.Text = "...";
		t4.AutoSize = true;
		((Control)t4).BackColor = Color.White;
		((Control)t4).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj3 = t4;
		location = new Point(748, 11);
		((Control)obj3).Location = location;
		((Control)t4).Name = "t4";
		Label obj4 = t4;
		size = new Size(24, 20);
		((Control)obj4).Size = size;
		((Control)t4).TabIndex = 37;
		t4.Text = "...";
		t3.AutoSize = true;
		((Control)t3).BackColor = Color.White;
		((Control)t3).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj5 = t3;
		location = new Point(514, 11);
		((Control)obj5).Location = location;
		((Control)t3).Name = "t3";
		Label obj6 = t3;
		size = new Size(24, 20);
		((Control)obj6).Size = size;
		((Control)t3).TabIndex = 36;
		t3.Text = "...";
		t2.AutoSize = true;
		((Control)t2).BackColor = Color.White;
		((Control)t2).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj7 = t2;
		location = new Point(278, 11);
		((Control)obj7).Location = location;
		((Control)t2).Name = "t2";
		Label obj8 = t2;
		size = new Size(24, 20);
		((Control)obj8).Size = size;
		((Control)t2).TabIndex = 35;
		t2.Text = "...";
		t1.AutoSize = true;
		((Control)t1).BackColor = Color.White;
		((Control)t1).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label obj9 = t1;
		location = new Point(37, 11);
		((Control)obj9).Location = location;
		((Control)t1).Name = "t1";
		Label obj10 = t1;
		size = new Size(24, 20);
		((Control)obj10).Size = size;
		((Control)t1).TabIndex = 30;
		t1.Text = "...";
		((Control)ico5).BackColor = Color.White;
		PictureBox obj11 = ico5;
		location = new Point(957, 9);
		((Control)obj11).Location = location;
		((Control)ico5).Name = "ico5";
		PictureBox obj12 = ico5;
		size = new Size(22, 22);
		((Control)obj12).Size = size;
		ico5.SizeMode = (PictureBoxSizeMode)1;
		ico5.TabIndex = 34;
		ico5.TabStop = false;
		((Control)ico4).BackColor = Color.White;
		PictureBox obj13 = ico4;
		location = new Point(720, 9);
		((Control)obj13).Location = location;
		((Control)ico4).Name = "ico4";
		PictureBox obj14 = ico4;
		size = new Size(22, 22);
		((Control)obj14).Size = size;
		ico4.SizeMode = (PictureBoxSizeMode)1;
		ico4.TabIndex = 33;
		ico4.TabStop = false;
		((Control)ico3).BackColor = Color.White;
		PictureBox obj15 = ico3;
		location = new Point(486, 9);
		((Control)obj15).Location = location;
		((Control)ico3).Name = "ico3";
		PictureBox obj16 = ico3;
		size = new Size(22, 22);
		((Control)obj16).Size = size;
		ico3.SizeMode = (PictureBoxSizeMode)1;
		ico3.TabIndex = 32;
		ico3.TabStop = false;
		((Control)ico2).BackColor = Color.White;
		PictureBox obj17 = ico2;
		location = new Point(250, 9);
		((Control)obj17).Location = location;
		((Control)ico2).Name = "ico2";
		PictureBox obj18 = ico2;
		size = new Size(22, 22);
		((Control)obj18).Size = size;
		ico2.SizeMode = (PictureBoxSizeMode)1;
		ico2.TabIndex = 31;
		ico2.TabStop = false;
		((Control)ico1).BackColor = Color.White;
		PictureBox obj19 = ico1;
		location = new Point(9, 9);
		((Control)obj19).Location = location;
		((Control)ico1).Name = "ico1";
		PictureBox obj20 = ico1;
		size = new Size(22, 22);
		((Control)obj20).Size = size;
		ico1.SizeMode = (PictureBoxSizeMode)1;
		ico1.TabIndex = 30;
		ico1.TabStop = false;
		((Control)PictureBox23).BackColor = Color.White;
		PictureBox23.Image = (Image)componentResourceManager.GetObject("PictureBox23.Image");
		PictureBox pictureBox27 = PictureBox23;
		location = new Point(1143, 7);
		((Control)pictureBox27).Location = location;
		((Control)PictureBox23).Name = "PictureBox23";
		PictureBox pictureBox28 = PictureBox23;
		size = new Size(24, 24);
		((Control)pictureBox28).Size = size;
		PictureBox23.SizeMode = (PictureBoxSizeMode)2;
		PictureBox23.TabIndex = 24;
		PictureBox23.TabStop = false;
		((Control)PictureBox22).BackColor = Color.White;
		PictureBox22.Image = (Image)componentResourceManager.GetObject("PictureBox22.Image");
		PictureBox pictureBox29 = PictureBox22;
		location = new Point(905, 7);
		((Control)pictureBox29).Location = location;
		((Control)PictureBox22).Name = "PictureBox22";
		PictureBox pictureBox30 = PictureBox22;
		size = new Size(24, 24);
		((Control)pictureBox30).Size = size;
		PictureBox22.SizeMode = (PictureBoxSizeMode)2;
		PictureBox22.TabIndex = 23;
		PictureBox22.TabStop = false;
		((Control)PictureBox21).BackColor = Color.White;
		PictureBox21.Image = (Image)componentResourceManager.GetObject("PictureBox21.Image");
		PictureBox pictureBox31 = PictureBox21;
		location = new Point(668, 7);
		((Control)pictureBox31).Location = location;
		((Control)PictureBox21).Name = "PictureBox21";
		PictureBox pictureBox32 = PictureBox21;
		size = new Size(24, 24);
		((Control)pictureBox32).Size = size;
		PictureBox21.SizeMode = (PictureBoxSizeMode)2;
		PictureBox21.TabIndex = 22;
		PictureBox21.TabStop = false;
		((Control)PictureBox20).BackColor = Color.White;
		PictureBox20.Image = (Image)componentResourceManager.GetObject("PictureBox20.Image");
		PictureBox pictureBox33 = PictureBox20;
		location = new Point(433, 7);
		((Control)pictureBox33).Location = location;
		((Control)PictureBox20).Name = "PictureBox20";
		PictureBox pictureBox34 = PictureBox20;
		size = new Size(24, 24);
		((Control)pictureBox34).Size = size;
		PictureBox20.SizeMode = (PictureBoxSizeMode)2;
		PictureBox20.TabIndex = 21;
		PictureBox20.TabStop = false;
		((Control)PictureBox19).BackColor = Color.White;
		PictureBox19.Image = (Image)componentResourceManager.GetObject("PictureBox19.Image");
		PictureBox pictureBox35 = PictureBox19;
		location = new Point(196, 7);
		((Control)pictureBox35).Location = location;
		((Control)PictureBox19).Name = "PictureBox19";
		PictureBox pictureBox36 = PictureBox19;
		size = new Size(24, 24);
		((Control)pictureBox36).Size = size;
		PictureBox19.SizeMode = (PictureBoxSizeMode)2;
		PictureBox19.TabIndex = 16;
		PictureBox19.TabStop = false;
		((Control)tab5).BackColor = Color.White;
		tab5.Image = (Image)componentResourceManager.GetObject("tab5.Image");
		PictureBox obj21 = tab5;
		location = new Point(944, 0);
		((Control)obj21).Location = location;
		((Control)tab5).Name = "tab5";
		PictureBox obj22 = tab5;
		size = new Size(230, 38);
		((Control)obj22).Size = size;
		tab5.SizeMode = (PictureBoxSizeMode)2;
		tab5.TabIndex = 20;
		tab5.TabStop = false;
		((Control)tab4).BackColor = Color.White;
		tab4.Image = (Image)componentResourceManager.GetObject("tab4.Image");
		PictureBox obj23 = tab4;
		location = new Point(708, 0);
		((Control)obj23).Location = location;
		((Control)tab4).Name = "tab4";
		PictureBox obj24 = tab4;
		size = new Size(230, 38);
		((Control)obj24).Size = size;
		tab4.SizeMode = (PictureBoxSizeMode)2;
		tab4.TabIndex = 19;
		tab4.TabStop = false;
		((Control)tab3).BackColor = Color.White;
		tab3.Image = (Image)componentResourceManager.GetObject("tab3.Image");
		PictureBox obj25 = tab3;
		location = new Point(472, 0);
		((Control)obj25).Location = location;
		((Control)tab3).Name = "tab3";
		PictureBox obj26 = tab3;
		size = new Size(230, 38);
		((Control)obj26).Size = size;
		tab3.SizeMode = (PictureBoxSizeMode)2;
		tab3.TabIndex = 18;
		tab3.TabStop = false;
		((Control)tab2).BackColor = Color.White;
		tab2.Image = (Image)componentResourceManager.GetObject("tab2.Image");
		PictureBox obj27 = tab2;
		location = new Point(236, 0);
		((Control)obj27).Location = location;
		((Control)tab2).Name = "tab2";
		PictureBox obj28 = tab2;
		size = new Size(230, 38);
		((Control)obj28).Size = size;
		tab2.SizeMode = (PictureBoxSizeMode)2;
		tab2.TabIndex = 17;
		tab2.TabStop = false;
		((Control)tab1).BackColor = Color.White;
		tab1.Image = (Image)componentResourceManager.GetObject("tab1.Image");
		PictureBox obj29 = tab1;
		location = new Point(0, 0);
		((Control)obj29).Location = location;
		((Control)tab1).Name = "tab1";
		PictureBox obj30 = tab1;
		size = new Size(230, 38);
		((Control)obj30).Size = size;
		tab1.SizeMode = (PictureBoxSizeMode)2;
		tab1.TabIndex = 16;
		tab1.TabStop = false;
		WebBrowser webBrowser = WebBrowser1;
		location = new Point(0, 131);
		((Control)webBrowser).Location = location;
		WebBrowser webBrowser2 = WebBrowser1;
		size = new Size(20, 20);
		((Control)webBrowser2).MinimumSize = size;
		((Control)WebBrowser1).Name = "WebBrowser1";
		WebBrowser1.ScriptErrorsSuppressed = true;
		WebBrowser webBrowser3 = WebBrowser1;
		size = new Size(1360, 590);
		((Control)webBrowser3).Size = size;
		((Control)WebBrowser1).TabIndex = 15;
		((Control)Label2).Anchor = (AnchorStyles)3;
		((Control)Label2).BackColor = Color.White;
		((Control)Label2).Font = new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.FromArgb(64, 64, 64);
		Label label3 = Label2;
		location = new Point(460, 5);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(466, 24);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 29;
		Label2.Text = "...";
		Label2.TextAlign = (ContentAlignment)32;
		urlhost.Interval = 5000;
		downfavicon.Interval = 500;
		WebBrowser webBrowser4 = WebBrowser2;
		location = new Point(0, 131);
		((Control)webBrowser4).Location = location;
		WebBrowser webBrowser5 = WebBrowser2;
		size = new Size(20, 20);
		((Control)webBrowser5).MinimumSize = size;
		((Control)WebBrowser2).Name = "WebBrowser2";
		WebBrowser2.ScriptErrorsSuppressed = true;
		WebBrowser webBrowser6 = WebBrowser2;
		size = new Size(1360, 590);
		((Control)webBrowser6).Size = size;
		((Control)WebBrowser2).TabIndex = 30;
		WebBrowser webBrowser7 = WebBrowser3;
		location = new Point(-1, 131);
		((Control)webBrowser7).Location = location;
		WebBrowser webBrowser8 = WebBrowser3;
		size = new Size(20, 20);
		((Control)webBrowser8).MinimumSize = size;
		((Control)WebBrowser3).Name = "WebBrowser3";
		WebBrowser3.ScriptErrorsSuppressed = true;
		WebBrowser webBrowser9 = WebBrowser3;
		size = new Size(1360, 590);
		((Control)webBrowser9).Size = size;
		((Control)WebBrowser3).TabIndex = 31;
		WebBrowser webBrowser10 = WebBrowser4;
		location = new Point(-1, 131);
		((Control)webBrowser10).Location = location;
		WebBrowser webBrowser11 = WebBrowser4;
		size = new Size(20, 20);
		((Control)webBrowser11).MinimumSize = size;
		((Control)WebBrowser4).Name = "WebBrowser4";
		WebBrowser4.ScriptErrorsSuppressed = true;
		WebBrowser webBrowser12 = WebBrowser4;
		size = new Size(1360, 590);
		((Control)webBrowser12).Size = size;
		((Control)WebBrowser4).TabIndex = 32;
		WebBrowser webBrowser13 = WebBrowser5;
		location = new Point(-2, 131);
		((Control)webBrowser13).Location = location;
		WebBrowser webBrowser14 = WebBrowser5;
		size = new Size(20, 20);
		((Control)webBrowser14).MinimumSize = size;
		((Control)WebBrowser5).Name = "WebBrowser5";
		WebBrowser5.ScriptErrorsSuppressed = true;
		WebBrowser webBrowser15 = WebBrowser5;
		size = new Size(1360, 590);
		((Control)webBrowser15).Size = size;
		((Control)WebBrowser5).TabIndex = 33;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj31 = defaultclose;
		location = new Point(952, 0);
		((Control)obj31).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj32 = defaultclose;
		size = new Size(51, 34);
		((Control)obj32).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj33 = hoverclose;
		location = new Point(1009, 0);
		((Control)obj33).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj34 = hoverclose;
		size = new Size(51, 34);
		((Control)obj34).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj35 = clickclose;
		location = new Point(1066, 0);
		((Control)obj35).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj36 = clickclose;
		size = new Size(51, 34);
		((Control)obj36).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox14.Image = (Image)componentResourceManager.GetObject("PictureBox14.Image");
		PictureBox pictureBox37 = PictureBox14;
		location = new Point(1252, 1);
		((Control)pictureBox37).Location = location;
		((Control)PictureBox14).Name = "PictureBox14";
		PictureBox pictureBox38 = PictureBox14;
		size = new Size(51, 34);
		((Control)pictureBox38).Size = size;
		PictureBox14.SizeMode = (PictureBoxSizeMode)2;
		PictureBox14.TabIndex = 118;
		PictureBox14.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		size = new Size(1360, 723);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox14);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)WebBrowser5);
		((Control)this).Controls.Add((Control)(object)WebBrowser4);
		((Control)this).Controls.Add((Control)(object)WebBrowser3);
		((Control)this).Controls.Add((Control)(object)WebBrowser2);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)WebBrowser1);
		((Control)this).Controls.Add((Control)(object)Panel2);
		((Control)this).Controls.Add((Control)(object)Panel1);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "meebrowser";
		((Form)this).ShowInTaskbar = false;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((ISupportInitialize)PictureBox13).EndInit();
		((ISupportInitialize)PictureBox12).EndInit();
		((ISupportInitialize)PictureBox11).EndInit();
		((ISupportInitialize)PictureBox10).EndInit();
		((ISupportInitialize)PictureBox9).EndInit();
		((ISupportInitialize)PictureBox8).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((ISupportInitialize)PictureBox6).EndInit();
		((ISupportInitialize)PictureBox5).EndInit();
		((ISupportInitialize)PictureBox4).EndInit();
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((ISupportInitialize)ico5).EndInit();
		((ISupportInitialize)ico4).EndInit();
		((ISupportInitialize)ico3).EndInit();
		((ISupportInitialize)ico2).EndInit();
		((ISupportInitialize)ico1).EndInit();
		((ISupportInitialize)PictureBox23).EndInit();
		((ISupportInitialize)PictureBox22).EndInit();
		((ISupportInitialize)PictureBox21).EndInit();
		((ISupportInitialize)PictureBox20).EndInit();
		((ISupportInitialize)PictureBox19).EndInit();
		((ISupportInitialize)tab5).EndInit();
		((ISupportInitialize)tab4).EndInit();
		((ISupportInitialize)tab3).EndInit();
		((ISupportInitialize)tab2).EndInit();
		((ISupportInitialize)tab1).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox14).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void TextBox1_Click(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).SelectAll();
	}

	private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (e.KeyChar == '\r')
		{
			WebBrowser1.Navigate(TextBox1.Text);
			urlhost.Enabled = true;
			urladdress.Enabled = true;
		}
	}

	private void TextBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void urlhost_Tick(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Uri uri = default(Uri);
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
				case 104:
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
							goto IL_001c;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0009:
					num = 2;
					uri = new Uri(TextBox1.Text);
					goto IL_001c;
					IL_001c:
					num = 3;
					Label2.Text = uri.Host;
					break;
					end_IL_0001_2:
					break;
				}
				num = 4;
				downfavicon.Enabled = true;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 104;
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

	private void urladdress_Tick(object sender, EventArgs e)
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
					break;
				case 72:
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
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
							goto end_IL_0001_3;
						}
						goto default;
					}
					end_IL_0001_2:
					break;
				}
				num = 2;
				TextBox1.Text = WebBrowser1.Url.ToString();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 72;
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

	private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
	}

	private void WebBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		Uri url = WebBrowser1.Url;
		if (url.HostNameType == UriHostNameType.Dns)
		{
			string requestUriString = "http://" + url.Host + "/favicon.ico";
			WebRequest webRequest = WebRequest.Create(requestUriString);
			Stream responseStream = default(Stream);
			try
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
				responseStream = httpWebResponse.GetResponseStream();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				foreach (HtmlElement item in WebBrowser1.Document.GetElementsByTagName("link"))
				{
					HtmlElement val = item;
					if (Operators.CompareString(val.GetAttribute("rel").ToUpper(), "SHORTCUT ICON", false) == 0)
					{
						string attribute = val.GetAttribute("href");
						webRequest = WebRequest.Create(WebBrowser1.Url.ToString() + attribute);
						HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
						responseStream = httpWebResponse.GetResponseStream();
						Image image = Image.FromStream(responseStream);
						ico1.Image = image;
						break;
					}
				}
				ProjectData.ClearProjectError();
			}
			if (responseStream != null)
			{
				Image image = Image.FromStream(responseStream);
				ico1.Image = image;
			}
		}
		t1.Text = WebBrowser1.DocumentTitle.ToString();
		urlhost.Enabled = true;
		urladdress.Enabled = true;
	}

	private void PictureBox4_Click(object sender, EventArgs e)
	{
		WebBrowser1.GoBack();
	}

	private void PictureBox5_Click(object sender, EventArgs e)
	{
		WebBrowser1.GoForward();
	}

	private void PictureBox12_Click(object sender, EventArgs e)
	{
		WebBrowser1.Navigate("www.bing.com");
		urlhost.Enabled = true;
		urladdress.Enabled = true;
	}

	private void PictureBox13_Click(object sender, EventArgs e)
	{
		WebBrowser1.Refresh();
	}

	private void PictureBox9_Click(object sender, EventArgs e)
	{
		WebBrowser1.Navigate(TextBox1.Text);
		urlhost.Enabled = true;
		urladdress.Enabled = true;
	}

	private void meebrowser_FormClosing(object sender, FormClosingEventArgs e)
	{
		((Control)WebBrowser1).Width = ((Control)this).Width;
		((Control)WebBrowser2).Width = ((Control)this).Width;
		((Control)WebBrowser3).Width = ((Control)this).Width;
		((Control)WebBrowser4).Width = ((Control)this).Width;
		((Control)WebBrowser5).Width = ((Control)this).Width;
		Fade.meebrowserout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.meeb.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void meebrowser_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = PictureBox3;
		checked
		{
			Point location = new Point(((Control)this).Width - ((Control)PictureBox3).Width, 0);
			((Control)pictureBox).Location = location;
			PictureBox pictureBox2 = PictureBox14;
			Point location2 = new Point(((Control)PictureBox3).Location.X - ((Control)PictureBox14).Width, ((Control)PictureBox3).Location.Y);
			((Control)pictureBox2).Location = location2;
			if (!((Control)MyProject.Forms.home.app1).Enabled)
			{
				((Control)MyProject.Forms.home.app1).Enabled = true;
				MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app2).Enabled)
			{
				((Control)MyProject.Forms.home.app2).Enabled = true;
				MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app3).Enabled)
			{
				((Control)MyProject.Forms.home.app3).Enabled = true;
				MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app4).Enabled)
			{
				((Control)MyProject.Forms.home.app4).Enabled = true;
				MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app5).Enabled)
			{
				((Control)MyProject.Forms.home.app5).Enabled = true;
				MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app6).Enabled)
			{
				((Control)MyProject.Forms.home.app6).Enabled = true;
				MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app7).Enabled)
			{
				((Control)MyProject.Forms.home.app7).Enabled = true;
				MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app8).Enabled)
			{
				((Control)MyProject.Forms.home.app8).Enabled = true;
				MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app9).Enabled)
			{
				((Control)MyProject.Forms.home.app9).Enabled = true;
				MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app10).Enabled)
			{
				((Control)MyProject.Forms.home.app10).Enabled = true;
				MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app11).Enabled)
			{
				((Control)MyProject.Forms.home.app11).Enabled = true;
				MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app12).Enabled)
			{
				((Control)MyProject.Forms.home.app12).Enabled = true;
				MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app13).Enabled)
			{
				((Control)MyProject.Forms.home.app13).Enabled = true;
				MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app14).Enabled)
			{
				((Control)MyProject.Forms.home.app14).Enabled = true;
				MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app15).Enabled)
			{
				((Control)MyProject.Forms.home.app15).Enabled = true;
				MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app16).Enabled)
			{
				((Control)MyProject.Forms.home.app16).Enabled = true;
				MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app17).Enabled)
			{
				((Control)MyProject.Forms.home.app17).Enabled = true;
				MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app18).Enabled)
			{
				((Control)MyProject.Forms.home.app18).Enabled = true;
				MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app19).Enabled)
			{
				((Control)MyProject.Forms.home.app19).Enabled = true;
				MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app20).Enabled)
			{
				((Control)MyProject.Forms.home.app20).Enabled = true;
				MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app21).Enabled)
			{
				((Control)MyProject.Forms.home.app21).Enabled = true;
				MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app22).Enabled)
			{
				((Control)MyProject.Forms.home.app22).Enabled = true;
				MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app23).Enabled)
			{
				((Control)MyProject.Forms.home.app23).Enabled = true;
				MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app24).Enabled)
			{
				((Control)MyProject.Forms.home.app24).Enabled = true;
				MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.meeb.Image;
			}
			else if (!((Control)MyProject.Forms.home.app25).Enabled)
			{
				((Control)MyProject.Forms.home.app25).Enabled = true;
				MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.meeb.Image;
			}
			Fade.meebrowserin();
			WebBrowser1.Navigate("www.bing.com");
			urlhost.Enabled = true;
			urladdress.Enabled = true;
		}
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Panel2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void WebBrowser5_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
	{
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
}
