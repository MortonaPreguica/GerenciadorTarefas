// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem-vindo a seu Gerenciador de tarefas. Para começar digite o comando: ");


string? comando = "0";

List<string> listaTarefas = new();

while(comando != "9")
{
    if (comando != null)
    {
        if(comando.Equals("0"))
        {
            Console.WriteLine("1 - Adicionar tarefa. ");
            Console.WriteLine("2 - Listar tarefa. ");
            Console.WriteLine("3 - Editar tarefa. ");
            Console.WriteLine("4 - Excluir tarefa. ");
            Console.WriteLine("Digite o comando:");

            comando = Console.ReadLine();
        }
        
        if (comando == "1")
        {
            Console.WriteLine("Adicione o nome da tarefa: ");
            string? novaTarefa = Console.ReadLine();

            if (novaTarefa != null)
            {
                listaTarefas.Add(novaTarefa);
                Console.WriteLine("Tarefa criada com sucesso!");
                comando = "0";
            }

        }
        else if (comando == "2")
        {
            Console.WriteLine("Lista de tarefas");

            for (int i = 0; i < listaTarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {listaTarefas[i]} ");
            }

            comando = "0";
            Console.WriteLine("Finalizou!");
        }
        else if(comando == "3") 
        { 
            
        }
    }
}

