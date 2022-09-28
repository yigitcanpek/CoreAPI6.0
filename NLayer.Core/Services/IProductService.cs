using NLayer.Core.DTOs.ApiDTOs;
using NLayer.Core.DTOs.ApiResponseDTOs;
using NLayer.Core.Entities;
using NLayer.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Services
{
    public interface IProductService:IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDTO>>> GetProductWithCategory();
    }
}
