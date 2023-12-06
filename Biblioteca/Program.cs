using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class documenti
    {
        public string codice { get; set; }
        public string titolo { get; set; }
        public int anno { get; set; }
        public string settore { get; set; }
        public string stato { get; set; }
        public documenti(string codice, string titolo, int anno, string settore, string stato)
        {
            this.codice = codice;
            this.titolo = titolo;
            this.anno = anno;
            this.settore = settore;
            this.stato = stato;
        }
        class libri : documenti
        {
            public int nPagine { get; set; }
            public libri(string codice, string titolo, int anno, string settore, string stato, int nPagine) : base(codice, titolo, anno, settore, stato)
            {
                this.nPagine = nPagine;
            }
        }
        class dvd
        {
            public int durata { get; set; }
            public dvd(string codice, string titolo, int anno, string settore, string stato, int durata) : base(codice, titolo, anno, settore, stato)
            {
                this.durata = durata;
            }
        }
        class persona : documenti
        {
            public string nome { get; set; }
            public string cognome { get; set; }
            public persona(string codice, string titolo, int anno, string settore, string stato, string nome, string cognome) : base(codice, titolo, anno, settore, stato)
            {
                this.nome = nome;
                this.cognome = cognome;
            }
        }
        class prestiti : documenti
        {
            public int nPrestiti { get; set; }
            public prestiti(string codice, string titolo, int anno, string settore, string stato, int nPrestiti): base(codice, titolo, anno, settore, stato)
            {
                this.nPrestiti = nPrestiti;
            }

        }
        class utente:persona
        {
            public string email { get; set; }
            public string password { get; set; }
            public int telefono { get; set; }
            public utente(string codice, string titolo, int anno, string settore, string stato, string nome, string cognome,string email,string password,int telefono) : base(codice, titolo, anno, settore, stato, nome, cognome)
            {
                this.email = email;
                this.password = password;
                this.telefono = telefono;
            }
        }


        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
