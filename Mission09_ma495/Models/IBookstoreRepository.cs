using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_ma495.Models
{
    public interface IBookstoreRepository //interface is a template for a class
    {
        IQueryable<Book> Books { get; }
    }
}
