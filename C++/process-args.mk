# Makefile for projects that process CLI arguments

include ../cxx.mk

OBJECT_FILES = main.o process_args.o

$(PROGRAM): $(OBJECT_FILES)
	$(CXX) $(CXXFLAGS) $(OBJECT_FILES) -o $(PROGRAM)

main.o: main.cpp process_args.hpp
	$(CXX) $(CXXFLAGS) -c main.cpp -o main.o

process_args.o: process_args.hpp process_args.cpp
	$(CXX) $(CXXFLAGS) -c process_args.cpp -o process_args.o

clean:
	$(RM) $(PROGRAM) $(PROGRAM).exe $(OBJECT_FILES)
