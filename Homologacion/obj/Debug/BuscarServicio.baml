   M S B A M L   `   `   `  ����G  CHomologacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:HomologacionHomologacion  5   	   !    Homologacion.BuscarServicio   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Homologacion     5   	     � Title$  BuscarServicio��5   	   $	��400��6    $	��700��6-   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FFA7FFD7��6   $ 1Q�61   5      .+�5   
   �� $
��Left=�6   $��40                 ��6,   $��-4,0,-150,0q�6I   $	��Top=�6^   $	��696��6v   .+�5      �� -   5         ��Name$ 
btEliminar��5      $��Eliminar Servicio��6)   $
��Left=�6E   $	��Top=�6`   $	��140��6x   $��40��6�    J� RenderTransformOrigin$ 0.293,0.527&�6�   ���	#FF70FFC4
���   �$��Medium"�6�   �� 5      -   5        $ 
btAgregar1��5      $��Agregar Servicio��6)   $
��Left=�6D   $	��Top=�6_   $	��140��6w   $��40��6�    �� Left$	 138��6�   ���	#FF70FFC4
���   �$��Medium"�6�   �� 5      -   5        $ btModificar��5      $��Modificar Servicio��6*   $
��Left=�6G   $	��Top=�6b   $	��140��6z   $��40��6�   $	 278��6�   ���	#FF70FFC4
���   �$��Medium"�6�   �� 5      -   5        $ 	btBuscar1��5      $��Buscar Servicio��6(   $
��Left=�6B   $	��Top=�6]   $	��140��6u   $��40��6�   $	 418��6�   ���	#FF70FFC4
���   �$��Medium"�6�   �� 5      -   5        $ btRegresar1��5      $��Salir��6*   $
��Left=�6:   $	��Top=�6U   $��140                 ��6m   $��40��6�   $	 558��6�   
���   �$��Medium"�6�   ���	#FF70FFC46�   5      �� 5   
   -   5         ��Name$ 	cbMateria��5      $
��Left=�6&   $��
48,102,0,0q�6A   $	��Top=�6U   $	��157��6m   6y   �� 5   
   -   5        $ cbDepartamento��5      $
��Left=�6+   $��250,102,0,0q�6F   $	��Top=�6[   $	��176��6s   �� 5   
   $��Materia��6   $
��Left=�6"   $��
250,60,0,0q�6=   $	��Top=�6Q   	 J� OpacityMask
	 �   ����	#66C2FFF96}   �� 5   
   $��Departamento��6   $
��Left=�6'   $��	48,60,0,0q�6B   $	��Top=�6U   $��36��6m   $��86��6y   ���	#66C2FFF9
	 �   �$ -1.21,0.634&�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        
  Name$
 	dgBuscar1��5      $
��Left=�6&   $	��188��6A   $��
43,150,0,0q�6N   $	��Top=�6b   $	��607��6z   �� 5   
   -	   5        $��Buscar��5      $
��Left=�6"   $��
476,89,0,0q�6=   $	��Top=�6Q   $	��114��6i   $��34��6�   ���	#FF4FF33E6�   5      5      