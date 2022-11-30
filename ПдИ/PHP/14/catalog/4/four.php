<?php
	$arr = [];
	function show_dir($dir_name)
	{   $sum = 0;
		$dir = scandir($dir_name);
		unset($dir[0], $dir[1]);
			foreach($dir as $elem) {
				$str = $dir_name;
				if(is_file($dir_name.'/'.$elem)) {
					$sum += round(filesize($dir_name.'/'.$elem)/1024/1024);
				}
				if(is_dir($dir_name.'/'.$elem)) {
					$str .= '/'.$elem;
					$arr [$elem]= show_dir($str);
				}
			}
		return $sum;
	}
	echo show_dir('../test');
?>