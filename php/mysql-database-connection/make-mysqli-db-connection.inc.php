<?php
/**
 * Makes a connection to the MySQL server using mysqli.
 *
 * @copyright 2010-03-05, Robert Impey
 */

/*
 * This file should define DB_USER, DB_DATABASE, DB_HOST and DB_PASSWORD.
 */
require_once 'db-settings.inc.php';

$mysqli = new mysqli(DB_HOST, DB_USER, DB_PASSWORD, DB_DATABASE);
?>
