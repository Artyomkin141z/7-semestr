<?php
$login = ["admin" =>1111,"Roma" =>2222,"Artem" =>3333,"Pavel" =>4444,"Sergey" =>5555];
if(isset($_GET["login"]) && array_key_exists($_GET["login"],$login)){ 
    if(isset($_GET["password"]) && $login[$_GET["login"]] == $_GET["password"]){
        echo "Hello Ivanov ", $_GET["login"], " Ivanovich <br>";
    }else{ echo "Не верный пароль<br>"; }
    }else{ echo "Пользователь не зарегистрирован<br>"; }
    
?>  