using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoSE.Models
{
    class Modulo2Model
    {
        public int module_id { get; set; }
        public int module1_id { get; set; }
        public string mac_address { get; set; }
        public DateTime timestamp { get; set; }
        

        public Modulo2Model(int module_id, int module1_id, string mac_address, DateTime timestamp)
        {
            this.module_id = module_id;
            this.module1_id = module1_id;   
            this.mac_address = mac_address;
            this.timestamp = timestamp;
        }
    }

    class MedidasM2Model
    {
        public int medida_id { get; set; }
        public int module2_id { get; set; }
        public bool short_circuit { get; set; }
        public DateTime data_init { get; set; }
        public DateTime data_end { get; set; }

        public MedidasM2Model(int module2_id, bool short_circuit, DateTime data_init, DateTime data_end)
        {
            this.module2_id = module2_id;   
            this.short_circuit = short_circuit;
            this.data_init = data_init;
            this.data_end = data_end;
        }

        public MedidasM2Model(int medida_id, int module2_id, bool short_circuit, DateTime data_init, DateTime data_end)
        {
            this.medida_id = medida_id;
            this.module2_id = module2_id;
            this.short_circuit = short_circuit;
            this.data_init = data_init;
            this.data_end = data_end;
        }
    }
}
