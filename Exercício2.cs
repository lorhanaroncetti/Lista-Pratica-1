using System;

class MainClass {
  public static void Main () {

    string opcao;
    int qntd;
    double resultado = 0;
		bool question = true;
    
		
    while(question == true){
        Console.Write ("Coloque o código referente ao produto que deseja escolher.\r\n");
        opcao = Console.ReadLine();

        Console.Write ("Qual quantidade você deseja adquirir do produto escolhido?\r\n");
        qntd = int.Parse(Console.ReadLine());

				switch (opcao){
          case "100":
          resultado += 1.70*qntd;
          break;

          case "101":
          resultado += 2.30*qntd;
          break;

          case "102":
          resultado += 2.60*qntd;
          break;

          case "103":
          resultado += 2.40*qntd;
          break;

          case "104":
          resultado += 2.50*qntd;
          break;

          case "105":
          resultado += 1.00*qntd;
          break;

          default:
            Console.WriteLine("ERRO! INSIRA UM CÓDIGO VÁLIDO.");
          break;
        } 

        Console.Write("Deseja mais alguma coisa? ");
        string opx = Console.ReadLine() ;
        if( opx == "sim" || opx == "SIM" || opx == "s" || opx == "S" ){
          question = true;
        }else{
          question = false;
        }

    } // Fim While

    Console.WriteLine( "Valor total da compra: {0}", resultado);

  }
}
