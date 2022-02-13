/* 
 * File:   process_args.hpp
 * Author: Robert
 *
 * Created on 10 June 2011, 22:37
 */

#ifndef MAIN_HPP
#define	MAIN_HPP

#ifdef	__cplusplus
extern "C" {
#endif

// Structs.
    
struct Args {
    int a;
    float b;
};

// Functions.

void init_args(Args *args);
bool process_args(int argc, char** argv, Args* args);

#ifdef	__cplusplus
}
#endif

#endif	/* MAIN_HPP */

