namespace Flappy_bird
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_rank
    {
        [Key]
        [StringLength(50)]
        public string Player { get; set; }

        public int Score { get; set; }
    }
}
