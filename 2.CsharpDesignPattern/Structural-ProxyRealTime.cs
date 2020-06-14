using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPattern
{
    public interface IImage
    {
        void DisplayImage();
    }
    public class RealImage : IImage
    {
        private string Filename { get; set; }
        public RealImage(string filename)
        {
            Filename = filename;
            LoadImageFromDisk();
        }
        public void LoadImageFromDisk()
        {
            Console.WriteLine("Loading Image : " + Filename);
        }
        public void DisplayImage()
        {
            Console.WriteLine("Displaying Image : " + Filename);
        }
    }
    public class ProxyImage : IImage
    {
        private RealImage realImage = null;
        private string Filename { get; set; }
        public ProxyImage(string filename)
        {
            Filename = filename;
        }
        public void DisplayImage()
        {
            if (realImage == null)
            {
                realImage = new RealImage(Filename);
            }
            realImage.DisplayImage();
        }
    }
    class ProxyRealTime
    {
        static void Main(string[] args)
        {
            IImage Image1 = new ProxyImage("Tiger Image");

            Console.WriteLine("Image1 calling DisplayImage first time :");
            Image1.DisplayImage(); // loading necessary
            Console.WriteLine("Image1 calling DisplayImage second time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine("Image1 calling DisplayImage third time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine();
            IImage Image2 = new ProxyImage("Lion Image");
            Console.WriteLine("Image2 calling DisplayImage first time :");
            Image2.DisplayImage(); // loading necessary
            Console.WriteLine("Image2 calling DisplayImage second time :");
            Image2.DisplayImage(); // loading unnecessary
            Console.ReadKey();
        }
    }
}
