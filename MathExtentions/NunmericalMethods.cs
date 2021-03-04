using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExtentions
{
    public class NumericalMethods 
    {
        public delegate double Expression(double x, double y);
        public  List<double> EulersMethod(Expression func,double upperBound,double lowerBound,double startX,int countStep,double startY)
        {
            var funcResults = new List<double>();
            funcResults.Add(startY);
            var step = GetStep(upperBound, lowerBound, countStep);
            double lastX = startX + step * countStep;
            int i = 0;
            for (double x = startX; x <=lastX; x+=step)
            {
                funcResults.Add(funcResults[i]+step*(double)func.DynamicInvoke(x,funcResults[i]));
                i++;
            }
            return funcResults;
        }
        public List<double> EulersMethod(Expression func, double upperBound, double lowerBound, double startX, double step, double startY)
        {
            var funcResults = new List<double>();
            funcResults.Add(startY);
            var countStep = GetStepCount(upperBound, lowerBound, step);
            double lastX = startX + step * countStep;
            int i = 0;
            for (double x = startX; x <= lastX; x += step)
            {
                funcResults.Add(funcResults[i] + step * (double)func.DynamicInvoke(x, funcResults[i]));
                i++;
            }
            return funcResults;
        }
        public double GetStep(double start, double stop, int stepCount)
        {
            if (start>stop)
            {
                throw new InvalidOperationException("Конец отрезка доллжен быть больше его начала");
            }
            return (stop - start) / stepCount;
        }
        public double GetStepCount(double start, double stop, double step)
        {
            if (start > stop)
            {
                throw new InvalidOperationException("Конец отрезка доллжен быть больше его начала");
            }
            return (stop - start) / step;
        }
        public List
    }
}
