﻿namespace ToKorean
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            scontMain = new SplitContainer();
            txtOrigin = new TextBox();
            txtOut = new TextBox();
            splitContainer1 = new SplitContainer();
            flpMain = new FlowLayoutPanel();
            btnTranslate = new Button();
            menuStrip1 = new MenuStrip();
            설정ToolStripMenuItem = new ToolStripMenuItem();
            btnYmlParse = new Button();
            ((System.ComponentModel.ISupportInitialize)scontMain).BeginInit();
            scontMain.Panel1.SuspendLayout();
            scontMain.Panel2.SuspendLayout();
            scontMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flpMain.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // scontMain
            // 
            scontMain.Dock = DockStyle.Fill;
            scontMain.IsSplitterFixed = true;
            scontMain.Location = new Point(0, 0);
            scontMain.Name = "scontMain";
            // 
            // scontMain.Panel1
            // 
            scontMain.Panel1.Controls.Add(txtOrigin);
            // 
            // scontMain.Panel2
            // 
            scontMain.Panel2.Controls.Add(txtOut);
            scontMain.Size = new Size(784, 383);
            scontMain.SplitterDistance = 392;
            scontMain.TabIndex = 0;
            // 
            // txtOrigin
            // 
            txtOrigin.Dock = DockStyle.Fill;
            txtOrigin.Location = new Point(0, 0);
            txtOrigin.Multiline = true;
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(392, 383);
            txtOrigin.TabIndex = 0;
            // 
            // txtOut
            // 
            txtOut.Dock = DockStyle.Fill;
            txtOut.Location = new Point(0, 0);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.ReadOnly = true;
            txtOut.Size = new Size(388, 383);
            txtOut.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(scontMain);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flpMain);
            splitContainer1.Size = new Size(784, 437);
            splitContainer1.SplitterDistance = 383;
            splitContainer1.TabIndex = 1;
            // 
            // flpMain
            // 
            flpMain.Controls.Add(btnYmlParse);
            flpMain.Controls.Add(btnTranslate);
            flpMain.Dock = DockStyle.Fill;
            flpMain.Location = new Point(0, 0);
            flpMain.Name = "flpMain";
            flpMain.Size = new Size(784, 50);
            flpMain.TabIndex = 0;
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(84, 3);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(75, 23);
            btnTranslate.TabIndex = 0;
            btnTranslate.Text = "번역";
            btnTranslate.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 설정ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // 설정ToolStripMenuItem
            // 
            설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            설정ToolStripMenuItem.Size = new Size(43, 20);
            설정ToolStripMenuItem.Text = "일반";
            // 
            // btnYmlParse
            // 
            btnYmlParse.Location = new Point(3, 3);
            btnYmlParse.Name = "btnYmlParse";
            btnYmlParse.Size = new Size(75, 23);
            btnYmlParse.TabIndex = 1;
            btnYmlParse.Text = "Yml Parser";
            btnYmlParse.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "한글 번역기";
            scontMain.Panel1.ResumeLayout(false);
            scontMain.Panel1.PerformLayout();
            scontMain.Panel2.ResumeLayout(false);
            scontMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scontMain).EndInit();
            scontMain.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flpMain.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer scontMain;
        private TextBox txtOrigin;
        private TextBox txtOut;
        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 설정ToolStripMenuItem;
        private FlowLayoutPanel flpMain;
        private Button btnTranslate;
        private Button btnYmlParse;
    }
}