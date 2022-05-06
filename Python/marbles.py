
from math import floor
from random import sample

def init_marbles(blue, red):
    marbles = []

    for i in range(blue):
        marbles.append("blue")

    for i in range(red):
        marbles.append("red")
    
    return marbles

def is_fixed(marbles):
    for i in range(len(marbles)-1):
        if marbles[i] != marbles[i+1]:
            return False
    
    return True

def select(marbles, rate):
    sample_size = floor(len(marbles) * rate)
    
    return sample(marbles, sample_size)

def expand(sample, target_pop):
    if target_pop % len(sample) != 0:
        raise Error("The target population should be a multiple of the size of the sample!")
    
    mult_factor = floor(target_pop / len(sample))
    
    new_pop = []
    
    for marble in sample:
        for i in range(mult_factor):
            new_pop.append(marble)
    
    return new_pop

def new_gen(marbles, rate):
    sample = select(marbles, rate)
    
    return expand(sample, len(marbles))

def main():
    start_blue = 50
    start_red = 50
    rate = 0.1
    
    generations = 0
    
    pop = init_marbles(start_blue, start_red)
    
    while not is_fixed(pop):
        pop = new_gen(pop, rate)
        generations += 1

    print(generations)

if __name__ == "__main__":
    main()
    