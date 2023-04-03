using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.EntryViewModels
{
    public class Get_Entry_View_Model
    {
        public  int EntryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public uint Vote { get; set; }
        public string Username { get; set; }
    }
}
