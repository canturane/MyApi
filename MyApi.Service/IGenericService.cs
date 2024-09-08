<<<<<<< HEAD
﻿using MyApi.Service.Dtos;
using System;
=======
﻿using System;
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApi.Service
{
    public interface IGenericService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
<<<<<<< HEAD

    }
}


=======
    }
}
>>>>>>> 288b9a8295fb51213e8c2ea94c79e9c386a17eef
