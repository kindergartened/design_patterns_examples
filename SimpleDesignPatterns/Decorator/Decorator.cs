namespace SimpleDesignPatterns;

using System;
/// <summary>
/// Интерфейс, представляющий напиток с обобщенным параметром типа `T`
/// </summary>
/// <typeparam name="T">Тип напитка, реализующего этот интерфейс.</typeparam>
public interface IBeverage<out T> where T : IBeverage<T>
{
    string? Description { get; set; }
    double Cost { get; set; }
    string GetDescription();
    double GetCost();
}
/// <summary>
/// Конкретный класс, представляющий напиток "Эспрессо".
/// </summary>
public class Espresso : IBeverage<Espresso>
{
    public Espresso()
    {
        Description = "Эспрессо";
        Cost = 49;
    }

    public string? Description { get; set; }
    public double Cost { get; set; }

    public string GetDescription() => Description!;

    public double GetCost() => Cost;
}

/// <summary>
/// Конкретный класс, представляющий напиток "Капучино".
/// </summary>
public class Сappuccino : IBeverage<Сappuccino>
{
    public Сappuccino()
    {
        Description = "Капучино";
        Cost = 59;
    }

    public string? Description { get; set; }
    public double Cost { get; set; }

    public string GetDescription() => Description!;

    public double GetCost() => Cost;
}

/// <summary>
/// Конкретный класс, представляющий напиток "Лунго".
/// </summary>
public class Lungo : IBeverage<Lungo>
{
    public Lungo()
    {
        Description = "Лунго";
        Cost = 69;
    }

    public string? Description { get; set; }
    public double Cost { get; set; }

    public string GetDescription() => Description!;

    public double GetCost() => Cost;
}

/// <summary>
/// Абстрактный базовый класс для декораторов напитков.
/// </summary>
/// <typeparam name="T">Тип декорируемого напитка.</typeparam>
public abstract class BeverageDecorator<T> : IBeverage<T> where T : IBeverage<T>
{
    private IBeverage<T> _beverage;

    public BeverageDecorator(IBeverage<T> beverage)
    {
        _beverage = beverage;
    }

    public string? Description { get => _beverage.Description; set => _beverage.Description = value; }
    public double Cost { get => _beverage.Cost; set => _beverage.Cost = value; }

    public string GetDescription() => _beverage.GetDescription();


    public double GetCost() => _beverage.GetCost();
}
/// <summary>
/// Конкретный класс декоратора, который добавляет молоко в напиток.
/// </summary>
public class MilkDecorator<T> : BeverageDecorator<T> where T : IBeverage<T>
{
    public MilkDecorator(IBeverage<T> beverage) : base(beverage)
    {
        Description += ", с молоком";
        Cost += 10;
    }
}
/// <summary>
/// Конкретный класс декоратора, который добавляет сахар в напиток.
/// </summary>
public class SugarDecorator<T> : BeverageDecorator<T> where T : IBeverage<T>
{
    public SugarDecorator(IBeverage<T> beverage) : base(beverage)
    {
        Description += ", с сахаром";
        Cost += 5;
    }
}