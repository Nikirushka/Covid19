
namespace Covid19
{
    partial class Diary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diary));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.EnterButton = new Guna.UI.WinForms.GunaButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(926, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дневник";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.EnterButton.Location = new System.Drawing.Point(641, 370);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.EnterButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.EnterButton.OnHoverForeColor = System.Drawing.Color.White;
            this.EnterButton.OnHoverImage = null;
            this.EnterButton.OnPressedColor = System.Drawing.Color.Black;
            this.EnterButton.Radius = 7;
            this.EnterButton.Size = new System.Drawing.Size(155, 60);
            this.EnterButton.TabIndex = 33;
            this.EnterButton.Text = "Узнать";
            this.EnterButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(882, 6);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 33);
            this.label13.TabIndex = 35;
            this.label13.Text = "X";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(-1, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(927, 55);
            this.label14.TabIndex = 36;
            this.label14.Text = "Внимание! Данный тест не является достоверным источником для формирования выводов" +
    " \r\nо наличии или отсутствии заболеваний и несет ознакомительный характер!\r\n";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(927, 505);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Diary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diary";
            this.Load += new System.EventHandler(this.Diary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton EnterButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}