<body>
<H1> Удаление строки: </H1>
<FORM  method="get">
  Введите число: <INPUT type="text" name="row">
  <P> <INPUT type="submit" value="Результат">
</FORM>
</body>

<?php
if(isset($_GET["row"])) 
{$row = $_GET["row"]; 
    echo $row ." <br>" ;
$filename = 'co.txt';
$handle = fopen($filename, "r");
$myfile = fopen("testfile.txt", "w");

$file_arr = file($filename); 
$lines = count($file_arr); 

for ($i = 0; $i < $lines; $i++) {
    echo htmlspecialchars($file_arr[$i]), '<br />';
    if($row-1 != $i) fwrite($myfile, htmlspecialchars($file_arr[$i]));  
}
    echo "<br>";
fclose($handle);
fclose($myfile);
 
unlink($filename);
rename("testfile.txt", "co.txt" );

 $file_arr = file($filename); 
 $lines = count($file_arr); 

 for ($i = 0; $i < $lines; $i++) {
     echo htmlspecialchars($file_arr[$i]), '<br />';
}

$_GET["row"] = null;
$row= null;
}
 
?>