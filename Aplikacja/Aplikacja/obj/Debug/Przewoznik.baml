   M S B A M L   `   `   `  ����D  @Aplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Aplikacja	Aplikacja  5   	       Aplikacja.Przewoznik   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Aplikacja     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
     � Title$
  Menu��5	   	   $	��600��6   $
��1024��6#    � WindowStartupLocation$ CenterScreen=�60    � 
ResizeMode$ NoResize=�6U    � WindowStyle$
 None=�6k   ���	#FF410A66.��5      � -   5         � ColumnDefinitions 5   
   �� 5      $
��271* �6   �� 5      $
��753* �6   .+�5   
   �� 
�������$��15 30 30 30q�6$    �� CornerRadius$ 5��69   $
��Auto��6J    K� ZIndex$ 8��6X   $��1��6i   ._�5      � .+�5      �� $	��Top=�6   $��2��65   $��40��6I   .+�5      � .+�5      �� $��Center=�6%    �� Orientation$ 
Horizontal=�6B   .+�5      �� $��Panel Przewoźnika��6(   $��Center=�6A   
�������$��25(�6n   $��Champagne & Limousines)�6|   $	��0 2q�6�   5      �� 5      $ 
Horizontal=�6%   $��Right=�6>   $	��0 0q�6Z   .+�5      �� -   5         ��Name$ ButtonFechar��5   %   $��30��6;   $��30��6F   $��0q�6   
���������6R   Z� ��6h   Z� .��5   "   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]	   Kind$	 Close=�6:   $��30��6G   $��30��6R   5      5      5      5      � 5      -   5        
 �Name$
 GridPrincipal��5      $��Center=�6.   $��Center=�6K   5      5       �� 5!   
   $	��225��6   $
��Left=�6   $��
30,30,0,30q�68   ���#424242$ 5��6b   $
��Auto��6s   $ 8��6�   ._�5"      � .+�5#      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5#   6   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Y   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5$      � -   5        $
 
GridCursor��5$      $��	0 100 0 0q�6/   ���#2196F3$��10��6W   $
��Left=�6b   $��60��6}   $	��Top=�6�   5%      �� 5&      -   5         ��Name$ ListViewMenu��5&      $��0 100q�61   
�������$��18(�6W    �� SelectedIndex$ 0��6�   .@�5'      �� $��60��6#   .��5(      �� $ 
Horizontal=�6%   .+�5)        $
	 Home=�66   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   �� 5*      $��Menu główne��6(   $��17(�6;   $��Center=�6I   $
��20 0q�6d   5+      5,      �� 5-      $��60��6#   .��5.      �� $ 
Horizontal=�6%   .+�5/        $
	 User=�66   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   �� 50      $��	Moje Dane��6(   $��17(�69   $��Center=�6G   $
��20 0q�6b   51      52      �� 53      $��60��6#   .��54      �� $ 
Horizontal=�6%   .+�55        $	 ShareVariant=�66   $��30��6J   $��30��6U   $��Center=�6a   $��5q�6|   �� 56      $��Moje Połączenia��6(   $��17(�6?   $��Center=�6M   $
��20 0q�6h   57      58      �� 59      $��60��6#   .��5:      �� $ 
Horizontal=�6%   .+�5;        $		 Add=�66   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5<      $��Dodaj Połączenie��6(   $��17(�6@   $��Center=�6N   $
��20 0q�6i   5=      5>      �� 5?      $��60��6#   .��5@      �� $ 
Horizontal=�6%   .+�5A        $		 Add=�66   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5B      $��Zarezerwuj pas��6(   $��17(�6>   $��Center=�6L   $
��20 0q�6g   5C      5D      5E      5F      5G      5H      5I      