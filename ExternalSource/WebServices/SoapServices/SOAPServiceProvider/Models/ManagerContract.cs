using System.Runtime.Serialization;

namespace SOAPServiceProvider.Models;

[DataContract]
public class ManagerContract
{
    [DataMember]
    public long Id { get; set; }
    [DataMember]
    public Guid Key { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string Password { get; set; }
    [DataMember]
    public string Phone { get; set; }
    [DataMember]
    public bool IsAccess { get; set; }

}