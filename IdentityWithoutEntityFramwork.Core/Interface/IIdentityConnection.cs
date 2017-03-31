using System.Configuration;

namespace IdentityWithoutEntityFramwork.Core.Interface
{
   public interface IIdentityConnection
    {
        ConnectionStringSettings Connection { get; set; } 
    }
}
