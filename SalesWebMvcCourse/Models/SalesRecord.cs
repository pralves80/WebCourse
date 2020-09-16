using SalesWebMvcCourse.Models.Enuns;
using System;

namespace SalesWebMvcCourse.Models
{
	public class SalesRecord
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public double Amount { get; set; }
		public SaleStatus Status { get; set; }
		public Seller Seller { get; set; }

		public SalesRecord() //Precisa ciar um construtor default (vazio) pq vai ser criado logo a baixo o construtor com argumento
		{
		}

		public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)  // construtor com argumento, foi criado usando o atalho(ferramenta) que fica no canto esquedo da linha, mas só usar o que for propriedade o que for do tipo enum nao é para criar (por exemplo que é uma coleção)
		{
			Id = id;
			Date = date;
			Amount = amount;
			Status = status;
			Seller = seller;
		}
	}
}
