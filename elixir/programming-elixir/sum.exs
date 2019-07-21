# Modules and Functions-4, p. 57
defmodule Sum do
    def of(1), do: 1
    def of(n), do: n + of(n - 1)
end
