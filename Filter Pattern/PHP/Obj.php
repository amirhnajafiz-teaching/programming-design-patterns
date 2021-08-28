<?php

class Obj 
{
    private int $code;
    private string $prefix;
    private string $suffix;

    public function __construct($code = 101, $prefix = "DR", $suffix = "OR")
    {
        $this->code = $code;
        $this->prefix = $prefix;
        $this->suffix = $suffix;
    }

    public function getCode()
    {
        return $this->code;
    }

    public function getPrefix()
    {
        return $this->prefix;
    }

    public function getSuffix()
    {
        return $this->suffix;
    }

    public function toString()
    {
        return $this->prefix . "/" . $this->code . "/" . $this->suffix;
    }
}

?>