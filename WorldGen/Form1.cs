using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldGen
{
    public partial class Form1 : Form
    {
        private World world;

        public Form1()
        {
            
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] biomesHeights = new double[8];
                biomesHeights[0] = Convert.ToDouble(biome1TextBox.Text);
                biomesHeights[1] = Convert.ToDouble(biome2TextBox.Text);
                biomesHeights[2] = Convert.ToDouble(biome3TextBox.Text);
                biomesHeights[3] = Convert.ToDouble(biome4TextBox.Text);
                biomesHeights[4] = Convert.ToDouble(biome5TextBox.Text);
                biomesHeights[5] = Convert.ToDouble(biome6TextBox.Text);
                biomesHeights[6] = Convert.ToDouble(biome7TextBox.Text);
                biomesHeights[7] = Convert.ToDouble(biome8TextBox.Text);

                Color[] biomesColors = new Color[8];
                biomesColors[0] = Color.FromArgb(Convert.ToInt32(r1TextBox.Text), Convert.ToInt32(g1TextBox.Text), Convert.ToInt32(b1TextBox.Text));
                biomesColors[1] = Color.FromArgb(Convert.ToInt32(r2TextBox.Text), Convert.ToInt32(g2TextBox.Text), Convert.ToInt32(b2TextBox.Text));
                biomesColors[2] = Color.FromArgb(Convert.ToInt32(r3TextBox.Text), Convert.ToInt32(g3TextBox.Text), Convert.ToInt32(b3TextBox.Text));
                biomesColors[3] = Color.FromArgb(Convert.ToInt32(r4TextBox.Text), Convert.ToInt32(g4TextBox.Text), Convert.ToInt32(b4TextBox.Text));
                biomesColors[4] = Color.FromArgb(Convert.ToInt32(r5TextBox.Text), Convert.ToInt32(g5TextBox.Text), Convert.ToInt32(b5TextBox.Text));
                biomesColors[5] = Color.FromArgb(Convert.ToInt32(r6TextBox.Text), Convert.ToInt32(g6TextBox.Text), Convert.ToInt32(b6TextBox.Text));
                biomesColors[6] = Color.FromArgb(Convert.ToInt32(r7TextBox.Text), Convert.ToInt32(g7TextBox.Text), Convert.ToInt32(b7TextBox.Text));
                biomesColors[7] = Color.FromArgb(Convert.ToInt32(r8TextBox.Text), Convert.ToInt32(g8TextBox.Text), Convert.ToInt32(b8TextBox.Text));

                Random rand = new Random();
                int seed;

                if (seedTextBox.Text == "r")
                    seed = rand.Next(Int32.MinValue, Int32.MaxValue);
                else
                    seed = Convert.ToInt32(seedTextBox.Text);
                world = new World(seed, Convert.ToInt32(sizeTextBox.Text), Convert.ToDouble(persistenceTextBox.Text), Convert.ToInt32(octavesTextBox.Text), Convert.ToDouble(scaleXTextBox.Text), Convert.ToDouble(scaleYTextBox.Text), Convert.ToDouble(heightTextBox.Text), biomesHeights, biomesColors);

                if (putSeedCheckBox.Checked)
                {
                    Graphics gr = Graphics.FromImage(world.bitmap);
                    gr.DrawString("seed: " + seed, new Font(FontFamily.GenericMonospace, 9, FontStyle.Regular), new SolidBrush(Color.Black), 3, 3);
                }

                pictureBox1.Image = world.bitmap;

                GC.Collect();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResistenceTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (filePathTextBox.Text != "-")
                    world.WriteToFile(filePathTextBox.Text);
                else
                    MessageBox.Show("Put file path before saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void forestPresetButton_Click(object sender, EventArgs e)
        {
            r1TextBox.Text = "0";
            r2TextBox.Text = "0";
            r3TextBox.Text = "0";
            r4TextBox.Text = "0";
            r5TextBox.Text = "0";
            r6TextBox.Text = "33";
            r7TextBox.Text = "22";
            r8TextBox.Text = "16";

            g1TextBox.Text = "0";
            g2TextBox.Text = "0";
            g3TextBox.Text = "0";
            g4TextBox.Text = "128";
            g5TextBox.Text = "100";
            g6TextBox.Text = "80";
            g7TextBox.Text = "64";
            g8TextBox.Text = "48";

            b1TextBox.Text = "101";
            b2TextBox.Text = "139";
            b3TextBox.Text = "255";
            b4TextBox.Text = "0";
            b5TextBox.Text = "0";
            b6TextBox.Text = "0";
            b7TextBox.Text = "0";
            b8TextBox.Text = "0";

            biome8TextBox.Text = "1.35";
        }

        private void snowPresetButton_Click(object sender, EventArgs e)
        {
            r1TextBox.Text = "0";
            r2TextBox.Text = "0";
            r3TextBox.Text = "0";
            r4TextBox.Text = "185";
            r5TextBox.Text = "220";
            r6TextBox.Text = "240";
            r7TextBox.Text = "250";
            r8TextBox.Text = "255";

            g1TextBox.Text = "0";
            g2TextBox.Text = "0";
            g3TextBox.Text = "0";
            g4TextBox.Text = "185";
            g5TextBox.Text = "220";
            g6TextBox.Text = "240";
            g7TextBox.Text = "250";
            g8TextBox.Text = "255";

            b1TextBox.Text = "101";
            b2TextBox.Text = "139";
            b3TextBox.Text = "255";
            b4TextBox.Text = "255";
            b5TextBox.Text = "255";
            b6TextBox.Text = "255";
            b7TextBox.Text = "255";
            b8TextBox.Text = "255";

            biome8TextBox.Text = "2";
        }

        private void desertPresetButton_Click(object sender, EventArgs e)
        {
            r1TextBox.Text = "0";
            r2TextBox.Text = "0";
            r3TextBox.Text = "0";
            r4TextBox.Text = "250";
            r5TextBox.Text = "220";
            r6TextBox.Text = "190";
            r7TextBox.Text = "160";
            r8TextBox.Text = "130";

            g1TextBox.Text = "0";
            g2TextBox.Text = "0";
            g3TextBox.Text = "0";
            g4TextBox.Text = "250";
            g5TextBox.Text = "220";
            g6TextBox.Text = "190";
            g7TextBox.Text = "160";
            g8TextBox.Text = "130";

            b1TextBox.Text = "101";
            b2TextBox.Text = "139";
            b3TextBox.Text = "255";
            b4TextBox.Text = "100";
            b5TextBox.Text = "100";
            b6TextBox.Text = "100";
            b7TextBox.Text = "100";
            b8TextBox.Text = "100";

            biome8TextBox.Text = "1.9";
        }
    }
}
