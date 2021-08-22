<?php 

require_once "../Factory.php";
require_once "MP4.php";
require_once "GIF.php";

class VideoFactory implements Factory
{
    public function build(string $type) 
    {
        switch ($type) {
            case 'mp4':
                return new MP4();
            case 'gif':
                return new GIF();
            default:
                return NULL;
        }
    }
}

?>