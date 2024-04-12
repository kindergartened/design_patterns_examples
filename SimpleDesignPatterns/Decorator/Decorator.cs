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

    public string GetDescription()
    {
        return Description!;
    }

    public double GetCost()
    {
        return Cost;
    }
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

    public string GetDescription()
    {
        return _beverage.GetDescription();
    }

    public double GetCost()
    {
        return _beverage.GetCost();
    }
}
/// <summary>
/// Конкретный класс декоратора, который добавляет молоко в напиток.
/// </summary>
public class MilkDecorator : BeverageDecorator<Espresso>
{
    public MilkDecorator(IBeverage<Espresso> beverage) : base(beverage)
    {
        Description += ", с молоком";
        Cost += 10;
    }
}
/// <summary>
/// Конкретный класс декоратора, который добавляет сахар в напиток.
/// </summary>
public class SugarDecorator : BeverageDecorator<Espresso>
{
    public SugarDecorator(IBeverage<Espresso> beverage) : base(beverage)
    {
        Description += ", с сахаром";
        Cost += 5;
    }
}