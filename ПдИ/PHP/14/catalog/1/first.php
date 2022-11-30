<?php
	$dir = scandir('../test');
	foreach($dir as $elem) {
		if(is_file('test/'.$elem)) {
			preg_match_all('#\<h1\>(.+)\</h1\>#', file_get_contents('test/'.$elem), $arr);
			rename('test/'.$elem, 'test/'.$arr[1][0].'.txt');
		}
	}
?>