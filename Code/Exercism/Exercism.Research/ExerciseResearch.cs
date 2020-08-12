using System.Collections.Generic;
using System.Linq;

namespace Exercism
{
    public static class Store
    {
        private enum QueueType
        {
            Queue1,
            Queue2,
            Queue3,
        }

        private static readonly Dictionary<QueueType, int> _waitTime = new Dictionary<QueueType, int>
        {
            [QueueType.Queue1] = 45,
            [QueueType.Queue2] = 30,
            [QueueType.Queue3] = 12,
        };

        public static int QueueWithMinimalWaitingTime(int customersInQueue1, int customersInQueue2, int customersInQueue3)
        {
            var waitTimeQueue1 = GetWaitTime(QueueType.Queue1, customersInQueue1);
            var waitTimeQueue2 = GetWaitTime(QueueType.Queue2, customersInQueue2);
            var waitTimeQueue3 = GetWaitTime(QueueType.Queue3, customersInQueue3);

            var waitTimes = new List<int>()
            {
                waitTimeQueue1,
                waitTimeQueue2,
                waitTimeQueue3,
            };

            int minWaitTime = waitTimes.Min();

            if (minWaitTime == waitTimeQueue1)
            {
                return 1;
            }
            else if (minWaitTime == waitTimeQueue2)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private static int GetWaitTime(QueueType queueType, int customersInQueue)
        {
            return _waitTime[queueType] * customersInQueue;
        }
    }
}
