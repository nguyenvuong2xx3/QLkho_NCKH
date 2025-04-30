using Abp.Application.Services;
using QLKho_NCKH.Products.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho_NCKH.Products
{
	public interface IProductAppService
	{
		Task<ProductListDto> CreateAsync(ProductListDto input);
		Task<ProductListDto> UpdateAsync(ProductListDto input);
		Task DeleteAsync(int id);
		Task<ProductListDto> GetByIdAsync(int id);
		Task<List<ProductListDto>> GetAllByFilterAsync(string filter);
		Task<List<ProductListDto>> GetAllByPagingAsync(int pageIndex, int pageSize);
		Task<int> GetTotalCountAsync();
		Task<List<ProductListDto>> GetAllByCategoryIdAsync(int categoryId);
		Task<List<ProductListDto>> GetAllBySupplierIdAsync(int supplierId);
		Task<List<ProductListDto>> GetAllByWarehouseIdAsync(int warehouseId);
	}
}
