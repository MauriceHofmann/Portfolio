   M S B A M L   `   `   `  ����L  HKontaktbuchMitCSV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:KontaktbuchMitCSVKontaktbuchMitCSV  5   	   "    KontaktbuchMitCSV.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:KontaktbuchMitCSV     5   	     � Title$  Kontaktbuch mit CSV��5   	   $	��305��6%   $	��650��62   .��5	      � -   5        $��0,0,0,-6q�5	      .+�5
   
   �� -   5         ��Name$ lstKontakte��5
      $��10,40,443,27q�6R   6h   �� 5   
   -   5         ��Name$ 
txtVorname��5      $
��Left=�6&   $��
325,57,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��230��6�   $��20��6�   �� 5   
   -   5        $ txtNachname��5      $
��Left=�6'   $��
325,82,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��230��6�   $��20��6�   �� 5   
   -   5        $ 
txtTelefon��5      $
��Left=�6&   $��325,107,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $	��230��6�   $��20��6�   �� 5   
   $��Vorname��6   $
��Left=�6"   $��
235,54,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Telefon-Nr.��6   $
��Left=�6&   $��235,104,0,0q�6A   $	��Top=�6V   �� 5   
   $��Nachname��6   $
��Left=�6#   $��
235,79,0,0q�6>   $	��Top=�6R   �� 5   
   $��Kontaktbuch mit CSV��6   $
��Left=�6.   $��10,0,0,0q�6I   $	��Top=�6[    J� RenderTransformOrigin$ -0.207,0.161&�6s   $��22(�6�   �� 5   
   -   5         ��Name$ btnNeuerKontakt��5      $��Neuer Kontakt��6*   $
��Left=�6B   $��235,179,0,0q�6]   $	��Top=�6r   $��35��6�   $	��100��6�   6�   �� 5   
   -   5        $ btnBearbeiten��5      $��
Bearbeiten��6(   $
��Left=�6=   $��366,179,0,0q�6X   $	��Top=�6m   $��35��6�   $	��100��6�   6�   �� 5   
   -   5        $ btnLoeschen��5      $��Löschen��6&   $
��Left=�68   $��497,179,0,0q�6S   $	��Top=�6h   $��35��6�   $	��100��6�   6�   5      5      