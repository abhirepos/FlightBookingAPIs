using Microsoft.EntityFrameworkCore;

namespace FlightBookingAPIs.Data
{
    public class UserRepoContext:DbContext
    {
        public UserRepoContext(DbContextOptions<UserRepoContext> opt): base(opt)
        {
            
        } 
        public DbSet<UserRepo> users{get;set;}

        
    }
}