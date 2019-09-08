using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Convivio.API.Entities
{
    public abstract class Entity
    {
        [Column("Id")]
        public long Id { get; set; }
    }
}