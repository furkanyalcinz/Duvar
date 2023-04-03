using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class AddEntryDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public uint Vote { get; set; }
    }
}
