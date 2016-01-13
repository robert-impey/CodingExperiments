package Sorting;

use strict;
use warnings;

use base 'Exporter';

our @EXPORT_OK = qw(
built_in
bubble
);

sub built_in
{
    return sort {$a <=> $b}  @_;
}

sub bubble
{
    my @sorted_list_of_integers =  @_;
    my $swapped;
    do {
        $swapped = 0;

        foreach (0..(scalar(@sorted_list_of_integers) - 2)) {
            if ($sorted_list_of_integers[$_] > $sorted_list_of_integers[$_ + 1]) {
                swap(\@sorted_list_of_integers, $_, $_ + 1);
                $swapped = 1;
            }
        }
    } while( $swapped);

    return @sorted_list_of_integers;
}

sub swap
{
	my $array_ref = shift;
	my $first_index = shift;
	my $second_index = shift;
	
	my $temp = @$array_ref[$first_index];
	@$array_ref[$first_index] = @$array_ref[$second_index];
	@$array_ref[$second_index] = $temp;
}
