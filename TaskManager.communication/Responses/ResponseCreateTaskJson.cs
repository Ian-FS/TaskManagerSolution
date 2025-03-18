using TaskManager.communication.Enum;

namespace TaskManager.communication.Responses;
public class ResponseCreateTaskJson {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; } = Priority.low;
    public DateTime Deadline { get; set; }
    public Status Status { get; set; }
}
