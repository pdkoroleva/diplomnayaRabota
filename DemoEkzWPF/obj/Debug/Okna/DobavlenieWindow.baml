   M S B A M L   `   `   `  ����E  ADemoEkzWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DemoEkzWPF.OknaDemoEkzWPF.Okna  5   	   &     DemoEkzWPF.Okna.DobavlenieWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:DemoEkzWPF.Okna     5   	     � Title$  7. Добавление��5   	   $	��550��6   $	��850��6,   $	��550��68   $	��850��6H    � Icon$, &/DemoEkzWPF;component/Ikonki/kitty.ico��6W    � WindowStartupLocation$ CenterScreen=�6�    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	       �� 
TargetType �� 	Resources �� Property �� Value�� 5
   
   %�  '��       '�� �     �� 5      " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 20��69   6F   5      5      5      �� 5      " ��6   .�5      ��  � ��$ 18(�6-   6:   �� 5       � ��$ Century Gothic)�6/   6H   �� 5       � ��$
 Wrap=�61   6@   �� 5       �@��TextAlignment$ Center=�62   6C   5      5      ��5      �� 5   
   	 �� EndPoint$	 0.4,1&�6   
 �� 
StartPoint$
 0.6,0&�6/   .��5      �  � Color$ 	#FF3D37B2��6    � Offset$ 0Q�6-   � 5      $ 	#FFFFEE85��6   $ 1Q�6-   5      .��5       � .+�5!   
   �� -   5         ��Name$ 	MenuImage��5!   /   $-��'/DemoEkzWPF;component/Kartinki/menu.png��6C   $��30��6t   $	��Top=�6   $��Right=�6�   $��0,5,5,0q�6�    � Cursor$
 Hand��6�   �� 5"   
   $��Добавление��6   $��0��6'   $
��Wrap=�67   $��36(�6K   
�������$��Century Gothic)�6l   $
��Bold"�6�   $	��234��6�   $��50��6�   $
��Left=�6�   $��Bottom=�6�   z�5#      �� 5$       �� Angle$	 -90Q�6"   5&      �� 5'   
   $��1��6   
�������$��50,25,25,50q�64    J� Opacity$	 0.7Q�6I    �� CornerRadius$ 30��6W    �� Padding$ 50q�6i   ._�5(      �� $��Center=�6   .+�5)      �� $��0,0,0,10q�6   ywОдна из основных функций Вашего приложения на демоэкзамене - это �� 6q   ���	#FF3C4BAA$
��Bold"�6�   .�6�   добавление6�   ��. Оно нужно не только для добавления товаров/услуг, но и в регистрации пользователей (фактически - добавление пользователей).6-  �� 5*      ���	#FF11194D$��0,0,0,10q�63   ��Важно обратить внимание на валидацию полей и их ограничения по вводу, ипользование специальных элементов �� 6�   ���	#FFA7B0EC$��Italic$�6�   .�6�   20(например, для даты - DatePicker)6   31, которые упрощают процесс.6!  �� 5+      -   5         ��Name$ FOshibkiTextBlock��5+      ���	#FF11194D$��0,0,0,10q�6u   $��	Underline{�6�   $
 Hand��6�   �� 6�   ���	#FF3C4BAA$
��Bold"�6�   .�6�   rpТакже помните про избежание фатальных ошибок при добавлении.6  6#  5,      5-      �� 5.   
   -   5         ��Name$ ProsmotrZadaniaButton��5.      $��40��6S   $	��148��6_   ���	#FF3C4BAA$��Century Gothic)�6�   $��18(�6�   
�������$��	50,0,0,63q�6�   $
 Hand��6�   $��Bottom=�6�   $
��Bold"�6�   .��6  Задание6  �� 5/   
    �� Orientation$ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6I   $��50,0,0,0q�6f   .+�50      �� -   5        $ NazadButton��50      $��40��6C   $��70��6O   ���	#FF3C4BAA$��Century Gothic)�6q   $��22(�6�   
�������$	��0,5q�6�   $
��Bold"�6�   $
 Hand��6�   .��6�   ←6�   �� 51      -   5        $ VperedButton��51      $��40��6E   $��70��6Q   ���	#FF3C4BAA$��Century Gothic)�6s   $��22(�6�   
�������$��10,5,0,5q�6�   $
 Hand��6�   .��6�   →6�   52      �� 53   
   -   5        $ DocxPodklImage��53       � ToolTip$5 /Код-пример для добавления��6L   $3��-/DemoEkzWPF;component/Kartinki/kitty_word.png��6p   $	��167��6�   $��Right=�6�   $��Bottom=�6�   $��0,0,0,10q�6�   $
 Help��6�   � 54   
   -   5         �Name$ 
ZavesaGrid��54   3   $y�	Collapsed=�6   $	��850��6'   ���	#FF878787$ 0.525Q�6^   $��0,0,-8,0q�6n   � 55   
   -   5        $ MenuGrid��55   '   $y�	Collapsed=�6   $��0q�69   $	��398��6D   $��Right=�6P   ��56      �� 57      $	 0.5,1&�6&   $
 0.5,0&�67   .��58      � $ 	#FF221B6A��6#   $ 0Q�65   � 59      $ 	#FF6F6AA0��6#   $ 1Q�65   � 5:      $ 	#FF3A3287��6#   $ 0.532Q�65   5;       � RowDefinitions 5=      �� 5>      �� 5?      �� 5@      �� 5A      �� 5B      �� 5C      �� 5D      �� 5E      �� 5F      �� 5G      �� 5H      �� 5I      �� 5J      �� 5K      �� 5L      .+�5N      �� -	   5        $ ZakrytMenuButton��5N      $��28��6M   $��Right=�6X   $��Center=�6t   $��28��6�   $��0,0,15,0q�6�   $��18(�6�   ���	#FFF3E90D���	#FF3939F0.��6�   ✘6�   �� 5O      $��0��6   $��20(�6%   $��	60,0,60,5q�6N   $��Center=�6a   $��Center=�6|   
�������$
��Bold"�6�   ��63   Z� Быстрый переход6�   �� 5P      -
   5        $ StrukturaTextBlock��5P      $��1��6\   $��16(�6i   $��	Underline{�6w   $��	60,0,60,5q�6�   $
 Hand��6�   $��Center=�6�   $��Right=�6�   
�������&$1. Структура проекта6  �� 5Q      -   5        $ RazmetkaTextBlock��5Q      $��2��6Z   $��16(�6g   $��	Underline{�6u   $��	60,0,60,5q�6�   $
 Hand��6�   $��Center=�6�   $��Right=�6�   
�������&$2. Разметка страницы6  �� 5R      -   5        $ PodkluchenieTextBlock��5R      $��3��6b   $��16(�6o   $��	Underline{�6}   $��	60,0,60,5q�6�   $
 Hand��6�   $��Right=�6�   $��Center=�6�   
�������#!3. Подключение к БД6  �� 5S      -   5        $ FatalnyeOshTextBlock��5S      $��4��6a   $��16(�6n   $��	Underline{�6|   $��	60,0,60,5q�6�   $
 Hand��6�   $��Center=�6�   $��Right=�6�   
�������.,4. Предотвращение ошибок6  �� 5T      -   5        $ AvtorizaciaTextBlock��5T      $��5��6a   $��16(�6n   $��	Underline{�6|   $��	60,0,60,5q�6�   $
 Hand��6�   $��Right=�6�   $��Center=�6�   
�������+)5. Авторизация по ролям6  �� 5U      -   5        $ VyvodTextBlock��5U      $��6��6T   $��16(�6a   $��	Underline{�6o   $��	60,0,60,5q�6�   $
 Hand��6�   $��Right=�6�   $��Center=�6�   
�������&$6. Вывод данных из БД6  �� 5V      -   5        $ DobavlenieTextBlock��5V      $��7��65   $��16(�6B   $��	60,0,60,5q�6k   $��Center=�6~   $��Right=�6�   ���	#FFDDE61C$
��Bold"�6�   ��6P   Z� 7. Добавление6�   �� 5W      -   5        $ IzmenenieTextBlock��5W      $��8��6\   $��16(�6i   $��	Underline{�6w   $��	60,0,60,5q�6�   $
 Hand��6�   $��Right=�6�   $��Center=�6�   
�������8. Изменение6  �� 5X      -   5        $ UdalenieTextBlock��5X      $��9��6Z   $��16(�6g   $��	Underline{�6u   $��	60,0,60,5q�6�   $
 Hand��6�   $��Right=�6�   $��Center=�6�   
�������9. Удаление6	  �� 5Y      -   5        $ PoiskTextBlock��5Y      $��10��6T   $��16(�6b   $��	Underline{�6p   $��	60,0,60,5q�6�   $
 Hand��6�   $��Right=�6�   $��Center=�6�   
�������10. Поиск6  �� 5Z      -   5        $ ZapolnenieCBTextBlock��5Z      $��11��6b   $��16(�6p   $��	Underline{�6~   $��0,0,60,5q�6�   $
 Hand��6�   $��Right=�6�   $��Center=�6�   
�������2011. Заполнение ComboBox'ов из БД6&  �� 5[      -   5        $ SortirovkaTextBlock��5[      $��12��6^   $��16(�6l   $��	Underline{�6z   $��	60,0,60,5q�6�   $
 Hand��6�   $��Center=�6�   $��Right=�6�   
�������12. Сортировка6  �� 5\      -   5        $ FiltraciaTextBlock��5\      $��13��6\   $��16(�6j   $��	Underline{�6x   $��	60,0,60,5q�6�   $��Center=�6�   $��Right=�6�   
�������$
 Hand��6�   13. Фильтрация6  �� 5]      -   5        $ ZakluchenieTextBlock��5]      $��14��6`   $��16(�6n   $��	Underline{�6|   $
��60,0q�6�   $
��Bold"�6�   $��Right=�6�   $��Center=�6�   
�������$
 Hand��6  Заключение6  5^      5_      5`      