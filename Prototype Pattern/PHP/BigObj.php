<?php

class BigObj
{
    private int $code;
    private string $data;

    public function __construct($code, $data)
    {
        $this->code = $code;
        $this->data = $data;
    }

    public function toString()
    {
        return $this->code . " " . $this->data;
    }

    public function clone()
    {
        return clone $this;
    }

    public function clearWith($code, $data)
    {
        $this->code = $code;
        $this->data = $data;
        return $this;
    }
}

?>