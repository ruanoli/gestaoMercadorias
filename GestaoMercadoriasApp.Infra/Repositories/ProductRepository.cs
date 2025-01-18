using GestaoMercadoriasApp.Domain.Interfaces;
using GestaoMercadoriasApp.Domain.Models;
using GestaoMercadoriasApp.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercadoriasApp.Infra.Repositories
{
    internal class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
