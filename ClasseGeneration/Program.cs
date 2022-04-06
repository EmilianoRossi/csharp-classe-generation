//ESERCIZIO CLASSE GENERATION

//----------- VARIABILI GLOBALI --------------
int numeroPostiADisposizione = 0;
int massimoNumeriPosti = 5;

string[] nomeAlunni = new string[massimoNumeriPosti];
string[] cognomeAlunni = new string[massimoNumeriPosti];
int[] annoDiProduzione = new int[massimoNumeriPosti];


//----------- DICHIAMO LE MIE FUNZIONI ------------
void AggiungiAlunno(string nome, string cognome, int età)
{
    if (numeroPostiADisposizione < massimoNumeriPosti)
    {
        nomeAlunni[numeroPostiADisposizione] = nome;
        cognomeAlunni[numeroPostiADisposizione] = cognome;
        annoDiProduzione[numeroPostiADisposizione] = età;
        numeroPostiADisposizione++;

    }
    else
    {
        Console.WriteLine("Posti in aula disponibili terminati");
    }

}