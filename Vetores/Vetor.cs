namespace Vetores;

internal class Vetor
{
    private string[] _elementos { get; set; }

    public Vetor(int capacidade)
    {
        _elementos = new string[capacidade];
    }

    public void Adiciona(string elemento)
    {
        for (int i = 0; i < _elementos.Length; i++)
        {
            if (_elementos[i] == null)
            {
                _elementos[i] = elemento;
                break;
            }
        }
    }

    public void Adiciona(int posicao, string elemento)
    {

    }

    public void Remove(int posicao)
    {

    }

    public string Busca(int posicao)
    {
        return "";
    }

    public string Busca(string elemento)
    {
        return "";
    }

    public int Tamanho()
    {
        return 0;
    }
}
