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
    }
}
