<?php 
    session_start();
    if(isset($_SESSION['nam']) && isset($_SESSION['countr']))
    {
        echo "Hello ".$_SESSION['nam']." You are living in country ".$_SESSION['countr'];
    }
    else {
        echo "Sorry We don't have information about you";
    }
?>