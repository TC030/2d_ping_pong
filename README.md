# 2D Ping Pong (Warm-up Project)

A classic 2D Ping Pong game built with **Godot 4.7 (.NET C#)**. The core objective of this project is to master the Godot C# API, event-driven architecture (Signals), and production-grade cross-platform environment configurations.

## 📂 Project Structure

The project utilizes a strict separation of concerns and decoupled asset/source layout:

```text
2d_ping_pong/
├── assets/           # Static raw assets (Art, Audio)
│   └── sprites/      # Textures and visual sprites
├── scenes/           # Godot scene files (.tscn)
│   └── world.tscn    # Core game world scene
├── src/              # C# source files (.cs)
│   └── actors/       # Physics-based game entities (PlayerPaddle, Ball)
├── .editorconfig     
├── .gitattributes    
├── .gitignore        
├── 2d_ping_pong.sln  
└── project.godot
```

## 🛠️ Development Environment & Hardware Specs
- **OS:** Native Windows 11
- **IDE:** VS Code (C# Dev Kit & C# Tools for Godot)
- **Engine:** Godot 4.7-stable (Mono/NET Version)
- **SDK:** .NET 10 SDK
