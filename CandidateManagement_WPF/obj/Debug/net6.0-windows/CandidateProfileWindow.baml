   M S B A M L   `   `   `  ����R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  5   	   4    .CandidateManagement_WPF.CandidateProfileWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CandidateManagement_WPF     5   	   -   5          � Title$  CandidateProfile��5   	   $	��582��6"   $	��800��6/    � WindowStartupLocation$ CenterScreen=�6;   ���	#FFD4F7D4.��5	      � $��	0,0,0,-16q�6   .+�5
   
   �� $ ��CANDIDATE PROFILE MANAGENT��6   $��Center=�65   $��0,10,0,0q�6R   $	��Top=�6d   $��32(�6|   $
��Bold"�6�   �� 5   
   $��FullName��6   $
��Left=�6#   $��	35,97,0,0q�6>   $	��Top=�6Q   $��16(�6i   �� 5   
   $
��Left=�6   $��
35,322,0,0q�6+   $	��Top=�6?   $��22(�6W   �� 5   
   $��BirthDay��6   $
��Left=�6#   $��
35,141,0,0q�6>   $	��Top=�6R   $��16(�6j   �� 5   
   $��Candidate ID��6   $
��Left=�6'   $��	35,53,0,0q�6B   $	��Top=�6U   $��16(�6m    J� RenderTransformOrigin$ 0.5,0.5&�6{   �� 5   
   $��Description��6   $
��Left=�6&   $��408,102,0,0q�6A   $	��Top=�6V   $��16(�6n   �� 5   
   $��	Image URL��6   $
��Left=�6$   $��
35,190,0,0q�6?   $	��Top=�6S   $��16(�6k   �� 5   
   $��JobPosting ID��6   $
��Left=�6(   $��
408,54,0,0q�6C   $	��Top=�6W   $��16(�6o   �� 5   
   -   5         ��Name$ idCandidate��5      $
��Left=�6'   $��
151,57,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��190��6�   $��16(�6�   ${�False��6�   �� 5   
   -   5        $ txtName��5      $
��Left=�6#   $��151,101,0,0q�6>   $
 Wrap=�6S   $	��Top=�6g   $	��190��6   $��16(�6�   �� 5   
   -   5        $ txtImg��5      $
��Left=�6"   $��151,198,0,0q�6=   $
 Wrap=�6R   $	��Top=�6f   $	��190��6~   $��16(�6�   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $��408,141,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��305��6�   $��16(�6�   $��80��6�   �� 5   
   -   5         ��Name$ 	cmbPostID��5      $
��Left=�6&   $��
523,56,0,0q�6A   $	��Top=�6U   $	��190��6m   $��24��6y   $��16(�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txtBirthday��5      $
��Left=�6*   $��151,149,0,0q�6E   $	��Top=�6Z   $	��190��6r   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgCandidateProfile��5      $��Center=�5         AutoGenerateColumns$ False��5      $��11,235,9,132q�5      $��12(�5      $	��640��5      $	��203��6   	 � 	Resources	 5       
 �� 
TargetType �� Property �� Value��%T   '��       �� 5!      "
 ��6   .�5"      ��  � ��$
 Wrap=�65   5#      5$         Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Candidate ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.4* 5)      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5(      �� *CandidateId+5)        5+      $ 	Full Name��6%   $ 1.25* 5-       5,      �� *
Fullname+5-        5/      $ Birthday��6%   $ 1.25* 51       50      �� *
Birthday+ �� StringFormat$ {0:MM/dd/yyyy}��51        53      $ Short Description��6%   $ 2* 55       54      �� *ProfileShortDescription+   ElementStyle 56      �� 57      "
 ��6    .�58      ��  � ��$
 Wrap=�6=   59      5;        5<      $ Profile URL��6%   $ 2* 5>       5=      �� *
ProfileUrl+5>        5@      $ 
Posting ID��6%   $ 1* 5B       5A      �� *	PostingId+5B      5D      �� 5E   
   -	   5         ��Name$ btnAdd��5E      $	��Add��6!   $
��Left=�6/   $��
11,455,0,0q�6J   $	��Top=�6^   $��50��6v   $	��150��6�   $��16(�6�   ���	#FF3686E5   RoundedButtonStyle#��[  6�   �� 5F   
   -
   5        $ 	btnUpdate��5F      $��Update��6$   $
��Left=�65   $��223,455,0,0q�6P   $	��Top=�6e   $��50��6}   $	��150��6�   $��16(�6�   ���	#FF54F33F6�   �� 5G   
   -   5        $ 	btnDelete��5G      $��Delete��6$   $
��Left=�65   $��436,455,0,0q�6P   $	��Top=�6e   $��50��6}   $	��150��6�   $��16(�6�   ���	#FFFD5E5E6�   �� 5H   
   -   5        $ btnClose��5H      $��Close��6#   $
��Left=�63   $��640,455,0,0q�6N   $	��Top=�6c   $��50��6{   $	��150��6�   $��16(�6�   6�   5J      5K      