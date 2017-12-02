using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Challenge_2
{
    class Coder
    {
        public string Name { get; private set; }

        public int ExperienceYears { get; private set; }

        public bool alive { get; private set; }

        public bool are_stressed { get; private set; }
        
        public bool are_saint { get; private set; }

        public readonly bool are_alone = true;

        protected Random random = new Random();

        private double coding_power = 0;

        private List<string> code_snippets = new List<string>();

        private int total_lines_coded = 0;

        private int y_axis { get; set; }

        public Coder(string Name, int ExperienceYears)
        {
            this.Name = Name;
            this.ExperienceYears = ExperienceYears;
            this.alive = true;
            this.are_saint = random.NextDouble() > 0.5;
            this.y_axis = this.are_saint ? 100 : 0;

            // Fill code snippets list
            this.code_snippets.AddRange(new List<string>
            {
                "Console.WriteLine(\"Hello\");",
                "Console.WriteLine(\"World\");",
                "Console.ReadKey();",
                "Console.Beep();",
                "if (2 * 2 == 5) return true;",
                "return new Matrix(rabbit_width, rabbit_height);",
                "using Brain;",
                "this.is = (bool)shit;",
                "{",
                "}"
            });
        }

        public void drink_coffee()
        {
            int cups = random.Next(1, 3);
            double power = cups * 1.5;
            this.coding_power += cups;
        }

        public void code()
        {
            while (this.coding_power > 1.0)
            {
                Console.WriteLine(this.code_snippets[random.Next(0, this.code_snippets.Count - 1)]);
                this.total_lines_coded++;
                this.coding_power -= 1.0;

                if (this.total_lines_coded > 1000)
                {
                    this.are_stressed = true;
                }
            }
        }

        public void go_rest()
        {
            this.total_lines_coded = 0;
            Console.WriteLine("huhhh...");
            Thread.Sleep(1000);
        }

        public void go_have_fun()
        {
            Console.WriteLine("Beer = Brew, Enjoy, Empty, Repeat.");
        }

        public void go_sleep()
        {
            Console.WriteLine("ZzZzzz...");
            Thread.Sleep(3000);
        }

        public void go_alive()
        {
            Console.WriteLine("Life sucks.");
        }

        public void go_find_soulmate()
        {
            if ((1 + 1) * (1 + 1) == 5)
            {
                Console.WriteLine("Congrats, you found your soulmate!"); // btw we ignore warnings
            }
            else
            {
                Console.WriteLine("Error 404: soulmate not found.");
            }
        }

        public void cheer_up()
        {
            Console.WriteLine("whatever :-)");
        }

        public bool go_to_heaven()
        {
            this.y_axis += 1000000000;
            return true;
        }

        public bool go_to_hell()
        {
            this.y_axis -= 1000000000;
            return false;
        }
    }
}
