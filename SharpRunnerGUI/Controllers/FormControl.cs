using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestRunnerGUI.Controllers
{
    public class FormControl
    {

        private bool mouseDown;
        private Point lastLocation;

        public void form_MouseDown( object sender, MouseEventArgs e )
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        public void form_MouseMove( object sender, MouseEventArgs e )
        {
            Form currentForm = sender as Form;

            if ( currentForm != null && mouseDown )
            {
                currentForm.Location = new Point( ( currentForm.Location.X - lastLocation.X ) + e.X, ( currentForm.Location.Y - lastLocation.Y ) + e.Y );
                currentForm.Update( );
            }
        }

        public void form_MouseUp( object sender, MouseEventArgs e )
        {
            mouseDown = false;
        }

    }
}
