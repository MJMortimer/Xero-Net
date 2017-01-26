using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class ReimbursementLine : HasValidationErrors
    {
        [DataMember(Name = "ReimbursementTypeID")]
        public Guid ReimbursementTypeId { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal Amount { get; set; }
    }    
}