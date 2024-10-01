using Vetores;

Vetor vetor = new Vetor(5);

try
{
    vetor.Adiciona("Maçã");
    vetor.Adiciona("Laranja");
    vetor.Adiciona("Bergamota");
    vetor.Adiciona("Banana");
    vetor.Adiciona("Ameixa");

    Console.WriteLine($"Quantidade de elementos do vetor: {vetor.Tamanho()}");
    Console.WriteLine(vetor);


}
catch (Exception)
{
	throw;
}