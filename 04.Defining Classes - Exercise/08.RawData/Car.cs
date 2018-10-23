using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tires tires;

        public Car(string model, Engine engine, Cargo cargo, Tires tires)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
        }

        public Tires Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }
    }
}
