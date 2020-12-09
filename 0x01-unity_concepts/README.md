![](https://upload.wikimedia.org/wikipedia/commons/8/8a/Official_unity_logo.png)

# 0x01. Unity - Concepts

## Learning Objectives
At the end of this project, you are expected to be able to explain to anyone, without the help of Google:

## General
* What is a GameObject
* What is a Component
* What is a Prefab
* What is a Tag
* What is a Layer
* How to create and change the properties of a GameObject
* How to create a Prefab
* How to add Tags and Layers
* Why is it important to name GameObjects and assets clearly and organize your project hierarchy
* What are gameplay and game mechanics and how do they relate to developing any kind of interactive experience

## Requirements

### General
* A README.md file, at the root of the folder of the project
* Use Unity’s default .gitignore in your holbertonschool-unity directory
* Push the entire project folder 0x01-unity_concepts to your repo, including .meta files
* Scenes and project assets such as Materials must be named and organized as described in the tasks
* No scripts are allowed for this project 

### Tasks

| **Filename** | **Description** |
|---|---|
| [0. Floor plans ](./0-floor.unity/) | Create a new 3D Unity project called 0x01-unity_concepts. Save your new scene as 0-floor. Create a new Cube GameObject named Floor with the given Transform properties  |
| [1. On the ball ](./1-ball.unity/) | Duplicate 0-floor by selecting the scene in the Project window and either Edit > Duplicate from the Toolbar or CTRL / CMD + D. Rename the scene 1-ball and open it. Create a new Sphere GameObject named Ball with the given Transform properties  |
| [2. Colors! ](./ball.mat/) | Duplicate 1-ball, rename it 2-colors, and open it. Create a Materials folder in the Project window, then create a new material named floor. In the Inspector window, change the Albedo color to any color you like using the color picker. Assign the material to the Floor GameObject. |
| [Gravity is a harsh mistress ](./bounce/) | Duplicate 2-colors, rename it 3-gravity, and open it. Add a Rigidbody Component to the Ball GameObject. Press Play to see what happens. Wouldn’t it be better if the ball bounced when it fell? |
| [4. Prefabricated ](./Ball) | Duplicate 3-gravity, rename it 4-prefab, and open it. Create a new folder named Prefabs. Create a prefab from the Ball inside the new folder, then, using the prefab, add four more instance of the Ball to the scene. Position and scale them any way you like.  |
| [5. Even more colors! ](./ball-*/) | Duplicate 4-prefab, rename it 5-more_colors, and open it. Change the colors of each ball so they are different hex colors as defined below. New materials should be named as listed below.  |
| [6. Tag yourself ](./6-tags.unity/) | Duplicate 5-more_colors, rename it 6-tags, and open it. Add a tag to all Ball objects called Obstacles.  |

#### Follow me 💬

| Authors | GitHub | Twitter | Linkedin |
| :---: | :---: | :---: | :---: |
| Maria Fernanda Crespo | [mfcrespo](https://github.com/mfcrespo) | [@mafe_crespo](https://twitter.com/mafe_crespo) | [mariafernandacrespo](https://www.linkedin.com/in/mariafernandacrespo) |

### License
*`0x01. Unity - Unity Concepts` is open source and therefore free to download and use without permission.*

<a href="url"><img src="https://www.holbertonschool.com/holberton-logo.png" align="middle" width="100" height="30"></a>

##### Holberton School – Advanced Program – AR/VR
##### December, 2020. Cali, Colombia
