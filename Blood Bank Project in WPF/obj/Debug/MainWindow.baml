   M S B A M L   `   `   `  ����T  PBlood Bank Project in WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Blood_Bank_Project_in_WPFBlood_Bank_Project_in_WPF  5   	   *    $Blood_Bank_Project_in_WPF.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:Blood_Bank_Project_in_WPF     5   	   -   5          � Title$  	BloodLine��5   	   $	��650��6   $
��1200��6(   $	��500��65   $	��650��6E    J� SnapsToDevicePixels .  � WindowStartupLocation$ CenterScreen=�6o    � Icon$ Media/System_Icon.ico��6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��6* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $	��18* �6   .+�5   
   �� $��Segoe UI)�6   $
��Wrap=�6*   $
��25px(�6>   $��Normal&�6N   
����d�
�������$��	BloodLine��6�    �� TextAlignment$ Center=�6�    � 5   
   $��1��6   $��0��6    
����d�$��20��6I   $	��Top=�6U   � 5   
   $��0��6   $��1��6   
����d� 5      �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    �� 5      $��1* �6    .+�5!      �� -   5         ��Name$ btn_home��5!      
����d� � Cursor$
 Hand��6D   $��1��6S   $
��Home��6`   $��Segoe UI)�6o   $
��20px(�6�   
���������6�   Z� �� 5"      -   5        $ btn_addDonor��5"      
����d�$
 Hand��6H   $��2��6V   $��	Add Donor��6c   
����d�$��Segoe UI)�6�   $
��20px(�6�   
�������6�   �� 5#      -   5        $ btn_donateBlood��5#      
����d�$
 Hand��6K   $��3��6Y   $��Donate Blood��6f   
����d�$��Segoe UI)�6�   $
��20px(�6�   
�������6�   �� 5$      -   5        $ btn_searchPerson��5$      
����d�$��4��6L   $
 Hand��6Y   $��Search Person��6g   
����d�$��Segoe UI)�6�   $
��20px(�6�   
�������6�   �� 5%      -   5        $ btn_viewAll��5%      
����d�$��5��6G   $��View All��6T   $
 Hand��6g   
����d�$��Segoe UI)�6�   $
��20px(�6�   
�������6�   �� 5&      -   5        $ 
btn_logout��5&      
����d�$��6��6F   $��Logout��6S   $
 Hand��6d   
����d�$��Segoe UI)�6�   $
��20px(�6�   
�������6�   �� 5'      -   5        $ 	btn_about��5'      
����d�$��7��6E   $��About��6R   $
 Hand��6b   
����d�$��Segoe UI)�6�   $
��20px(�6�   
�������6�   �� 5(      $��Active User:-��6   $��8��6-   $��0,25,0,0q�6:   $ Justify=�6L   $��Segoe UI)�6d   $
��15px(�6z   
�������6�   �� 5)      -	   5        	 ��Name$	 txt_activeUser��5)      $��9��60   $ Center=�6=   $��Farhad Akram��6T   $��Segoe UI)�6h   $
��20px(�6~   
�������6�   5*       � 5+   
   -
   5        
  �Name$
 
main_Frame��5+      $��1��6$   $��1��64     � NavigationUIVisibility$ Hidden=�6A   6c   5,      5-      