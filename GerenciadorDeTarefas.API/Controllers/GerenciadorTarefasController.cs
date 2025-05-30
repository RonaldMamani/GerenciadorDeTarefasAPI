using GerenciadorDeTarefas.Aplication.UseCases.Tarefa.Delete;
using GerenciadorDeTarefas.Aplication.UseCases.Tarefa.GetAll;
using GerenciadorDeTarefas.Aplication.UseCases.Tarefa.GetById;
using GerenciadorDeTarefas.Aplication.UseCases.Tarefa.Register;
using GerenciadorDeTarefas.Aplication.UseCases.Tarefa.Update;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class GerenciadorTarefasController : ControllerBase
{
    // Criar Tarefas
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult RegisterTarefas([FromBody] RequestTarefasJson request)
    {
        var response = new RegisterTarefaUseCase().Execute(request);
        return Created(string.Empty, response);
    }

    // Editar Tarefa
    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult UpdateTarefa([FromRoute] int id, [FromBody] RequestTarefasJson request)
    {
        var useCase = new UpdateTarefaUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    // Visualizar Todas as Tarefas
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTarefasJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAllTarefas() 
    {
        var useCase = new GetAllTarefasUseCase();
        var response = useCase.Execute();
        
        if (response.Tarefas.Any())
        {
            return Ok(response);
        }

        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTarefaJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
    public IActionResult Get(int id)
    {
        var useCase = new GetTarefaByIdUseCase();
        var response = useCase.Execute(id);

        return Ok(response);
    }

    // Deletar Tarefa
    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteTarefa([FromRoute] int id) 
    {
        var useCase = new DeleteTarefaByToIdUseCase();
        useCase.Execute(id);

        return NoContent();
    }
}
