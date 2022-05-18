﻿// See https://aka.ms/new-console-template for more information


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

namespace csharp_biblioteca // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        //Definisco un tipo enum

        static void Main(string[] args)
        {
            int iAppo;
            iAppo = 0;

            Stato StatoLibro;
            StatoLibro = Stato.Disponibile;
            Console.WriteLine("Lo stato del libro è {0}", StatoLibro);

        }
    }
}
