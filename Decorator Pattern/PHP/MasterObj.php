<?php 

require_once "Obj.php";
require_once "Decorator.php";

class MasterObj extends Decorator 
{
    public function __construct(Obj $newObj)
    {
        $this->newObj = $newObj;
        $this->id = 1001;
    }

    public function getInfo()
    {
        return "This is a master class";
    }
}

?>