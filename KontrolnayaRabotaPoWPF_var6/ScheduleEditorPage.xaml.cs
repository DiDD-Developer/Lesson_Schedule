using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace KontrolnayaRabotaPoWPF_var6
{
    public partial class ScheduleEditorPage : Page
    {
        private MaslovD_SturinAEntities3 db = new MaslovD_SturinAEntities3();
        private List<int> lessonNumbers;

        public List<int> LessonNumbers
        {
            get { return lessonNumbers; }
            set { lessonNumbers = value; }
        }

        public ScheduleEditorPage()
        {
            InitializeComponent();

            // Загрузка данных в комбобоксы
            GroupComboBox.ItemsSource = db.Groups.ToList();
            SubjectComboBox.ItemsSource = db.Subjects.ToList();
            TeacherComboBox.ItemsSource = db.Teachers.ToList();
            LessonCabinetNumberComboBox.ItemsSource = db.Cabinet.ToList();

            // Создание списка номеров уроков
            LessonNumbers = new List<int> { 1, 2, 3, 4, 5 };
            LessonNumberComboBox.ItemsSource = LessonNumbers;

            // Загрузка расписания
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            var groups = db.Groups.ToList();
            GroupComboBox.ItemsSource = groups;
            GroupComboBox.DisplayMemberPath = "GroupName";
        }

        private void LessonDateCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            // Обработчик события выбора даты
            // Можно добавить дополнительную логику при необходимости
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Обработчик события клика по кнопке "Add"

            // Проверка выбранных значений
            if (GroupComboBox.SelectedItem == null || SubjectComboBox.SelectedItem == null ||
                TeacherComboBox.SelectedItem == null || LessonCabinetNumberComboBox.SelectedItem == null ||
                LessonNumberComboBox.SelectedItem == null || LessonDateCalendar.SelectedDate == null)
            {
                MessageBox.Show("Please select all values!");
                return;
            }

            // Создание новой записи расписания
            Schedule newSchedule = new Schedule()
            {
                GroupId = ((Groups)GroupComboBox.SelectedItem).GroupId,
                SubjectId = ((Subjects)SubjectComboBox.SelectedItem).SubjectId,
                TeacherId = ((Teachers)TeacherComboBox.SelectedItem).TeacherId,
                CabinetId = ((Cabinet)LessonCabinetNumberComboBox.SelectedItem).CabinetId,
                LessonDate = (DateTime)LessonDateCalendar.SelectedDate
            };

            // Добавление записи в базу данных
            db.Schedule.Add(newSchedule);
            db.SaveChanges();

            // Обновление отображения расписания
            LoadSchedule();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GroupComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (GroupComboBox.SelectedItem is Groups selectedGroup)
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

                ScheduleDataGrid.ItemsSource = schedule;
            }
        }
    }
}
