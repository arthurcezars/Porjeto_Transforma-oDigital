using System;
using System.IO;

class Cadastro{

  public static void unidade(){
    int buscaint, codunidade, escolha;
    string busca;
    bool pcadastro=false, ncadastro=false;

    Console.Write("Digite 2 para se cadastrar: ");
    escolha=int.Parse(Console.ReadLine());

    if(escolha==2){
      Console.WriteLine("CADASTRO");
      Console.Write("Insira na ordem, Bloco>andar>ultimo digito da unidade:  ");
      codunidade=int.Parse(Console.ReadLine());

      using(StreamReader reader=new StreamReader("unidades.txt")){
        while(!reader.EndOfStream){
          busca=reader.ReadLine();
          buscaint=int.Parse(busca);

          if(buscaint==codunidade){
            Console.WriteLine("Unidade já está cadastrada!");
            ncadastro=true;
          }else{
            Console.WriteLine("Cadastrado com sucesso!");
            ncadastro=true;
          }
        }
      }

      if(ncadastro==true){
        using(StreamWriter writer=new StreamWriter("unidades.txt", true)){
          writer.WriteLine(codunidade);
        }
      }
    }

    if(ncadastro==true){
      using(StreamWriter writer=new StreamWriter("texte.txt")){
        writer.Write(1);
      }
    }

    if(pcadastro==true){
      using(StreamWriter writer=new StreamWriter("texte.txt")){
        writer.Write(1);
      }
    }
  }
}