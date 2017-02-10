using Abp.Domain.Entities;
using IPSP.Case;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSP.Contact.Client
{
    [Table("TCstmr_Client")]
    public class Client : Entity
    {
        [Column("n_ClientID")]
        public override int Id { get; set; }

        public virtual string s_Name { get; set; }

        public virtual ICollection<BaseCase> BaseCases { get; set; }

        public Client()
        {

        }
    }
}
