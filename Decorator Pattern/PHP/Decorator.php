<?php

require_once "Base.php";
require_once "Obj.php";

abstract class Decorator implements Base 
{
    protected int $id;
    protected Obj $newObj;

    public function getID()
    {
        return $this->id;
    }

    public abstract function getInfo();
}


?>