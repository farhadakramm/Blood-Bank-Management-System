   M S B A M L   `   `   `  ����T  PBlood Bank Project in WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Blood_Bank_Project_in_WPFBlood_Bank_Project_in_WPF  5   	   ,    &Blood_Bank_Project_in_WPF.Login_Screen   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Blood_Bank_Project_in_WPF     5   	     � Title$  Login��5   	   $	��250��6   $	��500��6$    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U    � WindowStyle$ SingleBorderWindow=�6k    � Icon$ Media/System_Icon.ico��6�   .��5	      �  +� FocusedElement 6   ��  �� ElementName$ txt_name�� � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��3* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
    � $��1��6   $��0��6    $��2��6-   $	��5px��6A   
����d�$	��Top=�6j   �� 5   
   $��Login��6   $��Segoe UI)�6!   $
��25px(�67   	 �� TextAlignment$	 Center=�6G   
�������
����d�$��0��6�   $��0��6�    � 5   
   $��0��6   $��1��6    $��3��6-   
����d�6>   � 5   
   $��0��6   $��4��6   
����d�.+�5      �� -   5        
 ��Name$
 
btn_signup��5      $��Sign Up��6)   $��Bottom=�6;   $��4��6V   $��Center=�6d   
�������   ButtonOverBlueButtonStyle#���   6�   6�   5      �� 5   
   $��	Username:��6   $��1��6%   $��1��65   $��Segoe UI)�6B   $
��18px(�6X   $��Right=�6h   $��Center=�6�   �� 5   
   $��	Passowrd:��6   $��1��6%   $��2��65   $��Segoe UI)�6B   $
��18px(�6X   $��Right=�6h   $��Center=�6�   �� 5   
   -   5         ��Name$ txt_name��5      $��2��6$   $��1��64   $��0��6A   $
��Left=�6N   $��30��6i   $	��250��6u   $��Segoe UI)�6�   $
��20px(�6�   $��Center=�6�   $��10,0,0,0q�6�   G� 5   
   -   5         G�Name$ txt_pass��5      $��2��6(   $��2��68   $
��Left=�6E   $��1��6`   $��30��6m   $	��250��6y    G� PasswordChar$ *��6�   $
��20px(�6�   $��Center=�6�   $��10,0,0,0q�6�   �� 5   
   -   5        $
 btn_forgetpass��5      
������ 
������ $��Forget Password��6\   $��3��6v   $��1��6�   $��3��6�   $��Roboto)�6�   $��11(�6�   $��Center=�6�   $��Bottom=�6�     Flat_Button#���  6�   6   �� 5    
   -   5        $
 
btn_signin��5       $��Sign In��6%   $��2��67   $��3��6G   $��Right=�6T   $��2��6p   $��	0,0,28,29q�6}   
������ #���  6�   $��26��6�   
������ $��Bottom=�6  5!      5"      