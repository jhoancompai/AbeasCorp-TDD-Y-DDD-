using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Final___AbeasCorp
{
    public class RequestSchedulerTest
    {
        public int GetMaxGain(List<Request> requests)
        {
            int n = requests.Count;
            if (n == 0) return 0;

            int[] dp = new int[n];
            dp[0] = requests[0].Price;

            for (int i = 1; i < n; i++)
            {
                int profit = requests[i].Price;
                for(int j = i -1 ; j >= 0; j--)
                {
                    if (requests[j].EndTime <= requests[i].StartTime)
                    {
                        profit += dp[j];
                        break;
                    }
                }

                dp[i] = Math.Max(profit, dp[i - 1]);


            }
            
            return dp[n - 1];

        }
    }
}

