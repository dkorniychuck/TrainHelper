using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class CalculateKKal
    {
        public string Gender;
        public int Age;
        public int Weight;
        public int Height;
        public double TrainingsCount;
        public string Goal;
        public void setValues(string gender, int age, int weight, int height, double trainingsCount, string goal)
        {
            this.Gender = gender;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;
            this.TrainingsCount = trainingsCount;
            this.Goal = goal;
        }
        public CalculateKKal(string gender, int age, int weight, int height, double trainingsCount, string goal)
        {
            this.setValues(gender, age, weight, height, trainingsCount, goal);
        }

        public double CaloriesCounter()
        {
            if (Gender == "Man")
            {
                double KKal = (((10 * Weight) + (6.25 * Height) - (5 * Age)) + 5) * TrainingsCount;
                switch (Goal)
                {
                    case "Increase":
                        {
                            KKal *= 1.1;
                            return KKal;
                        }
                    case "Save":
                        {
                            return KKal;
                        }
                    case "Decrease":
                        {
                            KKal *= 0.9;
                            return KKal;
                        }
                }
                return KKal;
            }
            else
            {
                double KKal = (((10 * Weight) + (6.25 * Height) - (5 * Age)) - 161) * TrainingsCount;
                switch (Goal)
                {
                    case "Increase":
                        {
                            KKal *= 1.1;
                            return KKal;
                        }
                    case "Save":
                        {
                            return KKal;
                        }
                    case "Decrease":
                        {
                            KKal *= 0.9;
                            return KKal;
                        }
                }
                return KKal;
            }
        }
    }
}
