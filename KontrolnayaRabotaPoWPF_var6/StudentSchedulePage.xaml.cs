using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace KontrolnayaRabotaPoWPF_var6
{
    public partial class StudentSchedulePage : Page
    {
        private MaslovD_SturinAEntities3 db;

        public StudentSchedulePage()
        {
            InitializeComponent();
            db = new MaslovD_SturinAEntities3();
            LoadGroups();
        }

        private void LoadGroups()
        {
            var groups = db.Groups.ToList();
            groupComboBox.ItemsSource = groups;
            groupComboBox.DisplayMemberPath = "GroupName";
        }


        

        private void groupComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (groupComboBox.SelectedItem is Groups selectedGroup)
            {
                int groupId = selectedGroup.GroupId;

                var schedule = (from s in db.Schedule
                                join g in db.Groups on s.GroupId equals g.GroupId
                                join t in db.Teachers on s.TeacherId equals t.TeacherId
                                join sub in db.Subjects on s.SubjectId equals sub.SubjectId
                                where s.GroupId == groupId
                                select new
                                {
                                    s.LessonDate,
                                    TeacherName = t.TeacherName,
                                    SubjectName = sub.SubjectName,
                                    s.Cabinet // Включаем столбец "Кабинет"
                                }).ToList();

                scheduleDataGrid.ItemsSource = schedule;
            }
        }
    }
}
