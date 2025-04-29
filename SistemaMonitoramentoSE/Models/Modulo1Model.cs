using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoSE.Models
{
    class Modulo1Model
    {
        public int module_id { get; set; }
        public string mac_address { get; set; }
        public int num_packages { get; set; }
        public DateTime timestamp { get; set; }
        public int send_freq_ms { get; set; }

        public Modulo1Model(int module_id, string mac_address, int num_packages, DateTime timestamp, int send_freq_ms)
        {
            this.module_id = module_id;
            this.mac_address = mac_address;
            this.num_packages = num_packages;
            this.timestamp = timestamp;
            this.send_freq_ms = send_freq_ms;
        }
    }




    class MedidasM1Model
    {
        public int medida_id { get; set; }
        public int module_id { get; set; }
        public string fase { get; set; }
        public float tensao { get; set; }
        public float corrente { get; set; }
        public float angTensao { get; set; }
        public float potApaVA { get; set; }
        public float potRealVAr { get; set; }
        public float potRealW { get; set; }
        public float fatorP { get; set; }
        public float freq { get; set; }
        public DateTime timestamp { get; set; }

        public string? target_vat = null;

        public string? target_phase = null;

        public MedidasM1Model(int medida_id, int module_id, string fase, float tensao, float corrente, float angTensao, float potApaVa, float potRealVAr, float potRealW, float fatorP, float freq, DateTime timestamp, string? target_vat, string? target_phase)
        {
            this.medida_id = medida_id;
            this.module_id = module_id;
            this.fase = fase;
            this.tensao = tensao;
            this.corrente = corrente;
            this.angTensao = angTensao;
            this.potApaVA = potApaVa;
            this.potRealVAr = potRealVAr;
            this.potRealW = potRealW;
            this.fatorP = fatorP;
            this.freq = freq;
            this.timestamp = timestamp;
            this.target_vat = target_vat;
            this.target_phase = target_phase;
        }
    }
}
