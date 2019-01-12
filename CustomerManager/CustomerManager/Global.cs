using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager
{
    public static class Global
    {
        public static string VersionNumber { get; set; } = "0.0.0.1";
        public static string CurrentUserName { get; set; }
        public static string CurrentUserLastName { get; set; }
        public static string CurrentUserId { get; set; }
    }
}
