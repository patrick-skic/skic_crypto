
namespace skic_crypto
{
    partial class Form1
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
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.btn_decrypt_page = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btn_encrypt_page = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel_Encrypt = new Guna.UI.WinForms.GunaPanel();
            this.rbCC_encrypt = new System.Windows.Forms.RadioButton();
            this.rbAES_encrypt = new System.Windows.Forms.RadioButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txt_encrypt_password = new Guna.UI.WinForms.GunaTextBox();
            this.btn_select = new Guna.UI.WinForms.GunaButton();
            this.txt_file_path = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Clear = new Guna.UI.WinForms.GunaButton();
            this.btn_Encrypt = new Guna.UI.WinForms.GunaButton();
            this.txt_encrypt1 = new System.Windows.Forms.RichTextBox();
            this.txt_encrypt = new System.Windows.Forms.RichTextBox();
            this.panel_decrypt = new Guna.UI.WinForms.GunaPanel();
            this.rbCC_decrypt = new System.Windows.Forms.RadioButton();
            this.rbAES_decrypt = new System.Windows.Forms.RadioButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_decrypt_password = new Guna.UI.WinForms.GunaTextBox();
            this.btn_select2 = new Guna.UI.WinForms.GunaButton();
            this.txt_file_path2 = new Guna.UI.WinForms.GunaTextBox();
            this.txt_decrypt1 = new System.Windows.Forms.RichTextBox();
            this.txt_decrypt = new System.Windows.Forms.RichTextBox();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.btn_decrypt = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox3 = new Guna.UI.WinForms.GunaControlBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gunaPanel2.SuspendLayout();
            this.panel_Encrypt.SuspendLayout();
            this.panel_decrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel2.Controls.Add(this.btn_decrypt_page);
            this.gunaPanel2.Controls.Add(this.btn_encrypt_page);
            this.gunaPanel2.Location = new System.Drawing.Point(0, 35);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(822, 45);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btn_decrypt_page
            // 
            this.btn_decrypt_page.Animated = true;
            this.btn_decrypt_page.AnimationHoverSpeed = 0.07F;
            this.btn_decrypt_page.AnimationSpeed = 0.03F;
            this.btn_decrypt_page.BaseColor = System.Drawing.Color.Transparent;
            this.btn_decrypt_page.BorderColor = System.Drawing.Color.Transparent;
            this.btn_decrypt_page.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_decrypt_page.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_decrypt_page.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_decrypt_page.CheckedForeColor = System.Drawing.Color.Salmon;
            this.btn_decrypt_page.CheckedImage = null;
            this.btn_decrypt_page.CheckedLineColor = System.Drawing.Color.Salmon;
            this.btn_decrypt_page.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_decrypt_page.FocusedColor = System.Drawing.Color.Empty;
            this.btn_decrypt_page.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_decrypt_page.ForeColor = System.Drawing.Color.White;
            this.btn_decrypt_page.Image = null;
            this.btn_decrypt_page.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_decrypt_page.LineBottom = 3;
            this.btn_decrypt_page.LineColor = System.Drawing.Color.Transparent;
            this.btn_decrypt_page.Location = new System.Drawing.Point(441, 1);
            this.btn_decrypt_page.Name = "btn_decrypt_page";
            this.btn_decrypt_page.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_decrypt_page.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_decrypt_page.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_decrypt_page.OnHoverImage = null;
            this.btn_decrypt_page.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_decrypt_page.OnPressedColor = System.Drawing.Color.Black;
            this.btn_decrypt_page.OnPressedDepth = 5;
            this.btn_decrypt_page.Size = new System.Drawing.Size(300, 42);
            this.btn_decrypt_page.TabIndex = 1;
            this.btn_decrypt_page.Text = "Decrypt";
            this.btn_decrypt_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_decrypt_page.Click += new System.EventHandler(this.btn_decrypt_page_Click);
            // 
            // btn_encrypt_page
            // 
            this.btn_encrypt_page.Animated = true;
            this.btn_encrypt_page.AnimationHoverSpeed = 0.07F;
            this.btn_encrypt_page.AnimationSpeed = 0.03F;
            this.btn_encrypt_page.BaseColor = System.Drawing.Color.Transparent;
            this.btn_encrypt_page.BorderColor = System.Drawing.Color.Transparent;
            this.btn_encrypt_page.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btn_encrypt_page.Checked = true;
            this.btn_encrypt_page.CheckedBaseColor = System.Drawing.Color.Transparent;
            this.btn_encrypt_page.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_encrypt_page.CheckedForeColor = System.Drawing.Color.Salmon;
            this.btn_encrypt_page.CheckedImage = null;
            this.btn_encrypt_page.CheckedLineColor = System.Drawing.Color.Salmon;
            this.btn_encrypt_page.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_encrypt_page.FocusedColor = System.Drawing.Color.Empty;
            this.btn_encrypt_page.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_encrypt_page.ForeColor = System.Drawing.Color.White;
            this.btn_encrypt_page.Image = null;
            this.btn_encrypt_page.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_encrypt_page.LineBottom = 3;
            this.btn_encrypt_page.LineColor = System.Drawing.Color.Transparent;
            this.btn_encrypt_page.Location = new System.Drawing.Point(101, 1);
            this.btn_encrypt_page.Name = "btn_encrypt_page";
            this.btn_encrypt_page.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_encrypt_page.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_encrypt_page.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_encrypt_page.OnHoverImage = null;
            this.btn_encrypt_page.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_encrypt_page.OnPressedColor = System.Drawing.Color.Black;
            this.btn_encrypt_page.OnPressedDepth = 5;
            this.btn_encrypt_page.Size = new System.Drawing.Size(300, 42);
            this.btn_encrypt_page.TabIndex = 0;
            this.btn_encrypt_page.Text = "Encrypt";
            this.btn_encrypt_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_encrypt_page.Click += new System.EventHandler(this.btn_encrypt_page_Click);
            // 
            // panel_Encrypt
            // 
            this.panel_Encrypt.BackColor = System.Drawing.Color.Transparent;
            this.panel_Encrypt.Controls.Add(this.rbCC_encrypt);
            this.panel_Encrypt.Controls.Add(this.rbAES_encrypt);
            this.panel_Encrypt.Controls.Add(this.gunaLabel1);
            this.panel_Encrypt.Controls.Add(this.txt_encrypt_password);
            this.panel_Encrypt.Controls.Add(this.btn_select);
            this.panel_Encrypt.Controls.Add(this.txt_file_path);
            this.panel_Encrypt.Controls.Add(this.btn_Clear);
            this.panel_Encrypt.Controls.Add(this.btn_Encrypt);
            this.panel_Encrypt.Controls.Add(this.txt_encrypt1);
            this.panel_Encrypt.Controls.Add(this.txt_encrypt);
            this.panel_Encrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Encrypt.Location = new System.Drawing.Point(0, 80);
            this.panel_Encrypt.Name = "panel_Encrypt";
            this.panel_Encrypt.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panel_Encrypt.Size = new System.Drawing.Size(822, 401);
            this.panel_Encrypt.TabIndex = 2;
            // 
            // rbCC_encrypt
            // 
            this.rbCC_encrypt.AutoSize = true;
            this.rbCC_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCC_encrypt.ForeColor = System.Drawing.Color.White;
            this.rbCC_encrypt.Location = new System.Drawing.Point(100, 33);
            this.rbCC_encrypt.Name = "rbCC_encrypt";
            this.rbCC_encrypt.Size = new System.Drawing.Size(121, 22);
            this.rbCC_encrypt.TabIndex = 17;
            this.rbCC_encrypt.Text = "Ceaser Cipher";
            this.rbCC_encrypt.UseVisualStyleBackColor = true;
            this.rbCC_encrypt.CheckedChanged += new System.EventHandler(this.rbCC_encrypt_CheckedChanged);
            // 
            // rbAES_encrypt
            // 
            this.rbAES_encrypt.AutoSize = true;
            this.rbAES_encrypt.Checked = true;
            this.rbAES_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAES_encrypt.ForeColor = System.Drawing.Color.White;
            this.rbAES_encrypt.Location = new System.Drawing.Point(23, 33);
            this.rbAES_encrypt.Name = "rbAES_encrypt";
            this.rbAES_encrypt.Size = new System.Drawing.Size(55, 22);
            this.rbAES_encrypt.TabIndex = 16;
            this.rbAES_encrypt.TabStop = true;
            this.rbAES_encrypt.Text = "AES";
            this.rbAES_encrypt.UseVisualStyleBackColor = true;
            this.rbAES_encrypt.CheckedChanged += new System.EventHandler(this.rbAES_encrypt_CheckedChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(23, 353);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Password";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_encrypt_password
            // 
            this.txt_encrypt_password.BaseColor = System.Drawing.Color.White;
            this.txt_encrypt_password.BorderColor = System.Drawing.Color.Silver;
            this.txt_encrypt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_encrypt_password.FocusedBaseColor = System.Drawing.Color.DarkSalmon;
            this.txt_encrypt_password.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_encrypt_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_encrypt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_encrypt_password.Location = new System.Drawing.Point(100, 350);
            this.txt_encrypt_password.Name = "txt_encrypt_password";
            this.txt_encrypt_password.PasswordChar = '\0';
            this.txt_encrypt_password.SelectedText = "";
            this.txt_encrypt_password.Size = new System.Drawing.Size(244, 26);
            this.txt_encrypt_password.TabIndex = 6;
            this.txt_encrypt_password.Text = "\r\n";
            // 
            // btn_select
            // 
            this.btn_select.AnimationHoverSpeed = 0.07F;
            this.btn_select.AnimationSpeed = 0.03F;
            this.btn_select.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_select.BorderColor = System.Drawing.Color.Black;
            this.btn_select.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_select.FocusedColor = System.Drawing.Color.Empty;
            this.btn_select.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_select.ForeColor = System.Drawing.Color.White;
            this.btn_select.Image = null;
            this.btn_select.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_select.Location = new System.Drawing.Point(643, 18);
            this.btn_select.Name = "btn_select";
            this.btn_select.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.btn_select.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_select.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_select.OnHoverImage = null;
            this.btn_select.OnPressedColor = System.Drawing.Color.Black;
            this.btn_select.Size = new System.Drawing.Size(161, 42);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "Select";
            this.btn_select.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_file_path
            // 
            this.txt_file_path.BaseColor = System.Drawing.Color.White;
            this.txt_file_path.BorderColor = System.Drawing.Color.Silver;
            this.txt_file_path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_file_path.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_file_path.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_file_path.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_file_path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_file_path.Location = new System.Drawing.Point(423, 18);
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.PasswordChar = '\0';
            this.txt_file_path.SelectedText = "";
            this.txt_file_path.Size = new System.Drawing.Size(216, 42);
            this.txt_file_path.TabIndex = 4;
            this.txt_file_path.Tag = "";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.AnimationHoverSpeed = 0.07F;
            this.btn_Clear.AnimationSpeed = 0.03F;
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Clear.BorderColor = System.Drawing.Color.Black;
            this.btn_Clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Clear.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.White;
            this.btn_Clear.Image = null;
            this.btn_Clear.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Clear.Location = new System.Drawing.Point(488, 343);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.btn_Clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Clear.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Clear.OnHoverImage = null;
            this.btn_Clear.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Clear.Radius = 20;
            this.btn_Clear.Size = new System.Drawing.Size(140, 40);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Encrypt.AnimationHoverSpeed = 0.07F;
            this.btn_Encrypt.AnimationSpeed = 0.03F;
            this.btn_Encrypt.BackColor = System.Drawing.Color.Transparent;
            this.btn_Encrypt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Encrypt.BorderColor = System.Drawing.Color.Black;
            this.btn_Encrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Encrypt.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Encrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Encrypt.ForeColor = System.Drawing.Color.White;
            this.btn_Encrypt.Image = null;
            this.btn_Encrypt.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Encrypt.Location = new System.Drawing.Point(643, 343);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btn_Encrypt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Encrypt.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Encrypt.OnHoverImage = null;
            this.btn_Encrypt.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Encrypt.Radius = 20;
            this.btn_Encrypt.Size = new System.Drawing.Size(160, 40);
            this.btn_Encrypt.TabIndex = 2;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // txt_encrypt1
            // 
            this.txt_encrypt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_encrypt1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_encrypt1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encrypt1.Location = new System.Drawing.Point(423, 91);
            this.txt_encrypt1.Name = "txt_encrypt1";
            this.txt_encrypt1.Size = new System.Drawing.Size(380, 230);
            this.txt_encrypt1.TabIndex = 1;
            this.txt_encrypt1.Text = "";
            // 
            // txt_encrypt
            // 
            this.txt_encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_encrypt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_encrypt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_encrypt.Location = new System.Drawing.Point(21, 91);
            this.txt_encrypt.Name = "txt_encrypt";
            this.txt_encrypt.Size = new System.Drawing.Size(380, 230);
            this.txt_encrypt.TabIndex = 0;
            this.txt_encrypt.Text = "";
            this.txt_encrypt.TextChanged += new System.EventHandler(this.txt_encrypt_TextChanged);
            // 
            // panel_decrypt
            // 
            this.panel_decrypt.BackColor = System.Drawing.Color.Transparent;
            this.panel_decrypt.Controls.Add(this.rbCC_decrypt);
            this.panel_decrypt.Controls.Add(this.rbAES_decrypt);
            this.panel_decrypt.Controls.Add(this.gunaLabel2);
            this.panel_decrypt.Controls.Add(this.txt_decrypt_password);
            this.panel_decrypt.Controls.Add(this.btn_select2);
            this.panel_decrypt.Controls.Add(this.txt_file_path2);
            this.panel_decrypt.Controls.Add(this.txt_decrypt1);
            this.panel_decrypt.Controls.Add(this.txt_decrypt);
            this.panel_decrypt.Controls.Add(this.gunaButton3);
            this.panel_decrypt.Controls.Add(this.btn_decrypt);
            this.panel_decrypt.Location = new System.Drawing.Point(0, 77);
            this.panel_decrypt.Name = "panel_decrypt";
            this.panel_decrypt.Size = new System.Drawing.Size(822, 404);
            this.panel_decrypt.TabIndex = 3;
            this.panel_decrypt.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_decrypt_Paint);
            // 
            // rbCC_decrypt
            // 
            this.rbCC_decrypt.AutoSize = true;
            this.rbCC_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCC_decrypt.ForeColor = System.Drawing.Color.White;
            this.rbCC_decrypt.Location = new System.Drawing.Point(100, 36);
            this.rbCC_decrypt.Name = "rbCC_decrypt";
            this.rbCC_decrypt.Size = new System.Drawing.Size(121, 22);
            this.rbCC_decrypt.TabIndex = 15;
            this.rbCC_decrypt.Text = "Ceaser Cipher";
            this.rbCC_decrypt.UseVisualStyleBackColor = true;
            this.rbCC_decrypt.CheckedChanged += new System.EventHandler(this.rbCC_decrypt_CheckedChanged);
            // 
            // rbAES_decrypt
            // 
            this.rbAES_decrypt.AutoSize = true;
            this.rbAES_decrypt.Checked = true;
            this.rbAES_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAES_decrypt.ForeColor = System.Drawing.Color.White;
            this.rbAES_decrypt.Location = new System.Drawing.Point(23, 36);
            this.rbAES_decrypt.Name = "rbAES_decrypt";
            this.rbAES_decrypt.Size = new System.Drawing.Size(55, 22);
            this.rbAES_decrypt.TabIndex = 14;
            this.rbAES_decrypt.TabStop = true;
            this.rbAES_decrypt.Text = "AES";
            this.rbAES_decrypt.UseVisualStyleBackColor = true;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(23, 356);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel2.TabIndex = 13;
            this.gunaLabel2.Text = "Password";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_decrypt_password
            // 
            this.txt_decrypt_password.BaseColor = System.Drawing.Color.White;
            this.txt_decrypt_password.BorderColor = System.Drawing.Color.Silver;
            this.txt_decrypt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_decrypt_password.FocusedBaseColor = System.Drawing.Color.DarkSalmon;
            this.txt_decrypt_password.FocusedBorderColor = System.Drawing.Color.DarkGoldenrod;
            this.txt_decrypt_password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_decrypt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_decrypt_password.Location = new System.Drawing.Point(100, 353);
            this.txt_decrypt_password.Name = "txt_decrypt_password";
            this.txt_decrypt_password.PasswordChar = '\0';
            this.txt_decrypt_password.SelectedText = "";
            this.txt_decrypt_password.Size = new System.Drawing.Size(244, 26);
            this.txt_decrypt_password.TabIndex = 12;
            this.txt_decrypt_password.Text = "\r\n";
            this.txt_decrypt_password.TextChanged += new System.EventHandler(this.txt_decrypt_password_TextChanged);
            // 
            // btn_select2
            // 
            this.btn_select2.AnimationHoverSpeed = 0.07F;
            this.btn_select2.AnimationSpeed = 0.03F;
            this.btn_select2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_select2.BorderColor = System.Drawing.Color.Black;
            this.btn_select2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_select2.FocusedColor = System.Drawing.Color.Empty;
            this.btn_select2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_select2.ForeColor = System.Drawing.Color.White;
            this.btn_select2.Image = null;
            this.btn_select2.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_select2.Location = new System.Drawing.Point(642, 21);
            this.btn_select2.Name = "btn_select2";
            this.btn_select2.OnHoverBaseColor = System.Drawing.Color.DarkGreen;
            this.btn_select2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_select2.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_select2.OnHoverImage = null;
            this.btn_select2.OnPressedColor = System.Drawing.Color.Black;
            this.btn_select2.Size = new System.Drawing.Size(161, 42);
            this.btn_select2.TabIndex = 11;
            this.btn_select2.Text = "Select";
            this.btn_select2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_select2.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // txt_file_path2
            // 
            this.txt_file_path2.BaseColor = System.Drawing.Color.White;
            this.txt_file_path2.BorderColor = System.Drawing.Color.Silver;
            this.txt_file_path2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_file_path2.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_file_path2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_file_path2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_file_path2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_file_path2.Location = new System.Drawing.Point(423, 21);
            this.txt_file_path2.Name = "txt_file_path2";
            this.txt_file_path2.PasswordChar = '\0';
            this.txt_file_path2.SelectedText = "";
            this.txt_file_path2.Size = new System.Drawing.Size(216, 42);
            this.txt_file_path2.TabIndex = 10;
            this.txt_file_path2.Tag = "";
            // 
            // txt_decrypt1
            // 
            this.txt_decrypt1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_decrypt1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_decrypt1.Location = new System.Drawing.Point(423, 94);
            this.txt_decrypt1.Name = "txt_decrypt1";
            this.txt_decrypt1.Size = new System.Drawing.Size(380, 230);
            this.txt_decrypt1.TabIndex = 7;
            this.txt_decrypt1.Text = "";
            // 
            // txt_decrypt
            // 
            this.txt_decrypt.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_decrypt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_decrypt.Location = new System.Drawing.Point(21, 94);
            this.txt_decrypt.Name = "txt_decrypt";
            this.txt_decrypt.Size = new System.Drawing.Size(380, 230);
            this.txt_decrypt.TabIndex = 6;
            this.txt_decrypt.Text = "";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = null;
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(488, 346);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.DarkRed;
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 20;
            this.gunaButton3.Size = new System.Drawing.Size(140, 40);
            this.gunaButton3.TabIndex = 9;
            this.gunaButton3.Text = "Clear";
            this.gunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.AnimationHoverSpeed = 0.07F;
            this.btn_decrypt.AnimationSpeed = 0.03F;
            this.btn_decrypt.BackColor = System.Drawing.Color.Transparent;
            this.btn_decrypt.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_decrypt.BorderColor = System.Drawing.Color.Black;
            this.btn_decrypt.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_decrypt.FocusedColor = System.Drawing.Color.Empty;
            this.btn_decrypt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrypt.ForeColor = System.Drawing.Color.White;
            this.btn_decrypt.Image = null;
            this.btn_decrypt.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_decrypt.Location = new System.Drawing.Point(643, 346);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.OnHoverBaseColor = System.Drawing.Color.Green;
            this.btn_decrypt.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_decrypt.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_decrypt.OnHoverImage = null;
            this.btn_decrypt.OnPressedColor = System.Drawing.Color.Black;
            this.btn_decrypt.Radius = 20;
            this.btn_decrypt.Size = new System.Drawing.Size(160, 40);
            this.btn_decrypt.TabIndex = 8;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_decrypt.Click += new System.EventHandler(this.gunaButton4_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox1.IconColor = System.Drawing.Color.White;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(777, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 4;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox;
            this.gunaControlBox2.Enabled = false;
            this.gunaControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(726, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox2.TabIndex = 5;
            // 
            // gunaControlBox3
            // 
            this.gunaControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox3.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox3.AnimationSpeed = 0.03F;
            this.gunaControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox3.IconColor = System.Drawing.Color.White;
            this.gunaControlBox3.IconSize = 15F;
            this.gunaControlBox3.Location = new System.Drawing.Point(675, 0);
            this.gunaControlBox3.Name = "gunaControlBox3";
            this.gunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox3.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox3.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox3.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::skic_crypto.Properties.Resources.istockphoto_1007179744_612x612;
            this.ClientSize = new System.Drawing.Size(822, 484);
            this.Controls.Add(this.gunaControlBox3);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.panel_Encrypt);
            this.Controls.Add(this.panel_decrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gunaPanel2.ResumeLayout(false);
            this.panel_Encrypt.ResumeLayout(false);
            this.panel_Encrypt.PerformLayout();
            this.panel_decrypt.ResumeLayout(false);
            this.panel_decrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaAdvenceButton btn_decrypt_page;
        private Guna.UI.WinForms.GunaAdvenceButton btn_encrypt_page;
        private Guna.UI.WinForms.GunaPanel panel_Encrypt;
        private Guna.UI.WinForms.GunaPanel panel_decrypt;
        private System.Windows.Forms.RichTextBox txt_encrypt;
        private Guna.UI.WinForms.GunaButton btn_Clear;
        private Guna.UI.WinForms.GunaButton btn_Encrypt;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaButton btn_decrypt;
        private System.Windows.Forms.RichTextBox txt_decrypt1;
        private System.Windows.Forms.RichTextBox txt_decrypt;
        private Guna.UI.WinForms.GunaButton btn_select;
        private Guna.UI.WinForms.GunaTextBox txt_file_path;
        private Guna.UI.WinForms.GunaButton btn_select2;
        private Guna.UI.WinForms.GunaTextBox txt_file_path2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txt_encrypt_password;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txt_decrypt_password;
        private System.Windows.Forms.RichTextBox txt_encrypt1;
        private System.Windows.Forms.RadioButton rbCC_decrypt;
        private System.Windows.Forms.RadioButton rbAES_decrypt;
        private System.Windows.Forms.RadioButton rbCC_encrypt;
        private System.Windows.Forms.RadioButton rbAES_encrypt;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

