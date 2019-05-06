using System.ComponentModel.DataAnnotations.Schema;

namespace OracleConnectionApp.Models
{
    [Table("HR.Departments")]
    public partial class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentId { get; set; }

        public string Name { get; set; }

        public int ManagerId { get; set; }
    }
}
