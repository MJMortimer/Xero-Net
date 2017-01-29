using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class TaxLine : HasValidationErrors
    {
        [DataMember(Name = "PayslipTaxLineID")]
        public Guid PayslipTaxLineId { get; set; }
        
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public string LiabilityAccount { get; set; }
    }
}