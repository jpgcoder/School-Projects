using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        string file = "",copy;
        bool save;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                if (save == false)
                {
                    if (MessageBox.Show("Do you wanna save?", "Save?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        File.WriteAllText(file, textBox1.Text);
                        save = true;
                    }
                }

            }
            else
            {
                if (textBox1.TextLength > 0)
                    if (MessageBox.Show("Do you wanna save?", "Save?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            file = saveFileDialog1.FileName;
                            File.WriteAllText(file, textBox1.Text);
                            save = true;
                        }

                    }
            }
            file = "";
            this.Text = "Untitled";
            textBox1.Clear();
            save = false;
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = saveFileDialog1.FileName;
                File.WriteAllText(file, textBox1.Text);
                save = true;
                this.Text = file.Substring(file.LastIndexOf('\\') + 1);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                File.WriteAllText(file, textBox1.Text);
                save = true;
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file = saveFileDialog1.FileName;
                    File.WriteAllText(file, textBox1.Text);
                    save = true;
                    this.Text = file.Substring(file.LastIndexOf('\\')+1);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            save = false;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text.Insert(textBox1.SelectionStart,copy);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                if (save == false)
                {
                    if (MessageBox.Show("Do you wanna save?", "Save?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        File.WriteAllText(file, textBox1.Text);
                        save = true;
                    }
                }
                    
            }
            else
            {
                if (textBox1.TextLength > 0)
                    if (MessageBox.Show("Do you wanna save?", "Save?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            file = saveFileDialog1.FileName;
                            File.WriteAllText(file, textBox1.Text);
                            save = true;
                        }

                    }
            }


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                textBox1.Text = File.ReadAllText(file);
                save = true;
                this.Text = file.Substring(file.LastIndexOf('\\') + 1);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = textBox1.SelectedText;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy = textBox1.SelectedText;
            textBox1.Text=textBox1.Text.Remove(textBox1.SelectionStart, textBox1.SelectionLength);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(file))
            {
                if (save == false)
                {
                    if (MessageBox.Show("Do you wanna save?", "Save?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        File.WriteAllText(file, textBox1.Text);
                        save = true;
                    }
                }

            }
            else
            {
                if (textBox1.TextLength > 0)
                    if (MessageBox.Show("Do you wanna save?", "Save?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            file = saveFileDialog1.FileName;
                            File.WriteAllText(file, textBox1.Text);
                            save = true;
                        }

                    }
            }
        }
    }
}

