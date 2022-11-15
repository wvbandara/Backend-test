using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Backend_test.Interfaces
{
    public interface IimageProcess
    {
        Byte [] ProcessImage(ImageEntity image);
    }
}
