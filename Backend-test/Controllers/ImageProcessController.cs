using Backend_test.Implementation;
using Backend_test.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Backend_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageProcessController : ControllerBase
    {
        private IimageProcess _iimageProcess;

        public ImageProcessController(IimageProcess iimageProcess)
        {
            _iimageProcess = iimageProcess;
        }

        [HttpPost]
        [Route("ImageProcess")]
        public Byte[] ImageProcess(ImageEntity imageEntity)
        {
            return _iimageProcess.ProcessImage(imageEntity);
        }

    }
}
