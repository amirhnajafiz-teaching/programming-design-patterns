<?php 

require_once "Obj.php";
require_once "Decorator.php";

class SuperObj extends Decorator 
{
    public function __construct(Obj $newObj)
    {
        $this->newObj = $newObj;
        $this->id = 101;
    }

    public function getInfo()
    {
        return "This is a super class";
    }
}

?>