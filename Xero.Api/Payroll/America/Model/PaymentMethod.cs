using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.America.Model.Types;

namespace Xero.Api.Payroll.America.Model
{
    [DataContract(Namespace = "")]
    public class PaymentMethod : HasValidationErrors
    {
        [DataMember]
        public PaymentMethodType PaymentMethodType { get; set; }

        [DataMember]
        public List<BankAccount> BankAccounts { get; set; }
    }
}