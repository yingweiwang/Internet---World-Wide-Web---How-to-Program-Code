<?php
// begin the session
session_start();
 
// loop through the session array with foreach
foreach($_SESSION['animals'] as $key=>$value)
    {
    // and print out the values
    echo 'The value of $_SESSION['."'".$key."'".'] is '."'".$value."'".' <br />';
    }
?>
