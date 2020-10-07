using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Toyota : Car
    {
        private string model;
        public Toyota() { }
        public Toyota(string model)
        {
            this.model = model;
        }
        public Toyota(string model, string owner) : base(owner)
        {
            this.model = model;
        }
        public Toyota(string model, int age) : base(age)
        {
            this.model = model;
        }
        public Toyota(string model, string owner, int age) : base(owner, age)
        {
            this.model = model;
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
    }
}
