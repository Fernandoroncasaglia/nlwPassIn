using System.ComponentModel.DataAnnotations.Schema;

namespace PassIn.Infrastructure.Entities;

public class CheckIn
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Created_at { get; set; }
    public Guid Attendee_id { get; set; }

    //Essa cópdigo abaixo é nescessário pelo fato do banco de dados estar errado, a relação de participantes e checkin era pra ser feita 1 pra 1 e esta 1 pra n
    [ForeignKey("Attendee_Id")]
    public Attendee Attendee { get; set; } = default!;
}