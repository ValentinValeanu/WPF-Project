   M S B A M L   `   `   `  ����F  BAssignment5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Assignment5.ViewAssignment5.View  5   	   '    !Assignment5.View.AddNewItemWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Assignment5.View     5   	     � 
ResizeMode$  CanMinimize=�5       � WindowStartupLocation$ CenterScreen=�63    � Title$ AddNewItemWindow��5   	   $	��220��6"   $	��250��6/   .��5	      � .+�5
   
   �� $��Title:��6   $��	10,10,0,0q�6!   $
��Left=�64   $	��Top=�6O   �� 5   
   $��25��6   $	��150��6   $
��Left=�6*   $	��Top=�6E   $��	60,10,0,0q�6]   ��6p   �� *
NewTitle+�� 5   
   $��Artist:��6   $��	10,40,0,0q�6"   $
��Left=�65   $	��Top=�6P   �� 5   
   $��25��6   $	��150��6   $
��Left=�6*   $	��Top=�6E   $��	60,40,0,0q�6]   ��6p   �� *	NewArtist+�� 5   
   $��Genre:��6   $��	10,70,0,0q�6!   $
��Left=�64   $	��Top=�6O   �� 5   
   $��25��6   $	��150��6   $
��Left=�6*   $	��Top=�6E   $��	60,70,0,0q�6]   ��6p   �� *
NewGenre+�� 5   
   $��
MediaType:��6   $��
10,100,0,0q�6%   $
��Left=�69   $	��Top=�6T   �� 5   
   $��25��6   $	��110��6   $
��Left=�6+   $	��Top=�6F   $��100,100,0,0q�6^    �� 
IsReadOnly . ��6s   �� *NewMediaTypes+ �� SelectedItem 6�   �� *SelectedNewMediaType+6�   �� 5   
   -   5        $	��Add��5      $��20��6   $��80��6+   $��Bottom=�66   $��0,0,0,15q�6Q   ��6c   �� *AddNewItemCommand+6�   5      5      