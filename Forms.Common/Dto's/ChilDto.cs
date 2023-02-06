using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Common.Dto_s
{
    public class ChilDto
    {
        public int ChildId { get; set; }

        public string ChildName { get; set; } = null!;

        public DateTime ChildDateBorn { get; set; }

        public string ChildTz { get; set; } = null!;
        [ForeignKey("UserId")]

        public int ParentId { get; set; }
    }
}
