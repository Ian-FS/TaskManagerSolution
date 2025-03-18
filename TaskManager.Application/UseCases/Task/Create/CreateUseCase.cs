using TaskManager.communication.Requests;
using TaskManager.communication.Responses;

namespace TaskManager.Application.UseCases.Task.Create;
public class CreateUseCase {
    public static ResponseGetTaskJson Execute(RequestCreateTaskJson request) {
        return new ResponseGetTaskJson() {
            Id = 1,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            Deadline = DateTime.UtcNow.AddDays(request.DeadlineInDays),
            Status = communication.Enum.Status.pending,
        };
    }
}
