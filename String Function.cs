
namespace Rohit
{
  class Program
  {
    static void Main(string[] args)
    {
      string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine("The length of the txt string is: " + txt.Length);
    }
  }
}



  class Program
  {
    static void Main(string[] args)
    {
      string txt = "Hello World";
      Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
      Console.WriteLine(txt.ToLower());   // Outputs "hello world"
    }
  }
}




  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John ";
      string lastName = "Doe";
      string name = firstName + lastName;
      Console.WriteLine(name);
    }
  }
}



  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John ";
      string lastName = "Doe";
      string name = string.Concat(firstName, lastName);
      Console.WriteLine(name);
    }
  }
}


  class Program
  {
    static void Main(string[] args)
    {
      string firstName = "John";
      string lastName = "Doe";
      string name = $"My full name is: {firstName} {lastName}";
      Console.WriteLine(name);
    }
  }
}


  class Program
  {
    static void Main(string[] args)
    {
      string myString = "Hello";
      Console.WriteLine(myString[0]);
    }
  }
}



  class Program
  {
    static void Main(string[] args)
    {
      string myString = "Hello";
      Console.WriteLine(myString.IndexOf("e"));
    }
  }
}


