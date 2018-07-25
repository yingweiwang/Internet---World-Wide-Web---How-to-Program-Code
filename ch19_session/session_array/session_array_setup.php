<?php
// begin the session
session_start();
 
// create an array
$my_array=array('cat', 'dog', 'mouse', 'bird', 'crocodile', 'wombat', 'koala', 'kangaroo');
 
// put the array in a session variable
$_SESSION['animals']=$my_array;
 
// a little message to say we have done it
echo 'Putting array into a session variable';
?>
