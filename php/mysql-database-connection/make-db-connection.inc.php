<?php
/**
 * Makes a connection to the MySQL server.
 *
 * @copyright 2010-03-05, Robert Impey
 */

/*
 * This file should define DB_USER, DB_DATABASE, DB_HOST and DB_PASSWORD.
 */
require_once 'db-settings.inc.php';

$dbh = mysql_connect(DB_HOST, DB_USER, DB_PASSWORD)
	or die('Unable to connect to the MySQL server!');

mysql_selectdb(DB_DATABASE, $dbh)
	or die('Unable to select the database!');
?>
