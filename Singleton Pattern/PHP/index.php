<?php 

require_once "App.php";

$app = App::getInstance(12);

echo $app->getCode(); 

$new_app = App::getInstance(24); 

echo $app->getCode();


?>