   M S B A M L   `   `   `  ����A  =UT5E04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:UT5E04UT5E04  5   	       UT5E04.Mantenimiento   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:UT5E04     5   	     � Title$  Reservas��5   	   $	��450��6   $	��800��6'    � 	Resources 5	         UT5E04.AsisteConverter   AsisteConverter��%   &	          5
   
   6:   5      .��5      ]� .+�5   
   � $��Bottom=�6   
�������.+�5      �� -   5         ��Name$ 	lblFiltro��5      $��
Sin filtro��6'   $
��Left=�6<   �� 5      -   5        $ lblRegistros��5      $��6 registros��6*   $��Right=�6@   5      ]� 5   
   $	��Top=�6   .+�5      �� -   5         ��Name$ btnNueva��5      $��Nueva��6'   $��Right=�67   $��50��6N   $��5q�6Y   6d   �� 5      -   5        $ 
btnFiltrar��5      $��Filtrar��6)   $��Right=�6;   $��50��6R   $��0,5,55,5q�6]    �� 	IsDefault . 6o   �� 5      -   5         ��Name$ 	txtFiltro��5      $��5,5,0,5q�6)   5      � 5   
   .+�5      �� -   5         ��Name$ 
lvReservas��5      $��5q�6+   $��Visible=�66    �� SelectionMode$ Single=�6i    �� View 5      �� 5      .P�5      �� $��Fecha��6)   	 �� Width$		 120��68   
 �� DisplayMemberBinding
 6D   �� *Fecha+ �� ConverterCulture$ es-ES�� �� StringFormat$  {0:dd/MM/yyyy}���� 5      $��Nombre��6)   $		 120��69   
 6E   �� *Nombre+�� 5      $��
Comensales��6)   $		 100��6=   
 6I   �� *
Comensales+�� 5      $��Asiste��6)   $		 150��69   
 6E   �� *Asiste+ �� 	Converter# [  5       � ContextMenu 5!      �� 5"      .@�5#      m� -   5         m�Name$ cmiNuevo��5#   #   $��Nuevo��65   6D   m� 5$      -   5        $ cmiModificar��5$   #   $��	Modificar��69   6L   m� 5%      -	   5        $ 	cmiBorrar��5%   #   $��Borrar��66   6F   �� 5&      m� 5'      -
   5        $ cmiConfirmar��5'   #   $��	Confirmar��69   6L   5(      5*      5+      5,      5-      