using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IconTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Windows icon files|*.ico";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgIcon.ImageLocation = dialog.FileName;
                lblFileName.Text = dialog.SafeFileName;
                this.Icon = new Icon(dialog.FileName);
            }
        }
    }
}
