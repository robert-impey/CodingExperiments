package Polybius;

use strict;

use base 'Exporter';
our @EXPORT_OK = qw(encrypt decrypt);

my @square = (
	[ qw(a b c d e f) ],
	[ qw(g h i j k l) ],
	[ qw(m n o p q r) ],
	[ qw(s t u v w x) ],
	[ qw(y z 0 1 2 3) ],
	[ qw(4 5 6 7 8 9) ]
);

sub encrypt
{
	my $plaintext = shift;
	
	$plaintext = lc $plaintext;
	
	$plaintext =~ s/[^a-z0-9]//;
	
	my @pt_chars = split //, $plaintext;
	
	my @cyphertext_chars;
	SEARCH: foreach my $pt_char (@pt_chars) {
		my $x = 1;
		foreach my $row (@square) {
			my $y = 1;
			foreach my $char (@{$row}) {
				if ($pt_char eq $char) {
					push @cyphertext_chars, "$x$y";
					next SEARCH;
				}
				$y++;
			}
			$x++;
		}
	}
	
	return join ',', @cyphertext_chars;
}

sub decrypt
{
	my $cyphertext = shift;
	
	my @cyphertext_codes = split /\s*,\s*/, $cyphertext;
	
	my $plaintext;
	foreach my $cyphertext_code (@cyphertext_codes) {
		my @cyphertext_code = split //, $cyphertext_code;
		my ($x, $y) = ($cyphertext_code[0] - 1, $cyphertext_code[1] - 1);
		
		$plaintext .= $square[$x][$y];
	}
	
	return $plaintext;
}

1;