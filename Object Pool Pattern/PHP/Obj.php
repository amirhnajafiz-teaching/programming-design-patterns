<?php

class Obj 
{
    private string $code;
    private string $data;

    public function __construct($code, $data = "")
    {
        $this->code = $code;
        $this->data = $data;
    }

    public function toString()
    {
        return $this->code . " :: " . $this->date;
    }

    public function getID() 
    {
        return $this->code;
    }

    public function resetWith($data)
    {
        $this->date = $data;
        return $this;
    }
}

?>