using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvcCourse.Models
{
	public class Department
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<Seller> Sellers { get; set; } = new List<Seller>();  //ICollection de que<Seller> com propriedade Sellers e ja vai ser istanciada recebendo uma List do tipo Seller

		public Department()  //Precisa ciar um construtor default (vazio) pq vai ser criado logo a baixo o construtor com argumento
		{
		}

		public Department(int id, string name)  // construtor com argumento, foi criado usando o atalho(ferramenta) que fica no canto esquedo da linha, mas só usar o que for propriedade o que for do tipo enum nao é para criar (por exemplo que é uma coleção)
		{
			Id = id;
			Name = name;
		}

		public void AddSeller(Seller seller)
		{
			Sellers.Add(seller);
		}

		public double TotalSales(DateTime initial, DateTime final)
		{
			return Sellers.Sum(seller => seller.TotalSales(initial, final));
		}
	}
}
