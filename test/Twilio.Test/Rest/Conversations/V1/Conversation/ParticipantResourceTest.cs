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
using Twilio.Rest.Conversations.V1.Conversation;

namespace Twilio.Tests.Rest.Conversations.V1.Conversation
{

    [TestFixture]
    public class ParticipantTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Conversations,
                "/v1/Conversations/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants",
                ""
            );
            request.AddHeaderParam("X-Twilio-Webhook-Enabled", Serialize(ParticipantResource.WebhookEnabledTypeEnum.True));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateSmsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": null,\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": {\"type\": \"sms\",\"address\": \"+15558675310\",\"proxy_address\": \"+15017122661\"},\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-12-16T22:18:37Z\",\"date_updated\": \"2015-12-16T22:18:38Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateChatResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"IDENTITY\",\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": null,\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-12-16T22:18:37Z\",\"date_updated\": \"2015-12-16T22:18:38Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateGmmsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"IDENTITY\",\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": {\"type\": \"sms\",\"projected_address\": \"+15017122661\"},\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-12-16T22:18:37Z\",\"date_updated\": \"2015-12-16T22:18:38Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateGmmsChatNoAttributesResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"IDENTITY\",\"attributes\": \"{}\",\"messaging_binding\": {\"type\": \"sms\",\"projected_address\": \"+15017122661\"},\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2020-07-01T22:18:37Z\",\"date_updated\": \"2020-07-01T22:18:37Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateGmmsSmsNoAttributesResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": null,\"attributes\": \"{}\",\"messaging_binding\": {\"type\": \"sms\",\"address\": \"+15017122661\"},\"role_sid\": null,\"date_created\": \"2020-07-01T22:18:37Z\",\"date_updated\": \"2020-07-01T22:18:37Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Create("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Conversations,
                "/v1/Conversations/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            request.AddHeaderParam("X-Twilio-Webhook-Enabled", Serialize(ParticipantResource.WebhookEnabledTypeEnum.True));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Update("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": null,\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": {\"type\": \"sms\",\"address\": \"+15558675310\",\"proxy_address\": \"+15017122661\"},\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-12-16T22:18:37Z\",\"date_updated\": \"2015-12-16T22:18:38Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Update("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateGmmsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"id\",\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": {\"type\": \"sms\",\"projected_address\": \"+15017122661\"},\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-12-16T22:18:37Z\",\"date_updated\": \"2015-12-16T22:18:38Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Update("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Conversations,
                "/v1/Conversations/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            request.AddHeaderParam("X-Twilio-Webhook-Enabled", Serialize(ParticipantResource.WebhookEnabledTypeEnum.True));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Delete("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = ParticipantResource.Delete("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", xTwilioWebhookEnabled: Serialize(ParticipantResource.WebhookEnabledTypeEnum.True), client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Conversations,
                "/v1/Conversations/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Fetch("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": null,\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": {\"type\": \"sms\",\"address\": \"+15558675310\",\"proxy_address\": \"+15017122661\"},\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-03-24T21:05:50Z\",\"date_updated\": \"2016-03-24T21:05:50Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}"
                                     ));

            var response = ParticipantResource.Fetch("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "MBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Conversations,
                "/v1/Conversations/CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                ParticipantResource.Read("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"participants\"},\"participants\": [{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": null,\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": {\"type\": \"sms\",\"address\": \"+15558675310\",\"proxy_address\": \"+15017122661\"},\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-03-24T21:05:50Z\",\"date_updated\": \"2016-03-24T21:05:50Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null},{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"conversation_sid\": \"CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sid\": \"MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"identity\": \"IDENTITY\",\"attributes\": \"{ \\\"role\\\": \\\"driver\\\" }\",\"messaging_binding\": null,\"role_sid\": \"RLaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2016-03-24T21:05:50Z\",\"date_updated\": \"2016-03-24T21:05:50Z\",\"url\": \"https://conversations.twilio.com/v1/Conversations/CHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants/MBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"last_read_message_index\": null,\"last_read_timestamp\": null}]}"
                                     ));

            var response = ParticipantResource.Read("CHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}