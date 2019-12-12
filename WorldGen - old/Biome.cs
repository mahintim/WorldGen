using System;
using System.Drawing;

namespace WorldGen
{
    class Biome
    {
        const int MIN_SIZE = 25;
        const int MAX_SIZE = 65;

        public Biome(int startX, int startY, Random rand, Bitmap bitmap, int size)
        {
            Color col;
            if (rand.Next(0, 30) != 1)
                col = Color.Green;
            else if (rand.Next(0, 5) != 1)
                col = Color.Yellow;
            else if (rand.Next(0, 3) != 1)
                col = Color.Blue;
            else
                col = Color.White;

            int right = rand.Next(MIN_SIZE, MAX_SIZE * rand.Next(1, 3));
            int left = rand.Next(MIN_SIZE, MAX_SIZE * rand.Next(1, 2));
            int up = rand.Next(MIN_SIZE, (int)(MAX_SIZE * rand.Next(1, 3) * 1.2));
            int down = rand.Next(MIN_SIZE, (int)(MAX_SIZE * rand.Next(1, 3) * 1.2));

            if (col == Color.Blue)
            {
                /* Lakes are usually smaller than other biomes. */
                right /= 3;
                left /= 3;
                up /= 3;
                down /= 3;
            }

            int x1 = startX - left;
            int y1 = startY - down;

            int x2 = startX + right;
            int y2 = startY + up;

            /* Filling the upper part of the biome. */
            FillBiome(startY+1, x1, y1, x2, col, true, rand, bitmap, size);
            /* Filling the lower part of the biome. */
            FillBiome(startY, x1, y2, x2, col, false, rand, bitmap, size);
        }

        private void FillBiome(int startY, int x1, int y2, int x2, Color col, bool isDown, Random rand, Bitmap bitmap, int size)
        {
            int y_cur = startY;
            int x_end = x2;
            int y_end = y2;
            int tmp_x = x1;
            int img_x, img_y;

            while (true)
            {
                if (isDown)
                {
                    if (y_cur <= y_end)
                        break;
                    y_cur--;
                }
                else
                {
                    if (y_cur >= y_end)
                        break;
                    y_cur++;
                }

                int x_cur = tmp_x;
                x_cur += rand.Next(-1, 1);
                x_end += rand.Next(-1, 1);
                if (rand.Next(0, 2) != 1)
                {
                    x_cur += rand.Next(-2, 9);
                    x_end -= rand.Next(-2, 9);
                }

                tmp_x = x_cur;

                while (x_cur < x_end)
                {

                    (img_x, img_y) = World.CheckPoint(x_cur, y_cur, size);
                    bitmap.SetPixel(img_x, img_y, col);
                    x_cur++;
                }


            }
        }
    }
}
