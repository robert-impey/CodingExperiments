# General variables and rules for Makefiles

include ../cxx.mk

$(PROGRAM): main.cpp
	$(CXX) $(CXXFLAGS) main.cpp -o $(PROGRAM)

debug: main.cpp
	$(CXX) $(CXXFLAGS) -g main.cpp -o $(PROGRAM)

clean:
	$(RM) $(PROGRAM) $(PROGRAM).exe
