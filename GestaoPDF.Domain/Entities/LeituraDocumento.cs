﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoPDF.Domain.Entities
{
    public class LeituraDocumento
    {
        public LeituraDocumento(string? nomeLoteLiteura, string? nomeUsuarioMaquina, string? nomeMaquina, IList<Documento> documentos)
        {
            NomeLoteLeitura = nomeLoteLiteura;
            NomeUsuarioMaquina = nomeUsuarioMaquina;
            NomeMaquina = nomeMaquina;
            Documentos = documentos;
            Id = Guid.NewGuid();
            DataGravacao = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string? NomeLoteLeitura { get; private set; }
        public DateTime DataGravacao { get; private set; }
        public string? NomeUsuarioMaquina { get; set; }
        public string? NomeMaquina { get; set; }
        public IList<Documento> Documentos { get; private set; }
    }
}
