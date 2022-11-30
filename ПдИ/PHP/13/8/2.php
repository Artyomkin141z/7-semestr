<?php
	session_start(); 


	if(!empty($_SESSION['email']))
		$email = $_SESSION['email'];
	else
		$email = '';
?>

<form action="" method="GET">
	<input type="text" name="name">
	<input type="text" name="surname">

	<input type="email" name="email" value="<?php echo $email ?>">

	<input type="submit">
</form>