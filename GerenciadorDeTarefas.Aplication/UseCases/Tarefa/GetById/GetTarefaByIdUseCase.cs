using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Aplication.UseCases.Tarefa.GetById;

public class GetTarefaByIdUseCase
{
    public ResponseTarefaJson Execute(int id)
    {
        return new ResponseTarefaJson
        {
            Id = id,
            Nome = "Construir Casa",
            Descricao = "Reforma de Imovel",
            Prioridade = Communication.Emums.Prioridade.Alta,
            DataLimite = new DateTime(year: 2024, month: 08, day: 20),
            Status = Communication.Emums.Status.Em_Andamento
        };
    }
}

