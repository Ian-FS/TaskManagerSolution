using TaskManager.communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetById;
public class GetByIdUseCase {
    public static ResponseGetTaskJson Execute(int id) {
        return new ResponseGetTaskJson() {
            Id = id,
            Name = "teste",
            Description = "teste",
            Priority = communication.Enum.Priority.medium,
            Deadline = DateTime.UtcNow.AddDays(1),
            Status = communication.Enum.Status.processing,
            
        };
    }
}
