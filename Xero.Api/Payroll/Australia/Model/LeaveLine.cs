using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.Australia.Model.Types;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class LeaveLine : HasValidationErrors
    {
        [DataMember(Name = "LeaveTypeID")]
        public Guid LeaveTypeId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal NumberOfUnits { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal AnnualNumberOfUnits { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public LeaveCalculationType CalculationType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal FullTimeNumberOfUnitsPerPeriod { get; set; }
    }
}