using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
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
using Microsoft.Office.Interop.Word;

namespace reader
{
    public partial class textMasker : Form
    {
        private string _originalContent = string.Empty;

        public textMasker()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the initial value of the slider
            trackBarMaskRatio.Minimum = 0;
            trackBarMaskRatio.Maximum = 100;
            trackBarMaskRatio.Value = 20; // Default mask ratio 20%

            // Initialize label text
            lblMaskRatio.Text = $"Shielding ratio：{trackBarMaskRatio.Value}%";
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                string filePath = openFileDialog1.FileName;
                string extension = System.IO.Path.GetExtension(filePath).ToLower();

                try
                {
                    _originalContent = string.Empty; // Reset original content
                    string content = string.Empty;
                    switch (extension)
                    {
                        case ".txt":
                            _originalContent = File.ReadAllText(filePath);
                            break;
                        case ".pdf":
                            _originalContent = ReadPdfDocument(filePath);
                            break;
                        case ".doc":
                        case ".docx":
                            _originalContent = ReadWordDocument(filePath);
                            break;
                        default:
                            MessageBox.Show("不支持的格式");
                            return;
                    }
                    UpdateMaskedContent();
                    // check if the mask is enabled
                    if (chkEnableMask.Checked)
                    {
                        double maskRatio = trackBarMaskRatio.Value / 100.0; // trackBarMaskRatio.Value is the percentage
                        content = RandomMaskText(content, maskRatio);
                    }

                    //rtbContent.Text = content;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Read failed: {ex.Message}");
                }

            }
        }
        private void trackBarMaskRatio_Scroll(object sender, EventArgs e)
        {
            lblMaskRatio.Text = $"Blocking ratio:{trackBarMaskRatio.Value}%";
            // Live update the masked content
            if (!string.IsNullOrEmpty(rtbContent.Text))
            {
                double ratio = 0;
                double maskRatio = ratio / 100.0;
                string maskedText = RandomMaskText(rtbContent.Text, maskRatio);
                rtbContent.Text = maskedText;
            }
            UpdateMaskedContent(); // Update the masked content
        }
        // check if the mask is enabled
        private void chkEnableMask_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMaskedContent();
        }
        private void UpdateMaskedContent()
        {
            if (string.IsNullOrEmpty(_originalContent))
                return;

            string processedContent = _originalContent;

            // random mask the text
            if (chkEnableMask.Checked)
            {
                double maskRatio = trackBarMaskRatio.Value / 100.0;
                processedContent = RandomMaskText(_originalContent, maskRatio);
            }

            // display the processed content
            rtbContent.Text = processedContent;
        }
        private string ReadPdfDocument(string path)
        {
            try
            {
                using (PdfReader reader = new PdfReader(path))
                {
                    StringBuilder text = new StringBuilder();
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        string currentText = PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                        text.Append(currentText);
                    }
                    return text.ToString(); // load the text
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"PDF failed to read: {ex.Message}");
                return string.Empty; // failed to read
            }
        }
        private string ReadWordDocument(string path)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document doc = wordApp.Documents.Open(path);

            string fullText = "";
            foreach (Paragraph paragraph in doc.Paragraphs)
            {
                fullText += paragraph.Range.Text + "\n";
            }

            doc.Close();
            wordApp.Quit();

            return fullText; 
        }
        private string RandomMaskText(string text, double maskRatio = 0.2, char maskChar = '*')
        {
            if (string.IsNullOrEmpty(text))
                return text;

            Random random = new Random();
            char[] textArray = text.ToCharArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                // skip spaces and newlines
                if (textArray[i] == ' ' || textArray[i] == '\n' || textArray[i] == '\r')
                    continue;

                // follow the mask ratio
                if (random.NextDouble() < maskRatio)
                {
                    textArray[i] = maskChar;
                }
            }

            return new string(textArray);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Saved|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, rtbContent.Text);
                MessageBox.Show("Saved！");
            }
        }
        private void rtbContent_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
