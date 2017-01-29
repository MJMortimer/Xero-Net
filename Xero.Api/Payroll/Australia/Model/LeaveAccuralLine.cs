using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class LeaveAccrualLine : HasValidationErrors
    {
        [DataMember]
        public Guid LeaveTypeID { get; set; }

        [DataMember]
        public decimal NumberOfUnits { get; set; }

        [DataMember]
        public bool AutoCalculate { get; set; }
    }
}