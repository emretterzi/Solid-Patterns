using System;
// Product (Ürün)
class Coffee
{
    public string Type { get; set; }
    public int Sugar { get; set; }
    public bool Milk { get; set; }
}

// Builder (Oluşturucu)
interface ICoffeeBuilder
{
    void SetType(string type);
    void SetSugar(int sugar);
    void SetMilk(bool milk);
    Coffee Build();
}

// ConcreteBuilder (Somut Oluşturucu)
class CoffeeBuilder : ICoffeeBuilder
{
    private Coffee coffee;

    public CoffeeBuilder()
    {
        coffee = new Coffee();
    }

    public void SetType(string type)
    {
        coffee.Type = type;
    }

    public void SetSugar(int sugar)
    {
        coffee.Sugar = sugar;
    }

    public void SetMilk(bool milk)
    {
        coffee.Milk = milk;
    }

    public Coffee Build()
    {
        return coffee;
    }
}

// Director (Yönetici)
class CoffeeMachine
{
    private ICoffeeBuilder coffeeBuilder;

    public CoffeeMachine(ICoffeeBuilder builder)
    {
        coffeeBuilder = builder;
    }

    public Coffee MakeCoffee(string type, int sugar, bool milk)
    {
        coffeeBuilder.SetType(type);
        coffeeBuilder.SetSugar(sugar);
        coffeeBuilder.SetMilk(milk);
        return coffeeBuilder.Build();
    }
}

