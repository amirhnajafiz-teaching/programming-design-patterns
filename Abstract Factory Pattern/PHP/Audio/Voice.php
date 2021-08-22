<?php 

require_once "Audio.php";

class Voice extends Audio 
{
    public function getInfo()
    {
        return "This is an MP3 audio";
    }
}

?>