//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KontrolnayaRabotaPoWPF_var6
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public Nullable<int> GroupId { get; set; }
        public Nullable<int> TeacherId { get; set; }
        public Nullable<int> SubjectId { get; set; }
        public Nullable<int> CabinetId { get; set; }
        public Nullable<System.DateTime> LessonDate { get; set; }
    
        public virtual Cabinet Cabinet { get; set; }
        public virtual Groups Groups { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
