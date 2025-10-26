cmake_minimum_required(VERSION 4.0)
project(engine_testificate)

set(CMAKE_CXX_STANDARD 20)

set(GLEW_LIB_DIR "${CMAKE_SOURCE_DIR}/Dependencies/GLEW/lib/Release/x64")
set(GLFW_LIB_DIR "${CMAKE_SOURCE_DIR}/Dependencies/GLFW/lib-mingw-w64")

set(GLEW_INCLUDE_DIR "${CMAKE_SOURCE_DIR}/Dependencies/GLEW/include")
set(GLFW_INCLUDE_DIR "${CMAKE_SOURCE_DIR}/Dependencies/GLFW/include")

include_directories(${GLFW_INCLUDE_DIR})
include_directories(${GLEW_INCLUDE_DIR})

link_directories(${GLFW_LIB_DIR})
link_directories(${GLEW_LIB_DIR})

add_definitions(-DGLFW_STATIC)
add_definitions(-DGLEW_STATIC)

add_executable(${PROJECT_NAME}
        src/main.cpp)

target_link_libraries(${PROJECT_NAME}
        glfw3
        glew32s
        opengl32
        gdi32
        user32
        kernel32
)