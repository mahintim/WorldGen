using System;
using System.Drawing;
using System.IO;

namespace WorldGen
{
    class World
    {
        public readonly Bitmap bitmap;

        public World(int seed, int size, double persistence, int octaves, double scaleX, double scaleY, double heightCoefficient, double[] biomesHeights, Color[] biomesColors)
        {
            Perlin noise = new Perlin();
            Random rand = new Random(seed);

            bitmap = new Bitmap(size, size);

            double z = rand.NextDouble() * 10;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    double p = noise.OctavePerlin(i / (double)size * scaleX, j / (double)size * scaleY, z, octaves, persistence) * heightCoefficient - 0.1;
                    Color col;

                    if (p < biomesHeights[0])
                        col = biomesColors[0];
                    else if (p < biomesHeights[1])
                        col = biomesColors[1];
                    else if (p < biomesHeights[2])
                        col = biomesColors[2];
                    else if (p < biomesHeights[3])
                        col = biomesColors[3];
                    else if (p < biomesHeights[4])
                        col = biomesColors[4];
                    else if (p < biomesHeights[5])
                        col = biomesColors[5];
                    else if (p < biomesHeights[6])
                        col = biomesColors[6];
                    else 
                        col = biomesColors[7];

                    bitmap.SetPixel(i, j, col);
                }
        }

        public void WriteToFile(string filePath)
        {
            bitmap.Save(filePath);
        }
    }
}
