using System;

namespace tigua.universal.model
{
    public class Cliente
    {
        private string nombres;
        private string paterno;
        private string materno;
        private string numeroDocumento;
        private string tipoDocumento;
        private string email;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno
        {
            get => materno;
            set
            {
                materno = value;
            }
        }
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Email { get => email; set => email = value; }
    }
}
