using System.Threading.Tasks;
using HotChocolate;
using HotChocolate_GraphQL.Data;
using HotChocolate_GraphQL.Queries.Speaker;

namespace HotChocolate_GraphQL.Queries
{
    public class Mutation
    {
        public async Task<AddSpeakerPayload> AddSpeakerAsync(
            AddSpeakerInput input,
            [Service] ApplicationDbContext context
        )
        {
            var speaker = new Entities.Speaker
            {
                Name = input.Name,
                Bio = input.Bio,
                WebSite = input.WebSite
            };

            context.Speakers.Add(speaker);
            await context.SaveChangesAsync();

            return new AddSpeakerPayload(speaker);
        }
    }
}
