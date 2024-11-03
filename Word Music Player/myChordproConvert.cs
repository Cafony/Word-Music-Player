using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Music_Player
{
    internal class myChordproConvert
    {

        public static string ConvertLyricsWithChordsToChordPro(string songText)
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
                                result.Append("SAIU");
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


        //====================================================================//
        public static string ConvertChordProToLyricsWithChords(string chordPro)
        {
            //var lines = chordPro.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            var lines = chordPro.Split(new[] { "\n" }, StringSplitOptions.None);
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
                        ///lyricsLine.Append(line[i]);
                        //chordsLine.Append(' ');
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

    }
}
