   M S B A M L   `   `   `  ����L  HOguzhan.Scrum.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Oguzhan.Scrum.WPFOguzhan.Scrum.WPF  5   	   $    Oguzhan.Scrum.WPF.NewStoryView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Oguzhan.Scrum.WPF     5   	     � Title$  NewStoryView��5   	   $��191.949��6   $��267.585��6/    � WindowStartupLocation$ CenterScreen=�6?    � 
ResizeMode$ NoResize=�6d    � WindowStyle$
 None=�6z   .��5	      � -   5         �Name$ ElementList��5	       � RowDefinitions 5
   
   �� 5      �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� -   5         ��Name$ txt_NewStory��5       �� TextWrapping$
 Wrap=�6(   ��6<   �� *
NewStory+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��datePicker1��5   <   $��52��6   $
��Left=�6!   $��1��6O   $	��Top=�6\   $	��268��6t   
   Text
 6�   �� *NewStorydate+$ TwoWay=�$	 PropertyChanged=��� 5   
   -   5         ��Name$ btn_Add��5      $
��EKLE��6"   $��2��61   6>   5      5      