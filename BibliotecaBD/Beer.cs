using System;
using System.Collections.Generic;

namespace BibliotecaBD
{
    public partial class Beer
    {
        public Beer()
        {
            InverseBrand = new HashSet<Beer>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int BrandId { get; set; }

        public virtual Beer Brand { get; set; } = null!;
        public virtual ICollection<Beer> InverseBrand { get; set; }
    }
}
