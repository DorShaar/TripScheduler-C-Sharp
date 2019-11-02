using System.Collections.Generic;

namespace TripScheduler.Interfaces
{
     public interface ISchedule
     {
          int ID { get; }
          IEnumerable<IEvent> EventsList { get; }
     }
}