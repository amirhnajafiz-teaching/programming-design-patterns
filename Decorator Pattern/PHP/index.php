<?php

require_once "Base.php";
require_once "Obj.php";
require_once "SuperObj.php";
require_once "MasterObj.php"; 


$myobj = new Obj();
$highObj = new SuperObj(new Obj());
$veryHigh = new MasterObj(new Obj());

var_dump($myobj);
var_dump($highObj);
var_dump($veryHigh);

?>