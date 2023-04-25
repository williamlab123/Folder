         //WINDOWS
using System;
using System.Diagnostics;
using System.IO;

class Program {
    static void Main(string[] args) {
        string currentDirectory = Directory.GetCurrentDirectory();
        Process.Start("explorer.exe", currentDirectory);
    }
}
/////////////////////////////////////////////////////////////

        //lINUX

using System;
using System.Diagnostics;
using System.IO;

class Program {
    static void Main(string[] args) {
        string currentDirectory = Directory.GetCurrentDirectory();
        Process.Start("nautilus", currentDirectory);
    }
}
