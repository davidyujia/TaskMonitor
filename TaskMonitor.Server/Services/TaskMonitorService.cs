using System;
using Grpc.Core;
using Grpc.TaskMonitor;

namespace TaskMonitor.Server.Services
{
    public class TaskMonitorService : Grpc.TaskMonitor.MonitorService.MonitorServiceBase
    {
        public override Task<MonitorModel> SendProcessStart(MonitorRequest request, ServerCallContext context)
        {
            return base.SendProcessStart(request, context);
        }

        public override Task<MonitorModel> SendProcessEnd(MonitorRequest request, ServerCallContext context)
        {
            return base.SendProcessEnd(request, context);
        }
    }
}