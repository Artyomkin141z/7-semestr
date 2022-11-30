<?php
	$dir = scandir('../test');
	$sum = 0;
	foreach($dir as $elem) {
		if(is_file('../test/'.$elem)) {
			$sum += round(filesize('../test/'.$elem)/1024/1024);
		}
	}
	echo $sum.' мб';
?>