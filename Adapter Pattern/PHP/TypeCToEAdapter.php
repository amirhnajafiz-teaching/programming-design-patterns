<?php

require_once "TypeC.php";
require_once "TypeE.php";

class TypeCToEAdapter extends TypeC 
{
    private TypeE $baseType;

    public function __construct(TypeE $base)
    {
        $this->baseType = $base;
    }

    public function resetOn()
    {
        return "No on in here";
    }

    public function checkOn()
    {
        return FALSE;
    }
}

?>