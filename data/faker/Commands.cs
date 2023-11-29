using CommandLine;

public class Options
{
    [Option('n', Required = true, HelpText = "Number of addresses to generate")]
    public int NumberOfAddresses { get; set; }

    [Option('c', Required = false, HelpText = "Host (FQDN)", Default = "localhost")]
    public string? Host { get; set; }
    [Option('p', Required = false, HelpText = "Port number", Default = 6379)]
    public int Port { get; set; }

    [Option('s', Required = false, HelpText = "Complete connectionstring for cases where host + port is not enough - overrides host + port")]
    public string? ConnectionString { get; set; }
}