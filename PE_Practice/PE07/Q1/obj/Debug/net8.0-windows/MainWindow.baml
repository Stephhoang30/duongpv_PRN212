   M S B A M L   `   `   `  ����=  9Q1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Q1Q1  5   	       Q1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:Q1     5   	     � Title$  
MainWindow��5   	   $	��800��6   $	��800��6)   .��5	      � .+�5   
   �� $
��Left=�6   $��	25,14,0,0q�6/   $
��Wrap=�6B   $��	Add Stars��6V   $	��Top=�6g   $��20(�6   �� 5   
   $��star's name��6   $
��Left=�6&   $��	24,46,0,0q�6A   $	��Top=�6T   �� 5   
   -   5         ��Name$ txbStarName��5      $
��Left=�6'   $��	24,89,0,0q�6B    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��196��6�   �� 5   
   $��gender��6   $
��Left=�6!   $��
25,112,0,0q�6<   $	��Top=�6P   	� 5   
   -   5         	�Name$ rdMale��5      $
��Male��6&   $
��Left=�65   $��
25,149,0,0q�6P   $	��Top=�6d   	� 5   
   -   5        $ rdFemale��5      $��Female��6(   $
��Left=�69   $��
84,149,0,0q�6T   $	��Top=�6h   �� 5   
   $��
DatePicker��6   $
��Left=�6%   $��
25,169,0,0q�6@   $	��Top=�6T   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePicker��5      $
��Left=�6)   $��
24,195,0,0q�6D   $	��Top=�6X   $	��196��6p   �� 5   
   $��Nationality��6   $
��Left=�6&   $��
25,224,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ cbNation��5      $
��Left=�6%   $��
25,250,0,0q�6@   $	��Top=�6T   $	��195��6l   �� 5   
   -   5         ��Name$ btnAdd��5      $��Add To Below��6!   $
��Left=�68   $��
25,302,0,0q�6S   $	��Top=�6g   6   �� 5   
   -   5        $ 	btnImport��5      $��Import From F��6$   $
��Left=�6<   $��122,302,0,0q�6W   $	��Top=�6l   6�   �� 5   
   -   5        $ btnSave��5      $��Save To File��6"   $
��Left=�69   $��236,302,0,0q�6T   $	��Top=�6i   6�   �� 5   
   -	   5         ��Name$ listView��5      $��	0,337,0,0q�6&    �� View 5      �� 5      .P�5      �� $��FullName��6%   	 �� Width$		 150��67   
 �� DisplayMemberBinding
 6C   ��  �� Path$
 Name��� 5      $��Gender��6%   $		 100��65   
 6A   �� $ Gender��� 5      $	��Dob��6%   $		 100��62   
 6>   �� $	 Dob��� 5      $��Nationality��6%   $		 100��6:   
 6F   �� $ Nationality�5       5"      �� 5#   
   -
   5        $ 
btnAddJson��5#      $��Add To Json��6%   $
��Left=�6;   $��338,302,0,0q�6V   $	��Top=�6k    � Cursor$  ��6�   6�   �� 5$   
   -   5        $ txbPath��5$      $
��Left=�6#   $��283,250,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��137��6   ${�False��6�   $��31��6�   5(      5)      