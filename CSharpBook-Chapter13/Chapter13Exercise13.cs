using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Exercise13
{
    public static void URL(String input)
    {
    
        int protocolIndex = input.IndexOf(':');
        string protocol = input.Substring(0, protocolIndex);
        int serverIndex = input.IndexOf('/', protocolIndex + 3);
        string server = input.Substring(protocolIndex + 3, serverIndex - protocolIndex - 3);
        string resource = input.Substring(serverIndex + 1);

        Console.WriteLine("[protocol]=\"{0}\"", protocol);
        Console.WriteLine("[server]=\"{0}\"", server);
        Console.WriteLine("[resource]=\"{0}\"", resource);
    }
}