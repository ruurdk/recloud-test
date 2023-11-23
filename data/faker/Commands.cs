using CommandLine;

public class Options
{
    [Option('n', Required = true, HelpText = "Number of addresses to generate")]
    public int NumberOfAddresses { get; set; }

    [Option('h', Required = false, HelpText = "Host (FQDN)", Default = "localhost")]
    public string? Host { get; set; }
    [Option('p', Required = false, HelpText = "Port number", Default = 6379)]
    public int Port { get; set; }
}