   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFWPF  5   	       WPF.Info.PlayerInfo   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:WPF     5   	     � Title$  
PlayerInfo��5   	   $	��450��6   $	��400��6)    � 	Resources 5
         OpenAnimation �� TargetProperty W� From	 W� To g� Duration��%n   &	        �� 5   
   .��5      W� $ Opacity�6    06B    16K   $ 0:0:0.3D�6R   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��Center=�6X   .+�5      �� -   5         ��Name$ lblPlayerInformation��5      $��Player Information��66   $
��Bold"�6P   $��16(�6b   5      �� 5   
   $��1��6   $��10q�6"   .+�5      �� -   5        	 ��Name$	 imgPlayerImage��5      $S��MC:\Users\valon\Documents\Algebra\Semestar 4\.NET\profilePictureBackholder.png��5      $��UniformToFill=�5      $	��100��5      $��Center=�5      �� 5!      -   5        $ lblPlayerName��5!      $��Player Name��6/   $
��Bold"�6B   �� 5"      -   5        $ txtPlayerName��5"      $��0,0,0,10q�6/   �� 5$      -   5        $ lblShirtNumber��5$      $��Shirt Number��60   $
��Bold"�6D   �� 5%      -   5        $ txtShirtNumber��5%      $��0,0,0,10q�60   �� 5'      -   5        $ lblPosition��5'      $��Position��6-   $
��Bold"�6=   �� 5(      -   5        $ txtPosition��5(      $��0,0,0,10q�6-   �� 5*      -	   5        $ lblIsCaptain��5*      $��Captain��6.   $
��Bold"�6=   �� 5+      -
   5        $ txtIsCaptain��5+      $��0,0,0,10q�6.   �� 5-      -   5        $ lblGoalsScored��5-      $��Goals Scored��60   $
��Bold"�6D   �� 5.      -   5        $ txtGoalsScored��5.      $��0,0,0,10q�60   �� 50      -   5        $ lblYellowCards��50      $��Yellow Cards��60   $
��Bold"�6D   �� 51      -   5        $ txtYellowCards��51      $��0,0,0,10q�60   52      53      54      