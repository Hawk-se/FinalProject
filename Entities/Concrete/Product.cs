using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{   /* Class'ı public yaptık. Bu sayede diğer katmanlar da erişebilir!!!
     Public yapılmazsa diğer katmanlar erişemez*/
    // Class'ın default değeri internal'dır ve bu durumda sadece Entities erişebilir
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
