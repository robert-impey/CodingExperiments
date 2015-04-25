#!/usr/bin/env perl

use strict;
use warnings;

use File::Slurp;
use YAML::XS qw(Load);

for my $file (@ARGV) {
    my $text = read_file($file);

    my @ary = Load($text);
    my $films_ref = shift @ary;
    my %films = %{$films_ref};
    for my $film_key (sort keys %films) {
        my $film_hash_ref = $films{$film_key};
        my %film = %{$film_hash_ref};

        print "Title: $film{title}\n";
        print "Director: $film{director}\n";

        print "Actors:\n"; 
        for my $actor (sort @{$film{actors}}) {
            print $actor, "\n";
        }

        print '-' x 40, "\n";
    }
}
