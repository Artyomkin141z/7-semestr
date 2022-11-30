<?php
    session_start();
    if(!isset($_SESSION['t']))
    {
        $_SESSION['t'] = "This is sentence wrote in session";
    }
?>
<p><a href="zd42.php">Check content of session</a></p>