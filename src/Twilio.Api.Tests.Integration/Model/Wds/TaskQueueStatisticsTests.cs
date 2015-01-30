﻿using System;
using System.IO;
using NUnit.Framework;
using RestSharp;
using RestSharp.Deserializers;
using Twilio.TaskRouter;

namespace Twilio.Api.Tests.Integration.Model
{
    [TestFixture]
    public class TaskQueueStatisticsTests
    {
        [Test]
        public void testDeserializeInstanceResponse()
        {
            var doc = File.ReadAllText(Path.Combine("Resources/Wds", "task_queue_statistics.json"));
            var json = new JsonDeserializer();
            var output = json.Deserialize<TaskQueueStatistics>(new RestResponse { Content = doc });

            Assert.NotNull(output);
        }

        [Test]
        public void testDeserializeListResponse()
        {
            var doc = File.ReadAllText(Path.Combine("Resources/Wds", "task_queues_statistics.json"));
            var json = new JsonDeserializer();
            var output = json.Deserialize<TaskQueueStatisticsResult>(new RestResponse { Content = doc });

            Assert.NotNull(output);
        }
    }
}

