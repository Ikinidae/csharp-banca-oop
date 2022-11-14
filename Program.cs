Banca fineco = new Banca("Fineco");
//utenti
fineco.AggiungiCliente("sandro", "ficini", "prova", 500);
fineco.AggiungiCliente("federica", "elia", "fdrela45677", 1500);
fineco.AggiungiCliente("pippo", "ippo", "ppppp3457", 500);
fineco.AggiungiCliente("chicco", "pepe", "cccpp4859", 800);
//copia che non viene stampata grazie al controllo sui doppioni
fineco.AggiungiCliente("sandro", "ficini", "fcnsdr9327", 500);

//prestiti
fineco.AggiungiPrestito(2000, 200, DateOnly.FromDateTime(DateTime.Now), DateOnly.Parse("12/12/2023"), "prova");
fineco.AggiungiPrestito(3000, 300, DateOnly.FromDateTime(DateTime.Now), DateOnly.Parse("12/12/2023"), "prova");


Console.WriteLine("Seleziona l'azione");
Console.WriteLine("0: Lista clienti");
Console.WriteLine("1: Modifica utente");
Console.WriteLine("2: Cerca cliente");
Console.WriteLine("3: Aggiungi un prestito");
Console.WriteLine("4: Cerca un prestito");
Console.WriteLine("5: Stampa tutti i prestiti");


int action = Convert.ToInt32(Console.ReadLine());
switch (action)
{
    case 0:
        //Lista clienti
        fineco.StampaListaClienti();
        break;

    case 1:
        //Modifica utente
        Console.WriteLine("Inserisci il codice fiscale dell'utente che vuoi modificare");
        string userInput = Console.ReadLine();
        Console.WriteLine("Inserisci in ordine i dati da modificare (nome, cognome, cod fiscale, stipendio");
        string inputNome = Console.ReadLine();
        string inputCognome = Console.ReadLine();
        string inputCodFiscale = Console.ReadLine();
        int inputStipendio = Convert.ToInt32(Console.ReadLine());
        fineco.ModificaCliente(userInput, inputNome, inputCognome, inputCodFiscale, inputStipendio);
        break;

    case 2:
        //Cerca cliente
        Console.WriteLine("Inserisci il codice fiscale dell'utente che vuoi cercare");
        string userInputRicerca = Console.ReadLine();
        Cliente cercaCliente = fineco.RicercaCliente(userInputRicerca);
        if (cercaCliente != null)
            Console.WriteLine("nome: " + cercaCliente.Nome + ", stipendio: " + cercaCliente.Stipendio);
        break;

    case 3:
        //Aggiungi un prestito
        Console.WriteLine("Inserisci in ordine i dati dal prestito (ammontare prestito, valore rata, fine prestito, cod fiscale)");
        int ammontare = Convert.ToInt32(Console.ReadLine());
        int valoreRata = Convert.ToInt32(Console.ReadLine());
        var dateNow = DateOnly.FromDateTime(DateTime.Now);
        var dateEnd = DateOnly.Parse(Console.ReadLine());
        string inputCodFiscaledue = Console.ReadLine();

        fineco.AggiungiPrestito(ammontare, valoreRata, dateNow, dateEnd, inputCodFiscaledue);
        fineco.AggiungiPrestito(1500, 150, dateNow, dateEnd, "fdrela45677");

        break;

    case 4:
        //Cerca prestito
        Console.WriteLine("Inserisci il codice fiscale dell'utente associato al prestito che vuoi cercare");
        string userInputPrestito = Console.ReadLine();
        Prestito cercaPrestito = fineco.RicercaPrestito(userInputPrestito);
        if (cercaPrestito != null)
            Console.WriteLine("------------");
        Console.WriteLine("id prestito: " + cercaPrestito.ID);
        Console.WriteLine("Ammontare prestito: " + cercaPrestito.Ammontare);
        Console.WriteLine("ValoreRata prestito: " + cercaPrestito.ValoreRata);
        Console.WriteLine("Inizio prestito: " + cercaPrestito.Inizio);
        Console.WriteLine("Fine prestito: " + cercaPrestito.Fine);
        Console.WriteLine("Intestatario prestito: " + cercaPrestito.Intestatario.Cognome);
        break;

    case 5:
        //Stampa lista prestiti
        fineco.StampaListaPrestiti();
        break;
}
