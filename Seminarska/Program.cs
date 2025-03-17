internal class Program
{
    private static void Main(string[] args)
    {
        int[] zaporedje = { 3, 7, 1, 2, 8, 4, 5 }; //zaporedje števil shranjeno v enodimenzionalni tabeli
        int dejanskaVsota = 0; //dejanska vsota vseh števil v zaporedju
        int dolzina = zaporedje.Length + 1; //dolžina zaporedja se shrani ter prišteje +1
        int pricakovanaVsota = dolzina * (dolzina + 1) / 2; //izračunamo pričakovano vsoto števil v zaporedju z uporabo formule x = n(n+1)/2, ki izračuna vsoto n naravnih števil

        for (int i = 0; i < zaporedje.Length; i++) //zanka izračuna vsoto vseh števil v zaporedju
        {
            dejanskaVsota += zaporedje[i]; //vsako število prištejemo v spremenljivko
        }

        int manjkajocaStevilka = pricakovanaVsota - dejanskaVsota; //rezultat izračunamo z odštevanjem pričakovane in dejanske vsote

        Console.WriteLine("V zaporedju:");
        for (int i = 0; i < zaporedje.Length; i++)
        {
            Console.Write(zaporedje[i] + ", "); //izpišemo zaporedje
        }
        Console.WriteLine("\nJe manjkajoča številka "+manjkajocaStevilka); //izpišemo rezultat
    }
}