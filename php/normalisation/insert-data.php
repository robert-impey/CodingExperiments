<?php
header('Content-type: text/plain');

require_once '../mysql-database-connection/make-db-connection.inc.php';
require_once 'include/read-data.inc.php';
require_once 'include/functions.inc.php';

/*
 * Add the data to the tables.
 */
$start = microtime(TRUE);
foreach ($data as $datum) {
	insert_data_into_denormalised_table(
		$dbh,
		$datum['session_date'],
		$datum['number_of_lengths'],
		$datum['first_name'],
		$datum['last_name'],
		$datum['swimming_pool'],
		$datum['swimming_pool_length']
	);
}
$finish = microtime(TRUE);
echo 'Denormalised inserts in ' . ($finish - $start) . " microseconds\n";

$start = microtime(TRUE);
foreach ($data as $datum) {
	insert_data_into_normalised_tables(
		$dbh,
		$datum['session_date'],
		$datum['number_of_lengths'],
		$datum['first_name'],
		$datum['last_name'],
		$datum['swimming_pool'],
		$datum['swimming_pool_length']
	);
}
$finish = microtime(TRUE);

echo 'Normalised inserts in ' . ($finish - $start) . " microseconds\n";
?>
