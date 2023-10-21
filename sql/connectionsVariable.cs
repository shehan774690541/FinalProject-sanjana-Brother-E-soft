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
        public int Port { get; } = 3306;
        public string User { get; } = "root";
        public string Database { get; } = "learning";
        public string Table { get; } = "registration";
        public string Password { get; } = "";
    }
}
