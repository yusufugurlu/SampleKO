using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SampleKO.Business.Abstract;
using SampleKO.DataAccess.Entities;
using SampleKO.Model;
using SampleKO.Model.ViewModel.ProductViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWorks _unitOfWorks;
        private readonly IGenericRepository<Product> _productRepo;
        private readonly IGenericRepository<ProductType> _productTypeRepo;
        public ProductManager(IUnitOfWorks unitOfWorks)
        {
            _unitOfWorks = unitOfWorks;
            _productRepo = _unitOfWorks.GetGenericRepository<Product>();
            _productTypeRepo = _unitOfWorks.GetGenericRepository<ProductType>();
        }
        public ServiceResult GetAll()
        {
            //ProductViewModel
            var productView = new List<ProductViewModel>();

            var products = _productRepo.GetAll(x => !x.IsDelete).Include(x => x.Brand).Include(x=>x.ProductTypes).ToList().Select(x => new ProductViewModel
            {
                Description = x.Description,
                Name = x.Name,
                BrandName = x.Brand.BrandFullName,
                Amount= x.ProductTypes.FirstOrDefault() != null ? x.ProductTypes.FirstOrDefault().Amount:0.0m,
                Stock= x.ProductTypes.FirstOrDefault() !=null ? x.ProductTypes.FirstOrDefault().Stock:0,
            }).ToList();
            
            productView.AddRange(products);

            return Result.Success("", productView);
        }
    }
}
