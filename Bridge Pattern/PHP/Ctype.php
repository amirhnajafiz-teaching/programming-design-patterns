<?php

require_once "Type.php";

class Ctype implements Type 
{
    public function getType()
    {
        return $this::class;
    }
}

?>