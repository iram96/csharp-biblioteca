namespace csharp_biblioteca
{
    internal class Library
    {
        public void AggiungiUtente(Person uUtente, List<Person> pList)
        {
            string sChiaveUtente = uUtente.Name.ToLower() + ";"
                + uUtente.Surname.ToLower() + ";"
                + uUtente.Email.ToLower();
            pList.Add(sChiaveUtente, uUtente);
        }
        /*public bool AggiungiUtente(string sNome, string sCognome, string sMail)
        {
            //Costruite l'istanza di utente
            //Aggiungi al dizionario.
            string sChiaveUtente = sNome + ";" + sCognome + ";" + sMail;
            MyDictionary.Add(sChiaveUtente, uUtente);
        }*/
    }
}
