# Experiment to look at the likelihood of a birthday clash at a party
# Robert Impey 2015-08-30

count_birthdays_with_clash <- function(party_size, number_of_parties = 10, days = c(1:365))
{
  number_of_clashes <- 0
  for (i in 1:number_of_parties) 
  {
    guests_birthdays <- sample(days, party_size, replace=TRUE)    
    if (party_has_clash(guests_birthdays))
    {
      number_of_clashes <- number_of_clashes + 1
    }
  }
  data.frame(number_of_parties = number_of_parties, number_of_clashes = number_of_clashes)
}

party_has_clash <- function(birthdays)
{
  length(birthdays) > length(unique(birthdays)) 
}

number_of_parties <- 4000

max_party_size <- 50
clash_ratios <- c()
for (party_size in 2:max_party_size)
{
  clash_counts <- count_birthdays_with_clash(
    party_size, 
    number_of_parties = number_of_parties)
  
  clash_ratio <- clash_counts$number_of_clashes / clash_counts$number_of_parties
  
  clash_ratios <- append(clash_ratios, clash_ratio)
}

plot(
  clash_ratios, 
  main = "Party Size vs Clash Ratio",
  xlab = "Party Size", 
  ylab = "Clash Ratio")
