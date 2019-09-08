using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Convivio.API.Entities
{
    public abstract class Entity
    {
        [Column("Id")]
        [Key]
        public long Id { get; set; }
    }
}