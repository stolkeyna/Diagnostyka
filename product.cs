using System;
using System.Collections.Generic;
using System.Text;

namespace Diagnostyka
{
	class Product
	{
		string name;
		float price;
		string category;

		// konstruktor inicjuje obiekt wartościami przekazanymi jako argumenty
		public Product(string name, float price, string category)
		{
			this.name = name;
			this.price = price;
			this.category = category;
		}
	}
}
