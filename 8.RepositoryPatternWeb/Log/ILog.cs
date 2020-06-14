using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternWeb.Logs
{
    public interface ILog
    {
        void LogException(string message);
    }
}