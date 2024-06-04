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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JSeoQGame.CellBox;

namespace JSeoQGame
{
    /// <summary>
    ///  PlayForm is a form that provides the user interface for playing the QGame.
    /// </summary>
    public partial class PlayForm : Form
    {
        // The size of each cell box in the grid
        private const int CELL_BOX_SIZE = 50;

        private int rows;
        private int cols;

        List<CellBox> grid = new List<CellBox>();

        CellBox selectedCellBox;
        int numberOfMoves = 0;
        int numberOfRemainingBoxes = 0;
        private bool isLoaded = false;

        /// <summary>
        /// Constructor for the PlayForm class. Initializes the form components.
        /// PlayForm 클래스의 생성자. 폼 컴포넌트를 초기화합니다.
        /// </summary>
        public PlayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the 'Close' menu item click event. Closes the form.
        /// '닫기' 메뉴 항목 클릭 이벤트에 대한 이벤트 핸들러입니다. 양식을 닫습니다.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }

        /// <summary>
        /// Event handler for the 'Load' menu item click event. Loads a game from a .qgame file.
        /// '로드' 메뉴 항목 클릭 이벤트에 대한 이벤트 핸들러입니다. .qgame 파일에서 게임을 로드합니다.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoaded)
            {
                // 만약 게임이 이미 로드되어있는데 또 새로운 걸 불러오려고 시도한다면 컨펌을 받는 메세지 창이 떠
                DialogResult result = MessageBox.Show(
                        "Are you sure you want to cancle the current game and load a new game?",
                        "QGame",
                        MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                // If the user selects 'Yes', 
                if (result == DialogResult.Yes)
                {
                    // the existing grid on the screen is removed manually.
                    // 화면의 기존 그리드가 수동으로 제거됩니다.
                    foreach (CellBox cell in grid)
                    {
                        pnlGameBoard.Controls.Remove(cell);
                    }
                    grid.Clear();

                    numberOfMoves = 0;
                    numberOfRemainingBoxes = 0;
                    txtMoves.Text = numberOfMoves.ToString();
                    txtRemainingBoxes.Text = numberOfRemainingBoxes.ToString();

                }
                else
                {
                    return;
                }
            }
            // Create an OpenFileDialog to allow the user to select a file to load
            // 사용자가 로드할 파일을 선택할 수 있도록 OpenFileDialog를 생성합니다.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to only show .qgame files
            // .qgame 파일만 표시하도록 필터를 설정합니다.
            openFileDialog.Filter = "QGame Files (*.qgame)|*.qgame";

            // Show the OpenFileDialog and continue if the user clicks 'OK'
            // 사용자가 '확인'을 클릭하면 OpenFileDialog를 표시하고 계속 진행합니다.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Create a StreamReader to read from the save file
                StreamReader reader = new StreamReader(filePath);

                // Read the number of rows and columns from the save file
                // 저장 파일에서 행과 열의 개수를 읽습니다.
                rows = int.Parse(reader.ReadLine());
                cols = int.Parse(reader.ReadLine());

                // Initialize the assignedToolType array
                // 'assignedToolType' 배열을 초기화합니다.
                int[,] assignedToolType = new int[rows + 1, cols + 1];

                // Read the information of the cells
                for (int i = 1; i <= rows * cols; i++)
                {
                    int row = int.Parse(reader.ReadLine());
                    int col = int.Parse(reader.ReadLine());
                    int toolType = int.Parse(reader.ReadLine());
                    if (toolType == 4 || toolType == 5)
                    {
                        numberOfRemainingBoxes++;
                    }
                    // Store the tool type in the assignedToolType array
                    // 도구 유형을 'assignedToolType' 배열에 저장합니다.
                    assignedToolType[row, col] = toolType;
                }

                // Close the StreamReader
                reader.Close();

                // Load the grid with the read rows, cols, and assignedToolType
                // 읽은 행, 열, 할당된 도구 유형으로 그리드를 로드합니다.
                LoadGrid(rows, cols, assignedToolType);

                isLoaded = true;
                if (numberOfMoves != 0)
                {
                    numberOfMoves = 0;
                }
                txtMoves.Text = numberOfMoves.ToString();
                txtRemainingBoxes.Text = numberOfRemainingBoxes.ToString();
            }
        }

        /// <summary>
        /// Loads the grid with the specified number of rows and columns, and assigns the tool type to each cell.
        /// /// 지정된 행과 열 수로 그리드를 로드하고 각 셀에 도구 유형을 할당합니다.
        /// </summary>
        /// <param name="rows">The number of rows in the grid.</param>
        /// <param name="cols">The number of columns in the grid.</param>
        /// <param name="assignedToolType">A 2D array representing the tool type assigned to each cell in the grid.</param>
        private void LoadGrid(int rows, int cols, int[,] assignedToolType)
        {
            for (int row = 1; row <= rows; row++)
            {
                for (int col = 1; col <= cols; col++)
                {
                    CellBox cell = new CellBox
                    {
                        Row = row,
                        Col = col,
                        ToolType = (CellBox.CellBoxToolType)assignedToolType[row, col],

                        Name = $"cellBox{row}{col}",
                        Size = new Size(CELL_BOX_SIZE, CELL_BOX_SIZE),
                        Location = new Point(
                            (pnlGameBoard.Width - cols * CELL_BOX_SIZE) / 2 + (col - 1) * CELL_BOX_SIZE,
                            (pnlGameBoard.Height - rows * CELL_BOX_SIZE) / 2 + (row - 1) * CELL_BOX_SIZE),
                        BorderStyle = BorderStyle.FixedSingle,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    // Update the cell box's image based on its tool type
                    // Images are assigned through resources
                    // 도구 유형에 따라 셀 박스의 이미지를 업데이트합니다.
                    // 이미지는 리소스를 통해 할당됩니다.
                    switch (cell.ToolType)
                    {
                        case CellBox.CellBoxToolType.None:
                            cell.Image = null;
                            break;
                        case CellBox.CellBoxToolType.Wall:
                            cell.Image = Properties.Resources.wall;
                            break;
                        case CellBox.CellBoxToolType.RedDoor:
                            cell.Image = Properties.Resources.red_door;
                            break;
                        case CellBox.CellBoxToolType.GreenDoor:
                            cell.Image = Properties.Resources.green_door;
                            break;
                        case CellBox.CellBoxToolType.RedBox:
                            cell.Image = Properties.Resources.red_box;
                            break;
                        case CellBox.CellBoxToolType.GreenBox:
                            cell.Image = Properties.Resources.green_box;
                            break;
                    }

                    // Add event handlers to the created cell
                    // 생성된 셀에 이벤트 핸들러 추가
                    cell.Click += CellBoxes_Click;

                    // Add the cell box to the game board panel
                    // 게임 보드 패널에 셀 상자 추가하기
                    pnlGameBoard.Controls.Add(cell);

                    // Add the cell box object to the grid list
                    // 그리드 목록에 셀 상자 객체를 추가합니다.
                    grid.Add(cell);
                }
            }
        }

        /// <summary>
        /// Event handler for the click event of the cell boxes.
        /// 셀 박스의 클릭 이벤트에 대한 이벤트 핸들러입니다.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void CellBoxes_Click(object sender, EventArgs e)
        {
            if (((CellBox)sender).ToolType == CellBoxToolType.RedBox || ((CellBox)sender).ToolType == CellBoxToolType.GreenBox)
            {
                selectedCellBox = (CellBox)sender;
            }
        }

        /// <summary>
        /// Event handler for the click event of the arrow buttons.
        /// 화살표 버튼의 클릭 이벤트에 대한 이벤트 핸들러입니다.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">The event arguments.</param>
        private void ArrowButtons_Click(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                // 게임이 로드 되지않았는데 누르면 로드부터 해달라고 메세지 창 뜸
                MessageBox.Show("Please load a game first", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // If the controller is clicked without selecting a box, notify the user by a MessageBox.
            // 상자를 선택하지 않고 컨트롤러를 클릭하면 메시지 상자로 사용자에게 알립니다.
            if (selectedCellBox == null)
            {
                MessageBox.Show("Please select a cell box", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int row = selectedCellBox.Row;
            int col = selectedCellBox.Col;
            int toolType = (int)selectedCellBox.ToolType;
            int newRow = row;
            int newCol = col;
            string cellBoxName = "";
            CellBox retrieviedCellBox = null;

            CellBoxToolType InitialType = (CellBox.CellBoxToolType)0;

            // Get the name of the cell box at the current position
            // 현재 위치의 셀 상자 이름을 가져옵니다.
            string currentCellBoxName = $"cellBox{row}{col}";

            // Update the tool type and image of the current cell box
            // 현재 셀 박스의 도구 유형과 이미지를 업데이트합니다.
            (pnlGameBoard.Controls[currentCellBoxName] as CellBox).ToolType = InitialType;
            UpdateCellBoxes(pnlGameBoard.Controls[currentCellBoxName] as CellBox);

            switch (((Button)sender).Text)
            {
                case "Up":
                    for (int r = row - 1; r >= 1; r--)
                    {
                        cellBoxName = $"cellBox{r}{col}";
                        retrieviedCellBox = pnlGameBoard.Controls[cellBoxName] as CellBox;
                        if ((retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)2 && toolType == 4) || (retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)3 && toolType == 5))
                        {
                            selectedCellBox = null;
                            break;
                        }
                        if (retrieviedCellBox.ToolType != (CellBox.CellBoxToolType)0)
                        {
                            break;
                        }
                        newRow = r;
                    }
                    break;
                case "Down":
                    for (int r = row + 1; r <= rows; r++)
                    {
                        cellBoxName = $"cellBox{r}{col}";
                        retrieviedCellBox = pnlGameBoard.Controls[cellBoxName] as CellBox;
                        if ((retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)2 && toolType == 4) || (retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)3 && toolType == 5))
                        {
                            selectedCellBox = null;
                            break;
                        }
                        if (retrieviedCellBox.ToolType != (CellBox.CellBoxToolType)0)
                        {
                            break;
                        }
                        newRow = r;
                    }
                    break;
                case "Left":
                    for (int c = col - 1; c >= 1; c--)
                    {
                        cellBoxName = $"cellBox{row}{c}";
                        retrieviedCellBox = pnlGameBoard.Controls[cellBoxName] as CellBox;
                        if ((retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)2 && toolType == 4) || (retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)3 && toolType == 5))
                        {
                            selectedCellBox = null;
                            break;
                        }
                        if (retrieviedCellBox.ToolType != (CellBox.CellBoxToolType)0)
                        {
                            break;
                        }
                        newCol = c;
                    }
                    break;
                case "Right":
                    for (int c = col + 1; c <= cols; c++)
                    {
                        cellBoxName = $"cellBox{row}{c}";
                        retrieviedCellBox = pnlGameBoard.Controls[cellBoxName] as CellBox;
                        if ((retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)2 && toolType == 4) || (retrieviedCellBox.ToolType == (CellBox.CellBoxToolType)3 && toolType == 5))
                        {
                            selectedCellBox = null;
                            break;
                        }
                        if (retrieviedCellBox.ToolType != (CellBox.CellBoxToolType)0)
                        {
                            break;
                        }
                        newCol = c;
                    }
                    break;
            }

            numberOfMoves++;
            txtMoves.Text = numberOfMoves.ToString();

            if (selectedCellBox != null)
            {
                // Get the name of the cell box at the new position
                // 새 위치의 셀 상자 이름을 가져옵니다.
                string newCellBoxName = $"cellBox{newRow}{newCol}";
                selectedCellBox = pnlGameBoard.Controls[newCellBoxName] as CellBox;
                // Update the tool type and image of the new cell box
                // 새 셀 상자의 도구 유형 및 이미지 업데이트하기
                selectedCellBox.ToolType = (CellBox.CellBoxToolType)toolType;
                UpdateCellBoxes(selectedCellBox);
            }
            else
            {
                numberOfRemainingBoxes--;
                txtRemainingBoxes.Text = numberOfRemainingBoxes.ToString();
                
                if (numberOfRemainingBoxes == 0)
                {
                    // When all boxes are removed show game end message on a MessageBox
                    // 모든 상자가 제거되면 메시지 상자에 게임 종료 메시지를 표시합니다.
                    MessageBox.Show("Congratulations!\nGame End", "QGame", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // remove all the remaining walls and doors
                    // 나머지 벽과 문을 모두 제거합니다.
                    foreach (CellBox cell in grid)
                    {
                        pnlGameBoard.Controls.Remove(cell);
                    }
                    grid.Clear();

                    isLoaded = false;

                    // Reset moves
                    numberOfMoves = 0;
                    txtMoves.Text = numberOfMoves.ToString();
                }
            }
        }

        /// <summary>
        /// Updates the specified cell box.
        /// 지정된 셀 상자를 업데이트합니다.
        /// </summary>
        /// <param name="cellbox">The cell box to be updated. 업데이트할 셀 상자입니다.</param>
        private void UpdateCellBoxes(CellBox cellbox)
        {
            // Update cell boxes's Image
            // Images are assigned through resources
            // 셀 박스의 이미지 업데이트
            // 이미지는 리소스를 통해 할당됩니다.
            switch (cellbox.ToolType)
            {
                // “None” tool which has index number 0 will empty a cell
                // 인덱스 번호가 0인 "없음" 도구는 셀을 비웁니다.
                case (CellBox.CellBoxToolType)0:
                    cellbox.Image = null;
                    break;
                case (CellBox.CellBoxToolType)1:
                    cellbox.Image = Properties.Resources.wall;
                    break;
                case (CellBox.CellBoxToolType)2:
                    cellbox.Image = Properties.Resources.red_door;
                    break;
                case (CellBox.CellBoxToolType)3:
                    cellbox.Image = Properties.Resources.green_door;
                    break;
                case (CellBox.CellBoxToolType)4:
                    cellbox.Image = Properties.Resources.red_box;
                    break;
                case (CellBox.CellBoxToolType)5:
                    cellbox.Image = Properties.Resources.green_box;
                    break;
            }
        }

    }
}
