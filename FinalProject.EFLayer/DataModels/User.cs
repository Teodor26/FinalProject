//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject.EFLayer.DataModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Admins = new HashSet<Admin>();
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
        }
    
        public int Id { get; set; }

        [Required(ErrorMessage = "���������� ���")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "���������� �������")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "��������� �����")]
        public string Login { get; set; }
        [Required(ErrorMessage = "��������� ������")]
        public string Password { get; set; }
        public int UserTypeId { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admin> Admins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual UserType UserType { get; set; }
    }
}
