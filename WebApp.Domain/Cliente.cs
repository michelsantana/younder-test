using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public class Cliente
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        [Required]
        public string cpf { get; set; }
        [Required]
        public string nome { get; set; }
        [Required]
        public DateTime nascimento { get; set; }
        [Required]
        public string empresa { get; set; }
    }
}
