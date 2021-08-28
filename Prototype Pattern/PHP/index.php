<?php

require_once "BigObj.php";


$myObj = new BigObj(12, "First");

$temp = $myObj->clone()->clearWith(10, "Second");

echo $myObj->toString() . PHP_EOL;
echo $temp->toString();

?>