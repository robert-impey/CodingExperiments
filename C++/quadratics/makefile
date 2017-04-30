CC = g++

PROGRAM = quadratics

OBJECT_FILES = main.o process_args.o

$(PROGRAM): $(OBJECT_FILES)
	$(CC) $(OBJECT_FILES) -o $(PROGRAM)

main.o:
	$(CC) -c main.cpp -o main.o

process_args.o:
	$(CC) -c process_args.cpp -o process_args.o

clean:
	$(RM) $(PROGRAM) $(OBJECT_FILES)
