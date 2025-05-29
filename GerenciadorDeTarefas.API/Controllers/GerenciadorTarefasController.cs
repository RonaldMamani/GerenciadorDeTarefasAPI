using GerenciadorDeTarefas.Aplication.UseCases.Tarefa.Delete;
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
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarefaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    public IActionResult RegisterTarefas([FromBody] RequestTarefasJson request)
    {
        var response = new RegisterTarefaUseCase().Execute(request);
        return Created(string.Empty, response);
    }

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
