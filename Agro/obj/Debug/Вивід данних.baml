   M S B A M L   `   `   `  ����?  ;Agro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AgroAgro  5   	   "    Agro.Вивід_данних   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Agro     5   	   -   5          � Title$  Вивід_данних��5	   	   $��470.318��6   $��849.159��6/    � WindowStartupLocation$ CenterScreen=�6?   .��5
      � $
��Left=�6   $	��813��6&   $��	10,0,0,-1q�62    � RowDefinitions 5   
   �� 5      $	��412 �6    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5        $1��+Маса урожаю для культур��5      ���	#FF78ECF1$
��Left=�6J   $��
499,74,0,0q�6e   $	��Top=�6y   $	��253��6�   $��40��6�   6�   �� 5   
   -   5        $O��IКультури, які не були посіяні цього року��5      ���	#FF78ECF1$
��Left=�6[   $��499,310,0,0q�6v   $	��Top=�6�   $	��253��6�   $��40��6�   6�   �� 5   
   -   5        $)��#Кількість поставок��5      ���	#FF78ECF1$
��Left=�6E   $��499,142,0,0q�6`   $	��Top=�6u   $	��253��6�   $��40��6�   6�   �� 5   
   -   5        $H��BРейтинг культур по кількості врожаю��5      ���	#FF78ECF1$
��Left=�6V   $��499,222,0,0q�6q   $	��Top=�6�   $	��253��6�   $��40��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��grid1��5      $
��Left=�6    $	��276��6;   $��	32,74,0,0q�6H   $	��Top=�6[   $	��363��6s   6   �� 5   
   -   5        $
��Left=�5      $��
0,355,0,-5q�6-   $	��Top=�6A   $	��140��6Y   $��63��6�   ��6e   Z� ��6{   Z� .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $5��/C:\Users\Виктория\Downloads\strelka.png��6   $��0,0,5,0q�6I   �� 5      5      5      5      5      