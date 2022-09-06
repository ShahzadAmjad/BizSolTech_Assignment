namespace BizSolTech_Assignment.Models
{
    public class SQLDeveloperRepository : IDeveloperRepository
    {
        private readonly AppDbContext Context;
        public SQLDeveloperRepository(AppDbContext context)
        {
            Context = context;
        }
        public Developer AddDeveloper(Developer developer)
        {
            Context.developers.Add(developer);
            Context.SaveChanges();
            return developer;
        }

        public IEnumerable<Developer> GetAllDevelopers()
        {
            return Context.developers;
        }
    }
}
