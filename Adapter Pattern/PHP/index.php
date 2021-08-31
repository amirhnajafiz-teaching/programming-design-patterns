<?php

require_once "TypeC.php";
require_once "TypeE.php";
require_once "TypeCToEAdapter.php";


$plug1 = new TypeC();
$plug2 = new TypeE();

$adapt = new TypeCToEAdapter(new TypeE());  # Storing a typeE in typeC

var_dump($plug1);
var_dump($plug2);
var_dump($adapt);

?>