using System.Configuration;

namespace IdentityWithoutEntityFramwork.Service.Interface
{
   public interface IIdentityConnection
    {
        ConnectionStringSettings Connection { get; set; } 
    }
}
