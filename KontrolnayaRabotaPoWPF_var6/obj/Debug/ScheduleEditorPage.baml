   M S B A M L   `   `   `  ����V  RKontrolnayaRabotaPoWPF_var6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:KontrolnayaRabotaPoWPF_var6KontrolnayaRabotaPoWPF_var6  5      4    .KontrolnayaRabotaPoWPF_var6.ScheduleEditorPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:KontrolnayaRabotaPoWPF_var6     5        N� Title$  ScheduleEditorPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��5q�6;   .+�5      �� -   5         ��Name$ GroupComboBox��5      $	��150��6.    �� DisplayMemberPath$ 	GroupName��6:    �� SelectedValuePath$ GroupId��6X   6t   �� 5      -   5        $ SubjectComboBox��5      $	��150��60   $ SubjectName��6<   $ 	SubjectId��6\   �� 5      -   5        $ TeacherComboBox��5      $	��150��60   $ TeacherName��6<   $ 	TeacherId��6\   �� 5      -   5        $! LessonCabinetNumberComboBox��5      $	��100��6<   $ Number_cabinet��6H   $ 	CabinetId��6k   �� 5      -   5        $��Добавить��5      $��10,0,0,0q�6@   �� 5      -   5        $��Удалить��5      $��10,0,0,0q�6B   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��5q�6;   .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ LessonDateCalendar��5      63   �� 5      .+�5       �� $��Lesson Number:��6   �� 5!      -   5        $ LessonNumberComboBox��5!      $	��100��69   ��6E   �� *LessonNumbers+�� 5"      -	   5        $	��Add��5"      6'   5#      5$      &   System.Windows.Controls.DataGrid  5'   
   -
   5          Name$ ScheduleDataGrid��5'       $��1��6      AutoGenerateColumns .  $��311,17,10,18q�6V   	   Columns	 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Group��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Group.GroupName+  5*      $
 Subject��6%    66   �� *Subject.SubjectName+  5+      $
 Teacher��6%    66   �� *Teacher.TeacherName+  5,      $
 Cabinet��6%    66   �� *Cabinet.Number_cabinet+  5-      $
 Lesson Date��6%    6:   �� *
LessonDate+  5.      $
 Lesson Number��6%    6<   �� *LessonNumber+50      51      52      