public class Prestito
{
    //attributi
    public static int ultimoIdInserito = 0;
    private int ammontarePrestito;

    //costruttori

    //prestito in partenza dalla data specificata
    public Prestito(int ammontare, int valoreRata, DateOnly inizio, DateOnly fine, Cliente intestatario)
    {
        ultimoIdInserito += 1;
        ID = ultimoIdInserito;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        Inizio = inizio;
        Fine = fine;
        Intestatario = intestatario;
    }

    //un prestito in data di oggi
    public Prestito(int ammontare, int valoreRata, DateOnly fine, Cliente intestatario)
    {
        ultimoIdInserito += 1;
        ID = ultimoIdInserito;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        //data di oggi
        Inizio = new DateOnly();
        Fine = fine;
        Intestatario = intestatario;
    }

    //proprietà 
    public int ID { get; set; }
    public int Ammontare { get; set; }
    public int ValoreRata { get; set; }
    public DateOnly Inizio { get; set; }
    public DateOnly Fine { get; set; }
    public Cliente Intestatario { get; set; }
}