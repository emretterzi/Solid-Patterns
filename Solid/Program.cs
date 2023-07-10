using System;
// Product (Ürün)

//Builder
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


//YAGNI

// İyi örnek: Basit bir hesap makinesi sınıfı

public class HesapMakinesi
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
}


// Kötü örnek: Gereksiz işlevsellik içeren bir hesap makinesi sınıfı

public class HesapMakinesi
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public int Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }

    public int Carp(int sayi1, int sayi2)
    {
        return sayi1 * sayi2;
    }

    public int Bol(int sayi1, int sayi2)
    {
        return sayi1 / sayi2;
    }

    public int ModAl(int sayi1, int sayi2)
    {
        return sayi1 % sayi2;
    }
}

//sadece toplama işlemi yapıcaksam  diğer gereksiz işlevleri kullanmama gerek yok




//OPEN CLOSED
using System;

public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class AreaCalculator  //Alan döndürme fonkiyuonu değişmeden 
//özelleştirebilmek

{
    public double CalculateArea(Shape shape)
    {
        return shape.Area();
    }
}


//LİSKOV


public abstract class Shape
{
    public abstract double Area();
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()
    {
        return Width * Height;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class AreaCalculator  //Alan döndürme fonkiyuonu değişmeden 
//özelleştirebilmek

{
    public double CalculateArea(Shape shape)
    {
        return shape.Area();
    }
}


//KISS

// İyi örnek: Basit bir hesap makinesi sınıfı

public class HesapMakinesi
{
    public int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
}


// Kötü örnek: Karmaşık hesaplamalar içeren bir hesap makinesi sınıfı

public class HesapMakinesi
{
    public int KarmaşıkHesaplama(int sayi1, int sayi2)
    {
        // Karmaşık hesaplama işlemleri...
        // ...
        return sonuc;
    }

    public int Topla(int sayi1, int sayi2)
    {
        // Toplama işlemi...
        // ...
        return sonuc;
    }

    public int ModAl(int sayi1, int sayi2)
    {
        // Mod alma işlemi...
        // ...
        return sonuc;
    }

    // Diğer karmaşık metodlar...
}

//KIS PRENSİBİ BASİT TUTMAYA YÖNELİK BİR PRENSİB



//INTERFACE SEGREGATİON
public interface IEmailService
{
    void SendEmail(string emailAddress, string message);
}

public class EmailService : IEmailService
{
    public void SendEmail(string emailAddress, string message)
    {
        Console.WriteLine($"Sending email to: {emailAddress}");
        Console.WriteLine($"Message: {message}");
    }
}

public class NotificationService
{
    private readonly IEmailService emailService;

    public NotificationService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void SendEmail(string emailAddress, string message)
    {
        emailService.SendEmail(emailAddress, message);
    }
}



// DEPENDCY İNVERSİON

// Soğutucu arayüzü
public interface ISogutucu
{
    void SogutmaIslemiUygula();
}

// Soğutucu modülü
public class SogutucuModul : ISogutucu
{
    public void SogutmaIslemiUygula()
    {
        Console.WriteLine("Soğutma işlemi uygulanıyor...");
    }
}

// Üst seviye modül
public class UstSeviyeModul
{
    private ISogutucu sogutucu;

    public UstSeviyeModul(ISogutucu sogutucu)
    {
        this.sogutucu = sogutucu;
    }

    public void Calistir()
    {
        sogutucu.SogutmaIslemiUygula();
    }
}

// Kullanım
public class Program
{
    public static void Main()
    {
        ISogutucu sogutucu = new SogutucuModul();
        UstSeviyeModul ustSeviyeModul = new UstSeviyeModul(sogutucu);
        ustSeviyeModul.Calistir();
    }
}



//BUİLDER PATTERN


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





