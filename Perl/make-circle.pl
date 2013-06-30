#!/usr/bin/perl

use strict;
use warnings;

use SVG;

my $svg = SVG->new(width=>200,height=>200);

my $y = $svg->group(
	id => 'group_y',
	style => { stroke=>'red', fill=>'green' }
);

$y->circle(cx=>100, cy=>100, r=>50, id=>'circle_in_group_y');

my $svg_file = 'circle.svg';
open(OUT, ">$svg_file") or die $!;
print OUT $svg->xmlify(
	-namespace => "svg",
	-pubid => "-//W3C//DTD SVG 1.0//EN",
	-inline   => 1
);
close OUT;
