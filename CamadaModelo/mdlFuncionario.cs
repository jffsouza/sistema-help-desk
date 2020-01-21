using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CamadaModelo
{
    public class mdlFuncionario
    {
        public string   ID            { get; set; }
        public string   Email         { get; set; }
        public string   Senha         { get; set; }
        public string   Nome          { get; set; }
        public string   Sobrenome     { get; set; }
        public string   Departamento  { get; set; }
        public bool     Status        { get; set; }
    }
}
