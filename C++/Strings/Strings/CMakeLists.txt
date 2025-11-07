# CMakeList.txt : CMake project for Strings, include source and define
# project specific logic here.
#

include(FetchContent)

FetchContent_Declare(
  CLI11
  GIT_REPOSITORY https://github.com/CLIUtils/CLI11.git
  GIT_TAG        v2.5.0  # Use a stable release tag
)

FetchContent_MakeAvailable(CLI11)

add_executable (Strings "Strings.cpp" "Strings.h")

if (CMAKE_VERSION VERSION_GREATER 3.12)
  set_property(TARGET Strings PROPERTY CXX_STANDARD 20)
endif()

target_link_libraries(Strings PRIVATE CLI11::CLI11)
