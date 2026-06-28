using System.ComponentModel.DataAnnotations;

namespace triage.Dtos
{
   
    public record CreateTicketRequest(
        [Required, StringLength(200, MinimumLength = 1)] string Subject,
        [Required] string Priority,
        Guid? AssigneeId);

    public record UpdateTicketRequest(string? Status, string? Priority, Guid? AssigneeId);

    
    public record TicketResponse(
        Guid Id,
        string Subject,
        string Status,
        string Priority,
        string Requester,
        Guid? AssigneeId,
        string? Assignee,
        DateTime? DueAt,
        DateTime CreatedAt);

    public record TicketStatsResponse(int Open, int Pending, int Resolved, int Breaching);

    public record PagedResponse<T>(IReadOnlyList<T> Items, int Total, int Page, int PageSize, int TotalPages);

    public record TicketCountsResponse(int Mine, int Unassigned, int Open, int Breaching, int Resolved);
}