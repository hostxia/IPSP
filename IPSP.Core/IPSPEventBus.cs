using Abp.Events.Bus;
using Abp.Events.Bus.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPSP
{
    public static class IPSPlusEventBus
    {
        public static EventBus Instance { get; }
    }

    public class CustomEventData : EventData
    {
        public object Data { get; set; }
    }

    public class CustomEventHandler : IEventHandler<CustomEventData>, IEventHandler
    {
        public void HandleEvent(CustomEventData eventData)
        {

        }
    }

}
