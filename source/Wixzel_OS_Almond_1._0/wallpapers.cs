using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[DesignerGenerated]
public class wallpapers : Form
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

	[AccessedThroughProperty("binary")]
	private PictureBox _binary;

	[AccessedThroughProperty("bubblero")]
	private PictureBox _bubblero;

	[AccessedThroughProperty("greenmix")]
	private PictureBox _greenmix;

	[AccessedThroughProperty("mirax")]
	private PictureBox _mirax;

	[AccessedThroughProperty("orange")]
	private PictureBox _orange;

	[AccessedThroughProperty("pinkero")]
	private PictureBox _pinkero;

	[AccessedThroughProperty("w1")]
	private PictureBox _w1;

	[AccessedThroughProperty("wixzelprob")]
	private PictureBox _wixzelprob;

	[AccessedThroughProperty("wixzelpro")]
	private PictureBox _wixzelpro;

	[AccessedThroughProperty("wixzeldb")]
	private PictureBox _wixzeldb;

	[AccessedThroughProperty("wixzeld")]
	private PictureBox _wixzeld;

	[AccessedThroughProperty("vibgyor")]
	private PictureBox _vibgyor;

	[AccessedThroughProperty("w2")]
	private PictureBox _w2;

	[AccessedThroughProperty("w3")]
	private PictureBox _w3;

	[AccessedThroughProperty("w5")]
	private PictureBox _w5;

	[AccessedThroughProperty("w4")]
	private PictureBox _w4;

	[AccessedThroughProperty("w7")]
	private PictureBox _w7;

	[AccessedThroughProperty("w6")]
	private PictureBox _w6;

	[AccessedThroughProperty("w13")]
	private PictureBox _w13;

	[AccessedThroughProperty("w12")]
	private PictureBox _w12;

	[AccessedThroughProperty("w11")]
	private PictureBox _w11;

	[AccessedThroughProperty("w10")]
	private PictureBox _w10;

	[AccessedThroughProperty("w9")]
	private PictureBox _w9;

	[AccessedThroughProperty("w8")]
	private PictureBox _w8;

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

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("Label24")]
	private Label _Label24;

	[AccessedThroughProperty("Label25")]
	private Label _Label25;

	[AccessedThroughProperty("cbinary")]
	private PictureBox _cbinary;

	[AccessedThroughProperty("cbubblero")]
	private PictureBox _cbubblero;

	[AccessedThroughProperty("cmirax")]
	private PictureBox _cmirax;

	[AccessedThroughProperty("cgreenmix")]
	private PictureBox _cgreenmix;

	[AccessedThroughProperty("cpinkero")]
	private PictureBox _cpinkero;

	[AccessedThroughProperty("corange")]
	private PictureBox _corange;

	[AccessedThroughProperty("cw1")]
	private PictureBox _cw1;

	[AccessedThroughProperty("cwixzelprob")]
	private PictureBox _cwixzelprob;

	[AccessedThroughProperty("cwixzelpro")]
	private PictureBox _cwixzelpro;

	[AccessedThroughProperty("cwixzeldb")]
	private PictureBox _cwixzeldb;

	[AccessedThroughProperty("cwixzeld")]
	private PictureBox _cwixzeld;

	[AccessedThroughProperty("cvibgyor")]
	private PictureBox _cvibgyor;

	[AccessedThroughProperty("cw7")]
	private PictureBox _cw7;

	[AccessedThroughProperty("cw6")]
	private PictureBox _cw6;

	[AccessedThroughProperty("cw5")]
	private PictureBox _cw5;

	[AccessedThroughProperty("cw4")]
	private PictureBox _cw4;

	[AccessedThroughProperty("cw3")]
	private PictureBox _cw3;

	[AccessedThroughProperty("cw2")]
	private PictureBox _cw2;

	[AccessedThroughProperty("cw13")]
	private PictureBox _cw13;

	[AccessedThroughProperty("cw12")]
	private PictureBox _cw12;

	[AccessedThroughProperty("cw11")]
	private PictureBox _cw11;

	[AccessedThroughProperty("cw10")]
	private PictureBox _cw10;

	[AccessedThroughProperty("cw9")]
	private PictureBox _cw9;

	[AccessedThroughProperty("cw8")]
	private PictureBox _cw8;

	[AccessedThroughProperty("defaultclose")]
	private PictureBox _defaultclose;

	[AccessedThroughProperty("hoverclose")]
	private PictureBox _hoverclose;

	[AccessedThroughProperty("clickclose")]
	private PictureBox _clickclose;

	[AccessedThroughProperty("PictureBox7")]
	private PictureBox _PictureBox7;

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

	internal virtual PictureBox binary
	{
		[DebuggerNonUserCode]
		get
		{
			return _binary;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = binary_Click;
			if (_binary != null)
			{
				((Control)_binary).Click -= eventHandler;
			}
			_binary = value;
			if (_binary != null)
			{
				((Control)_binary).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox bubblero
	{
		[DebuggerNonUserCode]
		get
		{
			return _bubblero;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = bubblero_Click;
			if (_bubblero != null)
			{
				((Control)_bubblero).Click -= eventHandler;
			}
			_bubblero = value;
			if (_bubblero != null)
			{
				((Control)_bubblero).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox greenmix
	{
		[DebuggerNonUserCode]
		get
		{
			return _greenmix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = greenmix_Click;
			if (_greenmix != null)
			{
				((Control)_greenmix).Click -= eventHandler;
			}
			_greenmix = value;
			if (_greenmix != null)
			{
				((Control)_greenmix).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox mirax
	{
		[DebuggerNonUserCode]
		get
		{
			return _mirax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mirax_Click;
			if (_mirax != null)
			{
				((Control)_mirax).Click -= eventHandler;
			}
			_mirax = value;
			if (_mirax != null)
			{
				((Control)_mirax).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox orange
	{
		[DebuggerNonUserCode]
		get
		{
			return _orange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = orange_Click;
			if (_orange != null)
			{
				((Control)_orange).Click -= eventHandler;
			}
			_orange = value;
			if (_orange != null)
			{
				((Control)_orange).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox pinkero
	{
		[DebuggerNonUserCode]
		get
		{
			return _pinkero;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = pinkero_Click;
			if (_pinkero != null)
			{
				((Control)_pinkero).Click -= eventHandler;
			}
			_pinkero = value;
			if (_pinkero != null)
			{
				((Control)_pinkero).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w1
	{
		[DebuggerNonUserCode]
		get
		{
			return _w1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w1_Click;
			if (_w1 != null)
			{
				((Control)_w1).Click -= eventHandler;
			}
			_w1 = value;
			if (_w1 != null)
			{
				((Control)_w1).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox wixzelprob
	{
		[DebuggerNonUserCode]
		get
		{
			return _wixzelprob;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = wixzelprob_Click;
			if (_wixzelprob != null)
			{
				((Control)_wixzelprob).Click -= eventHandler;
			}
			_wixzelprob = value;
			if (_wixzelprob != null)
			{
				((Control)_wixzelprob).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox wixzelpro
	{
		[DebuggerNonUserCode]
		get
		{
			return _wixzelpro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = wixzelpro_Click;
			if (_wixzelpro != null)
			{
				((Control)_wixzelpro).Click -= eventHandler;
			}
			_wixzelpro = value;
			if (_wixzelpro != null)
			{
				((Control)_wixzelpro).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox wixzeldb
	{
		[DebuggerNonUserCode]
		get
		{
			return _wixzeldb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = wixzeldb_Click;
			if (_wixzeldb != null)
			{
				((Control)_wixzeldb).Click -= eventHandler;
			}
			_wixzeldb = value;
			if (_wixzeldb != null)
			{
				((Control)_wixzeldb).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox wixzeld
	{
		[DebuggerNonUserCode]
		get
		{
			return _wixzeld;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = wixzeld_Click;
			if (_wixzeld != null)
			{
				((Control)_wixzeld).Click -= eventHandler;
			}
			_wixzeld = value;
			if (_wixzeld != null)
			{
				((Control)_wixzeld).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox vibgyor
	{
		[DebuggerNonUserCode]
		get
		{
			return _vibgyor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = vibgyor_Click;
			if (_vibgyor != null)
			{
				((Control)_vibgyor).Click -= eventHandler;
			}
			_vibgyor = value;
			if (_vibgyor != null)
			{
				((Control)_vibgyor).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w2
	{
		[DebuggerNonUserCode]
		get
		{
			return _w2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w2_Click;
			if (_w2 != null)
			{
				((Control)_w2).Click -= eventHandler;
			}
			_w2 = value;
			if (_w2 != null)
			{
				((Control)_w2).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w3
	{
		[DebuggerNonUserCode]
		get
		{
			return _w3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w3_Click;
			if (_w3 != null)
			{
				((Control)_w3).Click -= eventHandler;
			}
			_w3 = value;
			if (_w3 != null)
			{
				((Control)_w3).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w5
	{
		[DebuggerNonUserCode]
		get
		{
			return _w5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w5_Click;
			if (_w5 != null)
			{
				((Control)_w5).Click -= eventHandler;
			}
			_w5 = value;
			if (_w5 != null)
			{
				((Control)_w5).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w4
	{
		[DebuggerNonUserCode]
		get
		{
			return _w4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w4_Click;
			if (_w4 != null)
			{
				((Control)_w4).Click -= eventHandler;
			}
			_w4 = value;
			if (_w4 != null)
			{
				((Control)_w4).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w7
	{
		[DebuggerNonUserCode]
		get
		{
			return _w7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w7_Click;
			if (_w7 != null)
			{
				((Control)_w7).Click -= eventHandler;
			}
			_w7 = value;
			if (_w7 != null)
			{
				((Control)_w7).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w6
	{
		[DebuggerNonUserCode]
		get
		{
			return _w6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w6_Click;
			if (_w6 != null)
			{
				((Control)_w6).Click -= eventHandler;
			}
			_w6 = value;
			if (_w6 != null)
			{
				((Control)_w6).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w13
	{
		[DebuggerNonUserCode]
		get
		{
			return _w13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w13_Click;
			if (_w13 != null)
			{
				((Control)_w13).Click -= eventHandler;
			}
			_w13 = value;
			if (_w13 != null)
			{
				((Control)_w13).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w12
	{
		[DebuggerNonUserCode]
		get
		{
			return _w12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w12_Click;
			if (_w12 != null)
			{
				((Control)_w12).Click -= eventHandler;
			}
			_w12 = value;
			if (_w12 != null)
			{
				((Control)_w12).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w11
	{
		[DebuggerNonUserCode]
		get
		{
			return _w11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w11_Click;
			if (_w11 != null)
			{
				((Control)_w11).Click -= eventHandler;
			}
			_w11 = value;
			if (_w11 != null)
			{
				((Control)_w11).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w10
	{
		[DebuggerNonUserCode]
		get
		{
			return _w10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w10_Click;
			if (_w10 != null)
			{
				((Control)_w10).Click -= eventHandler;
			}
			_w10 = value;
			if (_w10 != null)
			{
				((Control)_w10).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w9
	{
		[DebuggerNonUserCode]
		get
		{
			return _w9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w9_Click;
			if (_w9 != null)
			{
				((Control)_w9).Click -= eventHandler;
			}
			_w9 = value;
			if (_w9 != null)
			{
				((Control)_w9).Click += eventHandler;
			}
		}
	}

	internal virtual PictureBox w8
	{
		[DebuggerNonUserCode]
		get
		{
			return _w8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = w8_Click;
			if (_w8 != null)
			{
				((Control)_w8).Click -= eventHandler;
			}
			_w8 = value;
			if (_w8 != null)
			{
				((Control)_w8).Click += eventHandler;
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
			_Label15 = value;
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
			_Label18 = value;
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

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	internal virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	internal virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual Label Label24
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label24 = value;
		}
	}

	internal virtual Label Label25
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label25 = value;
		}
	}

	internal virtual PictureBox cbinary
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbinary;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cbinary = value;
		}
	}

	internal virtual PictureBox cbubblero
	{
		[DebuggerNonUserCode]
		get
		{
			return _cbubblero;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cbubblero = value;
		}
	}

	internal virtual PictureBox cmirax
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmirax;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cmirax = value;
		}
	}

	internal virtual PictureBox cgreenmix
	{
		[DebuggerNonUserCode]
		get
		{
			return _cgreenmix;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cgreenmix = value;
		}
	}

	internal virtual PictureBox cpinkero
	{
		[DebuggerNonUserCode]
		get
		{
			return _cpinkero;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cpinkero = value;
		}
	}

	internal virtual PictureBox corange
	{
		[DebuggerNonUserCode]
		get
		{
			return _corange;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_corange = value;
		}
	}

	internal virtual PictureBox cw1
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw1 = value;
		}
	}

	internal virtual PictureBox cwixzelprob
	{
		[DebuggerNonUserCode]
		get
		{
			return _cwixzelprob;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cwixzelprob = value;
		}
	}

	internal virtual PictureBox cwixzelpro
	{
		[DebuggerNonUserCode]
		get
		{
			return _cwixzelpro;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cwixzelpro = value;
		}
	}

	internal virtual PictureBox cwixzeldb
	{
		[DebuggerNonUserCode]
		get
		{
			return _cwixzeldb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cwixzeldb = value;
		}
	}

	internal virtual PictureBox cwixzeld
	{
		[DebuggerNonUserCode]
		get
		{
			return _cwixzeld;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cwixzeld = value;
		}
	}

	internal virtual PictureBox cvibgyor
	{
		[DebuggerNonUserCode]
		get
		{
			return _cvibgyor;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cvibgyor = value;
		}
	}

	internal virtual PictureBox cw7
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw7 = value;
		}
	}

	internal virtual PictureBox cw6
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw6 = value;
		}
	}

	internal virtual PictureBox cw5
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw5 = value;
		}
	}

	internal virtual PictureBox cw4
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw4 = value;
		}
	}

	internal virtual PictureBox cw3
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw3 = value;
		}
	}

	internal virtual PictureBox cw2
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw2 = value;
		}
	}

	internal virtual PictureBox cw13
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw13 = value;
		}
	}

	internal virtual PictureBox cw12
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw12 = value;
		}
	}

	internal virtual PictureBox cw11
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw11 = value;
		}
	}

	internal virtual PictureBox cw10
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw10 = value;
		}
	}

	internal virtual PictureBox cw9
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw9 = value;
		}
	}

	internal virtual PictureBox cw8
	{
		[DebuggerNonUserCode]
		get
		{
			return _cw8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_cw8 = value;
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
	public wallpapers()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((Form)this).FormClosing += new FormClosingEventHandler(wallpapers_FormClosing);
		((Form)this).Load += wallpapers_Load;
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
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d4: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected O, but got Unknown
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_067d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected O, but got Unknown
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07be: Expected O, but got Unknown
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got Unknown
		//IL_08d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Expected O, but got Unknown
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Expected O, but got Unknown
		//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a17: Expected O, but got Unknown
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected O, but got Unknown
		//IL_0b4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b55: Expected O, but got Unknown
		//IL_0bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf4: Expected O, but got Unknown
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Expected O, but got Unknown
		//IL_0dbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Expected O, but got Unknown
		//IL_0e60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6a: Expected O, but got Unknown
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0c: Expected O, but got Unknown
		//IL_0fa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fae: Expected O, but got Unknown
		//IL_1730: Unknown result type (might be due to invalid IL or missing references)
		//IL_173a: Expected O, but got Unknown
		//IL_17f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fe: Expected O, but got Unknown
		//IL_18bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c5: Expected O, but got Unknown
		//IL_1982: Unknown result type (might be due to invalid IL or missing references)
		//IL_198c: Expected O, but got Unknown
		//IL_1a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a53: Expected O, but got Unknown
		//IL_1b10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1a: Expected O, but got Unknown
		//IL_1bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be1: Expected O, but got Unknown
		//IL_1c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca8: Expected O, but got Unknown
		//IL_1d65: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6f: Expected O, but got Unknown
		//IL_1e2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e36: Expected O, but got Unknown
		//IL_1ef3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1efd: Expected O, but got Unknown
		//IL_1fba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fc4: Expected O, but got Unknown
		//IL_207e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2088: Expected O, but got Unknown
		//IL_2145: Unknown result type (might be due to invalid IL or missing references)
		//IL_214f: Expected O, but got Unknown
		//IL_220c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2216: Expected O, but got Unknown
		//IL_22d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_22dd: Expected O, but got Unknown
		//IL_239a: Unknown result type (might be due to invalid IL or missing references)
		//IL_23a4: Expected O, but got Unknown
		//IL_2461: Unknown result type (might be due to invalid IL or missing references)
		//IL_246b: Expected O, but got Unknown
		//IL_2525: Unknown result type (might be due to invalid IL or missing references)
		//IL_252f: Expected O, but got Unknown
		//IL_25ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_25f6: Expected O, but got Unknown
		//IL_26b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_26bd: Expected O, but got Unknown
		//IL_277a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2784: Expected O, but got Unknown
		//IL_2841: Unknown result type (might be due to invalid IL or missing references)
		//IL_284b: Expected O, but got Unknown
		//IL_2908: Unknown result type (might be due to invalid IL or missing references)
		//IL_2912: Expected O, but got Unknown
		//IL_29bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_29c7: Expected O, but got Unknown
		//IL_2a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a70: Expected O, but got Unknown
		//IL_2b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b19: Expected O, but got Unknown
		//IL_2bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc2: Expected O, but got Unknown
		//IL_2c61: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c6b: Expected O, but got Unknown
		//IL_2d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d14: Expected O, but got Unknown
		//IL_2db3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dbd: Expected O, but got Unknown
		//IL_2e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e69: Expected O, but got Unknown
		//IL_2f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f15: Expected O, but got Unknown
		//IL_2fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fc1: Expected O, but got Unknown
		//IL_3063: Unknown result type (might be due to invalid IL or missing references)
		//IL_306d: Expected O, but got Unknown
		//IL_310f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3119: Expected O, but got Unknown
		//IL_31bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_31c5: Expected O, but got Unknown
		//IL_3267: Unknown result type (might be due to invalid IL or missing references)
		//IL_3271: Expected O, but got Unknown
		//IL_3313: Unknown result type (might be due to invalid IL or missing references)
		//IL_331d: Expected O, but got Unknown
		//IL_33bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_33c9: Expected O, but got Unknown
		//IL_346b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3475: Expected O, but got Unknown
		//IL_3517: Unknown result type (might be due to invalid IL or missing references)
		//IL_3521: Expected O, but got Unknown
		//IL_35c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35cd: Expected O, but got Unknown
		//IL_366f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3679: Expected O, but got Unknown
		//IL_371b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3725: Expected O, but got Unknown
		//IL_37c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_37d1: Expected O, but got Unknown
		//IL_3873: Unknown result type (might be due to invalid IL or missing references)
		//IL_387d: Expected O, but got Unknown
		//IL_391f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3929: Expected O, but got Unknown
		//IL_39cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d5: Expected O, but got Unknown
		//IL_3a73: Unknown result type (might be due to invalid IL or missing references)
		//IL_3a7d: Expected O, but got Unknown
		//IL_3b1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b25: Expected O, but got Unknown
		//IL_3bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_3bbc: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(wallpapers));
		PictureBox3 = new PictureBox();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		binary = new PictureBox();
		bubblero = new PictureBox();
		greenmix = new PictureBox();
		mirax = new PictureBox();
		orange = new PictureBox();
		pinkero = new PictureBox();
		w1 = new PictureBox();
		wixzelprob = new PictureBox();
		wixzelpro = new PictureBox();
		wixzeldb = new PictureBox();
		wixzeld = new PictureBox();
		vibgyor = new PictureBox();
		w2 = new PictureBox();
		w3 = new PictureBox();
		w5 = new PictureBox();
		w4 = new PictureBox();
		w7 = new PictureBox();
		w6 = new PictureBox();
		w13 = new PictureBox();
		w12 = new PictureBox();
		w11 = new PictureBox();
		w10 = new PictureBox();
		w9 = new PictureBox();
		w8 = new PictureBox();
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
		Label18 = new Label();
		Label19 = new Label();
		Label20 = new Label();
		Label21 = new Label();
		Label22 = new Label();
		Label23 = new Label();
		Label24 = new Label();
		Label25 = new Label();
		cbinary = new PictureBox();
		cbubblero = new PictureBox();
		cmirax = new PictureBox();
		cgreenmix = new PictureBox();
		cpinkero = new PictureBox();
		corange = new PictureBox();
		cw1 = new PictureBox();
		cwixzelprob = new PictureBox();
		cwixzelpro = new PictureBox();
		cwixzeldb = new PictureBox();
		cwixzeld = new PictureBox();
		cvibgyor = new PictureBox();
		cw7 = new PictureBox();
		cw6 = new PictureBox();
		cw5 = new PictureBox();
		cw4 = new PictureBox();
		cw3 = new PictureBox();
		cw2 = new PictureBox();
		cw13 = new PictureBox();
		cw12 = new PictureBox();
		cw11 = new PictureBox();
		cw10 = new PictureBox();
		cw9 = new PictureBox();
		cw8 = new PictureBox();
		defaultclose = new PictureBox();
		hoverclose = new PictureBox();
		clickclose = new PictureBox();
		PictureBox7 = new PictureBox();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)binary).BeginInit();
		((ISupportInitialize)bubblero).BeginInit();
		((ISupportInitialize)greenmix).BeginInit();
		((ISupportInitialize)mirax).BeginInit();
		((ISupportInitialize)orange).BeginInit();
		((ISupportInitialize)pinkero).BeginInit();
		((ISupportInitialize)w1).BeginInit();
		((ISupportInitialize)wixzelprob).BeginInit();
		((ISupportInitialize)wixzelpro).BeginInit();
		((ISupportInitialize)wixzeldb).BeginInit();
		((ISupportInitialize)wixzeld).BeginInit();
		((ISupportInitialize)vibgyor).BeginInit();
		((ISupportInitialize)w2).BeginInit();
		((ISupportInitialize)w3).BeginInit();
		((ISupportInitialize)w5).BeginInit();
		((ISupportInitialize)w4).BeginInit();
		((ISupportInitialize)w7).BeginInit();
		((ISupportInitialize)w6).BeginInit();
		((ISupportInitialize)w13).BeginInit();
		((ISupportInitialize)w12).BeginInit();
		((ISupportInitialize)w11).BeginInit();
		((ISupportInitialize)w10).BeginInit();
		((ISupportInitialize)w9).BeginInit();
		((ISupportInitialize)w8).BeginInit();
		((ISupportInitialize)cbinary).BeginInit();
		((ISupportInitialize)cbubblero).BeginInit();
		((ISupportInitialize)cmirax).BeginInit();
		((ISupportInitialize)cgreenmix).BeginInit();
		((ISupportInitialize)cpinkero).BeginInit();
		((ISupportInitialize)corange).BeginInit();
		((ISupportInitialize)cw1).BeginInit();
		((ISupportInitialize)cwixzelprob).BeginInit();
		((ISupportInitialize)cwixzelpro).BeginInit();
		((ISupportInitialize)cwixzeldb).BeginInit();
		((ISupportInitialize)cwixzeld).BeginInit();
		((ISupportInitialize)cvibgyor).BeginInit();
		((ISupportInitialize)cw7).BeginInit();
		((ISupportInitialize)cw6).BeginInit();
		((ISupportInitialize)cw5).BeginInit();
		((ISupportInitialize)cw4).BeginInit();
		((ISupportInitialize)cw3).BeginInit();
		((ISupportInitialize)cw2).BeginInit();
		((ISupportInitialize)cw13).BeginInit();
		((ISupportInitialize)cw12).BeginInit();
		((ISupportInitialize)cw11).BeginInit();
		((ISupportInitialize)cw10).BeginInit();
		((ISupportInitialize)cw9).BeginInit();
		((ISupportInitialize)cw8).BeginInit();
		((ISupportInitialize)defaultclose).BeginInit();
		((ISupportInitialize)hoverclose).BeginInit();
		((ISupportInitialize)clickclose).BeginInit();
		((ISupportInitialize)PictureBox7).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox3.Image = (Image)componentResourceManager.GetObject("PictureBox3.Image");
		PictureBox pictureBox = PictureBox3;
		Point location = new Point(949, 1);
		((Control)pictureBox).Location = location;
		((Control)PictureBox3).Name = "PictureBox3";
		PictureBox pictureBox2 = PictureBox3;
		Size size = new Size(51, 34);
		((Control)pictureBox2).Size = size;
		PictureBox3.SizeMode = (PictureBoxSizeMode)2;
		PictureBox3.TabIndex = 8;
		PictureBox3.TabStop = false;
		Label1.AutoSize = true;
		((Control)Label1).BackColor = Color.White;
		((Control)Label1).Font = new Font("Futura Bk BT", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		Label label = Label1;
		location = new Point(37, 7);
		((Control)label).Location = location;
		((Control)Label1).Name = "Label1";
		Label label2 = Label1;
		size = new Size(89, 19);
		((Control)label2).Size = size;
		((Control)Label1).TabIndex = 7;
		Label1.Text = "Wallpapers";
		((Control)PictureBox2).BackColor = Color.White;
		PictureBox2.Image = (Image)componentResourceManager.GetObject("PictureBox2.Image");
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(5, 2);
		((Control)pictureBox3).Location = location;
		((Control)PictureBox2).Name = "PictureBox2";
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(30, 30);
		((Control)pictureBox4).Size = size;
		PictureBox2.SizeMode = (PictureBoxSizeMode)2;
		PictureBox2.TabIndex = 6;
		PictureBox2.TabStop = false;
		PictureBox1.Image = (Image)componentResourceManager.GetObject("PictureBox1.Image");
		PictureBox pictureBox5 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox5).Location = location;
		((Control)PictureBox1).Name = "PictureBox1";
		PictureBox pictureBox6 = PictureBox1;
		size = new Size(1400, 35);
		((Control)pictureBox6).Size = size;
		PictureBox1.SizeMode = (PictureBoxSizeMode)2;
		PictureBox1.TabIndex = 5;
		PictureBox1.TabStop = false;
		((Control)binary).BackColor = Color.White;
		binary.Image = (Image)componentResourceManager.GetObject("binary.Image");
		PictureBox obj = binary;
		location = new Point(65, 74);
		((Control)obj).Location = location;
		((Control)binary).Name = "binary";
		PictureBox obj2 = binary;
		size = new Size(140, 90);
		((Control)obj2).Size = size;
		binary.SizeMode = (PictureBoxSizeMode)1;
		binary.TabIndex = 9;
		binary.TabStop = false;
		((Control)bubblero).BackColor = Color.White;
		bubblero.Image = (Image)componentResourceManager.GetObject("bubblero.Image");
		PictureBox obj3 = bubblero;
		location = new Point(211, 74);
		((Control)obj3).Location = location;
		((Control)bubblero).Name = "bubblero";
		PictureBox obj4 = bubblero;
		size = new Size(140, 90);
		((Control)obj4).Size = size;
		bubblero.SizeMode = (PictureBoxSizeMode)1;
		bubblero.TabIndex = 10;
		bubblero.TabStop = false;
		((Control)greenmix).BackColor = Color.White;
		greenmix.Image = (Image)componentResourceManager.GetObject("greenmix.Image");
		PictureBox obj5 = greenmix;
		location = new Point(357, 74);
		((Control)obj5).Location = location;
		((Control)greenmix).Name = "greenmix";
		PictureBox obj6 = greenmix;
		size = new Size(140, 90);
		((Control)obj6).Size = size;
		greenmix.SizeMode = (PictureBoxSizeMode)1;
		greenmix.TabIndex = 11;
		greenmix.TabStop = false;
		((Control)mirax).BackColor = Color.White;
		mirax.Image = (Image)componentResourceManager.GetObject("mirax.Image");
		PictureBox obj7 = mirax;
		location = new Point(503, 74);
		((Control)obj7).Location = location;
		((Control)mirax).Name = "mirax";
		PictureBox obj8 = mirax;
		size = new Size(140, 90);
		((Control)obj8).Size = size;
		mirax.SizeMode = (PictureBoxSizeMode)1;
		mirax.TabIndex = 12;
		mirax.TabStop = false;
		((Control)orange).BackColor = Color.White;
		orange.Image = (Image)componentResourceManager.GetObject("orange.Image");
		PictureBox obj9 = orange;
		location = new Point(649, 74);
		((Control)obj9).Location = location;
		((Control)orange).Name = "orange";
		PictureBox obj10 = orange;
		size = new Size(140, 90);
		((Control)obj10).Size = size;
		orange.SizeMode = (PictureBoxSizeMode)1;
		orange.TabIndex = 13;
		orange.TabStop = false;
		((Control)pinkero).BackColor = Color.White;
		pinkero.Image = (Image)componentResourceManager.GetObject("pinkero.Image");
		PictureBox obj11 = pinkero;
		location = new Point(795, 74);
		((Control)obj11).Location = location;
		((Control)pinkero).Name = "pinkero";
		PictureBox obj12 = pinkero;
		size = new Size(140, 90);
		((Control)obj12).Size = size;
		pinkero.SizeMode = (PictureBoxSizeMode)1;
		pinkero.TabIndex = 14;
		pinkero.TabStop = false;
		((Control)w1).BackColor = Color.White;
		((Control)w1).Enabled = false;
		PictureBox obj13 = w1;
		location = new Point(795, 190);
		((Control)obj13).Location = location;
		((Control)w1).Name = "w1";
		PictureBox obj14 = w1;
		size = new Size(140, 90);
		((Control)obj14).Size = size;
		w1.SizeMode = (PictureBoxSizeMode)1;
		w1.TabIndex = 20;
		w1.TabStop = false;
		((Control)wixzelprob).BackColor = Color.White;
		wixzelprob.Image = (Image)componentResourceManager.GetObject("wixzelprob.Image");
		PictureBox obj15 = wixzelprob;
		location = new Point(649, 190);
		((Control)obj15).Location = location;
		((Control)wixzelprob).Name = "wixzelprob";
		PictureBox obj16 = wixzelprob;
		size = new Size(140, 90);
		((Control)obj16).Size = size;
		wixzelprob.SizeMode = (PictureBoxSizeMode)1;
		wixzelprob.TabIndex = 19;
		wixzelprob.TabStop = false;
		((Control)wixzelpro).BackColor = Color.White;
		wixzelpro.Image = (Image)componentResourceManager.GetObject("wixzelpro.Image");
		PictureBox obj17 = wixzelpro;
		location = new Point(503, 190);
		((Control)obj17).Location = location;
		((Control)wixzelpro).Name = "wixzelpro";
		PictureBox obj18 = wixzelpro;
		size = new Size(140, 90);
		((Control)obj18).Size = size;
		wixzelpro.SizeMode = (PictureBoxSizeMode)1;
		wixzelpro.TabIndex = 18;
		wixzelpro.TabStop = false;
		((Control)wixzeldb).BackColor = Color.White;
		wixzeldb.Image = (Image)componentResourceManager.GetObject("wixzeldb.Image");
		PictureBox obj19 = wixzeldb;
		location = new Point(357, 190);
		((Control)obj19).Location = location;
		((Control)wixzeldb).Name = "wixzeldb";
		PictureBox obj20 = wixzeldb;
		size = new Size(140, 90);
		((Control)obj20).Size = size;
		wixzeldb.SizeMode = (PictureBoxSizeMode)1;
		wixzeldb.TabIndex = 17;
		wixzeldb.TabStop = false;
		((Control)wixzeld).BackColor = Color.White;
		wixzeld.Image = (Image)componentResourceManager.GetObject("wixzeld.Image");
		PictureBox obj21 = wixzeld;
		location = new Point(211, 190);
		((Control)obj21).Location = location;
		((Control)wixzeld).Name = "wixzeld";
		PictureBox obj22 = wixzeld;
		size = new Size(140, 90);
		((Control)obj22).Size = size;
		wixzeld.SizeMode = (PictureBoxSizeMode)1;
		wixzeld.TabIndex = 16;
		wixzeld.TabStop = false;
		((Control)vibgyor).BackColor = Color.White;
		vibgyor.Image = (Image)componentResourceManager.GetObject("vibgyor.Image");
		PictureBox obj23 = vibgyor;
		location = new Point(65, 190);
		((Control)obj23).Location = location;
		((Control)vibgyor).Name = "vibgyor";
		PictureBox obj24 = vibgyor;
		size = new Size(140, 90);
		((Control)obj24).Size = size;
		vibgyor.SizeMode = (PictureBoxSizeMode)1;
		vibgyor.TabIndex = 15;
		vibgyor.TabStop = false;
		((Control)w2).BackColor = Color.White;
		((Control)w2).Enabled = false;
		PictureBox obj25 = w2;
		location = new Point(65, 308);
		((Control)obj25).Location = location;
		((Control)w2).Name = "w2";
		PictureBox obj26 = w2;
		size = new Size(140, 90);
		((Control)obj26).Size = size;
		w2.SizeMode = (PictureBoxSizeMode)1;
		w2.TabIndex = 21;
		w2.TabStop = false;
		((Control)w3).BackColor = Color.White;
		((Control)w3).Enabled = false;
		PictureBox obj27 = w3;
		location = new Point(211, 308);
		((Control)obj27).Location = location;
		((Control)w3).Name = "w3";
		PictureBox obj28 = w3;
		size = new Size(140, 90);
		((Control)obj28).Size = size;
		w3.SizeMode = (PictureBoxSizeMode)1;
		w3.TabIndex = 22;
		w3.TabStop = false;
		((Control)w5).BackColor = Color.White;
		((Control)w5).Enabled = false;
		PictureBox obj29 = w5;
		location = new Point(503, 308);
		((Control)obj29).Location = location;
		((Control)w5).Name = "w5";
		PictureBox obj30 = w5;
		size = new Size(140, 90);
		((Control)obj30).Size = size;
		w5.SizeMode = (PictureBoxSizeMode)1;
		w5.TabIndex = 24;
		w5.TabStop = false;
		((Control)w4).BackColor = Color.White;
		((Control)w4).Enabled = false;
		PictureBox obj31 = w4;
		location = new Point(357, 308);
		((Control)obj31).Location = location;
		((Control)w4).Name = "w4";
		PictureBox obj32 = w4;
		size = new Size(140, 90);
		((Control)obj32).Size = size;
		w4.SizeMode = (PictureBoxSizeMode)1;
		w4.TabIndex = 23;
		w4.TabStop = false;
		((Control)w7).BackColor = Color.White;
		((Control)w7).Enabled = false;
		PictureBox obj33 = w7;
		location = new Point(795, 308);
		((Control)obj33).Location = location;
		((Control)w7).Name = "w7";
		PictureBox obj34 = w7;
		size = new Size(140, 90);
		((Control)obj34).Size = size;
		w7.SizeMode = (PictureBoxSizeMode)1;
		w7.TabIndex = 26;
		w7.TabStop = false;
		((Control)w6).BackColor = Color.White;
		((Control)w6).Enabled = false;
		PictureBox obj35 = w6;
		location = new Point(649, 308);
		((Control)obj35).Location = location;
		((Control)w6).Name = "w6";
		PictureBox obj36 = w6;
		size = new Size(140, 90);
		((Control)obj36).Size = size;
		w6.SizeMode = (PictureBoxSizeMode)1;
		w6.TabIndex = 25;
		w6.TabStop = false;
		((Control)w13).BackColor = Color.White;
		((Control)w13).Enabled = false;
		PictureBox obj37 = w13;
		location = new Point(795, 427);
		((Control)obj37).Location = location;
		((Control)w13).Name = "w13";
		PictureBox obj38 = w13;
		size = new Size(140, 90);
		((Control)obj38).Size = size;
		w13.SizeMode = (PictureBoxSizeMode)1;
		w13.TabIndex = 32;
		w13.TabStop = false;
		((Control)w12).BackColor = Color.White;
		((Control)w12).Enabled = false;
		PictureBox obj39 = w12;
		location = new Point(649, 427);
		((Control)obj39).Location = location;
		((Control)w12).Name = "w12";
		PictureBox obj40 = w12;
		size = new Size(140, 90);
		((Control)obj40).Size = size;
		w12.SizeMode = (PictureBoxSizeMode)1;
		w12.TabIndex = 31;
		w12.TabStop = false;
		((Control)w11).BackColor = Color.White;
		((Control)w11).Enabled = false;
		PictureBox obj41 = w11;
		location = new Point(503, 427);
		((Control)obj41).Location = location;
		((Control)w11).Name = "w11";
		PictureBox obj42 = w11;
		size = new Size(140, 90);
		((Control)obj42).Size = size;
		w11.SizeMode = (PictureBoxSizeMode)1;
		w11.TabIndex = 30;
		w11.TabStop = false;
		((Control)w10).BackColor = Color.White;
		((Control)w10).Enabled = false;
		PictureBox obj43 = w10;
		location = new Point(357, 427);
		((Control)obj43).Location = location;
		((Control)w10).Name = "w10";
		PictureBox obj44 = w10;
		size = new Size(140, 90);
		((Control)obj44).Size = size;
		w10.SizeMode = (PictureBoxSizeMode)1;
		w10.TabIndex = 29;
		w10.TabStop = false;
		((Control)w9).BackColor = Color.White;
		((Control)w9).Enabled = false;
		PictureBox obj45 = w9;
		location = new Point(211, 427);
		((Control)obj45).Location = location;
		((Control)w9).Name = "w9";
		PictureBox obj46 = w9;
		size = new Size(140, 90);
		((Control)obj46).Size = size;
		w9.SizeMode = (PictureBoxSizeMode)1;
		w9.TabIndex = 28;
		w9.TabStop = false;
		((Control)w8).BackColor = Color.White;
		((Control)w8).Enabled = false;
		PictureBox obj47 = w8;
		location = new Point(65, 427);
		((Control)obj47).Location = location;
		((Control)w8).Name = "w8";
		PictureBox obj48 = w8;
		size = new Size(140, 90);
		((Control)obj48).Size = size;
		w8.SizeMode = (PictureBoxSizeMode)1;
		w8.TabIndex = 27;
		w8.TabStop = false;
		((Control)Label2).Anchor = (AnchorStyles)3;
		((Control)Label2).BackColor = Color.Transparent;
		((Control)Label2).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label2).ForeColor = Color.White;
		Label label3 = Label2;
		location = new Point(65, 167);
		((Control)label3).Location = location;
		((Control)Label2).Name = "Label2";
		Label label4 = Label2;
		size = new Size(140, 20);
		((Control)label4).Size = size;
		((Control)Label2).TabIndex = 33;
		Label2.Text = "Binary";
		Label2.TextAlign = (ContentAlignment)32;
		((Control)Label3).Anchor = (AnchorStyles)3;
		((Control)Label3).BackColor = Color.Transparent;
		((Control)Label3).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label3).ForeColor = Color.White;
		Label label5 = Label3;
		location = new Point(211, 167);
		((Control)label5).Location = location;
		((Control)Label3).Name = "Label3";
		Label label6 = Label3;
		size = new Size(140, 20);
		((Control)label6).Size = size;
		((Control)Label3).TabIndex = 34;
		Label3.Text = "Bubblero";
		Label3.TextAlign = (ContentAlignment)32;
		((Control)Label4).Anchor = (AnchorStyles)3;
		((Control)Label4).BackColor = Color.Transparent;
		((Control)Label4).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label4).ForeColor = Color.White;
		Label label7 = Label4;
		location = new Point(503, 167);
		((Control)label7).Location = location;
		((Control)Label4).Name = "Label4";
		Label label8 = Label4;
		size = new Size(140, 20);
		((Control)label8).Size = size;
		((Control)Label4).TabIndex = 36;
		Label4.Text = "Mirax";
		Label4.TextAlign = (ContentAlignment)32;
		((Control)Label5).Anchor = (AnchorStyles)3;
		((Control)Label5).BackColor = Color.Transparent;
		((Control)Label5).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = Color.White;
		Label label9 = Label5;
		location = new Point(357, 167);
		((Control)label9).Location = location;
		((Control)Label5).Name = "Label5";
		Label label10 = Label5;
		size = new Size(140, 20);
		((Control)label10).Size = size;
		((Control)Label5).TabIndex = 35;
		Label5.Text = "Greenmix";
		Label5.TextAlign = (ContentAlignment)32;
		((Control)Label6).Anchor = (AnchorStyles)3;
		((Control)Label6).BackColor = Color.Transparent;
		((Control)Label6).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label6).ForeColor = Color.White;
		Label label11 = Label6;
		location = new Point(791, 167);
		((Control)label11).Location = location;
		((Control)Label6).Name = "Label6";
		Label label12 = Label6;
		size = new Size(140, 20);
		((Control)label12).Size = size;
		((Control)Label6).TabIndex = 38;
		Label6.Text = "Pinkero";
		Label6.TextAlign = (ContentAlignment)32;
		((Control)Label7).Anchor = (AnchorStyles)3;
		((Control)Label7).BackColor = Color.Transparent;
		((Control)Label7).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label7).ForeColor = Color.White;
		Label label13 = Label7;
		location = new Point(645, 167);
		((Control)label13).Location = location;
		((Control)Label7).Name = "Label7";
		Label label14 = Label7;
		size = new Size(140, 20);
		((Control)label14).Size = size;
		((Control)Label7).TabIndex = 37;
		Label7.Text = "O-Range";
		Label7.TextAlign = (ContentAlignment)32;
		((Control)Label8).Anchor = (AnchorStyles)3;
		((Control)Label8).BackColor = Color.Transparent;
		((Control)Label8).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label8).ForeColor = Color.White;
		Label label15 = Label8;
		location = new Point(791, 283);
		((Control)label15).Location = location;
		((Control)Label8).Name = "Label8";
		Label label16 = Label8;
		size = new Size(140, 20);
		((Control)label16).Size = size;
		((Control)Label8).TabIndex = 44;
		Label8.Text = "1";
		Label8.TextAlign = (ContentAlignment)32;
		((Control)Label9).Anchor = (AnchorStyles)3;
		((Control)Label9).BackColor = Color.Transparent;
		((Control)Label9).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label9).ForeColor = Color.White;
		Label label17 = Label9;
		location = new Point(645, 283);
		((Control)label17).Location = location;
		((Control)Label9).Name = "Label9";
		Label label18 = Label9;
		size = new Size(140, 20);
		((Control)label18).Size = size;
		((Control)Label9).TabIndex = 43;
		Label9.Text = "Wixzel Pro Blue";
		Label9.TextAlign = (ContentAlignment)32;
		((Control)Label10).Anchor = (AnchorStyles)3;
		((Control)Label10).BackColor = Color.Transparent;
		((Control)Label10).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = Color.White;
		Label label19 = Label10;
		location = new Point(503, 283);
		((Control)label19).Location = location;
		((Control)Label10).Name = "Label10";
		Label label20 = Label10;
		size = new Size(140, 20);
		((Control)label20).Size = size;
		((Control)Label10).TabIndex = 42;
		Label10.Text = "Wixzel Pro";
		Label10.TextAlign = (ContentAlignment)32;
		((Control)Label11).Anchor = (AnchorStyles)3;
		((Control)Label11).BackColor = Color.Transparent;
		((Control)Label11).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = Color.White;
		Label label21 = Label11;
		location = new Point(357, 283);
		((Control)label21).Location = location;
		((Control)Label11).Name = "Label11";
		Label label22 = Label11;
		size = new Size(140, 20);
		((Control)label22).Size = size;
		((Control)Label11).TabIndex = 41;
		Label11.Text = "Wixzel Blue";
		Label11.TextAlign = (ContentAlignment)32;
		((Control)Label12).Anchor = (AnchorStyles)3;
		((Control)Label12).BackColor = Color.Transparent;
		((Control)Label12).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.White;
		Label label23 = Label12;
		location = new Point(211, 283);
		((Control)label23).Location = location;
		((Control)Label12).Name = "Label12";
		Label label24 = Label12;
		size = new Size(140, 20);
		((Control)label24).Size = size;
		((Control)Label12).TabIndex = 40;
		Label12.Text = "Wixzel Default";
		Label12.TextAlign = (ContentAlignment)32;
		((Control)Label13).Anchor = (AnchorStyles)3;
		((Control)Label13).BackColor = Color.Transparent;
		((Control)Label13).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label13).ForeColor = Color.White;
		Label label25 = Label13;
		location = new Point(65, 283);
		((Control)label25).Location = location;
		((Control)Label13).Name = "Label13";
		Label label26 = Label13;
		size = new Size(140, 20);
		((Control)label26).Size = size;
		((Control)Label13).TabIndex = 39;
		Label13.Text = "Vibgyor";
		Label13.TextAlign = (ContentAlignment)32;
		((Control)Label14).Anchor = (AnchorStyles)3;
		((Control)Label14).BackColor = Color.Transparent;
		((Control)Label14).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label14).ForeColor = Color.White;
		Label label27 = Label14;
		location = new Point(791, 401);
		((Control)label27).Location = location;
		((Control)Label14).Name = "Label14";
		Label label28 = Label14;
		size = new Size(140, 20);
		((Control)label28).Size = size;
		((Control)Label14).TabIndex = 50;
		Label14.Text = "7";
		Label14.TextAlign = (ContentAlignment)32;
		((Control)Label15).Anchor = (AnchorStyles)3;
		((Control)Label15).BackColor = Color.Transparent;
		((Control)Label15).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label15).ForeColor = Color.White;
		Label label29 = Label15;
		location = new Point(645, 401);
		((Control)label29).Location = location;
		((Control)Label15).Name = "Label15";
		Label label30 = Label15;
		size = new Size(140, 20);
		((Control)label30).Size = size;
		((Control)Label15).TabIndex = 49;
		Label15.Text = "6";
		Label15.TextAlign = (ContentAlignment)32;
		((Control)Label16).Anchor = (AnchorStyles)3;
		((Control)Label16).BackColor = Color.Transparent;
		((Control)Label16).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label16).ForeColor = Color.White;
		Label label31 = Label16;
		location = new Point(503, 401);
		((Control)label31).Location = location;
		((Control)Label16).Name = "Label16";
		Label label32 = Label16;
		size = new Size(140, 20);
		((Control)label32).Size = size;
		((Control)Label16).TabIndex = 48;
		Label16.Text = "5";
		Label16.TextAlign = (ContentAlignment)32;
		((Control)Label17).Anchor = (AnchorStyles)3;
		((Control)Label17).BackColor = Color.Transparent;
		((Control)Label17).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label17).ForeColor = Color.White;
		Label label33 = Label17;
		location = new Point(357, 401);
		((Control)label33).Location = location;
		((Control)Label17).Name = "Label17";
		Label label34 = Label17;
		size = new Size(140, 20);
		((Control)label34).Size = size;
		((Control)Label17).TabIndex = 47;
		Label17.Text = "4";
		Label17.TextAlign = (ContentAlignment)32;
		((Control)Label18).Anchor = (AnchorStyles)3;
		((Control)Label18).BackColor = Color.Transparent;
		((Control)Label18).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label18).ForeColor = Color.White;
		Label label35 = Label18;
		location = new Point(211, 401);
		((Control)label35).Location = location;
		((Control)Label18).Name = "Label18";
		Label label36 = Label18;
		size = new Size(140, 20);
		((Control)label36).Size = size;
		((Control)Label18).TabIndex = 46;
		Label18.Text = "3";
		Label18.TextAlign = (ContentAlignment)32;
		((Control)Label19).Anchor = (AnchorStyles)3;
		((Control)Label19).BackColor = Color.Transparent;
		((Control)Label19).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = Color.White;
		Label label37 = Label19;
		location = new Point(65, 401);
		((Control)label37).Location = location;
		((Control)Label19).Name = "Label19";
		Label label38 = Label19;
		size = new Size(140, 20);
		((Control)label38).Size = size;
		((Control)Label19).TabIndex = 45;
		Label19.Text = "2";
		Label19.TextAlign = (ContentAlignment)32;
		((Control)Label20).Anchor = (AnchorStyles)3;
		((Control)Label20).BackColor = Color.Transparent;
		((Control)Label20).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label20).ForeColor = Color.White;
		Label label39 = Label20;
		location = new Point(791, 520);
		((Control)label39).Location = location;
		((Control)Label20).Name = "Label20";
		Label label40 = Label20;
		size = new Size(140, 20);
		((Control)label40).Size = size;
		((Control)Label20).TabIndex = 56;
		Label20.Text = "13";
		Label20.TextAlign = (ContentAlignment)32;
		((Control)Label21).Anchor = (AnchorStyles)3;
		((Control)Label21).BackColor = Color.Transparent;
		((Control)Label21).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = Color.White;
		Label label41 = Label21;
		location = new Point(645, 520);
		((Control)label41).Location = location;
		((Control)Label21).Name = "Label21";
		Label label42 = Label21;
		size = new Size(140, 20);
		((Control)label42).Size = size;
		((Control)Label21).TabIndex = 55;
		Label21.Text = "12";
		Label21.TextAlign = (ContentAlignment)32;
		((Control)Label22).Anchor = (AnchorStyles)3;
		((Control)Label22).BackColor = Color.Transparent;
		((Control)Label22).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = Color.White;
		Label label43 = Label22;
		location = new Point(503, 520);
		((Control)label43).Location = location;
		((Control)Label22).Name = "Label22";
		Label label44 = Label22;
		size = new Size(140, 20);
		((Control)label44).Size = size;
		((Control)Label22).TabIndex = 54;
		Label22.Text = "11";
		Label22.TextAlign = (ContentAlignment)32;
		((Control)Label23).Anchor = (AnchorStyles)3;
		((Control)Label23).BackColor = Color.Transparent;
		((Control)Label23).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = Color.White;
		Label label45 = Label23;
		location = new Point(357, 520);
		((Control)label45).Location = location;
		((Control)Label23).Name = "Label23";
		Label label46 = Label23;
		size = new Size(140, 20);
		((Control)label46).Size = size;
		((Control)Label23).TabIndex = 53;
		Label23.Text = "10";
		Label23.TextAlign = (ContentAlignment)32;
		((Control)Label24).Anchor = (AnchorStyles)3;
		((Control)Label24).BackColor = Color.Transparent;
		((Control)Label24).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label24).ForeColor = Color.White;
		Label label47 = Label24;
		location = new Point(211, 520);
		((Control)label47).Location = location;
		((Control)Label24).Name = "Label24";
		Label label48 = Label24;
		size = new Size(140, 20);
		((Control)label48).Size = size;
		((Control)Label24).TabIndex = 52;
		Label24.Text = "9";
		Label24.TextAlign = (ContentAlignment)32;
		((Control)Label25).Anchor = (AnchorStyles)3;
		((Control)Label25).BackColor = Color.Transparent;
		((Control)Label25).Font = new Font("Futura Bk BT", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)Label25).ForeColor = Color.White;
		Label label49 = Label25;
		location = new Point(65, 520);
		((Control)label49).Location = location;
		((Control)Label25).Name = "Label25";
		Label label50 = Label25;
		size = new Size(140, 20);
		((Control)label50).Size = size;
		((Control)Label25).TabIndex = 51;
		Label25.Text = "8";
		Label25.TextAlign = (ContentAlignment)32;
		((Control)cbinary).BackColor = Color.DodgerBlue;
		cbinary.Image = (Image)componentResourceManager.GetObject("cbinary.Image");
		PictureBox obj49 = cbinary;
		location = new Point(175, 74);
		((Control)obj49).Location = location;
		((Control)cbinary).Name = "cbinary";
		PictureBox obj50 = cbinary;
		size = new Size(30, 30);
		((Control)obj50).Size = size;
		cbinary.SizeMode = (PictureBoxSizeMode)2;
		cbinary.TabIndex = 57;
		cbinary.TabStop = false;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).BackColor = Color.DodgerBlue;
		cbubblero.Image = (Image)componentResourceManager.GetObject("cbubblero.Image");
		PictureBox obj51 = cbubblero;
		location = new Point(321, 74);
		((Control)obj51).Location = location;
		((Control)cbubblero).Name = "cbubblero";
		PictureBox obj52 = cbubblero;
		size = new Size(30, 30);
		((Control)obj52).Size = size;
		cbubblero.SizeMode = (PictureBoxSizeMode)2;
		cbubblero.TabIndex = 58;
		cbubblero.TabStop = false;
		((Control)cbubblero).Visible = false;
		((Control)cmirax).BackColor = Color.DodgerBlue;
		cmirax.Image = (Image)componentResourceManager.GetObject("cmirax.Image");
		PictureBox obj53 = cmirax;
		location = new Point(613, 74);
		((Control)obj53).Location = location;
		((Control)cmirax).Name = "cmirax";
		PictureBox obj54 = cmirax;
		size = new Size(30, 30);
		((Control)obj54).Size = size;
		cmirax.SizeMode = (PictureBoxSizeMode)2;
		cmirax.TabIndex = 60;
		cmirax.TabStop = false;
		((Control)cmirax).Visible = false;
		((Control)cgreenmix).BackColor = Color.DodgerBlue;
		cgreenmix.Image = (Image)componentResourceManager.GetObject("cgreenmix.Image");
		PictureBox obj55 = cgreenmix;
		location = new Point(467, 74);
		((Control)obj55).Location = location;
		((Control)cgreenmix).Name = "cgreenmix";
		PictureBox obj56 = cgreenmix;
		size = new Size(30, 30);
		((Control)obj56).Size = size;
		cgreenmix.SizeMode = (PictureBoxSizeMode)2;
		cgreenmix.TabIndex = 59;
		cgreenmix.TabStop = false;
		((Control)cgreenmix).Visible = false;
		((Control)cpinkero).BackColor = Color.DodgerBlue;
		cpinkero.Image = (Image)componentResourceManager.GetObject("cpinkero.Image");
		PictureBox obj57 = cpinkero;
		location = new Point(905, 74);
		((Control)obj57).Location = location;
		((Control)cpinkero).Name = "cpinkero";
		PictureBox obj58 = cpinkero;
		size = new Size(30, 30);
		((Control)obj58).Size = size;
		cpinkero.SizeMode = (PictureBoxSizeMode)2;
		cpinkero.TabIndex = 62;
		cpinkero.TabStop = false;
		((Control)cpinkero).Visible = false;
		((Control)corange).BackColor = Color.DodgerBlue;
		corange.Image = (Image)componentResourceManager.GetObject("corange.Image");
		PictureBox obj59 = corange;
		location = new Point(759, 74);
		((Control)obj59).Location = location;
		((Control)corange).Name = "corange";
		PictureBox obj60 = corange;
		size = new Size(30, 30);
		((Control)obj60).Size = size;
		corange.SizeMode = (PictureBoxSizeMode)2;
		corange.TabIndex = 61;
		corange.TabStop = false;
		((Control)corange).Visible = false;
		((Control)cw1).BackColor = Color.DodgerBlue;
		cw1.Image = (Image)componentResourceManager.GetObject("cw1.Image");
		PictureBox obj61 = cw1;
		location = new Point(905, 190);
		((Control)obj61).Location = location;
		((Control)cw1).Name = "cw1";
		PictureBox obj62 = cw1;
		size = new Size(30, 30);
		((Control)obj62).Size = size;
		cw1.SizeMode = (PictureBoxSizeMode)2;
		cw1.TabIndex = 68;
		cw1.TabStop = false;
		((Control)cw1).Visible = false;
		((Control)cwixzelprob).BackColor = Color.DodgerBlue;
		cwixzelprob.Image = (Image)componentResourceManager.GetObject("cwixzelprob.Image");
		PictureBox obj63 = cwixzelprob;
		location = new Point(759, 190);
		((Control)obj63).Location = location;
		((Control)cwixzelprob).Name = "cwixzelprob";
		PictureBox obj64 = cwixzelprob;
		size = new Size(30, 30);
		((Control)obj64).Size = size;
		cwixzelprob.SizeMode = (PictureBoxSizeMode)2;
		cwixzelprob.TabIndex = 67;
		cwixzelprob.TabStop = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cwixzelpro).BackColor = Color.DodgerBlue;
		cwixzelpro.Image = (Image)componentResourceManager.GetObject("cwixzelpro.Image");
		PictureBox obj65 = cwixzelpro;
		location = new Point(613, 190);
		((Control)obj65).Location = location;
		((Control)cwixzelpro).Name = "cwixzelpro";
		PictureBox obj66 = cwixzelpro;
		size = new Size(30, 30);
		((Control)obj66).Size = size;
		cwixzelpro.SizeMode = (PictureBoxSizeMode)2;
		cwixzelpro.TabIndex = 66;
		cwixzelpro.TabStop = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzeldb).BackColor = Color.DodgerBlue;
		cwixzeldb.Image = (Image)componentResourceManager.GetObject("cwixzeldb.Image");
		PictureBox obj67 = cwixzeldb;
		location = new Point(467, 190);
		((Control)obj67).Location = location;
		((Control)cwixzeldb).Name = "cwixzeldb";
		PictureBox obj68 = cwixzeldb;
		size = new Size(30, 30);
		((Control)obj68).Size = size;
		cwixzeldb.SizeMode = (PictureBoxSizeMode)2;
		cwixzeldb.TabIndex = 65;
		cwixzeldb.TabStop = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzeld).BackColor = Color.DodgerBlue;
		cwixzeld.Image = (Image)componentResourceManager.GetObject("cwixzeld.Image");
		PictureBox obj69 = cwixzeld;
		location = new Point(321, 190);
		((Control)obj69).Location = location;
		((Control)cwixzeld).Name = "cwixzeld";
		PictureBox obj70 = cwixzeld;
		size = new Size(30, 30);
		((Control)obj70).Size = size;
		cwixzeld.SizeMode = (PictureBoxSizeMode)2;
		cwixzeld.TabIndex = 64;
		cwixzeld.TabStop = false;
		((Control)cwixzeld).Visible = false;
		((Control)cvibgyor).BackColor = Color.DodgerBlue;
		cvibgyor.Image = (Image)componentResourceManager.GetObject("cvibgyor.Image");
		PictureBox obj71 = cvibgyor;
		location = new Point(175, 190);
		((Control)obj71).Location = location;
		((Control)cvibgyor).Name = "cvibgyor";
		PictureBox obj72 = cvibgyor;
		size = new Size(30, 30);
		((Control)obj72).Size = size;
		cvibgyor.SizeMode = (PictureBoxSizeMode)2;
		cvibgyor.TabIndex = 63;
		cvibgyor.TabStop = false;
		((Control)cvibgyor).Visible = false;
		((Control)cw7).BackColor = Color.DodgerBlue;
		cw7.Image = (Image)componentResourceManager.GetObject("cw7.Image");
		PictureBox obj73 = cw7;
		location = new Point(905, 308);
		((Control)obj73).Location = location;
		((Control)cw7).Name = "cw7";
		PictureBox obj74 = cw7;
		size = new Size(30, 30);
		((Control)obj74).Size = size;
		cw7.SizeMode = (PictureBoxSizeMode)2;
		cw7.TabIndex = 74;
		cw7.TabStop = false;
		((Control)cw7).Visible = false;
		((Control)cw6).BackColor = Color.DodgerBlue;
		cw6.Image = (Image)componentResourceManager.GetObject("cw6.Image");
		PictureBox obj75 = cw6;
		location = new Point(759, 308);
		((Control)obj75).Location = location;
		((Control)cw6).Name = "cw6";
		PictureBox obj76 = cw6;
		size = new Size(30, 30);
		((Control)obj76).Size = size;
		cw6.SizeMode = (PictureBoxSizeMode)2;
		cw6.TabIndex = 73;
		cw6.TabStop = false;
		((Control)cw6).Visible = false;
		((Control)cw5).BackColor = Color.DodgerBlue;
		cw5.Image = (Image)componentResourceManager.GetObject("cw5.Image");
		PictureBox obj77 = cw5;
		location = new Point(613, 308);
		((Control)obj77).Location = location;
		((Control)cw5).Name = "cw5";
		PictureBox obj78 = cw5;
		size = new Size(30, 30);
		((Control)obj78).Size = size;
		cw5.SizeMode = (PictureBoxSizeMode)2;
		cw5.TabIndex = 72;
		cw5.TabStop = false;
		((Control)cw5).Visible = false;
		((Control)cw4).BackColor = Color.DodgerBlue;
		cw4.Image = (Image)componentResourceManager.GetObject("cw4.Image");
		PictureBox obj79 = cw4;
		location = new Point(467, 308);
		((Control)obj79).Location = location;
		((Control)cw4).Name = "cw4";
		PictureBox obj80 = cw4;
		size = new Size(30, 30);
		((Control)obj80).Size = size;
		cw4.SizeMode = (PictureBoxSizeMode)2;
		cw4.TabIndex = 71;
		cw4.TabStop = false;
		((Control)cw4).Visible = false;
		((Control)cw3).BackColor = Color.DodgerBlue;
		cw3.Image = (Image)componentResourceManager.GetObject("cw3.Image");
		PictureBox obj81 = cw3;
		location = new Point(321, 308);
		((Control)obj81).Location = location;
		((Control)cw3).Name = "cw3";
		PictureBox obj82 = cw3;
		size = new Size(30, 30);
		((Control)obj82).Size = size;
		cw3.SizeMode = (PictureBoxSizeMode)2;
		cw3.TabIndex = 70;
		cw3.TabStop = false;
		((Control)cw3).Visible = false;
		((Control)cw2).BackColor = Color.DodgerBlue;
		cw2.Image = (Image)componentResourceManager.GetObject("cw2.Image");
		PictureBox obj83 = cw2;
		location = new Point(175, 308);
		((Control)obj83).Location = location;
		((Control)cw2).Name = "cw2";
		PictureBox obj84 = cw2;
		size = new Size(30, 30);
		((Control)obj84).Size = size;
		cw2.SizeMode = (PictureBoxSizeMode)2;
		cw2.TabIndex = 69;
		cw2.TabStop = false;
		((Control)cw2).Visible = false;
		((Control)cw13).BackColor = Color.DodgerBlue;
		cw13.Image = (Image)componentResourceManager.GetObject("cw13.Image");
		PictureBox obj85 = cw13;
		location = new Point(905, 427);
		((Control)obj85).Location = location;
		((Control)cw13).Name = "cw13";
		PictureBox obj86 = cw13;
		size = new Size(30, 30);
		((Control)obj86).Size = size;
		cw13.SizeMode = (PictureBoxSizeMode)2;
		cw13.TabIndex = 80;
		cw13.TabStop = false;
		((Control)cw13).Visible = false;
		((Control)cw12).BackColor = Color.DodgerBlue;
		cw12.Image = (Image)componentResourceManager.GetObject("cw12.Image");
		PictureBox obj87 = cw12;
		location = new Point(759, 427);
		((Control)obj87).Location = location;
		((Control)cw12).Name = "cw12";
		PictureBox obj88 = cw12;
		size = new Size(30, 30);
		((Control)obj88).Size = size;
		cw12.SizeMode = (PictureBoxSizeMode)2;
		cw12.TabIndex = 79;
		cw12.TabStop = false;
		((Control)cw12).Visible = false;
		((Control)cw11).BackColor = Color.DodgerBlue;
		cw11.Image = (Image)componentResourceManager.GetObject("cw11.Image");
		PictureBox obj89 = cw11;
		location = new Point(613, 427);
		((Control)obj89).Location = location;
		((Control)cw11).Name = "cw11";
		PictureBox obj90 = cw11;
		size = new Size(30, 30);
		((Control)obj90).Size = size;
		cw11.SizeMode = (PictureBoxSizeMode)2;
		cw11.TabIndex = 78;
		cw11.TabStop = false;
		((Control)cw11).Visible = false;
		((Control)cw10).BackColor = Color.DodgerBlue;
		cw10.Image = (Image)componentResourceManager.GetObject("cw10.Image");
		PictureBox obj91 = cw10;
		location = new Point(467, 427);
		((Control)obj91).Location = location;
		((Control)cw10).Name = "cw10";
		PictureBox obj92 = cw10;
		size = new Size(30, 30);
		((Control)obj92).Size = size;
		cw10.SizeMode = (PictureBoxSizeMode)2;
		cw10.TabIndex = 77;
		cw10.TabStop = false;
		((Control)cw10).Visible = false;
		((Control)cw9).BackColor = Color.DodgerBlue;
		cw9.Image = (Image)componentResourceManager.GetObject("cw9.Image");
		PictureBox obj93 = cw9;
		location = new Point(321, 427);
		((Control)obj93).Location = location;
		((Control)cw9).Name = "cw9";
		PictureBox obj94 = cw9;
		size = new Size(30, 30);
		((Control)obj94).Size = size;
		cw9.SizeMode = (PictureBoxSizeMode)2;
		cw9.TabIndex = 76;
		cw9.TabStop = false;
		((Control)cw9).Visible = false;
		((Control)cw8).BackColor = Color.DodgerBlue;
		cw8.Image = (Image)componentResourceManager.GetObject("cw8.Image");
		PictureBox obj95 = cw8;
		location = new Point(175, 427);
		((Control)obj95).Location = location;
		((Control)cw8).Name = "cw8";
		PictureBox obj96 = cw8;
		size = new Size(30, 30);
		((Control)obj96).Size = size;
		cw8.SizeMode = (PictureBoxSizeMode)2;
		cw8.TabIndex = 75;
		cw8.TabStop = false;
		((Control)cw8).Visible = false;
		((Control)defaultclose).BackColor = Color.White;
		defaultclose.Image = (Image)componentResourceManager.GetObject("defaultclose.Image");
		PictureBox obj97 = defaultclose;
		location = new Point(783, 0);
		((Control)obj97).Location = location;
		((Control)defaultclose).Name = "defaultclose";
		PictureBox obj98 = defaultclose;
		size = new Size(51, 34);
		((Control)obj98).Size = size;
		defaultclose.SizeMode = (PictureBoxSizeMode)2;
		defaultclose.TabIndex = 116;
		defaultclose.TabStop = false;
		((Control)defaultclose).Visible = false;
		((Control)hoverclose).BackColor = Color.White;
		hoverclose.Image = (Image)componentResourceManager.GetObject("hoverclose.Image");
		PictureBox obj99 = hoverclose;
		location = new Point(840, 0);
		((Control)obj99).Location = location;
		((Control)hoverclose).Name = "hoverclose";
		PictureBox obj100 = hoverclose;
		size = new Size(51, 34);
		((Control)obj100).Size = size;
		hoverclose.SizeMode = (PictureBoxSizeMode)2;
		hoverclose.TabIndex = 115;
		hoverclose.TabStop = false;
		((Control)hoverclose).Visible = false;
		((Control)clickclose).BackColor = Color.White;
		clickclose.Image = (Image)componentResourceManager.GetObject("clickclose.Image");
		PictureBox obj101 = clickclose;
		location = new Point(897, 0);
		((Control)obj101).Location = location;
		((Control)clickclose).Name = "clickclose";
		PictureBox obj102 = clickclose;
		size = new Size(51, 34);
		((Control)obj102).Size = size;
		clickclose.SizeMode = (PictureBoxSizeMode)2;
		clickclose.TabIndex = 114;
		clickclose.TabStop = false;
		((Control)clickclose).Visible = false;
		PictureBox7.Image = (Image)componentResourceManager.GetObject("PictureBox7.Image");
		PictureBox pictureBox7 = PictureBox7;
		location = new Point(897, 1);
		((Control)pictureBox7).Location = location;
		((Control)PictureBox7).Name = "PictureBox7";
		PictureBox pictureBox8 = PictureBox7;
		size = new Size(51, 34);
		((Control)pictureBox8).Size = size;
		PictureBox7.SizeMode = (PictureBoxSizeMode)2;
		PictureBox7.TabIndex = 118;
		PictureBox7.TabStop = false;
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
		((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
		((Form)this).BackColor = Color.DeepSkyBlue;
		((Control)this).BackgroundImageLayout = (ImageLayout)3;
		size = new Size(1000, 629);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)PictureBox7);
		((Control)this).Controls.Add((Control)(object)defaultclose);
		((Control)this).Controls.Add((Control)(object)hoverclose);
		((Control)this).Controls.Add((Control)(object)clickclose);
		((Control)this).Controls.Add((Control)(object)cw13);
		((Control)this).Controls.Add((Control)(object)cw12);
		((Control)this).Controls.Add((Control)(object)cw11);
		((Control)this).Controls.Add((Control)(object)cw10);
		((Control)this).Controls.Add((Control)(object)cw9);
		((Control)this).Controls.Add((Control)(object)cw8);
		((Control)this).Controls.Add((Control)(object)cw7);
		((Control)this).Controls.Add((Control)(object)cw6);
		((Control)this).Controls.Add((Control)(object)cw5);
		((Control)this).Controls.Add((Control)(object)cw4);
		((Control)this).Controls.Add((Control)(object)cw3);
		((Control)this).Controls.Add((Control)(object)cw2);
		((Control)this).Controls.Add((Control)(object)cw1);
		((Control)this).Controls.Add((Control)(object)cwixzelprob);
		((Control)this).Controls.Add((Control)(object)cwixzelpro);
		((Control)this).Controls.Add((Control)(object)cwixzeldb);
		((Control)this).Controls.Add((Control)(object)cwixzeld);
		((Control)this).Controls.Add((Control)(object)cvibgyor);
		((Control)this).Controls.Add((Control)(object)cpinkero);
		((Control)this).Controls.Add((Control)(object)corange);
		((Control)this).Controls.Add((Control)(object)cmirax);
		((Control)this).Controls.Add((Control)(object)cgreenmix);
		((Control)this).Controls.Add((Control)(object)cbubblero);
		((Control)this).Controls.Add((Control)(object)cbinary);
		((Control)this).Controls.Add((Control)(object)Label20);
		((Control)this).Controls.Add((Control)(object)Label21);
		((Control)this).Controls.Add((Control)(object)Label22);
		((Control)this).Controls.Add((Control)(object)Label23);
		((Control)this).Controls.Add((Control)(object)Label24);
		((Control)this).Controls.Add((Control)(object)Label25);
		((Control)this).Controls.Add((Control)(object)Label14);
		((Control)this).Controls.Add((Control)(object)Label15);
		((Control)this).Controls.Add((Control)(object)Label16);
		((Control)this).Controls.Add((Control)(object)Label17);
		((Control)this).Controls.Add((Control)(object)Label18);
		((Control)this).Controls.Add((Control)(object)Label19);
		((Control)this).Controls.Add((Control)(object)Label8);
		((Control)this).Controls.Add((Control)(object)Label9);
		((Control)this).Controls.Add((Control)(object)Label10);
		((Control)this).Controls.Add((Control)(object)Label11);
		((Control)this).Controls.Add((Control)(object)Label12);
		((Control)this).Controls.Add((Control)(object)Label13);
		((Control)this).Controls.Add((Control)(object)Label6);
		((Control)this).Controls.Add((Control)(object)Label7);
		((Control)this).Controls.Add((Control)(object)Label4);
		((Control)this).Controls.Add((Control)(object)Label5);
		((Control)this).Controls.Add((Control)(object)Label3);
		((Control)this).Controls.Add((Control)(object)Label2);
		((Control)this).Controls.Add((Control)(object)w13);
		((Control)this).Controls.Add((Control)(object)w12);
		((Control)this).Controls.Add((Control)(object)w11);
		((Control)this).Controls.Add((Control)(object)w10);
		((Control)this).Controls.Add((Control)(object)w9);
		((Control)this).Controls.Add((Control)(object)w8);
		((Control)this).Controls.Add((Control)(object)w7);
		((Control)this).Controls.Add((Control)(object)w6);
		((Control)this).Controls.Add((Control)(object)w5);
		((Control)this).Controls.Add((Control)(object)w4);
		((Control)this).Controls.Add((Control)(object)w3);
		((Control)this).Controls.Add((Control)(object)w2);
		((Control)this).Controls.Add((Control)(object)w1);
		((Control)this).Controls.Add((Control)(object)wixzelprob);
		((Control)this).Controls.Add((Control)(object)wixzelpro);
		((Control)this).Controls.Add((Control)(object)wixzeldb);
		((Control)this).Controls.Add((Control)(object)wixzeld);
		((Control)this).Controls.Add((Control)(object)vibgyor);
		((Control)this).Controls.Add((Control)(object)pinkero);
		((Control)this).Controls.Add((Control)(object)orange);
		((Control)this).Controls.Add((Control)(object)mirax);
		((Control)this).Controls.Add((Control)(object)greenmix);
		((Control)this).Controls.Add((Control)(object)bubblero);
		((Control)this).Controls.Add((Control)(object)binary);
		((Control)this).Controls.Add((Control)(object)PictureBox3);
		((Control)this).Controls.Add((Control)(object)Label1);
		((Control)this).Controls.Add((Control)(object)PictureBox2);
		((Control)this).Controls.Add((Control)(object)PictureBox1);
		((Form)this).FormBorderStyle = (FormBorderStyle)0;
		((Control)this).Name = "wallpapers";
		((Form)this).ShowInTaskbar = false;
		((Form)this).StartPosition = (FormStartPosition)1;
		((Form)this).TopMost = true;
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)binary).EndInit();
		((ISupportInitialize)bubblero).EndInit();
		((ISupportInitialize)greenmix).EndInit();
		((ISupportInitialize)mirax).EndInit();
		((ISupportInitialize)orange).EndInit();
		((ISupportInitialize)pinkero).EndInit();
		((ISupportInitialize)w1).EndInit();
		((ISupportInitialize)wixzelprob).EndInit();
		((ISupportInitialize)wixzelpro).EndInit();
		((ISupportInitialize)wixzeldb).EndInit();
		((ISupportInitialize)wixzeld).EndInit();
		((ISupportInitialize)vibgyor).EndInit();
		((ISupportInitialize)w2).EndInit();
		((ISupportInitialize)w3).EndInit();
		((ISupportInitialize)w5).EndInit();
		((ISupportInitialize)w4).EndInit();
		((ISupportInitialize)w7).EndInit();
		((ISupportInitialize)w6).EndInit();
		((ISupportInitialize)w13).EndInit();
		((ISupportInitialize)w12).EndInit();
		((ISupportInitialize)w11).EndInit();
		((ISupportInitialize)w10).EndInit();
		((ISupportInitialize)w9).EndInit();
		((ISupportInitialize)w8).EndInit();
		((ISupportInitialize)cbinary).EndInit();
		((ISupportInitialize)cbubblero).EndInit();
		((ISupportInitialize)cmirax).EndInit();
		((ISupportInitialize)cgreenmix).EndInit();
		((ISupportInitialize)cpinkero).EndInit();
		((ISupportInitialize)corange).EndInit();
		((ISupportInitialize)cw1).EndInit();
		((ISupportInitialize)cwixzelprob).EndInit();
		((ISupportInitialize)cwixzelpro).EndInit();
		((ISupportInitialize)cwixzeldb).EndInit();
		((ISupportInitialize)cwixzeld).EndInit();
		((ISupportInitialize)cvibgyor).EndInit();
		((ISupportInitialize)cw7).EndInit();
		((ISupportInitialize)cw6).EndInit();
		((ISupportInitialize)cw5).EndInit();
		((ISupportInitialize)cw4).EndInit();
		((ISupportInitialize)cw3).EndInit();
		((ISupportInitialize)cw2).EndInit();
		((ISupportInitialize)cw13).EndInit();
		((ISupportInitialize)cw12).EndInit();
		((ISupportInitialize)cw11).EndInit();
		((ISupportInitialize)cw10).EndInit();
		((ISupportInitialize)cw9).EndInit();
		((ISupportInitialize)cw8).EndInit();
		((ISupportInitialize)defaultclose).EndInit();
		((ISupportInitialize)hoverclose).EndInit();
		((ISupportInitialize)clickclose).EndInit();
		((ISupportInitialize)PictureBox7).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void wallpapers_FormClosing(object sender, FormClosingEventArgs e)
	{
		Fade.wallpapersout();
		if (MyProject.Forms.home.app1.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app1).Enabled = false;
		}
		else if (MyProject.Forms.home.app2.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app2).Enabled = false;
		}
		else if (MyProject.Forms.home.app3.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app3).Enabled = false;
		}
		else if (MyProject.Forms.home.app4.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app4).Enabled = false;
		}
		else if (MyProject.Forms.home.app5.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app5).Enabled = false;
		}
		else if (MyProject.Forms.home.app6.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app6).Enabled = false;
		}
		else if (MyProject.Forms.home.app7.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app7).Enabled = false;
		}
		else if (MyProject.Forms.home.app8.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app8).Enabled = false;
		}
		else if (MyProject.Forms.home.app9.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app9).Enabled = false;
		}
		else if (MyProject.Forms.home.app10.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app10).Enabled = false;
		}
		else if (MyProject.Forms.home.app11.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app11).Enabled = false;
		}
		else if (MyProject.Forms.home.app12.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app12).Enabled = false;
		}
		else if (MyProject.Forms.home.app13.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app13).Enabled = false;
		}
		else if (MyProject.Forms.home.app14.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app14).Enabled = false;
		}
		else if (MyProject.Forms.home.app15.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app15).Enabled = false;
		}
		else if (MyProject.Forms.home.app16.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app16).Enabled = false;
		}
		else if (MyProject.Forms.home.app17.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app17).Enabled = false;
		}
		else if (MyProject.Forms.home.app18.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app18).Enabled = false;
		}
		else if (MyProject.Forms.home.app19.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app19).Enabled = false;
		}
		else if (MyProject.Forms.home.app20.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app20).Enabled = false;
		}
		else if (MyProject.Forms.home.app21.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app21).Enabled = false;
		}
		else if (MyProject.Forms.home.app22.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app22).Enabled = false;
		}
		else if (MyProject.Forms.home.app23.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app23).Enabled = false;
		}
		else if (MyProject.Forms.home.app24.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app24).Enabled = false;
		}
		else if (MyProject.Forms.home.app25.Image == MyProject.Forms.appdata.wall.Image)
		{
			MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.noimg.Image;
			((Control)MyProject.Forms.home.app25).Enabled = false;
		}
	}

	private void wallpapers_Load(object sender, EventArgs e)
	{
		PictureBox pictureBox = PictureBox3;
		checked
		{
			Point location = new Point(((Control)this).Width - ((Control)PictureBox3).Width, 0);
			((Control)pictureBox).Location = location;
			PictureBox pictureBox2 = PictureBox7;
			Point location2 = new Point(((Control)PictureBox3).Location.X - ((Control)PictureBox7).Width, ((Control)PictureBox3).Location.Y);
			((Control)pictureBox2).Location = location2;
			if (!((Control)MyProject.Forms.home.app1).Enabled)
			{
				((Control)MyProject.Forms.home.app1).Enabled = true;
				MyProject.Forms.home.app1.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app2).Enabled)
			{
				((Control)MyProject.Forms.home.app2).Enabled = true;
				MyProject.Forms.home.app2.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app3).Enabled)
			{
				((Control)MyProject.Forms.home.app3).Enabled = true;
				MyProject.Forms.home.app3.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app4).Enabled)
			{
				((Control)MyProject.Forms.home.app4).Enabled = true;
				MyProject.Forms.home.app4.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app5).Enabled)
			{
				((Control)MyProject.Forms.home.app5).Enabled = true;
				MyProject.Forms.home.app5.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app6).Enabled)
			{
				((Control)MyProject.Forms.home.app6).Enabled = true;
				MyProject.Forms.home.app6.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app7).Enabled)
			{
				((Control)MyProject.Forms.home.app7).Enabled = true;
				MyProject.Forms.home.app7.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app8).Enabled)
			{
				((Control)MyProject.Forms.home.app8).Enabled = true;
				MyProject.Forms.home.app8.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app9).Enabled)
			{
				((Control)MyProject.Forms.home.app9).Enabled = true;
				MyProject.Forms.home.app9.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app10).Enabled)
			{
				((Control)MyProject.Forms.home.app10).Enabled = true;
				MyProject.Forms.home.app10.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app11).Enabled)
			{
				((Control)MyProject.Forms.home.app11).Enabled = true;
				MyProject.Forms.home.app11.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app12).Enabled)
			{
				((Control)MyProject.Forms.home.app12).Enabled = true;
				MyProject.Forms.home.app12.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app13).Enabled)
			{
				((Control)MyProject.Forms.home.app13).Enabled = true;
				MyProject.Forms.home.app13.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app14).Enabled)
			{
				((Control)MyProject.Forms.home.app14).Enabled = true;
				MyProject.Forms.home.app14.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app15).Enabled)
			{
				((Control)MyProject.Forms.home.app15).Enabled = true;
				MyProject.Forms.home.app15.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app16).Enabled)
			{
				((Control)MyProject.Forms.home.app16).Enabled = true;
				MyProject.Forms.home.app16.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app17).Enabled)
			{
				((Control)MyProject.Forms.home.app17).Enabled = true;
				MyProject.Forms.home.app17.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app18).Enabled)
			{
				((Control)MyProject.Forms.home.app18).Enabled = true;
				MyProject.Forms.home.app18.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app19).Enabled)
			{
				((Control)MyProject.Forms.home.app19).Enabled = true;
				MyProject.Forms.home.app19.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app20).Enabled)
			{
				((Control)MyProject.Forms.home.app20).Enabled = true;
				MyProject.Forms.home.app20.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app21).Enabled)
			{
				((Control)MyProject.Forms.home.app21).Enabled = true;
				MyProject.Forms.home.app21.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app22).Enabled)
			{
				((Control)MyProject.Forms.home.app22).Enabled = true;
				MyProject.Forms.home.app22.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app23).Enabled)
			{
				((Control)MyProject.Forms.home.app23).Enabled = true;
				MyProject.Forms.home.app23.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app24).Enabled)
			{
				((Control)MyProject.Forms.home.app24).Enabled = true;
				MyProject.Forms.home.app24.Image = MyProject.Forms.appdata.wall.Image;
			}
			else if (!((Control)MyProject.Forms.home.app25).Enabled)
			{
				((Control)MyProject.Forms.home.app25).Enabled = true;
				MyProject.Forms.home.app25.Image = MyProject.Forms.appdata.wall.Image;
			}
			Fade.wallpapersin();
		}
	}

	private void binary_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
		((Control)MyProject.Forms.home).BackgroundImage = binary.Image;
		((Control)cbinary).Visible = true;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void bubblero_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
		((Control)MyProject.Forms.home).BackgroundImage = bubblero.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = true;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void greenmix_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
		((Control)MyProject.Forms.home).BackgroundImage = greenmix.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = true;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void mirax_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
		((Control)MyProject.Forms.home).BackgroundImage = mirax.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = true;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void orange_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
		((Control)MyProject.Forms.home).BackgroundImage = orange.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = true;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void pinkero_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
		((Control)MyProject.Forms.home).BackgroundImage = pinkero.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = true;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void vibgyor_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		((Control)MyProject.Forms.home).BackgroundImage = vibgyor.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = true;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
	}

	private void wixzeld_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		((Control)MyProject.Forms.home).BackgroundImage = wixzeld.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = true;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
	}

	private void wixzeldb_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		((Control)MyProject.Forms.home).BackgroundImage = wixzeldb.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = true;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
	}

	private void wixzelpro_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		((Control)MyProject.Forms.home).BackgroundImage = wixzelpro.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = true;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
	}

	private void wixzelprob_Click(object sender, EventArgs e)
	{
		if (((Control)MyProject.Forms.home).BackgroundImage == binary.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\binary.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == bubblero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\bubblero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == greenmix.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\greenmix.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == mirax.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\mirax.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == orange.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\orange.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == pinkero.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\pinkero.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == vibgyor.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\vibgyor.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeld.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeld.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzeldb.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzeldb.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelpro.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelpro.file");
		}
		else if (((Control)MyProject.Forms.home).BackgroundImage == wixzelprob.Image)
		{
			((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file");
		}
		((Control)MyProject.Forms.home).BackgroundImage = wixzelprob.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = true;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
		StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).FileSystem.OpenTextFileWriter(MyProject.Forms.datacontrolroom.main.Text + "\\ProgramData\\WixzelOS\\1.0\\system.wixzel.home\\wallpaper.data\\wixzelprob.file", true);
		streamWriter.WriteLine("#void[if][edited]wixzel[wallpaper]auth");
		streamWriter.Close();
	}

	private void w1_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w1.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = true;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w2_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w2.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = true;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w3_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w3.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = true;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w4_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w4.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = true;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w5_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w5.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = true;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w6_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w6.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = true;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w7_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w7.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = true;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w8_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w8.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = true;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w9_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w9.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = true;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w10_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w10.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = true;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w11_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w11.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = true;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = false;
	}

	private void w12_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w12.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = true;
		((Control)cw13).Visible = false;
	}

	private void w13_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.home).BackgroundImage = w13.Image;
		((Control)cbinary).Visible = false;
		((Control)cbubblero).Visible = false;
		((Control)cgreenmix).Visible = false;
		((Control)cmirax).Visible = false;
		((Control)corange).Visible = false;
		((Control)cpinkero).Visible = false;
		((Control)cvibgyor).Visible = false;
		((Control)cwixzeld).Visible = false;
		((Control)cwixzeldb).Visible = false;
		((Control)cwixzelpro).Visible = false;
		((Control)cwixzelprob).Visible = false;
		((Control)cw1).Visible = false;
		((Control)cw2).Visible = false;
		((Control)cw3).Visible = false;
		((Control)cw4).Visible = false;
		((Control)cw5).Visible = false;
		((Control)cw6).Visible = false;
		((Control)cw7).Visible = false;
		((Control)cw8).Visible = false;
		((Control)cw9).Visible = false;
		((Control)cw10).Visible = false;
		((Control)cw11).Visible = false;
		((Control)cw12).Visible = false;
		((Control)cw13).Visible = true;
	}

	private void PictureBox3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
