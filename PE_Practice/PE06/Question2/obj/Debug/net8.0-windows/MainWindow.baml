   M S B A M L   `   `   `  ����D  @Question2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Question2	Question2  5   	       Question2.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Question2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Id��6   $
��Left=�6   $��546,124,0,0q�68   $	��Top=�6M   �� 5   
   $
��Name��6   $
��Left=�6   $��542,150,0,0q�6:   $	��Top=�6O   �� 5   
   $	��Sex��6   $
��Left=�6   $��545,176,0,0q�69   $	��Top=�6N   �� 5   
   $	��DOB��6   $
��Left=�6   $��542,202,0,0q�69   $	��Top=�6N   �� 5   
   $��Position��6   $
��Left=�6#   $��537,233,0,0q�6>   $	��Top=�6S   �� 5   
   -   5         ��Name$ 
btnRefresh��5      $��Refresh��6%   $
��Left=�67   $��559,288,0,0q�6R   $	��Top=�6g   6   �� 5   
   -   5        $ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��638,288,0,0q�6J   $	��Top=�6_   6w   �� 5   
   -   5        $ btnEdit��5      $
��Edit��6"   $
��Left=�61   $��702,288,0,0q�6L   $	��Top=�6a   6y   �� 5   
   -   5         ��Name$ tbName��5      $
��Left=�6"   $��628,154,0,0q�6=    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��120��6~   	� 5   
   -   5         	�Name$
 male��5      $
��Male��6$   $
��Left=�63   $��628,185,0,0q�6N   $	��Top=�6c   	� 5   
   -   5        $ female��5      $��Female��6&   $
��Left=�67   $��686,185,0,0q�6R   $	��Top=�6g   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$	 DOB��5      $
��Left=�6"   $��628,208,0,0q�6=   $	��Top=�6R   $	��120��6j   �� 5   
   -   5         ��Name$ cbPos��5      $
��Left=�6"   $��628,237,0,0q�6=   $	��Top=�6R   $	��120��6j   &   System.Windows.Controls.DataGrid  5   
   -	   5          Name$ dataGrid��5      $��0,113,292,0q�6%      AutoGenerateColumns$
 True��5      	   CanUserAddRows$	 False��5      $��Stretch=�5      $��Stretch=�5      �� 5   
   -
   5        $
 tbID��5      $
��Left=�6    $��628,128,0,0q�6;   $
 Wrap=�6P   $	��Top=�6d   $	��120��6|   ${�False��6�   5      5       