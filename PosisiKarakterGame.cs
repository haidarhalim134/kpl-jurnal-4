using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_1302220152
{
    internal class PosisiKarakterGame
    {
        public enum State { Berdiri, Jongkok, Tengkurap, Terbang }
        State currentState = State.Berdiri;
        public void start()
        {
            while (true)
            {
                Console.WriteLine("State sekarang: " + currentState);
                Console.WriteLine("Command: ");

                string cmd = Console.ReadLine();

                if (cmd == "w")
                    Console.WriteLine("tombol atas ditekan");
                else if (cmd == "s")
                    Console.WriteLine("tombol bawah ditekan");

                switch (currentState)
                {
                    case State.Berdiri:
                        if (cmd == "w")
                            currentState = State.Terbang;
                        else if (cmd == "s")
                            currentState = State.Jongkok; 
                        break;
                    case State.Terbang:
                        if (cmd == "s")
                            currentState = State.Berdiri;
                        else if (cmd == "x")
                            currentState = State.Jongkok;
                        break;
                    case State.Jongkok:
                        if (cmd == "w")
                            currentState = State.Berdiri;
                        else if (cmd == "s")
                            currentState = State.Tengkurap;
                        break;
                    case State.Tengkurap:
                        if (cmd == "w")
                            currentState = State.Jongkok;
                        break;
                }
            }

        }
    }
}
