using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlesnaSkola.WinUI.Helper
{
    public class SlikaHelper
    {
        public static byte[] getDefaultSlika()
        {
            Image slika = Properties.Resources.default_pic;
            var stream = new MemoryStream();
            slika.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }
    }
}
