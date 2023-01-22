namespace Diary
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_newNote = new System.Windows.Forms.Button();
            this.button_showAllNotes = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дневник";
            // 
            // button_newNote
            // 
            this.button_newNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_newNote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_newNote.FlatAppearance.BorderSize = 3;
            this.button_newNote.Location = new System.Drawing.Point(138, 213);
            this.button_newNote.Name = "button_newNote";
            this.button_newNote.Size = new System.Drawing.Size(300, 75);
            this.button_newNote.TabIndex = 1;
            this.button_newNote.Text = "Новая запись";
            this.button_newNote.UseVisualStyleBackColor = false;
            this.button_newNote.Click += new System.EventHandler(this.button_newNote_Click);
            // 
            // button_showAllNotes
            // 
            this.button_showAllNotes.Location = new System.Drawing.Point(138, 300);
            this.button_showAllNotes.Name = "button_showAllNotes";
            this.button_showAllNotes.Size = new System.Drawing.Size(300, 75);
            this.button_showAllNotes.TabIndex = 3;
            this.button_showAllNotes.Text = "Все записи";
            this.button_showAllNotes.UseVisualStyleBackColor = true;
            this.button_showAllNotes.Click += new System.EventHandler(this.button_showAllNotes_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(138, 386);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(300, 75);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Выход";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(611, 671);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_showAllNotes);
            this.Controls.Add(this.button_newNote);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дневник";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_newNote;
        private System.Windows.Forms.Button button_showAllNotes;
        private System.Windows.Forms.Button button_close;
    }
}

