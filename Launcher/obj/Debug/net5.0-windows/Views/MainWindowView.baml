   M S B A M L   `   `   `  ����C  ?Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Launcher.ViewsLauncher.Views  5   	   9!clr-namespace:Launcher.ViewModelsLauncher.ViewModels  5   	   #    Launcher.Views.MainWindowView   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   .localclr-namespace:Launcher.Views     5   	   Amainwindowviewmodel!clr-namespace:Launcher.ViewModels     5   	     � Title$  MainWindowView��5
   	   $	��450��6    $	��800��6-   
������� � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value��%9  '��       �� 5   
   " ��6   .�5      ��  � ��$ 14(�6)   �� 5       � �� �#00bac76+   �� 5       � ��$ 20q�6'    5      P� 5       �@J�IsMouseOver$
 True��61   . �5      ��  � ��$ 18(�61   �� 5       � �� �#00dded63   5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��Products��5      $��0��5      $��20q�5       $��14(�5!      ���#00dded��5"      �� *
Products+	 �� View	 5$      �� 5%      .P�5&      �� 
 �� DisplayMemberBinding
 6%   ��  �� Path$
 Name�.��6P   Name6V   �� 5'      
 6%   �� $ 
Brand.Name�.��6V   Brand6]   �� 5(      
 6%   �� $ Price�.��6Q   Price6X   �� 5)      
 6%   �� $ Count�.��6Q   Count6X   �� 5*      
 6%   �� $ Category.Name�.��6Y   
Category6c   �� 5+      
 6%   �� $ Designer.Name�.��6Y   Designer Name6h   �� 5,      
 6%   �� $ Designer.LastName�.��6]   Designer LastName6p   �� 5-      
 6%   �� $ Country.Name�.��6X   	Country6a   5.      50      � 51   
   $��1��6   .+�52      �  � RowDefinitions 53      �� 54      �� 55      �� 56      .+�59      �� $��0��6   $	��Buy��6&   ��64   �� *
AddCommand+�� 5:      $��1��6   $	��Add��6&   �� 5;      $��2��6   $��Delete��6&   5<      5>      5?      5@      