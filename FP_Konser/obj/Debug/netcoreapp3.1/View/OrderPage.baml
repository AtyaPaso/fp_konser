   M S B A M L   `   `   `  ����D  @FP_Konser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FP_Konser.ViewFP_Konser.View  5          FP_Konser.View.OrderPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:FP_Konser.View     5        N� Title$  	OrderPage��5	      .��5      � 
�������.+�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��50 �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ dgOrder��5   $   $��0��6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 65   $��Stretch=�6H   $��Stretch=�6f   $��35q�6�      AutoGenerateColumns$ False��6�      
IsReadOnly$
 True��6�   ��6�   ��  � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType	 �� Property
 �� Value)  #System.Windows.Controls.DataGridRow��%  '        7 '  �     �� 5      8   "  6U   .�5      �� 	 � ��
 �#509DC867   �� 5      	 � ��$
 50��63   �� 5      	 � ��$
 16(�65   �� 5      	 � ��$

 Bold"�67   5      �� 5      "  6   .�5      -   5        5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width$ * 6)      Header$ ID TRANSAKSI��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *id_transaksi+  5      $ * 6)   $ 
KODE TIKET��63    6G   �� *
kode_tiket+  5       $ * 6)   $ 	OPEN GATE��63    6F   �� *	open_gate+  5!      $ * 6)   $ LOKASI��63    6C   �� *lokasi+  5"      $ * 6)   $ TOTAL��63    6B   �� *harga+5$      �� 5%      -   5         ��Name$ btnExit��5%   !   $��1��6   $��/assets/icons/exit.png��62   $
��Left=�6R   $��38��6m   $��37��6x   $��25 0 0 0q�6�   6�   5&      5'      5(      