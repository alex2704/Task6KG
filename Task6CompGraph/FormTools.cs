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

namespace Task6CompGraph
{
    public partial class FormTools : Form
    {
        public static class Data
        {
            public static string Value { get; set; } = "0,1";
            public static int Rotate { get; set; } = 0;
        }
        public FormTools()
        {
            InitializeComponent();
            rotateX_rb.Checked = true;
        }

        private void FormTools_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            this.Location = new Point(w - this.Width, 20);
        }

        private void radioButtonTetraedr_CheckedChanged(object sender, EventArgs e)
        {
            byte flBody = 0;
            if (radioButtonTetraedr.Checked == true)
                flBody = 0;
            if (radioButtonHexaedr.Checked == true)
                flBody = 1;
            if (radioButtonOctaedr.Checked == true)
                flBody = 2;
            if (radioButtonXaxahedron.Checked == true)
                flBody = 3;
            if (radioButtonDodecahedron.Checked == true)
                flBody = 4;
            PlatonBody.body = new Body(flBody);
            FormMain.MyDraw();
        }

        private void rotateBody_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flRotate = false;
            FormMain.MyDraw();
        }

        private void rotateOXYZ_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flRotate = true;
            FormMain.MyDraw();
        }

        private void radioButtonEdge_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flEdge = 0;
            FormMain.MyDraw();
        }

        private void radioButtonFace_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flEdge = 1;
            FormMain.MyDraw();
        }

        private void radioButtonStereo_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.flEdge = 2;
            FormMain.MyDraw();
        }

        private void OXYZ_visible_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.visibleOXYZ = OXYZ_visible.Checked;
            FormMain.MyDraw();
        }

        private void speed_Box_ValueChanged(object sender, EventArgs e)
        {
            Data.Value = speed_Box.Text;
        }
        public void GetRotateVec()
        {
            if (noVector_rb.Checked)
                Data.Rotate = 0;
            if (rotateX_rb.Checked)
                Data.Rotate = 1;
            if (rotateY_rb.Checked)
                Data.Rotate = 2;
            throw new Exception("Вы должны выбрать вектор вращения");
        }

        private void PerspectiveVisible_cb_CheckedChanged(object sender, EventArgs e)
        {
            PlatonBody.visiblePoint = PerspectiveVisible_cb.Checked;
            FormMain.MyDraw();
        }

        private void firstPerspectivePoint_sb_Scroll(object sender, ScrollEventArgs e)
        {
            PlatonBody.Xs = -firstPerspectivePoint_sb.Value / 100d;
            FormMain.MyDraw();
        }

        private void secodPerspectivePoint_sb_Scroll(object sender, ScrollEventArgs e)
        {
            PlatonBody.Zs = secodPerspectivePoint_sb.Value / 100d;
            FormMain.MyDraw();
        }
    }
}
