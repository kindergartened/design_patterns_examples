namespace SimpleDesignPatterns;

using System;
/// <summary>
/// Абстрактный класс, представляющий собой напиток
/// </summary>
public abstract class Beverage
{
    public string? Description { get; set; }
    public double Cost { get; set; }

    public virtual string GetDescription()
    {
        return Description;
    }

    public virtual double GetCost()
    {
        return Cost;
    }
}
/// <summary>
/// Конкретный класс, наследуется от класса Напиток, представляет собой Эспрессо
/// </summary>
public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Эспрессо";
        Cost = 49;
    }
}
/// <summary>
/// Абстрактный декоратор, также наследуется от класса Напиток
/// </summary>
public class BeverageDecorator : Beverage
{
    private Beverage _beverage;

    public BeverageDecorator(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", " + Description;
    }

    public override double GetCost()
    {
        return _beverage.GetCost() + Cost;
    }
}
/// <summary>
/// Конкретный декоратор, наследуется от декоратора, добавляет к напитку молоко
/// </summary>
public class MilkDecorator : BeverageDecorator
{
    public MilkDecorator(Beverage beverage) : base(beverage)
    {
        Description += "с молоком";
        Cost += 10;
    }
}
/// <summary>
/// Еще один конкретный декоратор, добавляет к напитку сахар
/// </summary>
public class SugarDecorator : BeverageDecorator
{
    public SugarDecorator(Beverage beverage) : base(beverage)
    {
        Description += "с сахаром";
        Cost += 5;
    }
}