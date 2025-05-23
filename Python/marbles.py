from math import floor
from random import sample


def select(marbles, rate):
    sample_size = floor(len(marbles) * rate)

    return sample(marbles, sample_size)


def expand(selection, target_pop):
    if target_pop % len(selection) != 0:
        raise "The target population should be a multiple of the size of the sample!"

    mult_factor = floor(target_pop / len(selection))

    new_pop = []

    for marble in selection:
        for i in range(mult_factor):
            new_pop.append(marble)

    return new_pop


def new_gen(marbles, rate):
    selection = select(marbles, rate)

    return expand(selection, len(marbles))


def count(marbles):
    counts = {}

    for marble in marbles:
        if marble in counts:
            counts[marble] += 1
        else:
            counts[marble] = 1

    return counts


class Sim:
    def __init__(self, blue, red, rate):
        self._marbles = []

        for i in range(blue):
            self._marbles.append("blue")

        for i in range(red):
            self._marbles.append("red")

        self._rate = rate

        self._generations = []

    def is_fixed(self):
        for i in range(len(self._marbles) - 1):
            if self._marbles[i] != self._marbles[i + 1]:
                return False

        return True

    def run(self):
        if len(self._generations) > 0:
            raise "Can't run a simulation more than once!"

        while not self.is_fixed():
            self._generations.append(self._marbles)
            self._marbles = new_gen(self._marbles, self._rate)

        self._generations.append(self._marbles)

    def _ensure_has_run(self):
        gen_count = len(self._generations)
        if gen_count == 0:
            raise "The simulation has not been run yet!"

    def count_generations(self):
        self._ensure_has_run()

        return len(self._generations)

    def get_counts_by_generation(self):
        self._ensure_has_run()

        counts = []
        for gen in self._generations:
            counts.append(count(gen))

        return counts


def main():
    start_blue = 50
    start_red = 50
    rate = 0.1

    sim = Sim(start_blue, start_red, rate)
    sim.run()

    print("Generations: %i" % sim.count_generations())

    counts = sim.get_counts_by_generation()

    for c in counts:
        message = ""

        if "red" in c:
            message += "Red: %i " % c["red"]
        if "blue" in c:
            message += "Blue: %i " % c["blue"]

        print(message)


if __name__ == "__main__":
    main()
