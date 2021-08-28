<?php

require_once "Filter.php";

abstract class AndFilter implements Filter 
{
    public abstract function match($list);
}

?>