using System;
using System.Drawing;

namespace WorldGen
{
    class Village
    {
        public Village(Random rand, Bitmap bitmap, int worldSize)
        {
            int startX = rand.Next(0, worldSize);
            int startY = rand.Next(0, worldSize);
            Color col = bitmap.GetPixel(startX, startY);
            if (col.R != Color.Green.R || col.G != Color.Green.G || col.B != Color.Green.B)
                return;

            bitmap.SetPixel(startX, startY, Color.Red);
        }
    }
}
