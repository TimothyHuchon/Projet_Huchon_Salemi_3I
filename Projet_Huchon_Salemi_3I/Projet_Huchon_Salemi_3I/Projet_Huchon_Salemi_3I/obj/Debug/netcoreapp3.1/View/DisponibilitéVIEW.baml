   M S B A M L   `   `   `  ����R  NProjet_Huchon_Salemi_3I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Projet_Huchon_Salemi_3I.ViewProjet_Huchon_Salemi_3I.View  5      5    /Projet_Huchon_Salemi_3I.View.DisponibilitéVIEW   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Projet_Huchon_Salemi_3I.View     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  Disponibilité��5
      .��5      � $��Center=�5      $��Center=�5      $��0 10 0 0q�5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��/Images/car.png��6   $
��None=�6)   $	��Top=�68   $��	0 3 -80 0q�6P   �� 5    
   $��0��6   $��Disponibilité��6!      text#��[  66   $��Center=�6T   $��2��6q   $��0 0 0 90q�6�   $��SemiBold"�6�   $��30(�6�   �� 5"   
   -   5         ��Name$ 	txtBalade��5"   !   $��1��6   $��2��64   $��150 0 150 30q�5#      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Entrez Balade��5$      $��2q�6B     MaterialDesignDivider#���  5%        MaterialDesignComboBox#��[ 5&      5'      �� 5)   
   -   5         ��Name$ textVoiture��5)   3   $��2��6   $��2��6&   $��150 0 150 30q�6I   $( "Nombre de places dans le véhicule��5*      $��2q�6V   #���  5+       ! MaterialDesignOutlinedTextBox#��[ 6I   �� 5,   
   -   5        $ textVelo��5,   3   $��2��6   $��3��6&   $��150 0 150 0q�6F   $ Nombre de places vélo��5-      $��2q�6J   #���  5.      #��[ 6I   �� 50   
   -   5        $��4��50      $��0��6   $
��Save��6.   $
��5000q�6=     buttonMainGreen#��[ 51      $��2��52      $��Center=�53      $��
0 50 140 0q�54      55      �� 56   
   -   5        $��4��56      $��0��6   $��Clear��6.   $
��5000q�6>     
buttonMain#��[ 57      $��2��58      $��Center=�59      $��0 50 -130 0q�5:      5;      5=      5>      