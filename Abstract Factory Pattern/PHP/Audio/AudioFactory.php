<?php 

require_once "Factory.php";
require_once "MP3.php";
require_once "Voice.php";

class AudioFactory implements Factory
{
    public function build(string $type) 
    {
        switch ($type) {
            case 'mp3':
                return new MP3();
            case 'voice':
                return new Voice();
            default:
                return NULL;
        }
    }
}

?>