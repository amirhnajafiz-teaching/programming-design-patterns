<?php

require_once "Obj.php";

class Pool 
{
    protected static $objects = [];

    public static function initialize(int $number = 5)
    {
        for ($i = 0; $i < $number; $i++) {
            $id = uniqid("OBJ");
            self::$objects[$id] = ['item' => new Obj($id), 'status' => 1];
        }
    }

    public static function checkIn($data)
    {
        foreach(array_keys(self::$objects) as $key) {
            if(self::$objects[$key]['status'] == 1) {
                self::$objects[$key]['status'] = 0;
                return self::$objects[$key]['item']->resetWith($data);
            }
        }
        return NULL;
    }

    public static function checkOut(Obj $obj)
    {
        self::$objects[$obj->getID()]['status'] = 1;
    }
}

?>