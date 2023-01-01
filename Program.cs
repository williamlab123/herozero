



batalha();



void lojaAtributos()
{
   
  loja martelo = new loja();
  loja faca = new loja();
  loja katana = new loja();

  

  martelo.dano = 10;
  martelo.vida = 0;
  martelo.intuicao = 1;
  martelo.critico = 3;
  martelo.preco = 70;

  

}

int batalha()
{


   Console.WriteLine("1 para começar, 2 para equipar items");

   int escolha = int.Parse(Console.ReadLine());

   switch escolha
   {
    case 1:
       batalha();
    break;

    case 2:
      loja();

    
   }

    bool continuar = true;

    int resultado;

   int dano = 10;
   int vida = 100;
   int intuicao = 10;
   int critico = 10;

   int dano2 = 10;
   int vida2 = 200;
   int intuicao2 = 10;
   int critico2 = 10;




   do
   {

   
    vida2 -= dano;

    Console.WriteLine($"vida2 {vida2}");

    vida -= dano2;

    
    Console.WriteLine($"vida {vida}");


    if(vida <= 0 || vida2 <= 0)
    {
        continuar = false;
    }

   }  while(continuar);



   if(vida > vida2)
   {
    Console.WriteLine("player 1 ganhou");
   return resultado = 1;

   }

   else
   {
    Console.WriteLine("player 2 ganhou");

    return resultado = 2;
   }


   
}


public class loja
{
     public int preco;
     public int dano;
     public int vida;
     public int intuicao;
     public int critico;
     
}
