   M S B A M L   `   `   `  ����R  NProjet_Huchon_Salemi_3I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Projet_Huchon_Salemi_3I.ViewProjet_Huchon_Salemi_3I.View  5      2    ,Projet_Huchon_Salemi_3I.View.ReservationVIEW   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Projet_Huchon_Salemi_3I.View     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6@     N� Title$  Reservation��5	      .��5      � $��Center=�5      $��Center=�5      $��0 10 0 0q�5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��/Images/reserv.png��6   $
��None=�6,   $	��Top=�6;   $��	0 3 -80 0q�6S   �� 5    
   $��0��6   $��Réservation��6!      text#��[  64   $��Center=�6R   $��2��6o   $��0 0 0 90q�6�   $��SemiBold"�6�   $��30(�6�   �� 5"   
   -   5         ��Name$ txtCat��5$      $��1��5"      $��2��5#      $��150 0 150 20q�5%      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Entrez Catégorie��5&      $��2q�6E     MaterialDesignDivider#���  5'        MaterialDesignComboBox#��[ 5(      5)      �� 5,   
   -   5        $ 	txtBalade��5,   !   $��2��6   $��
40 0 40 20q�5-      $ Entrez Balade��5.      $��2q�6B   #���  5/      #��[ 50      51      �� 54   
   -   5        $ txtvelo��54   0   $��2��6   $��1��6    $��
40 0 40 20q�55      $ Entrez Vélo��56      $��2q�6@   #���  57      #��[ 58      59      �� 5<   
   -   5        $ txtPass��5<   !   $��3��6   $��
40 0 40 20q�5=      $ Entrez Rôle��5>      $��2q�6@   #���  5?      #��[ 5@      .@�5A      �� $��Passager��6   60   �� 5B      $��
Conducteur��6   62   5C      �� 5E   
   -   5         ��Name$ forfait��5E   "   $��4��6   #��[  63   $��Center=�6Q   �� 5F   
   -   5        $ 	placeRest��5F   1   $��4��6   $��1��6!   #��[  6D   $��Center=�6b   �� 5H   
   -   5        $��5��5H      $��0��6   $
��Save��6.   $
��5000q�6=     buttonMainGreen#��[ 5I      $��2��5J      $��Center=�5K      $��
0 30 140 0q�5L      5M      �� 5N   
   -   5        $��5��5N      $��0��6   $��Clear��6.   $
��5000q�6>     
buttonMain#��[ 5O      $��2��5P      $��Center=�5Q      $��0 30 -130 0q�5R      5S      5V      5W      