using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho_NCKH.Products.Dto
{
	public class ProductListDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public string Unit { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime ModifiedDate { get; set; }
		public bool IsActive { get; set; }
		public ProductListDto()
		{
			IsActive = true;
			CreatedDate = DateTime.Now;
			ModifiedDate = DateTime.Now;
		}
	}
}
