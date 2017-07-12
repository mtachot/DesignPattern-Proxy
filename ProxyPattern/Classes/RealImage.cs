using ProxyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Classes
{
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            LoadFromDisk(fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine(String.Format("Loading {0}...", fileName));
        }

        public void Display()
        {
            Console.WriteLine(String.Format("Displaying {0}...", this.fileName));
        }
    }
}
