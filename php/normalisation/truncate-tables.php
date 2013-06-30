<?php
require_once '../mysql-database-connection/make-mysqli-db-connection.inc.php';

$stmt = file_get_contents('sql/truncate-tables.sql');
$mysqli->multi_query($stmt);
?>
