using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Odtwarzacz_muzyki_v2
{
    class Import
    {
        
        public static List<string> import_lokalizacja(string lokalizacja)
        {
            string rozszezenia = "*.mp3,*.wav";

            var pliki = Directory.GetFiles(lokalizacja, "*.*", SearchOption.AllDirectories).Where(s => rozszezenia.Contains(Path.GetExtension(s).ToLower()));

            List<string> Lista_piosenek = pliki.ToList();

            return Lista_piosenek;
        }

        public static List<string> import_nazwa(string lokalizacja)
        {           
            string rozszezenia = "*.mp3,*.wav";

            var pliki = Directory.GetFiles(lokalizacja, "*.*", SearchOption.AllDirectories).Where(s => rozszezenia.Contains(Path.GetExtension(s).ToLower()));

            List<string> Lista_Piosenek_Nazwa = new List<string>();

            foreach (var plik in pliki)
            {
                Lista_Piosenek_Nazwa.Add(Path.GetFileName(plik));
            }

            return Lista_Piosenek_Nazwa;
        }
    }
}
