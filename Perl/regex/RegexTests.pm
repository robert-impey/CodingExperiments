package RegexTests;
use strict;
use warnings;

require Exporter;
our @ISA = qw(Exporter);
our @EXPORT_OK = qw(test_matching_and_non_matching);

sub test_regex
{
    my $target = shift;
    my $regex = shift;
    
    for my $test_case (@_) {
        my $message = "'$test_case' ";
        
        my @captures = $test_case =~ m/$regex/g;
        my $actual;
        if (scalar @captures) {
            $actual = 1;
            $message .= "matches\n";
            
            $message .= "# Captures:\n";
            for (@captures) {
                $message .= "#   $_\n";
            }
        } else {
            $actual = 0;
            $message .= "does not match\n"
        }
        
        if ($actual == $target) {
            print 'ok'
        } else {
            print 'not ok'
        }
        
        print " # $message";
    }
}

sub test_matching_and_non_matching
{
    my $regex = shift;
    my $matching_ref = shift;
    my $non_matching_ref = shift;
    
    print "# Regex: $regex\n";
    
    test_regex(1, $regex, @$matching_ref);
    test_regex(0, $regex, @$non_matching_ref);
}

1;
