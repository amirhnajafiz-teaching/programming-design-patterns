<?php

require_once "./Base.php";

class User implements Base 
{
    public function init() : string {
        return "This is a user";
    }
}

?>