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
        Beverage beverage = new Espresso();
        Console.WriteLine(beverage.GetDescription() + ": " + beverage.GetCost());

        Beverage beverageWithMilk = new MilkDecorator(beverage);
        Console.WriteLine(beverageWithMilk.GetDescription() + ": " + beverageWithMilk.GetCost());

        Beverage beverageWithMilkAndSugar = new SugarDecorator(beverageWithMilk);
        Console.WriteLine(beverageWithMilkAndSugar.GetDescription() + ": " + beverageWithMilkAndSugar.GetCost());
    }
}