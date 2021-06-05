
namespace Covid19
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.TextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.EnterButton = new Guna.UI.WinForms.GunaButton();
            this.TextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.TextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.TextBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(442, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "Регистрация ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.Transparent;
            this.TextBox2.BaseColor = System.Drawing.Color.White;
            this.TextBox2.BorderColor = System.Drawing.Color.Silver;
            this.TextBox2.BorderSize = 1;
            this.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2.Location = new System.Drawing.Point(13, 112);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.PasswordChar = '\0';
            this.TextBox2.Radius = 7;
            this.TextBox2.Size = new System.Drawing.Size(220, 50);
            this.TextBox2.TabIndex = 15;
            this.TextBox2.Text = "Имя";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.TextBox1.BaseColor = System.Drawing.Color.White;
            this.TextBox1.BorderColor = System.Drawing.Color.Silver;
            this.TextBox1.BorderSize = 1;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.Location = new System.Drawing.Point(13, 54);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.Radius = 7;
            this.TextBox1.Size = new System.Drawing.Size(220, 50);
            this.TextBox1.TabIndex = 14;
            this.TextBox1.Text = "Фамилия";
            // 
            // EnterButton
            // 
            this.EnterButton.Animated = true;
            this.EnterButton.AnimationHoverSpeed = 0.07F;
            this.EnterButton.AnimationSpeed = 0.03F;
            this.EnterButton.BackColor = System.Drawing.Color.Transparent;
            this.EnterButton.BaseColor = System.Drawing.SystemColors.Control;
            this.EnterButton.BorderColor = System.Drawing.Color.Black;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.EnterButton.FocusedColor = System.Drawing.Color.Empty;
            this.EnterButton.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.EnterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EnterButton.Image = null;
            this.EnterButton.ImageSize = new System.Drawing.Size(20, 20);
            this.EnterButton.Location = new System.Drawing.Point(126, 345);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EnterButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EnterButton.OnHoverForeColor = System.Drawing.Color.White;
            this.EnterButton.OnHoverImage = null;
            this.EnterButton.OnPressedColor = System.Drawing.Color.Black;
            this.EnterButton.Radius = 7;
            this.EnterButton.Size = new System.Drawing.Size(220, 52);
            this.EnterButton.TabIndex = 16;
            this.EnterButton.Text = "Создать";
            this.EnterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // TextBox4
            // 
            this.TextBox4.BackColor = System.Drawing.Color.Transparent;
            this.TextBox4.BaseColor = System.Drawing.Color.White;
            this.TextBox4.BorderColor = System.Drawing.Color.Silver;
            this.TextBox4.BorderSize = 1;
            this.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox4.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox4.Location = new System.Drawing.Point(126, 229);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.PasswordChar = '\0';
            this.TextBox4.Radius = 7;
            this.TextBox4.Size = new System.Drawing.Size(220, 50);
            this.TextBox4.TabIndex = 18;
            this.TextBox4.Text = "Логин";
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.Color.Transparent;
            this.TextBox3.BaseColor = System.Drawing.Color.White;
            this.TextBox3.BorderColor = System.Drawing.Color.Silver;
            this.TextBox3.BorderSize = 1;
            this.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox3.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3.Location = new System.Drawing.Point(13, 170);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.PasswordChar = '\0';
            this.TextBox3.Radius = 7;
            this.TextBox3.Size = new System.Drawing.Size(220, 50);
            this.TextBox3.TabIndex = 17;
            this.TextBox3.Text = "Отчество";
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.Color.Transparent;
            this.TextBox5.BaseColor = System.Drawing.Color.White;
            this.TextBox5.BorderColor = System.Drawing.Color.Silver;
            this.TextBox5.BorderSize = 1;
            this.TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox5.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox5.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox5.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.TextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox5.Location = new System.Drawing.Point(126, 287);
            this.TextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.PasswordChar = '\0';
            this.TextBox5.Radius = 7;
            this.TextBox5.Size = new System.Drawing.Size(220, 50);
            this.TextBox5.TabIndex = 19;
            this.TextBox5.Text = "Пароль";
            // 
            // gunaButton1
            // 
            this.gunaButton1.Animated = true;
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(126, 345);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 7;
            this.gunaButton1.Size = new System.Drawing.Size(220, 52);
            this.gunaButton1.TabIndex = 20;
            this.gunaButton1.Text = "Изменить";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 1;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.Location = new System.Drawing.Point(241, 170);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 7;
            this.gunaTextBox1.Size = new System.Drawing.Size(220, 50);
            this.gunaTextBox1.TabIndex = 23;
            this.gunaTextBox1.Text = "Возраст";
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.BorderSize = 1;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.gunaTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.Location = new System.Drawing.Point(241, 112);
            this.gunaTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.Radius = 7;
            this.gunaTextBox2.Size = new System.Drawing.Size(220, 50);
            this.gunaTextBox2.TabIndex = 22;
            this.gunaTextBox2.Text = "Email";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.maskedTextBox1.Location = new System.Drawing.Point(241, 57);
            this.maskedTextBox1.Mask = "000-00-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(220, 41);
            this.maskedTextBox1.TabIndex = 47;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(478, 413);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewUser";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox TextBox2;
        private Guna.UI.WinForms.GunaTextBox TextBox1;
        private Guna.UI.WinForms.GunaButton EnterButton;
        private Guna.UI.WinForms.GunaTextBox TextBox5;
        private Guna.UI.WinForms.GunaTextBox TextBox4;
        private Guna.UI.WinForms.GunaTextBox TextBox3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}