/*
 * Course: PROG2370-23F-Sec1
 * Programmed by : Juhwan Seo [8819123]
 * Revision history:
 *      30-Oct-2023: Project created
 *      3-Dec-2023: Designed forms
 *      3-Dec-2023: Debugging complete
 *      3-Dec-2023: Project complete
 */

using JSeoQGame.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace JSeoQGame
{
    /// <summary>
    ///  DesignerForm is a form that provides the user interface for designing the QGame
    /// </summary>
    public partial class DesignerForm : Form
    {
        // The maximum length of the grid
        private const int MAX_GRID_LENGTH = 8;
        // The size of each cell box in the grid
        private const int CELL_BOX_SIZE = 50;

        private int rows;
        private int cols;

        private bool isDragging = false;
        private bool isGenerated = false;
        private Button selectedTool;
        List<CellBox> grid = new List<CellBox>();

        /// <summary>
        /// Constructor for the DesignerForm class. Initializes the form components.
        /// </summary>
        public DesignerForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Event handler for the 'Close' menu item click event. Closes the form.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }

        /// <summary>
        /// Generate a new level after the validation.
        /// </summary>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // If the user doesn't enter any values,
            if (string.IsNullOrEmpty(txtRows.Text) || string.IsNullOrEmpty(txtCols.Text))
            {
                // Show an error messageBox
                MessageBox.Show("Rows and Cols values must be entered.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If they are integer values, run next code.
            if (int.TryParse(txtRows.Text, out rows) && int.TryParse(txtCols.Text, out cols))
            {
                // If they are in the proper range, run next code.
                if (rows >= 1 && rows <= MAX_GRID_LENGTH && cols >= 1 && cols <= MAX_GRID_LENGTH)
                {
                    // If the user clicks the "Generate" button in the middle of a level design, 
                    if (isGenerated)
                    {
                        // show a MessageBox asking the user if they want to cancel current level and start a new one.
                        DialogResult result = MessageBox.Show(
                        "Are you sure you want to delete the current level and generate a new level?",
                        "Confirm New Level",
                        MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        // If the user selects 'Yes', 
                        if (result == DialogResult.Yes)
                        {
                            // the existing grid on the screen is removed manually.
                            foreach (CellBox cell in grid)
                            {
                                pnlGameBoard.Controls.Remove(cell);
                            }
                            grid.Clear();

                            // Generate a new grid.
                            GenerateGrid(rows, cols);
                        }
                    }
                    else
                    {
                        // Generate a new grid.
                        GenerateGrid(rows, cols);
                        // Change the condition of the 'isGenerated'
                        isGenerated = true;
                    }
                }
                else
                {
                    // If they are not in the proper range, show an error messageBox
                    MessageBox.Show($"Rows and Cols must be positive values between 1 and {MAX_GRID_LENGTH}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                // If they are not integer values, show an error messageBox
                MessageBox.Show("Rows and Cols values must be integer type values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /// <summary>
        /// When the user selects a tool, sets the selectedTool variable. 
        /// </summary>
        private void ToolButtons_Click(object sender, EventArgs e)
        {
            selectedTool = (Button)sender;
        }

        /// <summary>
        /// Update the image and tool type of a cell box.
        /// </summary>
        /// <param name="cellbox">The cell box to be updated.</param>
        private void UpdateCellBoxes (CellBox cellbox)
        {
            // Update cell boxes's Image
            // Images are assigned through resources
            switch (selectedTool.ImageIndex)
            {
                // “None” tool which has index number 0 will empty a cell
                case 0:
                    cellbox.Image = null;
                    break;
                case 1:
                    cellbox.Image = Properties.Resources.wall;
                    break;
                case 2:
                    cellbox.Image = Properties.Resources.red_door;
                    break;
                case 3:
                    cellbox.Image = Properties.Resources.green_door;
                    break;
                case 4:
                    cellbox.Image = Properties.Resources.red_box;
                    break;
                case 5:
                    cellbox.Image = Properties.Resources.green_box;
                    break;
            }

            // Update cell boxes's tool type
            cellbox.ToolType = (CellBox.CellBoxToolType)selectedTool.ImageIndex;
        }

        /// <summary>
        /// Event handler for mouse down event on cell boxes.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CellBoxes_MouseDown(object sender, EventArgs e)
        {
            if (selectedTool == null)
            {
                MessageBox.Show("Please select a tool", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            isDragging = true;
            ((CellBox)sender).Capture = false;
            UpdateCellBoxes((CellBox)sender);
        }

        /// <summary>
        /// Event handler for mouse enter event on cell boxes.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CellBoxes_MouseEnter(object sender, EventArgs e)
        {
            if (isDragging)
            {
                UpdateCellBoxes((CellBox)sender);
            }
        }

        /// <summary>
        /// Event handler for mouse up event on cell boxes.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CellBoxes_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        /// <summary>
        /// Event handler for mouse enter event on the form.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DesignerForm_MouseEnter(object sender, EventArgs e)
		{
            if (isDragging)
            {
	    		isDragging = false;
            }
		}


        /// <summary>
        /// This evenet handler allows the user to save the current level to a file.
        /// </summary>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to allow the user to select a location and name for the save file
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the filter to only show .qgame files
            saveFileDialog.Filter = "QGame Files (*.qgame)|*.qgame";

            // Show the SaveFileDialog and continue if the user clicks 'OK'
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Initialize counters for the number of walls, doors, and boxes
                int walls = 0;
                int doors = 0;
                int boxes = 0;

                // Create a StreamWriter to write to the save file
                StreamWriter writer = new StreamWriter(filePath);

                // Write the number of rows
                writer.WriteLine(rows);
                // Write the number of cols
                writer.WriteLine(cols);

                // Write the information of the cells
                foreach (CellBox cell in grid)
                {
                    writer.WriteLine(cell.Row);
                    writer.WriteLine(cell.Col);
                    writer.WriteLine((int)cell.ToolType);

                    // Increment the counters
                    switch (cell.ToolType)
                    {
                        case CellBox.CellBoxToolType.Wall:
                            walls++;
                            break;
                        case CellBox.CellBoxToolType.RedDoor:
                        case CellBox.CellBoxToolType.GreenDoor:
                            doors++;
                            break;
                        case CellBox.CellBoxToolType.RedBox:
                        case CellBox.CellBoxToolType.GreenBox:
                            boxes++;
                            break;
                    }
                }
                // Close the StreamWriter
                writer.Close();

                // Show essageBox after saving (with the number of walls, doors, boxes)
                MessageBox.Show($"File saved successfully!\n\nTotal number of walls: {walls}\nTotal number of doors: {doors}\nTotal number of boxes: {boxes}", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Dynamically generates a grid for the game level design.
        /// </summary>
        /// <param name="rows">The number of rows in the grid.</param>
        /// <param name="cols">The number of columns in the grid.</param>
        private void GenerateGrid(int rows, int cols)
        {
            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= cols; col++)
                {
                    // Create a new CellBox object
                    CellBox cell = new CellBox
                    {
                        // Set the row and column properties
                        Row = row,
                        Col = col,
                        // Initialize the tool type to 0 (None)
                        ToolType = 0,
                        Name = $"cellBox{row}{col}",
                        Size = new Size(CELL_BOX_SIZE, CELL_BOX_SIZE),
                        Location = new Point(
                            (pnlGameBoard.Width - cols * CELL_BOX_SIZE) / 2 + (col - 1) * CELL_BOX_SIZE,
                            (pnlGameBoard.Height - rows * CELL_BOX_SIZE) / 2 + (row - 1) * CELL_BOX_SIZE),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    // Add event handlers to the created cell
                    cell.MouseDown += CellBoxes_MouseDown;
                    cell.MouseEnter += CellBoxes_MouseEnter;
                    cell.MouseUp += CellBoxes_MouseUp;

                    // Add the cell box to the game board panel
                    pnlGameBoard.Controls.Add(cell);

                    // Add the cell box object to the grid list
                    grid.Add(cell);
                }
            }
        }
	}
}
