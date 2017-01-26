using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.Common.Model
{
    [DataContract(Namespace = "")]
    public abstract class Account : HasValidationErrors
    {
        [DataMember(Name = "AccountID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}