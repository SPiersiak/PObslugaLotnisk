   M S B A M L   `   `   `  ����D  @Aplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Aplikacja	Aplikacja  5          Aplikacja.Zarezerwuj_   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Aplikacja     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      �� $��1��6   .+�5      �� 
�������$��0 50 0 0q�6,    �� CornerRadius$ 5��6>   $
��Auto��6O    K� ZIndex$ 8��6]   ._�5      �� $��25q�6!   .+�5      �� $��Center=�6$   $
��Wrap=�6A   $��Rezerwuj Lot:��6U   $	��Top=�6j   $	��350��6�   $��36(�6�   
������� �� TextAlignment$ Center=�6�   �� 5       �� Orientation$ 
Horizontal=�6%   .+�5      �� -   5         ��Name$ Z��5   &   $��45��61   $	��170��6=   $��15q�6I    %  !MaterialDesignFloatingHintTextBox#��[  6V   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Skąd lecisz?��6�   �� 5      -   5        $ DO��5   &   $��45��62   $	��170��6>   $��15q�6J   #��[  6W   $ Dokąd lecisz?��6�   �� 5      -   5        	 ��Name$
	 Find��5   %   $��Szukaj Pasów��63   $��	35 0 35 0q�6J   $��05q�6q   $��16(�6}   5      &   System.Windows.Controls.DataGrid  5      -   5        
  Name$

 Rezw��5   #   $��2q�61   $	��190��6<      
IsReadOnly .    GridLinesVisibility$ 
Horizontal=�6[      Columns 5      9  3MaterialDesignThemes.Wpf.MaterialDataGridTextColumn  5   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6L      Header$ Wylot��6X   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6g   �� *Z+  5   "   $	 150 6L   $ Przylot��6X    6i   �� *Do+  5   "   $	 150 6L   $
 Data��6X    6f   �� *Kiedy+  5   "   $	 150 6L   $ 
Numer lotu��6X    6l   �� *Nrlot+5      �� 5      $ 
Horizontal=�6%   .+�5       �� -   5        $		 Rez��5    %   $��
Rezerwacja��62   $��	35 0 35 0q�6G   $	�� 05q�6n   $��16(�6{   5!      5"      5#      5$      5%      5&      5'      