using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvcCourse.Models
{
	public class Seller
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }
		public double BaseSalary { get; set; }
		public Department Department { get; set; }
		public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();  //ICollection de que<SellesRecord> com propriedade Seles e ja vai ser istanciada recebendo uma List do tipo SelesRecord

		public Seller()  //Precisa ciar um construtor default (vazio) pq vai ser criado logo a baixo o construtor com argumento
		{
		}

		public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)  // construtor com argumento, foi criado usando o atalho(ferramenta) que fica no canto esquedo da linha, mas só usar o que for propriedade o que for do tipo enum nao é para criar (por exemplo que é uma coleção)
		{
			Id = id;
			Name = name;
			Email = email;
			BirthDate = birthDate;
			BaseSalary = baseSalary;
			Department = department;
		}

		public void AddSales(SalesRecord sr)
		{
			Sales.Add(sr);
		}

		public void RemoveSales(SalesRecord sr)
		{
			Sales.Remove(sr);
		}

		public double TotalSales(DateTime Initial, DateTime final) // total de vendas de um vendedor em um periodo de datas
		{
			return Sales.Where(sr => sr.Date >= Initial && sr.Date <= final).Sum(sr => sr.Amount); //expressão lambda + linq
		}

	}
}
