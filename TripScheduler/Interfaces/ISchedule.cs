using System.Collections.Generic;

namespace TripScheduler.Interfaces
{
     internal interface ISchedule
     {
          int ID { get; }
          IEnumerable<IEvent> Events { get; }
     }
}