   M S B A M L   `   `   `  ����B  >S12.wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:S12.wpfS12.wpf  5   	       S12.wpf.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:S12.wpf     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���#000000.��5	      �� .+�5
   
   �� ���#FFFFFF.��6%   First Name :63   �� 5   
   -   5        $��tbfname��5      ���#FFFFFF���#000000��6N   �� *fname+�� 5   
   ���#FFFFFF.��6%   Last Name :62   �� 5   
   -   5        $��tblname��5      ���#FFFFFF���#000000��6M   �� *lname+�� 5   
   ���#FFFFFF.��6%   
Number :6/   �� 5   
   -   5        $��tbnumber��5      ���#FFFFFF���#000000��6N   �� *number+�� 5   
   ���#FFFFFF.��6%   	Email :6.   �� 5   
   -   5        $��tbemail��5      ���#FFFFFF���#000000��6M   �� *email+�� 5   
   ���#FFFFFF.��6%   	State :6.   �� 5   
   -   5        $��
user_state��5      ���#FFFFFF���#000000��6P   �� *state+�� 5   
   ���#FFFFFF.��6%   Town :6-   �� 5   
   -   5        $��	user_town��5      ���#FFFFFF���#000000��6O   �� *town+�� 5   
   ���#FFFFFF.��6%   
Street :6/   �� 5   
   -   5        $��user_street��5      ���#FFFFFF���#000000��6Q   �� *street+�� 5   
   -   5        
��� � �.��5   :   Add6?   �� 5   
   -	   5        
���  ��.��5   :   Delete6B   �� 5   
   ���#FFFFFF.��6%   First Name to Search:6<   �� 5   
   -
   5        $��	tbfnametf��5      ���#FFFFFF���#000000��6P   �� *fname_tofind+�� 5   
   ���#FFFFFF.��6%   Last Name to Search:6;   �� 5   
   -   5        $��	tblnametf��5      ���#FFFFFF���#000000��6O   �� *lname_tofind+�� 5   
   -   5        
��� ���.��5   ;   Find6A   �� 5   
   -   5        $��lbNames��5      $	��150��6D   ��6!   �� *
Contacts+ �� SelectedIndex 6Q   �� *Selected_Index+��5       �� 5!      .R�5"      � .+�5#      �� ��6"   �� *Person_Name.FirstName+ �� Mode$ TwoWay=��� 5$      ��6"   �� *Person_Name.LastName+$ TwoWay=��� 5%      ��6"   �� *Person_Number+$ TwoWay=��� 5&      ��6"   �� *Person_Email+$ TwoWay=��� 5'      ��6"   �� *Person_Address.State+$ TwoWay=��� 5(      ��6"   �� *Person_Address.Town+$ TwoWay=��� 5)      ��6"   �� *Person_Address.Street+$ TwoWay=�5*      5+      5-      &   System.Windows.Controls.DataGrid  5/   
   -   5        $��
dgContacts��5/      ��6%   �� 50      51      