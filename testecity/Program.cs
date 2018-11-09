using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace testecity
{
    class Program
    {
        private static int id;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Inicio();
            Introducao();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Inicio();
            Console.Write("\n\nPressione enter p/ prosseguir");
            Console.ReadKey();

            int opcao;
            do

            {
                Console.Clear();

                Console.WriteLine("\n\t\t\t\t          *****************************PET SHOP******************************       ");
                Console.WriteLine("\t\t\t\t\t   _________________________________________________________________________________");
                Console.WriteLine("\t\t\t\t\t  | CADASTRO                              | CONSULTA                                |");
                Console.WriteLine("\t\t\t\t\t  |---------------------------------------|-----------------------------------------|");
                Console.WriteLine("\t\t\t\t\t  | 01 - Cadastro de Cliente              | 05 - Consulta de Clientes               |");
                Console.WriteLine("\t\t\t\t\t  | 02 - Cadastro de Funcionários         | 06 - Consulta de Agendamentos           |");
                Console.WriteLine("\t\t\t\t\t  | 03 - Cadastro de Serviços             | 07 - Consulta de Serviços               |");
                Console.WriteLine("\t\t\t\t\t  | 04 - Cadastro de Produtos             | 08 - Consulta de Produtos               |");
                Console.WriteLine("\t\t\t\t\t  |---------------------------------------|-----------------------------------------|");
                Console.WriteLine("\t\t\t\t\t  | 09 - Agendamento                                                                |");
                Console.WriteLine("\t\t\t\t\t  | 10 - Remover                                                                    |");
                Console.WriteLine("\t\t\t\t\t  |---------------------------------------------------------------------------------|");
                Console.WriteLine("\t\t\t\t\t  | 0 - Sair                                                                        |");
                Console.WriteLine("\t\t\t\t\t  |_________________________________________________________________________________|");

                Console.Write("\n\t\tESCOLHA OPÇÃO DESEJADA: ");
                while (!(int.TryParse(Console.ReadLine(), out opcao)))
                    Console.Write("Opção não numérica. DIGITE A OPÇÃO DESEJADA: ");
                Console.WriteLine("\n");
                switch (opcao)
                {
                    case 1:
                        cadastrarCliente();
                        break;
                    case 2:
                        cadastrarFuncionario();
                        break;
                    case 3:
                        cadastrarServicos();
                        break;
                    case 4:
                        cadastrarProdutos();
                        break;
                    case 5:
                        consultarCliente();
                        break;
                    case 6:
                        consultarAgendamento();
                        break;
                    case 7:
                        consultarServicos();
                        break;
                    case 8:
                        consultarProdutos();
                        break;
                    case 9:
                        agendamento();
                        break;
                    case 10:
                        remover();
                        break;
                    case 0:
                        Console.Write("Voce escolhe  a opção 0 e assim o Sistema será encerrado.");
                        Console.Write("\n\nDesenvolvido .");

                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;
                }//fim do switch
                Console.Write("\n\nPressione qualquer tecla p/ continuar.");
                Console.ReadKey();
                Console.Clear();
            } while (opcao != 0);
        }

        static void Introducao()
        {
            {
                Console.Clear();
                Inicio();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
                Console.Clear();
                Inicio();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                Console.Clear();
                Inicio();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
                Console.Clear();
                Console.Clear();
                Inicio();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(1000);
                Console.Clear();
                Inicio();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                Console.Clear();
                Inicio();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(00);
                Console.Clear();
            }

        }

        static void Inicio()
        {
            {

                Console.WriteLine("   SSSSSSSSSSSSSSSS  YYYYYYYY      YYYYYYYYY   SSSSSSSSSSSSSSSS   CCCCCCCCCCCCCCCCCCCCCC RRRRRRRRRRRRRRRRRRRRRR  EEEEEEEEEEEEEEEEEEEEEEE  AAAAAAAAAAAAAAAAAAAAAAAA  TTTTTTTTTTTTTTTTTTTTTTT IIIIIIIIIIIIIIIIIIIIII  OOOOOOOOOOOOOOOOOOO  NNNNNNNNN             NNNNNNNN");
                Console.WriteLine(" SS::::::::::::::::S Y::::::Y       Y::::::Y  SS::::::::::::::::S CCC::::::::::::::::CCC R:::::::::::::::::::::R  E::::::::::::::::::::E A::::::::::::::::::::::::A T:::::::::::::::::::::T I::::::::::::::::::::I O:::::::::::::::::::O N::::::::N            N::::::N");
                Console.WriteLine("S::::::SSSSSS::::::S Y::::::Y       Y::::::Y S::::::SSSSSS::::::S CC::::::::::::::::::CC R:::::::::::::::::::::R  E::::::::::::::::::::E A::::::::::::::::::::::::A T:::::::::::::::::::::T I::::::::::::::::::::I O:::::::::::::::::::O N:::::::::N           N::::::N");
                Console.WriteLine("S::::::S     SSSSSSS Y:::::::Y     Y:::::::Y S::::::S     SSSSSSS CC:::::CCCCCCCCCCCCCCC R::::::RRRRRRRRRR:::::R  EE::::::EEEEEEEEE::::E A::::::AAAAAAAAAAAA::::::A T:::::TT:::::::TT:::::T I::::::::::::::::::::I O:::::::::::::::::::O N::::::::::N          N::::::N");
                Console.WriteLine("S::::::S             YYY::::::Y   Y::::::YYY S::::::S             C:::::C                R::::::R        R:::::R  E:::::E       EEEEEEEE A::::::A          A::::::A TTTTTT  T:::::T  TTTTTT I::::::I:::::I:::::::I O:::::::OOOOO:::::::O N:::::::::::N         N::::::N");
                Console.WriteLine("S::::::S                Y::::::Y Y::::::Y    S::::::S             C:::::C                R::::::R        R:::::R  E:::::E                A::::::A          A::::::A         T:::::T                I:::::I         O::::::O     O::::::O N::::::::::::N        N::::::N");
                Console.WriteLine(" S:::::SSSS              Y::::::Y::::::Y      S:::::SSSS          C:::::C                R::::::RRRRRRRRRR::::R   E::::::EEEEEEEEEE      A::::::A          A::::::A         T:::::T                I:::::I         O::::::O     O::::::O N:::::::N:::::N       N::::::N");
                Console.WriteLine("  SS:::::::SSSSS          Y::::::::::Y        SS:::::::SSSSS      C:::::C                R::::::R R:::::R         E:::::::::::::::E      A::::::AAAAAAAAAAAA::::::A         T:::::T                I:::::I         O::::::O     O::::::O N::::::N N:::::N      N::::::N");
                Console.WriteLine("    SSS:::::::::SS         Y:::::::::Y           SSS:::::::::SS   C:::::C                R::::::R  R:::::R        E:::::::::::::::E      A::::::AAAAAAAAAAAA::::::A         T:::::T                I:::::I         O::::::O     O::::::O N::::::N  N:::::N     N::::::N");
                Console.WriteLine("       SSSSSS:::::S         Y:::::::Y               SSSSSS:::::S  C:::::C                R::::::R   R:::::R       E::::::EEEEEEEEEE      A::::::A          A::::::A         T:::::T                I:::::I         O::::::O     O::::::O N::::::N   N:::::N    N::::::N");
                Console.WriteLine("            S::::::S        Y:::::::Y                   S::::::S  C:::::C                R::::::R    R:::::R      E:::::E                A::::::A          A::::::A         T:::::T                I:::::I         O::::::O     O::::::O N::::::N    N:::::N   N::::::N");
                Console.WriteLine("            S::::::S        Y:::::::Y                    S::::::S C:::::C                R::::::R     R:::::R     E:::::E       EEEEEEEE A::::::A          A::::::A         T:::::T                I:::::I         O::::::O     O::::::O N::::::N     N:::::N  N::::::N");
                Console.WriteLine("SSSSSSS     S::::::S        Y:::::::Y        SSSSSSS     S::::::S C:::::C                R::::::R      R:::::R    EE:::::EEEEEEEE::::::E A::::::A          A::::::A       TT:::::::TT       I::::::I:::::I:::::::I O:::::::OOOOO:::::::O N::::::N      N:::::N N::::::N");
                Console.WriteLine("S::::::SSSSSS::::::S     YYYY:::::::YYYY     S::::::SSSSSS::::::S CC:::::CCCCCCCCCCCCCCC R::::::R       R:::::R   E::::::::::::::::::::E A::::::A          A::::::A       T:::::::::T       I::::::::::::::::::::I O:::::::::::::::::::O N::::::N       N:::::::::::::N");
                Console.WriteLine("S::::::::::::::::SS      Y:::::::::::::Y     S::::::::::::::::SS  CCC::::::::::::::::CCC R::::::R        R:::::R  EE:::::::::::::::::::E A::::::A          A::::::A       T:::::::::T       I::::::::::::::::::::I O:::::::::::::::::::O N::::::N        N::::::::::::N");
                Console.WriteLine(" SSSSSSSSSSSSSSSSS       YYYYYYYYYYYYYYY       SSSSSSSSSSSSSSSS   CCCCCCCCCCCCCCCCCCCCCC RRRRRRRR         RRRRRRR EEEEEEEEEEEEEEEEEEEEEE AAAAAAAA          AAAAAAAA       TTTTTTTTTTT       IIIIIIIIIIIIIIIIIIIIII  OOOOOOOOOOOOOOOOOOO  NNNNNNNN         NNNNNNNNNNNNN\n\n");


            }

        }

        static void cadastrarCliente()
        {
            //declarando variáveis para o cadastro de cliente
            int id, telefone, cpf;
            string nome, endereco, bairro, pet;
            char email;
            //inicio do laço de repetição "Faça" para todo o programa
            do
            {
                Console.Clear();
                Console.WriteLine("\n ********** CADASTRO DE CLIENTE **********");

                Console.Write("\n id: ");
                while (!(int.TryParse(Console.ReadLine(), out id)))
                    Console.Write("Opção não numérica. Digite o id novamente: ");

                Console.Write("Nome: ");
                nome = Console.ReadLine();
                while (nome == "")
                {
                    Console.Write("Opção inexistente. Digite o nome novamente: ");
                    nome = Console.ReadLine();
                }
                Console.Write("Telefone: ");
                while (!(int.TryParse(Console.ReadLine(), out telefone)))
                    Console.Write("Opção não numérica. Digite o telefone novamente: ");

                Console.Write("CPF: ");
                while (!(int.TryParse(Console.ReadLine(), out cpf)))
                    Console.Write("Opção não numérica. Digite o cpf novamente: ");

                Console.Write("Endereço: ");
                endereco = Console.ReadLine();
                while (endereco == "")
                {
                    Console.Write("Opção inexistente. Digite o endereço novamente: ");
                    endereco = Console.ReadLine();
                }
                Console.Write("Bairro: ");
                bairro = Console.ReadLine();
                while (bairro == "")
                {
                    Console.Write("Opção inexistente. Digite o bairro novamente: ");
                    bairro = Console.ReadLine();
                }
                Console.Write("Email: ");
                while (!(char.TryParse(Console.ReadLine(), out email)))
                {
                    Console.Write("Opção inexistente. Digite o email novamente: ");
                }

                Console.Write("Pet: ");
                pet = Console.ReadLine();
                while (pet == "")
                {
                    Console.Write("Opção inexistente. Digite o pet novamente: ");
                    pet = Console.ReadLine();
                }
                DirectoryInfo dir = new DirectoryInfo(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroClientes"); //direitório onde a pasta será criada// //verificando se a pasta existe//

                if (!dir.Exists)
                    try
                    {
                        //caso Não exista cria a pasta Cadastro de aluno em C:\
                        dir.Create();
                    }
                    //Caso ocorra erro
                    catch (Exception e)
                    {
                        Console.WriteLine("\n Não foi possivel criar o diretório: {0}", e.ToString());
                    }
                    finally { }

                //instaciando o stream de arquivo
                FileStream CriaArquivo = new FileStream(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroClientes\clientes.txt", FileMode.Append); //diretório onde a pasta e arquivo serão criados//
                StreamWriter Arquivo = new StreamWriter(CriaArquivo, Encoding.ASCII);

                //Informações do Cliente serão gravadas no txt//
                Arquivo.WriteLine("");
                Arquivo.WriteLine("********************NOVO REGISTRO DE CLIENTE********************");
                Arquivo.WriteLine("Cod: "); Arquivo.WriteLine(Convert.ToString(id));
                Arquivo.WriteLine("Nome: "); Arquivo.WriteLine(nome);
                Arquivo.WriteLine("Telefone"); Arquivo.WriteLine(Convert.ToString(telefone));
                Arquivo.WriteLine("Endereço"); Arquivo.WriteLine(endereco);
                Arquivo.WriteLine("Bairro"); Arquivo.WriteLine(bairro);
                Arquivo.WriteLine("Email"); Arquivo.WriteLine(email);
                Arquivo.WriteLine("Pet"); Arquivo.WriteLine(pet);


                Arquivo.Flush();
                Arquivo.Close();
                CriaArquivo.Close();

                Console.WriteLine("\n\tCliente cadastrado com sucesso!\n");
                Console.ReadKey();
                Thread.Sleep(600);
                Console.Clear();
                Console.Write("\nDeseja fazer um novo cadastro? (S/N): ");

            }
            while (id != 0);

        }

        static void cadastrarFuncionario()
        {
            int id, telefone, cpf;
            string nome, endereco, bairro;
            char email;

            do
            {
                Console.Clear();
                Console.WriteLine("********** \nCADASTRO DE FUNCIONÁRIO **********");
                Console.Write("ID: ");
                while (!(int.TryParse(Console.ReadLine(), out id)))
                    Console.Write("Opção não numérica! Digite o ID novamente: ");

                Console.Write("Nome: ");
                nome = Console.ReadLine();
                while (nome == "")
                {
                    Console.Write("Opção inválida! Digite o Nome novamente: ");
                    nome = Console.ReadLine();
                }

                Console.Write("CPF: ");
                while (!(int.TryParse(Console.ReadLine(), out cpf)))
                    Console.Write("Opção não numérica! Digite o CPF novamente: ");

                Console.Write("Telefone: ");
                while (!(int.TryParse(Console.ReadLine(), out telefone)))
                    Console.Write("Opção não numérica! Digite o Telefone novamente: ");

                Console.Write("Endereço: ");
                endereco = Console.ReadLine();
                while (endereco == "")
                {
                    Console.Write("Opção inválida! Digite o Endereço novamente: ");
                    endereco = Console.ReadLine();
                }

                Console.Write("Bairro: ");
                bairro = Console.ReadLine();
                while (bairro == "")
                {
                    Console.Write("Opção inválida! Digite o Bairro novamente: ");
                    bairro = Console.ReadLine();
                }

                Console.Write("E-mail: ");
                while (!(char.TryParse(Console.ReadLine(), out email)))
                    Console.Write("Opção não inválida! Digite o E-mail novamente: ");


            } while (id != 0);

        }

        static void cadastrarProdutos()
        {
            int id, qtd;
            double valor;
            string nomeprod;

            do
            {
                Console.Clear();
                Console.WriteLine("\n ********** CADASTRO DE PRODUTOS **********");

                Console.Write("\n ID: ");
                while (!int.TryParse(Console.ReadLine(), out id)) ;

                Console.Write("Nome: ");
                nomeprod = Console.ReadLine();
                while (nomeprod == "")
                {
                    Console.WriteLine("Opção inexistente. Digite o nome do produto novamente: ");
                    nomeprod = Console.ReadLine();
                }

                Console.Write("Valor: ");
                while (!double.TryParse(Console.ReadLine(), out valor)) ;

                Console.Write("Quantidade: ");
                while (!int.TryParse(Console.ReadLine(), out qtd)) ;

                DirectoryInfo dir = new DirectoryInfo(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroProdutos"); //direitório onde a pasta será criada// //verificando se a pasta existe//

                if (!dir.Exists)
                    try
                    {
                        //caso Não exista cria a pasta Cadastro de aluno em C:\
                        dir.Create();
                    }
                    //Caso ocorra erro
                    catch (Exception e)
                    {
                        Console.WriteLine("\n Não foi possivel criar o diretório: {0}", e.ToString());
                    }
                    finally { }

                //instaciando o stream de arquivo
                FileStream CriaArquivo = new FileStream(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroProdutos\produto.txt", FileMode.Append); //diretório onde a pasta e arquivo serão criados//
                StreamWriter Arquivo = new StreamWriter(CriaArquivo, Encoding.ASCII);

                //Informações do Cliente serão gravadas no txt//
                Arquivo.WriteLine("");
                Arquivo.WriteLine("********************NOVO REGISTRO DE PRODUTO********************");
                Arquivo.WriteLine("Cod: "); Arquivo.WriteLine(Convert.ToString(id));
                Arquivo.WriteLine("Nome: "); Arquivo.WriteLine(nomeprod);
                Arquivo.WriteLine("Valor: "); Arquivo.WriteLine(valor);
                Arquivo.WriteLine("Quantidade: "); Arquivo.WriteLine(qtd);


                Arquivo.Flush();
                Arquivo.Close();
                CriaArquivo.Close();

                Console.WriteLine("\n\tProduto cadastrado com sucesso!\n");
                Console.ReadKey();
                Thread.Sleep(600);
                Console.Clear();
                Console.Write("\nDeseja fazer um novo cadastro? (S/N): ");

            }
            while (id != 0);

        }

        static void cadastrarServicos()
        {
            int id;
            double valor;
            string nomeserv;

            do
            {
                Console.Clear();
                Console.WriteLine("\n ********** CADASTRO DE PRODUTOS **********");

                Console.Write("\n ID: ");
                while (!int.TryParse(Console.ReadLine(), out id)) ;

                Console.Write("Nome: ");
                nomeserv = Console.ReadLine();
                while (nomeserv == "")
                {
                    Console.WriteLine("Opção inexistente. Digite o nome do produto novamente: ");
                    nomeserv = Console.ReadLine();
                }

                Console.Write("Valor: ");
                while (!double.TryParse(Console.ReadLine(), out valor)) ;

                DirectoryInfo dir = new DirectoryInfo(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroServicos"); //direitório onde a pasta será criada// //verificando se a pasta existe//

                if (!dir.Exists)
                    try
                    {
                        //caso Não exista cria a pasta Cadastro de aluno em C:\
                        dir.Create();
                    }
                    //Caso ocorra erro
                    catch (Exception e)
                    {
                        Console.WriteLine("\n Não foi possivel criar o diretório: {0}", e.ToString());
                    }
                    finally { }

                //instaciando o stream de arquivo
                FileStream CriaArquivo = new FileStream(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroServicos\servicos.txt", FileMode.Append); //diretório onde a pasta e arquivo serão criados//
                StreamWriter Arquivo = new StreamWriter(CriaArquivo, Encoding.ASCII);

                //Informações do Cliente serão gravadas no txt//
                Arquivo.WriteLine("");
                Arquivo.WriteLine("********************NOVO REGISTRO DE SERVIÇO********************");
                Arquivo.WriteLine("Cod: "); Arquivo.WriteLine(Convert.ToString(id));
                Arquivo.WriteLine("Nome: "); Arquivo.WriteLine(nomeserv);
                Arquivo.WriteLine("Valor: "); Arquivo.WriteLine(valor);


                Arquivo.Flush();
                Arquivo.Close();
                CriaArquivo.Close();

                Console.WriteLine("\n\tServiço cadastrado com sucesso!\n");
                Console.ReadKey();
                Thread.Sleep(600);
                Console.Clear();
                Console.Write("\nDeseja fazer um novo cadastro? (S/N): ");

            }
            while (id != 0);

        }

        static void agendamento()
        {
            string nomeCliente, pet, nomeVeterinario;
            char data, horario;

            do
            {
                Console.Clear();
                Console.WriteLine("\n********** AGENDAMENTO **********");
                Console.Write("Nome do Cliente: ");
                nomeCliente = Console.ReadLine();
                while (nomeCliente == "")
                {
                    Console.Write("Opção inválida! Digite o nome do cliente novamente: ");
                    nomeCliente = Console.ReadLine();
                }

                Console.Write("Pet:");
                pet = Console.ReadLine();
                while (pet == "")
                {
                    Console.Write("Opção inválida! Digite o Pet novamente: ");
                    pet = Console.ReadLine();
                }

                Console.Write("Nome do Veterinário:");
                nomeVeterinario = Console.ReadLine();
                while (nomeVeterinario == "")
                {
                    Console.Write("Opção inválida! Digite o Nome do Veterinário novamente: ");
                    nomeVeterinario = Console.ReadLine();
                }

                Console.Write("Data: ");
                while (!(char.TryParse(Console.ReadLine(), out data)))
                {
                    Console.Write("Opção inválida! Digite a data novamente: ");
                }

                Console.Write("Horário: ");
                while (!(char.TryParse(Console.ReadLine(), out horario)))
                {
                    Console.Write("Opção inválida! Digite o horário novamente: ");
                }

                DirectoryInfo dir = new DirectoryInfo(@"C:\ETEC\PA\aula_cidade\aula_cidade\Agendamento"); //direitório onde a pasta será criada// //verificando se a pasta existe//


                if (!dir.Exists)
                    try
                    {
                        dir.Create();
                    }

                    catch (Exception e)
                    {
                        Console.WriteLine("\nNão foi possível criar o diretório: {0}", e.ToString());
                    }
                    finally { }

                FileStream CriaArquivo = new FileStream(@"C:\ETEC\PA\aula_cidade\aula_cidade\Agendamento\agendamentos", FileMode.Append);
                StreamWriter Arquivo = new StreamWriter(CriaArquivo, Encoding.ASCII);

                Arquivo.WriteLine("");
                Arquivo.WriteLine("********** NOVO AGENDAMENTO **********");
                Arquivo.Write("Nome do Cliente: "); Arquivo.WriteLine(nomeCliente);
                Arquivo.Write("Pet: "); Arquivo.WriteLine(pet);
                Arquivo.Write("Nome do Veterinário: "); Arquivo.WriteLine(nomeVeterinario);
                Arquivo.Write("Data: "); Arquivo.WriteLine(Convert.ToString(data));
                Arquivo.Write("Horário: "); Arquivo.WriteLine(Convert.ToString(horario));

                Arquivo.Flush();
                Arquivo.Close();
                CriaArquivo.Close();

                Console.WriteLine("Agendamento realizado com sucesso!\n");
                Console.ReadKey();
                Thread.Sleep(600);
                Console.Clear();
                Console.Write("\nDeseja fazer um novo cadastro? (S/N): ");

            } while (id != 0);
        }

        static void consultarCliente()
        {

            Console.Clear();
            Console.WriteLine("********** \nCONSULTAR CLIENTES **********");

            if (File.Exists(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroClientes\clientes.txt"))
            {
                Stream entrada = File.Open(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroClientes\clientes.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                String linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        static void consultarServicos()
        {

            Console.Clear();
            Console.WriteLine("********** \nCONSULTAR SERVIÇOS **********");

            if (File.Exists(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroServicos\servicos.txt"))
            {
                Stream entrada = File.Open(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroServicos\servicos.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                String linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
            else
            {
                Console.WriteLine("Serviço não encontrado.");
            }
        }

        static void consultarProdutos()
        {

            Console.Clear();
            Console.WriteLine("********** \nCONSULTAR SERVIÇOS **********");

            if (File.Exists(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroProdutos\produtos.txt"))
            {
                Stream entrada = File.Open(@"C:\ETEC\PA\aula_cidade\aula_cidade\CadastroProdutos\produtos.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                String linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        static void consultarAgendamento()
        {

            Console.Clear();
            Console.Write("\n********** CONSULTAR AGENDAMENTO *********");

            if (File.Exists(@"C:\Agendamento\agendamentos.txt"))
            {
                Stream entrada = File.Open(@"C:\Agendamento\agendamentos.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
            else
            {
                Console.WriteLine("Agendamento não encontrado!");
            }


        }

        static void remover()
        {
            string confirma, Caminho = (@"C:\CadastroCliente\cadastrados.txt"); // diretório onde a pasta e arquivo serão criados //

            Console.Clear();
            Console.WriteLine(" ########  REMOVER CLIENTE #######");
            if (File.Exists(@"C:\CadastroCliente\cadastrados.txt")) // diretório onde a pasta e arquivo serão criados //
            {
                Stream entrada = File.Open(@"C:\CadastroCliente\cadastrados.txt", FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();

                Console.Write("\n Deseja excluir os Clientes (S/N): ");
                confirma = Console.ReadLine();
                confirma = confirma.ToUpper();
                while (confirma == string.Empty || confirma != "S" && confirma != "N")
                {
                    Console.Clear();
                    Console.Write("\n Resposta inválida! Digite (S) para sim ou (N) para não: ");
                    confirma = Console.ReadLine();
                    confirma = confirma.ToUpper();
                }
                if (confirma == "S")
                {
                    File.Delete(Caminho);
                    Console.WriteLine("\n Clientes excluidos com sucesso!!!.");
                }
                else
                {
                    Console.WriteLine("\n Exclusão cancelada.");
                }
            }
            else
            {
                Console.WriteLine("\n Clientes não encontrados.");
            }

        }

    }
    
}







