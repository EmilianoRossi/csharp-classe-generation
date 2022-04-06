//ESERCIZIO CLASSE GENERATION

//----------- VARIABILI GLOBALI --------------
int numeroPostiADisposizione = 0;
int massimoNumeriPosti = 2;

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
        Console.Write(nomeAlunni[numeroPostiADisposizione] + " ");
        Console.Write(cognomeAlunni[numeroPostiADisposizione] + " ");
        Console.WriteLine(annoDiProduzione[numeroPostiADisposizione]);
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

//Funzione calcolo media
void EtàMedia(int[] array)
{

    int sommaArray = 0;
    int media = 0;
    for (int i = 0; i < array.Length; i++)
    {

        sommaArray = sommaArray + (int)array[i];
        media = sommaArray / massimoNumeriPosti;

    }
    Console.WriteLine("La media è: " + media);

}


//Calcolo età maggiore 

int etàPiuGrande(int[] array)
{
    int j = 0;
    int etàMaggiore = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (etàMaggiore < array[i])
        {
            etàMaggiore = array[i];
            j = i;
        }
    }
    return j;
}

//Età piu piccolo
//Calcolo età maggiore 

int etàPiuPiccolo(int[] array)
{
    int j = 0;
    int etàMaggiore = 400;
    for (int i = 0; i < array.Length; i++)
    {
        if (etàMaggiore > array[i])
        {
            etàMaggiore = array[i];
            j = i;
        }
    }
    return j;
}

//------------ PROGRAMMA PRINCIPALE ----------------


while (true)
{
    Console.WriteLine("Opzioni : aggiungi / rimuovi / media / grande / piccolo");
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

        case "media":
            EtàMedia(annoDiProduzione);
            break;

        case "grande":
            int indice = etàPiuGrande(annoDiProduzione);
            Console.WriteLine("l'alunno piu grande è: " + nomeAlunni[indice] + " " + cognomeAlunni[indice] + "--" + annoDiProduzione[indice] + " anni" );
            etàPiuGrande(annoDiProduzione);
            break;

        case "piccolo":
            int indice2 = etàPiuPiccolo(annoDiProduzione);
            Console.WriteLine("l'alunno piu piccolo è: " + nomeAlunni[indice2] + " " + cognomeAlunni[indice2] + "--" + annoDiProduzione[indice2] + " anni");
            etàPiuGrande(annoDiProduzione);
            break;
        default:
            Console.WriteLine("Mi dispiace non è un opzione accettata");
            break;
    }
    
}
/*for (int i = 0; i < massimoNumeriPosti; i++)
{
    Console.Write(nomeAlunni[i] + "      ,      ");
    Console.Write(cognomeAlunni[i] + "      ,      ");
    Console.WriteLine(annoDiProduzione[i]);
}
*/