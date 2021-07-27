﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NotGrocy.Models
{
    [Table("chores_log")]
    [Index(nameof(Id), IsUnique = true)]
    public partial class ChoresLog
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("chore_id")]
        public long ChoreId { get; set; }
        [Column("tracked_time", TypeName = "DATETIME")]
        public byte[] TrackedTime { get; set; }
        [Column("done_by_user_id")]
        public long? DoneByUserId { get; set; }
        [Column("row_created_timestamp", TypeName = "DATETIME")]
        public byte[] RowCreatedTimestamp { get; set; }
        [Column("undone", TypeName = "TINYINT")]
        public long Undone { get; set; }
        [Column("undone_timestamp", TypeName = "DATETIME")]
        public byte[] UndoneTimestamp { get; set; }
    }
}
