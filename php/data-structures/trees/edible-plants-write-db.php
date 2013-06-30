<?php
/**
 * Represent a tree.
 *
 * @copyright Copyright (c) 2010-08-10, Robert Impey
 */

require_once '../../mysql-database-connection/make-db-connection.inc.php';
require_once 'Tree.inc.php';

$edible_plants = new Tree('Edible Plants', null, $dbh);

$edible_plants
	->add_child('Fruits', 'Edible Plants')
	->add_child('Vegetables', 'Edible Plants')
	->add_child('Apples', 'Fruits')
	->add_child('Bananas', 'Fruits')
	->add_child('Coconuts', 'Fruits')
	->add_child('Legumes', 'Vegetables')
	->add_child('Bulbs', 'Vegetables')
	->add_child('Green Beans', 'Legumes')
	->add_child('Snap Peas', 'Legumes')
	->add_child('Soybeans', 'Legumes')
	->add_child('Onions', 'Bulbs')
	->add_child('Shallots', 'Bulbs')
	->add_child('Garlic', 'Bulbs');

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
		<p>Write to DB: <?php echo $edible_plants->write_to_db() ? 'Success' : 'Failure' ; ?></p>
	</body>
</html>
