<?php
/**
 * An attempt to rewrite explode (without worrying about $limit, the third argnument)
 * using just preg_match_all.
 *
 * @copyright 2010-03-04, Robert Impey
 */

header('Content-type: text/plain');

/*
 * My explode function.
 */

function my_explode($separator, $string)
{
	$atoms = array();
	
	if ($separator == '/') {
		$separator = '\/';
	}
	
	if ($separator == '\\') {
		$separator = '\\\\\\\\';
	}
	
	#$regex = "/(.*?)(?:$separator|$)/";
	#$regex = "/(.*?)(?:$separator)/";
	#$regex = "/(?:(.*?)(?:$separator)|(.+?)$)/";
	#$regex = "/(.+?)$/";
	$regex = "/(?:(.*?)(?:$separator)(?!$)|(.+)$)/";
	
	if (preg_match_all(
			$regex,
			$string,
			$matches
		)
	) {
		$atoms = $matches[1];
	}
	
	return $atoms;
}

/*
 * Display functions.
 */

function show_results($results)
{
	echo 'count($results): ' . count($results) . "\n";
	
	for ($i = 0; $i < count($results); $i++) {
		echo '$results[' . $i . ']: "' . $results[$i] . "\"\n";
	}
}

function print_line()
{
	echo "----------------------------------------\n";
}

/*
 * Some test data.
 */
$tests[] = array(
	'separator' => ' ',
	'str' => 'apples bananas coconuts'
);

$tests[] = array(
	'separator' => ' ',
	'str' => ' apples bananas coconuts'
);

$tests[] = array(
	'separator' => ',',
	'str' => 'apples,bananas,coconuts'
);

$tests[] = array(
	'separator' => ' ',
	'str' => 'apples bananas coconuts '
);

$tests[] = array(
	'separator' => ',',
	'str' => 'apples,bananas,coconuts,'
);

$tests[] = array(
	'separator' => ' ',
	'str' => ''
);

$tests[] = array(
	'separator' => ' ',
	'str' => ' '
);

$tests[] = array(
	'separator' => ' ',
	'str' => 'apples '
);

$tests[] = array(
	'separator' => ' ',
	'str' => 'apples'
);

$tests[] = array(
	'separator' => ' ',
	'str' => ' apples'
);

$tests[] = array(
	'separator' => ',',
	'str' => ',apples,bananas,coconuts'
);

$tests[] = array(
	'separator' => ',',
	'str' => ',apples,bananas,coconuts,'
);

$tests[] = array(
	'separator' => ',',
	'str' => 'apples,,bananas,coconuts'
);

$tests[] = array(
	'separator' => ',',
	'str' => 'apples,,,bananas,coconuts'
);

$tests[] = array(
	'separator' => '<!>',
	'str' => 'apples<!>bananas<!>coconuts,'
);

$tests[] = array(
	'separator' => '/',
	'str' => 'apples/bananas/coconuts'
);

$tests[] = array(
	'separator' => '/',
	'str' => '/apples/bananas/coconuts/'
);

$tests[] = array(
	'separator' => '//',
	'str' => 'apples//bananas//coconuts'
);

$tests[] = array(
	'separator' => '//',
	'str' => '//apples//bananas//coconuts//'
);

$tests[] = array(
	'separator' => '\\\\',
	'str' => 'apples\\\\bananas\\\\coconuts'
);

$tests[] = array(
	'separator' => '\\\\',
	'str' => '\\\\apples\\\\bananas\\\\coconuts\\\\'
);

#echo 'print_r($tests);' . "\n";
#print_r($tests);

/*
 * Compare how the functions behave.
 */

$all_tests_match = TRUE;
foreach ($tests as $test) {
	print_line();
	
	#echo 'print_r($test);' . "\n";
	#print_r($test);
	
	echo 'The separator: "' . $test['separator'] . "\"\n";
	echo 'The str: "' . $test['str'] . "\"\n";
	
	print_line();
	
	$explode_results = explode($test['separator'], $test['str']);
	
	#echo 'print_r($explode_results);' . "\n";
	#print_r($explode_results);
	
	echo 'show_results($explode_results);' . "\n";
	show_results($explode_results);
	
	print_line();
	
	$my_explode_results = my_explode($test['separator'], $test['str']);
	
	#echo 'print_r($my_explode_results);' . "\n";
	#print_r($my_explode_results);

	echo 'show_results($my_explode_results);' . "\n";
	show_results($my_explode_results);
	
	print_line();
	
	/*
	 * Do the results all match?
	 */
	$explode_results_count = count($explode_results);
	$same_length = $explode_results_count == count($my_explode_results);
	
	$same_elements = TRUE;
	if ($same_length) {
		$i = 0;
		while (
			$same_elements
			&&
			($i < $explode_results_count)
		) {
			if (
				$explode_results[$i] != $my_explode_results[$i]
			) {
				$same_elements = FALSE;
			}
			
			$i++;
		}
	}
	
	if (
		$same_length && $same_elements
	) {
		echo "The results match!\n";
	} else {
		echo "The results do not match!\n";
		
		$all_tests_match = FALSE;
	}
	
	print_line();
}

if ($all_tests_match) {
	echo "Success!\n";
} else {
	echo "Fail!\n";
}
?>
