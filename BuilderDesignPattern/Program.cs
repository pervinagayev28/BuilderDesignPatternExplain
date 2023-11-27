

// ****************** pizza *************************

using System;

public class Pizza
{
    public string crust;
    public string sauce;
    public string cheese;
    public bool pepperoni;
    public bool mushrooms;
    public bool onions;

    public void setCrust(string v)
    {
        this.crust = v;
    }

    public void setSauce(string v)
    {
        this.sauce = v;
    }

    public void setPepperoni(bool v)
    {
        this.pepperoni = v;
    }

    public void setCheese(string v)
    {
        this.cheese = v;
    }

    public void setMushrooms(bool v)
    {
        this.mushrooms = v;
    }

    public void setOnions(bool v)
    {
        this.onions = v;
    }

}








public interface PizzaCooker
{
    void cookCrust(String crust);
    void cookSauce(String sauce);
    void cookCheese(String cheese);
    void cookPepperoni(bool pepperoni);
    void cookMushrooms(bool mushrooms);
    void cookOnions(bool onions);
    Pizza getResult();
}

public class MargheritaPizzaCooker : PizzaCooker
{
    private Pizza pizza = new Pizza();

    public void cookCrust(String crust)
    {
        pizza.crust=crust;
    }

    public void cookSauce(String sauce)
    {
        pizza.sauce=(sauce);
    }

    public void cookCheese(String cheese)
    {
        pizza.cheese=(cheese);
    }


    public void cookPepperoni(bool pepperoni)
    {
        pizza.pepperoni=(pepperoni);
    }


    public void cookMushrooms(bool mushrooms)
    {
        pizza.mushrooms=(mushrooms);
    }


    public void cookOnions(bool onions)
    {
        pizza.onions=(onions);
    }


    public Pizza getResult()
    {
        return pizza;
    }


    class program
    {
        static void Main(string[] args)
        {
            Pizza pizzaObj = new Pizza();
            pizzaObj.setCrust("Thin Crust");
            pizzaObj.setSauce("Tomato Sauce");
            pizzaObj.setCheese("Mozzarella");
            pizzaObj.setPepperoni(true);
            pizzaObj.setMushrooms(false);
            pizzaObj.setOnions(true);

            PizzaCooker cooker = new MargheritaPizzaCooker();
            cooker.cookCrust("Thin Crust");
            cooker.cookSauce("Tomato Sauce");
            cooker.cookCheese("Mozzarella");
            cooker.cookPepperoni(true);
            cooker.cookMushrooms(false);
            cooker.cookOnions(true);

            Pizza pizzaObj = cooker.getResult();

        }
    }
}










//public class Computer
//{
//    private String cpu;
//    private int ram;
//    private String storage;

//    internal void setCpu(string cpu) =>
//       this.cpu = cpu;


//    internal void setRam(int ram) =>
//        this.ram = ram;

//    internal void setStorage(string storage) =>
//        this.storage = storage;
//}

//public interface ComputerBuilder
//{
//    void buildCPU(String cpu);
//    void buildRAM(int ram);
//    void buildStorage(String storage);
//    Computer getResult();
//}
//public class DesktopComputerBuilder : ComputerBuilder
//{
//    private Computer computer = new Computer();


//    public void buildCPU(String cpu) =>
//                computer.setCpu(cpu);

//    public void buildRAM(int ram) =>
//                computer.setRam(ram);

//    public void buildStorage(String storage) =>
//                computer.setStorage(storage);

//    public Computer getResult() => computer;
//}


//public class ComputerDirector
//{
//    private ComputerBuilder builder;

//    public ComputerDirector(ComputerBuilder builder)
//    {
//        this.builder = builder;
//    }

//    public void constructComputer()
//    {
//        builder.buildCPU("Intel i7");
//        builder.buildRAM(16);
//        builder.buildStorage("1TB SSD");
//    }
//}
//public class Client
//{
//    public static void main(String[] args)
//    {
//        ComputerBuilder builder = new DesktopComputerBuilder();
//        ComputerDirector director = new ComputerDirector(builder);

//        director.constructComputer();

//        Computer computer = builder.getResult();

//    }
//}
