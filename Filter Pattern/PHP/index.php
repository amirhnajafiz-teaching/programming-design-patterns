<?php

require_once "PrefixAndSuffixFilter.php";
require_once "CodeOrPrefixFilter.php";
require_once "Obj.php";


$list = [];

$list[] = new Obj(101, "PR", "OP");
$list[] = new Obj(102, "DR", "OP");
$list[] = new Obj(102, "PR", "OR");
$list[] = new Obj(104, "PR", "OR");
$list[] = new Obj(102, "DR", "OP");
$list[] = new Obj(101, "DR", "OR");
$list[] = new Obj(102, "PD", "OP");
$list[] = new Obj(104, "PD", "OR");

$filter_one = ( new PrefixAndSuffixFilter("PR", "OR") )->match($list);
$filter_two = ( new CodeOrPrefixFilter("PD", 104) )->match($list);

var_dump($filter_one);
var_dump($filter_two);

?>