namespace PassIn.Communication.Responses;
public class ResponseAllAttendeesJson
{
    public int PageIndex { get; set; }
    public int TotalPages { get; set; }
    public List<ResponseAttendeeJson> Attendees { get; set; } = [];
    public bool HasPreviousPage => PageIndex > 1;
    public bool HasNextPage => PageIndex < TotalPages;
}
