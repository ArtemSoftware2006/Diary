namespace Diary.Forms
{
    partial class Form_showNotes
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
            this.panel_recordNotes = new System.Windows.Forms.Panel();
            this.groupBox_showNote = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_onMain = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_redact = new System.Windows.Forms.Button();
            this.textBox_noteText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_recordNote.SuspendLayout();
            this.groupBox_showNote.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            // panel_recordNotes
            // 
            this.panel_recordNotes.AutoScroll = true;
            this.panel_recordNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_recordNotes.Location = new System.Drawing.Point(3, 26);
            this.panel_recordNotes.Name = "panel_recordNotes";
            this.panel_recordNotes.Size = new System.Drawing.Size(283, 650);
            this.panel_recordNotes.TabIndex = 0;
            this.panel_recordNotes.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_recordNotes_Scroll);
            // 
            // groupBox_showNote
            // 
            this.groupBox_showNote.BackColor = System.Drawing.Color.White;
            this.groupBox_showNote.Controls.Add(this.tableLayoutPanel1);
            this.groupBox_showNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_showNote.Location = new System.Drawing.Point(5, 5);
            this.groupBox_showNote.Name = "groupBox_showNote";
            this.groupBox_showNote.Size = new System.Drawing.Size(564, 669);
            this.groupBox_showNote.TabIndex = 0;
            this.groupBox_showNote.TabStop = false;
            this.groupBox_showNote.Text = "Просмотр";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_noteText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.8125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.1875F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(558, 640);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button_onMain, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_delete, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_redact, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 564);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(550, 72);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_onMain
            // 
            this.button_onMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_onMain.Location = new System.Drawing.Point(370, 4);
            this.button_onMain.Name = "button_onMain";
            this.button_onMain.Size = new System.Drawing.Size(176, 64);
            this.button_onMain.TabIndex = 2;
            this.button_onMain.Text = "На главную";
            this.button_onMain.UseVisualStyleBackColor = true;
            this.button_onMain.Click += new System.EventHandler(this.button_onMain_Click);
            // 
            // button_delete
            // 
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_delete.Location = new System.Drawing.Point(187, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(176, 64);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Удалить";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_redact
            // 
            this.button_redact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_redact.Location = new System.Drawing.Point(4, 4);
            this.button_redact.Name = "button_redact";
            this.button_redact.Size = new System.Drawing.Size(176, 64);
            this.button_redact.TabIndex = 0;
            this.button_redact.Text = "Редактировать";
            this.button_redact.UseVisualStyleBackColor = true;
            // 
            // textBox_noteText
            // 
            this.textBox_noteText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_noteText.Location = new System.Drawing.Point(4, 4);
            this.textBox_noteText.Multiline = true;
            this.textBox_noteText.Name = "textBox_noteText";
            this.textBox_noteText.ReadOnly = true;
            this.textBox_noteText.Size = new System.Drawing.Size(550, 553);
            this.textBox_noteText.TabIndex = 1;
            // 
            // Form_showNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(889, 699);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_showNotes";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Ваши записи";
            this.Load += new System.EventHandler(this.Form_ShowNotes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_recordNote.ResumeLayout(false);
            this.groupBox_showNote.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox_recordNote;
        private System.Windows.Forms.GroupBox groupBox_showNote;
        private System.Windows.Forms.Panel panel_recordNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_onMain;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_redact;
        private System.Windows.Forms.TextBox textBox_noteText;
    }
}