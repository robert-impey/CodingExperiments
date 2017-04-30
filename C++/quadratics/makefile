CC = g++

PROGRAM = quadratics

OBJECT_FILES = main.o process_args.o

$(PROGRAM): $(OBJECT_FILES)
	$(CC) $(OBJECT_FILES) -o $(PROGRAM)

main.o: main.cpp process_args.hpp
	$(CC) -c main.cpp -o main.o

process_args.o: process_args.hpp process_args.cpp
	$(CC) -c process_args.cpp -o process_args.o

clean:
	$(RM) $(PROGRAM) $(PROGRAM).exe $(OBJECT_FILES)
