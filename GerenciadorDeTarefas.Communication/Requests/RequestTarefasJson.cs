using GerenciadorDeTarefas.Communication.Emums;

namespace GerenciadorDeTarefas.Communication.Requests;

public class RequestTarefasJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descrisao { get; set; } = string.Empty;
    public Prioridade Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    public Status Status { get; set; }

}

