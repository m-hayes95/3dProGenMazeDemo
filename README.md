
P2: Content Generation Demo

Google docs link: https://docs.google.com/document/d/1YQ0LrKpf53qUqNj-sa8-47BZj_TkGjTa3jpYa8mOsgM/edit?usp=sharing
Content generation

Procedural Generated content refers to algorithmic calculations used to create the illusion of randomly generated instances. The key benefit to using Procedural Generated content is to automatically create patterns from parameters/inputs. This allows resources (time, money, and mental energy) to be saved on designing large complex patterns such as natural terrain. As the patterns are created using parameters, they can be customised to make a unique and personalised experience for players. The randomness of the results can create unintended but interesting experiences for players. They can also provide some inspiration for developers to further edit or use the procedurally generated content to fit the vision of their project. Procedural Generated content can also be created in real-time, allowing developers to reduce the game's overall file size and decrease loading times, making a more enjoyable experience for players.

Procedural Generated Noise

Procedural Generated Noise is one such technique used to produce randomly generated content. Noise refers to a function that creates randomly generated values. It is a mathematical equation so the “randomness” is not truly random however, there are enough unique instances that make it appear so. As Noise uses an equation it is predictable and therefore controllable. Common use cases of Procedural Generated Noise are creating unique, natural feeling patterns such as terrain or textures.
In Unity, there are several tools used for implementing Procedural Generated Noise. One of which is Peril Noise.

Peril Noise 

Peril Noise is one of the most widely used Noise functions in the industry and is a powerful tool for developers due to the reasons provided above.
It uses a vector-based grid with random directions, however using the same length. The vectors are used to calculate gradients between each other. These gradients are then interpolated (the process of inserting something of different nature into an existing thing) to create a unique pattern similar to ones found in nature. 
Using this technique, developers can create natural-looking elements such as smoke, clouds or fire, textures such as rock or trees, or even height maps for the terrain. As they can be created in real-time, they can create unique experiences for each player.
As the Perlin noise is a mathematical algorithm, the results from inputted parameters are always the same and therefore controllable by developers. Developers can save the result of the Perlin noise method and reuse the generated element in other areas.

Implementing the Perlin Noise Method into a Project

In the referenced content generation demo, we are procedurally generating a mesh within a script called MeshGeneratorLand. This mesh will be used for the environment's terrain. The mesh is made from vertices that are created and each is given a value. Each value assigned to the newly created vertices is stored within an array. This is done using a for loop, which calls the nested code within, each time it loops. The start and end points of the for loop are defined within the for loop parameters. Here we start at 0 for the x and y axis and end at the pre-defined xSize and zSize integer variables. These integer variables define the total size of the terrain's X and Z axis and can be modified at any time to create a larger or smaller mesh. 

To implement the Perlin Noise algorithm to generate a mesh, we use the method Mathf.PerlinNoise. This method takes in two variables with float datatypes and applies them to the Perlin Noise algorithm to create a result. The two values within the content generation demo are the current z and x values within the for loop. These values are then multiplied by a float variable defined as perlinNoiseMultipler for the X and Z values, to make the resulting noise value smoother. The result from the Perlin noise algorithm is then multiplied to exaggerate the outcome’s effect. The value is stored within a temporary float variable called perlinValueY as we only want this value for the height of the current vertices. Finally, we define a new vertices vector 3 value for the current vertices within the array. This value is provided by the current x value for the x-axis, the current z value for the z-axis and the Perlin noise value for the current y-axis. 
As a result, we now have a generated terrain with a predefined x and z value for the length and depth of the terrain and a random value for the height on each of the vertices throughout the terrain.

Why use the Perlin Noise Method?

The purpose of the content generation demo is to switch through terrains, trying to find the perfect view for the client.
Using the Perlin Noise method to create a random height value throughout the terrain mesh, creates a natural feeling terrain. Landscapes within nature vary dramatically throughout and re-creating this feeling one tile at a time will take a large number of recourses and time. Therefore, creating a script to generate a unique, natural-feeling terrain to use for our projects is much more efficient. As the algorithm provides the exact same results every time, if a preferred terrain is found it can be reused in another area of the project.
My current implementation uses a mesh renderer which takes up a lot of recourse when it becomes larger, using the terrain object with terrain data component would be a less computationally expensive option for larger terrains. However, for smaller more specific terrains, a mesh might be the better option as its vertices are easily viewable and can be more finely edited.
