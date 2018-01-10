using System;
using System.Windows.Forms;

namespace T576282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            using (DialogForm frm = new DialogForm())
            {
                var res = frm.ShowDialog();
                labelControlResult.Text = res.ToString();
            }
        }
    }
}
