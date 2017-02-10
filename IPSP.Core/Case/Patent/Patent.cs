using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Case.Patent
{
    [Table("TPCase_Patent")]
    public class Patent : BaseCase
    {
        public virtual int n_PatentTypeID { get; set; }
    }

}

