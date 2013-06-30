#!/usr/bin/perl

use strict;
use warnings;

use Getopt::Long;

use Math::Random;

my ($number_of_deviates, $mean);

GetOptions(
	'n|number-of-deviates=i' => \$number_of_deviates,
	'm|mean=f' => \$mean
);

my @deviates = random_normal($number_of_deviates, $mean);

print join "\n", @deviates, "\n";
