using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenge_2
{
    class Life
    {
        static void Main(string[] args)
        {
            Coder you = new Coder(Name: "GEveloper", ExperienceYears: 4);

            while (you.alive)
            {
                you.drink_coffee();
                you.code(); // actually turning coffee in to code))

                if (you.are_stressed)
                {
                    you.go_rest();
                    you.go_have_fun();
                    you.go_sleep();
                }
                
                if (you.are_alone) // and you are, because you are coder
                {
                    you.go_alive();
                    you.go_find_soulmate();
                    you.cheer_up();
                }
            }

            bool result = you.are_saint ? you.go_to_heaven() : you.go_to_hell();

            /* exception is thrown here,
             * you are coder you now everything is lie, matrix doesn't work that way)) */

        }
    }
}
