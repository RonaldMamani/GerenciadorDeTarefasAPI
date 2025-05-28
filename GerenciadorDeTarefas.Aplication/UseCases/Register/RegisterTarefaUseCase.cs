using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Aplication.UseCases.Register;

public class RegisterTarefaUseCase
{
    public ResponseRegisterTarefaJson Execute(RequestTarefasJson request)
    {
        return new ResponseRegisterTarefaJson
        {
            Id = request.Id,
            Nome = request.Nome,
            Descrisao = request.Descrisao,
            Prioridade = request.Prioridade,
            DataLimite = request.DataLimite
        };
    }
}

