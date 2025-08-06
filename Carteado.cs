List<int> baralho = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

List<int> embaralhar(List<int> baralho)
{
    Random rand = new Random();
    return baralho.OrderBy(x => rand.Next()).ToList();
}

int darCarta(List<int> baralho)
{
    int posicaoPrimeoraCarta = 0;
    int carta = baralho[posicaoPrimeoraCarta];
    baralho.RemoveAt(posicaoPrimeoraCarta);
    return carta;
}

List<int> baralhoEmbaralhado = embaralhar(baralho);
int carta1 = darCarta(baralhoEmbaralhado);
int carta2 = darCarta(baralhoEmbaralhado);

var jogador1 = carta1;
var jogador2 = carta2;

if (jogador1 > jogador2)
{
    Console.WriteLine($"Jogador 1 venceu com a carta {jogador1} vs carta: {jogador2}");
}
else if (jogador2 > jogador1)
{
    Console.WriteLine($"Jogador 2 venceu com a carta {jogador2} vs carta: {jogador1}");
}
else
{
    Console.WriteLine("Empate! Ambos os jogadores tiraram a carta " + jogador1);
}