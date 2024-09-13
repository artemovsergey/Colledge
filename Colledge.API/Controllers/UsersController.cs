using Asp.Versioning;
using Colledge.Application.Features.ListUsers;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Colledge.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly ILogger<UsersController> _logger;
    public UsersController(IMediator mediatr, ILogger<UsersController> logger)
    {
        _logger = logger;
        _mediator = mediatr;
    }

    //[Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        
        var users = await _mediator.Send(new ListUsersRequest());

        if (users == null)
        {
            return NotFound("Пользователи не найдены");
        }
        return Ok(users);
    }
}


//    [HttpPost]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(StatusCodes.Status400BadRequest)]
//    [SwaggerOperation(Summary = "Создание репозитория.")]
//    [SwaggerResponse(StatusCodes.Status200OK, "Repo created success")]
//    [SwaggerResponse(StatusCodes.Status400BadRequest, "Repo not created", typeof(ValidationProblemDetails))]
//    public async Task<ActionResult<Repository>> PostRepository([FromBody] Repository repo)
//    {
//        var response = await _mediator.Send(new AddRepositoryRequest(repo));
//        if (response.repo == null)
//        {
//            return BadRequest("Репозиторий не создан!");
//        }
//        return Ok("Новый репозиторий создан!");
//    }

//    [Authorize]
//    [HttpPut]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(StatusCodes.Status400BadRequest)]
//    [SwaggerOperation(Summary = "Редактирование репозитория.")]
//    [SwaggerResponse(StatusCodes.Status200OK, "Repo edited success")]
//    [SwaggerResponse(StatusCodes.Status400BadRequest, "Repo not edited", typeof(ValidationProblemDetails))]
//    public async Task<ActionResult<Repository>> EditRepository([FromBody] Repository repo)
//    {
//        var response = await _mediator.Send(new EditRepositoryRequest(repo));
//        if (response.repo == null)
//        {
//            return BadRequest("Репозиторий не отредактирован!");
//        }
//        return Ok("Репозиторий отредактирован!");
//    }



//    //TODO Оптимизировать

//    [Authorize]
//    [HttpDelete]
//    [ProducesResponseType(StatusCodes.Status200OK)]
//    [ProducesResponseType(StatusCodes.Status400BadRequest)]
//    [SwaggerOperation(Summary = "Удаление репозитория.")]
//    [SwaggerResponse(StatusCodes.Status200OK, "Repo deleted success")]
//    [SwaggerResponse(StatusCodes.Status400BadRequest, "Repo not deleted", typeof(ValidationProblemDetails))]
//    public async Task<ActionResult<bool>> DeleteRepository([FromBody] Repository repo)
//    {
//        var response = await _mediator.Send(new DeleteRepositoryRequest(repo));
//        if (response.Result == false)
//        {
//            return BadRequest("Репозиторий не удален!");
//        }
//        return Ok("Репозиторий удален!");
//    }
//}
