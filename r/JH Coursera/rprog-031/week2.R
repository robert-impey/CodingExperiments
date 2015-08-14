f <- function(x) {
  g <- function(y) {
    y + z
  }
  z <- 4
  x + g(x)
}

z <- 10

f(3)

x <- 5

y <- if (x < 5) {
  NA
} else {
  10
}
