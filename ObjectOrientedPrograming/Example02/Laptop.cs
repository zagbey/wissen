using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Laptop:Product
    {
        //oto property için prop yazmak yeterli
        //full property için propfull

        public string OperatingSystem { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }

        // İsimlendirme standartı önerisi;
        // Normalde bilgisayar belleği anlamına gelen Random Access Memory kelimelerinin
        // Kısaltması RAM şeklinde yazılır. Ancak kodlamada bu kısaltmayı Ram şeklinde
        // görmeniz mümkün.
        // Her iki standart da yaygın kullanılır
        public int Ram { get; set; }
        public string Cpu { get; set; }
        public int CpuHertz { get; set; }
    }
}
