using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    [Serializable]
    public class Function
    {
        public static int IterationNumTo = 10;
        public static int IterationFrom = -10;

        public List<FunctionParameter> Parameter { get; set; }

        public Function()
        {
            Parameter = new List<FunctionParameter>();
        }

        public float[] GetYValues()
        {
            float[] yValues= new float[IterationNumTo*2];
            int counter = 0;
            for(int i = IterationFrom; i < IterationNumTo; i++)
            {
                yValues[counter] = GetYValue(i);
                counter++;
            }

            return yValues;
        }

        public float GetYValue(float x)
        {
            float temp = 0;
            foreach(FunctionParameter fp in Parameter)
            {
                temp += fp.GetValue(x);
            }
            return temp;
        }
    }
}
