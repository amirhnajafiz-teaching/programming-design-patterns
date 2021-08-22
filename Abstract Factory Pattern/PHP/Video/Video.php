<?php 

require_once "../Device.php";

abstract class Video extends Device
{
    public function play() : string
    {
        return "Is showing...";
    }

    public abstract function getInfo();
}

?>