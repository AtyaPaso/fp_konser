   M S B A M L   `   `   `  ����D  @FP_Konser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:FP_Konser.ViewFP_Konser.View  5      #    FP_Konser.View.PembayaranPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:FP_Konser.View     5        N� Title$  PembayaranPage��5	      .��5      � ���#CFE7F4 � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��
Pembayaran��6   $��36(�6&   $
��bold"�64   $��Baloo Thambi)�6F   $��30 0 0 0q�6`   $��Bottom=�6r   �� 5   
   $��1��6   .+�5      � $��40 30 40 40q�6    � ColumnDefinitions 5      �� 5      $	��200 �6'   �� 5      $��20 �6'   �� 5      $��* �6'    5      �� 5      $��40 �6$   �� 5      $��40 �6$   �� 5      $��40 �6$   .+�5      �� $��0��6   $��0��6,   $��Kode Transaksi��69   $��Baloo Thambi)�6O   $��20(�6i   $
��Bold"�6w   �� 5      $��1��6   $��0��6,   $��:��69   $��20(�6B   $
��Bold"�6P   $��Baloo Thambi)�6b   �� 5       -   5         ��Name$ txtKodeTransaksi��5    9   $��2��6   $��0��6,   $��	AAAE12345��6S   $��Baloo Thambi)�6d   $��20(�6~   $
��Bold"�6�   �� 5!      $��0��6   $��1��6,   $��Total Transaksi��69   $��Baloo Thambi)�6P   $��20(�6j   $
��Bold"�6x   �� 5"      $��1��6   $��1��6,   $��:��69   $��20(�6B   $
��Bold"�6P   $��Baloo Thambi)�6b   �� 5#      -   5        $ txtTotalTransaksi��5#   9   $��2��6   $��1��6,   $��30.000��6T   $��Baloo Thambi)�6b   $��20(�6|   $
��Bold"�6�   �� 5$      $��0��6   $��2��6,   $��Metode Bayar��69   $��Baloo Thambi)�6M   $��20(�6g   $
��Bold"�6u   �� 5%      $��1��6   $��2��6,   $��:��69   $��20(�6B   $
��Bold"�6P   $��Baloo Thambi)�6b   �� 5&      -   5         ��Name$ cbMetodePembayaran��5&   8   $��2��6   $��2��6+    �� Text$ Pilih Metode Bayar��6T   $	��343��6n   $
��Left=�6z    �� 
IsEditable$
 True��6�    �� 
IsReadOnly$
 True��6�   .@�5'      �� $
��DANA��6#   �� 5(      $��TRANSFER��6#   �� 5)      $��	INDOMARET��6#   5*      5+      5,      ]� 5-   
   $��2��6   .+�5.      �� -   5         ��Name$ btnExit��5.      $��/assets/icons/exit.png��6%   $��38��6E   $��20 0 0 0q�6P   6b   �� 5/      -   5        	 ��Name$	 btnBayar��5/      $	��159��6'   $��44��63   $��0q�6?   ���#509DC8$��Right=�6h   
 �� CornerRadius$
 10��6�   $��0 0 20 0q�6�   ._�50      �� $��Bayar��6   $��20(�6*   $��Baloo Thambi)�68   $��Center=�6R   $��Center=�6m   
������ 6�   51      52      54      55      