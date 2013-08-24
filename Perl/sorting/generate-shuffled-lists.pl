#!/usr/bin/env perl

use strict;
use warnings;

use Getopt::Long;
use Pod::Usage;

use List::Util qw(shuffle);

my $man  = 0;
my $help = 0;

my ($number_of_lists, $size_of_lists);

GetOptions(
	'help|?'        => \$help,
	'man'           => \$man,
	'n|number-of-lists=i' => \$number_of_lists,
	's|size-of-lists=i' => \$size_of_lists
) or pod2usage(2);

pod2usage(1) if $help;
pod2usage( -exitstatus => 0, -verbose => 2 ) if $man;

pod2usage(1) unless ($number_of_lists and $size_of_lists);

my $output_file_name = "shuffled-lists-$number_of_lists-$size_of_lists.txt";

open FILE, '>', $output_file_name or die $!;

foreach (1..$number_of_lists) {
	my @list_of_ints = shuffle(1..$size_of_lists);
	
	print FILE join ',', @list_of_ints;
	print FILE "\n";
}

close FILE;

__END__

=head1 NAME

    generate-shuffled-lists.pl - A program for generating shuffled lists of integers to be sorted elsewhere.

=head1 SYNOPSIS

    generate-shuffled-lists.pl -n [NUMBER OF LISTS] -s [SIZE OF EACH LIST]
    Options:
		-help	brief help message
		-man	full documentation
		-n		The number of lists to be generated.
		-s		The size of each list that is generated.

=head1 OPTIONS

=over 8

=item B<-help|?>

Print a brief help message and exits.

=item B<-man>

Prints the manual page and exits.

=item B<-number-of-lists|n>

The number of lists to be generated.

=item B<-size-of-lists|s>

The size of each list that is generated.

=back

=head1 DESCRIPTION

B<generate-shuffled-lists.pl> generates text files that contain shuffled lists of integers.

The output files are named so: shuffled-lists-<NUMBER>-<SIZE>.txt

The files are used by other programs to experiment with sorting algorithms.

=cut
