<?php

require_once "./Audio/AudioFactory.php";
require_once "./Video/VideoFactory.php";
require_once "Factory.php";

class AbstractFactory
{
    public static Factory $AUDIO;
    public static Factory $VIDEO;

    public static function init()
    {
        self::$AUDIO = new AudioFactory();
        self::$VIDEO = new VideoFactory();
    }
}

?>