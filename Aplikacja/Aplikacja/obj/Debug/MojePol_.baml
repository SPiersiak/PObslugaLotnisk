   M S B A M L   `   `   `  ����D  @Aplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Aplikacja	Aplikacja  5          Aplikacja.MojePol_   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Aplikacja     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $	��450��5	      $	��650��6   .��5
      � $	��450��6   $	��650��6   .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   $	��450��6M   $	��650��6Z   .+�5      �� $��Center=�6   $	��650��6:   .+�5      �� $��10q�6!   .+�5      �� -   5        $��Linia��5   $   $��Moje Połączenia��61   
�������$��35(�6Z   $��0 15 0 7q�6h   �� 5      
������� �� CornerRadius$ 5��64    K� ZIndex$ 8��6E   $
��Auto��6V   ._�5      &   System.Windows.Controls.DataGrid  -   5          Name$	 Pol��5   '   $��2q�64   $	��330��6?      
IsReadOnly .    GridLinesVisibility$ 
Horizontal=�6^   	   Columns	 5   "   9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5   &   ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nr Lotu��6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6a   �� *NrLot+  5   &   $
 Lotnisko Startowe��6P    6k   �� *
LotStart+  5   &   $
 Lotnisko Docelowe��6P    6k   �� *LotDoc+  5   &   $
 	Data Lotu��6P    6c   �� *Ctrw+  5   &   $
 Godzina Lotu��6P    6f   �� *Prze+5      5      5      5      5      5      5       5!      