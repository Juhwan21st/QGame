namespace JSeoQGame
{
    partial class PlayForm
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
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.lblMoves = new System.Windows.Forms.Label();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblRemainingBoxes = new System.Windows.Forms.Label();
            this.txtRemainingBoxes = new System.Windows.Forms.TextBox();
            this.mnsMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mnsMainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BackColor = System.Drawing.Color.White;
            this.pnlGameBoard.Location = new System.Drawing.Point(30, 70);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(850, 750);
            this.pnlGameBoard.TabIndex = 1;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.YellowGreen;
            this.btnUp.Location = new System.Drawing.Point(1048, 561);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 80);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.ArrowButtons_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.YellowGreen;
            this.btnDown.Location = new System.Drawing.Point(1048, 647);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(80, 80);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.ArrowButtons_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLeft.Location = new System.Drawing.Point(962, 647);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 80);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.ArrowButtons_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRight.Location = new System.Drawing.Point(1134, 647);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 80);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.ArrowButtons_Click);
            // 
            // lblMoves
            // 
            this.lblMoves.AutoSize = true;
            this.lblMoves.Font = new System.Drawing.Font("Arial", 10F);
            this.lblMoves.Location = new System.Drawing.Point(13, 32);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(171, 23);
            this.lblMoves.TabIndex = 3;
            this.lblMoves.Text = "Number of Moves:";
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(17, 70);
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ReadOnly = true;
            this.txtMoves.Size = new System.Drawing.Size(252, 28);
            this.txtMoves.TabIndex = 4;
            this.txtMoves.Text = "0";
            this.txtMoves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRemainingBoxes
            // 
            this.lblRemainingBoxes.AutoSize = true;
            this.lblRemainingBoxes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingBoxes.Location = new System.Drawing.Point(13, 137);
            this.lblRemainingBoxes.Name = "lblRemainingBoxes";
            this.lblRemainingBoxes.Size = new System.Drawing.Size(264, 23);
            this.lblRemainingBoxes.TabIndex = 3;
            this.lblRemainingBoxes.Text = "Number of Remaining Boxes:";
            // 
            // txtRemainingBoxes
            // 
            this.txtRemainingBoxes.Location = new System.Drawing.Point(17, 174);
            this.txtRemainingBoxes.Name = "txtRemainingBoxes";
            this.txtRemainingBoxes.ReadOnly = true;
            this.txtRemainingBoxes.Size = new System.Drawing.Size(252, 28);
            this.txtRemainingBoxes.TabIndex = 4;
            this.txtRemainingBoxes.Text = "0";
            this.txtRemainingBoxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.mnsMainMenu.TabIndex = 5;
            this.mnsMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtRemainingBoxes);
            this.panel1.Controls.Add(this.txtMoves);
            this.panel1.Controls.Add(this.lblRemainingBoxes);
            this.panel1.Controls.Add(this.lblMoves);
            this.panel1.Location = new System.Drawing.Point(942, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 251);
            this.panel1.TabIndex = 6;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1278, 844);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.mnsMainMenu);
            this.Name = "PlayForm";
            this.Text = "Play Form";
            this.mnsMainMenu.ResumeLayout(false);
            this.mnsMainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblRemainingBoxes;
        private System.Windows.Forms.TextBox txtRemainingBoxes;
        private System.Windows.Forms.MenuStrip mnsMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}