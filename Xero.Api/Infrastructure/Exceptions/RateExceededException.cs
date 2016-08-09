using System;
using System.Net;

namespace Xero.Api.Infrastructure.Exceptions
{
    [Serializable]
    public class RateExceededException
        : XeroApiException
    {
        public string ExceededRateLimitType { get; set; }

        public RateExceededException() { }

        public RateExceededException(string message) : base(HttpStatusCode.ServiceUnavailable, message)
        {
            ExceededRateLimitType = "Unknown";
        }

        public RateExceededException(string message, string exceededRateLimitType)
            : base(HttpStatusCode.ServiceUnavailable, message)
        {
            ExceededRateLimitType = exceededRateLimitType;
        }
    }
}