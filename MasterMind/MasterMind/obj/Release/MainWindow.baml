   M S B A M L   `   `   `  ���� E  AMasterMind, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MasterMind
MasterMind      MasterMind.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:MasterMind       � 
ResizeMode$  NoResize=� � Title$ Master Mind��$	��700��$	��615�� � Icon$ Pictures/smile.ico�� � 	Resources    StyleStackPanel �� 
TargetType �� Property �� Value  StyleEllipse  StylePicture��%�  &	        &	 �     &	 `    �� " ��.���  �@��Orientation$ 
Horizontal=���  � ��$ 45����  � ��$ 45����  � ��
 ��� ���  � ��$
 Left=���  � ��$	 Top=���  � ��$ 3,0,3,0q��� " A�.���  � ��$ 41����  � ��$ 41����  � ��
 ��� ���  � ��$
 Left=���  � ��$	 Top=���  � ��$ 5,0,5,0q��� " ��.���  � ��$ 41����  � ��$ 41��.��� -    �Name$ GridMain��
����  �.+��� -    ��Name$ StackPanelInput��	 �� Orientation$	 Vertical=�
����  �$
��Left=�$	��318��$��	50,86,0,0q�$	��Top=�$	��222��.+��� -   $ StackPanelInput1��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,10,5,5q��� -   $ StackPanelInput2��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelInput3��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelInput4��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelInput5��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelInput6��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -	   $ StackPanelResult��$	 Vertical=�
����  �$��Right=�$	��318��$��	0,86,50,0q�$	��Top=�$	��222��.+��� -
   $ StackPanelOutput1��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,10,5,5q��� -   $ StackPanelOutput2��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelOutput3��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelOutput4��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelOutput5��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelOutput6��$	 
Horizontal=�$	��208��$��41��$	��Top=�$��5,5,5,5q��� -   $ StackPanelControl��$	 
Horizontal=�
����  �$��Center=�$��85��$��
72,0,82,73q�$��Bottom=�$	��455��.+��� -   $ StackPanelSmile��$
��Left=�$��64��$��	10,10,5,5q�$	��Top=�$��64��.+��� $��Pictures/SmileT.png���� -   $ StackPanelHerc��$
��Left=�$��64��$��5,10,5,5q�$	��Top=�$��64��.+��� $��Pictures/Herc.png��$��64���� -   $ StackPanelCaro��$
��Left=�$��64��$��5,10,5,5q�$	��Top=�$��64��.+��� $��Pictures/Caro.png��$��64���� -   $ StackPanelPic��$
��Left=�$��64��$��5,10,5,5q�$	��Top=�$��64��.+��� $��Pictures/Pic.png��$��64���� -   $ StackPanelTref��$
��Left=�$��64��$��5,10,5,5q�$	��Top=�$��64��.+��� $��Pictures/Tref.png��$��64���� -   $ StackPanelStar��$
��Left=�$��64��$��	5,10,10,0q�$	��Top=�$��64��.+��� $��Pictures/Star.png��$��64���� -   $ StackPanelTarget��$	 
Horizontal=�
����  �$
��Left=�$��51��$��
50,424,0,0q�$	��Top=�$	��222��.+��� $
��Left=�$��41��$��10,5,5,5q�$	��Top=�$��43��.+��� -   
 ��Name$
 TargetImage1��$��Pictures/questionmark.png��#��[ �� $
��Left=�$��41��$��5,5,5,5q�$	��Top=�$��43��.+��� -   $
 TargetImage2��$��Pictures/questionmark.png��#��[ �� $
��Left=�$��41��$��5,5,5,5q�$	��Top=�$��43��.+��� -   $
 TargetImage3��$��Pictures/questionmark.png��#��[ �� $
��Left=�$��41��$��5,5,5,5q�$	��Top=�$��43��.+��� -   $
 TargetImage4��$��Pictures/questionmark.png��#��[ �� -    ��Name$ 	LabelTime��$��00:00��$��30(�$
��Bold"�$��50,20q�$	��100��$��50��$
��Left=�$	��Top=��� -    ��Name$ ButtonNewGame��$��New game��$��20(�$��3q�
����  �$��Center=�$��Center=�
���/���$
��Bold"�$��Right=�$��	0,30,50,0q�$	��Top=�$	��122��$��40���� -   $ ButtonEnter��$��Enter��$��20(�$��3q�
����  �$��Center=�$��Center=�
����� �$
��Bold"�$��Right=�$��
0,424,50,0q�$	��Top=�$��82��$��51���� -   $ ButtonDelete��$��Delete��$��20(�$��3q�
����  �$��Center=�$��Center=�
����� �$
��Bold"�$��Right=�$��0,424,190,0q�$	��Top=�$��82��$��51���� 
����� �$��15q� �� Padding$ 5q� K� ZIndex$ -1��� -    $ 
GridRecord��
����  �$y�Hidden=�$ 1��.+��� -!   $ ButtonClose��$��Close��$��Center=�$��	0,0,0,115q�$��Bottom=�$��76��&   System.Windows.Controls.DataGrid  -"     Name$ DataGridRecord��$��5,5,5,5q�   HeadersVisibility$ Column=�   
IsReadOnly . $��22(�$
��Bold"�   AutoGenerateColumns .   �� AlternationCount$ 2��   AlternatingRowBackground
 �����$��Stretch=�$	��381��$��10,10,10,30q�$��Stretch=����� *NewlistRecord+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  ��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Number+  $
 Name��$ *  �� *Name+  $
 Time��$ *  �� *Time+