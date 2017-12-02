using System;

namespace Challenge_2
{
    class Life
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            Coder you = new Coder(Name: "GEveloper", ExperienceYears: 4);

            try
            {
                while (you.alive)
                {
                    you.drink_coffee();
                    you.code(); // actually turning coffee in to code))

                    if (you.are_stressed)
                    {
                        if (!you.go_rest())
                        {
                            break;
                        }

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
                 * you are coder, you know everything is lie, matrix doesn't work that way)) */
                throw new FuckThatLifeException("Everything Is Lie!");
            }
            catch (FuckThatLifeException fex)
            {
                Console.WriteLine(string.Format("<< {0} >>", fex.Message));
            }

            Console.ReadKey();
        }
    }
}
