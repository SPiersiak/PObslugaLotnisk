   M S B A M L   `   `   `  ����D  @Aplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Aplikacja	Aplikacja  5          Aplikacja.DodajPol_   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Aplikacja     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      �� $��1��6   .+�5      �� 
�������$��0 0 0 0q�6,    �� CornerRadius$ 5��6=   $
��Auto��6N    K� ZIndex$ 8��6\   ._�5      �� $��25q�6!   .+�5      �� $��Center=�6$   $
��Wrap=�6A   $��Nowe Połączenie��6U   $	��Top=�6l   $	��350��6�   $��36(�6�   
������� �� TextAlignment$ Center=�6�   �� 5       �� Orientation$ 
Horizontal=�6%   .+�5      �� -   5         ��Name$ Z��5   &   $��45��61   $	��170��6=   $��15q�6I    %  !MaterialDesignFloatingHintTextBox#��[  6V   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Lotnisko Startowe��6�   �� 5      -   5        $ Do��5   &   $��45��62   $	��170��6>   $��15q�6J   #��[  6W   $ Lotnisko Docelowe��6�   �� 5   "   -   5        	 ��Name$		 Prz��5   +   $��45��68   $	��170��6D   $��15q�6P    & "MaterialDesignFloatingHintComboBox#��[ 6]   $ Z przesiadkami?��6�   .@�5   "   �� $��0��6/   $	��Nie��6<   $
��Left=�6J   �� 5   "   $��1��6/   $	��Tak��6<   $
��Left=�6J   5      5      �� 5      $ 
Horizontal=�6%   .+�5      �� -   5        $ l_miej��5   &   $��45��66   $	��170��6B   $��15q�6N   #��[  6[   $ Liczba miejsc:��6�   )  #MaterialDesignThemes.Wpf.TimePicker  5      -   5        
  Name$
 zegar��5   8      	Is24Hours . $��45��6X   $	��170��6d   $��15q�6p    ( $MaterialDesignFloatingHintTimePicker#��[ 6|   $ Wybierz czas lotu:  ��6�   6�   �� 5      -   5        $ nrlot��5   &   $��15q�66   $	��170��6B   #��[  6N   $ Numer Lotu:��6�   5      �� 5      $ 
Horizontal=�6%   .+�5       �� $
��Left=�6(   $��	16 10 0 0q�6C   $
��Wrap=�6V   $��Ceny Biletów:��6j   $	��Top=�6   $	��385��6�   $��13(�6�   
�������$
 Left=�6�   �� 5!      $
��Left=�6(   $��	16 10 0 0q�6C   $
��Wrap=�6V   $��Ceny Bagaży:��6j   $	��Top=�6~   $	��100��6�   $��13(�6�   
�������$
 Left=�6�   5#      �� 5$      $ 
Horizontal=�6%   .+�5%      �� -   5        $ ek��5%   &   $��15q�63   $	��170��6?   #��[  6K   $ Klasa Ekonomiczna��6�   �� 5&      -	   5        $	 biz��5&   &   $��15q�64   $	��170��6@   #��[  6L   $ Klasa Biznes��6�   �� 5'      -
   5        $
 do25��5'   &   $��15q�65   $	��150��6A   #��[  6M   $ Cena małego bagażu:��6�   5(      �� 6'   $ 
Horizontal=�62   .+�5)      �� -   5        $
 firs��5)   &   $��15q�64   $	��370��6@   #��[  6L   $ Pierwsza klasa��6�   �� 5*      -   5        $ pow25��5*   &   $��15q�65   $	��125��6A   #��[  6M   $ Cena dużego bagażu��6�   5,      �� 5-      $ 
Horizontal=�6%   $��Center=�6>   $��0,10,0,0q�6[   .+�5.      �� -   5         ��Name$	 Add��5.   %   $��Dodaj Połączenie��62   $��	35 0 35 0q�6M   $��15 05q�6t   $��16(�6�   5/      50      51      52      53      54      55      