def multiply(n, a)
  if n == 1 then
    return a
  else
    return a  + multiply(n - 1, a)
  end
end

