using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Service.ViewModels
{
    public class ClienteVM
    {
        public string id { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public DateTime nascimento { get; set; }
        public string empresa { get; set; }
    }
}