<?php
/**
 * Functions for experimenting with denormalised and normalised tables.
 *
 * @copyright 2010-03-05, Robert Impey
 */

/**
 * Insert the data into the denormalised table.
 */
function insert_data_into_denormalised_table(
	$dbh,
	$session_date,
	$number_of_lengths,
	$first_name,
	$last_name,
	$swimming_pool,
	$swimming_pool_length
)
{
	$stmt = <<<SQL
INSERT INTO
	denormalised_swimming_sessions
SET
	session_date = '$session_date',
	number_of_lengths = $number_of_lengths,
	first_name = '$first_name',
	last_name = '$last_name',
	swimming_pool = '$swimming_pool',
	swimming_pool_length = $swimming_pool_length
SQL;
	
	#echo $stmt;

	mysql_query($stmt, $dbh);
}

/**
 * Insert the data into the normalised tables.
 */
function insert_data_into_normalised_tables(
	$dbh,
	$session_date,
	$number_of_lengths,
	$first_name,
	$last_name,
	$swimming_pool,
	$swimming_pool_length
)
{
	/*
	 * The swimmer.
	 */
	$query = <<<SQL
SELECT
	id
FROM
	swimmers
WHERE
	first_name = '$first_name'
	AND
	last_name = '$last_name'
SQL;
		
	$result = mysql_query($query, $dbh);
	
	if ($row = mysql_fetch_assoc($result)) {
		$swimmer_id = $row['id'];
	} else {
		$stmt = <<<SQL
INSERT INTO
	swimmers
SET
	first_name = '$first_name',
	last_name = '$last_name'
SQL;
		
		#echo $stmt;
		
		mysql_query($stmt, $dbh);
		
		$swimmer_id = mysql_insert_id($dbh);
	}
		
	/*
	 * The swimming pool.
	 */
	$query = <<<SQL
SELECT
	id
FROM
	swimming_pools
WHERE
	name = '$swimming_pool'
SQL;

	$result = mysql_query($query, $dbh);
	
	if ($row = mysql_fetch_assoc($result)) {
		$swimming_pool_id = $row['id'];
	} else {
		$stmt = <<<SQL
INSERT INTO
	swimming_pools
SET
	name = '$swimming_pool',
	swimming_pool_length = $swimming_pool_length
SQL;
			
		mysql_query($stmt, $dbh);
		
		$swimming_pool_id = mysql_insert_id($dbh);
	}
	
	/*
	 * Add the swimming session.
	 */
	$stmt = <<<SQL
INSERT INTO
	swimming_sessions
SET
	session_date = '$session_date',
	number_of_lengths = '$number_of_lengths',
	swimmer_id = $swimmer_id,
	swimming_pool_id = $swimming_pool_id
SQL;
	
	mysql_query($stmt, $dbh);
}
?>
