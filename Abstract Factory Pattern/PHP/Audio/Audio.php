<?php 

require_once "Device.php";

abstract class Audio extends Device
{
    public function play() : string
    {
        return "Is playing...";
    }

    public abstract function getInfo();
}

?>