   M S B A M L   `   `   `  ����@  <Tours, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ToursTours  5          Tours.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Tours     5        N� Title$  AddEditPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   6.   �� 5      $��* �6#   5       � RowDefinitions 5   
   �� 5      $��* �6   5      �� 5      $��* �6   5      �� 5      $��* �6   5      �� 5       $��* �6   5!      .+�5#   
   �� $�� Название��6   6(   �� 5$   
   $&��  Количество звёзд��6   $��1��6-   �� 5%   
   $�� Страна��6   $��2��6#   �� 5&   
    �� 	MaxLength$	 100��60   $��1��6A   $��2��6N   ��6   �� *CountOfStars+6N   �� 5'   
   $	��379��6(   $
��Left=�64   $��2��6O   ��6   �� *Name+6O   �� 5(   
   -   5         ��Name$ ComboCountries��5(   Q   $��2��64   $��1��6A    �� DisplayMemberPath$
 Name��6i    �� SelectedItem 6   �� *	Country+6�   �� 5*   
   -   5        $��BtnSave��5*   2   $��Сохранить��6   $��3��6%   $��2��6W   $
��Auto��6h   $
��Auto��6v   5,      5-      