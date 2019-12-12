using System;
using System.Drawing;
using System.IO;

namespace WorldGen
{
    class World
    {
        readonly private int seed;
        readonly Random rand;
        public Bitmap Bitmap
        {
            get; private set;
        }
        const int BIOME_MIN_SIZE = 25;
        const int BIOME_MAX_SIZE = 65;

        public World(int seed, int groupsNum, int biosmesInGroupMax, int villagesNum, int size)
        {
            this.seed = seed;
            rand = new Random(seed);
            Perlin perlin = new Perlin(rand.Next(Int32.MinValue, Int32.MaxValue));
            Bitmap = new Bitmap(size, size);

            Graphics g = Graphics.FromImage(Bitmap);
            g.Clear(Color.Blue);

            /*for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    double p = perlin.eval(i / (double)size * 20, j / (double)size * 20, 5);
                    Color col;

                    if (p < -0.1)
                        col = Color.DarkBlue;
                    else if (p < 0.1)
                        col = Color.Blue;
                    else if (p < 0.25)
                        col = Color.GreenYellow;
                    else if (p < 0.8)
                        col = Color.ForestGreen;
                    else
                        col = Color.White;

                    Bitmap.SetPixel(i, j, col);
                }


            */
            for (int i = 0; i < groupsNum; i++)
            {
                int x = rand.Next(0, size);
                int y = rand.Next(0, size);
                for (int j = 0; j < biosmesInGroupMax * rand.Next(1, 3); j++)
                    new Biome(x + (j * rand.Next(-(BIOME_MIN_SIZE + BIOME_MAX_SIZE) / 6, (BIOME_MIN_SIZE + BIOME_MAX_SIZE) / 6)), y + (j * rand.Next(-(BIOME_MIN_SIZE + BIOME_MAX_SIZE) / 6, (BIOME_MIN_SIZE + BIOME_MAX_SIZE) / 6)), rand, Bitmap, size);
            }


        }

        public static (int, int) CheckPoint(int x, int y, int size)
        {
            int x1 = x, y1 = y;
            if (x < 0)
                x1 = 0;
            else if (x >= size)
                x1 = size - 1;

            if (y < 0)
                y1 = 0;
            else if (y >= size)
                y1 = size - 1;

            return (x1, y1);
        }

        public void WriteToFile(string filePath)
        {
            Bitmap.Save(filePath);
        }
    }
}
