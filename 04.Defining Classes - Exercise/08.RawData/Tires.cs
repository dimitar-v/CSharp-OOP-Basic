using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tires
    {
        private int age1;
        private double pressure1;
        private int age2;
        private double pressure2;
        private int age3;
        private double pressure3;
        private int age4;
        private double pressure4;

        public Tires(int age1, double pressure1, int age2, double pressure2, 
            int age3, double pressure3, int age4, double pressure4)
        {
            this.Age1 = age1;
            this.Pressure1 = pressure1;
            this.Age2 = age1;
            this.Pressure2 = pressure2;
            this.Age3 = age3;
            this.Pressure3 = pressure3;
            this.Age4 = age4;
            this.Pressure4 = pressure4;
        }

        public int Age1
        {
            get { return age1; }
            set { age1 = value; }
        }
        public double Pressure1
        {
            get { return pressure1; }
            set { pressure1 = value; }
        }

        public int Age2
        {
            get { return age2; }
            set { age2 = value; }
        }
        public double Pressure2
        {
            get { return pressure2; }
            set { pressure2 = value; }
        }

        public int Age3
        {
            get { return age3; }
            set { age3 = value; }
        }
        public double Pressure3
        {
            get { return pressure3; }
            set { pressure3 = value; }
        } 

        public int Age4
        {
            get { return age4; }
            set { age4 = value; }
        }
        public double Pressure4
        {
            get { return pressure4; }
            set { pressure4 = value; }
        }
    }
}
