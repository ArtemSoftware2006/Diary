namespace Diary.Forms
{
    partial class Form_entrance
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
            this.label_logo = new System.Windows.Forms.Label();
            this.button_entrance = new System.Windows.Forms.Button();
            this.textBox_loginInput = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_psw = new System.Windows.Forms.Label();
            this.textBox_pswInput = new System.Windows.Forms.TextBox();
            this.label_registr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_logo
            // 
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_logo.Location = new System.Drawing.Point(15, 19);
            this.label_logo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(119, 46);
            this.label_logo.TabIndex = 1;
            this.label_logo.Text = "Вход";
            // 
            // button_entrance
            // 
            this.button_entrance.Location = new System.Drawing.Point(37, 248);
            this.button_entrance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_entrance.Name = "button_entrance";
            this.button_entrance.Size = new System.Drawing.Size(209, 50);
            this.button_entrance.TabIndex = 2;
            this.button_entrance.Text = "Войти";
            this.button_entrance.UseVisualStyleBackColor = true;
            // 
            // textBox_loginInput
            // 
            this.textBox_loginInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_loginInput.Location = new System.Drawing.Point(37, 118);
            this.textBox_loginInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_loginInput.Name = "textBox_loginInput";
            this.textBox_loginInput.Size = new System.Drawing.Size(412, 30);
            this.textBox_loginInput.TabIndex = 3;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(37, 86);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(68, 25);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логин";
            // 
            // label_psw
            // 
            this.label_psw.AutoSize = true;
            this.label_psw.Location = new System.Drawing.Point(37, 162);
            this.label_psw.Name = "label_psw";
            this.label_psw.Size = new System.Drawing.Size(80, 25);
            this.label_psw.TabIndex = 6;
            this.label_psw.Text = "Пароль";
            // 
            // textBox_pswInput
            // 
            this.textBox_pswInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pswInput.Location = new System.Drawing.Point(37, 192);
            this.textBox_pswInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_pswInput.Name = "textBox_pswInput";
            this.textBox_pswInput.Size = new System.Drawing.Size(412, 30);
            this.textBox_pswInput.TabIndex = 5;
            // 
            // label_registr
            // 
            this.label_registr.AutoSize = true;
            this.label_registr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_registr.ForeColor = System.Drawing.Color.Blue;
            this.label_registr.Location = new System.Drawing.Point(313, 273);
            this.label_registr.Name = "label_registr";
            this.label_registr.Size = new System.Drawing.Size(142, 25);
            this.label_registr.TabIndex = 7;
            this.label_registr.Text = "Регистрация";
            this.label_registr.Click += new System.EventHandler(this.label_registr_Click);
            this.label_registr.Enter += new System.EventHandler(this.label_registr_Enter);
            this.label_registr.Leave += new System.EventHandler(this.label_registr_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Нет аккаунта?";
            // 
            // Form_entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(515, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_registr);
            this.Controls.Add(this.label_psw);
            this.Controls.Add(this.textBox_pswInput);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_loginInput);
            this.Controls.Add(this.button_entrance);
            this.Controls.Add(this.label_logo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_entrance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дневник Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Button button_entrance;
        private System.Windows.Forms.TextBox textBox_loginInput;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_psw;
        private System.Windows.Forms.TextBox textBox_pswInput;
        private System.Windows.Forms.Label label_registr;
        private System.Windows.Forms.Label label5;
    }
}