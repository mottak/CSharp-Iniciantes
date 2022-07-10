using System;

namespace JogarDados {
  class Program{
    static string jogador1="";
     static string jogador2 = "";
// https://docs.microsoft.com/pt-br/dotnet/api/system.random?view=net-6.0
     static public byte pontos1 = 0;
     static public byte pontos2 = 0;
    static void Main(string[] args){
      Console.WriteLine("App Jogar Dados \n");
      PlayersName();

      for(int i =1; i<= 3; i++){
        Match(i);
        Console.WriteLine($"Pontos do jogador {jogador1}: {pontos1}.\nPontos do jogador {jogador2}: {pontos2}.\n");
      }
      while(pontos1 == pontos2){
        int index = 4;
        Match(index);
        index++;
      }

      
    static void PlayersName(){
      Console.WriteLine("Informe o nome do primeiro jogador");
       jogador1 = Console.ReadLine();
      Console.WriteLine("Informe o nome do segundo jogador");
       jogador2 = Console.ReadLine();
       while (jogador1 == jogador2){
        Console.WriteLine("O nome dos jogadores precisam ser diferentes");
        Console.WriteLine("Informe um nome valido para o segundo jogador");
        jogador2 = Console.ReadLine();
       }
    }
    static void Match(int rodada){
      
      Random rand = new Random();
      byte matchPoints1 = Convert.ToByte(rand.Next(1, 7));
      byte matchPoints2 = Convert.ToByte(rand.Next(1, 7));

      if(matchPoints1 > matchPoints2){
        pontos1 += 1;
      Console.WriteLine($"{jogador1} tirou o número {matchPoints1} e {jogador2} o número {matchPoints2}. {jogador1} venceu a rodada {rodada}");
      }
      if(matchPoints1 < matchPoints2){
        pontos2 += 1;
      Console.WriteLine($"{jogador1} tirou o número {matchPoints1} e {jogador2} o número {matchPoints2}. {jogador2} venceu a rodada {rodada}");
      }
        if(matchPoints1 == matchPoints2){

      Console.WriteLine($"{jogador1} tirou o número {matchPoints1} e {jogador2} o número {matchPoints2}. Empate");
      }
    }  
    }
  }
}