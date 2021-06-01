namespace Task5.MegaBitmap
{
    partial class MainForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBoxOutput = new System.Windows.Forms.PictureBox();
            this.pictureBoxInput = new System.Windows.Forms.PictureBox();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.groupBoxPixels = new System.Windows.Forms.GroupBox();
            this.listBoxPixels = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDrawSurface = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxInput)).BeginInit();
            this.panelDraw.SuspendLayout();
            this.groupBoxPixels.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.pictureBoxOutput);
            this.groupBox4.Controls.Add(this.pictureBoxInput);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBox4.Location = new System.Drawing.Point(0, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(663, 332);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вывод";
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(305, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "🡲";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonApplyFilter_Click);
            // 
            // pictureBoxOutput
            // 
            this.pictureBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutput.Location = new System.Drawing.Point(359, 25);
            this.pictureBoxOutput.Name = "pictureBoxOutput";
            this.pictureBoxOutput.Size = new System.Drawing.Size(293, 289);
            this.pictureBoxOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutput.TabIndex = 1;
            this.pictureBoxOutput.TabStop = false;
            // 
            // pictureBoxInput
            // 
            this.pictureBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInput.Location = new System.Drawing.Point(6, 25);
            this.pictureBoxInput.Name = "pictureBoxInput";
            this.pictureBoxInput.Size = new System.Drawing.Size(293, 289);
            this.pictureBoxInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInput.TabIndex = 0;
            this.pictureBoxInput.TabStop = false;
            // 
            // panelDraw
            // 
            this.panelDraw.Controls.Add(this.groupBoxPixels);
            this.panelDraw.Controls.Add(this.groupBoxImage);
            this.panelDraw.Controls.Add(this.groupBox4);
            this.panelDraw.Location = new System.Drawing.Point(12, 12);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1011, 437);
            this.panelDraw.TabIndex = 18;
            // 
            // groupBoxPixels
            // 
            this.groupBoxPixels.Controls.Add(this.listBoxPixels);
            this.groupBoxPixels.Controls.Add(this.listBox1);
            this.groupBoxPixels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.groupBoxPixels.Location = new System.Drawing.Point(684, 3);
            this.groupBoxPixels.Name = "groupBoxPixels";
            this.groupBoxPixels.Size = new System.Drawing.Size(315, 414);
            this.groupBoxPixels.TabIndex = 6;
            this.groupBoxPixels.TabStop = false;
            this.groupBoxPixels.Text = "Первые 50x50 пикселей";
            // 
            // listBoxPixels
            // 
            this.listBoxPixels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxPixels.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listBoxPixels.FormattingEnabled = true;
            this.listBoxPixels.ItemHeight = 18;
            this.listBoxPixels.Location = new System.Drawing.Point(11, 25);
            this.listBoxPixels.Name = "listBoxPixels";
            this.listBoxPixels.Size = new System.Drawing.Size(286, 380);
            this.listBoxPixels.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(540, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 402);
            this.listBox1.TabIndex = 5;
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.button2);
            this.groupBoxImage.Controls.Add(this.button1);
            this.groupBoxImage.Controls.Add(this.button3);
            this.groupBoxImage.Controls.Add(this.buttonDrawSurface);
            this.groupBoxImage.Controls.Add(this.groupBox7);
            this.groupBoxImage.Location = new System.Drawing.Point(6, 341);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(660, 76);
            this.groupBoxImage.TabIndex = 4;
            this.groupBoxImage.TabStop = false;
            this.groupBoxImage.Text = "Изображение: не выбрано";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(270, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "загрузить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonLoadCustomImage_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(143, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "стив";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonLoadSteveImage_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button3.ForeColor = System.Drawing.Color.Cornsilk;
            this.button3.Location = new System.Drawing.Point(397, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "стереть";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonClearImages_Click);
            // 
            // buttonDrawSurface
            // 
            this.buttonDrawSurface.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonDrawSurface.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDrawSurface.Location = new System.Drawing.Point(16, 26);
            this.buttonDrawSurface.Name = "buttonDrawSurface";
            this.buttonDrawSurface.Size = new System.Drawing.Size(111, 38);
            this.buttonDrawSurface.TabIndex = 3;
            this.buttonDrawSurface.Text = "медуза";
            this.buttonDrawSurface.UseVisualStyleBackColor = false;
            this.buttonDrawSurface.Click += new System.EventHandler(this.buttonLoadJellyfish_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(0, 374);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(774, 65);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1055, 453);
            this.Controls.Add(this.panelDraw);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxInput)).EndInit();
            this.panelDraw.ResumeLayout(false);
            this.groupBoxPixels.ResumeLayout(false);
            this.groupBoxImage.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox groupBoxPixels;
        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.ListBox listBoxPixels;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.OpenFileDialog openFileDialog;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxOutput;

        private System.Windows.Forms.PictureBox pictureBoxInput;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button buttonDrawSurface;

        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.GroupBox groupBox7;

        private System.Windows.Forms.Button buttonDrawLine;

        private System.Windows.Forms.Panel panelDraw;


        private System.Windows.Forms.GroupBox groupBox4;

        #endregion
    }
}