
namespace Rohit
{
class MyClass
{
  // Class members
  string color = "red";        // field
  int maxSpeed = 200;          // field
  public void fullThrottle()   // method
  {
    Console.WriteLine("The car is going as fast as it can!");
  }
}



  class Car 
  {
    string color = "red";
    int maxSpeed = 200;

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
    }
  }
}




  class Car 
  {
    string color;
    int maxSpeed;

    static void Main(string[] args)
    {
      Car myObj = new Car();
      myObj.color = "red";
      myObj.maxSpeed = 200;
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.maxSpeed);
    }
  }
}



  class Car 
  {
    string model;
    string color;
    int year;

    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}




  class Car
  {
    string color;                 // field
    int maxSpeed;                 // field
    public void fullThrottle()    // method
    {
      Console.WriteLine("The car is going as fast as it can!");
    }

    static void Main(string[] args)
    {
      Car myObj = new Car();
      myObj.fullThrottle();  // Call the method
    }
  }
}




  class Program
  {
    static void Main(string[] args)
    {
      Car Ford = new Car();
      Ford.model = "Mustang";
      Ford.color = "red";
      Ford.year = 1969;

      Car Opel = new Car();
      Opel.model = "Astra";
      Opel.color = "white";
      Opel.year = 2005;

      Console.WriteLine(Ford.model);
      Console.WriteLine(Opel.model);
    }
  }
}
