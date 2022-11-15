using Backend_test.Interfaces;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Backend_test.Implementation
{
    public class ImageProcess : IimageProcess
    {
       
        public Byte [] ProcessImage(ImageEntity imageEntity)
        {
            try
            {
                Byte[] image = File.ReadAllBytes(imageEntity.imageLocation);
                if (imageEntity.effect1)
                {
                    //code to adding effect1
                }
                if (imageEntity.effect2)
                {
                    //code to adding effect2
                }
                if (imageEntity.effect2)
                {
                    //code to adding effect3
                }
                if (imageEntity.radius > 0)
                {
                    //change radius of image
                }
                if (imageEntity.size > 0)
                {
                    //change size of image
                }

                return image;
            }
            catch (Exception)
            {

                throw;
            }
        
        }
    }
}
