   M S B A M L   `   `   `  ����R  NCandidateManagement_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CandidateManagement_WPFCandidateManagement_WPF  5   	   (    "CandidateManagement_WPF.JobPosting   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:CandidateManagement_WPF     5   	     � Title$  
JobPosting��5   	   $	��575��6   $	��800��6)   .��5	      � $��	0,19,0,20q�6   .+�5
   
   �� $��	PostingID��6   $
��Left=�6$   $��	56,62,0,0q�6?   $	��Top=�6R   $��16(�6j   �� 5   
   $��Job Posting Title��6   $
��Left=�6,   $��
56,132,0,0q�6G   $	��Top=�6[   $��16(�6s   �� 5   
   $��Description��6   $
��Left=�6&   $��498,132,0,0q�6A   $	��Top=�6V   $��16(�6n   �� 5   
   $��Posted Date��6   $
��Left=�6&   $��
493,62,0,0q�6A   $	��Top=�6U   $��16(�6m   �� 5   
   $��Job Posting��6   $��Center=�6&   $��0,10,0,0q�6C   $	��Top=�6U   $��32(�6m   $
��Bold"�6{   �� 5   
   -   5         ��Name$ 	idPosting��5      $
��Left=�6&   $��
119,98,0,0q�6A   $	��Top=�6U   $	��190��6m   $��24��6y   �� 5   
   -   5         ��Name$ txtPostingTitle��5      $
��Left=�6+   $��119,168,0,0q�6F    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��190��6�   $��24��6�   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $��535,168,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��190��6�   $��70��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
datePosted��5      $
��Left=�6)   $��
535,98,0,0q�6D   $	��Top=�6X   $	��190��6p   $��24��6|   &   System.Windows.Controls.DataGrid  5   
   $��	0,260,0,0q�6>   $	��189��6Q   $	��Top=�6^   �� 5   
   -   5         ��Name$ btnClose��5      $��Close��6#   $
��Left=�63   $��640,455,0,0q�6N   $	��Top=�6c   $��50��6{   $	��150��6�   $��16(�6�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��436,455,0,0q�6P   $	��Top=�6e   $��50��6}   $	��150��6�   $��16(�6�   ���	#FFFD5E5E6�   �� 5   
   -   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��223,455,0,0q�6P   $	��Top=�6e   $��50��6}   $	��150��6�   $��16(�6�   ���	#FF54F33F6�   �� 5   
   -   5        $ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
11,455,0,0q�6J   $	��Top=�6^   $��50��6v   $	��150��6�   $��16(�6�   ���	#FF3686E56�   5      5      