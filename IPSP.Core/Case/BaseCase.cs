using Abp.Domain.Entities;
using IPSP.Contact.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Case
{
    [Table("TCase_Base")]
    public class BaseCase : Entity
    {
        [Column("n_CaseID")]
        public override int Id { get; set; }

        public int n_ClientID { get; set; }

        public virtual string s_CaseName { get; set; }

        public virtual string s_CaseSerial { get; set; }

        [ForeignKey("n_ClientID")]
        public virtual Client TheClient { get; set; }

    }
}
