using System;

namespace Calculadora{
  class Program{
    static void Main(string[] args){
      string operacao = "";
      int number1, number2;
      Console.WriteLine("App calculadora \n");
      Console.WriteLine("Informe qual operação vai realizar: \n 1- Soma \n 2- Subtracão \n 3- multiplicação \n 4- divisão \n 5- Resto da divisão \n 6- Potencia (informar a base, depois expoente)");
      operacao = Console.ReadLine();
      Console.WriteLine($"Operacao que será feita: {operacao}");
      Console.WriteLine("Informe o primeiro numero");
      
      // transformar a string em int
      number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Informe o segundo numero");
      number2 = Convert.ToInt32(Console.ReadLine());;

      // soma 
      if(operacao == "1"){
      float resultado = number1 + number2;
      Console.WriteLine($"O resultado da operacao de resultado com os numeros informados é: {resultado}");
      }
      // subtracao
      if(operacao == "2"){
      float resultado = Subtracao(number1, number2);
      Console.WriteLine($"O resultado da operacao de subtracao com os numeros informados é: {resultado}");
      }
      // multiplicacao
      if(operacao == "3"){
      float resultado = Multiplicacao(number1, number2);
      Console.WriteLine($"O resultado da operacao de multiplicacao com os numeros informados é: {resultado}");
      }
      // divisao
      if(operacao == "4"){
      float resultado = Divisao(number1, number2);
      Console.WriteLine($"O resultado da divisão de resultado com os numeros informados é: {resultado}");
      }
       // resto da divisão
      if(operacao == "5"){
      float resultado = Resto(number1, number2);
      Console.WriteLine($"O resto da divisão entre os numeros os numeros informados é: {resultado}");
      }
      
       // potencia
      if(operacao == "6"){
      double resultado = Potencia(number1, number2);
      Console.WriteLine($"A potenciacao dos numeros informados é: {resultado}");
      }
      
      
      Console.ReadLine();
    }
    static float Soma(int num1, int num2){
      return num1 + num2;
    }
       static float Subtracao(int num1, int num2){
      return num1 - num2;
    }
     static float Multiplicacao(int num1, int num2){
      return num1 * num2;
    }
       static float Divisao(int num1, int num2){
      return num1 / num2;
    }

       static float Resto(int num1, int num2){
      return num1 % num2;
    }

       static double Potencia(int num1, int num2){
      return Math.Pow(num1, num2);
    }
  }
}

