using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lfspinnerBeta.I_SendMail
{
     interface ISendMail
    {
        void setHost(string host);
        void setPort(int port);
        bool Send();
    }
}
