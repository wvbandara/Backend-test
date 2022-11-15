using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Backend_test
{
    public class ImageEntity
    {
        public string imageLocation { get; set; }
        public bool effect1 { get; set; }
        public bool effect2 { get; set; }
        public bool effect3 { get; set; }
        public double radius { get; set; }
        public double size { get; set; }
    }
}
