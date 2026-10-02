# CMakeList.txt : CMake project for FiveLetters, include source and define
# project specific logic here.
#

include(FetchContent)

FetchContent_Declare(
  CLI11
  GIT_REPOSITORY https://github.com/CLIUtils/CLI11.git
  GIT_TAG        v2.7.2
)

FetchContent_MakeAvailable(CLI11)

# Keep the task processing library independent of the command-line interface so
# it can be linked by both the application and the tests.
add_library(FiveLettersCore "FiveLettersCore.cpp" "FiveLettersCore.h")
target_compile_features(FiveLettersCore PUBLIC cxx_std_20)
target_include_directories(FiveLettersCore PUBLIC ${CMAKE_CURRENT_SOURCE_DIR})

add_executable (FiveLetters "FiveLetters.cpp" "FiveLetters.h")

if (CMAKE_VERSION VERSION_GREATER 3.12)
  set_property(TARGET FiveLetters PROPERTY CXX_STANDARD 20)
endif()

target_link_libraries(FiveLetters PRIVATE CLI11::CLI11 FiveLettersCore)
