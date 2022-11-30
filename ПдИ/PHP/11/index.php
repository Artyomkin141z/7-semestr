<!DOCTYPE html>
<html>
<head>
<title>Laba 11</title>
<meta charset="utf-8" />
</head><BODY>
<?php
function is_prime ($n)
{
    for($x=2; $x <= sqrt($n); $x++) {
        if($n % $x == 0) {
            return false;
        }
    }
    return true;
}
$arr;
$value =0;
if(isset($_POST["size"])){
$size = $_POST["size"];
$arr = range(1, $size);  
}
if(isset($_POST["value"])){
$value = $_POST["value"];
switch ($value) {
    case 1:
        for ($i=2; $i<=$size; $i+=2) {
            echo $i." ";
            }      
        break;
    case 2:
        for ($i=1;$i<=$size;$i+=2) {
            echo $i." ";
            }
        break;
    case 3:
        for ($i=1;$i<=$size;$i++) {
            if (is_prime($i)) echo $i." ";
            }
        break;
    case 4  :
        for ($i=1;$i<=$size;$i++) {
            if (!is_prime($i)) echo $i." ";
            }
        break;  
}
}
?>
<H1> Вывод делителей: </H1>
<FORM  method="post">
    Введите число: <INPUT type="text" name="size">
    <p>Какие делители вывести: 
    <SELECT  name="value" size="1">
        <OPTION  value="1"  SELECTED> Четные делители
        <OPTION  value="2"> Нечетные делители
        <OPTION  value="3"> Простые делители
        <OPTION  value="4"> Составные делители
    </SELECT>
    <P> <INPUT type="submit" value="Результат">
</FORM>
</HTML> 
</BODY>
</html>