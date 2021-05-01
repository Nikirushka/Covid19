
namespace Covid19
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.LoginTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterButton = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 5;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.LoginTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EnterButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 326);
            this.panel1.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextBox.BaseColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.BorderSize = 1;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.PasswordTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextBox.Location = new System.Drawing.Point(45, 122);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Radius = 7;
            this.PasswordTextBox.Size = new System.Drawing.Size(220, 50);
            this.PasswordTextBox.TabIndex = 8;
            this.PasswordTextBox.Text = "Пароль";
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
            this.gunaButton1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(45, 249);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 7;
            this.gunaButton1.Size = new System.Drawing.Size(220, 52);
            this.gunaButton1.TabIndex = 6;
            this.gunaButton1.Text = "Создать новый аккаунт";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginTextBox.BaseColor = System.Drawing.Color.White;
            this.LoginTextBox.BorderColor = System.Drawing.Color.Silver;
            this.LoginTextBox.BorderSize = 1;
            this.LoginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.LoginTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LoginTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.LoginTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginTextBox.Location = new System.Drawing.Point(45, 64);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.PasswordChar = '\0';
            this.LoginTextBox.Radius = 7;
            this.LoginTextBox.Size = new System.Drawing.Size(220, 50);
            this.LoginTextBox.TabIndex = 7;
            this.LoginTextBox.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(292, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.EnterButton.Location = new System.Drawing.Point(45, 189);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EnterButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EnterButton.OnHoverForeColor = System.Drawing.Color.White;
            this.EnterButton.OnHoverImage = null;
            this.EnterButton.OnPressedColor = System.Drawing.Color.Black;
            this.EnterButton.Radius = 7;
            this.EnterButton.Size = new System.Drawing.Size(220, 52);
            this.EnterButton.TabIndex = 10;
            this.EnterButton.Text = "Войти";
            this.EnterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Вход";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 5;
            this.gunaElipse2.TargetControl = this.panel1;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaTextBox PasswordTextBox;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox LoginTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton EnterButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}