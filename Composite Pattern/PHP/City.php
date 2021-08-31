<?php

require_once "Person.php";
require_once "Man.php";
require_once "Women.php";


class City 
{
    protected static $people = [];

    public static function addCitizen(Person $person)
    {
        self::$people[] = $person;
    }

    public static function showInfo()
    {
        foreach(self::$people as $person) {
            echo $person->getInfo() . PHP_EOL;
        }
    }
}

?>