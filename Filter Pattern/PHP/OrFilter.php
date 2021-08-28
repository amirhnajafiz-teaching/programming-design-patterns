<?php

require_once "Filter.php";

abstract class OrFilter implements Filter 
{
    public abstract function match($list);
}

?>