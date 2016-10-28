using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoFileSurroundPlayer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
           

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            NAudio.Gui.VolumeMeter meter = new NAudio.Gui.VolumeMeter();

            meter.Paint += new PaintEventHandler(this.MainWindow_Paint);

        }

        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            // Create a local version of the graphics object for the PictureBox.
            Graphics g = e.Graphics;
            ImageConverter conv;
          
            Point p = e.ClipRectangle.Location;
            

            //g.DrawImage(i, p);
            
            // Draw a line in the PictureBox.
            g.DrawLine(Pens.Red, Left, Top,
                Right, Bottom);
        }
    }
}
