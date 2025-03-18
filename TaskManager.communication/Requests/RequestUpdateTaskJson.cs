using TaskManager.communication.Enum;

namespace TaskManager.communication.Requests;
public class RequestUpdateTaskJson {
    public string? Name { get; set; }
    public string? Description { get; set; }
    public Priority? Priority { get; set; }
    public int? DeadlineInDays { get; set; }
}
