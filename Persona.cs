
/* 
 * Si vuole progettare un sistema per la gestione di una biblioteca.
Gli utenti registrati al sistema, fornendo:

cognome, nome, email, password, recapito telefonico,
possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD).

I documenti sono caratterizzati da un codice identificativo di tipo stringa 
(ISBN per i libri, numero seriale per i DVD), titolo, anno, settore 
(storia, matematica, economia, …),
stato (In Prestito, Disponibile), uno scaffale in cui è posizionato,
un elenco di autori (Nome, Cognome).

Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente,
effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.

Il sistema per ogni prestito determina un numero progressivo di tipo alfanumerico.

Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome
di un utente.
 */
namespace csharp_biblioteca
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Cell { get; set; }


        public Person(string sName, string sSurname, string sEmail, string sPassword, int iCell)
        {
            this.Name = sName;
            this.Surname = sSurname;
            this.Email = sEmail;
            this.Password = sPassword;
            this.Cell = iCell;

        }
    }

    class PersonList
    {
        private Dictionary<string, Person> pList;

        public PersonList()
        {
            pList = new Dictionary<string, Person>();
        }


    }


    public enum Stato { Disponibile, InPrestito }

    public class Document
    {
        public string ISBN { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }

        private Stato stato;

        public string Scaffale { get; set; }
        public List<string> Autori { get; set; }

        public Document(string sISBN, string sTitolo, int iAnno, string sSettore, Stato _stato, string sScaffale, List<string> lAutori)
        {
            this.ISBN = sISBN;
            this.Titolo = sTitolo;
            this.Anno = iAnno;
            this.Settore = sSettore;
            this.stato = _stato;
            this.Scaffale = sScaffale;
            this.Autori = lAutori;
        }


        public void CercaDocumento(string Codice, string Titolo)
        {

        }

    }

    class Book : Document
    {
        public int NumeroPagine { get; }

        public Book(string sISBN, string sTitolo, int iAnno, string sSettore, Stato _stato, string sScaffale, List<string> lAutori, int iNumeroPag) : base(sISBN, sTitolo, iAnno, sSettore, _stato, sScaffale, lAutori)
        {
            this.NumeroPagine = iNumeroPag;


        }



    }

    class Movie : Document
    {
        public int DurataMinuti { get; }
        public Movie(string sISBN, string sTitolo, int iAnno, string sSettore, Stato _stato, string sScaffale, List<string> lAutori, int iDurataMinuti) : base(sISBN, sTitolo, iAnno, sSettore, _stato, sScaffale, lAutori)
        {

            this.DurataMinuti = iDurataMinuti;
        }


    }
}
