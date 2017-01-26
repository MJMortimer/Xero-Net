﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class OpeningBalances : HasValidationErrors
    {
        [DataMember]
        public List<BenefitLine> BenefitLines { get; set; }

        [DataMember]
        public List<DeductionLine> DeductionLines { get; set; }

        [DataMember]
        public List<EarningsLine> EarningsLines { get; set; }

        [DataMember]
        public List<ReimbursementLine> ReimbursementLines { get; set; }        
    }
}