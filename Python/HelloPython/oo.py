class F:
    def __init__(self):
        self.data = []
    def add(self, thing):
        self.data.append(thing)

f = F()
f.add("Hello, Objects")
f.add("More stuff")

for d in f.data:
    print(d)
