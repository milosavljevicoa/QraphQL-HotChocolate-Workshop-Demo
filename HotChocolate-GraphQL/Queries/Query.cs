using System.Linq;
using HotChocolate;
using HotChocolate_GraphQL.Data;

namespace HotChocolate_GraphQL.Queries
{
    public class Query
    {
        public IQueryable<Entities.Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
            context.Speakers;
    }
}
