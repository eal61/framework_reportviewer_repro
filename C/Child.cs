using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WebForms;

namespace C
{
    public class Child : IReportServerConnection
    {
        public Uri ReportServerUrl => throw new NotImplementedException();

        public int Timeout => throw new NotImplementedException();

        public WindowsIdentity ImpersonationUser => throw new NotImplementedException();

        public ICredentials NetworkCredentials => throw new NotImplementedException();

        public bool GetFormsCredentials(out Cookie authCookie, out string userName, out string password, out string authority)
        {
            throw new NotImplementedException();
        }
    }
}
