using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Texditor
{
    public partial class Form1 : Form
    {
        private int column;

        private int columnline = 1;

        private int currentline = 1;

        private string fileName = "";

        private float fontSizecon = 0;

        private string ftoin = "";

        private int line;

        private int totalline = 1;

        public Form1()
        {
            InitializeComponent();
            toolStripLabel6.Enabled = false;
            toolStripLabel1.Enabled = false;
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                fontname.Items.Add(oneFontFamily.Name);
            }
            fontname.Text = this.richTextBox1.Font.Name.ToString();
            fontsize.Text = this.richTextBox1.Font.Size.ToString();
        }

      

        public void Whenreplaced(StringBuilder replacing)
        {
            richTextBox1.Rtf = "" + replacing;
        }

        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rtext = richTextBox1.Text;

                if (rtext.Length > 0)
                {
                    DialogResult res = MessageBox.Show("You want to save the document?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        saveFileDialog1.Filter =
                "Files (*.txt)|*.txt| rtf (*.rtf)|*.rtf| Docx (*.Doc)|*.Doc ";
                   
                    }
                    else if (res == DialogResult.No)
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fontname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String fontName = fontname.SelectedItem.ToString();
                FontFamily family = new FontFamily(fontName);
            }
            catch (Exception eee) { MessageBox.Show(eee.Message); }
        }

        private void fontSize2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ftoin = fontsize.SelectedItem.ToString();
                fontSizecon = float.Parse(ftoin);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
            "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string myfile = openFileDialog1.FileName;

                Bitmap mybitmap = new Bitmap(myfile);

                Clipboard.SetDataObject(mybitmap);

                DataFormats.Format myformat = DataFormats.GetFormat(DataFormats.Bitmap);

                if (this.richTextBox1.CanPaste(myformat))
                {
                    richTextBox1.Paste(myformat);
                }
            }
        }

        private void findAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(richTextBox1.Rtf);

            FindReplace form2 = new FindReplace(sb);

            form2.Show();
            this.Hide();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            try
            {
                string rtext = richTextBox1.Text;

                if (rtext.Length > 0)
                {
                    DialogResult res = MessageBox.Show("You want to save the document?", "Confirmation", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)

                    {
                        saveFileDialog1.Filter =
                "Text (*.txt)|*.txt| rtf (*.rtf)|*.rtf| Docx (*.Doc)|*.Doc";

                        if (saveFileDialog1.FileName.Contains(".txt"))
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Rtf);
                        }
                    }
                    else if (res == DialogResult.No)
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            try
            {
                string rtext = richTextBox1.Text;
                if (rtext.Length > 0)
                {
                    DialogResult res = MessageBox.Show("You want to save the document?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        saveFileDialog1.Filter =
                "Files (*.txt)|*.txt| rtf (*.rtf)|*.rtf| Docx (*.Doc)|*.Doc ";

                        if (saveFileDialog1.FileName.Contains(".txt"))
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Rtf);
                        }
                    }
                    
                    else
                    {
                        OpenFileDialog openFileDialog1 = new OpenFileDialog();
                        openFileDialog1.ShowDialog();

                        if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            fileName = openFileDialog1.FileName;
                            string lines = System.IO.File.ReadAllText(fileName);
                            richTextBox1.Text = "" + lines;
                        }
                    }
                }
                else
                {
                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openFileDialog1.FileName;
                        string lines = System.IO.File.ReadAllText(fileName);
                        richTextBox1.Text = lines;
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = Clipboard.GetText(TextDataFormat.Text);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 200);
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
            {
                richTextBox1.Redo();
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Space)
                autocompleteMenu1.Show(richTextBox1, true);

            int tempNum;
            if (e.KeyCode == Keys.Enter)
                try
                {
                    if (char.IsDigit(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine()]))
                    {
                        if (char.IsDigit(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 1]) && richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 2] == '.')
                            tempNum = int.Parse(richTextBox1.Text.Substring(richTextBox1.GetFirstCharIndexOfCurrentLine(), 2));
                        else tempNum = int.Parse(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine()].ToString());

                        if (richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 1] == '.' || (char.IsDigit(richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 1]) && richTextBox1.Text[richTextBox1.GetFirstCharIndexOfCurrentLine() + 2] == '.'))
                        {
                            tempNum++;
                            richTextBox1.SelectedText = "\r\n" + tempNum.ToString() + ". ";
                            e.SuppressKeyPress = true;
                        }
                    }
                }
                catch { }
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int numbr = 0;
            numbr = richTextBox1.Text.Length;
            if (numbr > 0)
            {
                if (richTextBox1.Text[numbr - 1].ToString() == "{")
                    richTextBox1.Text += "}";
                if (richTextBox1.Text[numbr - 1].ToString() == "(")
                    richTextBox1.Text += ")";
                if (richTextBox1.Text[numbr - 1].ToString() == "[")
                    richTextBox1.Text += "]";
                if (richTextBox1.Text[numbr - 1].ToString() == "<")
                    richTextBox1.Text += ">";
            }

            int countline = 0;
            if (totalline == 1)
            {
                for (int i = 0; i < richTextBox1.Text.Length; i++)
                {
                    if (richTextBox1.Text[i] == '\n')
                    {
                        countline++;
                    }
                }
                TotalLines.Text = "Total Lines : " + (countline + 1);
            }

            if (currentline == 1)
            {
                LineNumber.Text = "Current Line : " + line;
            }

            if (columnline == 1)
            {
                ColumnNumber.Text = "Column Number : " + column;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            line = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.GetFirstCharIndexOfCurrentLine());
            column = 1 + richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileName.Length == 0)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter =
                    "Files (*.txt)|*.txt|rtf (*.rtf)|*.rtf|Doc (*.Doc)|*.Doc ";
                    if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        fileName = saveFileDialog1.FileName.ToString();

                        if (saveFileDialog1.FileName.Contains(".txt"))
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                            fileName = saveFileDialog1.FileName.ToString();
                        }
                        else
                        {
                            File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Rtf);
                            fileName = saveFileDialog1.FileName.ToString();
                        }
                    }
                }
                else
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(richTextBox1.Rtf);

            InsertTable form2 = new InsertTable(sb);

            form2.Show();
            this.Hide();
        }

        private void testingBetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (testingBetsToolStripMenuItem.Checked == true)
            {
                menuStrip1.BackColor = Color.FromArgb(179, 236, 255);
                toolStrip1.BackColor = Color.FromArgb(179, 236, 255);
                toolStrip2.BackColor = Color.FromArgb(179, 236, 255);
                richTextBox1.BackColor = Color.White;
                Form1 frm = new Form1();
                frm.BackColor = Color.FromArgb(179, 236, 255);
                richTextBox1.ForeColor = Color.Black;
            }

            if (testingBetsToolStripMenuItem.Checked == false)
            {
                menuStrip1.BackColor = Color.Gray;
                toolStrip1.BackColor = Color.Gray;
                toolStrip2.BackColor = Color.Gray;
                richTextBox1.BackColor = Color.Black;
                Form1 frm = new Form1();
                frm.BackColor = Color.Gray;
                richTextBox1.ForeColor = Color.White;
            }
        }



        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            string temptext = richTextBox1.SelectedText;
            int SelectionStart = richTextBox1.SelectionStart;
            int SelectionLength = richTextBox1.SelectionLength;
            richTextBox1.SelectionStart = richTextBox1.GetFirstCharIndexOfCurrentLine();
            richTextBox1.SelectionLength = 0;
            richTextBox1.SelectedText = "1. ";
            int j = 2;

            for (int i = SelectionStart; i < SelectionStart + SelectionLength; i++)
                if (richTextBox1.Text[i] == '\n')
                {
                    richTextBox1.SelectionStart = i + 1;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.SelectedText = j.ToString() + ". ";
                    j++;
                    SelectionLength += 3;
                }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionBullet == true)
            { richTextBox1.SelectionBullet = false; }
            else
            { richTextBox1.SelectionBullet = true; }
        }

        private void toolStripButton5_Click(object sender, EventArgs e) 
        {
            ColorDialog colorDialog1 = new ColorDialog();

            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
            else
                MessageBox.Show("Color dialog error");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)

        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            colorDialog1.Color != richTextBox1.BackColor)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton8_Click(object sender, EventArgs e) 
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.DefaultExt = ".pdf";
            saveFileDialog1.Filter =
            "Files (*.pdf)|*.pdf";
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SautinSoft.PdfMetamorphosis p = new SautinSoft.PdfMetamorphosis();
                string fromtext = this.richTextBox1.Rtf;
                byte[] pdf = p.RtfToPdfConvertByte(fromtext);
                File.WriteAllBytes(saveFileDialog1.FileName, pdf);

                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                Clipboard.SetText(richTextBox1.SelectedText);
                richTextBox1.SelectedText = "";
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {   
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
    
}