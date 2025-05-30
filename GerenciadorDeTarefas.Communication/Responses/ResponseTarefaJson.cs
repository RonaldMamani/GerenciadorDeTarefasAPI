using GerenciadorDeTarefas.Communication.Emums;

namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseTarefaJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public Prioridade Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public Status Status { get; set; }
}

