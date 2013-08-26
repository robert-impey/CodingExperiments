# General variables and rules for Makefiles

PC = fpc

$(PROGRAM): $(PROGRAM).pas
	$(PC) $(PROGRAM).pas

clean:
	$(RM) $(PROGRAM) $(PROGRAM).exe $(PROGRAM).o
