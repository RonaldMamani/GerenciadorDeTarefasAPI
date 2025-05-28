using GerenciadorDeTarefas.Communication.Emums;

namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseRegisterTarefaJson
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descrisao { get; set; } = string.Empty;
    public Prioridade Prioridade { get; set; }
    public DateTime DataLimite { get; set; }
    
}

