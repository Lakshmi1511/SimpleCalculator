   M S B A M L   `   `   `  ����E  ACalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Calculator
Calculator  5   	       Calculator.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   $localclr-namespace:Calculator  5   	     � Title$  
Calculator��5	   	   $��317.7��6   $��287.2��6+   
���   � � WindowStartupLocation$ CenterScreen=�6M    � Icon$ /icon/Calculator1.ico��6r    � 
ResizeMode$ NoResize=�6�      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5
   	   .��5      ]� .+�5   
   �� -   5         ��Name$ Label1��5   %   $	��Top=�6   $
��Left=�66   $	��Top=�6Q   $��76��6i   $��32��6t   $��20(�6�   �� 5   
   -   5         ��Name$ 	txtResult��5   (   $	��Top=�6    �� 
IsReadOnly .  �� TextAlignment$ Right=�6M   $��Bottom=�6c   $��Stretch=�6~   $��1q�6�   $��30(�6�   $��49��6�   $
��Auto��6�   .��6�   06�   � 5   
   	 � ColumnDefinitions	 5      �� 5      �� 5      �� 5      �� 5      
 � RowDefinitions
 5      �� 5      �� 5      �� 5      �� 5      .+�5      �� -   5         ��Name$ Button1��5      $��0��6&   $��0��63   $
��Bold"�6S   $��18(�6e   $��0,-1,0,1q�6s   .��6�   76�   �� 5      -   5        $ Button2��5      $��0��6&   $��1��63   $
��Bold"�6S   $��18(�6e   .��6s   86v   �� 5      -   5        $ Button3��5      $��0��6&   $��2��63   $
��Bold"�6S   $��18(�6e   .��6s   96v   �� 5      -   5        $ Button4��5      $��1��6&   $��0��63   $
��Bold"�6S   $��18(�6e   .��6s   46v   �� 5      -   5        $ Button5��5      $��1��6&   $��1��63   $
��Bold"�6S   $��18(�6e   .��6s   56v   �� 5       -   5        $ Button6��5       $��1��6&   $��2��63   $
��Bold"�6S   $��18(�6e   .��6s   66v   �� 5!      -	   5        $ Button7��5!      $��2��6&   $��0��63   $
��Bold"�6S   $��18(�6e   .��6s   16v   �� 5"      -
   5        $ Button8��5"      $��2��6&   $��1��63   $
��Bold"�6S   $��18(�6e   .��6s   26v   �� 5#      -   5        $ Button9��5#      $��2��6&   $��2��63   $
��Bold"�6S   $��18(�6e   .��6s   36v   �� 5$      -   5        $ Button10��5$      $��3��6'   $��1��64   $
��Bold"�6T   $��18(�6f   .��6t   06w   �� 5&      -   5        $ 	ButtonAdd��5&      $��0��6(   $��3��65   $
��Bold"�6]   $��18(�6o   .��6}   +6�   �� 5'      -   5        $ ButtonSubtract��5'      $��1��6-   $��3��6:   $
��Bold"�6g   $��18(�6y   .��6�   -6�   �� 5(      -   5        $ ButtonMultiply��5(      $��2��6-   $��3��6:   $
��Bold"�6g   $��18(�6y   .��6�   *6�   �� 5)      -   5        $ ButtonDivision��5)      $��3��6-   $��3��6:   $
��Bold"�6g   $��18(�6y   .��6�   /6�   �� 5*      -   5        $ ButtonEquals��5*      $��3��6+   $��2��68   $
��Bold"�6c   $��18(�6u   .��6�   =6�   �� 5,      -   5        $ ButtonClear��5,      $��3��6*   $��0��67   $
��Bold"�6a   $��18(�6s   .��6�   C6�   5.      5/      50      