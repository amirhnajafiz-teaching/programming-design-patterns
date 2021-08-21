<?php

require_once "./Factory.php";


$obj = Factory::build('user');
$home = Factory::build('home');
$myuser = Factory::build('user');

echo $obj->init() . PHP_EOL;
echo $home->init();

?>