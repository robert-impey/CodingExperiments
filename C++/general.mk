# General variables and rules for Makefiles

CC = g++

$(PROGRAM): main.cpp
	$(CC) main.cpp -o $(PROGRAM)

debug: main.c
	$(CC) -g main.cpp -o $(PROGRAM)

clean:
	$(RM) $(PROGRAM)
