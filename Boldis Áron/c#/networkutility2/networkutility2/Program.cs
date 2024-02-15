﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using NetworkUtility.Ping;


namespace networkutility2
{
    public class NetworkServiceTests
    {

        private readonly NetworkServive _pingService;
        public NetworkServiceTests()
        {
            //SUT
            _pingService = new NetworkService();
        }
        
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            var _pingService = new NetworkService();
            var result = _pingService.PingTimeout();
            result.Should().Be("Success: Ping sent!");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_ReceivePing_ReturnInt(int a, int b, int expected)
        {
            var _pingService = new NetworkService();
            var result = _pingService.PingTimeout(a, b);
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}