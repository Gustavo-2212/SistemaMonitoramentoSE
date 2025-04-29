using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SistemaMonitoramentoSE.Handler
{
    public interface IMessageHandler
    {
        void Handle(JObject message, Form form);
    }
}
