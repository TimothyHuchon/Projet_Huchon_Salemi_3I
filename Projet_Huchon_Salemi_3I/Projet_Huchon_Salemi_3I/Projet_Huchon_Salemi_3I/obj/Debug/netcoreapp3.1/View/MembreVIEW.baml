   M S B A M L   `   `   `  ����R  NProjet_Huchon_Salemi_3I, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Projet_Huchon_Salemi_3I.ViewProjet_Huchon_Salemi_3I.View  5   	   -    'Projet_Huchon_Salemi_3I.View.MembreVIEW   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFMaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   6local*clr-namespace:Projet_Huchon_Salemi_3I.View  5   	     � Title$  Membre��5	   	   $	��700��6   $
��1000��6%    � Icon$ /Images/biker.png��62      MaterialDesignBody#���   5
   	    � WindowStyle$
 None=�5   	    � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �   MaterialDesignPaper#���  6    � ColumnDefinitions 5   
   �� 5      $
��829* �6   �� 5      $��0 �6   .+�5   
   �� $��BikeBaladeApp��6   $��Fonts/#Orbitron Medium)�5      $��30(�5      $	��Top=�5      $��Center=�5      $��0,10,-200,0q�5      $��2��61   �� 5   
   $��	AS AND TH��6   ���#525965$��Fonts/#Orbitron Medium)�5      $��10(�5      $��Bottom=�5      $��Right=�5       $��	0,0,15,10q�5!      $��2��6/   �� 5#   
   ���#D61734$��15��5$       �� CornerRadius$ 3,0,0,3��5%      $��5��5&      $��Bottom=�5'      $��Right=�5(      $��0,0,0,8q�5)      $��1��6*   �� 5,   
   ���#2E333A$	��230��5-       �� Orientation$ Vertical=�5.      $
��Left=�5/      .+�52      � $	��100��6   $	��Top=�53      $��0,30,0,0q�54      .+�56      �� ���#D61734$��25��57      $ 3,0,0,3��58      $��6��59      $��Center=�5:      $��Right=�5;      �� 5=      $��/Images/logo.png��6   $	��100��62   $	��100��6?   5>      o� 5B      $	��500��6   
������ $��	00,65,0,0q�5D      ��5F      �� 5G      .R�5I      $�  $� Orientation$ Vertical=�61   5K      .@�5O      m� -   5        $��Accueil��5O        Menu_Template#��[ 5P      $��0,0,0,20q�5Q      	 m� Icon	 5S      �� 5T      $��/Images/home.png��6    $
��None=�5U       5Y      m� 5\      $��Mise à jour��6     Menu_SubMenu_Template#��[ 5]      $��0,0,0,20q�5^      	 5`      �� 5a      $��/Images/new.png��6    $
��None=�5b       .@�5d      m� -   5        $��Vélo��5d      #��[ 5e      $��0,0,0,20q�5f      	 5h      �� 5i      $��/Images/velo.png��6$   $
��None=�5j       5m      m� 5n      -   5        $��	Categorie��5n      #��[ 5o      $��0,0,0,20q�5p      	 5r      �� 5s      $��/Images/cat.png��6$   $
��None=�5t       5w      5y      m� 5}      -   5        $��Disponibilité��5}      #��[ 5~      $��0,0,0,20q�5      	 5�      �� 5�      $��/Images/car.png��6    $
��None=�5�       5�      m� 5�      -   5        $��Réservation��5�      #��[ 5�      $��0,0,0,20q�5�      	 5�      �� 5�      $��/Images/reserv.png��6    $
��None=�5�       5�      m� 5�      -   5        $��Paiement��5�      #��[ 5�      $��0,0,0,20q�5�      	 5�      �� 5�      $��/Images/img_paiement.png��6    $
��None=�5�       5�      m� 5�      -   5        
 m�Name$
 responsable��5�      $��Balade��5�      #��[ 5�      $��0,0,0,20q�5�      $��2(�5�      $y�Hidden=�5�      	 5�      �� 5�      $��/Images/personne.png��6    $
��None=�5�       .@�5�      m� -   5        $
 ajoutBalade��5�      $��Ajout��5�      #��[ 5�      $��0,0,0,20q�5�      $��2(�5�      	 5�      �� 5�      $��/Images/plus.png��6$   $
��None=�5�       5�      m� 5�      -	   5        $
 
infoBalade��5�      $
��Info��5�      #��[ 5�      $��0,0,0,20q�5�      $��2(�5�      	 5�      �� 5�      $��/Images/i.png��6$   $
��None=�5�       5�      5�      m� 5�      -
   5        $
 	tresorier��5�      $��
Trésorier��5�      #��[ 5�      $��
0,-70,0,20q�5�      $y�Hidden=�5�      	 5�      �� 5�      $��/Images/personne.png��6    $
��None=�5�       5�      5�      5�       � 5�   
   -   5          �Name$
 Main��5�      $��230,65,0,30q�6   63   �� 5�   
   -   5         ��Name$ modifBtn��5�       ! MaterialDesignFlatMidBgButton#��[ 6#   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�6Z   $��53��6�   $	��120��5�      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��6%   $��18(�6S   $��Modifier��6a   $
��Left=�6t   $��555,600,0,16q�6�   $y�Hidden=�6�   6�   '  !MaterialDesignThemes.Wpf.PopupBox  5�   
   $��Right=�6$   $��
0,9,10,666q�6@      PlacementMode$ BottomAndAlignRightEdges=�6T      	StaysOpen$ False��6}   $��25��6�   $ Depth4=�6�      PopupContent. 5�      �� .+�5�      �� $��	16 10 0 6q�6   $ 
Horizontal=�60   $��Center=�6I   .+�5�      �� $��Center=�6    $��	Dark Mode��6;   d� 5�      -   5         d�Name$ themeToggle��5�   ^    � Cursor$
 Hand��6#    � ToolTip$ Enable Dark Mode��61   $��12 0 8 0q�6L    d� 	IsChecked 6s   �� *IsDarkTheme+6�   5�      �� 5�      -   5        $ signOut��5�      $( "Cliquez ici pour vous déconnecter��6*   $��0 8 0 0q�6V   $��Déconnexion��6g   6}   �� 5�      -   5        $ btn_exit��5�      $ Close Application��6+   $��Exit Application��6G   6b   5�      5�      5�      5�      