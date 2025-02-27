
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8603 // Possible null reference return.
public class TarefaView
{

    public string MenuSelecao()
    {
        Console.WriteLine("----------MENU----------");
        Console.WriteLine("| 1. Criar Tarefa      |");
        Console.WriteLine("| 2. Excluir Tarefa    |");
        Console.WriteLine("| 3. Listar Tarefas    |");
        Console.WriteLine("| 4. Tarefas Pendentes |");
        Console.WriteLine("| 5. Finalizar Tarefa  |");
        Console.WriteLine("| 6. Sair              |");
        Console.WriteLine("------------------------");
        string escolha = Console.ReadLine();

        return escolha;
    }

    public string SolicitarNomeNovaTarefa()
    {
        Console.WriteLine("Digite o nome da sua tarefa:");
        string nome = Console.ReadLine();

        return nome;
    }

    public string SolicitarIdExcluirTarefa()
    {
        Console.WriteLine("Digite o ID da Tarefa para excluir:");
        string id = Console.ReadLine();

        return id;
    }

    public string SolicitarIdFinalizarTarefa()
    {
        Console.WriteLine("Digite o ID da Tarefa para ser finalizada:");
        string id = Console.ReadLine();

        return id;
    }
    public void ListarTarefas(List<Tarefa> tarefas)
    {
        Console.WriteLine("----------LISTA DE TAREFAS----------");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"#{tarefa.id}: {tarefa.nome} -> {(tarefa.finalizada ? "Finalizada" : "Pendente")}");
        }
        Console.WriteLine("------------------------------------");
    }
    public void ListarTarefasPendentes(List<Tarefa> tarefas)
{
    Console.WriteLine("----------LISTA DE TAREFAS PENDENTES----------");

    bool algumaPendente = false;

    foreach (var tarefa in tarefas)
    {
        if (!tarefa.finalizada) // Verifica se a tarefa n�o est� finalizada
        {
            Console.WriteLine($"#{tarefa.id}: {tarefa.nome} -> Pendente");
            algumaPendente = true;
        }
    }

    if (!algumaPendente)
    {
        Console.WriteLine("Nenhuma tarefa pendente");
    }

    Console.WriteLine("----------------------------------------------");
}

}