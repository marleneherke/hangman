using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Game
    {
        // Klassenvariablen für die Klasse games. 
        public int fehlVersuche = 11;
        public string currentWord = "";
        public List<char> letters = new List<char>(); 

        // Checks if the word only contains letters. Create the currentWord with the correct number of '_'.
        public bool CheckWord(string WortEingabe)
        {
            bool result = WortEingabe.All(Char.IsLetter);
            int laenge = WortEingabe.Length;

            for (int i = 0; i < laenge; i++)
            {
                currentWord += '_';
            }
            return result;
        }

        // Manages the lifes of the player, game organisation.
        public string Play(char buchstabe, string wort)
        {
            string rueckgabe;
            letters.Add(buchstabe);

            currentWord = ChangeCurrentWord(wort, buchstabe);
            while (fehlVersuche > 0)
            {
                if (!wort.Contains(buchstabe) && currentWord.Contains('_'))
                {
                    fehlVersuche = fehlVersuche - 1;
                    rueckgabe = $"Falscher Buchstabe! Sie haben noch {fehlVersuche} Versuche.";
                    return rueckgabe + currentWord;
                }
                else if (wort.Contains(buchstabe) && currentWord.Contains('_'))
                {
                    rueckgabe = "Super! Sie haben richtig geraten!";
                    return rueckgabe + currentWord;
                }
                else if (wort.Equals(currentWord))
                {
                    rueckgabe = "SIE HABEN GEWONNEN!!";
                    return rueckgabe + currentWord; 
             
                }
              
            }
            rueckgabe = "Das Spiel ist vorbei! GAMEOVER" + currentWord;
            return rueckgabe;
        }
     

        // Change '_' if the given letter is correct.
        public string ChangeCurrentWord(string givenWord, char buchstabe)
        {          

            for (int j = 0; j < givenWord.Length; j++)
            {
                if (givenWord[j].Equals(buchstabe))
                {                 
                    StringBuilder sb = new StringBuilder(currentWord);
                    sb[j] = buchstabe;
                    currentWord = sb.ToString();
                }
            }
            return currentWord;
        }

    }
}

