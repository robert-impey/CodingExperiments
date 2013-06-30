#!/usr/bin/perl

use strict;
use warnings;

use Getopt::Long;

use Polybius qw(decrypt);

my ($cyphertext);

GetOptions(
	'c|cyphertext=s' => \$cyphertext
);

print decrypt($cyphertext), "\n";
