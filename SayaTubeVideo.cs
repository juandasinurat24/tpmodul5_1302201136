using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302201136
{
	internal class SayaTubeVideo
	{

		private int id;
		private string title;
		private int playCount;

		public SayaTubeVideo(string title)
		{
			SetTitle(title);
			this.playCount = 0;



			// Generate angka random antara 55555 dan 99.999
			this.id = new Random().Next(55555, 99999);
		}

		// Set title jika karakter melebihi 100
		public void SetTitle(string title)
		{
			if (title == null) return;
			if (title.Length > 100) return;

			this.title = title;
		}

		// menambah play count dan cek jika parameter diatas dari 10.000.000
		public void IncreasePlayCount(int count)
		{
			int temp = this.playCount;
			try
			{
				if (count > 10000000) return;
				temp = checked(temp + count);
				this.playCount = temp;
			}
			catch (OverflowException ex)
			{
				Console.WriteLine("Angka play count telah melebihi batas!");
			}
		}

		// Print detail video (title, id, play count)
		public void PrintVideoDetails()
		{
			Console.WriteLine(this.title + " (ID: " + this.id + ")" + " has " + this.playCount + " play(s)");
		}
    }
}
