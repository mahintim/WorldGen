namespace WorldGen
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.groupsNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seed = new System.Windows.Forms.TextBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxBiomesInGroup = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.worldSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate world";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupsNum
            // 
            this.groupsNum.Location = new System.Drawing.Point(12, 23);
            this.groupsNum.Name = "groupsNum";
            this.groupsNum.Size = new System.Drawing.Size(100, 20);
            this.groupsNum.TabIndex = 1;
            this.groupsNum.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Biome groups number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seed (put `r` for random seed)";
            // 
            // seed
            // 
            this.seed.Location = new System.Drawing.Point(12, 105);
            this.seed.Name = "seed";
            this.seed.Size = new System.Drawing.Size(100, 20);
            this.seed.TabIndex = 8;
            this.seed.Text = "r";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 144);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(100, 20);
            this.filePath.TabIndex = 9;
            this.filePath.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "File path (put `-` to don\'t save image to file)";
            // 
            // maxBiomesInGroup
            // 
            this.maxBiomesInGroup.Location = new System.Drawing.Point(12, 65);
            this.maxBiomesInGroup.Name = "maxBiomesInGroup";
            this.maxBiomesInGroup.Size = new System.Drawing.Size(100, 20);
            this.maxBiomesInGroup.TabIndex = 11;
            this.maxBiomesInGroup.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Maximal number of biomes in group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(224, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 726);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(9, 723);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(10, 13);
            this.seedLabel.TabIndex = 14;
            this.seedLabel.Text = " ";
            // 
            // worldSize
            // 
            this.worldSize.Location = new System.Drawing.Point(12, 186);
            this.worldSize.Name = "worldSize";
            this.worldSize.Size = new System.Drawing.Size(100, 20);
            this.worldSize.TabIndex = 17;
            this.worldSize.Text = "500";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Size of the world";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 745);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.worldSize);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxBiomesInGroup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.seed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupsNum);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1146, 784);
            this.MinimumSize = new System.Drawing.Size(1146, 784);
            this.Name = "Form1";
            this.Text = "Random world generator by MahinTim";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox groupsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seed;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxBiomesInGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox worldSize;
        private System.Windows.Forms.Label label3;
    }
}

