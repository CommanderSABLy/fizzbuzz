using System;

class Program {
  private static void getInfo (ref string fizz, ref string buzz, ref int firstMult, ref int secondMult, ref int iterations){
    string tempstr ="";
    int tempint = -1;
    
    Console.WriteLine("Choose your first word or press enter for Fizz");
    tempstr = Console.ReadLine();
    if(string.IsNullOrEmpty(tempstr)){ //Fizz is default
      tempstr = "Fizz";
    }
    fizz = tempstr;

    Console.WriteLine("Choose your second word or press enter for Buzz");
    tempstr = Console.ReadLine();
    if(string.IsNullOrEmpty(tempstr)){ //Buzz is default
      tempstr = "Buzz";
    }
    buzz = tempstr;

    Console.WriteLine("Choose your multiples for {0} or press enter for 3", fizz);
    tempstr = Console.ReadLine();
    if(!int.TryParse(tempstr, out tempint)){ //3 is default
      tempint = 3;
    }
    firstMult = tempint;

    Console.WriteLine("Choose your multiples for {0} or press enter for 5", buzz);
    tempstr = Console.ReadLine();
    if(!int.TryParse(tempstr, out tempint)){
      tempint = 5;
    }
    secondMult = tempint;

    Console.WriteLine("How high do you want to Fizzbuzz?");
    tempstr = Console.ReadLine();
    if(!int.TryParse(tempstr, out tempint)){
      tempint = 100;
    }
    iterations = tempint;

    Console.Clear();
  }
  private static void fizzBuzz(string fizz = "Fizz", string buzz = "Buzz", int firstMult = 3, int secondMult = 5, int iterations =100){
    for(int i = 1; i <= iterations; i++){
      string output = "";
      if(i % firstMult == 0){
        output += fizz;
      }
      if(i % secondMult == 0){
        output += buzz;
      }
      if (string.IsNullOrEmpty(output)){
        output += i.ToString();
      }

      Console.WriteLine(output);
    }
  }
  public static void Main (string[] args) {
    int first = 0, second = 0, iterations = 0;
    string fizz = "", buzz = "";
    getInfo(ref fizz, ref buzz, ref first, ref second, ref iterations);
    fizzBuzz(fizz, buzz, first, second, iterations);
    //fizzBuzz();
    }
}
