# General variables and rules for Makefiles

CC = gcc

$(PROGRAM): main.c
	$(CC) main.c -o $(PROGRAM)

debug: main.c
	$(CC) -g main.c -o $(PROGRAM)

clean:
	$(RM) $(PROGRAM) $(PROGRAM).exe 
