<?php

require_once "Obj.php";

$myobj = (new Obj())
            ->code(101)
            ->meta("URL:TTR23EE")
            ->has_meta(TRUE)
            ->data("Objcet for storing my meta data.");

$second = (new Obj())
            ->data("Storing class.")
            ->has_meta(FALSE)
            ->code(202);

var_dump($myobj);
var_dump($second);

?>