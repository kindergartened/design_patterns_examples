using SimpleDesignPatterns;
namespace PatternsConsole;

class Program
{
    static void Main()
    {
        /*  _____  ______ _____ ____  _____         _______ ____  _____  
            |  __ \|  ____/ ____/ __ \|  __ \     /\|__   __/ __ \|  __ \ 
            | |  | | |__ | |   | |  | | |__) |   /  \  | | | |  | | |__) |
            | |  | |  __|| |   | |  | |  _  /   / /\ \ | | | |  | |  _  / 
            | |__| | |___| |___| |__| | | \ \  / ____ \| | | |__| | | \ \ 
            |_____/|______\_____\____/|_|  \_\/_/    \_\_|  \____/|_|  \_\                                                
         */
        IBeverage<Espresso> beverage = new Espresso();
        Console.WriteLine(beverage.GetDescription() + ": " + beverage.GetCost());

        IBeverage<Espresso> beverageWithMilk = new MilkDecorator(beverage);
        Console.WriteLine(beverageWithMilk.GetDescription() + ": " + beverageWithMilk.GetCost());

        IBeverage<Espresso> beverageWithMilkAndSugar = new SugarDecorator(beverageWithMilk);
        Console.WriteLine(beverageWithMilkAndSugar.GetDescription() + ": " + beverageWithMilkAndSugar.GetCost());
    }
}