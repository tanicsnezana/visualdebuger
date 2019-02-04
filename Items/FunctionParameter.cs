using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    [Serializable]
    public class FunctionParameter
    {
        public char Sign { get; set; }
        public float Coefficient { get; set; }
        public int Degree { get; set; }

        public FunctionParameter() { }
        public FunctionParameter(char sign, float coefficient, int degree)
        {
            Sign = sign;
            Coefficient = coefficient;
            Degree = degree;
        }
        
        public float GetValue(float x)
        {
            float temp = 1;
            for(int i=0; i < Degree; i++)
            {
                temp *= x;
            }

            temp *= Coefficient;
            return Sign == '-' ? (-1 * temp) : temp;
        }
    }
}
