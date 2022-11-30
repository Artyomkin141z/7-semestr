<?php

function myAutoload($script){
    if ($_SERVER['SCRIPT_NAME'] != '/'.$script) {
        echo 'Trying catch file '.$script.'<br>';
        include_once $script;
        echo '<br>';
    }
}

$dir = array_diff(scandir(__DIR__), ['..', '.']);

echo '<h4>Archive original:</h4>';
echo '<pre>';
print_r($dir);
echo '</pre>';

foreach ($dir as $key => &$val) {
    if (!is_file($val)) {
        //echo 'No file: '.$val.'<br>';
        unset($dir[$key]);
    } else {
        //echo 'File: '.$val.'<br>';
        myAutoload($val);
    }
}

echo '<h4>Archive changed:</h4>';
echo '<pre>';
print_r(array_values($dir));
echo '</pre>';

$scr02 = new Script02();
$scr03 = new Script03();
$scr04 = new Script04(); 

?>