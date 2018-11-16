using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSplendor());
        }

		/// <summary>
		/// Write with color in the console, this is mainly for logs
		/// </summary>
		/// <param name="msg">The message who want write</param>
		/// <param name="color">The color of text for default is red</param>
		public static void ConsoleColor(string msg, ConsoleColor color = System.ConsoleColor.Red)
		{
			try
			{
				if (msg != null)
				{
					Console.ForegroundColor = color;
					Console.WriteLine(msg);
					Console.ResetColor();
				}
				else
				{
					throw new ArgumentNullException();
				}
			}
			catch(Exception e)
			{
				ConsoleColor(e.Message);
			}
		}
	}

	
}
