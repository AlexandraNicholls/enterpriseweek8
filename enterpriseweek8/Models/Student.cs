namespace enterpriseweek8.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public int StudentID { get; set; }

        //NEVER modify the model to be out of sync with the database!!
        [Required]
        [StringLength(50)]
        //make a more pleasing name for the table
        [Display (Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        [Display (Name = "First Name")]
        public string FirstMidName { get; set; }

        [Column(TypeName = "date")]
        [Display (Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
