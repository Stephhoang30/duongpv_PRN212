   M S B A M L   `   `   `  ����J  FPRN221_Trial_02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PRN221_Trial_02PRN221_Trial_02  5   	        PRN221_Trial_02.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PRN221_Trial_02     5   	     � Title$  EmployeeWindow��5   	   $	��800��6    $	��800��6-   .��5	      � .+�5
   
   �� $��0,0,400,380q�6   
����ح�.+�5      �� $��Employee Information��6   $��18(�64   
���  ��$
��Bold"�6S   �� 5      $��Employee Id��6   6-   �� 5      -   5        $	��eid��5   "   $��5q�6   ${�False��6-   ��6?   �� *
EmployeeId+ � DataContext 6[   �� *SelectedItem+ �� ElementName$ listView���� 5      $��	FirstName��6   6*   �� 5      -   5        $��	firstname��5   "   $��5q�6   ��63   �� *	FirstName+ 6N   �� *SelectedItem+$ listView���� 5      $��LastName��6   6)   �� 5      -   5        $��lastname��5   "   $��5q�6   ��62   �� *
LastName+ 6L   �� *SelectedItem+$ listView���� 5      $��
Department��6   6+   �� 5      -   5        $��
department��5   >   $	��120��6   $
��Left=�6#    �� SelectedValuePath$ DepartmentId��6P   �� 5      $��Title��6   6&   �� 5      -   5         ��Name$ title��5      $��5q�6%   ��61   �� *Title+ 6H   �� *SelectedItem+$ listView���� 5      $��Title of Courtesy��6   62   �� 5      -   5         ��Name$ titleOfCourtesy��5      $��54��60   $
��Left=�6;   �� 5       $��	Birthdate��6   6*   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$	 dob��5!         Text 6&   �� *	BirthDate+ 6A   �� *SelectedItem+$ listView��5#      �� 5%   
    �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��10,395,10,0q�6a   .+�5&      �� -   5        $��bRefresh��5&   I   $��Refresh��6   $��80��6'   $��5q�62   $��5q�6=   6r   �� 5'      -	   5        	 ��Name$
	 bAdd��5'   E   $	��Add��6   $��80��6#   $��5q�6.   $��5q�69   6S   �� 5(      -
   5        $��bEdit��5(   G   $
��Edit��6   $��80��6$   $��5q�6/   $��10q�6:   6j   5)      �� 5+   
   -   5        $��listView��5+   &   $��	0,447,0,0q�6   
 �� View
 5,      �� 5-      .P�5.      �� $��
EmployeeID��6%    �� Width$ 80��69    �� DisplayMemberBinding 6D   ��  �� Path$ 
EmployeeId�6w   �� 5/      $��	FirstName��6%   $	 100��68    6D   �� $ 	FirstName�6v   �� 50      $��LastName��6%   $	 120��67    6C   �� $ LastName�6t   �� 51      $��
Department��6%   $ 80��69    6D   �� $ DepartmentId�6y   �� 52      $��Title��6%   $	 140��64    6@   �� $ Title�6n   �� 53      $��TitleOfCourtesy��6%   $	 100��6>    6J   �� $ TitleOfCourtesy�6�   �� 54      $��	Birthdate��6%   $	 190��68    6D   �� $ 	BirthDate�6v   55      57      59      5:      