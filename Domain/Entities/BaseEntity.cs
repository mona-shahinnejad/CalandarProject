using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Column(Order = 0)]
        public long Id { get; set; }

        [Column(Order = 98)]
        public DateTime CreateDateTime { get; set; }

        [Column(Order = 99)]
        public DateTime ModifyDateTime { get; set; }
    }
}
