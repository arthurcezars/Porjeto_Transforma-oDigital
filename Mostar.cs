using System;
using System.IO;

class Mostar{
  public static void show(){
    string line;
    int counter=0,counter2=0;

    Console.WriteLine("--------------------");
    Console.WriteLine("Unidades que Reservaram a academia:");
    using (StreamReader reader=new StreamReader("unidades.txt")){
      while((line=reader.ReadLine()) != null){
        Console.WriteLine(line);
        counter++;
      }
    }
    Console.WriteLine("--------------------");

    Console.WriteLine("Horarios reservados(Respectivo as unidades acima):");
    using(StreamReader reader=new StreamReader("horar.txt")){
      while((line=reader.ReadLine()) != null){
        Console.WriteLine(line);
        counter2++;
      }
    }
    Console.WriteLine("--------------------");
    
  }
}