using System;

// 1. interface comum para as bebidas
public interface IBebida
{
    string GetDescricao();
    double GetPreco();
}

// bebidas base (ainda sem complementos)
public class CafeExpresso : IBebida
{
    public string GetDescricao() => "Café Expresso";
    public double GetPreco() => 6.0;
}
public class Capuccino : IBebida
{
    public string GetDescricao() => "Capuccino";
    public double GetPreco() => 8.0;
}
public class Cha : IBebida
{
    public string GetDescricao() => "Chá";
    public double GetPreco() => 4.0;
}