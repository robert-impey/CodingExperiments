# 1.1

defmodule Switch do
    def push(true), do: false
    def push(false), do: true
end

IO.puts "Start..."

startState = false
IO.puts startState

state = Switch.push(startState)
IO.puts state

newState = Switch.push(state)
IO.puts newState
