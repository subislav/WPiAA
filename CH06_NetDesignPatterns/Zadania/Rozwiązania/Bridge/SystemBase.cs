using System;
using System.Collections.Generic;

namespace Bridge
{
    public abstract class SystemBase
    {
        protected IUserInterface _interface;
        public SystemBase(IUserInterface ui)
        {
            _interface = ui;
        }
        public void SetInterface(IUserInterface ui)
        {
            _interface = ui;
        }
        public abstract void OpenMenu();
    }
    public class LinuxSystem : SystemBase
    {
        public LinuxSystem(IUserInterface ui) : base(ui) { }
        public override void OpenMenu()
        {
            List<string> linuxPrograms = new List<string> { "Vim", "Grep", "Htop", "Git" };
            _interface.DisplayMenu("Linux Ubuntu", linuxPrograms);
        }
    }
    public class WindowsSystem : SystemBase
    {
        public WindowsSystem(IUserInterface ui) : base(ui) { }

        public override void OpenMenu()
        {
            List<string> winPrograms = new List<string> { "Notepad", "Paint", "Edge", "Office" };
            _interface.DisplayMenu("Windows 11  ", winPrograms);
        }
    }
}