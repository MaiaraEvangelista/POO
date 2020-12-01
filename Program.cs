using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //DECLARAÇÕES
             int escolher;
             string [] personagens = new string[7];
             bool  personagemValido;

            do
            {
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("--------------------");
                Console.WriteLine("Escolha entre as opções abaixo:");
              //  Console.WriteLine("-------------------------------------");
                Console.WriteLine("[1]- Escolher personagens");
                Console.WriteLine("[2]- Assistir partidas");
                Console.WriteLine("[0]- Sair");   
                 escolher = int.Parse(Console.ReadLine());
                 
                 switch (escolher)
                 {
                        case 1:
                        Console.WriteLine("Qual dos personagens a seguir você vai ser?");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Safira; Cleya; Spark; Nyon; Myra; Bydon; Lyon");
                        // Console.WriteLine("Escreva o nome do seu personagem: ");

                                    do
                                    {
                                        Console.WriteLine("Digite o nome do seu personagem: ");
                                        Console.WriteLine("-------------------------------------");
                                        string personagem = Console.ReadLine();
                                        personagemValido = EscolherPersonagem(personagem);


                                    } while (!personagemValido);

                        
                        break;

                            case 2:
                                Console.WriteLine("Escolh entre as opções:");
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("[A]- Assistir partidas em tempo real");
                                Console.WriteLine("[B]- Ver partidas gravadas");
                                Console.WriteLine("[C]- Melhores momentos");
                                
                                
                            break;

                   //  default:
                 }

            } while (true);

            bool EscolherPersonagem(string personagens){
                if(personagens == "Safira" || personagens == "Spark" || personagens == "Nyon" || personagens == "Myra" || personagens == "Bydon" || personagens == "Lyon"){
                    return true;
                } else{
                    Console.WriteLine("Opção Inválida");
                        return false;
                }
            }
            
        }
    }
}
