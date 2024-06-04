/*
 * Course: PROG2370-23F-Sec1
 * Programmed by : Juhwan Seo [8819123]
 * Revision history:
 *      30-Oct-2023: Project created
 *      3-Dec-2023: Designed forms
 *      3-Dec-2023: Debugging complete
 *      3-Dec-2023: Project complete
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSeoQGame
{
    /// <summary>
    ///  ControlPanelForm is the main form that provides the user interface for controlling the QGame
    /// </summary>
    public partial class ControlPanelForm : Form
    {
        /// <summary>
        /// Constructor for the ControlPanelForm class. Initializes the form components.
        /// </summary>
        public ControlPanelForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDesign_Click(object sender, EventArgs e)
        {
            // Create a new instance of the DesignerForm
            DesignerForm designerForm = new DesignerForm();

            // Show the DesignerForm
            designerForm.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            // Create a new instance of the PlayForm
            PlayForm playForm = new PlayForm();

            // Show the PlayForm
            playForm.Show();
        }
    }
}
