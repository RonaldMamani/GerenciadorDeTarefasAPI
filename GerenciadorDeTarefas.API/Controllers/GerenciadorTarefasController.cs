using GerenciadorDeTarefas.Aplication.UseCases.Register;
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
}
