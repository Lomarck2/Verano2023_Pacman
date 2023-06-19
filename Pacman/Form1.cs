using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Bitmap FullSprite = new Bitmap(@"resources\FullSprite.png");
        Bitmap[] imgPacman = new Bitmap[6];

        Rectangle recPacMan = new Rectangle(100, 100, 42, 42);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imgPacman[0] = CargarImagen(FullSprite, 15, 14, 05, 538);
            imgPacman[1] = CargarImagen(FullSprite, 15, 14, 21, 538);
            imgPacman[2] = CargarImagen(FullSprite, 15, 14, 37, 538);
            imgPacman[3] = CargarImagen(FullSprite, 14, 14, 37, 538);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgPacman[2], recPacMan);
        }

        Bitmap CargarImagen(Bitmap origen, int ancho, int alto, int OrigenX, int OrigenY)
        {
            Bitmap imagen = new Bitmap(ancho, alto);
            for (int x = 0; x < ancho; x++)
            {
                for (int y = 0; y < alto; y++)
                {
                    Color info = origen.GetPixel(x + OrigenX, y + OrigenY);
                    imagen.SetPixel(x, y, info);
                }
            }
            return imagen;
        }
    }
}
