using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinFormsApp
{
    public partial class frmOpenImg : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new("Resource\\haarcascade\\haarcascade_frontalface_alt_tree.xml");
        public frmOpenImg()
        {
            InitializeComponent();
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new() { Multiselect = false, Filter = "JPEG|*.jpg" })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Bitmap bitmap = new(Image.FromFile(ofd.FileName));

                    ///*
                    //Image<Bgr, byte> grayImage = new();
                    //ImageConverter converter = new ImageConverter();
                    //Image<Bgr, byte> grayImage = (Image<Bgr, byte>)converter.ConvertTo(Image.FromFile(ofd.FileName), typeof(Image<Bgr, byte>));
                    //var a = new Image<Bgr, byte>(bitmap);

                    //Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(bitmap);
                    //Image<Bgr, byte> emguImage = bitmap.ToImage<Bgr, byte>();
                    //Image<Bgr, byte> img = bitmap.ToImage<Bgr, byte>();
                    //Image<Bgr, Byte> myImage = new Image<Bgr, byte>();
                    //var img = new Image<Bgr, byte>(ofd.FileName);
                    //Emgu.CV.Image<Bgr, byte> grayImage = bitmap.as;
                    //picImagem.Image = bitmap
                    //var image = new Image<Bgr, Byte>(new Bitmap(picImagem.Image));
                    //Image<Bgr, Byte> IMG = new Image<Bgr, byte>((Bitmap)bitmap);
                    //Image<Bgr, Byte> grayImage = new Image<Bgr, Byte>(ofd.FileName);

                    //BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
                    //Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap.Width, bitmap.Height, bitmapData.Stride, bitmapData.Scan0);

                    Image<Bgr, byte> grayImage = new Image<Bgr, byte>(ofd.FileName);

                    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.1, 1);

                    foreach (var rectangle in rectangles)
                    {
                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            using (Pen pen = new(Color.Blue, 1))
                            {
                                graphics.DrawRectangle(pen, rectangle);
                            }
                        }
                    }

                    picImagem.Image = bitmap;// Image.FromFile(ofd.FileName);
                }
            }

        }
    }
}