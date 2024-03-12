namespace PizzaStore.DB; 

public record Pizza
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class PizzaDb
{
    private static list<Pizza> _pizza = new list<Pizza>()
    {
        new Pizza() { Id = 1, Name= "The Pepperoni Parade, Pizza loaded with Pepperoni "},
        new Pizza() { Id = 2, Name= "Buffalo Chicken Blaze, Blazin hot pizza "},
        new Pizza() { Id = 3, Name= "Montemagno, Pizza shaped like a great mountain"}
    };
    
public static List(Pizza) GetPizza()
    {
        return _pizza; 
    }

public static Pizza ? GetPizza(int id)
    {
        return _pizzas.SingleOrDefault(pizza => pizza.id == id); 
    }

public static Pizza CreatePizza(pizza pizza)
    { 
        _pizza.Add(pizza);
        return new pizza; 
    }

public static UpdatePizza(Pizza update)
    {

    }







}