   M S B A M L   `   `   `  ����Q  MPZ1_Bogdanovic_Isidora, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:PZ1_Bogdanovic_IsidoraPZ1_Bogdanovic_Isidora  5   	   "    PZ1_Bogdanovic_Isidora.Ispis   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:PZ1_Bogdanovic_Isidora     5   	   -   5          � Title$  Ispis��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStyle$
 None=�66    � 
ResizeMode$ NoResize=�6I    � AllowsTransparency . 
������  � 	Resources 5         btn_pozadina �� 
TargetType �� Property �� Value	 �� 
TargetType
 �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6%   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $��	btn_okvir��6!   $��0q�62   ._�5      �� $��Center=�6/   $��Center=�6L   5      
 5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.7Q�6<   5      5      5      5      5      .��5       �� $	��800��6   $	��500��6   .+�5#   
   F� 
���   �$��3��6   ��5$      �� 5%       �� Color$ #424242��6"   ��5'      B� 5(      .��5)      E�  E� 
StartPoint$
 25,0&�6!   .��5*      ��  �� Size$ 25,25��6%    �� RotationAngle$	 180Q�62    �� 
IsLargeArc .   �� SweepDirection$ Counterclockwise=�6Y    �� Point$
 0,25&�6{   �� 5+       �� Point$ 0,475&�6&   �� 5,      $ 25,25��6%   $	 180Q�62    .  $ Counterclockwise=�6Y   $ 25,500&�6{   �� 5-      $ 775,500&�6&   �� 5.      $ 25,25��6%   $	 180Q�62    .  $ Counterclockwise=�6Y   $ 800,475&�6{   �� 5/      $ 800,25&�6&   �� 50      $ 25,25��6%   $	 180Q�62    .  $ Counterclockwise=�6Y   $ 775,0&�6{   �� 51      $
 25,0&�6&   52      53      55      � 58   
   $	��800��6   $	��500��6   .+�5<   
   �� -   5         ��Name$ btn_exit��5<      #��[  5=      $��25��5>      $��25��5?      $��772,2,3,473q�5@      
������  � ToolTip$ Izlaz iz aplikacije��5C      .��5D      �� $��Fotografije\Exit.png��6   $��26��62   5E      �� 5J   
   -   5         ��Name$ img_unos��5J      $	��200��6"   $��511,163,10,137q�6/   ]� 5M   
   $	��453��6   $	��496��6!   $��10,37,294,10q�6-   .+�5N      �� -   5         ��Name$ 	rtbx_opis��5N      $��12(�6-   ���#E0E0E0���#212121 �� 
IsReadOnly . 6e   5O      5R      5S      5T      