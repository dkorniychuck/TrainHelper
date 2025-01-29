using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class User
    {
        public int id {get; set;}
        public string login, gender, isActive, goal;
        public int age, weight, height;
        public Double trainingsCount, kKal;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public string Goal
        {
            get { return goal; }
            set { goal = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public double TrainingsCount
        {
            get { return trainingsCount; }
            set { trainingsCount = value; }
        }

        public double KKal
        {
            get { return kKal; }
            set { kKal = value; }
        }

        public User() { }

        public User(string login, string gender, string isActive, string goal, int age, int weight, int height, double trainingsCount, double kkal)
        {
            this.login = login;
            this.gender = gender;
            this.isActive = isActive;
            this.goal = goal;
            this.age = age;
            this.weight = weight;
            this.height = height;
            this.trainingsCount = trainingsCount;
            this.kKal = kkal;
        }
    }
}
