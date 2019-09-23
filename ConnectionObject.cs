using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    public static class ConnectionObject
    {
        public static OleDbConnection Conn { get; set; }
    }
}
