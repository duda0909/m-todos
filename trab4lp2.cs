using System;
using System.Collections.Generic;


public class Item
{
    public string Nome;
    public int Id;
    public int Preco;
    public string Desc;
}



public class Player
{
    public string nome;
    public int xp;
    public int gold;
    public List<Item> Itens = new List<Item>();
}



public class LP2_Trabalho
{

 
 
    static List<Player> Players = new List<Player>();






    public static void Main(string[] args)
    {
       
        
        bool MostrarMenu = true;
        while (MostrarMenu)
        {
            MostrarMenu = MenuPrincipal();
        }

    }












    private static void CreatePlayer(){

                Console.Clear();            
                Console.Write("digite  um nome : ");
                var PlayerName = Console.ReadLine();
                PlayerName = PlayerName.ToLower();


                Console.Write("digite  uma quantidade de experiência: ");
                var PlayerExperience = Console.ReadLine();
               
                Random GetEXP = new Random();
                var PlayerCoins = GetEXP.Next(50, 350);


                Players.Add(new Player { nome = PlayerName, xp = Convert.ToInt32(PlayerExperience), gold = PlayerCoins});
                Console.Clear();
                Console.WriteLine("Jogador criado com sucesso");
                Console.WriteLine("");
                Console.WriteLine("Adicionamos $" + PlayerCoins  + " de ouro na sua conta");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.Read();

    }


    















    private static void ViewPlayers(){

                Console.Clear();
                for (int i = 0; i < Players.Count; i++)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Jogador:");            
                    Console.WriteLine("nome : " + Players[i].nome);
                    Console.WriteLine("Experiência : " + Players[i].xp);
                    Console.WriteLine("Ouro : " + Players[i].gold);                 
                    Console.WriteLine("");
                }//END FOR

                Console.WriteLine("");
                Console.Write("Pressione qualquer tecla para sair...");
                Console.ReadKey();
    }




















    private static void CheckInv(){
            
            Console.Clear();
            Console.WriteLine("Digite o nome do jogador para verificar o iventário:");
            var PlayerName = Console.ReadLine();
            PlayerName = PlayerName.ToLower();
            foreach(Player p in Players)
            {
                if(p.nome == PlayerName)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Itens:");
                    Console.WriteLine("");
                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Item: " + p.Itens[i].Nome);
                    }//END FOR
                    Console.WriteLine("");
                    Console.WriteLine("Entre com qualquer tecla para continuar");
                    Console.Read();
                }//END IF
                else{
                    Console.Clear();
                    Console.WriteLine(" Nao foi encontrado nenhum jogador... Retornando ao menu principal");
                  Console.Read();
                }//END ELSE
            }//END FOREACH

    }






























    private static void StoreManager(
      
        Item Boomachado, 
        Item Adagas_Destruidoras,
        Item Varinha_Do_Mago_Destruídor , 
        Item Escudo_ De_Superproteçao,
        Item Espada_Do_Infinito,
        
        ){
            



            Console.Clear();
            Console.WriteLine("Digite o nome do jogador que irá acessar a loja: ");
            var PlayerName = Console.ReadLine();
            PlayerName = PlayerName.ToLower();
      
      
      
      
      
      
      
      
            foreach(Player p in Players)
            {
                if(p.nome == PlayerName)
                {       
                    Console.WriteLine("- Digite o ID do item que você espera comprar:");
                    Console.WriteLine("");
                    Console.WriteLine(Boomachaodo.Id + " - " + Boomachado.Nome  + " " + Boomachado.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Adagas_ Destruídoras.Id + " - " + Adagas_ Destruídoras.Nome  + " " + Adagas_ Destruídoras.Desc);
                    Console.WriteLine("")
                    Console.WriteLine("");
                    Console.WriteLine( Varinha_Do_Mago_Destruídor.Id + " - " + Varinha_Do_Mago_Destruídor.Nome + Varinha_Do_Mago_Destruídor " " +.Desc);
                    Console.WriteLine("")
                    Console.WriteLine( Escudo_ De_Superproteçao.Id + " - " +  Escudo_ De_Superproteçao.Nome  + " " +  Escudo_ De_Superproteçao.Desc);
                    Console.WriteLine("");
                    Console.WriteLine(Espada_Do_Infinito.Id + " - " + Espada_Do_Infinito.Nome + " " + Espada_Do_Infinito.Desc);       
                    Console.WriteLine("");
                    var ic = Console.ReadLine();
                 
                 

















                    if( ic ==  Boomachado.Id.ToString() ){

                        Console.WriteLine("Você gostaria de comprar " +  Boomachado.Nome + " por " + Boomachado.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >=  Boomachado.Preco)
                            {
                                p.gold = p.gold -  Boomachado.Preco;
                                p.Itens.Add( Boomachado);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                               Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END IF
                               else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE
                        }//END IF
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE 
                    }//END ELSE IF
























                    else if(ic == Adagas_Destruidora .Id.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Adagas_Destruidoras gas_o.Nome + " por " + Adagas_Destruidoras.Preco + "G? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.gold);              
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.gold >= Adagas_Destruidora.Preco)
                            {
                                p.gold = p.gold - Adagas_Destruidoras.Preco;
                                p.Itens.Add(Adagas_Destruidoras);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END IF
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE
                        }//END IF
                              else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//END ELSE 
                    }//END ELSE IF
























                    else if(ic == Varinha_Do_Mago_Destruídor .Id.ToString())
                    {

                       Console.WriteLine("Você gostaria de comprar " + Varinha_Do_Mago_Destruídor.Nome + " por " + Varinha_Do_Mago_Destruídor.Preco + "G? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                       resp = resp.ToLower();
                        if(resp == "s" )
                        {
                            if(p.gold >= Varinha_Do_Mago_Destruídor.Preco)
                            {
                                p.gold = p.gold - Varinha_Do_Mago_Destruídor.Preco;
                                p.Itens.Add(Varinha_Do_Mago_Destruídor);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END IF
                            else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE
                        }//END IF
                         else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//END ELSE 
                    }//END ELSE IF























                    else if(ic == Escudo_De_Superproteçao.Id.ToString())
                    {
                       Console.WriteLine("Você gostaria de comprar " + Escudo_ De_Superproteçao.Nome + " por " +Escudo_De_Superproteçao  .Preco + "G? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >=  Escudo_ De_Superproteçao,.Preco)
                            {
                                p.gold = p.gold -  Escudo_ De_Superproteçao.Preco;
                                p.Itens.Add( Escudo_ De_Superproteçao,);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");
                                 Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END IF
                           else
                            {
                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE
                        }//END IF
                             else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//END ELSE 
                    }//END ELSE IF
















                     else if(ic == Espada_Do_Infinito.Id.ToString())
                    {

                       Console.WriteLine("Você gostaria de comprar " + Espada_Do_Infinito.Nome + " por " + Espada_Do_Infinito.Preco + "G? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.gold);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.gold >= Espada_Do_Infinito.Preco)
                            {
                                p.gold = p.gold - Espada_Do_Infinito.Preco;
                                p.Itens.Add(Espada_Do_Infinito);
                                Console.Clear();
                                Console.WriteLine("Item adicionado ao iventário com sucesso!");    
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END IF
                            else
                            {

                                Console.WriteLine("Saldo insuficiente");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//END ELSE
                        }//END IF
                        else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//END ELSE 
                    }//END ELSE IF







                    else{
                    Console.Clear();
                    Console.WriteLine(" Nao foi encontrado nenhum jogador...");
                    Console.WriteLine("Insira qualquer tecla para retornar ao menu principal...");
                    Console.ReadLine();
                    }//END ELSE

                   

                 }//END IF
            }//END FOREACH

    }



























    private static bool MenuPrincipal()
    {

            Item Boomachado = new Item();
            Boomachado.Id = 1;
            Boomachado.Nome = "Boomachado";
            Boomachado.Preco = 55;
            Boomachado.Desc = "(+30% VELOCIDADE DE ATAQUE)";

            Item Adagas_Destruidoras = new Item();
            Adagas_Destruidoras.Id = 60;
             Adagas_Destruidoras.Nome = " Adagas_Destruidoras";
            Adagas_Destruidoras.Preco = 100;
            Adagas_Destruidoras.Desc = "(+10% DANO DE ATAQUE)";

            Item Varinha_Do_Mago_Destruídor  = new Item();
            Varinha_Do_Mago_Destruídor .Id = 2;
            Varinha_Do_Mago_Destruídor .Nome = "Varinha_Do_Mago_Destruídor ";
            Varinha_Do_Mago_Destruídor.Preco = 30;
            Varinha_Do_Mago_Destruídor.Desc = "(CAUSA +15% DO DANO EQUIVALENTE A VIDA MÁXIMA RESTANTE DO ALVO)";

            Item Escudo_De_Superproteçao = new Item();
            Escudo_De_Superproteçao.Id = 4;
            Escudo_De_Superproteçao.Nome = " Escudo_De_Superproteçao";
            Escudo_De_Superproteçao.Preco = 95;
            Escudo_De_Superproteçao.Desc = "(+20% CHANCE DE ACERTO CRÍTICO)";

            Item Espada_Do_Infinito= new Item();
            Espada_Do_Infinito.Id = 5;
            Espada_Do_Infinito.Nome = " Espada_Do_Infinito";
            Espada_Do_Infinito.Preco = 69;
            Espada_Do_Infinito.Desc = "(+40% DANO DE ACERTO CRÍTICO)";


       


        Console.Clear();
        Console.WriteLine("==================================================================");
        Console.WriteLine("Entre com '1' para criar um jogador (necessário para entrar na loja).");
        Console.WriteLine("Entre com '2' para checar as informações de todos os jogadores criados.");
        Console.WriteLine("Entre com '3' para olhar o seu inventário.");
        Console.WriteLine("Entre com '4' para entrar na loja.");
        Console.WriteLine("Entre com '5' para encerrar o programa.");
        Console.WriteLine("==================================================================");
        switch (Console.ReadLine())
        {
            case "1":
            CreatePlayer();
            return true;//END CASE (SWITCH)


            case "2":
            ViewPlayers();
            return true;//END CASE (SWITCH)
    

            case "3":
            CheckInv();
            return true;//END CASE (SWITCH)


            case "4":
            (
                Boomachado,
                Adagas_Destruidoras,
                Varinha_Do_Mago_Destruídor,
                Escudo_De_Superproteçao,
                Espada_Do_Infinito
            );
            return true;//END CASE (SWITCH)


            //END PROGRAM
            case "5":
                return false;


            //DEFAULT ROUTE (BACK TO MENU)
            default:
                return true;





        }//END SWITCH
    
    }//END METHOD






}//END CLASS