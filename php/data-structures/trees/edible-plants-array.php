<?php
/**
 * Represent a tree.
 *
 * @copyright Copyright (c) 2010-08-10, Robert Impey
 */

$edible_plants = array();
$edible_plants['Fruits'] = explode(', ', 'Apples, Bananas, Coconuts');

$edible_plants['Vegetables']['Legumes'] = explode(', ', 'Green Beans, Snap Peas, Soybeans');
$edible_plants['Vegetables']['Bulbs'] = explode(', ', 'Onions, Shallots, Garlic');

?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN"
    "http://www.w3.org/TR/html4/strict.dtd"
    >
<html lang="en">
	<head>
		<title>Trees</title>
	</head>
	<body>
	<pre><?php print_r($edible_plants); ?></pre>
	</body>
</html>
