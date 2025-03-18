using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.Task.Create;
using TaskManager.Application.UseCases.Task.Delete;
using TaskManager.Application.UseCases.Task.GetAll;
using TaskManager.Application.UseCases.Task.GetById;
using TaskManager.Application.UseCases.Task.Update;
using TaskManager.communication.Requests;
using TaskManager.communication.Responses;

namespace TaskManagerAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase {

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllGetTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetAllTasks() {
        var response = GetAllUseCase.Execute();
        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseGetTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetTask([FromRoute] int id) {
         var response = GetByIdUseCase.Execute(id);

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CreateTask([FromBody] RequestCreateTaskJson request) {
        var response = CreateUseCase.Execute(request);
        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult UpdateTask([FromRoute]int id, [FromBody]RequestUpdateTaskJson request) { 
        UpdateUseCase.Execute(id, request);
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult DeleteTask([FromRoute] int id) { 
        DeleteUseCase.Execute(id);
        return NoContent();
    }
}
