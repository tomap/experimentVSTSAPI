using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Middleware.SharedTools;

namespace VSTSClient
{
    public class ConvertWorkItemId
    {
        private WorkItemTrackingHttpClient _workItemClient;

        public ConvertWorkItemId(string token)
        {
            _workItemClient = Client.GetClient<WorkItemTrackingHttpClient>(token);
        }
        

    }
}
