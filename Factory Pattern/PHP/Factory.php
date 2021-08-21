<?php

require_once "./Home.php";
require_once "./User.php";

class Factory
{
    public static function build(string $type) : Base {
        switch ($type) {
            case 'user':
                return new User();
            case 'home':
                return new Home();
            default:
                return NULL;
        }
    }
}

?>