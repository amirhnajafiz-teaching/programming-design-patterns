<?php

require_once "Amodel.php";
require_once "Bmodel.php";
require_once "Ctype.php";
require_once "Dtype.php";


$obj1 = new Amodel(new Ctype());
$obj2 = new Bmodel(new Dtype());

echo $obj1->getModel() . PHP_EOL;
echo $obj2->getModel();

?>