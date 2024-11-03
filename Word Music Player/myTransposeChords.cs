using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    internal class myTransposeChords
    {       
        
        private readonly string[] indexToChord = new string[]
        { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

        static Dictionary<string, int> chordToIndex = new Dictionary<string, int>
        {
            { "C", 0 }, { "C#", 1 }, { "Db", 1 }, { "D", 2 }, { "D#", 3 }, { "Eb", 3 },
            { "E", 4 }, { "F", 5 }, { "F#", 6 }, { "Gb", 6 }, { "G", 7 }, { "G#", 8 }, { "Ab", 8 },
            { "A", 9 }, { "A#", 10 }, { "Bb", 10 }, { "B", 11 }
        };


        //==================================================================================
        private bool isChordLines(string line)
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

        }  // FUNCAO FEITA POR MIM SE É LINHA DE ACORDES

        public string RemoveTabs(string _richtext)
        {   
            var tabLength = 6;
            var tabSpace = new string(' ', tabLength);
            string _text = _richtext.Replace("\t", tabSpace);
            return _text;           
        }

        #region TRANSPOSE FUNTION 
        public string TransposeChords(string input, int transposeAmount)
        {
            string[] lines = input.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);


            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace("(", "( ").Replace("/", "/ ");

                lines[i] = TransposeLine(lines[i], transposeAmount);
                lines[i] = lines[i].Replace("( ", "(").Replace("/ ", "/");
            }
            return string.Join(Environment.NewLine, lines);
        }

        private string TransposeLine(string line, int transposeAmount)
        {
            string[] words = line.Split(' ');

            if (isChordLines(line) == true)   //============Verifica se é linha acordes
            {
                //=============FUNCAO DO CHAT==========================
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];

                    string rootChord = GetRootChord(word);
                    if (rootChord != null)
                    {
                        int rootChordIndex = chordToIndex[rootChord];
                        string suffix = word.Substring(rootChord.Length);
                        int newIndex = (rootChordIndex + transposeAmount + 12) % 12;
                        words[i] = indexToChord[newIndex] + suffix;
                    }
                }
            }
            return string.Join(" ", words);
        }

        private string GetRootChord(string word)
        {
            foreach (var chord in chordToIndex.Keys.OrderByDescending(c => c.Length))
            {
                if (word.StartsWith(chord))
                {
                    return chord;

                }
            }
            return null; // Return null if no chord is found
        }

        #endregion
    
    



    }
}
