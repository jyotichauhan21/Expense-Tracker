using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
	public class Category
	{
		public int CategoryId { get; set; }

		[Column(TypeName ="nvarchar(50)")]

        [Required]
		public string Title { get; set; }

		[Column(TypeName = "nvarchar(5)")]

		public string Icon { get; set; } = "";

		[Column(TypeName = "nvarchar(10)")]
		public string Type { get; set; } = "Expense";

		[NotMapped]
		public string? TitleWithIcon
		{
			get
			{
				return this.Icon + " " + this.Title;
			}
		}
	}
}
