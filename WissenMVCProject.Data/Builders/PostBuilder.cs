using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenMVCProject.Model;

namespace WissenMVCProject.Data.Builders
{
    public class PostBuilder
    {
        public PostBuilder(EntityTypeConfiguration<Post> entity)
        {
            entity.Property(p => p.Title).IsRequired().HasMaxLength(100);
            entity.Property(p => p.Description).IsRequired().HasMaxLength(5000);
            entity.HasOptional(p => p.Category).WithMany(m => m.Posts).HasForeignKey(p => p.CategoryId);
        }
    }
}
