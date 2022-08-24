using Erantissen_Backend.Data.Contexts;
using Erantissen_Backend.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erantissen_Backend.Data.Repositories
{
    public class CheckoutRepository : ICheckoutRepository
    {
        private readonly Context _context;
        public CheckoutRepository(Context context)
        {
            _context = context;
        }
        public async Task UpdateProduct(string title)
        {
            var product = await _context.Products.FindAsync(title);

            if (product is null)
                return;

            product.Quantity--;
            product.BoughtNoOfTimes++;

            await _context.SaveChangesAsync();
        }
    }
}
