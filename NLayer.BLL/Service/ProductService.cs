using AutoMapper;
using NLayer.Core.DTOs.ApiDTOs;
using NLayer.Core.DTOs.ApiResponseDTOs;
using NLayer.Core.Entities;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.BLL.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDTO>>> GetProductWithCategory()
        {
            List<Product> products = await _productRepository.GetProductsWithCategory();
            List<ProductWithCategoryDTO> productsDTO = _mapper.Map<List<ProductWithCategoryDTO>>(products);
            return CustomResponseDto<List<ProductWithCategoryDTO>>.Success(200,productsDTO);
        }
    }
}
