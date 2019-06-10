#!/usr/bin/env python3

import argparse
import hashlib
import time

if __name__ == '__main__':
    parser = argparse.ArgumentParser('Time MD5')

    parser.add_argument('File',
                        help='The file to check.')

    args = parser.parse_args()

    file_name = args.File
    
    print("Reading: '{}'".format(file_name))
    
    start = time.process_time()
    
    with open(file_name, 'rb') as f:
        m = hashlib.md5()
        m.update(f.read())
        print("Digest: {}".format(m.digest()))
    
    finish = time.process_time()
    
    print("Time take: {} s".format(finish - start))
    