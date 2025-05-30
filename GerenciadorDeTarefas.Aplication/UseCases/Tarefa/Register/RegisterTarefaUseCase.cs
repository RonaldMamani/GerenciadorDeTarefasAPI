using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Aplication.UseCases.Tarefa.Register;

public class RegisterTarefaUseCase
{
    public ResponseRegisterTarefaJson Execute(RequestTarefasJson request)
    {
        return new ResponseRegisterTarefaJson
        {
            Id = request.Id,
            Nome = request.Nome,
            Descricao = request.Descricao,
            Prioridade = request.Prioridade,
            DataLimite = request.DataLimite
        };
    }
}

