using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace skic_crypto
{
    public partial class Form1 : Form
    {
       // byte[] abc;
        //byte[,] table;
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_encrypt_page_Click(object sender, EventArgs e)
        {
            panel_Encrypt.BringToFront();
            txt_decrypt.Text = "";
            txt_decrypt1.Text = "";
            txt_file_path2.Text = "";
            txt_decrypt_password.Text = "";
        }

        private void btn_decrypt_page_Click(object sender, EventArgs e)
        {
            panel_decrypt.BringToFront();
            txt_encrypt.Text = "";
            txt_encrypt1.Text = "";
            txt_file_path.Text = "";
            txt_encrypt_password.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void panel_decrypt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (txt_decrypt.Text != null)
            {
                if (rbAES_decrypt.Checked == true)
                {
                    StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\privatemessage.txt");
                    string line = sr.ReadLine();
                    txt_decrypt1.Text = Encryptor.Decrypted(Convert.ToString(line));
                }
                if (rbAES_decrypt.Checked == false)
                {
                    form_key f2 = new form_key();
                    f2.ShowDialog();
                    int key_encrypt = Convert.ToInt32(form_key.encrypt_key);
                    //message=text to encrypt
                    string message = txt_decrypt.Text;
                    txt_decrypt1.Text = CeasarCipher.Decrypt(message, key_encrypt);
                }
            }
            else
            {
                MessageBox.Show("Please enter a text to decrypt");
            }


        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            txt_decrypt.Text = "";
            txt_decrypt1.Text = "";
            txt_decrypt_password.Text = "";
            txt_file_path2.Text = "";
            
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        public static string password;
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (txt_encrypt.TextLength>=1)
            {
                if (rbAES_encrypt.Checked == true)
                {
                    password = txt_encrypt_password.Text;
                    txt_encrypt1.Text = Encryptor.Encrypt(txt_encrypt.Text);
                    //var copy = encm;
                    File.WriteAllText(@"C:\Users\Public\Documents\privatemessage.txt", txt_encrypt1.Text);
                    MessageBox.Show("the saved location of this encryption is, path C:Users:Public:Documents:privatemessage.txt");
                }
                if (rbCC_encrypt.Checked == true)
                {
                    form_key f2 = new form_key();
                    f2.ShowDialog();
                    int key_encrypt = Convert.ToInt32(form_key.encrypt_key);
                    //message=text to encrypt
                    string message = txt_encrypt.Text;
                    txt_encrypt1.Text = CeasarCipher.encrypt(message, key_encrypt);
                    File.WriteAllText(@"C:\Users\Public\Documents\Ceasar.txt", txt_encrypt1.Text);
                    MessageBox.Show("the saved location of this encryption is, path C:Users:Public:Documents:Ceasar.txt");
                }
            }            
                 else
                {
                    MessageBox.Show("Please enter a text to encrypt");
                }
           
        }
        private void btn_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = ".txt";
           // ofd.ShowDialog();
           // bool? result = ofd.ShowDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txt_file_path.Text = ofd.FileName;
                using(StreamReader sr=new StreamReader(ofd.FileName))
                {
                txt_encrypt.Text = sr.ReadToEnd();
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //ofd=open file directory
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_file_path2.Text = ofd.FileName;
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    txt_decrypt.Text = sr.ReadToEnd();
                }
            }
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string verify;
        private void txt_decrypt_password_TextChanged(object sender, EventArgs e)
        {
            verify = txt_decrypt_password.Text;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_encrypt.Text = "";
            txt_encrypt1.Text = "";
            txt_file_path.Text = "";
            txt_encrypt_password.Text = "";

        }

        private void rbCC_encrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCC_encrypt.Checked == true)
            {
                txt_encrypt_password.Enabled = false;
            }
            if (rbCC_encrypt.Checked == false)
            {
                txt_encrypt_password.Enabled = true;
            }
        }

        private void rbAES_encrypt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCC_decrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCC_decrypt.Checked == true) 
            {
                txt_decrypt_password.Enabled = false;
               // btn_select2.Enabled = false;
               // txt_file_path2.Enabled = false;
            }
            if (rbCC_decrypt.Checked == false) 
            {
                txt_decrypt_password.Enabled = true;
                btn_select2.Enabled = true;
                txt_file_path2.Enabled = true;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_encrypt1.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void txt_encrypt_TextChanged(object sender, EventArgs e)
        {


        }
        private void txt_encrypt_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                RichTextBoxEx fs = new RichTextBoxEx();
                fs.AddContextMenu();
            }
        }
        public partial class RichTextBoxEx : RichTextBox
        {
            public RichTextBoxEx()
            {
                AddContextMenu();
            }


            public void AddContextMenu()
            {
                ContextMenuStrip cms = new ContextMenuStrip { ShowImageMargin = false };

                ToolStripMenuItem tsmiUndo = new ToolStripMenuItem("Undo");
                tsmiUndo.Click += (sender, e) => { if (CanUndo) Undo(); };
                tsmiUndo.ShortcutKeys = Keys.Z | Keys.Control;
                cms.Items.Add(tsmiUndo);

                ToolStripMenuItem tsmiRedo = new ToolStripMenuItem("Redo");
                tsmiRedo.Click += (sender, e) => { if (CanRedo) Redo(); };
                tsmiRedo.ShortcutKeys = Keys.Y | Keys.Control;
                cms.Items.Add(tsmiRedo);

                cms.Items.Add(new ToolStripSeparator());

                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Cut");
                tsmiCut.Click += (sender, e) => Cut();
                tsmiCut.ShortcutKeys = Keys.X | Keys.Control;
                cms.Items.Add(tsmiCut);

                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
                tsmiCopy.Click += (sender, e) => Copy();
                tsmiCopy.ShortcutKeys = Keys.C | Keys.Control;
                cms.Items.Add(tsmiCopy);

                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Paste");
                tsmiPaste.Click += (sender, e) => Paste();
                tsmiPaste.ShortcutKeys = Keys.V | Keys.Control;
                cms.Items.Add(tsmiPaste);

                ToolStripMenuItem tsmiDelete = new ToolStripMenuItem("Delete");
                tsmiDelete.Click += (sender, e) => { SelectedText = ""; };
                cms.Items.Add(tsmiDelete);

                cms.Items.Add(new ToolStripSeparator());

                ToolStripMenuItem tsmiSelectAll = new ToolStripMenuItem("Select All");
                tsmiSelectAll.Click += (sender, e) => { SelectionStart = 0; SelectionLength = Text.Length; };
                tsmiSelectAll.ShortcutKeys = Keys.A | Keys.Control;
                cms.Items.Add(tsmiSelectAll);

                cms.Opening += delegate (object sender, CancelEventArgs e)
                {
                    tsmiUndo.Enabled = CanUndo && !this.ReadOnly;
                    tsmiRedo.Enabled = CanRedo && !this.ReadOnly;
                    tsmiCut.Enabled = (SelectionLength != 0) && !this.ReadOnly;
                    tsmiCopy.Enabled = SelectionLength != 0;
                    tsmiPaste.Enabled = Clipboard.ContainsText() && !this.ReadOnly;
                    tsmiDelete.Enabled = (SelectionLength != 0) && !this.ReadOnly;
                    tsmiSelectAll.Enabled = (TextLength > 0) && (SelectionLength < TextLength);
                };

                ContextMenuStrip = cms;
             
            }


        }
    }

   
    
 }
