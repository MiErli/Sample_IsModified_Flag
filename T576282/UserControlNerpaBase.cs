using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace T576282
{
    public partial class UserControlNerpaBase : UserControl
    {
        public UserControlNerpaBase()
        {
            InitializeComponent();

            this.Load += UserControlNerpaBase_Load;
        }

        private void UserControlNerpaBase_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            new ControlPatcher<BaseEdit>((edit) => edit.Validating += Edit_Validating).ProcessContainer(this);
            this.FindForm().FormClosing += UserControlNerpaBase_FormClosing;
        }

        List<Control> controlsWithUpdatedValues = new List<Control>();

        void Edit_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as BaseEdit;
            if (!e.Cancel && edit.IsModified && !controlsWithUpdatedValues.Contains(edit))
                controlsWithUpdatedValues.Add(edit);
        }

        private void UserControlNerpaBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (controlsWithUpdatedValues.Count == 0)
            {
                MessageBox.Show("No changes");
                return;
            }

            var controls = string.Empty;
            foreach (var control in controlsWithUpdatedValues)
                controls += control.Name + Environment.NewLine;

            MessageBox.Show(controls);
        }
    }
}
