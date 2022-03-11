using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PromoCalculator.Models;
using PromoCalculator.Service;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
	public static class extended {
		public static void AddRepeated<T>(this List<T> self, T item, int count)
		{
			var temp = Enumerable.Repeat(item, count);
			self.AddRange(temp);
		}

	}

	[TestClass]
	public class UnitTest1
	{
		
		[TestMethod]
		public void TestScenario1()
		{
			List<ProductSKU> cart = new List<ProductSKU>();
			cart.Add(new ProductSKU('A'));
			cart.Add(new ProductSKU('B'));
			cart.Add(new ProductSKU('C'));
			//cart.Add(new ProductSKU('D'));

			PriceCalculator pCalc = new PriceCalculator();
			int price=pCalc.EvaluatedPriceOfCart(cart);

			Assert.Equals(100,price);
		}

		[TestMethod]
		public void TestScenario2()
		{
			List<ProductSKU> cart = new List<ProductSKU>();
			cart.AddRepeated(new ProductSKU('A'),5);
			cart.AddRepeated(new ProductSKU('B'), 5);
			cart.Add(new ProductSKU('C'));
			//cart.Add(new ProductSKU('D'));

			PriceCalculator pCalc = new PriceCalculator();
			int price = pCalc.EvaluatedPriceOfCart(cart);

			Assert.Equals(370, price);
		}

		[TestMethod]
		public void TestScenario3()
		{
			List<ProductSKU> cart = new List<ProductSKU>();
			cart.AddRepeated(new ProductSKU('A'), 3);
			cart.AddRepeated(new ProductSKU('B'), 5);
			cart.Add(new ProductSKU('C'));
			cart.Add(new ProductSKU('D'));

			PriceCalculator pCalc = new PriceCalculator();
			int price = pCalc.EvaluatedPriceOfCart(cart);

			Assert.Equals(280, price);
		}

		[TestMethod]
		public void TestScenario4()
		{
			PriceCalculator pCalc = new PriceCalculator();
			int skuPrice = pCalc.FetchPriceBySKU(new ProductSKU('A'));

			Assert.Equals(50, skuPrice);

		}

		
	}
}
