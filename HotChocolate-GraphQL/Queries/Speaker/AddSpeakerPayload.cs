namespace HotChocolate_GraphQL.Queries.Speaker
{
    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Entities.Speaker speaker)
        {
            Speaker = speaker;
        }

        public Entities.Speaker Speaker { get; }
    }
}
