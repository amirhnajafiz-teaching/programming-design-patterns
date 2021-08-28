<?php

require_once "Pool.php";


Pool::initialize(1);

$first = Pool::checkIn("Mydata");
$second = Pool::checkIn("New data");

var_dump($first);
var_dump($second);

Pool::checkOut($first);
$second = Pool::checkIn("New data");

var_dump($second);

?>