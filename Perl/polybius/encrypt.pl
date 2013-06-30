#!/usr/bin/perl

use strict;
use warnings;

use Getopt::Long;

use Polybius qw(encrypt);

my ($plaintext);

GetOptions(
	'p|plaintext=s' => \$plaintext
);

print encrypt($plaintext), "\n";
