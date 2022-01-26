using System;

namespace ProxyDesignPattern
{
    //Subject
    interface IImageGenerator
    {
        void ShowImage();
    }
    class ImageGenerator : IImageGenerator
    {
        private string _fullPath;
        public ImageGenerator(string fullPath)
        {
            _fullPath = fullPath;
        }
        public void ShowImage()
        {
            Console.WriteLine("{0} image is showing",_fullPath);
        }
    }

    class ImageGeneratorProxy : IImageGenerator
    {
        private ImageGenerator _imageGenerator;
        private string _fullPath;
        public ImageGeneratorProxy(string fullPath)
        {
            _fullPath = fullPath;
        }
        public void ShowImage()
        {
            if(_imageGenerator == null)
            {
                _imageGenerator = new ImageGenerator(_fullPath);
            }
            _imageGenerator.ShowImage();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ImageGeneratorProxy proxy1 = new ImageGeneratorProxy("c://image1.jpg");
            ImageGeneratorProxy proxy2 = new ImageGeneratorProxy("c://image2.jpg");

            proxy1.ShowImage();
            proxy2.ShowImage();
            proxy1.ShowImage();

        }
    }
}
