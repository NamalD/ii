using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ii
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form1();

            if (args.Any())
            {
                var imgBox = (PictureBox) form.Controls.Find("imgBox", false)[0];
                var image = Image.FromFile(args[0]);
                imgBox.Image = image;
            }

            Application.Run(form);
        }
    }
}