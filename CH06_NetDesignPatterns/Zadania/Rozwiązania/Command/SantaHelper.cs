using System;
using System.Collections.Generic;

namespace Command
{
    public class SantaHelper
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            _command = command;
        }
        public void PressButton()
        {
            if (_command != null)
            {
                Console.Write("Elf wysyła polecenie do fabryki: ");
                _command.Execute();
            }
        }
    }
}