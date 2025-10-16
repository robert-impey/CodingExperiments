# CMakeList.txt : CMake project for Strings, include source and define
# project specific logic here.
#
cmake_minimum_required (VERSION 3.31)

include(FetchContent)

FetchContent_Declare(
  CLI11
  GIT_REPOSITORY https://github.com/CLIUtils/CLI11.git
  GIT_TAG        v2.5.0  # Use a stable release tag
)

FetchContent_MakeAvailable(CLI11)

add_executable (Strings "Strings.cpp" "Strings.h")

target_link_libraries(Strings PRIVATE CLI11::CLI11)
