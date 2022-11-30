<?php 
    session_start();

    if(!isset($_SESSION['counter']))
    {
        echo "You are not reset page";
        $_SESSION['counter']=0;
    }else{
        $_SESSION['counter']++;
        echo "Amount of reset equal: ". $_SESSION['counter'];
    }
?>