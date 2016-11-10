using System.ComponentModel.DataAnnotations;            // For [Key]
using System.ComponentModel.DataAnnotations.Schema;     // For [Table], [Column]

namespace SM.Lunchinator.Data.Entities
{
	/// <summary>
	/// The definition for the Restaurant table.  (do not pluralize table names)
	/// </summary>
	[Table("Person")]								// DBA's prefer singular. (EF pluralizes by default)
	public class Person
    {
		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		[Column(TypeName = "varchar(64)")]          // DBA's compained about using "nvarchar(max)" as default.
		public string FirstName { get; set; }

		[Required]
		[Column(TypeName = "varchar(64)")]          // DBA's compained about using "nvarchar(max)" as default.
		public string LastName { get; set; }

		[Required]
		[Column(TypeName = "varchar(128)")]          // DBA's compained about using "nvarchar(max)" as default.
		public string Email { get; set; }
	}
}