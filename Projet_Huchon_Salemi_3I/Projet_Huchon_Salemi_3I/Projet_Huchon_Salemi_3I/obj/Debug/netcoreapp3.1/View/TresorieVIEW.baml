   M S B A M L   `   `   `  ����R  NProjet_Huchon_Salemi_3I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Projet_Huchon_Salemi_3I.ViewProjet_Huchon_Salemi_3I.View  5      /    )Projet_Huchon_Salemi_3I.View.TresorieVIEW   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Projet_Huchon_Salemi_3I.View     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  Tresorie��5
      .��5      � $��Center=�5      $��Center=�5      $��0 10 0 0q�5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��/Images/personne.png��6   $
��None=�6.   $	��Top=�6=   $��
0 3 -130 0q�6U   �� 5    
   $��0��6   $��Trésorerie��6!      text#��[  63   $��Center=�6Q   $��2��6n   $��0 0 0 50q�6�   $��SemiBold"�6�   $��30(�6�   �� 5"   
   -   5         ��Name$ 	txtBalade��5"       $��1��6   $��130 -20 130 30q�5#      $��2��5$      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Entrez Balade��5%      $��2q�6B     MaterialDesignDivider#���  5&        MaterialDesignComboBox#��[ 5'      5(      �� 5*   
   -   5        $��2��5*      $��0��6   $��Envoyer rappel paiement��6.   $
��5000q�6P   $	��200��6_     
buttonMain#��[ 5+      $��Center=�5,      $��2��5-      $��
50 0 60 30q�5.      5/      �� 52   
   -   5        $��3��52      $��0��6   $��Payer conducteur��6.   $
��5000q�6I     buttonMainRed#��[ 53      $��2��54      $��Center=�55      $��	0 0 340 0q�56      57      �� 58   
   -   5        $��3��58      $��0��6   $��Réclamer forfait��6.   $
��5000q�6I   #��[ 59      $��2��5:      $��Center=�5;      $��
0 0 -340 0q�5<      5=      5?      5@      