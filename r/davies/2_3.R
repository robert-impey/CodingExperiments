# Exercise 2.3

a <- seq(from=5, to=-11, by=-0.3)

a <- seq(from=-11, to=5, by=0.3)

c <- rep(x=c(-1, 3, -5, 7, -9), times=2, each=10)
c <- sort(c, decreasing=TRUE)

d_i <- 6:12
d_ii <- rep(5.3, 3)
d_iii <- c(-3)
d_iv <- seq(from=102, to=length(c), length.out=9)

d <- c(d_i, d_ii, d_iii, d_iv)
length(d)
