namespace HotChocolate_GraphQL.Queries.Speaker
{
    public record AddSpeakerInput(
        string Name,
        string Bio,
        string WebSite
    );
}
