   M S B A M L   `   `   `  ����>  :WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPF.InfoWPF.Info  5   	       WPF.Info.TeamInfo   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WPF.Info     5   	     � Title$  TeamInfo��5   	   $	��450��6   $	��300��6'    � 
ResizeMode$ NoResize=�63    � 	Resources 5	         OpenAnimation �� TargetProperty9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%j  &	        �� 5
   
   .��5      U� $- 'RenderTransform.(ScaleTransform.ScaleX)�6,   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.3��6'   $ 1Q�69   5      U� 5      $- 'RenderTransform.(ScaleTransform.ScaleY)�6,   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.3��6'   $ 1Q�69   5      5      5      .��5      � .+�5   
   �� .+�5      �� $��Team Information��6   $
��Bold"�60   $��16(�6B   $��Center=�6P   $	��Top=�6m   $��0,0,0,10q�6�   �� 5      $��Name:��6   �� 5      -   5         ��Name$ txtTeamName��5       �� 
IsReadOnly$
 True��6+   $��0,0,0,5q�6=   �� 5      $��
FIFA Code:��6   �� 5      -   5        $ txtFifaCode��5      $
 True��6+   $��0,0,0,5q�6=   �� 5!      $��Games:��6   �� 5"      -   5        $ txtGames��5"      $
 True��6(   $��0,0,0,5q�6:   �� 5$      $��Wins:��6   �� 5%      -   5        $ txtWins��5%      $
 True��6'   $��0,0,0,5q�69   �� 5'      $��Losses:��6   �� 5(      -   5        $ 	txtLosses��5(      $
 True��6)   $��0,0,0,5q�6;   �� 5*      $��Draws:��6   �� 5+      -   5        $ txtDraws��5+      $
 True��6(   $��0,0,0,5q�6:   �� 5-      $��Goals Scored:��6   �� 5.      -   5        $ txtGoalsScored��5.      $
 True��6.   $��0,0,0,5q�6@   �� 50      $��Goals Conceded:��6   �� 51      -   5        $ txtGoalsConceded��51      $
 True��60   $��0,0,0,5q�6B   �� 53      $��Goal Difference:��6   �� 54      -	   5        $ txtGoalDifference��54      $
 True��61   $��0,0,0,5q�6C   55      56      58      