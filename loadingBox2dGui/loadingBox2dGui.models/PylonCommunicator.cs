using Basler.Pylon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public class PylonCommunicator
    {
        Camera _camera1;
        Camera _camera2;

        public PylonCommunicator()
        {
            _camera1 = new Camera();
            ConnectCamera(_camera1);
            StartCamera(_camera1);

        }

        public bool ConnectCamera(Camera camera)
        {
            camera.Open();
            return true;
        }
        public bool SetCameraSettings(Camera camera)
        {
            return true;
        }
        public bool StartCamera(Camera camera)
        {
            camera.StreamGrabber.Start();
            IGrabResult grabResult = camera.StreamGrabber.RetrieveResult(1000, TimeoutHandling.ThrowException);
            if (grabResult.GrabSucceeded)
            {
                Console.WriteLine("SizeX: {0}", grabResult.Width);
                Console.WriteLine("SizeY: {0}", grabResult.Height);
                SaveImage(grabResult);
            }
            return true;
        }

        public bool SaveImage(IGrabResult grabResult)
        {
            string filePath = "output_image.png";
            //bmp.Save(filePath, ImageFormat.Png);
            return true;
        }
    }
}
