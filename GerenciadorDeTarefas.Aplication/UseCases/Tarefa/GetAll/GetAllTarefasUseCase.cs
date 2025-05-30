using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Aplication.UseCases.Tarefa.GetAll;

public class GetAllTarefasUseCase
{
    public ResponseAllTarefasJson Execute() => new ResponseAllTarefasJson
    {
        Tarefas = new List<ResponseMoreTarefasJson>
            {
                new ResponseMoreTarefasJson
                {
                    Id = 1,
                    Nome = "Reforma da Casa",
                    Descricao = "Reforma interna da Casa",
                    Prioridade = Communication.Emums.Prioridade.Media,
                    DataLimite = DateTime.Parse("2025-07-20"),
                    Status = Communication.Emums.Status.Em_Andamento,
                }
            }
    };

}

