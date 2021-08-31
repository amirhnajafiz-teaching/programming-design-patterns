<?php 

abstract class Person 
{
    protected int $age;
    protected string $gender;

    public function getAge()
    {
        return $this->age;
    }

    public function getGender()
    {
        return $this->gender;
    }

    public abstract function getInfo();
}

?>