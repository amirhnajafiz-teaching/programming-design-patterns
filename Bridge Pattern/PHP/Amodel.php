<?php

require_once "Model.php";
require_once "Type.php";

class Amodel extends Model 
{
    private Type $type;

    public function __construct(Type $type)
    {
        $this->type = $type;
    }

    public function getModel() 
    {
        return "This is an A model of type " . $this->type->getType();
    }
}

?>