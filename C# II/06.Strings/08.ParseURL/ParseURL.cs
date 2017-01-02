using System;
    class ParseURL
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int colonIndex = input.IndexOf(':');
            int thirdSlashIndex = input.IndexOf('/', colonIndex + 3);
            int serverLength = thirdSlashIndex - colonIndex - 3;
            string protocol = input.Substring(0, colonIndex);
            string server = input.Substring(colonIndex + 3, serverLength);
            string resource = input.Substring(thirdSlashIndex, input.Length - server.Length - protocol.Length - 3);
            Console.WriteLine("[protocol] = {0}",protocol);
            Console.WriteLine("[server] = {0}",server);
            Console.WriteLine("[resource] = {0}"
            ,resource);
            
            
;        }
    }
