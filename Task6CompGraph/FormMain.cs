using PolyhedronClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Task6CompGraph.FormTools;

namespace Task6CompGraph
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        public static PlatonBody Platon;
        bool drawing = false;
        private static Graphics g; //поверхность рисования
        public static bool flMove = false;
        MouseEventArgs e0; //Класс, представляющтй данные для события Mouse

        private void FormMain_Load(object sender, EventArgs e)
        {
            MouseWheel += new MouseEventHandler(FormMain_MouseWheel);
            g = CreateGraphics();
            Platon = new PlatonBody(ClientRectangle.Width, ClientRectangle.Height);
        }
        private void FormMain_MouseWheel(object sender, MouseEventArgs e)
        {
            Platon.ChangeWindowXY(e.X, e.Y, e.Delta);
            MyDraw();
        }
        public static void MyDraw()
        {
            Platon.Draw();
            g.DrawImage(Platon.bitmap, Program.formMain.ClientRectangle);
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            MyDraw();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                if (e.Button == MouseButtons.Left)
                {
                    double x = double.Parse(Data.Value) * e.X - ClientRectangle.Width / 2;
                    double y = double.Parse(Data.Value) * e.Y - ClientRectangle.Width / 2;
                    Platon.SetAngle(x, y, Data.Rotate, PlatonBody.flRotate);
                }
                else
                {
                    e0 = e;
                }
                MyDraw();
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }
    }
}
