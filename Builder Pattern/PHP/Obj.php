<?php

class Obj 
{
    private int $code;
    private string $data;
    private bool $has_meta;
    private string $meta;

    public function __cuntruct()
    {
        // Empty construct
    }

    public function code(int $code) 
    {
        $this->code = $code;
        return $this;
    }

    public function data(string $data) 
    {
        $this->data = $data;
        return $this;
    }

    public function has_meta(bool $has_meta) 
    {
        $this->has_meta = $has_meta;
        return $this;
    }

    public function meta(string $meta) 
    {
        $this->meta = $meta;
        return $this;
    }
}

?>