   M S B A M L   `   `   `  ����D  @SalaryWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SalaryWPF	SalaryWPF  5   	       SalaryWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SalaryWPF     5   	   -   5          �Name$  SalaryWindow��5   	    � Title$ Salary Window��5   	   $��542.2��6   $��443.2��6.   .��5	      � $��0,0,3.8,5.8q�6    � ColumnDefinitions 5
   
   �� 5      $	��92* �6   �� 5      $	��20* �6   �� 5      $
��294* �6   �� 5      $	��27* �6   .+�5   
   �� $��Personel Maaş Tablosu��6   $
��Left=�60   $��5,22,0,0q�6K   $	��Top=�6]   $��30��6u   $	��245��6�   $��Times New Roman)�6�   $��18(�6�   ���	#FF176376$
��Bold"�6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridPersonel��5      $	��144��6)   $��43,57,22.6,306q�66   $��3��6N      
IsReadOnly . $��Center=�6t   �� 5   
   $��Bütçe:��6   $
��Left=�6!   $��	4,207,0,0q�6<   $	��Top=�6O   $��Times New Roman)�6g   $��16(�6�   $��2��6�    J� RenderTransformOrigin$ 0.156,0.583&�6�   $��29��6�   $��51��6�   �� 5   
   -   5         ��Name$ textBoxButce��5      $
��Left=�6(   $��23��6C   $��
62,210,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $��Bolum Butce��6w   $	��Top=�6�   $	��120��6�   $��Times New Roman)�6�   $��16(�6�   $��2��6�    �� 
IsReadOnly . 6�   �� 5   
   -   5        	 ��Name$	 
DurumLabel��5      $��DURUM��6$   $
��Left=�64   $��
91,253,0,0q�6O   $	��Top=�6c   $��Times New Roman)�6{   $��16(�6�   $��3��6�   $��29��6�   $	��291��6�   �� 5   
   $��Personel ID:��6   $
��Left=�6'   $��	1,308,0,0q�6B   $	��Top=�6U   $��16(�6m   $��2��6{   $��Times New Roman)�6�   $��29��6�   $��91��6�   $��1��6�   �� 5   
   -   5        $ textID��5      $
��Left=�6"   $��23��6=   $��
99,314,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   $��16(�6�   $��2��6�   
 �� SelectionOpacity$	
 0.6Q�6�   $��Times New Roman)�6�   6�   �� 5   
   $��Yeni Maaş: ��6   $
��Left=�6&   $��	1,349,0,0q�6A   $	��Top=�6T   $��16(�6l   $��2��6z   $��Times New Roman)�6�   $��29��6�   $��86��6�   $��1��6�   �� 5   
   -   5        $ textYeniMaas��5      $
��Left=�6(   $��23��6C   $��
99,349,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $��16(�6�   $��2��6�   $	
 0.6Q�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5         ��Name$ Button��5      $�� ��6!   $��2��6,   $
��Left=�6<   $��
77,390,0,0q�6W   $	��Top=�6k   $��67��6�   $��65��6�   ��5      �� 5       �� ImageSource$ maasDegistir.jpg��6   5      5      5      