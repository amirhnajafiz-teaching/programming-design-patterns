<?php

require_once "AndFilter.php";

class PrefixAndSuffixFilter extends AndFilter
{
    private string $prefix;
    private string $suffix;

    public function __construct($prefix, $suffix)
    {
        $this->prefix = $prefix;
        $this->suffix = $suffix;
    }

    public function match($list) 
    {
        $res = [];
        foreach($list as $obj) {
            if ($obj->getPrefix() == $this->prefix && $obj->getSuffix() == $this->suffix)
                $res[] = $obj;
        }
        return $res;
    }
}

?>