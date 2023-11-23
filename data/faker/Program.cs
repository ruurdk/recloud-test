using CommandLine;
using Newtonsoft.Json;
using StackExchange.Redis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Address data faker");
        
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(options =>
            {
                Console.WriteLine("Connecting to Redis instance at {0}:{1}", options.Host, options.Port);
                try {
                    ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(string.Format("{0}:{1}", options.Host, options.Port));
                    
                    var addresses = new List<Address>();

                    for (int i = 0; i < options.NumberOfAddresses; i++) {
                        
                        if (i % 1000 == 0)
                        {
                            Console.WriteLine("Currently at {0}.", i);

                            // Generate more addresses (much faster in batch).
                            addresses = new AddressFaker().Generate(1000);                            
                        }
                        
                        var key = string.Format("address:{0}", i);
                        var a = addresses[i % 1000];

                        var db = redis.GetDatabase();
                        db.ExecuteAsync(
                            "JSON.SET", key, "$", JsonConvert.SerializeObject(a)
                        );                        
                    }
                } 
                catch (RedisConnectionException)
                {
                    Console.WriteLine("Unable to connect to Redis server");
                }
            }
            );   
    }
}