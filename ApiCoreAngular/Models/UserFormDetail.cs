using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiCoreAngular.Models
{
    public class UserFormDetail
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Birthday { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Jobs { get; set; }

        public string Age { get; set; }
    }
}
