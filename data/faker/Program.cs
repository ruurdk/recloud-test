using CommandLine;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Address data faker");
        
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                Console.WriteLine("Generating {0} addresses", options.NumberOfAddresses);
                var a = new AddressFaker().Generate(options.NumberOfAddresses);
                
                Console.WriteLine("Connecting to Redis instance at {0}:{1}", options.Host, options.Port);


            }
            );   
    }
}