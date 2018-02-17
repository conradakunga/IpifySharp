using System;
using System.Net;
using System.Net.Http;

namespace IpifySharp
{
    /// <summary>
    /// Ipify class that resolves a client's IPAddress from the ipify.org service
    /// </summary>
    public sealed class Ipify
    {
        /// <summary>
        /// Gets the public IP Address as an IPAddress object
        /// </summary>
        /// <returns> An instance of <see cref="IPAddress" />, or
        /// <see cref="IPAddress.None" /> if there is an error.</returns>
        public static IPAddress GetPublicIPAddress()
        {
            var address = GetPublicAddress();
            IPAddress ipAddress;
            if (IPAddress.TryParse(address, out ipAddress))
            {
                return ipAddress;
            }
            else
            {
                return IPAddress.None;
            }
        }
        /// <summary>
        /// Gets the public address as a string
        /// </summary>
        /// <returns>The public address.</returns>
        public static string GetPublicAddress()
        {
            var client = new HttpClient();
            var ip = client.GetStringAsync("https://api.ipify.org");
            return ip.Result;
        }

    }
}
