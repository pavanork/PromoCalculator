using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoCalculator.Models
{
	public class ProductSKU
	{
		public ProductSKU(string skuId)
		{
			SKUId = skuId;
		}

		public string SKUId { get; set; }
		//public int Price { get => FetchPriceBySKU(SKUId); }

		/*private int FetchPriceBySKU(char skuId)
		{
			switch (SKUId)
			{
				case 'A':
					return 50;
				case 'B':
					return 30;
				case 'C':
					return 20;
				case 'D':
					return 15;
				default:
					return 0;
			}
		}*/
	}
}
