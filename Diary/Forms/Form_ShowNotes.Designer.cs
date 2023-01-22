﻿namespace Diary.Forms
{
    partial class Form_ShowNotes
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox_recordNote = new System.Windows.Forms.GroupBox();
            this.groupBox_showNote = new System.Windows.Forms.GroupBox();
            this.panel_recordNotes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_recordNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_recordNote);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_showNote);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(869, 679);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_recordNote
            // 
            this.groupBox_recordNote.BackColor = System.Drawing.Color.White;
            this.groupBox_recordNote.Controls.Add(this.panel_recordNotes);
            this.groupBox_recordNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_recordNote.Location = new System.Drawing.Point(0, 0);
            this.groupBox_recordNote.Name = "groupBox_recordNote";
            this.groupBox_recordNote.Size = new System.Drawing.Size(289, 679);
            this.groupBox_recordNote.TabIndex = 0;
            this.groupBox_recordNote.TabStop = false;
            this.groupBox_recordNote.Text = "Ваши записи";
            // 
            // groupBox_showNote
            // 
            this.groupBox_showNote.BackColor = System.Drawing.Color.White;
            this.groupBox_showNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_showNote.Location = new System.Drawing.Point(5, 5);
            this.groupBox_showNote.Name = "groupBox_showNote";
            this.groupBox_showNote.Size = new System.Drawing.Size(564, 669);
            this.groupBox_showNote.TabIndex = 0;
            this.groupBox_showNote.TabStop = false;
            this.groupBox_showNote.Text = "Просмотр";
            // 
            // panel_recordNotes
            // 
            this.panel_recordNotes.AutoScroll = true;
            this.panel_recordNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_recordNotes.Location = new System.Drawing.Point(3, 26);
            this.panel_recordNotes.Name = "panel_recordNotes";
            this.panel_recordNotes.Size = new System.Drawing.Size(283, 650);
            this.panel_recordNotes.TabIndex = 0;
            // 
            // Form_ShowNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(889, 699);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ShowNotes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Ваши записи";
            this.Load += new System.EventHandler(this.Form_ShowNotes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_recordNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_recordNote;
        private System.Windows.Forms.GroupBox groupBox_showNote;
        private System.Windows.Forms.Panel panel_recordNotes;
    }
}