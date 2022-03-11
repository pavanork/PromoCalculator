using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PromoCalculator.Models;

namespace PromoCalculator.Service
{
	/*
	public class promotion
	{
		public promotion(char sKUId, int count, int comboPrice)
		{
			SKUId = sKUId;
			this.count = count;
			ComboPrice = comboPrice;
		}

		public char SKUId { get; set; }
		public int count { get; set; }
		public int ComboPrice { get; set; }
	}*/

	public class PriceCalculator
	{
		// commented this part there is a combination of C&D instead of each counter, 
		//private static readonly List<promotion> activePromotions = new List<promotion> { new promotion('A', 3, 130), new promotion('B', 2, 45), new promotion('C', 1, 30), new promotion('D', 1, 30) };


		public int EvaluatedPriceOfCart(List<ProductSKU> items)
		{
			int finalPrice = 0, aLength = 0, bLength = 0, cLength = 0, dLength = 0;
			int aPrice = 0, bPrice = 0;

			foreach (ProductSKU s in items)
			{
				if (s != null && s.SKUId.Equals("A")) aLength++;
				else if (s != null && s.SKUId.Equals("B")) bLength++;
				else if (s != null && s.SKUId.Equals("C")) cLength++;
				else if (s != null && s.SKUId.Equals("D")) dLength++;
			}
			aPrice = aLength>0?((aLength / 3) * 130) + ((aLength % 3) * 50):0;
			bPrice = bLength > 0 ? ((bLength / 2) * 45) + ((bLength % 2) * 30):0;
			//cPrice = ((cLength / 3) * 130) + ((cLength % 3) + 50);
			//dPrice = ((dLength / 3) * 130) + ((dLength % 3) + 50);

			int cdMin = Math.Min(cLength, dLength);
			//int cdMax = Math.Max(cLength, dLength);
			int cdPrice = ((cdMin % 2) * 30) + ((cLength - cdMin) * 20) + ((dLength - cdMin) * 15);			

			finalPrice = aPrice + bPrice + cdPrice;
			return finalPrice;
		}

	}
}
