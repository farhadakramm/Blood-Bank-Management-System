   M S B A M L   `   `   `  ����T  PBlood Bank Project in WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Blood_Bank_Project_in_WPFBlood_Bank_Project_in_WPF  5   	   &     Blood_Bank_Project_in_WPF.SignUp   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Blood_Bank_Project_in_WPF     5   	   X TXceed.Wpf.Toolkit, Version=2.9.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Sign Up��5	   	   $	��330��6   $	��600��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � Icon$ Media/System_Icon.ico��6m   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $
��1.2* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Sign Up��6   $��0��6#   $��0��63   
����d�$
��Wrap=�6\   
�������$��Segoe UI)�6�   $
��20px(�6�    �� TextAlignment$ Center=�6�    � 5   
   $��0��6   $��1��6    
����d�$��5��6I    � 5   
   $��1��6   $��0��6    $��2��6-   
����d�$	��5px��6]   $	��Top=�6j   �� 5   
   $��
Username: ��6   $��1��6&   $��0��66   $��Center=�6C   $��0,10,0,0q�6^   $��Right=�6p   $��Segoe UI)�6�   $
��15px(�6�   �� 5   
   $��Mobile No: ��6   $��1��6'   $��1��67   $��Center=�6D   $��Right=�6`   $��Segoe UI)�6|   $
��15px(�6�   $��	0,10,0,10q�6�   �� 5   
   $��E-Mail: ��6   $��1��6$   $��2��64   $��	0,10,0,10q�6A   $��Center=�6T   $��Right=�6o   $��Segoe UI)�6�   $
��15px(�6�   �� 5   
   $��
Password: ��6   $��1��6&   $��3��66   $��Center=�6C   $��Right=�6^   $��Segoe UI)�6z   $
��15px(�6�   �� 5   
   -   5         ��Name$ txt_name��5      $��30��6$   $	��300��60   $��Center=�6<   $��	10,10,0,0q�6W   $��0��6j   $
��Left=�6w   $��2��6�   $��0��6�   $��Segoe UI)�6�   $
��20px(�6�   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ 
txt_mobile��5   1   	   Mask$	 0000-0000000��6   $��30��6E   $	��300��6Q   $��Center=�6]   $��1��6x   $
��Left=�6�   $��2��6�   $��1��6�   $��10,0,0,0q�6�   $��Segoe UI)�6�   $
��20px(�6�   �� 5    
   -   5        $ 	txt_email��5       $��30��6%   $	��300��61   $��Center=�6=   $
��Left=�6X   $��2��6s   $��2��6�   $��2��6�   $��10,0,0,0q�6�   $��Segoe UI)�6�   $
��20px(�6�   G� 5!   
   -   5        
 G�Name$
 txt_password��5!      $��30��6,   $	��300��68   $��Center=�6D   $
��Left=�6_   $��3��6z   $��2��6�   $��3��6�   $��10,0,0,0q�6�   $
��20px(�6�    G� PasswordChar$ *��6�   �� 5"   
   -   5         ��Name$ 
btn_submit��5"      $��30��6%   $��70��61      Flat_Button#���   6<   $��Submit��6b   $��2��6s   $��5��6�   $��5��6�   $��Right=�6�   $	��Top=�6�   $��0,0,30,0q�6�   6�   �� 5#   
   -   5        $ btn_back��5#      $��30��6#   $��70��6/   #���   6:   $
��Back��6`   $��2��6o   $��5��6   $��6��6�   $
��Left=�6�   $	��Top=�6�   $��10,0,0,0q�6�   6�   5$      5%      