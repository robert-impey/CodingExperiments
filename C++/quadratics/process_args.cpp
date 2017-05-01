#include <cstdlib>
#include <unistd.h>

#include "process_args.hpp"

void init_args(Args* args) 
{
    args->a = 0.0;
    args->b = 0.0;
    args->c = 0.0;
    args->d = false;
}

bool process_args(int argc, char** argv, Args* args)
{
    if (argc < 7) {
        return false;
    }

    int opt_rtn;
    init_args(args);

    while ((opt_rtn = getopt(argc, argv, "a:b:c:d")) != -1) {
        switch (opt_rtn) {
            case 'a': 
                args->a = atof(optarg);
                break;
            case 'b':
                args->b = atof(optarg);
                break;
            case 'c':
                args->c = atof(optarg);
                break;
            case 'd':
                args->d = true;
                break;
            default:
                return false;
        }
    }

    return true;
}

