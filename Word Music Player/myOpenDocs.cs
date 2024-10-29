using Spire.Doc.Documents;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    internal class myOpenDocs
    {

        // Function to open DOCX or ODT files
        public string OpenDocument(string filePath)
        {
            // Create a new document object
            Document document = new Document();
            string _docText = string.Empty;

            try
            {
                // Load the DOCX or ODT file into the document object
                document.LoadFromFile(filePath);

                // Convert the document content to text (or you can display it in a richer format)
                _docText = document.GetText();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening document: " + ex.Message);
            }
            return _docText;
        }


        public void SaveDocument(string filePath, RichTextBox richTextBox, string format)
        {
            try
            {
                // Create a new document object
                Document document = new Document();

                // Add a section and a paragraph
                Section section = document.AddSection();
                Paragraph paragraph = section.AddParagraph();

                if (format == "odt")
                {
                    // Add specific separators between rows
                    string[] lines = richTextBox.Lines;
                    string combinedText = string.Join("\r\n", lines);
                    // Save Text
                    paragraph.AppendText(combinedText);
                }
                else
                {
                    paragraph.AppendText(richTextBox.Text);
                }


                // Determine the format to save in
                switch (format.ToLower())
                {
                    case "odt":
                        document.SaveToFile(filePath, FileFormat.Odt);

                        break;

                    case "docx":
                        document.SaveToFile(filePath, FileFormat.Docx);
                        break;

                    case "doc":
                        document.SaveToFile(filePath, FileFormat.Doc);
                        break;

                    case "rtf":
                        document.SaveToFile(filePath, FileFormat.Rtf);
                        break;

                    case "txt":
                        document.SaveToFile(filePath, FileFormat.Txt);
                        break;

                    default:
                        throw new ArgumentException("Erro");
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Sorry Cant Save Document: " + ex.Message);
            }
        }



    }
}
