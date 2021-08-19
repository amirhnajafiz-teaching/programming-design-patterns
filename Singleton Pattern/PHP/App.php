<?php 

class App 
{
	private static App $app;
	private int $code;
	
	private function __construct(int $code) 
	{
		$this->code = $code;
	}
	
	public static function getInstance(int $code = 0) : App 
	{
		if (!isset(self::$app)) {
			self::$app = new App($code);
		}
		return self::$app;
	}
	
	public function getCode() : int 
	{
		return $this->code;
	}
}

?>