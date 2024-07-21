# QuantumForge Game Engine

QuantumForge is my attempt at writing my own game engine as a side project. This project serves as a learning experience to understand how a game engine works and because I enjoy a challenge.

## Project Structure

The solution consists of two main projects:

1. **QuantumForgeEditor**: A WPF application for editing game assets and managing game projects.
2. **RenderEngine**: A static C++ library responsible for the core rendering functionality.

## Getting Started

### Prerequisites

- Visual Studio 2022 or later
- .NET 8.0 SDK
- C++ build tools for Visual Studio

### Setup

1. **Clone the repository:**

    ```sh
    git clone https://github.com/AllramEst83/CodedByKay.QuantumForge
    cd QuantumForge
    ```

2. **Open the solution in Visual Studio:**

    Open `CodedByKay.QuantumForge.sln` in Visual Studio.

3. **Build the solution:**

    - Ensure the solution configuration is set to `Debug` or `Release` and the platform is set to `x64`.
    - Build the solution by clicking on `Build > Build Solution` or pressing `Ctrl+Shift+B`.

## Project Configuration

### QuantumForgeEditor

The `QuantumForgeEditor` is a WPF project targeting .NET 8.0. It is configured to output to the `x64` folder.

### RenderEngine

The `RenderEngine` is a static C++ library and is also configured to output to the `x64` folder.

### Output Paths

- **Debug Builds**: `..\x64\Debug\`
- **Release Builds**: `..\x64\Release\`

The output paths are configured in the respective project files and are relative to the solution directory.

## Contributions

Contributions are welcome! If you find a bug or have a feature request, please open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [Apache-2.0 license](https://github.com/AllramEst83/CodedByKay.QuantumForge/blob/master/LICENSE.txt) file for details.

## Acknowledgements

Special thanks to the community and resources that have helped in the development of this project.

---

Happy coding!
