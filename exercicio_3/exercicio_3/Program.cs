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

//2. Decorator - classe dos adicionais 
public abstract class  BebidaDecorator : IBebida
{
    protected IBebida bebidaAtual;
    public BebidaDecorator(IBebida bebida)
    {
        this.bebidaAtual = bebida;
    }

    //só passa a chamada para a bebida que esta "dentro"
    public virtual string GetDescricao() => bebidaAtual.GetDescricao();
    public virtual double GetPreco() => bebidaAtual.GetPreco();
}

// 3. Decorators concretos (os adicionais, que herdam do BebidaDecorator)
public class Leite : BebidaDecorator
{   
    //repassa para o construtor da classe pai
    public Leite(IBebida bebida) : base(bebida) { }
    public override string GetDescricao()
    {
        return base.bebidaAtual.GetDescricao() + ", Leite";
    } 
    public override double GetPreco()
    {
        return base.bebidaAtual.GetPreco() + 2.0;
    } 
}

public class Chantilly : BebidaDecorator
{
    public Chantilly(IBebida bebida) : base(bebida) { }
    public override string GetDescricao()
    {
        return base.bebidaAtual.GetDescricao() + ", Chantilly";
    }
    public override double GetPreco()
    {
        return base.bebidaAtual.GetPreco() + 3.0;
    }
}

public class Canela : BebidaDecorator
{
    public Canela(IBebida bebida) : base(bebida) { }
    public override string GetDescricao()
    {
        return base.bebidaAtual.GetDescricao() + ", Canela";
    }
    public override double GetPreco()
    {
        return base.bebidaAtual.GetPreco() + 1.0;
    }
}

public class CaldaChocolate : BebidaDecorator
{
    public CaldaChocolate(IBebida bebida) : base(bebida) { }
    public override string GetDescricao()
    {
        return base.bebidaAtual.GetDescricao() + ", Calda de Chocolate";
    }
    public override double GetPreco()
    {
        return base.bebidaAtual.GetPreco() + 1.5;
    }
}