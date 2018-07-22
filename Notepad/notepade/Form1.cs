using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Imad";
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveAssToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;


            this.wordWrapeToolStripMenuItem.Checked = false;
            this.textBox1.WordWrap = false;

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = false;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
                
            }
        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                this.textBox1.Font = this.fontDialog1.Font;
                this.textBox1.ForeColor = this.fontDialog1.Color;
            }
        }

        public void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.Multiline = true;
            this.textBox1.ScrollBars = ScrollBars.Both;
        }

        private void wordWrapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapeToolStripMenuItem.Checked == true)
            {
                wordWrapeToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;
            }
            else
            {
                wordWrapeToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }  
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string ab = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(ab);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string bd = saveFileDialog1.FileName;
                bd += ".txt";
                File.WriteAllText(bd, this.textBox1.Text);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                this.textBox1.Text = " ";
            }
            else
            {
                saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
                DialogResult dr = this.saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string sd = saveFileDialog1.FileName;
                    sd += ".txt";
                    File.WriteAllText(sd, this.textBox1.Text);
                }
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string bd = saveFileDialog1.FileName;
                bd += ".txt";
                File.WriteAllText(bd, this.textBox1.Text);
            }
        }
    }
}
