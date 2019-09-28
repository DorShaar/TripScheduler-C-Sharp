using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
     /// <summary>
     /// The lowest score, the best rank.
     /// </summary>
     internal class RankingStrategyBuilder
     {
          public double EmptyOneHourSlotBadPoints { get; set; } = 1;
          public double DayWithEventsBadPoints { get; set; } = 5;

          public Func<ISchedule, Task<double>> BuildStrategy()
          {
               return RankSchedule;
          }

          private Task<double> RankSchedule(ISchedule schedule)
          {
               double timeRankPoint = CalculateRankByTime(
                    schedule.Events.Select(e => e.EventTime.ActualStartingTime)).Result;
               timeRankPoint += CalculateRankByLocation(schedule.Events).Result;
               return Task.FromResult(timeRankPoint);
          }

          private Task<double> CalculateRankByTime(IEnumerable<DateTime> dateTimes)
          {
               double rank = 0;

               IOrderedEnumerable<DateTime> events = dateTimes.OrderBy(e => e.TimeOfDay);
               IEnumerator<DateTime> enumerator = events.GetEnumerator();
               DateTime currentEvent = enumerator.Current;
               while (enumerator.MoveNext())
               {
                    DateTime nextEvent = enumerator.Current;

                    // current event and next event has are same day.
                    if (currentEvent.Date.Equals(nextEvent.Date))
                    {
                         rank += (currentEvent.TimeOfDay - currentEvent.TimeOfDay).Hours * 
                              EmptyOneHourSlotBadPoints;
                    }
                    else
                    {
                         rank += DayWithEventsBadPoints;
                    }

                    currentEvent = nextEvent;
               }

               return Task.FromResult(rank);
          }

          private Task<double> CalculateRankByLocation(IEnumerable<IEvent> _)
          {
               return Task.FromResult(0d);
          }
     }
}