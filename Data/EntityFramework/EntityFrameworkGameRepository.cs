using WebApplication4.Data;
using WebApplication4.Model;


namespace WebApplication4.EntityFramework
{
    public class EntityFrameworkGameRepository : EntityFrameworkRepository<Game, WebApplication4Context>
    {
        public EntityFrameworkGameRepository(WebApplication4Context context) : base(context)
        {

        }
        //// Repository can introduce more methods to the game repository here
    }



}




