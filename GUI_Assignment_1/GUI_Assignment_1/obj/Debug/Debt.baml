   M S B A M L   `   `   `  ����K  GGUI_Assignment_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GUI_Assignment_1GUI_Assignment_1  5   	       GUI_Assignment_1.Debt   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GUI_Assignment_1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5   	     � Title$  
Add Debtor��5
   	   $	��250��6   $	��400��6)    � WindowStartupLocation$ CenterOwner=�5   	    � ShowInTaskbar .   � 	Resources 5       �� 
TargetType �� Triggers P� Property P� Value �� Property	 �� Value
 �� Self �� RelativeSource �� Path��%�   '��       �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip	 5      �� # Z
 $) #(Validation.Errors)[0].ErrorContent�5      5      5      .��5      �  +� FocusedElement 6   ��  �� ElementName$ tbxName�� � ColumnDefinitions 5   
   �� 5      $��2* �6   6,   �� 5      $	��15* �6   �� 5       $��1* �6   6,    � RowDefinitions 5"   
   �� 5#      $
��auto �6   �� 5$      $
��auto �6   �� 5%      $
��auto �6   �� 5&      $��1* �6   �� 5'      $
��auto �6   .+�5*   
   �� $��28��6   $��0,6,0.333,386.667q�6   .��68   Name6>   �� 5+   
   $��28��6   $��0,37,0.333,355.667q�6   .��6:   Debt6@   �� 5-   
   -   5        $��tbxName��5.      $��39.2,10,0,0q�5-      $	��Top=�5/      $
��Left=�50      $	��200��51      $��1��53      ��52      �� $ CurrentDebt.Name� �� Mode$ TwoWay=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions .  �� NotifyOnValidationError . 53      �� 56   
   -   5        $��tbxSum��57      $��39.2,39,0,0q�56      $	��Top=�58      $
��Left=�59      $��1��5;      $	��100��5<      ��5:      �� $ CurrentDebt.Sum�$ TwoWay=� .  .  . 5<      �� 5@   
   -   5        $��btnOk��5E      $��20��5A      $ ��44.667,112,214.333,288.667q�5B      $��1��5C      $��OK��5D      ��5G      �� $ OkBtnCommand���5H      �� 5I      " ��6   .�5J      ��  � {�	 .  62    5K      ^� 5L       ^� 
Conditions 5M      �� 5N   "    �� Binding 6,   �� $ (Validation.HasError)�$ tbxName�� �� Value	 False6p   �� 5O   "    6,   �� $ (Validation.HasError)�$ tbxSum��	 False6o   .0�5Q      ��  � {�	 . 6:   5R      5T      5V      5W      5X      