using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenMVCProject.Model;

namespace WissenMVCProject.Data.Builders
{
    public class CategoryBuilder
    {
        public CategoryBuilder(EntityTypeConfiguration<Category> entity)
        {
            entity.Property(p => p.Name).IsRequired().HasMaxLength(50);
            entity.Property(p => p.Description).HasMaxLength(5000);

        }
    }
}
