﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DitaliaAPI.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
