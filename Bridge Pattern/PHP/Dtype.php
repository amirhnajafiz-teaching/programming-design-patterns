<?php

require_once "Type.php";

class Dtype implements Type 
{
    public function getType()
    {
        return $this::class;
    }
}

?>