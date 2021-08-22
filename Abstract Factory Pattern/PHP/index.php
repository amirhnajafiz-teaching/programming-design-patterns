<?php

require_once "AbstractFactory.php";


AbstractFactory::init();


$myGif = AbstractFactory::$VIDEO->build("gif");
$music = AbstractFactory::$AUDIO->build("mp3");

echo $myGif->getInfo() . PHP_EOL;
echo $music->getInfo();

?>