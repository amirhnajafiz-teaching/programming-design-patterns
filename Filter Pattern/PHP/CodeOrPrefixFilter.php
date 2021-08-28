<?php

require_once "OrFilter.php";

class CodeOrPrefixFilter extends OrFilter 
{
    private string $prefix;
    private int $code;

    public function __construct($prefix, $code)
    {
        $this->prefix = $prefix;
        $this->code = $code;
    }

    public function match($list) 
    {
        $res = [];
        foreach($list as $obj) {
            if ($obj->getPrefix() == $this->prefix || $obj->getCode() == $this->code)
                $res[] = $obj;
        }
        return $res;
    }
}

?>