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


        public List<DistanceData> Kontroleris(List<DataClassKMI> originalData, int height,int weight ,float KMI, int Comination)
        {
            DistanceData.Clear();

            if (Comination == 0)
            {
                List<DistanceData> SortedDistance = MaxMethodHeightWeight(originalData, height, weight);
                return NN(SortedDistance);
            }
            else if (Comination == 1)
            {
                List<DistanceData> SortedDistance = MaxMethodHeightKMI(originalData, height, KMI);
                return NN(SortedDistance);
            }
            else if (Comination == 2)
            {
                List<DistanceData> SortedDistance = MaxMethodWeightKMI(originalData, weight, KMI);
                return NN(SortedDistance);
            }
            else if (Comination == 3)
            {
                List<DistanceData> SortedDistance = MaxMethodAll(originalData, height, weight, KMI);
                return NN(SortedDistance); ;
            }

            return null;
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

        private List<DistanceData> MaxMethodHeightWeight(List<DataClassKMI> originalData, int height, int weight)
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

        private List<DistanceData> MaxMethodHeightKMI(List<DataClassKMI> originalData, float height, float kmi)
        {

            float distanceFirst = 0;
            float distanceSecond = 0;

            foreach (var item in originalData)
            {
                float heightDistance = height - item.Height;
                float KMIDistance = kmi - item.KMI;

                if (heightDistance < 0)
                {
                    heightDistance = heightDistance * -1;
                }

                if (KMIDistance < 0)
                {
                    KMIDistance = KMIDistance * -1;
                }

                if (heightDistance > KMIDistance)
                {
                    distanceFirst = heightDistance;
                    distanceSecond = KMIDistance;

                }
                else
                {
                    distanceFirst = KMIDistance;
                    distanceSecond = heightDistance;
                }

                DistanceData.Add(new DistanceData(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender, distanceFirst, distanceSecond));
            }

            List<DistanceData> SortedDistance = DistanceData.OrderBy(o => o.DistanceFirst).ToList();

            return SortedDistance;
        }


        private List<DistanceData> MaxMethodWeightKMI(List<DataClassKMI> originalData, float weight, float kmi)
        {

            float distanceFirst = 0;
            float distanceSecond = 0;

            foreach (var item in originalData)
            {
                float heightDistance = weight - item.Weight;
                float KMIDistance = kmi - item.KMI;

                if (heightDistance < 0)
                {
                    heightDistance = heightDistance * -1;
                }

                if (KMIDistance < 0)
                {
                    KMIDistance = KMIDistance * -1;
                }

                if (heightDistance > KMIDistance)
                {
                    distanceFirst = heightDistance;
                    distanceSecond = KMIDistance;

                }
                else
                {
                    distanceFirst = KMIDistance;
                    distanceSecond = heightDistance;
                }

                DistanceData.Add(new DistanceData(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender, distanceFirst, distanceSecond));
            }

            List<DistanceData> SortedDistance = DistanceData.OrderBy(o => o.DistanceFirst).ToList();

            return SortedDistance;
        }

        private List<DistanceData> MaxMethodAll(List<DataClassKMI> originalData, float heigt, float weight, float kmi)
        {

            float distanceFirst = 0;
            float distanceSecond = 0;

            foreach (var item in originalData)
            {
                
                float heightDistance = heigt - item.Height;
                float weightDistance = weight - item.Weight;
                float kmiDistance = kmi - item.KMI;

                if (heightDistance < 0)
                {
                    heightDistance = heightDistance * -1;
                }

                if (weightDistance < 0)
                {
                    weightDistance = weightDistance * -1;
                }

                if (kmi < 0)
                {
                    kmi = kmi * -1;
                }

                if (heightDistance > weightDistance && heightDistance > kmiDistance)
                {
                    distanceFirst = heightDistance;
                    distanceSecond = weightDistance;

                }
                else if (weightDistance > heightDistance && weightDistance > kmiDistance)
                {
                    distanceFirst = weightDistance;
                    distanceSecond = heightDistance;
                }
                else if (kmiDistance > heightDistance && kmiDistance > weightDistance)
                {
                    distanceFirst = kmi;
                    distanceSecond = heightDistance;
                }

                DistanceData.Add(new DistanceData(item.Name, item.Height, item.Weight, item.ClassKMI, item.KMI, item.Gender, distanceFirst, distanceSecond));
            }

            List<DistanceData> SortedDistance = DistanceData.OrderBy(o => o.DistanceFirst).ToList();

            return SortedDistance;
        }
    }
}
