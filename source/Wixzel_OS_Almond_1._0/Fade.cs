using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Wixzel_OS_Almond_1._0.My;

namespace Wixzel_OS_Almond_1._0;

[StandardModule]
internal sealed class Fade
{
	public static void calculatorin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.calculator).Opacity = num;
			((Control)MyProject.Forms.calculator).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void calculatorout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.calculator).Opacity = num;
			((Control)MyProject.Forms.calculator).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void aboutin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.about).Opacity = num;
			((Control)MyProject.Forms.about).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void aboutout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.about).Opacity = num;
			((Control)MyProject.Forms.about).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void calendarin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.calendar).Opacity = num;
			((Control)MyProject.Forms.calendar).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void calendarout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.calendar).Opacity = num;
			((Control)MyProject.Forms.calendar).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void camerain()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.camera).Opacity = num;
			((Control)MyProject.Forms.camera).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void cameraout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.camera).Opacity = num;
			((Control)MyProject.Forms.camera).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void clockin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.clock).Opacity = num;
			((Control)MyProject.Forms.clock).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void clockout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.clock).Opacity = num;
			((Control)MyProject.Forms.clock).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void commanderin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.commander).Opacity = num;
			((Control)MyProject.Forms.commander).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void commanderout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.commander).Opacity = num;
			((Control)MyProject.Forms.commander).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void dialogin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.dialog).Opacity = num;
			((Control)MyProject.Forms.dialog).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void dialogout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.dialog).Opacity = num;
			((Control)MyProject.Forms.dialog).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void filesin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.files).Opacity = num;
			((Control)MyProject.Forms.files).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void filesout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.files).Opacity = num;
			((Control)MyProject.Forms.files).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void lockscreenbackin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.lockscreenback).Opacity = num;
			((Control)MyProject.Forms.lockscreenback).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void lockscreenbackout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.lockscreenback).Opacity = num;
			((Control)MyProject.Forms.lockscreenback).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void meebrowserin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meebrowser).Opacity = num;
			((Control)MyProject.Forms.meebrowser).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void meebrowserout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meebrowser).Opacity = num;
			((Control)MyProject.Forms.meebrowser).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void meemailin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meemail).Opacity = num;
			((Control)MyProject.Forms.meemail).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void meemailout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meemail2).Opacity = num;
			((Control)MyProject.Forms.meemail2).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void meemail2in()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meemail2).Opacity = num;
			((Control)MyProject.Forms.meemail2).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void meemail2out()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meemail2).Opacity = num;
			((Control)MyProject.Forms.meemail2).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void meemail3in()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meemail3).Opacity = num;
			((Control)MyProject.Forms.meemail3).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void meemail3out()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.meemail3).Opacity = num;
			((Control)MyProject.Forms.meemail3).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void ncodein()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.ncode).Opacity = num;
			((Control)MyProject.Forms.ncode).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void ncodeout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.ncode).Opacity = num;
			((Control)MyProject.Forms.ncode).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void paintainin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.paintain).Opacity = num;
			((Control)MyProject.Forms.paintain).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void paintainout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.paintain).Opacity = num;
			((Control)MyProject.Forms.paintain).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void passwordin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.password).Opacity = num;
			((Control)MyProject.Forms.password).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void passwordout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.password).Opacity = num;
			((Control)MyProject.Forms.password).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void screenlitin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.screenlit).Opacity = num;
			((Control)MyProject.Forms.screenlit).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void screenlitout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.screenlit).Opacity = num;
			((Control)MyProject.Forms.screenlit).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void screenshotin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.screenshot).Opacity = num;
			((Control)MyProject.Forms.screenshot).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void screenshotout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.screenshot).Opacity = num;
			((Control)MyProject.Forms.screenshot).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void ttsin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.tts).Opacity = num;
			((Control)MyProject.Forms.tts).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void ttsout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.tts).Opacity = num;
			((Control)MyProject.Forms.tts).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void updatesin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.updates).Opacity = num;
			((Control)MyProject.Forms.updates).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void updatesout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.updates).Opacity = num;
			((Control)MyProject.Forms.updates).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void vboardin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.vboard).Opacity = num;
			((Control)MyProject.Forms.vboard).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void vboardout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.vboard).Opacity = num;
			((Control)MyProject.Forms.vboard).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void wallpapersin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.wallpapers).Opacity = num;
			((Control)MyProject.Forms.wallpapers).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void wallpapersout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.wallpapers).Opacity = num;
			((Control)MyProject.Forms.wallpapers).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void weatherin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.weather).Opacity = num;
			((Control)MyProject.Forms.weather).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void weatherout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.weather).Opacity = num;
			((Control)MyProject.Forms.weather).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void winexein()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.winexe).Opacity = num;
			((Control)MyProject.Forms.winexe).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void winexeout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.winexe).Opacity = num;
			((Control)MyProject.Forms.winexe).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void wordproin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.wordpro).Opacity = num;
			((Control)MyProject.Forms.wordpro).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void wordproout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.wordpro).Opacity = num;
			((Control)MyProject.Forms.wordpro).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void diskmanagementin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.diskmanagement).Opacity = num;
			((Control)MyProject.Forms.diskmanagement).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void diskmanagementout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.diskmanagement).Opacity = num;
			((Control)MyProject.Forms.diskmanagement).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}

	public static void settingsin()
	{
		double num = 0.0;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.settings).Opacity = num;
			((Control)MyProject.Forms.settings).Refresh();
			Thread.Sleep(100);
			num += 0.5;
			num2 = num;
			num3 = 1.1;
		}
		while (num2 <= num3);
	}

	public static void settingsout()
	{
		double num = 1.1;
		double num2;
		double num3;
		do
		{
			((Form)MyProject.Forms.settings).Opacity = num;
			((Control)MyProject.Forms.settings).Refresh();
			Thread.Sleep(100);
			num += -0.7;
			num2 = num;
			num3 = 0.0;
		}
		while (num2 >= num3);
	}
}
