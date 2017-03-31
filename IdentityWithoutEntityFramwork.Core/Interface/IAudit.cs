using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityWithoutEntityFramwork.Core.Interface
{
   public interface IAudit
    {
        Guid CreateBy { get; set; }
        DateTime CreateDate { get; set; }
        Guid ModifyBy { get; set; }
        DateTime ModifyDate { get; set; }
    }
}
