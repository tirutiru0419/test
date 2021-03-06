﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntranceAndExitRecord.Entity
{
    [Table("Item")]
    public class Item
    {
        [Key]
        [Required]
        public int PointNo { set; get; }

        [Key]
        [Required]
        public int Id { set; get; }

        [Required]
        public string ItemName { set; get; }

        [Required]
        public int SortNum { set; get; }
    }
}