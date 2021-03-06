﻿namespace LemcubeWinformProgram
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCallLibrary = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCheckForUpdates = new System.Windows.Forms.ToolStripButton();
            this.textBoxPathForUpdate = new System.Windows.Forms.TextBox();
            this.labelPathForUpdate = new System.Windows.Forms.Label();
            this.buttonCheckUpdatesPath = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCallLibrary
            // 
            this.buttonCallLibrary.Location = new System.Drawing.Point(187, 214);
            this.buttonCallLibrary.Name = "buttonCallLibrary";
            this.buttonCallLibrary.Size = new System.Drawing.Size(164, 23);
            this.buttonCallLibrary.TabIndex = 0;
            this.buttonCallLibrary.Text = "Call library Function";
            this.buttonCallLibrary.UseVisualStyleBackColor = true;
            this.buttonCallLibrary.Click += new System.EventHandler(this.buttonCallLibrary_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCheckForUpdates});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCheckForUpdates
            // 
            this.toolStripButtonCheckForUpdates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCheckForUpdates.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCheckForUpdates.Image")));
            this.toolStripButtonCheckForUpdates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCheckForUpdates.Name = "toolStripButtonCheckForUpdates";
            this.toolStripButtonCheckForUpdates.Size = new System.Drawing.Size(108, 22);
            this.toolStripButtonCheckForUpdates.Text = "Check for Updates";
            this.toolStripButtonCheckForUpdates.Click += new System.EventHandler(this.toolStripButtonCheckForUpdates_Click);
            // 
            // textBoxPathForUpdate
            // 
            this.textBoxPathForUpdate.Location = new System.Drawing.Point(187, 97);
            this.textBoxPathForUpdate.Name = "textBoxPathForUpdate";
            this.textBoxPathForUpdate.Size = new System.Drawing.Size(164, 20);
            this.textBoxPathForUpdate.TabIndex = 2;
            this.textBoxPathForUpdate.Text = "C:\\TEMP\\t";
            // 
            // labelPathForUpdate
            // 
            this.labelPathForUpdate.AutoSize = true;
            this.labelPathForUpdate.Location = new System.Drawing.Point(4, 100);
            this.labelPathForUpdate.Name = "labelPathForUpdate";
            this.labelPathForUpdate.Size = new System.Drawing.Size(177, 13);
            this.labelPathForUpdate.TabIndex = 3;
            this.labelPathForUpdate.Text = "Path of directory containing updates";
            // 
            // buttonCheckUpdatesPath
            // 
            this.buttonCheckUpdatesPath.Location = new System.Drawing.Point(357, 95);
            this.buttonCheckUpdatesPath.Name = "buttonCheckUpdatesPath";
            this.buttonCheckUpdatesPath.Size = new System.Drawing.Size(164, 23);
            this.buttonCheckUpdatesPath.TabIndex = 4;
            this.buttonCheckUpdatesPath.Text = "Check Updates Path";
            this.buttonCheckUpdatesPath.UseVisualStyleBackColor = true;
            this.buttonCheckUpdatesPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 375);
            this.Controls.Add(this.buttonCheckUpdatesPath);
            this.Controls.Add(this.labelPathForUpdate);
            this.Controls.Add(this.textBoxPathForUpdate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonCallLibrary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lemcube Winform Program";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCallLibrary;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCheckForUpdates;
        private System.Windows.Forms.TextBox textBoxPathForUpdate;
        private System.Windows.Forms.Label labelPathForUpdate;
        private System.Windows.Forms.Button buttonCheckUpdatesPath;
    }
}

