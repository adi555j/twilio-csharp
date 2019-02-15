/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Verify.V1.Service;

namespace Twilio.Tests.Rest.Verify.V1.Service 
{

    [TestFixture]
    public class VerificationCheckTest : TwilioTest 
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Verify,
                "/v1/Services/VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/VerificationCheck",
                ""
            );
            request.AddPostParam("Code", Serialize("code"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                VerificationCheckResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "code", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestVerificationChecksResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"VEaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"VAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"to\": \"+14159373912\",\"channel\": \"sms\",\"status\": \"approved\",\"valid\": false,\"amount\": \"$29.99\",\"payee\": \"Acme\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\"}"
                                     ));

            var response = VerificationCheckResource.Create("VAXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "code", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}