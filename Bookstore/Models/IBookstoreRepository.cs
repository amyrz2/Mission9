using System;
using System.Linq;

namespace Bookstore.Models
{
	public interface IBookstoreRepository
	{
        public IQueryable<Book> Books { get; }
    }
}

