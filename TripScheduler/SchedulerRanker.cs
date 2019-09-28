using System;
using System.Threading.Tasks;
using TripScheduler.Interfaces;

namespace TripScheduler
{
     internal class SchedulerRanker : IScheduleRanker
     {
          public double RankSchedule(ISchedule schedule, Func<ISchedule, Task<double>> rankAlgorithm)
          {
               return rankAlgorithm(schedule).Result;
          }
     }
}