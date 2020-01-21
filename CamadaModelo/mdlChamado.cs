using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamadaModelo
{
    public class mdlChamado
    {
        public string Protocolo     { get; set; }
        public string Assunto       { get; set; }
        public string Usuario       { get; set; }
        public string Departamento  { get; set; }
        public string Categoria     { get; set; }
        public string Texto         { get; set; }
        public string DataHora      { get; set; }
        public bool   Status        { get; set; }
        public string Replica       { get; set; }
    }
}
