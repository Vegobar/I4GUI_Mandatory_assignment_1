   M S B A M L   `   `   `  ����K  GGUI_Assignment_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:GUI_Assignment_1GUI_Assignment_1  5   	   !    GUI_Assignment_1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:GUI_Assignment_1     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   S OPrism.Wpf, Version=7.2.0.1422, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5   	     � Title$  The Debt Book��5
   	   $	��350��6   $	��800��6,    � DataContext 5      *   $GUI_Assignment_1.MainWindowViewModel  5   
    � 	Resources 5      %   GUI_Assignment_1.ColorConverter   colorConvert��%   &	          5   
   66   5      .��5      ]� .+�5   
   o� -   5        $��mainMenu��5   $   $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� $
��_New��6    m� Command 6)   �� *NewFileCommand+m� 5      $��_Open��6    6*   �� *OpenFileCommand+ m� CommandParameter 6N   ��  �� ElementName$ tbxFileName�� �� Path$
 Text�m� 5      $��_Save��6    6*   �� *SaveCommand+m� 5      $��Save_As��6    6,   �� *SaveAsCommand+ 6N   �� $ tbxFileName��$
 Text�m� 5      $��E_xit��6    6*   �� *CloseAppCommand+5      5      c� 5   
   $	��Top=�6   $
��auto��6'   
�������.@�5      �� $��File Name: ��6   $��12(�5       $��Medium"�5!      $��Center=�5"       �� Target 5      �� $ tbxFileName��5"      �� 5$      -   5         ��Name$ tbxFileName��5$      $��12(�5%      $��Medium"�5&      $��Center=�5'      $	��150��5(      5)      �� 5*   
   6   � 5,      	 � RowDefinitions	 5-      �� 5.      $
��auto �6    �� 5/      $
��auto �6    �� 50      $
��auto �6    �� 51      $��1* �6    �� 52      $��1* �6    .+�55      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 datagridDebts��55      $ �� IsSynchronizedWithCurrentItem$
 TrueY�59         
IsReadOnly .    CanUserAddRows .     CanUserDeleteRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5=         AutoGenerateColumns .  $��1��5?      $	��150��5@      ��56      �� $ Debitors� �� SelectedItem 57      �� $ CurrentDebitor� �� SelectedIndex 58      �� $ CurrentIndex�   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��5E      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5D      �� *Name+   ElementStyle 5F      �� 5G       �� 
TargetType" ��6$   .�5H   "   ��  �� Property � �� �� Value 6?   �� *Sum+ �� 	Converter# [  5I      5K        5L      $	 Sum��5N       5M      �� *Sum+ 5O      �� 5P      " ��6$   .�5Q   "   ��  � �� 6?   �� *Sum+# [  5R      5T        5U      $
 Date��5W       5V      �� *Date+ 5X      �� 5Y      " ��6$   .�5Z   "   ��  � �� 6?   �� *Sum+# [  5[      5]      .  (System.Windows.Interactivity.Interaction   Triggers 5_      /	  )System.Windows.Interactivity.EventTrigger	  5`       	  	EventName$ MouseDoubleClick��6%   .
  (System.Windows.Interactivity.TriggerBase 
  Actions. 5a      -  'Prism.Interactivity.InvokeCommandAction     Command 64   �� *SeeTotalDebtCommand+5b      5d      �� 5e      -   5         ��Name$	 Add��5e      $��3��5f      $
��_Add��5g      $��20��5h      $	��100��5i      ��5j      �� $ AddNewDebtCommand�5l      5m      5n      