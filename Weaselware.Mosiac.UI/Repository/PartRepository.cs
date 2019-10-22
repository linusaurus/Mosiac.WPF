using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Weaselware.Mosiac.DataAccess;
using Weaselware.Mosiac.Model;

namespace Weaselware.Mosiac.UI
{
    public class PartRepository : IPartRepository
    {
        private MosiacContext _context;

        public PartRepository(MosiacContext context)
        { _context = context;}

        public async Task<Part> GetByIdAsync(int partID)
        {return await _context.Part.SingleAsync(f => f.PartID == partID);}

        public bool HasChanges()
        {return _context.ChangeTracker.HasChanges();}

        public async Task SaveAsync()
        {await _context.SaveChangesAsync(); }

    }
}
