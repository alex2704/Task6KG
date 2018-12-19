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

        }

        private void rotateBody_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
