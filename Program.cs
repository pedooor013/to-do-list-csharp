using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tasks> tarefas = new List<Tasks>();

            int escolhaUser;
            do
            {
                Console.Write("Escolha uma opção:" +
                    "\n1) Criar uma tarefa;" +
                    "\n2) Concluir uma tarefa;" +
                    "\n3) Listar tarefa(s);" +
                    "\n4) Listar tarefas concluídas;" +
                    "\n5) Listas tarefas não concluídas;" +
                    "\n6) Deletar uma tarefa;" +
                    "\n7) Sair;" +
                    "\nSelecione: ");
                escolhaUser = int.Parse(Console.ReadLine());

                switch (escolhaUser)
                {
                    case 1:
                        Console.WriteLine("Nome da tarefa:");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Descrição da tarefa:");
                        string descricao = Console.ReadLine();

                        DateTime dataCriacao = DateTime.Now.Date;

                        Console.WriteLine("Prazo da tarefa (dd/mm/aaaa):");
                        string prazoTexto = Console.ReadLine();

                        DateTime prazo = DateTime.ParseExact(
                            prazoTexto,
                            "dd/MM/yyyy",
                            System.Globalization.CultureInfo.InvariantCulture
                        );

                        bool eh_concluida = false;

                        Tasks novaTask = new Tasks(nome, descricao, dataCriacao, prazo);
                        tarefas.Add(novaTask);

                        Console.WriteLine("Tarefa cadastrada com sucesso!");
                        break;
                    case 2:
                        foreach(Tasks task in tarefas)
                        {
                            int contagem = 1;
                            if (!task.Eh_Concluida)
                            {
                            Console.WriteLine($"{contagem} - {task.Nome}");
                            contagem++;
                            }
                        }

                        Console.WriteLine("Qual tarefa você deseja concluir:");
                        int taskIndex = int.Parse(Console.ReadLine()) - 1;

                        tarefas[taskIndex].Eh_Concluida = true;

                        Console.WriteLine($"Tarefa {tarefas[taskIndex].Nome} foi concluída com sucesso!");

                        break;
                    case 3:
                        foreach(Tasks task in tarefas)
                        {
                            int contagem = 1;
                            Console.WriteLine($"{contagem} - {task.Nome}" +
                                $"\nDescrição: {task.Descricao}" +
                                $"\nData Criação: {task.DataCriacao.ToString("dd/MM/yyyy")}" +
                                $"\nPrazo Final: {task.Prazo.ToString("dd/MM/yyyy")}" +
                                $"\nDias Validade: {task.DiasTermino()}");
                            if (task.Eh_Concluida)
                            {
                                Console.WriteLine("Status: Concluída;");
                            }
                            else 
                            {
                                Console.WriteLine("Status: Não concluída;");
                            }
                            Console.WriteLine("==========================================================================");
                            contagem++;
                        }
                        break;
                    case 4:
                        foreach (Tasks task in tarefas)
                        {
                            if (task.Eh_Concluida)
                            {
                            int contagem = 1;
                                Console.WriteLine($"{contagem} - {task.Nome}" +
                                    $"\nDescrição: {task.Descricao}" +
                                    $"\nData Criação: {task.DataCriacao.ToString("dd/MM/yyyy")}" +
                                    $"\nPrazo Final: {task.Prazo.ToString("dd/MM/yyyy")}" +
                                    $"\nDias Validade: {task.DiasTermino()}");
                                if (task.Eh_Concluida)
                                {
                                    Console.WriteLine("Status: Concluída;");
                                }
                                else
                                {
                                    Console.WriteLine("Status: Não concluída;");
                                }
                                Console.WriteLine("==========================================================================");
                                contagem++;
                            }
                        }
                        break;
                    case 5:
                        foreach (Tasks task in tarefas)
                        {
                            if (!task.Eh_Concluida)
                            {
                            int contagem = 1;
                                Console.WriteLine($"{contagem} - {task.Nome}" +
                                    $"\nDescrição: {task.Descricao}" +
                                    $"\nData Criação: {task.DataCriacao.ToString("dd/MM/yyyy")}" +
                                    $"\nPrazo Final: {task.Prazo.ToString("dd/MM/yyyy")}" +
                                    $"\nDias Validade: {task.DiasTermino()}");
                                if (task.Eh_Concluida)
                                {
                                    Console.WriteLine("Status: Concluída;");
                                }
                                else
                                {
                                    Console.WriteLine("Status: Não concluída;");
                                }
                                Console.WriteLine("\n==========================================================================");
                                contagem++;
                            }
                        }
                        break;
                    case 6:
                        foreach (Tasks task in tarefas)
                        {
                            int contagem = 1;
                            Console.WriteLine($"{contagem} - {task.Nome}");
                            contagem++;
                        }

                        Console.WriteLine("Selecione qual tarefa você quer deletar: ");

                        int index = int.Parse(Console.ReadLine()) - 1;

                        tarefas.RemoveAt(index);

                        Console.WriteLine("Tarefa excluida com sucesso!");

                        break;
                    case 7:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Valor inválido! Digite novamente!");
                        break;
                }
            } while (escolhaUser != 7);
        }
    }
}