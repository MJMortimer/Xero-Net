using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Common
{
    [DataContract(Namespace = "")]
    public abstract class HasValidationErrors
    {
        [DataMember(EmitDefaultValue = false, Name = "ValidationErrors")]
        public List<ValidationError> Errors { get; set; }
    }
}