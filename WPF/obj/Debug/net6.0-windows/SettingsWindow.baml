   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.SettingsWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  SettingsWindow��5   	   $	��400��6    $	��400��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Settings��6   $��40(�6$   $��0��62   $��Center=�6?   �� 5   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Center=�6I   $��1��6f   .+�5      �� $��Language��6   	� 5      -   5         	�Name$ rbENG��5   (   $	��ENG��6    	� 	GroupName$ Language��67   $��
 10 0 10 0q�6L   	� 5      -   5        $ rbCRO��5   (   $	��CRO��6   $ Language��67   $��
 10 0 10 0q�6L   5      �� 5   
   $ 
Horizontal=�6   $��Center=�6.   $��Center=�6I   $��2��6f   .+�5      �� $��Display Mode��6   	� 5      -   5        $ XL��5   '   $��XL��6   $ WM��63   $��
 10 0 10 0q�6B   	� 5      -   5        $ L��5   &   $��L��6   $ WM��61   $��
 10 0 10 0q�6@   	� 5      -   5        $ M��5   &   $��M��6   $ WM��61   $��
 10 0 10 0q�6@   5      �� 5   
   -   5         ��Name$ 
saveButton��5      $��3��6%   $
��Save��62   $��Center=�6A   $��Center=�6^   $	��10 q�6y   6�   5      5      