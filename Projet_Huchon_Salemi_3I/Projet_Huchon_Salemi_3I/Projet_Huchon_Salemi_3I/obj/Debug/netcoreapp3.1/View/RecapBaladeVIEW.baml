   M S B A M L   `   `   `  ����R  NProjet_Huchon_Salemi_3I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Projet_Huchon_Salemi_3I.ViewProjet_Huchon_Salemi_3I.View  5      2    ,Projet_Huchon_Salemi_3I.View.RecapBaladeVIEW   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Projet_Huchon_Salemi_3I.View     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  RecapBalade��5
      .��5      � $��Center=�5      $��Center=�5      $��0 10 0 0q�5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5    
   �� $��/Images/i.png��6   $
��None=�6'   $	��Top=�66   $��	0 3 -80 0q�6N   �� 5!   
   $��0��6   $��Informations��6!      text#��[  65   $��Center=�6S   $��2��6p   $��0 0 0 90q�6�   $��SemiBold"�6�   $��30(�6�   �� 5#   
   -   5         ��Name$ 	txtBalade��5#   !   $��1��6   $��2��64   $��150 0 150 30q�5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Entrez Balade��5%      $��2q�6B     MaterialDesignDivider#���  5&        MaterialDesignComboBox#��[ 5'      5(      �� 5)   
   -   5         ��Name$ membreTotal��5)   !   $��2��6   #��[  66   $��Center=�6T   �� 5*   
   -   5        $ 
membreRest��5*   !   $��3��6   $��0��65   #��[  6F   $��Center=�6d   �� 5+   
   -   5        $ 	veloTotal��5+   "   $��2��6   $��1��65   #��[  6F   $��Center=�6d   �� 5,   
   -   5        $ veloRest��5,   "   $��3��6   $��1��64   #��[  6E   $��Center=�6c   �� 5-   
   -   5        $ membreBesoin��5-   7   $��2��6   $��4��6)   #��[  6M   $��Center=�6k   �� 5.   
   -   5        $ 
veloBesoin��5.   7   $��2��6   $��5��6)   #��[  6L   $��Center=�6j   50      51      