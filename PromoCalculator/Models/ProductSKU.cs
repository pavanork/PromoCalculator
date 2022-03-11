using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoCalculator.Models
{
	public class ProductSKU
	{
		public ProductSKU(char skuId)
		{
			SKUId = skuId;
		}

		public char SKUId { get; set; }
		public int Price { get; set; } = 0;


	}
}
