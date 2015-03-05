#!/usr/bin/env ruby
class LivingThing
  attr_accessor :name
  def live
    puts "#{@name} - So far, so good!"
  end

  def die
    puts "#{@name} - Is that all there is?"
  end
end

module ThermoRegulator
  def raise_own_temperature
    puts "#{@name} - Try and warm up"
  end
end

class Plant < LivingThing
  def soak_up_sunshine
    puts "#{@name} - Everybody loves the sunshine!"
  end
end

class Mammal < LivingThing
  include ThermoRegulator
  def give_birth_to_live_young
    puts "#{@name} - Pop! pop! pop!"
  end
end

class Monkey < Mammal
  def howl
    puts "#{@name} - Howl!"
  end
end

# Apparently, they can regulate their temperature
# http://en.wikipedia.org/wiki/Nelumbo_nucifera
class SacredLotus < Plant
  include ThermoRegulator
  def float_on_pond
    puts "#{@name} - I'm floating on a pond"
  end
end

georgina = Monkey.new
georgina.name = "Georgina"

georgina.live

georgina.howl

georgina.give_birth_to_live_young

georgina.raise_own_temperature

georgina.die

lori = SacredLotus.new
lori.name = "Lori"

lori.live

lori.soak_up_sunshine

lori.float_on_pond

lori.raise_own_temperature

lori.die
