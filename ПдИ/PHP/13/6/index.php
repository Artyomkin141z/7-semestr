<?php
    session_start();

?>
<body>
    <form method="POST">
        <h1>Enter your credentials</h1>
        <p>Enter your name:<input type="text" name="nam"/></p>
        <p>Enter your country:<input type="text" name="countr"/></p>
        <p><input type="submit" value="Save credentials"/></p>
    </form>
    <?php 
        if (isset($_POST["nam"]) && isset($_POST["countr"])){
            $_SESSION["nam"]=$_POST["nam"];
            $_SESSION["countr"]= $_POST["countr"];
        }
    ?>
<p><a href="test.php">Check content</a></p>
</body>
