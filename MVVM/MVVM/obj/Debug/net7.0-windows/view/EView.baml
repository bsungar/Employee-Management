   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:MVVM.view	MVVM.view  5      /clr-namespace:MVVM.viewmodelMVVM.viewmodel  64       MVVM.view.EView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:MVVM.view     5      2	viewmodelclr-namespace:MVVM.viewmodel     64   $	��500��5      $	��525��6,   .��5      � $��5,8,5,8q�6     � ColumnDefinitions  5	   
   �� 5
      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   .+�5   
   �� $��Employee Management��6   $��0��6/   $��0��6?   $��2��6L   $��30(�6`   
����+��$��UltraExpanded&�6�   $��Center=�6�   $��Center=�6�   $��5,8,5,8q�6�   6�   �� 5   
   $��
Enter ID: ��6   $��0��6&   $��1��66   $��Center=�6C   $
��Left=�6^   
����� �6�   �� 5   
   $��Enter Name: ��6   $��0��6(   $��2��68   $��Center=�6E   $
��Left=�6`   
����� �6�   �� 5   
   $��Enter Age: ��6   $��0��6'   $��3��67   $��Center=�6D   $
��Left=�6_   
����� �6�   �� 5   
   -   5         ��Name$ txtboxID��5      $��1��6W   $��1��6g   $��5,8,5,8q�6u   ��6$   ��  �� Path$  CurrentEmployee.EmployeeID�6�   �� 5   
   -   5        $ 
txtboxname��5      $��2��6[   $��2��6k   $��5,8,5,8q�6x   ��6&   �� $" CurrentEmployee.EmployeeName�6�   �� 5   
   -   5        $ 	txtboxage��5      $��3��6Z   $��3��6j   $��5,8,5,8q�6w   ��6%   �� $! CurrentEmployee.EmployeeAge�6�   �� 5    
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��1��6;   $��5,8,5,8q�6K   .+�5!      �� -   5         ��Name$ btnadd��5!      $	��ADD��6%   $��80��63   $��50��6>   $��5,8,5,8q�6p   ��6J   �� $ saveCommand�6�   �� 5"      -   5        $ 	btnsearch��5"      $��SEARCH��6(   $��80��6`   $��50��6k   $��5,8,5,8q�6w   ��69   �� $ SearchCommand�6�   �� 5#      -   5        $ btndel��5#      $��DELETE��6%   $��80��66   $��50��6h   $��5,8,5,8q�6t   ��6A   �� $ DeleteCommand�6�   �� 5$      -   5        $ 	btnupdate��5$      $��UPDATE��6(   $��80��69   $��50��6D   $��5,8,5,8q�6x   ��6P   �� $ updateEmployee�6�   5&      �� 5'   
   -   5         ��Name$ 
txtMessage��5'      $��5��6F   $��1��6S   $��5,8,5,8q�6c   ��6(   �� $ Message�6v   �� 5(   
   $��6��6   $��1��6$   $��5,8,5,8q�64   $	��150��6E   .��5)      &   System.Windows.Controls.DataGrid  -	   5          Name$ dataEmployees��5)         AutoGenerateColumns$ False��6.   ��6J   �� $ EmployeeLists�	   Columns	 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Employee Id��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6K   �� $ 
EmployeeID�6q     5,      $
 Employee Name��6)   $
 auto 6@    6M   �� $ EmployeeName�6u     5-      $
 Employee Age��6)   $
 auto 6?    6L   �� $ EmployeeAge�6s   50      51      52      53      