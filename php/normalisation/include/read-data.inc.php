<?php
/*
 * Read the data from the CSV file.
 */
$data = array();

if ($fh = fopen(
	'data/swimming-sessions.csv',
	'r'
)) {
	while (!feof($fh)) {
		$line = fgets($fh);
		
		if (strlen($line) > 0) {
			$values = explode(',', $line);
			
			$i = 0;
			$data[] = array(
				'session_date' => $values[$i++],
				'number_of_lengths' => $values[$i++],
				'first_name' => $values[$i++],
				'last_name' => $values[$i++],
				'swimming_pool' => $values[$i++],
				'swimming_pool_length' => $values[$i++]
			);
		}
	}
	
	fclose($fh);
}

#print_r($data);
?>