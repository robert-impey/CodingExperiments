# CMakeList.txt : CMake project for FiveLetters, include source and define
# project specific logic here.
#

include(FetchContent)

FetchContent_Declare(
  CLI11
  GIT_REPOSITORY https://github.com/CLIUtils/CLI11.git
  GIT_TAG        v2.5.0  # Use a stable release tag
)

FetchContent_MakeAvailable(CLI11)

# Add source to this project's executable.
add_executable (FiveLetters "FiveLetters.cpp" "FiveLetters.h")

if (CMAKE_VERSION VERSION_GREATER 3.12)
  set_property(TARGET FiveLetters PROPERTY CXX_STANDARD 20)
endif()

target_link_libraries(FiveLetters PRIVATE CLI11::CLI11)
