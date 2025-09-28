using ShopCore.Domain.Enum;

namespace ShopCore.Domain.Models;

public class Report : Entity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public ReportType ReportType { get; private set; }
    public Guid TargetId { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public Guid UserId { get; private set; }

    public User User { get; private set; }
}
