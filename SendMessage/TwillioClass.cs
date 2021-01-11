using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SendMessage
{
    public class TwillioClass
    {
        public static void SendMessage(string phoneNumber, string code)
        {
            string accountSid = "AC6c82d03b79d8909634380cb011b9c6cd";
            string authToken = "de8eccf0a191bca39dc93b359365481c";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: $"Ваш код для регистрации: {code}",
                from: new Twilio.Types.PhoneNumber("+12059472605"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );
        }
    }
}
