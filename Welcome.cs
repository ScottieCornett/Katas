using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public static class Welcome
    {
        public static string Greet(string language)
        {
            
            Dictionary<string, string> languageDictionary = new Dictionary<string, string>
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"}
            };

            string greeting;
            string defaultGreeting = "Welcome";
            
            if (languageDictionary.TryGetValue(language, out greeting))
            {
                greeting = languageDictionary[language];
            }
            else
            {
                return defaultGreeting;
            }

            return greeting;
                                            
        }
    }
}
