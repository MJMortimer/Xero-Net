using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class LeaveEarningsLine : HasValidationErrors
    {
        [DataMember(Name = "EarningsRateId", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public decimal RatePerUnit { get; set; }

        [DataMember]
        public decimal NumberOfUnits { get; set; }
    }
}