using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityWithoutEntityFramwork.Service.Interface
{
   public interface IAudit
    {
        Guid CreateBy { get; set; }
        DateTime CreateDate { get; set; }
        Guid ModifyBy { get; set; }
        DateTime ModifyDate { get; set; }
    }
}
