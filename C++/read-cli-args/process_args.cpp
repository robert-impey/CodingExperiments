/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
#include <cstdlib>
#include <unistd.h>

#include "process_args.hpp"

void init_args(Args *args) {
    args->a = 0;
    args->b = 0.0;
}

bool process_args(int argc, char** argv, Args* args) {
    int optRtn;
    init_args(args);

    while ((optRtn = getopt(argc, argv, "A:B:")) != -1) {
        switch (optRtn) {
            case 'A':
                args->a = atoi(optarg);
                break;

            case 'B':
                args->b = atof(optarg);
                break;

            default:
                return false;
        }
    }

    return true;
}
