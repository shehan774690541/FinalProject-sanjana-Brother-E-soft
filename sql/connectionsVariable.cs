using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.sql
{
    internal class ConnectionsVariable
    {
        public string Server { get; } = "localhost";
        public string User { get; } = "root";
        public string Database { get; } = "learning";
        public string Password { get; } = "";
    }
}
