﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gInk
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Root Root;
			Root = new Root();

			Root.Run();
		}
	}
}
