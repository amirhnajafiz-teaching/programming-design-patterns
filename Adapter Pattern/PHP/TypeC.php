<?php

require_once "Type.php";

class TypeC implements Type 
{
    private bool $on;

    public function getPlug()
    {
        return "NONE";
    }

    public function resetOn()
    {
        $this->on = !$this->on;
    }

    public function checkOn()
    {
        return $this->on;
    }

    public function getCode()
    {
        return 202;
    }
}

?>