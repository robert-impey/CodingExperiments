const int numberOfAppointments = 7;

const double desiredTotalProbability = 0.5;

var maxProbability = 1.0;

var minProbability = desiredTotalProbability;

const int maxIterations = 1_000_000;

var candidateIndividualProbability = maxProbability;

var probabilityOfAllAttended = AllAttended(candidateIndividualProbability);

var lowNext = true;

var diff = 1.0 / maxIterations;

for (var i = 0; i < maxIterations; i++)
{
    if (probabilityOfAllAttended > desiredTotalProbability)
    {
        if (lowNext)
        {
            maxProbability -= diff;
            candidateIndividualProbability = minProbability;
        }
        else
        {
            minProbability -= diff;
            candidateIndividualProbability = maxProbability;
        }
    }
    else
    {
        if (lowNext)
        {
            maxProbability += diff;
            candidateIndividualProbability = minProbability;
        }
        else
        {
            minProbability += diff;
            candidateIndividualProbability = maxProbability;
        }
    }

    probabilityOfAllAttended = AllAttended(candidateIndividualProbability);

    lowNext = !lowNext;
}

double AllAttended(double individualProbability)
{
    var probability = 1.0;

    for (var i = 0; i < numberOfAppointments; i++)
    {
        probability *= individualProbability;
    }

    return probability;
}

Console.WriteLine($"If an individual has a probability of {candidateIndividualProbability} of going to the appointment,");
Console.WriteLine($"the probability that all appointments are kept is {probabilityOfAllAttended}.");
