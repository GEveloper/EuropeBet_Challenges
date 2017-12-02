using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge_2
{
    class Coder
    {
        public string Name { get; private set; }

        public int ExperienceYears { get; private set; }

        public bool alive { get; private set; }

        public bool are_stressed { get; set; }
        
        public bool are_saint { get; private set; }

        public readonly bool are_alone = true;

        protected Random random = new Random();
        
        public Coder(string Name, int ExperienceYears)
        {
            this.Name = Name;
            this.ExperienceYears = ExperienceYears;
            this.alive = true;
            this.are_saint = random.NextDouble() > 0.5;
        }

        public void drink_coffee()
        {
            throw new NotImplementedException();
        }

        public void code()
        {
            throw new NotImplementedException();
        }

        public void go_rest()
        {
            throw new NotImplementedException();
        }

        public void go_sleep()
        {
            throw new NotImplementedException();
        }

        public void go_alive()
        {
            throw new NotImplementedException();
        }

        public void cheer_up()
        {
            throw new NotImplementedException();
        }

        public bool go_to_hell()
        {
            throw new NotImplementedException();
        }

        public bool go_to_heaven()
        {
            throw new NotImplementedException();
        }

        public void go_find_soulmate()
        {
            throw new NotImplementedException();
        }

        public void go_have_fun()
        {
            throw new NotImplementedException();
        }
    }
}
