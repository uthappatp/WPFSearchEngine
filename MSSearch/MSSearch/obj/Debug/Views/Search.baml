   M S B A M L   `   `   `  ����  MSSearch    MSSearch.Views.Search   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ` \Xceed.Wpf.Toolkit, Version=3.1.16356.12170, Culture=neutral, PublicKeyToken=ba83ff368b7563c64xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      .��5
      �    TopGrid#��[  6     � RowDefinitions  5   
   �� 5      $��40 �6   �� 5      $��* �6   .+�5   
   �  
 Header#��[ 6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��200 �6#   �� 5      $��50 �6#   .+�5      ��   TitleBorder#��[ 6   ._�5      ��   	TitleText#��[ 6\   ��6   �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�6\   5      �� 5      $��1��62   $��1,3,1,1q�6B   ��6   �� *
SearchText+6B   �� 5      $��2��6   $��Search��6W     SearchButton#��[ 6h   ��6%   ��  �� Path$ LoadSearchStoriesCommand�6h   5      %  Xceed.Wpf.Toolkit.BusyIndicator  5    
   $��1��6      IsBusy 6*   �� *IsBusy+   BusyContent 6D   �� *
IsBusyText+.��5!      �� .��5"      ��   StoriesList#��[ 6M   ��6   �� *SearchStories+ �� Mode$ TwoWay=���5$      �� 5%      .R�5&      �  5'   "   �� 5(   &   $��80 �67   �� 5)   &   $��* �67   .+�5+   "   �� $��5q�6)   
���   �$��1q�6H   ._�5,   &   �� $
��Fill=�6J   $��80��6Y   $��80��6d   ��6,   �� $ Image�6d   5-   #   �� 5.   "   $��1��6-   $��5q�6=   .+�5/   &   ��  �� Orientation$ 
Horizontal=�61   $
��Bold"�6J   .+�50   *   ��   HyperLinkButtonStyle#��[ 51   )   $��Center=�6|   $��Center=�6�   ��50   1   ��  �� RelativeSource �� *FindAncestor+	 �� AncestorType"	 ��$! DataContext.OpenLinkCommand���6�   �� *
HrefLink+��51   W   �� $ Description�6�   53   '   �� 54   &   ��60   �� $
 Site��� 55   &   ��60   �� $ Title��� 56   &   ��60   �� $ PublishedDate�57   #   58      59      5<      5=      5>      5@      5A      