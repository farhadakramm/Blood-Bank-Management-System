   M S B A M L   `   `   `  ����T  PBlood Bank Project in WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Blood_Bank_Project_in_WPFBlood_Bank_Project_in_WPF  5   	   /    )Blood_Bank_Project_in_WPF.Forget_Password   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Blood_Bank_Project_in_WPF     5   	     � Title$  Forget Password��5   	   $	��250��6!   $	��600��6.    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ NoResize=�6_    � Icon$ Media/System_Icon.ico��6u   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $
��1.2* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� $��Forget Password��6   $��0��6+   $��0��6;   
����d�$
��Wrap=�6d   
�������$��Segoe UI)�6�   $
��15px(�6�    �� TextAlignment$ Center=�6�    � 5   
   $��0��6   $��1��6    
����d�$��4��6I    � 5   
   $��1��6   $��0��6    $��2��6-   
����d�$	��5px��6]   $	��Top=�6j   �� 5   
   $��
Username: ��6   $��1��6&   $��0,5,0,0q�66   $��0��6G   $��Center=�6T   $��Right=�6o   $��Segoe UI)�6�   $
��15px(�6�   �� 5   
   $��E-Mail: ��6   $��1��6$   $��1��64   $��Center=�6A   $��Right=�6\   $��Segoe UI)�6x   $
��15px(�6�   �� 5   
   $��New Password: ��6   $��1��6*   $��2��6:   $��Center=�6G   $��Right=�6b   $��Segoe UI)�6~   $
��15px(�6�   �� 5   
   -   5         ��Name$ txt_name��5      $��30��6$   $	��300��60   $��0��6<   $��Center=�6I   $
��Left=�6d   $��2��6   $��0��6�   $��10,5,0,0q�6�   $��Segoe UI)�6�   $
��15px(�6�   �� 5   
   -   5        $ 	txt_email��5      $��30��6%   $	��300��61   $��1��6=   $��Center=�6J   $
��Left=�6e   $��2��6�   $��1��6�   $��10,0,0,0q�6�   $��Segoe UI)�6�   $
��15px(�6�   G� 5   
   -   5         G�Name$ txt_newPassword��5      $��30��6/   $	��300��6;   $��2��6G   $��Center=�6T   $
��Left=�6o   $��2��6�   $��2��6�   $��10,0,0,0q�6�   $
��20px(�6�   	 G� PasswordChar$	 *��6�   �� 5   
   -   5        
 ��Name$
 
btn_submit��5      $��30��6%   $��70��61   $��4��6<      Flat_Button#���   6I   $��Submit��6o   $��2��6�   $��4��6�   $��Right=�6�   $	��Top=�6�   $��0,5,30,0q�6�   6�   �� 5   
   -   5        $
 btn_back��5      $��30��6#   $��70��6/   $��5��6:   #���   6G   $
��Back��6m   $��2��6|   $��4��6�   $
��Left=�6�   $	��Top=�6�   $��10,5,0,0q�6�   6�   5       5!      