<?php
/**
 * Represent a tree.
 *
 * @copyright Copyright (c) 2010-08-10, Robert Impey
 */

require_once '../../mysql-database-connection/make-db-connection.inc.php';
require_once 'Tree.inc.php';

$edible_plants = new Tree('Edible Plants', null, $dbh);

$edible_plants->read_from_db();

?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN"
    "http://www.w3.org/TR/html4/strict.dtd"
    >
<html lang="en">
	<head>
		<title>Trees</title>
	</head>
	<body>
		<?php echo $edible_plants->get_ul(); ?>
	</body>
</html>
