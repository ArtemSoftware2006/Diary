namespace Diary.Forms
{
    partial class Form_addNote
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
            this.label_dateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_logo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_note = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_dateNow = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_backonMain = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_addNote = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_dateLabel
            // 
            this.label_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_dateLabel.AutoSize = true;
            this.label_dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dateLabel.Location = new System.Drawing.Point(3, 11);
            this.label_dateLabel.Name = "label_dateLabel";
            this.label_dateLabel.Size = new System.Drawing.Size(106, 36);
            this.label_dateLabel.TabIndex = 4;
            this.label_dateLabel.Text = "Дата :";
            this.label_dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.3566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.3566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.9775F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.30931F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(695, 491);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.label_logo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(14, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 48);
            this.panel3.TabIndex = 8;
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_logo.Location = new System.Drawing.Point(3, 7);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(226, 36);
            this.label_logo.TabIndex = 8;
            this.label_logo.Text = "Новая запись";
            this.label_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Новая запись";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_note);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(14, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 296);
            this.panel1.TabIndex = 6;
            // 
            // textBox_note
            // 
            this.textBox_note.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_note.Location = new System.Drawing.Point(0, 0);
            this.textBox_note.Multiline = true;
            this.textBox_note.Name = "textBox_note";
            this.textBox_note.Size = new System.Drawing.Size(667, 296);
            this.textBox_note.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(14, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 48);
            this.panel2.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_dateLabel);
            this.panel5.Controls.Add(this.label_dateNow);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, -9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(667, 57);
            this.panel5.TabIndex = 7;
            // 
            // label_dateNow
            // 
            this.label_dateNow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_dateNow.AutoSize = true;
            this.label_dateNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_dateNow.Location = new System.Drawing.Point(109, 11);
            this.label_dateNow.Name = "label_dateNow";
            this.label_dateNow.Size = new System.Drawing.Size(167, 36);
            this.label_dateNow.TabIndex = 6;
            this.label_dateNow.Text = "21.11.2023";
            this.label_dateNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(14, 420);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(667, 64);
            this.panel4.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.button_backonMain, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_reset, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_addNote, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(667, 64);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button_backonMain
            // 
            this.button_backonMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_backonMain.Location = new System.Drawing.Point(448, 4);
            this.button_backonMain.Name = "button_backonMain";
            this.button_backonMain.Size = new System.Drawing.Size(215, 56);
            this.button_backonMain.TabIndex = 2;
            this.button_backonMain.Text = "На главную";
            this.button_backonMain.UseVisualStyleBackColor = true;
            this.button_backonMain.Click += new System.EventHandler(this.button_backonMain_Click);
            // 
            // button_reset
            // 
            this.button_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_reset.Location = new System.Drawing.Point(226, 4);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(215, 56);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "Очистить";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_addNote
            // 
            this.button_addNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_addNote.Location = new System.Drawing.Point(4, 4);
            this.button_addNote.Name = "button_addNote";
            this.button_addNote.Size = new System.Drawing.Size(215, 56);
            this.button_addNote.TabIndex = 0;
            this.button_addNote.Text = "Сохранить";
            this.button_addNote.UseVisualStyleBackColor = true;
            this.button_addNote.Click += new System.EventHandler(this.button_addNote_Click);
            // 
            // Form_addNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 491);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_addNote";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.Form_addNote_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_dateLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_backonMain;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_addNote;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.TextBox textBox_note;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_dateNow;
    }
}