<?php
	$dir = scandir('../test');
	foreach($dir as $elem) {
		if(is_file('../test/'.$elem) and filesize('../test/'.$elem)/1024/1024 > 1) {
			unlink('../test/'.$elem);
		}
	}
?>