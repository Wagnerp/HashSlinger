﻿using System;

using NUnit.ConsoleRunner;

namespace HashSlingerTestRunner
{
    // Written by blokeley
    class NUnitConsoleRunner
    {
        [STAThread]
        static void Main(string[] args)
        {
            NUnit.ConsoleRunner.Runner.Main(args);
        }
    }
}
