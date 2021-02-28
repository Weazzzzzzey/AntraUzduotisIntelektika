using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraUzduotisIntelektika
{
    public class Estimates
    {
        private List<DistanceData> DistanceData = new List<DistanceData>();


        public List<DistanceData> Kontroleris(List<DataClassKMI> originalData, int height, int weight)
        {
            
            List<DistanceData> SortedDistance = MaxMethod(originalData, height, weight);
            return NN(SortedDistance);
        
        }


        private List<DistanceData> NN(List<DistanceData> SortedDistance)
        {

            List<DistanceData> NormalData = new List<DistanceData>();

            foreach (var item in SortedDistance)
            {
                if (item.DistanceFirst < 10)
                {
                    NormalData.Add(new DistanceData(item.Name,item.Height,item.Weight,item.ClassKMI,item.KMI,item.Gender,item.DistanceFirst,item.DistanceSecond));
                }
            }

            return NormalData;

        }

        private List<DistanceData> MaxMethod(List<DataClassKMI> originalData, int height, int weight)
        {

            int distanceFirst = 0;
            int distanceSecond = 0;

            foreach (var item in originalData)
            {
                int heightDistance = height - item.Height;
                int weightDistance = weight - item.Weight;

                if (heightDistance < 0)
                {
                    heightDistance = heightDistance * -1;
                }

                if (weightDistance < 0)
                {
                    weightDistance = weightDistance * -1;
                }

                if (heightDistance > weightDistance)
                {
                    distanceFirst = heightDistance;
                    distanceSecond = weightDistance;

                }
                else
                {
                    distanceFirst = weightDistance;
                    distanceSecond = heightDistance;
                }

                DistanceData.Add(new DistanceData(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender, distanceFirst, distanceSecond));
            }

            List<DistanceData> SortedDistance = DistanceData.OrderBy(o => o.DistanceFirst).ToList();

            return SortedDistance;
        }

    }
}
