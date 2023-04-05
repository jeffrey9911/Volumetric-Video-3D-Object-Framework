# **W23-Capstone VR&AR Unity**
This project simply provides a scene that the users can interact with 3D objects and Soar volumetric capture.

## **Environment setup**
Below are some tips for setting up the environment
### Oculus Quest
- Developer mode: First thing is to turn on the Developer Mode for Oculus Quest
![Developer mode](./$Externals/imgs/developer-mode.jpeg)
- [Meta Quest Developer Hub](https://developer.oculus.com/documentation/unity/ts-odh/#set-up): A software that helps the system connect to Oculus Quest.
### Unity
- Unity Editor: Android target platform.

![Unity Editor](./$Externals/imgs/unity-editor-modules.png)
- [Unity Oculus Integration SDK](https://developer.oculus.com/downloads/package/unity-integration/): An all-in-one Unity Package. The one used in this project is provided: [here]()

![Unity Editor](./$Externals/imgs/oculus-xr-plugin.png)
- [Unity XR Plug-in Management](https://docs.unity3d.com/Packages/com.unity.xr.management@4.3/manual/index.html): A Unity plug-in that can be found in Unity Package Manager.

![Unity Editor](./$Externals/imgs/xr-plugin-management.png)
- Project Settings
    - Player:
    
    ![Unity Editor](./$Externals/imgs/player-settings-others.png)
    - XR Plug-in Management:
    
    ![Unity Editor](./$Externals/imgs/xr-plugin-management-setting.png)
    - Oculus: Do NOT use Low Overhead Mode while Soar SDK is setup to URP (Universal Render Pipeline) mode
    
    ![Unity Editor](./$Externals/imgs/oculus-setting.png)
### Soar SDK
- Soar Unity Package: An all-in-one Unity Package for Soar SDK. The one used in this project is provided: [here]()
