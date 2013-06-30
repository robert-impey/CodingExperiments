# General variables and rules for Makefiles

CC = gpc

$(PROGRAM): main.pas
	$(CC) main.pas -o $(PROGRAM)

debug: main.pas
	$(CC) -g main.pas -o $(PROGRAM)

clean:
	$(RM) $(PROGRAM) $(PROGRAM).exe 
