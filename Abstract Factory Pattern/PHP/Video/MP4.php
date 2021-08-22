<?php 

require_once "Video.php";

class MP4 extends Video
{
    public function getInfo()
    {
        return "This is an MP4 Video";
    }
}

?>