include(FetchContent)

# Use the same MSVC runtime library setting as the application.
set(gtest_force_shared_crt ON CACHE BOOL "" FORCE)

FetchContent_Declare(
  googletest
  GIT_REPOSITORY https://github.com/google/googletest.git
  GIT_TAG        v1.14.0
)
FetchContent_MakeAvailable(googletest)

add_executable(FiveLettersTests FiveLettersCoreTests.cpp)
target_compile_features(FiveLettersTests PRIVATE cxx_std_20)
target_link_libraries(FiveLettersTests PRIVATE FiveLettersCore GTest::gtest_main)

include(GoogleTest)
gtest_discover_tests(FiveLettersTests)
