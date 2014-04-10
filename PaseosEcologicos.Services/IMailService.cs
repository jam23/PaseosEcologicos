using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reval.Services
{
    public interface IMailService
    {
        bool Send(string _to, string _from, string _subject, string _body);
        void Over();
    }
}
