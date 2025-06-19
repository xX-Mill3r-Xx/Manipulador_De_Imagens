using System;

namespace InserirAnexo.Models
{
    public class OSD_ordem_servico_anexo
    {
        public long oax_codtemp { get; set; }
        public long oax_codserv { get; set; }
        public long ods_codtemp { get; set; }
        public DateTime oax_data { get; set; }
        public string oax_descricao { get; set; }
        public byte[] oax_imagem { get; set; }
        public string oax_extensao { get; set; }
    }
}
