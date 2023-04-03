using Application.ViewModels.EntryViewModels;
using Domain.Common.ReturnTypes;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public interface IEntryService
    {
        public Task<Result> AddEntry(Entry newEntry);
        public Task<IDataResult<List<Get_Entry_View_Model>>> GetEntries();
    }
}
