<?php

require_once "Person.php";

class Man extends Person 
{
    public function __construct(int $age)
    {
        $this->gender = $this::class;
        $this->age = $age;
    }

    public function getInfo()
    {
        return "This is a " . $this->getAge() . " years old " . $this->getGender() . ".";
    }
}

?>