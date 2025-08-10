class Carta
{
    int Valor;

}

class Jogador
{

    Carta Carta;
}

class Baralho
{
    List<Carta> Cartas;

    Carta DarCarta()
    {
        int posicaoPrimeoraCarta = 0;
        Carta carta = Cartas[posicaoPrimeoraCarta];
        Cartas.RemoveAt(posicaoPrimeoraCarta);
        return carta;

    }
    void Embaralhar()
    {
        var rand = new Random();
        Cartas = Cartas.OrderBy(x => rand.Next()).ToList();
    }

}