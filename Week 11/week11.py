class Counter:
    def __init__(self, name):
        self._count = 0
        self._name = name

    def increment(self):
        self._count += 1

    def reset(self):
        self._count = 0

    def get_ticks(self):
        return self._count

    def set_name(self, value):
        self._name = value

    def get_name(self):
        return self._name


class Clock:
    def __init__(self):
        self.seconds = Counter("Seconds")
        self.minutes = Counter("Minutes")
        self.hours = Counter("Hours")

    def tick(self):
        if self.seconds.get_ticks() == 59:
            if self.minutes.get_ticks() == 59:
                if self.hours.get_ticks() == 23:
                    self.clock_reset()
                else:
                    self.hours.increment()
                    self.seconds.reset()
                    self.minutes.reset()
            else:
                self.minutes.increment()
                self.seconds.reset()
        else:
            self.seconds.increment()

    def clock_reset(self):
        self.seconds.reset()
        self.minutes.reset()
        self.hours.reset()

    def show(self):
        result = f"{self.hours.get_ticks():02d}:{self.minutes.get_ticks():02d}:{self.seconds.get_ticks():02d}"
        return result


if __name__ == "__main__":
    clock = Clock()
    print(clock.show())
    clock.tick()
    print(clock.show())
    clock.tick()
    clock.tick()
    clock.tick()
    print(clock.show())
    clock.tick()
    clock.tick()
    print(clock.show())
