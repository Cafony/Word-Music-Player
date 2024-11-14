using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    internal class myCifraFuntions
    {     
        
        private static Dictionary<string, string> Cifra_Doremi_Dictionary = new Dictionary<string, string>
        {
                { "D", "Re" },
                { "D#", "Re#" },
                { "E", "Mi" },
                { "F", "Fa" },
                { "F#", "Fa#" },
                { "G", "Sol" },
                { "G#", "Sol#" },
                { "A", "La" },
                { "A#", "La#" },
                { "B", "Si" },
                { "C", "Do" },
                { "C#", "Do#" },
        };

        private static Dictionary<string, string> Doremi_Cifra_Dictionary = new Dictionary<string, string>
        {
                {"Re"   , "D"    },
                {"Ré"   , "D"    },
                {"RE"   , "D"    },
                {"RÈ"   , "D"    },
                {"Re#" , "D#"    },
                {"Ré#" , "D#"    },
                {"RE#" , "D#"    },
                {"RÉ#" , "D#"    },
                {"Mi"   , "E"    },
                {"MI"   , "E"    },
                {"Fa"   , "F"   },
                {"Fá"   , "F"   },
                {"FA"   , "F"   },
                {"FÁ"   , "F"   },
                {"Fa#" , "F#"    },
                {"Fá#" , "F#"    },
                {"FA#" , "F#"    },
                {"FÁ#" , "F#"    },
                {"Sol"  , "G"    },
                {"SOL"  , "G"    },
                {"Sol#", "G#"    },
                {"SOL#", "G#"    },
                {"La"   , "A"    },
                {"Lá"   , "A"    },
                {"LA"   , "A"    },
                {"LÁ"   , "A"    },
                { "La#" , "A#"   },
                { "Lá#" , "A#"   },
                { "LA#" , "A#"   },
                { "LÁ#" , "A#"   },
                {"Si"   , "B"   },
                {"SI"   , "B"   },
                {"Do"   , "C"   },
                {"Dó"   , "C"   },
                {"DO"   , "C"   },
                {"DÓ"   , "C"   },
                { "Do#" , "C#"   },
                { "DÓ#" , "C#"   },
                { "DO#" , "C#"   },
                { "Dó#" , "C#"   }
        };

        //===================================================================================

        // FUNCAO FEITA POR MIM SE É LINHA DE ACORDES
        private static bool isChordLine(string line)
        {
            string frase = line;
            int letters = frase.Count(f => f != ' ');
            int spaces = frase.Count(f => f == ' ');

            if (spaces > letters)
            {
                return true;
            }
            else if (letters < 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }  

        public static  string RemoveTabs(string _richtext)
        {
            var tabLength = 6;
            var tabSpace = new string(' ', tabLength);
            string _text = _richtext.Replace("\t", tabSpace);
            return _text;
        }

        public static string CifraConvert(string input)
        {
            string _noTabs = RemoveTabs(input);
            string[] lines = _noTabs.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            
            for (int i = 0; i < lines.Length; i++)
            {
                if (isChordLine(lines[i]) == true)
                {
                    foreach (var pair in Cifra_Doremi_Dictionary)
                    {
                        lines[i] = lines[i].Replace(pair.Key, pair.Value);
                    }
                }
            }
            return string.Join(Environment.NewLine, lines);
        }

        public static string DoremiConvert(string input)
        {
            string _noTabs = RemoveTabs(input);
            string[] lines = _noTabs.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

            for (int i = 0; i < lines.Length; i++)
            {
                if (isChordLine(lines[i]) == true)
                {
                    foreach (var pair in Doremi_Cifra_Dictionary)
                    {
                        lines[i] = lines[i].Replace(pair.Key, pair.Value);
                    }
                }
            }
            return string.Join(Environment.NewLine, lines);
        }

        public static bool checkCifra(string input)
        {
            foreach (var pair in Cifra_Doremi_Dictionary)
            {
                if (input.Contains(pair.Key))
                {
                    return true;
                }
            }
            return false;
        }
        
        public static void ChangeTextColor(RichTextBox richTextBox1, string color)
        {

            richTextBox1.Text = richTextBox1.Text.Replace("\t", "      ");
            
            string[] linhas = richTextBox1.Lines;       
            

            for (int i = 0; i < linhas.Length; i++)
            { 
                if (isChordLine(linhas[i])==true)
                {                    
                    richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(i), linhas[i].Length);
                    Font currentFont = richTextBox1.SelectionFont;
                    float _newSize = richTextBox1.Font.Size;
                    richTextBox1.SelectionColor = Color.FromName(color);
                    richTextBox1.SelectionFont = new Font(currentFont, FontStyle.Bold);
                    //richTextBox1.SelectionFont = new Font(currentFont.FontFamily, _newSize, currentFont.Style | FontStyle.Bold);
                    //richTextBox1.SelectionFont = new Font(currentFont.FontFamily, _newSize, currentFont.Style);
                }
            }
        }

        public static void ChangeTextSize(RichTextBox richTextBox1, int _newSize)
        {
            //int _newSize = Convert.ToInt32(numericUpDownSize.Value);

            string[] linhas = richTextBox1.Lines;

            for (int i = 0; i < linhas.Length; i++)
            {
                if (isChordLine(linhas[i]))
                {
                    richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(i), linhas[i].Length);
                    Font currentFont = richTextBox1.SelectionFont;

                    richTextBox1.SelectionFont = new Font(currentFont.FontFamily, _newSize, currentFont.Style);

                }

            }
        }

        #region ADD REMOVE SPACE FROM LINES
        public static void RemoveSpaces(RichTextBox richTextBox)
        {            
            // Get all lines from the RichTextBox
            string[] lines = richTextBox.Lines;

            // Process each line individually
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                
                // Check if the line meets the specified condition
                if (isChordLine(line))
                {
                    // Regular expression to find groups of spaces between words
                    //string pattern = @"\b( )+\b";
                    string pattern = @"( )+\b";


                    // Update the line by replacing matches
                    string updatedLine = Regex.Replace(line, pattern, match =>
                    {
                        string spaces = match.Value;
                        // Reduce spaces to a minimum of two
                        return spaces.Length > 2 ? spaces.Substring(0, spaces.Length - 1) : spaces;
                    });

                    // Update the line in the array
                    lines[i] = updatedLine;
                }
            }

            // Set the updated lines back to the RichTextBox
            richTextBox.Lines = lines;
        }
        public static void AddSpaces(RichTextBox richTextBox)
        {
            // Get all lines from the RichTextBox
            string[] lines = richTextBox.Lines;

            // Process each line individually
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                // Check if the line meets the specified condition
                if (isChordLine(line))
                {
                    // Regular expression to find two or more spaces between words
                    //string pattern = @"\b( )+\b";
                    string pattern = @" {2,}";


                    // Update the line by replacing matches with a single space
                    //string updatedLine = Regex.Replace(line, pattern, " ");
                    string updatedLine = Regex.Replace(line, pattern, match => match.Value + " ");


                    // Update the line in the array
                    lines[i] = updatedLine;
                }
            }

            // Set the updated lines back to the RichTextBox
            richTextBox.Lines = lines;
        }
        #endregion

        #region MENU RIGHT CLICK JOIN LINES AND CHORDS
        public static string JoinTextLinesInTwo(string songText)
        {
            //string songText = richTextBox.Text;
            string[] lines = songText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            StringBuilder result = new StringBuilder();

            // Check if number of lines is odd
            bool isOdd = lines.Length % 2 != 0;
            
            for (int i = 0; i < lines.Length; i += 2)
            {
                // If an empty line is encountered, add it and continue to the next line
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    result.AppendLine();
                    i--; // Move back by one to continue checking with the next line
                    continue;
                }

                if (i + 1 < lines.Length)
                {
                    if (string.IsNullOrWhiteSpace(lines[i + 1]))
                    {
                        result.AppendLine(lines[i]); // Append only the first line if the second is empty
                        i--; // Move back by one to keep pairing correctly
                        continue;
                    }

                    // Group two lines into one
                    result.AppendLine(lines[i] + " " + lines[i + 1]);
                }
                else if (isOdd)
                {
                    // If odd, add the last line as it is
                    result.AppendLine(lines[i]);
                }                

            }
            return result.ToString().TrimEnd('\n');
        }

        public static string JoinLyricsWithChords(string inputText)
        {
            // Split the input text into lines
            string[] lines = inputText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();

            // Process each group of 4 lines
            for (int i = 0; i < lines.Length; i += 4)
            {
                // Check if there are enough lines left to process
                if (i + 3 < lines.Length)
                {
                    // Join lines 1 and 3 with a space
                    string spaces = "       ";
                    string newLine1 = $"{lines[i]} {spaces}  {lines[i + 2]}";
                    sb.Append(newLine1 + '\n');

                    // Join lines 2 and 4 with a space
                    string newLine2 = $"{lines[i + 1]} {lines[i + 3]}";
                    sb.Append(newLine2 + '\n');
                }
                else
                {
                    MessageBox.Show("Please select a group of 4 lines at a time.");
                    break; // Exit the loop if not enough lines remain
                }
            }
            return sb.ToString();
        }

        public static string RemoveChordsFromSelected(string inputText)
        {
            // Split the selected text into lines
            string[] lines = inputText.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            // Create a list to store the even-numbered lines (index-based, so 1st line is 0 index)
            List<string> evenLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                // If the line index is even, add it to the list (0-based index)
                if (i % 2 != 0) // Odd lines are at odd indices in a 0-based index system
                {
                    evenLines.Add(lines[i]);
                }
            }

            // Join the even lines back into a single string
            string newText = string.Join("\n", evenLines);
            
            return newText;
        }

        #endregion

        #region CHORD PRO CONVERT FUNTIOS

        public static string ConvertChordproToLyrics(string chordPro)
        {
            RemoveTabs(chordPro);

            var lines = chordPro.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            //var lines = chordPro.Split(new[] { "\n" }, StringSplitOptions.None);
            var result = new System.Text.StringBuilder();
            foreach (var line in lines)
            {
                string convertedLine = ConvertLine(line);
                result.AppendLine(convertedLine);
            }
            return result.ToString();
        }

        public static string ConvertLine(string line)
        {
            //help helpForm = new help();          

            var lyricsLine = new System.Text.StringBuilder();
            var chordsLine = new System.Text.StringBuilder();
            int i = 0;
            while (i < line.Length)
            {
                if (line[i] == '[')
                {
                    // Find the closing bracket index
                    int endIndex = line.IndexOf(']', i);
                    if (endIndex > i)
                    {
                        // Extract chord and append it to chords line
                        string chord = line.Substring(i + 1, endIndex - i - 1);
                        chordsLine.Append(chord);
                        //lyricsLine.Append('*', chord.Length); // Add spaces in lyrics line to align with chords
                        i = endIndex + 1;
                    }
                    else
                    {
                        lyricsLine.Append(line[i]);
                        chordsLine.Append(' ');
                        i++;
                    }
                }
                else
                {
                    lyricsLine.Append(line[i]);
                    chordsLine.Append(' '); // Espacos em branco da linha de acordes
                    i++;
                }

            }

            return chordsLine.ToString().TrimEnd() + '\n' + lyricsLine.ToString().TrimEnd();
            //return chordsLine.ToString() +'\n'+ lyricsLine.ToString();

        }

        public static string ProcessLine(string chordsLine, string lyricsLine)
        {
            string[] chords = chordsLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] lyricsWords = lyricsLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string result = "";
            int chordIndex = 0;
            foreach (var word in lyricsWords)
            {
                if (chordIndex < chords.Length)
                {
                    result += $"[{chords[chordIndex]}]{word} ";
                    chordIndex++;
                }
                else
                {
                    result += word + " ";
                }
            }
            //return result.Trim();
            return result;
        }

        public static string ConvertLyricsToChordpro(string songText)
        {
            //string songText = richTextBox.Text;
            string[] lines = songText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lines.Length; i += 2)
            {
                if (i + 1 < lines.Length)
                {
                    string chordsLine = lines[i];         // Linha de Acordes
                    string lyricsLine = lines[i + 1];     // Linha de Lyrics
                    int chordIndex = 0;

                    for (int j = 0; j < lyricsLine.Length; j++)   // Passa por cada caracter
                    {
                        if (chordIndex < chordsLine.Length && chordsLine[chordIndex] != ' ')
                        {
                            int endIndex = chordIndex;

                            while (endIndex < chordsLine.Length && chordsLine[endIndex] != ' ')
                            {
                                endIndex++;
                            }

                            if (endIndex > lyricsLine.Length)
                            {
                                int posicao = lyricsLine[j];
                                result.Append("");
                            }
                            string chord = chordsLine.Substring(chordIndex, endIndex - chordIndex).Trim();

                            result.Append($"[{chord}]");
                            chordIndex = endIndex;

                        }
                        else
                        {
                            chordIndex++;
                        }
                        result.Append(lyricsLine[j]);
                    }
                    result.AppendLine();
                }
            }

            return result.ToString().TrimEnd('\n');
            //richTextBox.Text = result.ToString().TrimEnd('\n');
        }

        public static string ConvertLyricsWithChordsToChordPro(string songText)
        {
            
            
            RemoveTabs(songText);

            //string songText = richTextBox.Text;
            string[] lines = songText.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lines.Length; i += 2)
            {
                if (i + 1 < lines.Length)
                {

                    string chordsLine = lines[i];         // Linha de Acordes
                    string lyricsLine = lines[i + 1];     // Linha de Lyrics
                    int chordIndex = 0;

                    for (int j = 0; j < lyricsLine.Length; j++)   // Passa por cada caracter
                    {
                        if (chordIndex < chordsLine.Length && chordsLine[chordIndex] != ' ')
                        {
                            int endIndex = chordIndex;

                            while (endIndex < chordsLine.Length && chordsLine[endIndex] != ' ')
                            {
                                endIndex++;
                            }

                            if (endIndex > lyricsLine.Length)
                            {
                                int posicao = lyricsLine[j];
                                result.Append("");
                            }
                            string chord = chordsLine.Substring(chordIndex, endIndex - chordIndex).Trim();

                            result.Append($"[{chord}]");
                            chordIndex = endIndex;

                        }
                        else
                        {
                            chordIndex++;
                        }
                        result.Append(lyricsLine[j]);
                    }
                    result.AppendLine();
                }
            }

            return result.ToString().TrimEnd('\n');
            //richTextBox.Text = result.ToString().TrimEnd('\n');
        }

        #endregion


    }
}
