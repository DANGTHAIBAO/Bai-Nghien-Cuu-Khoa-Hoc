using IronOcr;
using iText.IO.Image;
using System.Windows.Forms;

namespace OCRn
{
	public partial class Form1 : Form
	{	
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void SelectImage_Click(object sender, EventArgs e)
		{
			{
				OpenFileDialog open = new OpenFileDialog();
				// image filters  
				open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp ; *.png";
				if (open.ShowDialog() == DialogResult.OK)
				{
					// display image in picture box  
					pictureBox1.Image = new Bitmap(open.FileName);
					// image file path  
					ImagePath.Text = open.FileName;
				}
			}
		}

		private void ConvertToText_Click(object sender, EventArgs e)
		{
			IronTesseract IronOcr = new IronTesseract();
			IronOcr.Language = OcrLanguage.Vietnamese;
			var Result = IronOcr.Read(ImagePath.Text);
			richTextBox1.Text = Result.Text;

		}
	}
}