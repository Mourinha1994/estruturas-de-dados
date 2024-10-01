﻿namespace Vetores;

internal class Vetor
{
    private string[] _elementos { get; set; }
    private int _tamanho { get; set; }

    public Vetor(int capacidade)
    {
        _elementos = new string[capacidade];
        _tamanho = 0;
    }

    public void Adiciona(string elemento)
    {
        if (_tamanho < _elementos.Length)
        {
            _elementos[_tamanho] = elemento;
            _tamanho++;
        }
        else
        {
            throw new Exception($"Vetor cheio! Não é possivel adicionar {elemento}");
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
