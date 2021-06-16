using System.Runtime.Serialization;
using Keyfactor.HydrantId.Interfaces;

namespace Keyfactor.HydrantId.Client.Models
{
    [DataContract]
    public class HawkCredentialComment : IHawkCredentialComment
    {
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; }

    }
}