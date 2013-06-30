#!/usr/bin/perl -w

use strict;
use warnings;

my %hash_of_arrays;

push @{$hash_of_arrays{first}}, 'foo', 'bar', 'baz';
push @{$hash_of_arrays{second}}, 'fee', 'fi', 'fo', 'fum';

for my $hash_key (sort {@{$hash_of_arrays{$b}} <=> @{$hash_of_arrays{$a}}} keys %hash_of_arrays) {
    print "$hash_key: ", join(", ", sort @{ $hash_of_arrays{$hash_key}}), "\n";
}

print "-" x 20, "\n";

push @{$hash_of_arrays{third}}, 'bish';

my %filtered_hash_of_arrays;

for my $hash_key (keys %hash_of_arrays) {
    if ($#{$hash_of_arrays{$hash_key}} > 1) {
        @{$filtered_hash_of_arrays{$hash_key}} = @{$hash_of_arrays{$hash_key}};
    }
}

print "-" x 20, "\n";

for my $hash_key (keys %hash_of_arrays) {
    print "$hash_key: ", join(", ", @{$hash_of_arrays{$hash_key}}), "\n";
}

print "-" x 20, "\n";

for my $hash_key (keys %filtered_hash_of_arrays) {
    print "$hash_key: ", join(", ", @{$filtered_hash_of_arrays{$hash_key}}), "\n";
}

print "-" x 20, "\n";

$filtered_hash_of_arrays{second}[1] = 'fi changed';

for my $hash_key (keys %hash_of_arrays) {
    print "$hash_key: ", join(", ", @{$hash_of_arrays{$hash_key}}), "\n";
}

print "-" x 20, "\n";

for my $hash_key (keys %filtered_hash_of_arrays) {
    print "$hash_key: ", join(", ", @{$filtered_hash_of_arrays{$hash_key}}), "\n";
}
