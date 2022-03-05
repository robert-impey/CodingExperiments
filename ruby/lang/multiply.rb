def odd(n)
 return (n % 2 == 1)
end

def half(n)
  return n / 2
end

def multiply0(n, a)
  if n == 1 then
    return a
  else
    return a  + multiply(n - 1, a)
  end
end

