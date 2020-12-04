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
             string [] personagens = new string[6];
             string [] partes = new string [3];
             bool  personagemValido;
            string entrar;
            bool EscolherOpcoes;

            do
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Bem Vindo!");
                Console.WriteLine("--------------------");
                Console.WriteLine("Escolha entre as opções abaixo:");
                Console.WriteLine("[1]- Escolher personagens");
                Console.WriteLine("[2]- Assistir partidas");
                Console.WriteLine("[0]- Sair");   
                escolher = int.Parse(Console.ReadLine());
                 
                switch (escolher)
                {
                        case 1:
                        Console.WriteLine("Qual dos personagens a seguir você vai ser?");
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("Safira; Spark; Nyon; Myra; Bydon; Lyon");
                                    do
                                    {
                                        Console.WriteLine("Digite o nome do seu personagem: ");
                                        Console.WriteLine("-------------------------------------");
                                        string personagem = Console.ReadLine();
                                        personagemValido = EscolherPersonagem(personagem);

                                          Console.WriteLine("Bem Vindo a fase decisiva, aqui você da a sua última palavra"); 
                                          Console.WriteLine("Você deseja mesmo entrar na partida online? (S/N)");
                                          entrar = Console.ReadLine();
                                          
                                            if(entrar == "S" ){
                                                    Console.WriteLine("Boa sorte na sua partida! Seja feroz, esperto, e acabe com seu oponente!");
                                            } 
                                            else if(entrar == "N")
                                            {
                                                Console.WriteLine("Aaa :( até a próxima!");
                                            }

                                    } while (!personagemValido);
                        break;

                            case 2:
                                Console.WriteLine("Escolha entre as opções abaixo:");
                                Console.WriteLine("Assistir partidas em tempo real; Ver partidas gravadas; Melhores momentos");

                               string parte = Console.ReadLine(); 
                               EscolherOpcoes = Opcoes(parte);
                            break;

                                    case 0:
                                    Console.WriteLine("Ok, agradecemos pela presença, até qualquer dia (:");
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
                    bool  Opcoes (string partes){
                        if(partes == "Assistir partidas em tempo real" || partes == "Ver partidas gravadas" || partes == "Melhores momentos"){
                                return true;
                        } else{
                            Console.WriteLine("Desculpa mas essa opção é inválida!");
                                return false;
                        }
                    }


        }
    }
}
