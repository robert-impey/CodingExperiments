#!/usr/bin/perl

use strict;
use warnings;

use File::Spec;
use File::Remove 'remove';
use File::Copy 'cp';

my $korean_file_name = "한국어.txt";

if (-f $korean_file_name){
    print "I can see the file.\n";
} else {
    print "I can't see the file!\n";
}

my $tmp_dir = File::Spec->tmpdir() . '/perl-utf-files-experiment';

mkdir $tmp_dir;

my $tmp_korean_file_name = "$tmp_dir/$korean_file_name";

cp( $korean_file_name,  $tmp_korean_file_name);

if (-f $tmp_korean_file_name) {
    print "I can see the temporary file.\n";
} else {
    print "I can't see the temporary file!\n";
}

remove(\1, $tmp_dir);

