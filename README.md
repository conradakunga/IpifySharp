# IpifySharp
A .net client that allows a client to retrieve an IPAddress from the site ipify.org

##Usage

```cs
using System;

using Ipify;

class Program
{
    static void main(string[] args)
	{
		Console.WriteLine(Ipify.GetPublicAddress());
	}
}
```
