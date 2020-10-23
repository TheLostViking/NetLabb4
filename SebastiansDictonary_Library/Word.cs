using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebastiansDictionary_Library
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        //initialiserar 'Translations' med data som skickas in som ' translations'.
        public Word(params string[] translations)
        {
            
            Translations = translations;
        }

        //Gör samma som ovan men sätter även FromLanguage och ToLanguage.
        public Word(int fromLanguage, int toLanguange, params string[] translations)
        {
            
            FromLanguage = fromLanguage;
            ToLanguage = toLanguange;
            Translations = translations;
        }
    }
}
