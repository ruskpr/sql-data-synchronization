   M S B A M L   `   `   `  ????F  BSyncApp_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:SyncApp_GUI.PagesSyncApp_GUI.Pages  5      $    SyncApp_GUI.Pages.GenerateData   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:SyncApp_GUI.Pages     5        N? Title$  GenerateData??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $	??250 ?6   ?? 5      $??55 ?6   ?? 5      $??* ?6   ?? 5      $??20 ?6    ? ColumnDefinitions 5   
   ?? 5      $??20 ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??20 ?6   .+?5   
   ?? $??1??6   $??3??5      .+?5      ??  $   MaterialDesignHeadline4TextBlock#??[  6   
???????$??Offline Data Store??5       ?? 5!       $  MaterialDesignSubtitle1TextBlock#??[ 6   
???????${??uOn this page you can view your offline data store where all your unsynchronized data is wait for an online connection??5#      $
??Wrap=?5$      $??50??5%      ?? 5&       ?? Orientation$ 
Horizontal=?6   .+?5'      ?? $%??Number of records to generate: ??6   $??Center=?5(      $??16(?5)      ?? 5*      -   5         ??Name$ tbNumRecords??5*      $	??150??5+      $??50??5,      $??20(?5-      
???????$??Center=?5/       ?? AcceptsReturn$
 True??50        MaterialDesignTextBox#??[ 51      $??35??52       ?? TextWrapping$ NoWrap=?53      ?? 55      -   5         ??Name$ btnGenerate??55      $
??Left=?57      $??20q?58      $	??200??59      $??Generate random data??5:        MaterialDesignRaisedButton#??[ 5;      5>      ?? 5A      -   5         ??Name$ 
lbErrorMsg??5A      
???  ??$?? ??5C      $??0,10,0,0q?5D       ! MaterialDesignButtonTextBlock#??[ 5E      ?? 5F      5I      5J      ?? 5L   
   $??1??6   $??1??5M      $??3??5N      .+?5P      ?? -   5        	 ??Name$	 lbRecordsToSync??5P      $??Records to sync: ??5Q      62   ?? 5R      -   5        $	 lbDataStorePath??5R      $??Data store path: ??5S      62   ]? 5U      5X      5Z      &   System.Windows.Controls.DataGrid  5\   
   -   5        
  Name$
 dgData??5\      $??2??5]      $??1??5^      $??3??5_         CanUserAddRows$ False??5`         
IsReadOnly$
 True??5a         AutoGenerateColumns$
 True??5b         SelectionMode$ Extended=?5c         SelectionUnit$
 Cell=?5d      5e      5h      