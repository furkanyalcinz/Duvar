using Application.DTO;
using AutoMapper;
using Domain.Common.ReturnTypes;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persistence.Services;

namespace DuvarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        private readonly IEntryService _entryService;
        private readonly IMapper _mapper;

        public EntryController(IEntryService entryService, IMapper mapper)
        {
            _entryService = entryService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddEntryDTO newEntry) 
        {
            var entry = _mapper.Map<Entry>(newEntry);
            await _entryService.AddEntry(entry);
            return Ok(new SuccessResult());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEntries()
        {
            var entries = _entryService.GetEntries();
            return Ok(entries);
        }
    }
}
