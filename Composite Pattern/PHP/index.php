<?php

require_once "Person.php";
require_once "Man.php";
require_once "Women.php";
require_once "City.php";

City::addCitizen(new Women(22));
City::addCitizen(new Women(62));
City::addCitizen(new Man(18));
City::addCitizen(new Women(29));
City::addCitizen(new Man(67));
City::addCitizen(new Man(43));
City::addCitizen(new Women(20));
City::addCitizen(new Man(22));

City::showInfo();

?>