# SheeeeshEngine
SheeeshEngine stands as a video game engine conceived by Oriol Martin and Xiao Shan Costajussa, both students from CITM at Universitat Politècnica de Catalunya (UPC). 
The project aims to construct a game engine that is both user-friendly and well-optimized, tailored for the "VideoGame Engines" course in the 3rd year of our academic journey. In the short term, our plan is to implement essential features typical of a game engine, including tasks such as loading models and functioning within a 3D environment. Notably, we have also successfully incorporated an audio sub-system into the engine.

## Team Members:

### Xiao Shan Costajussa Bellver

![xiaoPic](https://github.com/xaitta/Animation-Combat/blob/main/docs/media/Mi%20cara.jpg)

Xiao Shan Costajussa is one of the team members, he worked on display options, bounding boxes, mouse picking, game objects logic, drag and drop and camera settings . We mainly worked all together.
* [GitHub Profile](https://github.com/xaitta)



### Oriol Martin Corella

![pauPic](https://github.com/arinWald/KaChowEngine/assets/99820809/9e08a22a-f9f9-4012-becc-eb139175f38b)


The other component of the group is Oriol Martin, he took care about configuration screen, console, camera movement, serialization, memory leaks,  viewports and audio integration. We mainly worked all together.


* [GitHub Profile](https://github.com/Urii98)
* [Linkedin Profile](https://www.linkedin.com/in/urimartincorella/)

## Main Core Sub-Systems

### Camera Controls
- **Right Click:** FPS free rotation.
- **Mouse Wheel UP/DOWN:** Zoom in and out.
- **Left Alt + Left Click:** Orbit around selected object.

While right-clicking:

- (Hold Shift for movement speed boost)
- **W:** Move forward
- **A:** Move Left
- **S:** Move backward
- **D:** Move Right
- **Q:** Move Up
- **E:** Move Down
- **F:** Focus on selected object.

### Inspector
Displays components and properties of selected GameObjects.

### Components
Various components available:

- **Transform:** Modify rotation, position, and scale.
- **Mesh:** Detailed mesh information.
- **Materials:** Manage textures and materials.
- **Camera:** Edit camera settings (FOV, Near/Far Distance).
- **Audio Source:** Set that gameobject as an Audio Source. Can select the music from the audio bank file.
- **Audio Listener:** Set that gameobject as an Audio Listener. Can listen the audio source if there's any.

### Drag & Drop
Simplify asset management through Drag & Drop:

- Drag and drop FBX files.
- Assign textures by dragging and dropping files.

### Mouse Picking
Select objects by clicking in the scene.

### Frustrum Culling
Shows only visible objects in the camera field of view.

### Guizmo
Transform object position, rotation, and scale using Guizmo. Note: Be cautious with parent transforms.

### Serialization
Basic serialization for saving/loading scene parameters:

- Ctrl + S to save.
- Button in the header menu.

### Audio Engine and Wwise
- Audio Listener and Source Components.
- Spatial 3D audio feature.
- Import SoundBanks for events: Play, Stop, Pause, Resume.

## Windows

### Configuration
Fine-tune settings for development and user experience:

- **Save and Load Config:** Buttons for saving and loading configuration.
- **FPS Histogram:** Real-time FPS display.
- **MS Histogram:** Frame time histogram.
- **Window:** Manage display settings.
- **View:** Activate/deactivate windows.
- **Camera:** Change frustum configuration.

### Rendering
Control rendering options:

- **Lighting:** Enable/disable lighting.
- **Cullface:** Control face culling.
- **Depth Test:** Toggle depth testing.
- **Color Material:** Customize material colors.
- **Wireframe:** Visualize in wireframe mode.
- **Textures 2D:** Manage and apply textures.
- **VSync:** Enable/disable vertical synchronization.
- **Brightness Slider:** Adjust scene brightness.
- **Bounding Boxes:** Toggle game object bounding boxes.

### Input
- **Mouse and Keyboard Inputs:** Display current input.

### Audio
- **Volume Slider:** Adjust volume.

### Objects
Create and manipulate objects:

- **Hierarchy:** List of GameObjects in the scene.
- **Inspector:** Customize GameObjects.

### Console
Central location for logs and messages.

### Viewports
Visualize Scene and Game Windows with Play, Pause, and Stop functionality.

## Audio sub-system
We had to implement the Audio core subsystem using WWise. It was useful for learning how Wwise SDK works.

### Two background music that could blend between each other in a loop:
We did this by basically controlling both the music options in WWise. WWise has many functionalities, including one that lets you create playlist for your sounds, so it’s as easy as creating a sequence and telling Wwise how to play them and in which order. When you do this, as soon as you play the music in the engine, the functions from Wwise have the information on how to play them and in which order.

![87e0aeb976375d098a16106a243e0844](https://github.com/xaitta/Animation-Combat/blob/main/docs/media/Gif2.gif)

### Spatial audio
Be able to listen the sound effects/music depending on the listener´s position. This is also done easily by the WWise SDK, but you have to do some code aswell. In the WWise application, you have to go to the “Positioning” tab and check the 3D Spatialization aswell as the Attenuation. With this options, WWise generates the soundbanks ready for 3D audio. But this is not it, you have to go to the source code and implement a position and orientation for the listener, so WWise knows how to calculate the distance. We did this with a simple function that asks for 2 parameters: the ID from the gameobject and it´s position. Once you call the function correctly, WWise will register the gameobject’s position and will know how to treat it.

![58ccce0e350b8671b06730baa0deb0ca](https://github.com/xaitta/Animation-Combat/blob/main/docs/media/Gif1.gif)

### Extra funcionalities
- Sound options: Change volume and activate/desactivate components (mute). This options control the audio so you don’t have to do it via code, volume ranges from 0 to 100.

## Video demo

This video demonstrates how the Audio System works, and the whole engine too.

[SheeeeshEngine Video Demo](https://drive.google.com/file/d/1dB1DqsFI4pVtKO_DE170vTLDc09qDwb2/view?usp=sharing)

## Download the release here:

[Download](https://github.com/Urii98/SheeeshEngine/releases/tag/V.3)

## License

MIT License

Copyright (c) 2024 Oriol Martin Corella and Xiao Shan Costajussa Bellver

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
