using Erantissen_Backend.Data.Contexts;

namespace Erantissen_Backend.Data.Repositories
{
    public class HeroRepository
    {
        private readonly Context _context;

        public HeroRepository(Context context)
        {
            _context = context;
        }
    }
}
