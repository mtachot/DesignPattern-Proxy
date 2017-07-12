using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Classes
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (this.realImage == null)
                this.realImage = new RealImage(fileName);
            this.realImage.Display();
        }
    }
}
