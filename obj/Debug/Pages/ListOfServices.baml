   M S B A M L   `   `   `  ����N  JLearnLanguageSchool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LearnLanguageSchool.PagesLearnLanguageSchool.Pages  5      .    (LearnLanguageSchool.Pages.ListOfServices   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:LearnLanguageSchool.Pages     5        N� Title$  ListOfServices��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      6!   �� 5      $	��10* �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      $	��10* �6   6+   �� 5      6   .+�5   
   �� $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $	��Top=�6K   $��Center=�6c   .+�5      �� $��/Images/school_logo.png��6   $��50��65   $��50��6@   $
��Left=�6L   �� 5      $��200,10,150,10q�6   $
��Wrap=�6/   $��Список услуг��6C   $��18(�6W   $��Stretch=�6e   �� 5      $��Right=�6   .+�5      �� -   5         ��Name$ BtnBack��5      $��0,10,0,0q�6*   $��20��6<   $	��120��6H   $��
Выйти��6T   ���	#FF04A0FF6�   5      5      �� 5!   
   $��1��6   $��1��6%   $
��Left=�62   $	��Top=�6M   $��	10 60 0 0q�6e   $ 
Horizontal=�6x   .+�5"      �� -   5        $��CmbxSort��5"      $��10q�6'   $��20��63   $	��150��6?   .@�5#      �� .��6   По возрастанию6/   �� 5$      .��6   По убыванию6,   5%      �� 5&      -   5        $��CmbxDiscountRange��5&      $��10q�60   $��20��6<   $	��150��6H   .@�5'      �� .��6   Все6$   �� 5(      .��6   от 0% до 5%6,   �� 5)      .��6   от 5% до 15%6-   �� 5*      .��6   от 15% до 30%6.   �� 5+      .��6   от 30% до 70%6.   �� 5,      .��6   от 70% до 100%6/   5-      �� 5.      $��10q�6   	Search:6.   �� 5/      -   5         ��Name$ Search��5/      $	��200��6&   $��20��62   $��10q�6>   6m   50      �� 52   
   -   5         ��Name$ ListItemsAdmin��52      $��	0 100 0 0q�6+   $y�	Collapsed=�6>   $��1��6U   $��1��6e   ��53      �� 54      .R�55      �� $ 
Horizontal=�6!   .+�56      �� $	��150��6    $	��150��6,   ��69   �� *MainImagePath+�� 57      $��10q�6%   .+�58      �� $��15(�6(   ��66   �� *Title+�� 59      $ 
Horizontal=�6)   .+�5:   "   �� $��15(�6,   $��Strikethrough{�6:   ��6Z   �� *CostStrikethrough+�� 5;   "   $��15(�6,   ��6:   �� *DiscountedPrice+5<      �� 5=      $��13(�6(   ��66   �� *DiscountString+�� 5?      $��20��6)   67   �� 5A      $ 
Horizontal=�6)   .+�5B   "   �� -   5        $ ��Редактировать��5B   )   $��10q�6A   
�������$��5q�6`   6l   �� 5C   "   -   5        $��Удалить��5C   )   $��10q�6;   
�������$��5q�6Z   6f   5D      5E      5F      5G      5I      �� 5K   
   -   5        $ 	ListItems��5K      $y�	Collapsed=�6&   $��1��6=   $��1��6M   $��	0 100 0 0q�6Z   ��5L      �� 5M      .R�5N      �� $ 
Horizontal=�6!   ��6;   �� *ColorBackground+.+�5O      �� $	��150��6    $	��150��6,   ��69   �� *MainImagePath+�� 5P      $��10q�6%   .+�5Q      �� $��15(�6(   ��66   �� *Title+�� 5R      $ 
Horizontal=�6)   .+�5S   "   �� $��15(�6,   $��Strikethrough{�6:   ��6Z   �� *CostStrikethrough+�� 5T   "   $��15(�6,   ��6:   �� *DiscountedPrice+5U      �� 5V      $��13(�6(   ��66   �� *DiscountString+�� 5W      $��20��6)   67   5X      5Y      5Z      5\      �� 5^   
   $��1��6   $��1��6"   $ 
Horizontal=�62   $��Bottom=�6K   $��Center=�6f   .+�5_      �� -	   5         ��Name$ 
NumberFrom��5_      $��Center=�6,   06L   �� 5`      $��Center=�6   \68   �� 5a      -
   5        $ NumberTo��5a      $��Center=�6*   06J   5b      5c      5d      