﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NotGrocy.Models
{
    [Table("chores")]
    [Index(nameof(Id), IsUnique = true)]
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(Id), nameof(Active), Name = "ix_chores_performance1")]
    public partial class Chore
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Required]
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Required]
        [Column("period_type")]
        public string PeriodType { get; set; }
        [Column("period_days")]
        public long? PeriodDays { get; set; }
        [Column("row_created_timestamp", TypeName = "DATETIME")]
        public byte[] RowCreatedTimestamp { get; set; }
        [Column("period_config")]
        public string PeriodConfig { get; set; }
        [Column("track_date_only", TypeName = "TINYINT")]
        public long? TrackDateOnly { get; set; }
        [Column("rollover", TypeName = "TINYINT")]
        public long? Rollover { get; set; }
        [Column("assignment_type")]
        public string AssignmentType { get; set; }
        [Column("assignment_config")]
        public string AssignmentConfig { get; set; }
        [Column("next_execution_assigned_to_user_id", TypeName = "INT")]
        public long? NextExecutionAssignedToUserId { get; set; }
        [Column("consume_product_on_execution", TypeName = "TINYINT")]
        public long ConsumeProductOnExecution { get; set; }
        [Column("product_id", TypeName = "TINYINT")]
        public long? ProductId { get; set; }
        [Column("product_amount")]
        public double? ProductAmount { get; set; }
        [Column("period_interval")]
        public long PeriodInterval { get; set; }
        [Column("active", TypeName = "TINYINT")]
        public long Active { get; set; }
    }
}
