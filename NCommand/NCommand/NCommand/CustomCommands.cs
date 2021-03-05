﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCommand
{
    using System.Windows.Input;
    class CustomCommands
    {
        public static RoutedUICommand Launch { get; }
        static CustomCommands()
        {
            InputGestureCollection myInputGestures = new
           InputGestureCollection();
            myInputGestures.Add(new KeyGesture(Key.L, ModifierKeys.Control));
            Launch = new RoutedUICommand("Запуск", "Launch",
           typeof(CustomCommands), myInputGestures);
        }

    }
}
