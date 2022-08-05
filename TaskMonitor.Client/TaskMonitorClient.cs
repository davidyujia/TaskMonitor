using Grpc.Net.Client;
using Grpc.TaskMonitor;

namespace TaskMonitor.Client;

public class TaskMonitor : IDisposable
{
    private GrpcChannel _channel;
    private MonitorService.MonitorServiceClient _client;
    private readonly ClientConfig _config;

    public TaskMonitor(ClientConfig config)
    {
        _config = config;
        _channel = GrpcChannel.ForAddress(config.HostUri);
        _client = new MonitorService.MonitorServiceClient(_channel);

        _client.SendProcessStart(new MonitorRequest
        {

        });
    }

    public void Fail(Exception e, string message, params string[] args)
    {
    }

    public void Dispose()
    {
        _client.SendProcessEnd(new MonitorRequest
        {

        });
    }
}


public class ClientConfig
{
    public string HostUri { get; internal set; }
}