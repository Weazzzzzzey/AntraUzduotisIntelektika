using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraUzduotisIntelektika
{
    public class DataClassKMI
    {

        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string ClassKMI { get; set; }
        public float KMI { get; set; }
        public int Gender { get; set; }

        public DataClassKMI(string name, int height, int weight, string classkmi, float kmi, int gender)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.ClassKMI = classkmi;
            this.KMI = kmi;
            this.Gender = gender;
        }


    }
}
