using System;

class MainClass{
  public static void Main () {
    int candidato; 
    int R1 = 0;
    int R2 = 0;
    int R3 = 0;
    int R4 = 0;
    int R5 = 0;
    bool voto = true;
    

    while(voto == true){
      
      Console.Write("Coloque o número referente ao candidato que deseja votar. \r\n");
      candidato = int.Parse(Console.ReadLine());

      switch(candidato){
        case 33:
        R1 += 1;
        break;

        case 25:
        R2 += 1;
        break;

        case 10:
        R3 += 1;
        break;

        case 0:
        R4 += 1;
        break;

        case 4:
        R5 += 1;
        break;

        default:
        Console.WriteLine("ERRO! INSIRA UM NÚMERO VÁLIDO.");
        break;
        
      } // Fim switch
    
      Console.Write("Deseja votar novamente? ");
      string opx = Console.ReadLine() ;
      if( opx == "sim" || opx == "SIM" || opx == "s" || opx == "S" ){
        voto = true;
      }else{
        voto = false;
        Console.WriteLine("Candidato 1>> {0} votos\nCandidato 2>> {1} votos\nCandidato 3 >> {2}\nVotos Brancos>> {3} votos\nVotos nulos>> {4} votos\n\n",R1,R2,R3,R4,R5);
      }
    }
   
    if( (R1 > R2) && ( R1 > R3 ) ){
      Console.WriteLine("Jose Couve Ganhou com {0} votos!", R1);
    }else if( R2 > R3 ){
      Console.WriteLine("Joana Bravo Ganhou com {0} votos!", R2);
    }else{
      Console.WriteLine("Roberto Nove Ganhou com {0} votos!", R3);
    }
    
  } 
} 
