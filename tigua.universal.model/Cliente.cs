using System;

namespace tigua.universal.model
{
    public class Cliente
    {
        private string nombre;
        private string paterno;
        private string materno;
        private string numeroDocumento;
        private string tipoDocumento;
        private string email;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Email { get => email; set => email = value; }
    }
}
