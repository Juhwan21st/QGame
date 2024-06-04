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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSeoQGame
{
    /// <summary>
    /// The CellBox class, which inherits from PictureBox, represents a cell in the QGame grid.
    /// </summary>
    internal class CellBox : PictureBox
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public CellBoxToolType ToolType { get; set; }


        /// <summary>
        /// Enum for the different types of tools a cell box can represent.
        /// </summary>
        public enum CellBoxToolType
        {
            None,       // 0
            Wall,       // 1
            RedDoor,    // 2
            GreenDoor,  // 3
            RedBox,     // 4
            GreenBox    // 5
        }

    }
}
