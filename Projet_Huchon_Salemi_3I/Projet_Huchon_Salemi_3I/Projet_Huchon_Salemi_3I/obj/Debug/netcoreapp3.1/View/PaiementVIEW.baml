   M S B A M L   `   `   `  ����R  NProjet_Huchon_Salemi_3I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Projet_Huchon_Salemi_3I.ViewProjet_Huchon_Salemi_3I.View  5      /    )Projet_Huchon_Salemi_3I.View.PaiementVIEW   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:Projet_Huchon_Salemi_3I.View     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6@     N� Title$  Paiement��5	      .��5      � $��Center=�5      $��Center=�5      $��0 10 0 0q�5       � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $	��300 �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $	��120 �6   �� 5      $
��auto �6   .+�5   
   �� $��/Images/img_paiement.png��6   $
��None=�62   $	��Top=�6A   $��	0 3 -80 0q�6Y   �� 5    
   $��0��6   $��Paiement��6!      text#��[  61   $��Center=�6O   $��2��6l   $��0 0 0 90q�6�   $��SemiBold"�6�   $��30(�6�   �� 5"   
   $��1��6   $��Soldes��6!   #��[  6/   $��0 0 0 0q�6M   $��Center=�5#      $	��Top=�5$      �� 5%   
   -   5         ��Name$ solde��5%   !   $��1��6     	textSolde#��[ 60   �� 5'   
   $��1��6   $��1��6!   $��Compte banquaires��61   #��[  6J   $��0 0 0 0q�6h   $��Center=�5(      $	��Top=�5)      �� 5*   
   -   5        $	 cpt��5*   1   $��1��6   $��1��6!     textCpt#��[ 6>   �� 5.   
   -   5        $��2��5.      $��0��6   $��Payer dette��6.   $
��5000q�6D     buttonMainGreen#��[ 5/      $��Center=�50      $��0 30 0 0q�51      6#   �� 53   
   -   5         ��Name$ textajouter��53   0   $��2��6   $��1��6    $��65 30 155 0q�6F   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Montant��54      $��2q�6<     MaterialDesignDivider#���  55       ! MaterialDesignOutlinedTextBox#��[ 6I   �� 56   
   -   5        $��2��56      $��1��6   $��	Recharger��6.   $
��5000q�6B   #��[ 57      $��Center=�58      $��
100 30 0 0q�59      6%   5:      5;      