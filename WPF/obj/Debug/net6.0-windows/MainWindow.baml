   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	   -   5          �Name$  
mainWindow��5
   	    � 
ResizeMode$ NoResize=�5   	   
������� � Title$ 
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      �  � RowDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��85* �6   .+�5   
   o� .@�5      m� -   5         m�Name$ settings��5      $��Settings��6)   6;   m� 5      -   5        $ 
changeName��5      $��Change Name��6+   6@   5      �� 5   
    �� Orientation$ 
Horizontal=�5      $��Center=�5      $��0��5      .+�5      �� -   5         ��Name$ infoFirstTeam��5      $��15(�5      $��Center=�5       $��?��5!      6   �� 5#      -   5         ��Name$ cbFirstTeam��5&      $��30��5$      $	��200��5%      $��10,10,10,10q�5'      5)      �� 5*      -   5         ��Name$ scoreFirstTeam��5,      $��0��5+      $��45(�5-      $��Center=�5.      $��
ExtraBlack"�5/      �� 51      $��:��52      $��45(�53      $��Center=�54      $��
ExtraBlack"�55      �� 57      -   5        $ scoreSecondTeam��59      $��0��58      $��45(�5:      $��Center=�5;      $��
ExtraBlack"�5<      �� 5>      -   5        $ cbSecondTeam��5A      $��30��5?      $	��200��5@      $��10,10,10,10q�5B      5D      �� 5E      -	   5        $ infoSecondTeam��5F      $��15(�5G      $��Center=�5H      $��?��5I      6   5K      � 5L   
   -
   5        	 �Name$	 	gridPitch��5N      $��1��5M      ��5O      �� 5P      
 �� ImageSource$
 /WPF;component/pitch.jpg��6    � ColumnDefinitions 5R      �� 5S      $��* �6#   �� 5T      $��* �6#   �� 5U      $��* �6#   �� 5V      $��* �6#   �� 5W      $��* �6#   �� 5X      $��* �6#   �� 5Y      $��* �6#   �� 5Z      $��* �6#   .+�5]      �� -   5         ��Name$ 
homeGoalie��5]   )   $��0��6   $��Center=�6>   5^      �� 5`      -   5        $ homeDefense��5`   )   $��1��6   $��Center=�6?   5a      �� 5c      -   5        $ homeMidfield��5c   )   $��2��6   $��Center=�6?   5d      �� 5f      -   5        $ 
homeAttack��5f   )   $��3��6   $��Center=�6=   5g      �� 5i      -   5        $ 
awayAttack��5i   )   $��4��6   $��Center=�6=   5j      �� 5l      -   5        $ awayMidfield��5l   )   $��5��6   $��Center=�6?   5m      �� 5o      -   5        $ awayDefense��5o   )   $��6��6   $��Center=�6>   5p      �� 5r      -   5        $ 
awayGoalie��5r   )   $��8��6   $��Center=�6=   5s      5w      5y      5z      