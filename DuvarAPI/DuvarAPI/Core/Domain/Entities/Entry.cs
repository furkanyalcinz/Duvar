using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Entry:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public  int UserID { get; set; }
        public uint Vote { get; set; }
        public virtual User User { get; set; }

    }
}
