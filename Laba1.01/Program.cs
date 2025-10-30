// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Laba1._01;
using System.Runtime.CompilerServices;
using static Laba1._01.AbstractFactory;
using static Laba1._01.Builder;
using static Laba1._01.MethodFactory;
using static Laba1._01.CreateCar;

class Program
{
    static void Main()
    {
        //проверка работы AbstractFactory  для реализации можно выбрать RestoranFactory, CafeFactory, OfficeFactory
        AbstractEquiomentFactory factory = new RestoranFactory();

        var mashine = factory.CreateCoffeeMachine();
        var grinder = factory.CreateCoffeeGrinder();
        var beans = factory.CreateCoffeeBeans();

        Console.WriteLine(mashine.Brewing());
        Console.WriteLine(grinder.Grinding());
        Console.WriteLine(beans.AddCoffee());


        // проверка работы Build
        var americanoSome = new AmericanoBuilder();
        americanoSome.AddEspresso();
        americanoSome.AddWater();
        DrinkSome americano = americanoSome.GetDrink();

        var capuchinoSome = new CapuchinoBuilder();
        capuchinoSome.AddEspresso();
        capuchinoSome.AddMilk();
        DrinkSome capuchino = capuchinoSome.GetDrink();

        var capuchinoSome2 = new CapuchinoWithAlmondMilkBuilder();
        capuchinoSome2.AddEspresso();
        capuchinoSome2.AddMilk();
        capuchinoSome2.AddSyrop();
        DrinkSome capuchino2 = capuchinoSome2.GetDrink();

        // для реализации можно выбрать capuchino2, capuchino, americano
        Console.WriteLine(capuchino2);


        //реализация Method Factory  можно выбрать Crab, Cheez, Paprica
        MethodFactory.Creator c = new MethodFactory.CreatorLaseCrab();
        c.AddTaste();

        // реализация Single Ton    можно выбрать Starbucks, Kafema, Coffee Brew
        Singleton.CurrentCoffeeShop.Instance.AddCoffeeShop("Kafema");

        var shop = Singleton.CurrentCoffeeShop.Instance.GetCoffeeShop();
        Console.WriteLine(shop);


        //реализация Prototype
        var Latte = new Drink("Latte", "Large", new List<string> { "syrop", "cinnamon" });
        var Americano = new Drink("Americano", "smal", new List<string> { });
        var copy = (Drink)Latte.Clone();
        var copy1 = (Drink)Americano.Clone();
        copy.Strings.Add("cream");
        Console.WriteLine(copy1);


        //// проверка Car
        var audi = new Audi();
        var volvo = new Volvo();
        var abrams = new Abrams();
        var tiger = new Tiger();
        var man = new Man();
        var honda = new Honda();
        var tesla = new Tesla();
        var scania = new Scania();
        var merkava = new Merkava();
        CreateCar.Scania scania1 = new Scania();

        Console.WriteLine(scania1);
    }
}