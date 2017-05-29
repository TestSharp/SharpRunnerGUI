using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TestRunnerGUI.Controllers
{
    public class ButtonControl
    {
        public void SwitchForeAndBackButtonColors( Button button )
        {
            Color currentBackColor = button.BackColor;
            Color currentForeColor = button.ForeColor;

            button.BackColor = currentForeColor;
            button.ForeColor = currentBackColor;
        }

        public void controlButtons_MouseEnter( object sender, EventArgs e )
        {
            Button button = sender as Button;

            if ( button != null )
            {
                SwitchForeAndBackButtonColors( button );
            }
        }

        public void controlButtons_MouseLeave( object sender, EventArgs e )
        {
            Button button = sender as Button;

            if ( button != null )
            {
                SwitchForeAndBackButtonColors( button );
            }
        }

        public void SwitchBackTabColorsToDefault( Dictionary<Button, Color> tabButtonsDictionaryForeColor, Dictionary<Button, Color> tabButtonsDictionaryBackColor )
        {
            foreach( KeyValuePair<Button, Color> currentTabButton in tabButtonsDictionaryForeColor )
            {
                currentTabButton.Key.ForeColor = currentTabButton.Value;
            }

            foreach( KeyValuePair<Button, Color> currentTabButton in tabButtonsDictionaryBackColor )
            {
                currentTabButton.Key.BackColor = currentTabButton.Value;
            }
        }

    }
}
