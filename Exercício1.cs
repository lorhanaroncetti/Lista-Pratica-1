using System;

class MainClass{
   public static void Main () {
    double N1, N2, resultado = 0;
    string operacao;


    Console.Write ("Digite um número: ");
    N1 = double.Parse(Console.ReadLine());

    Console.Write ("Digite novamene um número: ");
    N2 = double.Parse(Console.ReadLine());

    Console.Write ("Digite a operação que deseja fazer: ");
    operacao = Console.ReadLine();
    


    switch (operacao){
      case "*":
       resultado = N1*N2;
       break;

      case "/":
        resultado = N1/N2;
        break;

      case "+":
        resultado = N1+N2;
        break;

      case "-":
        resultado = N1-N2;
        break;

      default:
        Console.WriteLine("Erro");
        break; 
    }

   Console.WriteLine("{0} {1} {2} = {3}", N1, N2, operacao, resultado);

   }
   
}

