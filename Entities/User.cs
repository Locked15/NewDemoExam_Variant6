//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _41_размер.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int UserID { get; set; }
        public string UserSurname { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }

        /// <summary>
        /// Свойство-обертка для получения полного ФИО пользователя.
        /// </summary>
        public String FullName 
        { 
            get
            {
                return $"{UserSurname} {UserName} {UserPatronymic}";
            }
        }

        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int UserRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Role Role { get; set; }
    }
}