namespace JSeoQGame
{
    partial class DesignerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerForm));
			this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlGanerator = new System.Windows.Forms.Panel();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.txtCols = new System.Windows.Forms.TextBox();
			this.lblCols = new System.Windows.Forms.Label();
			this.txtRows = new System.Windows.Forms.TextBox();
			this.lblRows = new System.Windows.Forms.Label();
			this.pnlToolBox = new System.Windows.Forms.Panel();
			this.btnGreenBox = new System.Windows.Forms.Button();
			this.imgTools = new System.Windows.Forms.ImageList(this.components);
			this.btnRedBox = new System.Windows.Forms.Button();
			this.btnGreenDoor = new System.Windows.Forms.Button();
			this.btnRedDoor = new System.Windows.Forms.Button();
			this.btnWall = new System.Windows.Forms.Button();
			this.btnNone = new System.Windows.Forms.Button();
			this.lblToolbox = new System.Windows.Forms.Label();
			this.pnlGameBoard = new System.Windows.Forms.Panel();
			this.mnsMainMenu.SuspendLayout();
			this.pnlGanerator.SuspendLayout();
			this.pnlToolBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnsMainMenu
			// 
			this.mnsMainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.mnsMainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mnsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mnsMainMenu.Location = new System.Drawing.Point(0, 0);
			this.mnsMainMenu.Name = "mnsMainMenu";
			this.mnsMainMenu.Size = new System.Drawing.Size(1278, 33);
			this.mnsMainMenu.TabIndex = 3;
			this.mnsMainMenu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
			this.closeToolStripMenuItem.Text = "&Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// pnlGanerator
			// 
			this.pnlGanerator.BackColor = System.Drawing.Color.YellowGreen;
			this.pnlGanerator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlGanerator.Controls.Add(this.btnGenerate);
			this.pnlGanerator.Controls.Add(this.txtCols);
			this.pnlGanerator.Controls.Add(this.lblCols);
			this.pnlGanerator.Controls.Add(this.txtRows);
			this.pnlGanerator.Controls.Add(this.lblRows);
			this.pnlGanerator.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pnlGanerator.Location = new System.Drawing.Point(0, 36);
			this.pnlGanerator.Name = "pnlGanerator";
			this.pnlGanerator.Size = new System.Drawing.Size(1278, 80);
			this.pnlGanerator.TabIndex = 4;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(613, 14);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(191, 52);
			this.btnGenerate.TabIndex = 3;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// txtCols
			// 
			this.txtCols.Location = new System.Drawing.Point(398, 24);
			this.txtCols.Name = "txtCols";
			this.txtCols.Size = new System.Drawing.Size(162, 30);
			this.txtCols.TabIndex = 2;
			// 
			// lblCols
			// 
			this.lblCols.AutoSize = true;
			this.lblCols.Location = new System.Drawing.Point(301, 27);
			this.lblCols.Name = "lblCols";
			this.lblCols.Size = new System.Drawing.Size(91, 23);
			this.lblCols.TabIndex = 0;
			this.lblCols.Text = "Columns:";
			// 
			// txtRows
			// 
			this.txtRows.Location = new System.Drawing.Point(97, 24);
			this.txtRows.Name = "txtRows";
			this.txtRows.Size = new System.Drawing.Size(162, 30);
			this.txtRows.TabIndex = 1;
			// 
			// lblRows
			// 
			this.lblRows.AutoSize = true;
			this.lblRows.Location = new System.Drawing.Point(25, 27);
			this.lblRows.Name = "lblRows";
			this.lblRows.Size = new System.Drawing.Size(66, 23);
			this.lblRows.TabIndex = 0;
			this.lblRows.Text = "Rows:";
			// 
			// pnlToolBox
			// 
			this.pnlToolBox.BackColor = System.Drawing.Color.OldLace;
			this.pnlToolBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlToolBox.Controls.Add(this.btnGreenBox);
			this.pnlToolBox.Controls.Add(this.btnRedBox);
			this.pnlToolBox.Controls.Add(this.btnGreenDoor);
			this.pnlToolBox.Controls.Add(this.btnRedDoor);
			this.pnlToolBox.Controls.Add(this.btnWall);
			this.pnlToolBox.Controls.Add(this.btnNone);
			this.pnlToolBox.Controls.Add(this.lblToolbox);
			this.pnlToolBox.Location = new System.Drawing.Point(0, 114);
			this.pnlToolBox.Name = "pnlToolBox";
			this.pnlToolBox.Size = new System.Drawing.Size(260, 731);
			this.pnlToolBox.TabIndex = 5;
			// 
			// btnGreenBox
			// 
			this.btnGreenBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGreenBox.ImageIndex = 5;
			this.btnGreenBox.ImageList = this.imgTools;
			this.btnGreenBox.Location = new System.Drawing.Point(28, 604);
			this.btnGreenBox.Name = "btnGreenBox";
			this.btnGreenBox.Size = new System.Drawing.Size(200, 100);
			this.btnGreenBox.TabIndex = 9;
			this.btnGreenBox.Text = "Green Box";
			this.btnGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGreenBox.UseVisualStyleBackColor = true;
			this.btnGreenBox.Click += new System.EventHandler(this.ToolButtons_Click);
			// 
			// imgTools
			// 
			this.imgTools.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTools.ImageStream")));
			this.imgTools.TransparentColor = System.Drawing.Color.Transparent;
			this.imgTools.Images.SetKeyName(0, "none_tile.png");
			this.imgTools.Images.SetKeyName(1, "wall.png");
			this.imgTools.Images.SetKeyName(2, "red_door.png");
			this.imgTools.Images.SetKeyName(3, "green_door.png");
			this.imgTools.Images.SetKeyName(4, "red_box.png");
			this.imgTools.Images.SetKeyName(5, "green_box.png");
			// 
			// btnRedBox
			// 
			this.btnRedBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRedBox.ImageIndex = 4;
			this.btnRedBox.ImageList = this.imgTools;
			this.btnRedBox.Location = new System.Drawing.Point(30, 499);
			this.btnRedBox.Name = "btnRedBox";
			this.btnRedBox.Size = new System.Drawing.Size(200, 100);
			this.btnRedBox.TabIndex = 8;
			this.btnRedBox.Text = "Red Box";
			this.btnRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRedBox.UseVisualStyleBackColor = true;
			this.btnRedBox.Click += new System.EventHandler(this.ToolButtons_Click);
			// 
			// btnGreenDoor
			// 
			this.btnGreenDoor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGreenDoor.ImageIndex = 3;
			this.btnGreenDoor.ImageList = this.imgTools;
			this.btnGreenDoor.Location = new System.Drawing.Point(28, 392);
			this.btnGreenDoor.Name = "btnGreenDoor";
			this.btnGreenDoor.Size = new System.Drawing.Size(200, 100);
			this.btnGreenDoor.TabIndex = 7;
			this.btnGreenDoor.Text = "Green Door";
			this.btnGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGreenDoor.UseVisualStyleBackColor = true;
			this.btnGreenDoor.Click += new System.EventHandler(this.ToolButtons_Click);
			// 
			// btnRedDoor
			// 
			this.btnRedDoor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRedDoor.ImageIndex = 2;
			this.btnRedDoor.ImageList = this.imgTools;
			this.btnRedDoor.Location = new System.Drawing.Point(28, 286);
			this.btnRedDoor.Name = "btnRedDoor";
			this.btnRedDoor.Size = new System.Drawing.Size(200, 100);
			this.btnRedDoor.TabIndex = 6;
			this.btnRedDoor.Text = "Red Door";
			this.btnRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRedDoor.UseVisualStyleBackColor = true;
			this.btnRedDoor.Click += new System.EventHandler(this.ToolButtons_Click);
			// 
			// btnWall
			// 
			this.btnWall.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnWall.ImageIndex = 1;
			this.btnWall.ImageList = this.imgTools;
			this.btnWall.Location = new System.Drawing.Point(28, 180);
			this.btnWall.Name = "btnWall";
			this.btnWall.Size = new System.Drawing.Size(200, 100);
			this.btnWall.TabIndex = 5;
			this.btnWall.Text = "Wall";
			this.btnWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnWall.UseVisualStyleBackColor = true;
			this.btnWall.Click += new System.EventHandler(this.ToolButtons_Click);
			// 
			// btnNone
			// 
			this.btnNone.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNone.ImageIndex = 0;
			this.btnNone.ImageList = this.imgTools;
			this.btnNone.Location = new System.Drawing.Point(28, 74);
			this.btnNone.Name = "btnNone";
			this.btnNone.Size = new System.Drawing.Size(200, 100);
			this.btnNone.TabIndex = 4;
			this.btnNone.Text = "None";
			this.btnNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNone.UseVisualStyleBackColor = true;
			this.btnNone.Click += new System.EventHandler(this.ToolButtons_Click);
			// 
			// lblToolbox
			// 
			this.lblToolbox.AutoSize = true;
			this.lblToolbox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblToolbox.Location = new System.Drawing.Point(65, 24);
			this.lblToolbox.Name = "lblToolbox";
			this.lblToolbox.Size = new System.Drawing.Size(123, 33);
			this.lblToolbox.TabIndex = 0;
			this.lblToolbox.Text = "Toolbox";
			// 
			// pnlGameBoard
			// 
			this.pnlGameBoard.Location = new System.Drawing.Point(270, 180);
			this.pnlGameBoard.Name = "pnlGameBoard";
			this.pnlGameBoard.Size = new System.Drawing.Size(1000, 600);
			this.pnlGameBoard.TabIndex = 6;
			this.pnlGameBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CellBoxes_MouseUp);
			// 
			// DesignerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1278, 844);
			this.Controls.Add(this.pnlGameBoard);
			this.Controls.Add(this.mnsMainMenu);
			this.Controls.Add(this.pnlGanerator);
			this.Controls.Add(this.pnlToolBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DesignerForm";
			this.Text = "Design Form";
			this.MouseEnter += new System.EventHandler(this.DesignerForm_MouseEnter);
			this.mnsMainMenu.ResumeLayout(false);
			this.mnsMainMenu.PerformLayout();
			this.pnlGanerator.ResumeLayout(false);
			this.pnlGanerator.PerformLayout();
			this.pnlToolBox.ResumeLayout(false);
			this.pnlToolBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGanerator;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.ImageList imgTools;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Panel pnlGameBoard;
    }
}