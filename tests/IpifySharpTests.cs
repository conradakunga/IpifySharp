using System;
using System.Net;
using FluentAssertions;
using IpifySharp;
using Xunit;

namespace tests
{
    public class IpifySharpTests
    {
        [Fact]
        public void CanGetIPAddressAsString()
        {
            var address = Ipify.GetPublicAddress();
            address.Should().NotBeNull();
            IPAddress ip;
            IPAddress.TryParse(address, out ip).Should().BeTrue();
        }

        [Fact]
        public void CanGetIPAddress()
        {
            var address = Ipify.GetPublicIPAddress();
            address.Should().BeOfType(typeof(IPAddress));
        }
        [Fact]
        public void ReturnedIPAddressIsValid()
        {
            var address = Ipify.GetPublicIPAddress();
            address.Should().NotBe(IPAddress.None);
        }
    }
}
