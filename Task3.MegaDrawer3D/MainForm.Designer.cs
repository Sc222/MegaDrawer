﻿namespace MegaAnimator
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
            this.panelDrawCanvas = new System.Windows.Forms.Panel();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonDrawSurface = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDrawSphere = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDrawSpiral = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.panelDraw.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panelDrawCanvas);
            this.groupBox4.Location = new System.Drawing.Point(279, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 332);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Вывод";
            // 
            // panelDrawCanvas
            // 
            this.panelDrawCanvas.BackColor = System.Drawing.Color.White;
            this.panelDrawCanvas.Location = new System.Drawing.Point(6, 25);
            this.panelDrawCanvas.Name = "panelDrawCanvas";
            this.panelDrawCanvas.Size = new System.Drawing.Size(450, 292);
            this.panelDrawCanvas.TabIndex = 0;
            // 
            // panelDraw
            // 
            this.panelDraw.Controls.Add(this.groupBox8);
            this.panelDraw.Controls.Add(this.groupBox6);
            this.panelDraw.Controls.Add(this.groupBox3);
            this.panelDraw.Controls.Add(this.groupBox1);
            this.panelDraw.Controls.Add(this.groupBox4);
            this.panelDraw.Location = new System.Drawing.Point(12, 18);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(747, 663);
            this.panelDraw.TabIndex = 18;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button8);
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Controls.Add(this.button6);
            this.groupBox8.Controls.Add(this.button4);
            this.groupBox8.Controls.Add(this.button5);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Location = new System.Drawing.Point(4, 252);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(268, 190);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Куб";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button8.ForeColor = System.Drawing.Color.Cornsilk;
            this.button8.Location = new System.Drawing.Point(146, 81);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 38);
            this.button8.TabIndex = 8;
            this.button8.Text = "движение";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonMoveCube_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button7.ForeColor = System.Drawing.Color.Cornsilk;
            this.button7.Location = new System.Drawing.Point(146, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 38);
            this.button7.TabIndex = 7;
            this.button7.Text = "масштаб";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonScaleCube_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.ForeColor = System.Drawing.Color.Cornsilk;
            this.button6.Location = new System.Drawing.Point(16, 81);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "вращать";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonRotateCube_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button4.ForeColor = System.Drawing.Color.Cornsilk;
            this.button4.Location = new System.Drawing.Point(16, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "стереть";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonEraseCube_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.ForeColor = System.Drawing.Color.Cornsilk;
            this.button5.Location = new System.Drawing.Point(15, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 38);
            this.button5.TabIndex = 3;
            this.button5.Text = "нарисовать";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonDrawCube_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Location = new System.Drawing.Point(0, 374);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(774, 65);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.buttonDrawSurface);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Location = new System.Drawing.Point(4, 169);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(268, 77);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Поверхность";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button3.ForeColor = System.Drawing.Color.Cornsilk;
            this.button3.Location = new System.Drawing.Point(146, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 38);
            this.button3.TabIndex = 5;
            this.button3.Text = "стереть";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonEraseSurface_Click);
            // 
            // buttonDrawSurface
            // 
            this.buttonDrawSurface.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDrawSurface.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDrawSurface.Location = new System.Drawing.Point(16, 26);
            this.buttonDrawSurface.Name = "buttonDrawSurface";
            this.buttonDrawSurface.Size = new System.Drawing.Size(111, 38);
            this.buttonDrawSurface.TabIndex = 3;
            this.buttonDrawSurface.Text = "нарисовать";
            this.buttonDrawSurface.UseVisualStyleBackColor = false;
            this.buttonDrawSurface.Click += new System.EventHandler(this.buttonDrawSurface_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(0, 374);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(774, 65);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttonDrawSphere);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(4, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 77);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сфера";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.ForeColor = System.Drawing.Color.Cornsilk;
            this.button2.Location = new System.Drawing.Point(146, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "стереть";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonEraseSphere_Click);
            // 
            // buttonDrawSphere
            // 
            this.buttonDrawSphere.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDrawSphere.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDrawSphere.Location = new System.Drawing.Point(15, 26);
            this.buttonDrawSphere.Name = "buttonDrawSphere";
            this.buttonDrawSphere.Size = new System.Drawing.Size(111, 38);
            this.buttonDrawSphere.TabIndex = 3;
            this.buttonDrawSphere.Text = "нарисовать";
            this.buttonDrawSphere.UseVisualStyleBackColor = false;
            this.buttonDrawSphere.Click += new System.EventHandler(this.buttonDrawSphere_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(0, 374);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(774, 65);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonDrawSpiral);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спираль";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(146, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "стереть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonEraseSpiral_Click);
            // 
            // buttonDrawSpiral
            // 
            this.buttonDrawSpiral.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonDrawSpiral.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonDrawSpiral.Location = new System.Drawing.Point(16, 26);
            this.buttonDrawSpiral.Name = "buttonDrawSpiral";
            this.buttonDrawSpiral.Size = new System.Drawing.Size(111, 38);
            this.buttonDrawSpiral.TabIndex = 3;
            this.buttonDrawSpiral.Text = "нарисовать";
            this.buttonDrawSpiral.UseVisualStyleBackColor = false;
            this.buttonDrawSpiral.Click += new System.EventHandler(this.buttonDrawSpiral_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(770, 698);
            this.Controls.Add(this.panelDraw);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox4.ResumeLayout(false);
            this.panelDraw.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button8;

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox9;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button buttonDrawSpiral;

        private System.Windows.Forms.Button buttonDrawSphere;

        private System.Windows.Forms.Button buttonDrawSurface;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;

        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;

        private System.Windows.Forms.Panel panelDraw;


        private System.Windows.Forms.Panel panelDrawCanvas;

        private System.Windows.Forms.GroupBox groupBox4;

        #endregion
    }
}