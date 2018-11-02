﻿namespace P06_Animals
{
    class Frog : Animals
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        { }

        public override string ProduceSound()
            => "Ribbit";
    }
}
