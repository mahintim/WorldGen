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
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rand = new Random();
                int _seed;

                if (seed.Text == "r")
                    _seed = rand.Next(Int32.MinValue, Int32.MaxValue);
                else
                    _seed = Convert.ToInt32(seed.Text);
                World world = new World(_seed, Convert.ToInt32(groupsNum.Text), Convert.ToInt32(maxBiomesInGroup.Text), 0, Convert.ToInt32(worldSize.Text));

                if (filePath.Text != "-")
                    world.WriteToFile(filePath.Text);

                pictureBox1.Image = world.Bitmap;

                seedLabel.Text = "Seed: " + _seed;
                GC.Collect();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
