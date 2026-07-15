
List<Animal> animals = new List<Animal>();
List<Car> cars = new List<Car>();
List<Person> persons = new List<Person>();
List<Book> books = new List<Book>();

animals.Add(new Animal { Name = "Dog", Age = 3 });
animals.Add(new Animal { Name = "Cat", Age = 5 });

cars.Add(new Car { Brand = "Toyota", Year = 2020 });
cars.Add(new Car { Brand = "BMW", Year = 2022 });

persons.Add(new Person { Name = "John", Job = "Developer" });
persons.Add(new Person { Name = "Anna", Job = "Designer" });

books.Add(new Book { Title = "1984", Author = "Orwell" });
books.Add(new Book { Title = "Dune", Author = "Herbert" });

Console.WriteLine("=== ANIMALS ===");
foreach (var a in animals) { a.ShowInfo(); a.MakeSound(); }

Console.WriteLine("=== CARS ===");
foreach (var c in cars) { c.ShowInfo(); c.Drive(); }

Console.WriteLine("=== PERSONS ===");
foreach (var p in persons) { p.ShowInfo(); p.Greet(); }

Console.WriteLine("=== BOOKS ===");
foreach (var b in books) { b.ShowInfo(); b.Read(); }


class Animal 
{
   public string Name { get; set;   }
   public int Age {get; set; }

   public void MakeSound()
   {
      Console.WriteLine($"{Name} makes a sound.");
   }

   public void ShowInfo()
   {
      Console.WriteLine($"Animal: Name: {Name}, Age: {Age}");
   }
}

class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }

    public void Drive()
    {
        Console.WriteLine($"{Brand} is driving!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Car: {Brand}, Year: {Year}");
    }
}

class Person
{
    public string Name { get; set; }
    public string Job { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hi, my name is {Name}!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Person: {Name}, Job: {Job}");
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void Read()
    {
        Console.WriteLine($"Reading {Title} by {Author}!");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Book: {Title}, Author: {Author}");
    }
}