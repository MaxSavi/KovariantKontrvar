public abstract class Animal
{
    public string Name { get; set; }
    public abstract void SayHello();
}
public class Dog : Animal
{
    public override void SayHello()
    {
        Console.WriteLine($"Я {Name}! Гав-гав!");
    }
}

public class Cat : Animal
{
    public override void SayHello()
    {
        Console.WriteLine($"Я {Name}! Мяу!");
    }
}

public class Program
{
    //Это метод, который принимает список животных и делегат Action<Animal> и вызывает делегат для каждого животного
    public static void GreetingsAnimals(List<Animal> animals, Action<Animal> greetAction)
    {
        foreach (Animal animal in animals)
        {
            greetAction(animal);
        }
    }

    public static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog{ Name = "Вилли" },
            new Cat{Name = "Барсик"},
            new Dog{ Name = "Дружок" },
            new Cat{Name = "Леопольд"}
        };

        //Использование метода с разными делегатами
        Action<Animal> greetDelegate = animal => animal.SayHello();
        //Вызов метода с разными делегатами
        GreetingsAnimals(animals, greetDelegate);
    }
}