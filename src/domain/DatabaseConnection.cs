using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sql.domain
{
    class DatabaseConnection
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        private long Id { get; set; }

        private string Name { get; set; } = string.Empty;

        private string Url { get; set; } = string.Empty;

        private string Username { get; set; } = string.Empty;

        private string Password { get; set; } = string.Empty;
    }
}
