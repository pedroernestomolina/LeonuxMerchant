using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Demo
{

    public enum EnumResult { isOk, isError };

    public class Resultado 
    {
        public EnumResult Result { get; set; }
        public string Mensaje { get; set; }

        public Resultado()
        {
            Result = EnumResult.isOk;
            Mensaje = "";
        }
    }

    public class RespuestaLogon
    {
        public bool success { get; set; }
        public string message { get; set; }
        public int code { get; set; }
    }

    public class RespuestaCierre
    {
        public bool success { get; set; }
        public string message { get; set; }
        public int code { get; set; }
        public string lote { get; set; }
    }

    public class RespuestaUltConsulta
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string id { get; set; }
        public int code { get; set; }
        public string reference { get; set; }
        public string voucher { get; set; }
        public string ordernumber { get; set; }
        public string sequence { get; set; }
        public string approval { get; set; }
        public int? lote { get; set; }
        public int? responsecode { get; set; }
        public bool? deferred { get; set; }
        public DateTime? datetime { get; set; }
        public decimal? amount { get; set; }
        public string authid { get; set; }
        public string idmerchant { get; set; }
        public string terminal { get; set; }
    }

}