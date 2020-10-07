using System;
using System.Collections.Generic;
using System.Text;

namespace _3
{
    class Honda : Car
    {
        private string model;
        public Honda() { }
        public Honda(string model)
        {
            this.model = model;
        }
        public Honda(string model, string owner) : base(owner)
        {
            this.model = model;
        }
        public Honda(string model, int age) : base(age)
        {
            this.model = model;
        }
        public Honda(string model, string owner, int age) : base(owner, age)
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
