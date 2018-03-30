using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TheCrossingProblem
{
    class Crossing
    {
        public bool[] Side { get; set; }

        public Crossing(bool human = false, bool lion = false, bool rabbit = false, bool cabbage = false)
        {
            Side = new bool[4] { human, lion, rabbit, cabbage };
        }

        public void Cross(char action)
        {

            if (action == 'a')
            {
                Side[(int)Agents.Human] = !Side[(int)Agents.Human];
                Console.WriteLine("The Man sailed to the " + printSide(Side[(int)Agents.Human]) + " bank.");
            }

            else if (action == 'l')
            {
                if(Side[(int)Agents.Human] == Side[(int)Agents.Lion])
                {
                    Side[(int)Agents.Human] = !Side[(int)Agents.Human];
                    Side[(int)Agents.Lion] = !Side[(int)Agents.Lion];
                    Console.WriteLine("The Man and the Lion sailed to the " + printSide(Side[(int)Agents.Human]) + " bank.");
                }

                else
                {
                    throw new SameSideException("Man", "Lion");
                }
            }

            else if (action == 'r')
            {
                if (Side[(int)Agents.Human] == Side[(int)Agents.Rabbit])
                {
                    Side[(int)Agents.Human] = !Side[(int)Agents.Human];
                    Side[(int)Agents.Rabbit] = !Side[(int)Agents.Rabbit];
                    Console.WriteLine("The Man and the Rabbit sailed to the " + printSide(Side[(int)Agents.Human]) + " bank.");
                }

                else
                {
                    throw new SameSideException("Man", "Rabbit");
                }
            }

            else if (action == 'c')
            {
                if (Side[(int)Agents.Human] == Side[(int)Agents.Cabbage])
                {
                    Side[(int)Agents.Human] = !Side[(int)Agents.Human];
                    Side[(int)Agents.Cabbage] = !Side[(int)Agents.Cabbage];
                    Console.WriteLine("The Man and the Cabbage sailed to the " + printSide(Side[(int)Agents.Human]) + " bank.");
                }

                else
                {
                    throw new SameSideException("Man", "Cabbage");
                }
            }

            else
            {
                throw new CommandException();
            }

            CheckConfiguration();
        }

        public void CheckConfiguration()
        {
            char agent = ' ';

            for (int i = 0; i < Side.Length; i++)
            {
                

                if(i == 0)
                {
                    agent = 'H';
                }
                else if(i == 1)
                {
                    agent = 'L';
                }
                else if(i == 2)
                {
                    agent = 'R';
                }
                else if(i == 3)
                {
                    agent = 'C';
                }

                if(Side[i] == false)
                {
                    Console.WriteLine(" " + agent + " |          |");
                }
                else
                {
                    Console.WriteLine("   |          | " + agent);
                }
            }

            if (Side[(int)Agents.Human] != Side[(int)Agents.Lion] && Side[(int)Agents.Lion] == Side[(int)Agents.Rabbit])
            {
                throw new TragedyException("Lion", "Rabbit");
            }

            else if (Side[(int)Agents.Human] != Side[(int)Agents.Rabbit] && Side[(int)Agents.Rabbit] == Side[(int)Agents.Cabbage])
            {
                throw new TragedyException("Rabbit", "Cabbage");
            }
        }

        private string printSide(bool side)
        {
            if (side == false)
                return "left";
            else
                return "right";
        }
    }
}
