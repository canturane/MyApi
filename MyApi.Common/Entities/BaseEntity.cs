using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Common.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; } = new DateTime();
        public DateTime? LastUpdateDate { get; set; } = new DateTime();
<<<<<<< HEAD
        public bool IsActive { get; set; }
=======
        public bool? IsActive { get; set; }
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
    }
}
