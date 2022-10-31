# AR Sounds Joel Zuzzi

Project made with Unity 2020.3.40f1

Using Vuforia 10.10.2

The project has been tested using a Samsung Galaxy S20

There are two scenes in the project:

- The AR 3D Sound

  This Scene is composed of 4 Panels:
  - Transform: A panel to move and rotate selected objects
  - Objects: A panel to select objects (wall, car or occluder)
  - Audio: A panel to change some sounds settings (Volume, blend, pitch and falloff and Toggle On/Off the Audio source)
  - Settings: A panel to change the rotation speed and the move speed (useful to try out Doppler effect)
  Plus there are 3 markers from the Vuforia Mars Database to use:
    - The Astronaut: Contains the sound source, (the sound source is activated only when you toggle the button in the settings)
    - The Oxyen: Contains a brick wall, which occludes the Sound Source
    - The Drone: Contains an occluder object that make disappear everything behind it

- The Classic 3D Sound
  This Scene Contains the same Panels previously mentioned, only values of speed changes to adapt to the scale of the scene

Notes:
- The occluder Object doesn't work in the classic 3D Sound, tried with different shader, even a hand made one and the shader used in AR 3D Sounds, but the occlusion never worked, probably due to some problems with Vulkan or OpenGl 3.0
- The falloff modification doesn't update
- It can happen that sometimes, using the settings panel prevents from switching to other panels, I think I fixed it (after multiple tries in build and in editor) so it should work, I don't know where does this comes from never had this probem before

