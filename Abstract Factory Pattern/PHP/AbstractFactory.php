<?php

require_once "./Audio/AudioFactory.php";
require_once "./Video/VideoFactory.php";
require_once "Factory.php";

class AbstractFactory
{
    public static $AUDIO = new AudioFactory();
    public static $VIDEO = new VideoFactory();
}

?>