using IronOcr;
using System;
using System.IO;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
namespace OCRn
{
	partial class Form1
	{
		
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImagePath = new TextBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            SelectImage = new Button();
            ConvertToText = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ImagePath
            // 
            ImagePath.Location = new System.Drawing.Point(186, 117);
            ImagePath.Margin = new Padding(1);
            ImagePath.Name = "ImagePath";
            ImagePath.Size = new System.Drawing.Size(531, 27);
            ImagePath.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(886, 157);
            richTextBox1.Margin = new Padding(1);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(607, 641);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(94, 157);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(700, 638);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SelectImage
            // 
            SelectImage.Location = new System.Drawing.Point(394, 66);
            SelectImage.Margin = new Padding(1);
            SelectImage.Name = "SelectImage";
            SelectImage.Size = new System.Drawing.Size(130, 29);
            SelectImage.TabIndex = 3;
            SelectImage.Text = "Select Image";
            SelectImage.UseVisualStyleBackColor = true;
            SelectImage.Click += SelectImage_Click;
            // 
            // ConvertToText
            // 
            ConvertToText.Location = new System.Drawing.Point(1100, 66);
            ConvertToText.Margin = new Padding(1);
            ConvertToText.Name = "ConvertToText";
            ConvertToText.Size = new System.Drawing.Size(143, 29);
            ConvertToText.TabIndex = 3;
            ConvertToText.Text = "Convert to Text";
            ConvertToText.UseVisualStyleBackColor = true;
            ConvertToText.Click += ConvertToText_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1541, 868);
            Controls.Add(ConvertToText);
            Controls.Add(SelectImage);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(ImagePath);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "OCR";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ImagePath;
		private RichTextBox richTextBox1;
		private PictureBox pictureBox1;
		private Button SelectImage;
		private Button ConvertToText;
    }
}
