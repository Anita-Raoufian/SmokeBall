   M S B A M L   `   `   `  ����G  CWpfSearchApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfSearchAppWpfSearchApp  5   	       WpfSearchApp.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfSearchApp     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � -   5        $��
SearchGrid��5	      $��
10,0,10,10q�6   ���#D65909 � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $
��Auto �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��/Resources/Logo.jpg��6   $��0��6-   $��0��6=   $
��Left=�6J   6g   �� 5   
   $��1��6   $��1��6    $��Center=�6-   $��Trebuchet MS)�6H   $��20(�6c   
���   �.��6�   +)Search phrase (keywords comma separated):5      �� 5   
   -   5        $��KeywordTextBox��5      $��1��6)   $��2��69   .��6G   conveyancing software6^   �� 5   
   -   5        $��ResultTextBox��5      $��1��6'   $��4��67   $��Center=�6D    �� 
IsReadOnly . ��6q   ��  �� Path$ SearchResult� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   -   5        $��SearchButton��5      $��1��6&   $��5��66   $��0,10,0,0q�6C   $	��125��6U   $��25��5       $
��Left=�6   .��6V   Search6^   5!      5"      