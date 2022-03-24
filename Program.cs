using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302201136
{
    internal class Program
    {
        static void Main(string[] args)
        {
			
			SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Juanda Sinurat");
			video.IncreasePlayCount(460);
			video.PrintVideoDetails();

		}

    }
}
