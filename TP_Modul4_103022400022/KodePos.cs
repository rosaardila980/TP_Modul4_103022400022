using System;
using System.Collections.Generic;

namespace TP_Modul4_103022400022
{
    public class KodePos
    {
        public string getKodePos(string kelurahan)
        {
            Dictionary<string, string> tabelKodePos = new Dictionary<string, string>()
            {
                { "Batununggal", "40266" },
                { "Kujangsari",  "40287" },
                { "Mengger",     "40267" },
                { "Wates",       "40256" },
                { "Cijaura",     "40287" },
                { "Jatisari",    "40286" },
                { "Margasari",   "40286" },
                { "Sekejati",    "40286" },
                { "Kebonwaru",   "40272" },
                { "Maleer",      "40274" }
            };

            if (tabelKodePos.ContainsKey(kelurahan))
                return tabelKodePos[kelurahan];
            else
                return "Kelurahan tidak ditemukan";
        }
    }
}