namespace BizSolTech_Assignment.Models
{
    public interface IDeveloperRepository
    {
        Developer AddDeveloper(Developer developer);
        //Developer AddMultipleDevelopers(IEnumerable<Developer> developersList);
        IEnumerable<Developer> GetAllDevelopers();
    }
}
