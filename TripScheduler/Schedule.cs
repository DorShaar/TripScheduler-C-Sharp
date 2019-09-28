using System.Collections.Generic;
using TripScheduler.Interfaces;

namespace TripScheduler
{
     internal class Schedule : ISchedule
     {
          public int ID { get; }
          public IEnumerable<IEvent> Events { get; }

          internal Schedule(int id, IEnumerable<IEvent> events)
          {
               ID = id;
               Events = events;
          }
     }
}