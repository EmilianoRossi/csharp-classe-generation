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

void DecrementaAlunno()
{
    if (massimoNumeriPosti == numeroPostiADisposizione)
    {

        numeroPostiADisposizione--;
        nomeAlunni[massimoNumeriPosti - 1] = "";
        cognomeAlunni[massimoNumeriPosti - 1] = "";
        annoDiProduzione[massimoNumeriPosti - 1] = 0;

    }

}

//------------ PROGRAMMA PRINCIPALE ----------------
Console.WriteLine("Dimmi il tuo numero iniziale di alunni in aula");
numeroPostiADisposizione = int.Parse(Console.ReadLine());


while (true)
{
    Console.WriteLine("Vuoi aggiungere o rimuovere un alunno [aggiungi/rimuovi]?");
    string risposta = Console.ReadLine();

    switch (risposta)
    {
        case "aggiungi":
            Console.WriteLine("Inserisci nome alunno");
            string nomeAlunno = Console.ReadLine();
            Console.WriteLine("Inserisci cognome alunno");
            string cognomeAlunno = Console.ReadLine();
            Console.WriteLine("Dimmi età dell'alunno: ");
            int etàAlunno = int.Parse(Console.ReadLine());
            AggiungiAlunno(nomeAlunno, cognomeAlunno, etàAlunno);
            break;

        case "rimuovi":
            DecrementaAlunno();
            Console.WriteLine("Ci dispiace ma non c'è piu posto in aula");
            break;

        default:
            Console.WriteLine("Mi dispiace non è un opzione accettata");
            break;
    }
}