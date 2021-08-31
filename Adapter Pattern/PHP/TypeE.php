<?php

require_once "Type.php";

class TypeE implements Type 
{
    public function getPlug()
    {
        return "EURO-PL";
    }

    public function getCode()
    {
        return 507;
    }
}

?>