using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    internal class myEditChords
    {
        public void joinChordsLines(RichTextBox richTextBox1)
        {
            Clipboard.SetText(richTextBox1.SelectedText);

            string[] lines = Clipboard.GetText().Split('\n');   // richtext1 copy lines to clipboard to be copied

            //string line1 = richTextBox1.SelectedText;
            string line1 = richTextBox1.SelectedText;         // Select richtext2 where we going to copy

            int textStart = richTextBox1.SelectionStart;      // define the start of the selection text
            int textLenght = richTextBox1.SelectionLength;    // define de lenght of selected text

            string beforeSelection = richTextBox1.Text.Substring(0, textStart);       // before the selected text
            string afterSelection = richTextBox1.Text.Substring(textStart + textLenght);    // after selected text

            StringBuilder sb = new StringBuilder();



            if (lines.Length >= 4)
            {
                // Join lines 1 and 3 with a space
                string spaces = "       ";
                string newLine1 = $"{lines[0]} {spaces}  {lines[2]}";
                sb.Append(newLine1 + '\n');

                // Join lines 2 and 4 with a space
                string newLine2 = $"{lines[1]} {lines[3]}";
                sb.Append(newLine2 + '\n');

                // Update the text of the RichTextBox
                //richTextBox1.Text = $"{newLine1}\n{newLine2}";
                richTextBox1.Text = beforeSelection + sb + afterSelection;
            }
            else
            {
                MessageBox.Show("Não há linhas suficientes para fazer esta operação");
            }
        }

        public static string copyChords(RichTextBox richTextBox1)
        {
            string[] line = Clipboard.GetText().Split('\n');   // richtext1 copy lines to clipboard to be copied

            //string line1 = richTextBox1.SelectedText;         // Select richtext2 where we going to copy
            string line1 = richTextBox1.SelectedText;         // Select richtext2 where we going to copy


            int textStart = richTextBox1.SelectionStart;      // define the start of the selection text
            int textLenght = richTextBox1.SelectionLength;    // define de lenght of selected text


            string beforeSelection = richTextBox1.Text.Substring(0, textStart);       // before the selected text
            string afterSelection = richTextBox1.Text.Substring(textStart + textLenght);    // after selected text


            richTextBox1.Text = line1.Replace("\n", "\n\n").Insert(0, "\n"); // Add new empty line in richtext + insert line on top
            string[] line2 = richTextBox1.Lines;

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < line.Length; i++)
            {
                int x = i;

                if ((x % 2) == 0)  // define odd line
                {
                    sb.Append(line[i] + "\n");    // if type them append
                }
                else
                {
                    sb.Append(line2[i] + "\n");   // append the same text
                }
            }
            richTextBox1.Text = beforeSelection + sb + afterSelection;
            richTextBox1.Select(textStart, 0); // Para voltar á linha onde está a sleccao

            return richTextBox1.Text;
        }
        
        
    }
}
