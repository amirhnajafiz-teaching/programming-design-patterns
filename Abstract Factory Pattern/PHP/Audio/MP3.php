<?php 

require_once "Audio.php";

class MP3 extends Audio 
{
    public function getInfo()
    {
        return "This is an MP3 audio";
    }
}

?>