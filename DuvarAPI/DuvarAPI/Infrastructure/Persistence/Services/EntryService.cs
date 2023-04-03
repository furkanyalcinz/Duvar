using Application.Repositories.EntryRepository;
using Application.ViewModels.EntryViewModels;
using Domain.Common.ReturnTypes;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class EntryService : IEntryService
    {
        private readonly IEntryWriteRepository _entryWriteRepository;
        private readonly IEntryReadRepository _entryReadRepository;

        public EntryService(IEntryWriteRepository entryWriteRepository, IEntryReadRepository entryReadRepository)
        {
            _entryWriteRepository = entryWriteRepository;
            _entryReadRepository = entryReadRepository;
        }

        public async Task<Result> AddEntry(Entry newEntry)
        {
            
            await _entryWriteRepository.AddAsync(newEntry);
            await _entryWriteRepository.SaveAsync();
            return new SuccessResult();
        }

        public Task<IDataResult<List<Get_Entry_View_Model>>> GetEntries()
        {
            var entries = _entryReadRepository.GetAll().Include(e=> e.User);

            List<Get_Entry_View_Model> list = new List<Get_Entry_View_Model>();
            foreach (var entry in entries)
            {
                Get_Entry_View_Model get_Entry_View_Model = new Get_Entry_View_Model();
                get_Entry_View_Model.Title = entry.Title;
                get_Entry_View_Model.CreatedDate = entry.CreatedDate;
                get_Entry_View_Model.EntryId = entry.ID;
                get_Entry_View_Model.Username = entry.User.Name;
                get_Entry_View_Model.Vote = entry.Vote;
                get_Entry_View_Model.Description = entry.Description;
                list.Add(get_Entry_View_Model);
            }
            return Task.FromResult<IDataResult<List<Get_Entry_View_Model>>>(new SuccessDataResult<List<Get_Entry_View_Model>>(list));
        }
    }
}
