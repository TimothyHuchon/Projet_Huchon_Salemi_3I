   M S B A M L   `   `   `  ����R  NProjet_Huchon_Salemi_3I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Projet_Huchon_Salemi_3I.ViewProjet_Huchon_Salemi_3I.View  5      +    %Projet_Huchon_Salemi_3I.View.VeloVIEW   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Projet_Huchon_Salemi_3I.View     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6@     N� Title$
  Velo��5	      .��5      � $��Center=�5      $��Center=�5      $��0 10 0 0q�5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��/Images/velo.png��6   $
��None=�6*   $	��Top=�69   $��	0 3 -80 0q�6Q   �� 5    
   $��0��6   $��Ajout Vélo��6!      text#��[  63   $��Center=�6Q   $��2��6n   $��0 0 0 50q�6�   $��SemiBold"�6�   $��30(�6�   �� 5"   
   -   5         ��Name$ textType��5"   3   $��2��6   $��1��6&   $��150 0 150 30q�6E   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Type de vélo��5#      $��2q�6A     MaterialDesignDivider#���  5$       ! MaterialDesignOutlinedTextBox#��[ 6I    �� 	MaxLength$ 50��6�   �� 5&   
   -   5        $ textLong��5&   3   $��2��6   $��2��6&   $��150 0 150 30q�6E   $ Longeur du vélo��5'      $��2q�6D   #���  5(      #��[ 6I   $ 50��6�   �� 5*   
   -   5        $ textPoid��5*   3   $��3��6   $��3��6&   $��150 0 150 30q�6E   $ Poids du vélo��5+      $��2q�6B   #���  5,      #��[ 6I   $ 50��6�   �� 5.   
   -   5        $��5��5.      $��0��6   $
��Save��6.   $
��5000q�6=     buttonMainGreen#��[ 5/      $��2��50      $��Center=�51      $��	0 0 140 0q�52      53      �� 54   
   -   5        $��5��54      $��0��6   $��Clear��6.   $
��5000q�6>     
buttonMain#��[ 55      $��2��56      $��Center=�57      $��
0 0 -130 0q�58      59      5<      5=      