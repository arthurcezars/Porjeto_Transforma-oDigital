using System;
using System.IO;

class Reservar{
  public static void academia(){
    string busca, bhora;
    int  buscaint=0, hora, bhoraint;
    bool livret=false;

    using(StreamReader reader=new StreamReader("texte.txt")){
      busca=reader.ReadLine();
      buscaint=int.Parse(busca);
    }
     
    if(buscaint==1){
      using(StreamWriter writer=new StreamWriter("texte.txt")){
        writer.Write(2);
      }

      Console.Write("Usando o fromato de 24 horas digite o horario que deseja reservar(Exemplo-13 para 1 hora da tarde): ");
      hora=int.Parse(Console.ReadLine());

      using(StreamReader reader=new StreamReader("horar.txt")){
        while(!reader.EndOfStream){
          bhora=reader.ReadLine();
          bhoraint=int.Parse(bhora);

          if(bhoraint==hora){
            Console.WriteLine("Esse horario já está reservado!");
          } else{
            livret=true;
            Console.WriteLine("Horario reservado com sucesso!");
          }
        }
      }

      if(livret==true){
        using(StreamWriter writer=new StreamWriter("horar.txt", true)){
          writer.WriteLine(hora);
        }
      }
    }

  }
}