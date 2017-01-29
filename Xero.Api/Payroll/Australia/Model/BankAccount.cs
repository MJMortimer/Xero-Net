using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.Australia.Model
{
    [DataContract(Namespace = "")]
    public class BankAccount: HasValidationErrors
    {
        [DataMember]
        public string StatementText { get; set; }

        [DataMember]
        public string AccountName { get; set; }

        [DataMember(Name = "BSB")]
        public string BankStateBranch { get; set; }

        [DataMember]
        public string AccountNumber { get; set; }

        [DataMember]
        public bool Remainder { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }
    } 
}