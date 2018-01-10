using System;
using System.Windows.Forms;

namespace T576282
{
    public class ControlPatcher<T> where T : Control
    {
        Action<T> _ProcessControlAction;
        public ControlPatcher(Action<T> processControlAction)
        {
            _ProcessControlAction = processControlAction;
        }
        public void ProcessContainer(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is T)
                {
                    ProcessControl(control);
                }
                else
                    ProcessContainer(control);
            }
        }
        private void ProcessControl(object control)
        {
            _ProcessControlAction(control as T);
        }
    }
}
