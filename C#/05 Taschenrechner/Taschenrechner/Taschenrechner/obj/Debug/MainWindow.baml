   M S B A M L   `   `   `  ????I  ETaschenrechner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TaschenrechnerTaschenrechner  5   	       Taschenrechner.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Taschenrechner     5   	     ? Title$  Taschenrechner??5   	   $	??394??6    $??289.334??6-   ???	#FF141414 ? 
ResizeMode$ NoResize=?6T    ? Icon$ Taschenrechnericon.png??6j   .??5	      ? $	??364??6   $	??Top=?6   ???	#FF141414.+?5
   
   ?? -   5         ??Name$ 
txtAusgabe??5
      $??53??6&    ?? TextWrapping$
 Wrap=?62   $	??Top=?6F   {?.  $??	5 + 3 = 8??6p   $??36(?6?    ?? TextAlignment$ Right=?6?   $??MB Corpo A Title Cond)?6?   ???	#FF3C3C3C$??	11,14,0,0q?6?   
??????? J? RenderTransformOrigin$ 0.5,0.5&?6  $
??Left=?6<  $	??257??6W  ??6?   Z? .??6c  z?5      V? 5      .~?5      ?? ?? 5       ?? AngleX$
 0.67Q?6$   ?? 5      T? 5       T? X$ 0.322Q?6)   5      .??5   '   5      ?? 5   
   -   5        	 ??Name$	 BtnVier??5      $??4??6"   $
??Left=?6.   $??
10,200,0,0q?6I   $	??Top=?6]   $??65??6u   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -   5        $	 	BtnSieben??5      $??7??6$   $
??Left=?60   $??
10,150,0,0q?6K   $	??Top=?6_   $??65??6w   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -   5        $	 BtnEins??5      $??1??6"   $
??Left=?6.   $??
10,250,0,0q?6I   $	??Top=?6]   $??65??6u   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -   5        $	 BtnFuenf??5      $??5??6#   $
??Left=?6/   $??
75,200,0,0q?6J   $	??Top=?6^   $??65??6v   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -   5        $	 BtnAcht??5      $??8??6"   $
??Left=?6.   $??
75,150,0,0q?6I   $	??Top=?6]   $??65??6u   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -   5        $	 BtnZwei??5      $??2??6"   $
??Left=?6.   $??
75,250,0,0q?6I   $	??Top=?6]   $??65??6u   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -   5        $	 BtnSechs??5      $??6??6#   $
??Left=?6/   $??140,200,0,0q?6J   $	??Top=?6_   $??64??6w   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -	   5        $	 BtnNeun??5      $??9??6"   $
??Left=?6.   $??140,150,0,0q?6I   $	??Top=?6^   $??64??6v   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -
   5        $	 BtnDrei??5      $??3??6"   $
??Left=?6.   $??140,250,0,0q?6I   $	??Top=?6^   $??64??6v   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5   
   -   5        $	 BtnMinus??5      $??-??6#   $
??Left=?6/   $??204,250,0,0q?6J   $	??Top=?6_   $??65??6w   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   ???	#FF282828
?????????6?   Z? 6   ?? 5   
   -   5        $	 BtnMal??5      $??x??6!   $
??Left=?6-   $??204,200,0,0q?6H   $	??Top=?6]   $??65??6u   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   ???	#FF282828
?????????6?   Z? 6?   ?? 5   
   -   5        $	 BtnPlus??5      $??+??6"   $
??Left=?6.   $??204,300,0,0q?6I   $	??Top=?6^   $??65??6v   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   ???	#FF282828
?????????6?   Z? 6?   ?? 5    
   -   5        $	 BtnBerechne??5       $??=??6&   $
??Left=?62   $??140,300,0,0q?6M   $	??Top=?6b   $??64??6z   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   ???	#FF4337EC
?????????6?   Z? 6  ?? 5!   
   -   5        $	 BtnNull??5!      $??0??6"   $
??Left=?6.   $??
10,300,0,0q?6I   $	??Top=?6]   $??65??6u   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5"   
   -   5        $	 BtnKomma??5"      $??,??6#   $
??Left=?6/   $??
75,300,0,0q?6J   $	??Top=?6^   $??65??6v   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   
???   ?
?????????6?   Z? 6?   ?? 5#   
   -   5        $	 BtnClear??5#      $??C??6#   $
??Left=?6/   $??140,100,0,0q?6J   $	??Top=?6_   $??64??6w   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   ???	#FFF99D17
?????????6?   Z? 6   ?? 5$   
   -   5        $	 BtnLoeschen??5$      $??«??6&   $
??Left=?62   $??204,100,0,0q?6M   $	??Top=?6b   $??65??6z   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   $ 1.487,0.481&?6?   ???	#FFF99D17
?????????6  Z? 6'  ?? 5%   
   -   5        $	 
BtnGeteilt??5%      $??÷??6%   $
??Left=?61   $??204,150,0,0q?6L   $	??Top=?6a   $??65??6y   $??50??6?   $??MB Corpo A Title Cond)?6?   $??22(?6?   ???	#FF282828
?????????6?   Z? 6  5&      5'      