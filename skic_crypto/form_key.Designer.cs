
namespace skic_crypto
{
    partial class form_key
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
            this.Num_Key = new Guna.UI.WinForms.GunaNumeric();
            this.btn_cancel = new Guna.UI.WinForms.GunaButton();
            this.btn_ok = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // Num_Key
            // 
            this.Num_Key.BaseColor = System.Drawing.Color.White;
            this.Num_Key.BorderColor = System.Drawing.Color.Silver;
            this.Num_Key.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Num_Key.ButtonForeColor = System.Drawing.Color.White;
            this.Num_Key.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Num_Key.ForeColor = System.Drawing.Color.Black;
            this.Num_Key.Location = new System.Drawing.Point(56, 37);
            this.Num_Key.Maximum = ((long)(9999999));
            this.Num_Key.Minimum = ((long)(0));
            this.Num_Key.Name = "Num_Key";
            this.Num_Key.Size = new System.Drawing.Size(166, 30);
            this.Num_Key.TabIndex = 0;
            this.Num_Key.Text = "gunaNumeric1";
            this.Num_Key.Value = ((long)(0));
            // 
            // btn_cancel
            // 
            this.btn_cancel.AnimationHoverSpeed = 0.07F;
            this.btn_cancel.AnimationSpeed = 0.03F;
            this.btn_cancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_cancel.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FocusedColor = System.Drawing.Color.Empty;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = null;
            this.btn_cancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_cancel.Location = new System.Drawing.Point(56, 83);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_cancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_cancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_cancel.OnHoverImage = null;
            this.btn_cancel.OnPressedColor = System.Drawing.Color.Black;
            this.btn_cancel.Size = new System.Drawing.Size(75, 42);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.AnimationHoverSpeed = 0.07F;
            this.btn_ok.AnimationSpeed = 0.03F;
            this.btn_ok.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_ok.BorderColor = System.Drawing.Color.Black;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ok.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Image = null;
            this.btn_ok.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ok.Location = new System.Drawing.Point(147, 83);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ok.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ok.OnHoverImage = null;
            this.btn_ok.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ok.Size = new System.Drawing.Size(75, 42);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Ok";
            this.btn_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(103, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(73, 20);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Enter key";
            // 
            // form_key
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(281, 145);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.Num_Key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_key";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaNumeric Num_Key;
        private Guna.UI.WinForms.GunaButton btn_ok;
        private Guna.UI.WinForms.GunaButton btn_cancel;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}