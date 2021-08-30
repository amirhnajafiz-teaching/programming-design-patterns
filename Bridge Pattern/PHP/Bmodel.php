<?php

require_once "Model.php";
require_once "Type.php";

class Bmodel extends Model 
{
    private Type $type;

    public function __construct(Type $type)
    {
        $this->type = $type;
    }

    public function getModel() 
    {
        return "This is a B model of type " . $this->type->getType();
    }
}

?>