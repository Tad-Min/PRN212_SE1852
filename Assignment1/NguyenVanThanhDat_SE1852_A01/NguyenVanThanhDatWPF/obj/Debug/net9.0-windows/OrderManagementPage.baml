   M S B A M L   `   `   `  ����O  KNguyenVanThanhDatWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:NguyenVanThanhDatWPFNguyenVanThanhDatWPF  5      .    (NguyenVanThanhDatWPF.OrderManagementPage   5      W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:NguyenVanThanhDatWPF     5        N� Title$  OrderManagementPage��5	      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgOrders��5      $��0��5         AutoGenerateColumns$ False��5         SelectionMode$ Single=�5         
IsReadOnly$
 True��5      $��0,0,0,10q�5         AlternatingRowBackground �#F2F2F2   RowBackground
 �����$��14(�5         ColumnHeaderHeight$ 35Q�5      	   	RowHeight$	 30Q�5      ���#BDC3C7$��1q�5       
   GridLinesVisibility$
 
Horizontal=�5!       � 	Resources 5"      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value*  $System.Windows.Controls.DataGridCell��%m  '        '  �     �� 5#      "  6   .�5$      ��  � �� �#2980B963   �� 5%       � ��
 �����63   �� 5&       � ��$
 Bold"�63   �� 5'       � ��$ Center=�6C   �� 5(       � ��$ 6q�60   5)      �� 5*      "  6   .�5+      ��  � ��$ Center=�6C   �� 5,       � ��$ Center=�6A   5-      5.         Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Mã Đơn��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	OrderId+6Q     51      $ Khách hàng��6%   $	 150 6Z    69   �� *CustomerName+6Z     52      $ Nhân viên��6%   $	 120 6Y    68   �� *EmployeeName+6Y     53      $ Ngày��6%   $	 100 6j    63   �� *	OrderDate+ �� StringFormat$ 
dd/MM/yyyy��6j     54      $ Tổng tiền��6%   $	 100 6i    68   �� *TotalAmount+$ N0��6i   56        59   
   -   5        $ dgOrderDetails��59      $��1��5:      $ False��5;      $ Single=�5<      $
 True��5=      $��0,0,0,10q�5>       �#F2F2F2
 �����$��14(�5A      $ 35Q�5B      $	 30Q�5C      ���#BDC3C7$��1q�5E      $
 
Horizontal=�5F       5G      ��%m  '        '  �     �� 5H      "  6   .�5I      ��  � �� �#2980B963   �� 5J       � ��
 �����63   �� 5K       � ��$
 Bold"�63   �� 5L       � ��$ Center=�6C   �� 5M       � ��$ 6q�60   5N      �� 5O      "  6   .�5P      ��  � ��$ Center=�6C   �� 5Q       � ��$ Center=�6A   5R      5S       5T        5U      $ Sản phẩm��6%   $	 150 6W    67   �� *ProductName+6W     5V      $ Số lượng��6%   $ 80 6T    67   �� *
Quantity+6T     5W      $ 
Đơn giá��6%   $	 100 6e    66   �� *	UnitPrice+$ N0��6e     5X      $ Thành tiền��6%   $	 100 6d    69   �� *Total+$ N0��6d   5Z      �� 5]   
    �� Orientation$ Vertical=�6   $��2��6,   $��0,10,0,0q�69   .+�5^      �� $ 
Horizontal=�6   $��0,0,0,10q�62   $��Center=�6D   .+�5_      �� $��Khách hàng��6   $��90��6-   $��Center=�68   �� 5`      -   5         ��Name$ 
cbCustomer��5`      $	��150��6/   $��0,0,10,0q�6;   �� 5a      $��Nhân viên��6   $��80��6,   $��Center=�67   �� 5b      -   5        $ 
cbEmployee��5b      $	��150��6/   $��0,0,10,0q�6;   �� 5c      $��Ngày��6   $��50��6'   $��Center=�62   (  "System.Windows.Controls.DatePicker  5d      -   5          Name$ dpOrderDate��5d      $	��120��62   $��0,0,10,0q�6>   5e      �� 5g      $ 
Horizontal=�6   $
��Left=�62   .+�5h      �� -   5        $��Thêm sản phẩm��5h      $	��120��5i      $��0,0,10,0q�5j      $��6q�5k      ���#27AE60
�������$��SemiBold"�5n      5o      �� 5p      -   5        $��Sửa sản phẩm��5p      $	��120��5q      $��0,0,10,0q�5r      $��6q�5s      ���#2980B9
�������$��SemiBold"�5v      5w      �� 5x      -   5        $��Xóa sản phẩm��5x      $	��120��5y      $��0,0,10,0q�5z      $��6q�5{      ���#C0392B
�������$��SemiBold"�5~      5      �� 5�      -	   5        $��
Lưu mới��5�      $��90��5�      $��0,0,10,0q�5�      $��6q�5�      ���#27AE60
�������$��SemiBold"�5�      5�      �� 5�      -
   5        $��Cập nhật��5�      $��90��5�      $��0,0,10,0q�5�      $��6q�5�      ���#2980B9
�������$��SemiBold"�5�      5�      �� 5�      -   5        $
��Xóa��5�      $��70��5�      $��6q�5�      ���#C0392B
�������$��SemiBold"�5�      5�      5�      �� 5�      -   5         ��Name$ 	txtStatus��5�      
���  ��$
��Bold"�5�      $��5,10,0,0q�5�      5�      5�      5�      