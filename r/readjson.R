# Read JSON from GitHub on user's repos
# Robert Impey 2016-06-12

setwd("~")

library(jsonlite)

dataDir <- 'data'
gitHubUser <- 'robert-impey'

if (!file.exists(dataDir)) {
  dir.create(dataDir)
}

gitHubJsonFile <- sprintf("%s/gitHub%s.json", dataDir, gitHubUser)

if (!file.exists(gitHubJsonFile)) {
  fileUrl <- sprintf('https://api.github.com/users/%s/repos', gitHubUser)
  download.file(fileUrl, destfile = gitHubJsonFile, method = "curl")
}

gitHubJson <- fromJSON(gitHubJsonFile)

print(gitHubJson['name'])
