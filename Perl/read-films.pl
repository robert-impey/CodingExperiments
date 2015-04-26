#!/usr/bin/env perl

use strict;
use warnings;

use File::Slurp;
use YAML::XS qw(Load);

for my $file (@ARGV) {
	my $text = read_file($file);

	my @ary = Load($text);
	my %films = %{shift @ary};
	for my $film_key (sort keys %films) {
		my %film = %{$films{$film_key};};

		print "Title: $film{title}\n";
		print "Director: $film{director}\n";

		print "Actors:\n"; 
		for my $actor (sort @{$film{actors}}) {
			print $actor, "\n";
		}

		print '-' x 40, "\n";
	}
}
