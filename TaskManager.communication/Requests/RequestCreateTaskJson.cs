using TaskManager.communication.Enum;

namespace TaskManager.communication.Requests;
public class RequestCreateTaskJson {
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public int DeadlineInDays { get; set; } = 0;
}
