<?php
error_reporting(E_ALL);
ini_set('display_errors', 1);

function myHandler( )
{
    return true;
}

set_error_handler('myHandler', E_ALL);

function shutdown()
{
    $error = error_get_last();

    if (is_array($error) && in_array($error['type'], [E_ERROR, E_PARSE, E_CORE_ERROR, E_COMPILE_ERROR])) {
        while (ob_get_level()) {
            ob_end_clean();
        }

        echo '<h3>Server on technical servise, sorry :(</h3>';

        $file = fopen($error['file'], 'r');

        $line = 1;
        while (!feof($file)) {
            $text = htmlspecialchars(fgets($file));
            if ($line == $error['line']) {
                echo '<span style="color: darkred">'.$text.'</span><br>';
            } else {
                echo $text.'<br>';
            }
            ++$line;
        }
        fclose($file);
    }
}

register_shutdown_function('shutdown');

require_once 'not-exists.php';
throw new Exception(); ?>