using TaskManager.communication.Responses;

namespace TaskManager.Application.UseCases.Task.GetAll;
public class GetAllUseCase {
    public static ResponseAllGetTasksJson Execute() {
        return new ResponseAllGetTasksJson() {
            Tasks = [
                new(){
                    Id = 1,
                    Name = "Test",
                    Description = "Test",
                    Priority = communication.Enum.Priority.high,
                    Deadline = DateTime.UtcNow.AddDays(1),
                    Status = communication.Enum.Status.pending,
                },
                new(){
                    Id = 2,
                    Name = "Test2",
                    Description = "Test2",
                    Priority = communication.Enum.Priority.high,
                    Deadline = DateTime.UtcNow.AddDays(1),
                    Status = communication.Enum.Status.pending,
                },
                new(){
                    Id = 3,
                    Name = "Test3",
                    Description = "Test3",
                    Priority = communication.Enum.Priority.high,
                    Deadline = DateTime.UtcNow.AddDays(1),
                    Status = communication.Enum.Status.pending,
                },
            ]
        };
    }
}
