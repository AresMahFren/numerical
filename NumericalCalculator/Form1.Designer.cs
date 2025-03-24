using System.Drawing;

namespace NumericalCalculator
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.equationDisplay = new System.Windows.Forms.Panel();
            this.componentDisplay = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.graphDisplay = new System.Windows.Forms.Panel();
            this.tableDisplay = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.commandPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 860);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.flowLayoutPanel1.Controls.Add(this.resultPanel);
            this.flowLayoutPanel1.Controls.Add(this.commandPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1360, 827);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1360, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // resultPanel
            // 
            this.resultPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPanel.Controls.Add(this.graphDisplay);
            this.resultPanel.Controls.Add(this.panel4);
            this.resultPanel.Location = new System.Drawing.Point(3, 3);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(762, 824);
            this.resultPanel.TabIndex = 0;
            // 
            // commandPanel
            // 
            this.commandPanel.BackColor = System.Drawing.Color.White;
            this.commandPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.commandPanel.Controls.Add(this.componentDisplay);
            this.commandPanel.Controls.Add(this.equationDisplay);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandPanel.Location = new System.Drawing.Point(772, 6);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(584, 820);
            this.commandPanel.TabIndex = 0;
            // 
            // equationDisplay
            // 
            this.equationDisplay.BackColor = System.Drawing.Color.DimGray;
            this.equationDisplay.Location = new System.Drawing.Point(13, 13);
            this.equationDisplay.Name = "equationDisplay";
            this.equationDisplay.Size = new System.Drawing.Size(559, 299);
            this.equationDisplay.TabIndex = 0;
            // 
            // componentDisplay
            // 
            this.componentDisplay.BackColor = System.Drawing.Color.DimGray;
            this.componentDisplay.Location = new System.Drawing.Point(13, 328);
            this.componentDisplay.Name = "componentDisplay";
            this.componentDisplay.Size = new System.Drawing.Size(559, 480);
            this.componentDisplay.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.tableDisplay);
            this.panel4.Location = new System.Drawing.Point(8, 553);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(749, 258);
            this.panel4.TabIndex = 0;
            // 
            // graphDisplay
            // 
            this.graphDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.graphDisplay.Location = new System.Drawing.Point(8, 14);
            this.graphDisplay.Name = "graphDisplay";
            this.graphDisplay.Size = new System.Drawing.Size(749, 521);
            this.graphDisplay.TabIndex = 1;
            // 
            // tableDisplay
            // 
            this.tableDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDisplay.Location = new System.Drawing.Point(0, 0);
            this.tableDisplay.Name = "tableDisplay";
            this.tableDisplay.RowHeadersWidth = 62;
            this.tableDisplay.RowTemplate.Height = 28;
            this.tableDisplay.Size = new System.Drawing.Size(749, 258);
            this.tableDisplay.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 860);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUMERICAL METHODS BY LUKE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.commandPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.Panel componentDisplay;
        private System.Windows.Forms.Panel equationDisplay;
        private System.Windows.Forms.Panel graphDisplay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tableDisplay;
    }
}

