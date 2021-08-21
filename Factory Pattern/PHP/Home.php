<?php

require_once "./Base.php";

class Home implements Base 
{
    public function init() : string {
        return "This is the home page";
    }
}

?>