   M S B A M L   `   `   `  ����D  @Aplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Aplikacja	Aplikacja  5          Aplikacja.Rezerwacje_   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Aplikacja     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��450��5	      $	��650��6   .��5
      � $	��450��6   $	��650��6   .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   $	��450��6M   $	��650��6Z   .+�5      �� .+�5      �� $��
Rezerwacje��6    
�������$��25(�6D   $��	10 0 0 0 q�6R   �� 5      $��10q�6!   .+�5      �� -   5        $
��name��5   $   
�������$��35(�6C   $��0,5,0,-1q�6Q   �� 5      -   5        $��sname��5   $   
�������$��35(�6D   �� 5      $��Moje rezerwacje:��6$   
�������$��25(�6N   $��Champagne & Limousines)�6\   $��0,15,5,5q�6�   �� 5      
������� �� CornerRadius$ 5��64    K� ZIndex$ 8��6E   $
��Auto��6V   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Rezwac��5   '   $��2q�67   $	��190��6B      
IsReadOnly .    GridLinesVisibility$ 
Horizontal=�6a   	   Columns	 5   "   9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5   &   ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nr lotu��6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *Nrlot+5      5      5      �� 5      $��Champagne & Limousines)�6   $��Udanej Podróży��6D   
�������$��18(�6o   $��10q�6}   5      5      5       5!      5"      