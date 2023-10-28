using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Flappy_bird.Model
{
    public partial class DB_player : DbContext
    {
        public DB_player()
            : base("name=DB_player2")
        {
        }

        public virtual DbSet<tb_rank> tb_ranks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tb_rank>()
                .Property(e => e.Player)
                .IsUnicode(false);
        }
    }
}
