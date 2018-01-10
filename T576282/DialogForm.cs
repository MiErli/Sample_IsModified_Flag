using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T576282 {
    public partial class DialogForm : Form {
        public DialogForm() {
            InitializeComponent();

            this.FormClosed += DialogForm_FormClosed;

        }

        private void DialogForm_FormClosed(object sender, FormClosedEventArgs e) {
            //
        }
         
        
        
        private void DialogForm_Load(object sender, EventArgs e)
        {
            FormClosing += DialogForm_FormClosing;
            btnOK.Click += BtnOK_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void DialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (DialogResult == DialogResult.Cancel)
            {
                if (userControlCustomerEdit1.IsModified())
                {
                    var res = MessageBox.Show("Wollen Sie die Änderungen speichern?", "Close", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (res == DialogResult.Cancel)
                        e.Cancel = true;
                }
            }


        }
    }
}
