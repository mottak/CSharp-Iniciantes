using System;

namespace SomaMedia{
  class Program{
    static void Main(string[] args){
      Console.WriteLine("App Soma e Media \n");
      Console.WriteLine("Quantos numeros serão informados (min 3 e max 10): \n");
      int totalNum = Convert.ToInt32(Console.ReadLine());

      if(totalNum < 3){
        Console.WriteLine("É necessario informar pelo menos 3 numeros \n");
      } else if(totalNum > 10){
        Console.WriteLine("São permitidos no máximo 10 numeros \n");
      } else {
      float somaNums = Soma(totalNum);
      float mediaNums = Media(somaNums, totalNum);

      Console.WriteLine($"A Soma dos numeros informados é: {somaNums}");
      Console.WriteLine($"A Media dos numeros informados é: {mediaNums}");

      }
    }

    static float Soma (int total){
      float soma = 0;
      for(int index = 0; index < total; index++){
        Console.WriteLine("Informe o numero: \n");
        float num = float.Parse(Console.ReadLine());
        soma = soma + num;
      }
      return soma;
    }

     static float Media (float soma, int total){
      return soma / total;
    }
  }
}